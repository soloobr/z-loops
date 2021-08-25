using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Processos : Form
    {

        bool bPopCombo, cadastrar;

        string idcli, idVendedor, idresponsavel, nomeresponsavel, idCorretora, idCorretor, idempreendimentos, idagenciaimovel, idprograma, Status, valor, svalorimovel, svalorfinanciado;
        //private int cadastrar = 0;
        //private int newProgressValue;

        public Form_Cadastro_Processos()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            bPopCombo = false;
        }
        public void setLabel(string statuslbl)
        {
            lblstatus.Text = statuslbl;
        }
        internal void setidUserLoged(string idresp)
        {
            if (idresp != null)
            {
                idresponsavel = idresp;
            }
            //if (nomefunc != null)
            //{
            //    nomeresponsavel = nomefunc;
            //}
        }

        public event Action ProcessoSalvo;
        private void Form_Cadastro_Documentos_Load(object sender, EventArgs e)
        {
            var pctr = new Button();
            pctr.Size = new Size(22, ComboBoxClient.ClientSize.Height + 2);
            pctr.Dock = DockStyle.Right;
            pctr.Cursor = Cursors.Default;
            pctr.Image = Properties.Resources.procurar16;
            pctr.FlatStyle = FlatStyle.Flat;
            pctr.FlatAppearance.BorderSize = 3;
            pctr.AutoSize = false;
            pctr.ForeColor = Color.White;
            //pctr.FlatAppearance.BorderSize = 0;
            pctr.Click += pctr_Click;
            //pctr.Click += new EventHandler(pctr_Click);

            ComboBoxClient.Controls.Add(pctr);


            var btnvendedor = new Button();
            btnvendedor.Size = new Size(22, textnomevendedor.ClientSize.Height + 2);
            btnvendedor.Dock = DockStyle.Right;
            btnvendedor.Cursor = Cursors.Default;
            btnvendedor.Image = Properties.Resources.procurar16;
            btnvendedor.FlatStyle = FlatStyle.Flat;
            btnvendedor.FlatAppearance.BorderSize = 3;
            btnvendedor.AutoSize = false;
            btnvendedor.ForeColor = Color.White;
            //pctr.FlatAppearance.BorderSize = 0;
            btnvendedor.Click += btnvendedor_Click;
            //pctr.Click += new EventHandler(pctr_Click);

            textnomevendedor.Controls.Add(btnvendedor);



            //this.clientesTableAdapter.Fill(this.dS_Clientes.Clientes);

            //var btn = new Button();

            //idresponsavel = "1";
            //idCorretora = "1";
            //idCorretor = "1";
            Status = "Lançado";

            ComboBoxClient.Text = "";
            txtStatusCPF.Text = "";
            ComboBoxClient.Select();
            this.ActiveControl = ComboBoxClient;
            ComboBoxClient.Focus();

            // tabControl.TabPages.Remove(tabcartorio);
            //tabControl.TabPages.Remove(tabdoc);

            #region Valor Imovel
            valor = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorimovel.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorimovel.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorimovel.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorimovel.Text.StartsWith("0,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorimovel.Text.Contains("00,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorimovel.Text;
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorimovel.Select(valorimovel.Text.Length, 0);
            #endregion

            #region Valor Financiado
            valor = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorfinanciado.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorfinanciado.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorfinanciado.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorfinanciado.Text.StartsWith("0,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorfinanciado.Text.Contains("00,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorfinanciado.Text;
            valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorfinanciado.Select(valorfinanciado.Text.Length, 0);
            #endregion


        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvardoc_Click(object sender, EventArgs e)
        {
            string Vlimovel = valorimovel.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Replace(" ", "").Replace("00,", "");

            if (String.IsNullOrEmpty(ComboBoxClient.Text))
            {

                MessageBox.Show("Nome do Cliente necessario!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBoxClient.Select();
                ComboBoxClient.Focus();
                return;

            }
            else if (String.IsNullOrEmpty(textnomevendedor.Text))
            {
                MessageBox.Show("Nome do Vendedor necessario!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textnomevendedor.Select();
                textnomevendedor.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(comboBox_agencia.Text))
            {
                MessageBox.Show("Seleciona a Agência", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_agencia.Select();
                comboBox_agencia.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(comboBox_programa.Text))
            {
                MessageBox.Show("Seleciona o Programa", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_programa.Select();
                comboBox_programa.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(valorimovel.Text) || Vlimovel == "000")
            {

                MessageBox.Show("Valor do Imóvel Necessário!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valorimovel.Select();
                valorimovel.Focus();
                return;
            }
            else
            {

                pctr_Click(this, EventArgs.Empty);


                switch (cadastrar)
                {
                    case false:
                        svalorimovel = valorimovel.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                        svalorfinanciado = valorfinanciado.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Replace(" ", "").Replace("00,", ""); ;
                        LoginDaoComandos criarprocesso = new LoginDaoComandos();
                        criarprocesso.CriarProcesso(idcli, idVendedor, idresponsavel, idCorretora, idCorretor, idempreendimentos, idagenciaimovel, idprograma, svalorimovel, svalorfinanciado, Status);
                        MessageBox.Show(criarprocesso.mensagem, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (ProcessoSalvo != null)
                            ProcessoSalvo.Invoke();
                        Close();
                        break;
                    case true:

                        break;

                }
            }
        }
        private void LimparCampos()
        {
            //ComboBoxClient.Text = "";
            txtcpf.Clear();
            txtrg.Clear();
            txtnasc.Clear();
            txtemail.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtrenda.Clear();
            txtagencia.Clear();
            txtcontavendedor.Clear();
            txtStatusCPF.Text = "";
            txtciweb.Text = "";
            txtcadmut.Text = "";
            txtir.Text = "";
            txtfgts.Text = "";
        }
        private void LimparCamposVendedor()
        {
            //ComboBoxClient.Text = "";
            textnomevendedor.Text = "";
            textcnpjcpf.Text = "";
            textagenciavendedor.Text = "";
            txtcontavendedor.Text = "";
            textemailvendedor.Text = "";
            texttelefonevendedor.Text = "";
            textcelularvendedor.Text = "";
        }
        private async void pctr_Click(object sender, EventArgs e)
        {

            LimparCampos();
            //backgroundWorker.RunWorkerAsync();

            int chars = ComboBoxClient.Text.Length;

            if (chars >= 3)
            {
                LoginDaoComandos gett = new LoginDaoComandos();

                //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

                gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text);

                int cont = ComboBoxClient.Items.Count;

                if (cont == 1)
                {
                    bPopCombo = false;
                    Cliente[] myArray = gett.GetClientes(ComboBoxClient.Text).ToArray();
                    foreach (Cliente c in myArray)
                    {

                        idcli = c.Id_cliente;
                        ComboBoxClient.Text = c.Nome_cliente;
                        txtcpf.Text = c.CPF_cliente;
                        txtrg.Text = c.RG_cliente;
                        txtnasc.Text = c.Nascimento_cliente;
                        txtemail.Text = c.Email_cliente;
                        txttelefone.Text = c.Telefone_cliente;
                        txtcelular.Text = c.Celular_cliente;
                        txtrenda.Text = c.Renda_cliente;
                        txtagencia.Text = c.Agencia_cliente;
                        txtcontacliente.Text = c.Conta_cliente;
                        tabControl.Select();
                        tabControl.Focus();
                    }
                }
                else if (cont == 0)
                {
                    string message = "Não foram encontrados registro para:  " + ComboBoxClient.Text + " Deseja Cadastrar o Cliente?";
                    const string caption = "Cadastrar Cliente";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        cadastrar = true;
                        ComboBoxClient.Select();
                        ComboBoxClient.Focus();

                        Form_Dados_Cliente frm_Cadastro_cliente = new Form_Dados_Cliente();
                        frm_Cadastro_cliente.setTextNome(ComboBoxClient.Text);
                        frm_Cadastro_cliente.Show();
                    }
                    else
                    {
                        cadastrar = false;
                        LimparCampos();
                        ComboBoxClient.Select();
                        ComboBoxClient.Focus();
                        bPopCombo = false;
                    }

                }
                else
                {
                    if (bPopCombo)
                    {

                    }
                    else
                    {
                        ComboBoxClient.DroppedDown = true;
                    }


                }
            }
            else
            {
                MessageBox.Show("Favor digitar ao menos 3 Caracteres para persquisa", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboBoxClient.Select();
                ComboBoxClient.Focus();
            }

        }


        private async void btnvendedor_Click(object sender, EventArgs e)
        {

            //backgroundWorker.RunWorkerAsync();

            int chars = textnomevendedor.Text.Length;

            if (chars >= 3)
            {
                LoginDaoComandos gett = new LoginDaoComandos();

                //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

                gett.autoCompletarVendedor(textnomevendedor, textnomevendedor.Text);

                int cont = textnomevendedor.Items.Count;

                if (cont == 1)
                {
                    bPopCombo = false;
                    Vendedor[] myArray = gett.GetVendedores(textnomevendedor.Text).ToArray();
                    foreach (Vendedor v in myArray)
                    {

                        idVendedor = v.Id_vendedor;
                        textnomevendedor.Text = v.Nome_vendedor;
                        if (v.CNPJ_vendedor == "0")
                        {
                            textcnpjcpf.Text = v.CPF_vendedor;
                        }
                        else
                        {
                            textcnpjcpf.Text = v.CNPJ_vendedor;
                        }

                        textagenciavendedor.Text = v.Agencia_vendedor;
                        txtcontavendedor.Text = v.Conta_vendedor;
                        textemailvendedor.Text = v.Email_vendedor;
                        texttelefonevendedor.Text = v.Telefone_vendedor;
                        textcelularvendedor.Text = v.Celular_vendedor;
                        tabControl.Select();
                        tabControl.Focus();
                    }
                }
                else if (cont == 0)
                {
                    string message = "Não foram encontrados registro para:  " + textnomevendedor.Text + " Deseja Cadastrar o Vendedor?";
                    const string caption = "Cadastrar Vendedor";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.Yes)
                    {
                        //cadastrar = 1;
                        textnomevendedor.Select();
                        textnomevendedor.Focus();
                        //MessageBox.Show("Abriu");
                        Form_Cadastro_Vendedor frm_Cadastro_Vendedor = new Form_Cadastro_Vendedor();
                        frm_Cadastro_Vendedor.setTextNome(textnomevendedor.Text);
                        frm_Cadastro_Vendedor.Show();
                    }
                    else
                    {
                        //cadastrar = 0;
                        LimparCamposVendedor();
                        textnomevendedor.Select();
                        textnomevendedor.Focus();
                    }


                    //MessageBox.Show("Não foram encontrados registro para:  " + ComboBoxClient.Text + "Deseja Cadastrar o Cliente?");


                }
                else
                {
                    if (bPopCombo)
                    {

                    }
                    else
                    {
                        textnomevendedor.DroppedDown = true;
                    }


                }
            }
            else
            {
                MessageBox.Show("Favor digitar Almenos 3 Caracteres para persquisa");
                textnomevendedor.Select();
                textnomevendedor.Focus();
            }

        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {


                //CHECK FOR CANCELLATION FIRST
                if (backgroundWorker.CancellationPending)
                {
                    //CANCEL
                    e.Cancel = true;
                }
                else
                {
                    simulateHeavyJobAsync();
                    backgroundWorker.ReportProgress(i);
                }
            }



        }

        private async void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //display("You have Cancelled");
                // progressBar1.Value = 0;

                ProgressBar.Visible = false;
            }
            else
            {
                //MessageBox.Show("Work completed successfully");
                ProgressBar.Value = 0;
                //ProgressBar.Visible = false;



                int cont = ComboBoxClient.Items.Count;

                if (cont == 1)
                {
                    LoginDaoComandos gett = new LoginDaoComandos();
                    //await Task.Run(() => gett.GetClientes(ComboBoxClient.Text).ToArray());
                    Cliente[] myArray = await Task.Run(() => gett.GetClientes(ComboBoxClient.Text).ToArray());
                    foreach (Cliente c in myArray)
                    {

                        idcli = c.Id_cliente;
                        ComboBoxClient.Text = c.Nome_cliente;
                        //txtnomecli.Text = c.Nome_cliente;
                        txtcpf.Text = c.CPF_cliente;
                        txtrg.Text = c.RG_cliente;
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
                        txtagencia.Text = c.Agencia_cliente;
                        txtcontacliente.Text = c.Conta_cliente;
                        tabControl.Select();
                        tabControl.Focus();
                    }
                }
                else if (cont == 0)
                {
                    LimparCampos();
                    MessageBox.Show("Não foram encontrados registro para:  " + ComboBoxClient.Text);
                    ComboBoxClient.Select();
                    ComboBoxClient.Focus();

                }
                else
                {
                    ComboBoxClient.DroppedDown = true;

                }


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            backgroundWorker.RunWorkerAsync();
            //        

            //        Thread backgroundThread = new Thread(
            //    new ThreadStart(() =>
            //    {
            //        LoginDaoComandos gett = new LoginDaoComandos();

            //        //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

            //        gett.GetClientes( ComboBoxClient.Text);

            //        //for (int n = 0; n < 100; n++)
            //        //{
            //        //    Thread.Sleep(50);
            //        //    ProgressBar.Value = n;
            //        //}

            //        MethodInvoker mi = new MethodInvoker(() => ProgressBar.Value = newProgressValue);
            //        if (ProgressBar.InvokeRequired)
            //        {
            //            ProgressBar.Invoke(mi);
            //        }
            //        else
            //        {
            //            mi.Invoke();
            //        }

            //        MessageBox.Show("Thread completed!");
            //        ProgressBar.Value = 0;
            //    }
            //));
            //        backgroundThread.Start();
        }

        private void textnomevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bPopCombo = true;
                btnvendedor_Click(this, EventArgs.Empty);
            }
        }

        private void textnomevendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (bPopCombo)
            {
                textnomevendedor.DroppedDown = true;
                bPopCombo = false;
            }
        }

        private void textnomevendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = this.textnomevendedor.GetItemText(this.textnomevendedor.SelectedItem);
            //MessageBox.Show(selected);

            String selecionado = this.textnomevendedor.GetItemText(this.textnomevendedor.SelectedItem);

            LoginDaoComandos gett = new LoginDaoComandos();
            Vendedor[] myArray = gett.GetVendedores(selecionado).ToArray();
            foreach (Vendedor v in myArray)
            {
                idVendedor = v.Id_vendedor;
                textnomevendedor.Text = v.Nome_vendedor;
                if (v.CNPJ_vendedor == "")
                {
                    textcnpjcpf.Text = v.CPF_vendedor;
                }
                else
                {
                    textcnpjcpf.Text = v.CNPJ_vendedor;
                }

                textagenciavendedor.Text = v.Agencia_vendedor;
                txtcontavendedor.Text = v.Conta_vendedor;
                textemailvendedor.Text = v.Email_vendedor;
                texttelefonevendedor.Text = v.Telefone_vendedor;
                textcelularvendedor.Text = v.Celular_vendedor;
                tabControl.Select();
                tabControl.Focus();
            }
        }

        private void ComboBoxClient_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textnomevendedor_KeyDown(object sender, KeyEventArgs e)
        {
            //int chars = textnomevendedor.Text.Length;

            //if (chars >= 3)
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    //if (e.KeyChar == (char)Keys.Enter)
            //    {
            //        //btnvendedor_Click(this, EventArgs.Empty);

            //        #region Load Combobox
            //        LoginDaoComandos getcombo = new LoginDaoComandos();

            //        int numberOfRecords = getcombo.GetDataVendedor(textnomevendedor.Text).Rows.Count;

            //        if (numberOfRecords > 1)
            //        {
            //            bPopCombo = true;
            //        }
            //        else if (numberOfRecords == 1)
            //        {
            //            bPopCombo = false;
            //            ///                   MessageBox.Show(" = 1");
            //        }
            //        else
            //        {
            //            MessageBox.Show("não encontrado clientes");
            //            return;
            //        }
            //        #endregion


            //    }
            //}
        }

        private void valorproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorimovel.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void valorproduto_Leave(object sender, EventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "");
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void valorfinanciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorfinanciado.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void valorfinanciado_KeyUp(object sender, KeyEventArgs e)
        {
            valor = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorfinanciado.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorfinanciado.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorfinanciado.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorfinanciado.Text.StartsWith("0,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorfinanciado.Text.Contains("00,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorfinanciado.Text;
            valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorfinanciado.Select(valorfinanciado.Text.Length, 0);
        }

        private void valorfinanciado_Leave(object sender, EventArgs e)
        {
            valor = valorfinanciado.Text.Replace("R$", "");
            valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tabimovel"])//your specific tabname
            {

            }
            if (tabControl.SelectedTab == tabControl.TabPages["tabvendedor"])//your specific tabname
            {
                textnomevendedor.Select();
            }
        }

        private void comboBox_agencia_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_agencia_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_agencia.DataSource is null)
            {
                comboBox_agencia.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_agencia.DataSource = gettpross.GetDataAgencia();
                comboBox_agencia.DisplayMember = "Agencia";
                comboBox_agencia.ValueMember = "Id";
                //comboBox_agencia.Text = "";
                #endregion

                comboBox_agencia.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }

        }

        private void comboBox_programa_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_programa.DataSource is null)
            {
                comboBox_programa.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_programa.DataSource = gettpross.GetDataPrograma();
                comboBox_programa.DisplayMember = "Descricao";
                comboBox_programa.ValueMember = "Id";
                //comboBox_agencia.Text = "";
                #endregion
                comboBox_programa.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_programa_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_programa_DisplayMemberChanged(object sender, EventArgs e)
        {


        }

        private void comboBox_agencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcorretora_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtcorretora.DataSource is null)
            {
                txtcorretora.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                txtcorretora.DataSource = gettpross.GetDataCorretora();
                txtcorretora.DisplayMember = "Descricao";
                txtcorretora.ValueMember = "Id";
                //txtcorretora.Text = "";
                #endregion

                txtcorretora.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_agencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idagenciaimovel = comboBox_agencia.SelectedValue.ToString();
        }

        private void comboBox_programa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idprograma = comboBox_programa.SelectedValue.ToString();
        }

        private void comboBox_corretor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idCorretor = comboBox_corretor.SelectedValue.ToString();
        }

        private void comboBox_corretor_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_corretor.DataSource is null)
            {
                comboBox_corretor.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_corretor.DataSource = gettpross.GetDataCorretores();
                comboBox_corretor.DisplayMember = "Nome";
                comboBox_corretor.ValueMember = "Id";
                //comboBox_corretor.Text = "";
                #endregion

                comboBox_corretor.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_empreendimentos_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_empreendimentos.DataSource is null)
            {
                comboBox_empreendimentos.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
                comboBox_empreendimentos.DisplayMember = "Descricao";
                comboBox_empreendimentos.ValueMember = "Id";
                comboBox_empreendimentos.MaxDropDownItems = 10;
                //comboBox_empreendimentos.Text = "";
                #endregion

                comboBox_empreendimentos.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtcorretora_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCorretora = txtcorretora.SelectedValue.ToString();
        }

        private void comboBox_empreendimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idempreendimentos = comboBox_empreendimentos.SelectedValue.ToString();
        }

        private void comboBox_corretor_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCorretor = comboBox_corretor.SelectedValue.ToString();
        }

        private void valorproduto_KeyUp(object sender, KeyEventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorimovel.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorimovel.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorimovel.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorimovel.Text.StartsWith("0,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorimovel.Text.Contains("00,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorimovel.Text;
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorimovel.Select(valorimovel.Text.Length, 0);
        }

        private async Task simulateHeavyJobAsync()
        {
            Thread backgroundThread = new Thread(new ThreadStart(() =>
            {
                LoginDaoComandos gett = new LoginDaoComandos();
                //await Task.Run(() => gett.GetClientes(ComboBoxClient.Text).ToArray());
                //LoginDaoComandos gett = new LoginDaoComandos();
                //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

                gett.GetClientes(ComboBoxClient.Text);
            })); backgroundThread.Start();

            //LoginDaoComandos gett = new LoginDaoComandos();

            //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));
        }
        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void btncancelardoc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bPopCombo = true;
                pctr_Click(this, EventArgs.Empty);
            }
        }

        private void ComboBoxClient_KeyUp(object sender, KeyEventArgs e)
        {
            if (bPopCombo)
            {
                ComboBoxClient.DroppedDown = true;
                bPopCombo = false;
            }
        }

        private void ComboBoxClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selected = this.ComboBoxClient.GetItemText(this.ComboBoxClient.SelectedItem);
            //MessageBox.Show(selected);

            String selecionado = this.ComboBoxClient.GetItemText(this.ComboBoxClient.SelectedItem);

            LoginDaoComandos gett = new LoginDaoComandos();
            Cliente[] myArray = gett.GetClientes(selecionado).ToArray();
            foreach (Cliente c in myArray)
            {
                idcli = c.Id_cliente;
                ComboBoxClient.Text = c.Nome_cliente;
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
                txtrg.Text = c.RG_cliente;
                txtagencia.Text = c.Agencia_cliente;
                txtcontacliente.Text = c.Conta_cliente;
                tabControl.Select();
                tabControl.Focus();
            }
        }
    }
}
