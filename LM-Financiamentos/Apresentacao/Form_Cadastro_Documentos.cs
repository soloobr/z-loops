using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Documentos : Form
    {
        MySqlDataReader dr;
        public Form_Cadastro_Documentos()
        {
            InitializeComponent();
        }
        public void setLabel( string statuslbl)
        {
            lblstatus.Text = statuslbl;
        }
        private void lblcliente_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabdoc_Click(object sender, EventArgs e)
        {

        }

        private void Form_Cadastro_Documentos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dS_Clientes.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusCPF'. Você pode movê-la ou removê-la conforme necessário.
            this.statusCPFTableAdapter.Fill(this.dS_Combobox.StatusCPF);
            txtnomecli.Text = "";
            txtStatusCPF.Text = "";
            txtnomecli.Select();
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();
        }

        private void txtnasc_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnasc.Text))
            {
                DateTime entryDate;
                if (DateTime.TryParseExact(txtnasc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out entryDate))
                {
                    // further actions for validations
                }
                else
                {
                    setTooltip(txtnasc, "txtEntryDate", "Invalid date format date must be formatted to dd/MM/yyyy");
                    txtnasc.Focus();
                }
            }
            else
            {
                setTooltip(txtnasc, "txtEntryDate", "Please provide entry date in the format of dd/MM/yyyy");
                txtnasc.Focus();
            }
        }

        private void setTooltip(Control Ctrl, string CtrlCaption, string ToolTipMsg)
        {
            ToolTip tt1 = new ToolTip();
            tt1.AutoPopDelay = 5000;
            tt1.InitialDelay = 1000;
            tt1.ReshowDelay = 500;
            tt1.ShowAlways = false;
            tt1.SetToolTip(Ctrl, CtrlCaption);
            tt1.Show(ToolTipMsg, Ctrl, 5000);
        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnomecli_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcpf_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtnomecli_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginDaoComandos gett = new LoginDaoComandos();
            Cliente  cli = new Cliente();

            cli = gett.GetCliente(txtnomecli.Text);

            txtemail.Text = cli.Email_cliente;
            txtnasc.Text = cli.Nascimento_cliente;
            txtcpf.Text = cli.CPF_cliente;
            txtrenda.Text = cli.Renda_cliente;
            txtStatusCPF.Text = cli.StatusCPF_cliente;
            tabControl.Select();
            tabControl.Focus();
            // .Columns[2]..ToString();

            //MessageBox.Show("Cliente " +DAL.DS_ClientesTableAdapters.ClientesTableAdapter +" Selecionado", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
