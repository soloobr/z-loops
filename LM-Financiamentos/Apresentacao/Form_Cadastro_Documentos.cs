using ComponentFactory.Krypton.Toolkit;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Documentos : Form
    {

        bool bPopCombo;

        string idcli;
        private int cadastrar = 0;
        private int newProgressValue;

        public Form_Cadastro_Documentos()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            bPopCombo = false;
        }
        public void setLabel(string statuslbl)
        {
            lblstatus.Text = statuslbl;
        }

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

            ComboBoxClient.Text = "";
            txtStatusCPF.Text = "";
            ComboBoxClient.Select();
            this.ActiveControl = ComboBoxClient;
            ComboBoxClient.Focus();
        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvardoc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ComboBoxClient.Text))
            { 

                MessageBox.Show("Nome do Cliente necessario!");
                ComboBoxClient.Select();
                ComboBoxClient.Focus();

            }else
	        {
                //string message = "Não foram encontrados registro para:  " + ComboBoxClient.Text + " Deseja Cadastrar o Cliente?";
                //const string caption = "Cadastrar Cliente";
                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.YesNo,
                //                             MessageBoxIcon.Question);

                //// If the no button was pressed ...
                //if (result == DialogResult.Yes)
                //{
                //    //MessageBox.Show("Abriu");
                //    Form_Cadastro_cliente frm_Cadastro_cliente = new Form_Cadastro_cliente();
                //    //frm_Cadastro_cliente.Name;
                //    //frm_Cadastro_cliente.setLabel(func, ola);
                //    frm_Cadastro_cliente.Show();
                //}
                //else
                //{
                //    LimparCampos();
                //    ComboBoxClient.Select();
                //    ComboBoxClient.Focus();
                //}

                //pctr_Click(this, EventArgs.Empty);
                //Console.Write("Enter your selection (1, 2, or 3): ");
                //string s = Console.ReadLine();
                //int n = Int32.Parse(s);

                pctr_Click(this, EventArgs.Empty);

                switch (cadastrar)
                {
                    case 1:
                        //MessageBox.Show("Current value is Yes");
                        cadastrar = 0;


                        break;
                    case 0:
                        //MessageBox.Show("Current value is No");
                        
                        if (String.IsNullOrEmpty(comboBox_analise.Text))
                        {
                            MessageBox.Show("Status da Análise é necessario!, caso não tenha feito selecione Não Consultado.");
                            tabControl.SelectedIndex = 1;

                            comboBox_analise.Select();
                            comboBox_analise.Focus();
                            comboBox_analise.DroppedDown = true;
                        }
                        else if (String.IsNullOrEmpty(comboBox_statuseng.Text))
                        {
                            MessageBox.Show("Status da Engenharia é necessario!, caso não tenha feito selecione Não Consultado.");
                            tabControl.SelectedIndex = 1;
                            comboBox_statuseng.Select();
                            comboBox_statuseng.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_agencia.Text))
                        {
                            MessageBox.Show("Agência é necessario!, caso não tenha feito selecione Não Consultado.");
                            tabControl.SelectedIndex = 1;
                            comboBox_agencia.Select();
                            comboBox_agencia.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_programa.Text))
                        {
                            MessageBox.Show("Programa é necessario!, caso não tenha feito selecione Não Consultado.");
                            tabControl.SelectedIndex = 1;
                            comboBox_programa.Select();
                            comboBox_programa.Focus();
                        }
                        else if (String.IsNullOrEmpty(valorproduto.Text))
                        {
                            MessageBox.Show("Valor do Ímovel é necessario!, caso não tenha feito selecione Não Consultado.");
                            tabControl.SelectedIndex = 1;
                            valorproduto.Select();
                            valorproduto.Focus();
                        }
                        else if (String.IsNullOrEmpty(txtcorretora.Text))
                        {
                            MessageBox.Show("Corretora é necessario!, caso não tenha, selecione Não Tem");
                            tabControl.SelectedIndex = 1;
                            txtcorretora.Select();
                            txtcorretora.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_corretor.Text))
                        {
                            MessageBox.Show("Corretor é necessario!, caso não tenha, selecione Não Tem");
                            tabControl.SelectedIndex = 1;
                            comboBox_corretor.Select();
                            comboBox_corretor.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_empreendimentos.Text))
                        {
                            MessageBox.Show("Empreendimento é necessario!, caso não tenha, selecione Não Tem");
                            tabControl.SelectedIndex = 1;
                            comboBox_empreendimentos.Select();
                            comboBox_empreendimentos.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_nomecartorio.Text))
                        {
                            MessageBox.Show("Nome do Cartório é necessario!, caso não Enviado, selecione Não Enviado");
                            tabControl.SelectedIndex = 2;
                            comboBox_nomecartorio.Select();
                            comboBox_nomecartorio.Focus();
                        }
                        else if (String.IsNullOrEmpty(comboBox_statuscartorio.Text))
                        {
                            MessageBox.Show("Status Cartório é necessario!, caso não Enviado, selecione Não Enviado");
                            tabControl.SelectedIndex = 2;
                            comboBox_statuscartorio.Select();
                            comboBox_statuscartorio.Focus();
                        }

                        else
                        {
                            MessageBox.Show("Cadastro efetuado com Sucesso!");
                        }

                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection.");
                        break;
                }
            }




            //LoginDaoComandos updatecliente = new LoginDaoComandos();

            //updatecliente.UpdateClienteProcesso(idcli, txtStatusCPF.Text, txtciweb.Text, txtcadmut.Text, txtir.Text, txtfgts.Text);

            //MessageBox.Show(updatecliente.mensagem);
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
            textagencia.Text = "";
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
                    Cliente[] myArray = gett.GetClientes(ComboBoxClient.Text).ToArray();
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
                        //txtStatusCPF.Text = c.StatusCPF_cliente;
                        //txtciweb.Text = c.StatusCiweb_cliente;
                        //txtcadmut.Text = c.StatusCadmut_cliente;
                        //txtir.Text = c.StatusIR_cliente;
                        //txtfgts.Text = c.StatusFGTS_cliente;
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

                    // If the no button was pressed ...
                    if (result == DialogResult.Yes)
                    {
                        //cadastrar = 1;
                        ComboBoxClient.Select();
                        ComboBoxClient.Focus();
                        //MessageBox.Show("Abriu");
                        Form_Cadastro_cliente frm_Cadastro_cliente = new Form_Cadastro_cliente();
                        frm_Cadastro_cliente.setTextNome(ComboBoxClient.Text);
                        frm_Cadastro_cliente.Show();
                    }
                    else
                    {
                        //cadastrar = 0;
                        LimparCampos();
                        ComboBoxClient.Select();
                        ComboBoxClient.Focus();
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
                        ComboBoxClient.DroppedDown = true;
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Favor digitar Almenos 3 Caracteres para persquisa");
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
                    Cliente[] myArray = gett.GetVendedor(textnomevendedor.Text).ToArray();
                    foreach (Cliente c in myArray)
                    {

                        //idcli = c.Id_cliente;
                        textnomevendedor.Text = c.Nome_cliente;
                        if (c.CNPJ_cliente == "")
                        {
                            textcnpjcpf.Text = c.CPF_cliente;
                        }
                        else
                        {
                            textcnpjcpf.Text = c.CNPJ_cliente;
                        }
                        
                        textagencia.Text = c.Agencia_cliente;
                        txtcontavendedor.Text = c.Conta_cliente;
                        textemailvendedor.Text = c.Email_cliente;
                        texttelefonevendedor.Text = c.Telefone_cliente;
                        textcelularvendedor.Text = c.Celular_cliente;

                       // txtrg.Text = c.RG_cliente;
                        //txtnasc.Text = c.Nascimento_cliente;


                        
                        //txtrenda.Text = c.Renda_cliente;
                        //txtStatusCPF.Text = c.StatusCPF_cliente;
                        //txtciweb.Text = c.StatusCiweb_cliente;
                        //txtcadmut.Text = c.StatusCadmut_cliente;
                        //txtir.Text = c.StatusIR_cliente;
                        //txtfgts.Text = c.StatusFGTS_cliente;

                       
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
                        Form_Cadastro_cliente frm_Cadastro_cliente = new Form_Cadastro_cliente();
                        frm_Cadastro_cliente.setTextNome(textnomevendedor.Text);
                        frm_Cadastro_cliente.Show();
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

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
    
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
        private async Task simulateHeavyJobAsync()
        {
            Thread backgroundThread = new Thread(
        new ThreadStart(() =>
        {
            LoginDaoComandos gett = new LoginDaoComandos();
            //await Task.Run(() => gett.GetClientes(ComboBoxClient.Text).ToArray());
            //LoginDaoComandos gett = new LoginDaoComandos();
            //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

            gett.GetClientes(ComboBoxClient.Text);


        }
    ));
            backgroundThread.Start();

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

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
            LoginDaoComandos gett = new LoginDaoComandos();
            Cliente[] myArray = gett.GetClientes(ComboBoxClient.Text).ToArray();
            foreach (Cliente c in myArray)
            {
                idcli = c.Id_cliente;
                ComboBoxClient.Text = c.Nome_cliente;
                //txtnomecli.Text = c.Nome_cliente;
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

        //private Task ProcessData(List<Tuple<int, string>> list, IProgress<ProgressReport> progress)
        //{
        //    int index = 1;
        //    int totalprogress = list.Count;
        //    var progressreport = new ProgressReport();

        //    return Task.Run(() => {
        //        for (int i = 0; i < totalprogress; i++)
        //        {
        //            Tuple<int, string> temp = list[i];
        //            int id = temp.Item1;
        //            string address = temp.Item2;
        //            //label_autoupdate.Text = string.Format("Processing ...{0}", address);
        //            //excuteAutoUpdate(id, address);
        //            progressreport.PercentComplete = i++ * 100 / totalprogress;
        //            progress.Report(progressreport);
        //            Thread.Sleep(10);
        //        }
        //        // groupBox_autoupdate.Visible = false;

        //    });
        //}
    }
}
