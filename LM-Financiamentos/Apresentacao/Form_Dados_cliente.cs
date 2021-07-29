using LMFinanciamentos.DAL;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_cliente : Form
    {
        String sexo, status;
        
        
        public Form_Dados_cliente()
        {
            InitializeComponent();
        }

        public void setTextNome(String sNome)
        {
            txtnomecli.Text = sNome;

        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Dados_cliente_Load(object sender, EventArgs e)
        {
            
            //txtnomecli.Select();
            //txtnomecli.ScrollToCaret();
            //txtnomecli.Focus();

            txtnomecli.Select(txtnomecli.Text.Length, 0);
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (checkBox_Masculino.Checked)
            {
                sexo = "Masculino"; 
            } else if (checkBox_Feminino.Checked)
            { 
                sexo = "Feminino";
            }
            else
            {
                sexo = "";
            }

            status = "Ativo";

            LoginDaoComandos inserircliente = new LoginDaoComandos();

            inserircliente.CadastrarCliente(txtnomecli.Text, txtemail.Text, txttelefone.Text, txtcelular.Text, txtcpf.Text, txtStatusCPF.Text, txtciweb.Text, txtcadmut.Text, txtir.Text, txtfgts.Text, txtrg.Text,
                txtnasc.Text, sexo, status, txtrenda.Text);

            MessageBox.Show(inserircliente.mensagem);
        }
    }
}
