using LMFinanciamentos.DAL;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_cliente : Form
    {
        String sexo, status;
        
        
        public Form_Controle_cliente()
        {
            InitializeComponent();
        }


        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_cliente_Load(object sender, EventArgs e)
        {
            LoginDaoComandos getclientes = new LoginDaoComandos();
            dgv_clientes.AutoGenerateColumns = false;
            dgv_clientes.DataSource = getclientes.GetClientes("%");
            dgv_clientes.Refresh();
            //txtnomecli.Select();
            //txtnomecli.ScrollToCaret();
            //txtnomecli.Focus();

            //txtnomecli.Select(txtnomecli.Text.Length, 0);
            //this.ActiveControl = txtnomecli;
            //txtnomecli.Focus();
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

        }


    }
}
