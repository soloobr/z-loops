using LMFinanciamentos.DAL;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_cliente : Form
    {
        string sexo, status;
        string valor;



        public Form_Cadastro_cliente()
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

        private void Form_Cadastro_cliente_Load(object sender, EventArgs e)
        {
            
            //txtnomecli.Select();
            //txtnomecli.ScrollToCaret();
            //txtnomecli.Focus();

            txtnomecli.Select(txtnomecli.Text.Length, 0);
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();

            Settxtrenda();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtrendacli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacli.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacli_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacli.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendacli.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacli.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacli.Text.StartsWith("0,"))
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacli.Text.Contains("00,"))
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacli.Text;
            txtrendacli.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacli.Select(txtrendacli.Text.Length, 0);
        }
        private void Settxtrenda()
        {
            valor = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacli.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendacli.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacli.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacli.Text.StartsWith("0,"))
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacli.Text.Contains("00,"))
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacli.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacli.Text;
            txtrendacli.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacli.Select(txtrendacli.Text.Length, 0);
        }
        private void txtrendacli_Leave(object sender, EventArgs e)
        {
            valor = txtrendacli.Text.Replace("R$", "");
            txtrendacli.Text = string.Format("{0:C}", Convert.ToDouble(valor));
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
