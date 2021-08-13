using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Vendedor : Form
    {
        String sexo, status, idvendedor;
        public string consultar;
        int vendedorselecionado;
        int contgrid, contgridlast;
        public Form_Controle_Vendedor()
        {
            InitializeComponent();
            //dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.Format = "D";
        }


        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_Vendedor_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getvendedor = new LoginDaoComandos();
            //dgv_vendedores.Columns[3].DefaultCellStyle.Format = "d";
            dgv_vendedores.AutoGenerateColumns = false;
            dgv_vendedores.DataSource = getvendedor.GetVendedores("%");
            //this.dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_vendedores.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_vendedores.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action VendedorSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Vendedor frm_cadastro_vendedor = new Form_Cadastro_Vendedor();

            frm_cadastro_vendedor.VendedorSalvo += new Action(frm_cadastro_vendedor_VendedorSalvo);
            //frm_cadastro_vendedors.setLabel("Em Preenchimento");
            frm_cadastro_vendedor.Show();
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

        private void Form_Controle_Vendedor_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_vendedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgv_vendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Vendedor frm_dados_vendedor = new Form_Dados_Vendedor();
            frm_dados_vendedor.setIdVendedor(dgv_vendedores.SelectedRows[0].Cells["id"].Value.ToString());
            //MessageBox.Show(dgv_vendedores.SelectedRows[0].Cells["id"].Value.ToString());
            vendedorselecionado = dgv_vendedores.CurrentCell.RowIndex;
            frm_dados_vendedor.VendedorSalvo += new Action(frm_dados_vendedor_VendedorSalvo);
            contgrid = dgv_vendedores.Rows.Count;
            frm_dados_vendedor.Show();
            Cursor = Cursors.Default;
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o número ou Nome do Vendedor para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getvendedor = new LoginDaoComandos();
                Vendedor[] myArray = getvendedor.GetVendedores(consultar).ToArray();
                bool verifica = false;

                foreach (Vendedor c in myArray)
                {
                    if (c.Id_vendedor != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_vendedores.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_vendedores.DataSource = getvendedor.GetVendedores(consultar);
                    dgv_vendedores.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Vendedor para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void dgv_vendedores_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dgv_vendedores.Rows[e.RowIndex].Selected = true;
        }

        private void dgv_vendedores_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_vendedores_CurrentCellChanged(object sender, EventArgs e)
        {


        }

        void frm_dados_vendedor_VendedorSalvo()
        {
            AtualizaGrid();
            contgridlast = dgv_vendedores.Rows.Count;

            if(contgrid  ==  contgridlast) 
            {
                MessageBox.Show(vendedorselecionado.ToString());
                dgv_vendedores.ClearSelection();
                dgv_vendedores.Rows[vendedorselecionado].Selected = true;
                dgv_vendedores.Rows[vendedorselecionado].Cells[0].Selected = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Vendedor frm_dados_vendedor = new Form_Dados_Vendedor();
            frm_dados_vendedor.setIdVendedor(dgv_vendedores.SelectedRows[0].Cells["id"].Value.ToString());
            vendedorselecionado = dgv_vendedores.CurrentCell.RowIndex;
            frm_dados_vendedor.VendedorSalvo += new Action(frm_dados_vendedor_VendedorSalvo);
            contgrid = dgv_vendedores.Rows.Count;
            frm_dados_vendedor.Show();
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            String idvendedorexclude = dgv_vendedores.SelectedRows[0].Cells["id"].Value.ToString();
            var result =  MessageBox.Show("Deseja Excluir o Vendedor: \n "+ dgv_vendedores.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?","excluir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                

                LoginDaoComandos deletevendedor = new LoginDaoComandos();

                if(deletevendedor.GetFotoVendedor(idvendedorexclude).Foto_vendedor != null)
                {
                    //MessageBox.Show("Tem foto");
                    deletevendedor.DeleteFotoVendedor(idvendedorexclude);
                    deletevendedor.DeleteVendedor(idvendedorexclude);
                    MessageBox.Show(deletevendedor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (VendedorSalvo != null)
                        VendedorSalvo.Invoke();
                    AtualizaGrid();
                }
                else
                {
                    deletevendedor.DeleteVendedor(idvendedorexclude);
                    MessageBox.Show(deletevendedor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (VendedorSalvo != null)
                        VendedorSalvo.Invoke();
                    AtualizaGrid();
                }


                
            }
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnclosvend_Click(object sender, EventArgs e)
        {
            Close();
        }

        void frm_cadastro_vendedor_VendedorSalvo()
        {
            AtualizaGrid();
    
            dgv_vendedores.ClearSelection();

            int nRowIndex = dgv_vendedores.Rows.Count - 1;
            //vendedorselecionado = dgv_vendedores.Rows.Count - 1;
            dgv_vendedores.Rows[nRowIndex].Selected = true;
            dgv_vendedores.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_vendedores.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getvendedores = new LoginDaoComandos();
            dgv_vendedores.DataSource = getvendedores.GetVendedores("%");


        }


    }
}
