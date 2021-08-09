using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_cliente : Form
    {
        String sexo, status, idcliente;
        public string consultar;

        public Form_Controle_cliente()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Form_Cadastro_cliente frm_cadastro_clientes = new Form_Cadastro_cliente();
            //frm_cadastro_clientes.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            //frm_cadastro_clientes.setLabel("Em Preenchimento");
            frm_cadastro_clientes.Show();
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

        private void Form_Controle_cliente_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_Dados_cliente frm_dados_clientes = new Form_Dados_cliente();
            //frm_dados_documentos.setIdProcess(dgv_process.Rows[1].Cells[0].Value.ToString());
            frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
            //frm_dados_clientes.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            //frm_dados_documentos.setIdProcess("1");
            frm_dados_clientes.Show();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
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
        }


    }
}
