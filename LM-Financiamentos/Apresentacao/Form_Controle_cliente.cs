using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Cliente : Form
    {
        String sexo, status, idcliente;
        public string consultar;
        int clienteselecionado;

        public Form_Controle_Cliente()
        {
            InitializeComponent();
            dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "D";
        }


        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_cliente_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getclientes = new LoginDaoComandos();
            //dgv_clientes.Columns[3].DefaultCellStyle.Format = "d";
            dgv_clientes.AutoGenerateColumns = false;
            dgv_clientes.DataSource = getclientes.GetClientes("%");
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_clientes.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_clientes.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action ClienteSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Cliente frm_cadastro_clientes = new Form_Cadastro_Cliente();

            frm_cadastro_clientes.ClienteSalvo += new Action(frm_cadastro_clientes_ClienteSalvo);
            //frm_cadastro_clientes.setLabel("Em Preenchimento");
            frm_cadastro_clientes.Show();
            Cursor = Cursors.Default;
        }

        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == (char)Keys.Return)
            {
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void Form_Controle_Cliente_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente();
            frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
            clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
            frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
            frm_dados_clientes.Show();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o número ou Nome do Cliente para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getclientes = new LoginDaoComandos();
                Cliente[] myArray = getclientes.GetClientes(consultar).ToArray();
                bool verifica = false;

                foreach (Cliente c in myArray)
                {
                    if (c.Id_cliente != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_clientes.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_clientes.DataSource = getclientes.GetClientes(consultar);
                    dgv_clientes.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Clientes para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        private void dgv_clientes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dgv_clientes.Rows[e.RowIndex].Selected = true;
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_clientes_CurrentCellChanged(object sender, EventArgs e)
        {


        }

        void frm_dados_clientes_ClienteSalvo()
        {
            AtualizaGrid();

            dgv_clientes.ClearSelection();
            dgv_clientes.Rows[clienteselecionado].Selected = true;
            dgv_clientes.Rows[clienteselecionado].Cells[0].Selected = true;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente();
            frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
            clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
            frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
            frm_dados_clientes.Show();
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            String idclienteexclude = dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString();
            var result = MessageBox.Show("Deseja Excluir o Cliente: \n " + dgv_clientes.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deletecliente = new LoginDaoComandos();

                if (deletecliente.GetFotoCliente(idclienteexclude).Foto_cliente != null)
                {
                    //MessageBox.Show("Tem foto");
                    deletecliente.DeleteFotoCliente(idclienteexclude);
                    deletecliente.DeleteCliente(idclienteexclude);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ClienteSalvo != null)
                        ClienteSalvo.Invoke();

                    AtualizaGrid();
                    Cursor = Cursors.Default;
                }
                else
                {
                    deletecliente.DeleteCliente(idclienteexclude);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ClienteSalvo != null)
                        ClienteSalvo.Invoke();
                    AtualizaGrid();
                    Cursor = Cursors.Default;
                }



            }
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoginDaoComandos getfunclientes = new LoginDaoComandos();
            dgv_clientes.AutoGenerateColumns = false;
            dgv_clientes.DataSource = getfunclientes.GetClientes("%");
            dgv_clientes.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();

            Cursor = Cursors.Default;
        }

        void frm_cadastro_clientes_ClienteSalvo()
        {
            AtualizaGrid();

            dgv_clientes.ClearSelection();

            int nRowIndex = dgv_clientes.Rows.Count - 1;
            //clienteselecionado = dgv_clientes.Rows.Count - 1;
            dgv_clientes.Rows[nRowIndex].Selected = true;
            dgv_clientes.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_clientes.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getclientes = new LoginDaoComandos();
            dgv_clientes.DataSource = getclientes.GetClientes("%");


        }


    }
}
