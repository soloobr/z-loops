using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Documentos : Form
    {
        //MySqlDataReader dr;
        string idcli;
        //private int uiChanges = 0;
        public Form_Cadastro_Documentos()
        {
            InitializeComponent();
        }
        public void setLabel(string statuslbl)
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
            /*
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox1.Cartorio'. Você pode movê-la ou removê-la conforme necessário.
            this.cartorioTableAdapter.Fill(this.dS_Combobox1.Cartorio);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox1.StatusCartorio'. Você pode movê-la ou removê-la conforme necessário.
            this.statusCartorioTableAdapter.Fill(this.dS_Combobox1.StatusCartorio);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox2.Empreendimentos'. Você pode movê-la ou removê-la conforme necessário.
            this.empreendimentosTableAdapter.Fill(this.dS_Combobox2.Empreendimentos);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox2.Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.vendedorTableAdapter.Fill(this.dS_Combobox2.Vendedor);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox2.Corretores'. Você pode movê-la ou removê-la conforme necessário.
            this.corretoresTableAdapter.Fill(this.dS_Combobox2.Corretores);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox2.Corretora'. Você pode movê-la ou removê-la conforme necessário.
            this.corretoraTableAdapter.Fill(this.dS_Combobox2.Corretora);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.Programa'. Você pode movê-la ou removê-la conforme necessário.
            this.programaTableAdapter.Fill(this.dS_Combobox.Programa);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.Agencia'. Você pode movê-la ou removê-la conforme necessário.
            this.agenciaTableAdapter.Fill(this.dS_Combobox.Agencia);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox1.StatusEng'. Você pode movê-la ou removê-la conforme necessário.
            this.statusEngTableAdapter.Fill(this.dS_Combobox1.StatusEng);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusAnalise'. Você pode movê-la ou removê-la conforme necessário.
            this.statusAnaliseTableAdapter.Fill(this.dS_Combobox.StatusAnalise);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusFGTS'. Você pode movê-la ou removê-la conforme necessário.
            this.statusFGTSTableAdapter.Fill(this.dS_Combobox.StatusFGTS);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusIR'. Você pode movê-la ou removê-la conforme necessário.
            this.statusIRTableAdapter.Fill(this.dS_Combobox.StatusIR);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusCadmut'. Você pode movê-la ou removê-la conforme necessário.
            this.statusCadmutTableAdapter.Fill(this.dS_Combobox.StatusCadmut);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusCiweb'. Você pode movê-la ou removê-la conforme necessário.
            this.statusCiwebTableAdapter.Fill(this.dS_Combobox.StatusCiweb);*/
            // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.dS_Clientes.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'dS_Combobox.StatusCPF'. Você pode movê-la ou removê-la conforme necessário.
            //this.statusCPFTableAdapter.Fill(this.dS_Combobox.StatusCPF

            //var btn = new Button();
            //btn.Size = new Size(25, txtnomecli.ClientSize.Height + 2);
            // btn.Location = new Point(txtnomecli.ClientSize.Width - btn.Width, -1);
            //btn.Dock = DockStyle.Right;
            //btn.Anchor = AnchorStyles.Left;
            //btn.Padding = new Padding(5);
            //btn.Cursor = Cursors.Default;
            //btn.BringToFront();
            //btn.Image = Properties.Resources.soma10;
            //btn.FlatStyle = FlatStyle.Flat;
            //btn.ForeColor = Color.White;
            //btn.FlatAppearance.BorderSize = 1;
            //btn.FlatAppearance.BorderColor = Color.Red; 

            //txtnomecli.Controls.Add(btn);

            var btn = new Button();

            txtnomecli.Text = "";
            txtStatusCPF.Text = "";
            txtnomecli.Select();
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();
        }

        private static readonly int SEARCH_BUTTON_WIDTH = 25;

        private void ConfigureSearchBox()
        {
            var btn = new Button();
            btn.Size = new Size(SEARCH_BUTTON_WIDTH, txtnomecli.ClientSize.Height + 2);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.mais16;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += btn_Click;
            txtnomecli.Controls.Add(btn);
            this.AcceptButton = btn;
            // Send EM_SETMARGINS to prevent text from disappearing underneath the button
            SendMessage(txtnomecli.Handle, 0xd3, (IntPtr)2, (IntPtr)(btn.Width << 16));
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
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
            Cliente cli = new Cliente();

            cli = gett.GetCliente(txtnomecli.Text);

            idcli = cli.Id_cliente;
            txtcpf.Text = cli.CPF_cliente;
            txtnasc.Text = cli.Nascimento_cliente;
            txtemail.Text = cli.Email_cliente;
            txttelefone.Text = cli.Telefone_cliente;
            txtcelular.Text = cli.Celular_cliente;
            txtrenda.Text = cli.Renda_cliente;
            txtStatusCPF.Text = cli.StatusCPF_cliente;
            txtciweb.Text = cli.StatusCiweb_cliente;
            txtcadmut.Text = cli.StatusCadmut_cliente;
            txtir.Text = cli.StatusIR_cliente;
            txtfgts.Text = cli.StatusFGTS_cliente;
            tabControl.Select();
            tabControl.Focus();
            // .Columns[2]..ToString();

            //MessageBox.Show("Cliente " +DAL.DS_ClientesTableAdapters.ClientesTableAdapter +" Selecionado", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnsalvardoc_Click(object sender, EventArgs e)
        {
            LoginDaoComandos updatecliente = new LoginDaoComandos();

            updatecliente.UpdateClienteProcesso(idcli, txtStatusCPF.Text, txtciweb.Text, txtcadmut.Text, txtir.Text, txtfgts.Text);

            MessageBox.Show(updatecliente.mensagem);
        }

        private void lbl_topo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btncancelardoc_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_TextChanged(object sender, EventArgs e)
        {
            //uiChanges++;
            //if (uiChanges > 4)
            //{
            //    btnprocura.Visible = true;
            //    uiChanges = 0;
            //}
            //else if (uiChanges < 4)
            //{
            //    btnprocura.Visible = false;
            //}
        }

        private void txtnomecli_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonContextMenu1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnproc_Click(object sender, EventArgs e)
        {
            LoginDaoComandos gett = new LoginDaoComandos();
            //Cliente cli = new Cliente();

            //cli = gett.GetCliente(txtnomecli.Text);
            //cli = gett.GetClientes(txtnomecli.Text);


            //if (gett.GetCliente(txtnomecli.Text) != null && gett.GetCliente(txtnomecli.Text).Rows.Count > 1)
            //if (gett.GetCliente(txtnomecli.Text) != null )
            //{
            //idcli = cli.Id_cliente;
            //    txtnomecli.Text = cli.Nome_cliente;
            //    txtcpf.Text = cli.CPF_cliente;
            //    txtnasc.Text = cli.Nascimento_cliente;
            //    txtemail.Text = cli.Email_cliente;
            //    txttelefone.Text = cli.Telefone_cliente;
            //    txtcelular.Text = cli.Celular_cliente;
            //    txtrenda.Text = cli.Renda_cliente;
            //    txtStatusCPF.Text = cli.StatusCPF_cliente;
            //    txtciweb.Text = cli.StatusCiweb_cliente;
            //    txtcadmut.Text = cli.StatusCadmut_cliente;
            //    txtir.Text = cli.StatusIR_cliente;
            //    txtfgts.Text = cli.StatusFGTS_cliente;
            //    tabControl.Select();
            //    tabControl.Focus();
            // }
            //else
            // {

            //}

            //if (gett.GetClientes(txtnomecli.Text).Count > 1)
            //{
                var source = new AutoCompleteStringCollection();

                Cliente[] myArray = gett.GetClientes(txtnomecli.Text).ToArray();
            int count = 0;
                foreach (Cliente c in myArray)
                {
                
                    //source.AddRange(new string[]
                    //source.Add(c.Nome_cliente);
                //txtnomecli.Text = c.Nome_cliente;
                //txttelefone.Text = c.Telefone_cliente;
                //if (c.Nome_cliente != null)
                //{
                    count = count+1;
                //}
                listBox1.Items.Add(count);
                listBox1.Items.Add(c.Nome_cliente);
            }
                
            //MessageBox.Show();
            if (count == 1)
            {
                //MessageBox.Show("maior");

                foreach (Cliente c in myArray)
                {
                    
                    idcli = c.Id_cliente;
                    txtnomecli.Text = c.Nome_cliente;
                    txtcpf.Text = c.CPF_cliente;
                    txtnasc.Text = c.Nascimento_cliente;
                    txtemail.Text = c.Email_cliente;
                    txttelefone.Text = c.Telefone_cliente;
                    txtcelular.Text = c.Celular_cliente;
                    txtrenda.Text = c.Renda_cliente;
                    txtStatusCPF.Text = c.StatusCPF_cliente;
                    txtciweb.Text = c.StatusCiweb_cliente;
                    txtcadmut.Text = c.StatusCadmut_cliente;
                    txtir.Text = c.StatusIR_cliente;
                    txtfgts.Text = c.StatusFGTS_cliente;
                    tabControl.Select();
                    tabControl.Focus();
                    count = 0;
                }
            }else
            {
                foreach (Cliente c in myArray)
                {

                    source.Add(c.Nome_cliente);

                    txtnomecli.AutoCompleteCustomSource = source;
                    txtnomecli.Controls. = true;
                    count = 0;
                }

            }


            //}
            //else
            // {
            //    MessageBox.Show("Menor");

            //  }

        }
    }
}
