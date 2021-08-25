using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Cliente : Form
    {
        String sexo, status, idCliente, valor, renda, nascimento, arquivo, RG, CPF, telefone, celular;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase, cj, cj1, cj2, cj3;


        public Form_Dados_Cliente()
        {
            InitializeComponent();
        }
        public void setIdCliente(string idcliente)
        {
            idCliente = idcliente;
        }
        public void setTextNome(String sNome)
        {
            txtnomecli.Text = sNome;

        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtrendacli_Leave(object sender, EventArgs e)
        {
            valor = txtrendacli.Text.Replace("R$", "");
            txtrendacli.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtnomecli.Text == "")
            {
                MessageBox.Show("Campo Nome do Cliente é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecli.Select();
                Cursor = Cursors.Default;
                return;
            }
            #region Telefone
            if (string.IsNullOrEmpty(txttelefone.Text))
            {
                if (string.IsNullOrEmpty(txtcelular.Text))
                {


                    MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttelefone.Select();
                    Cursor = Cursors.Default;
                    return;
                }

            }
            txtcelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtcelular.Text != "")
            {
                celular = txtcelular.Text;

            }
            txttelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txttelefone.Text != "")
            {
                telefone = txttelefone.Text;
            }
            #endregion

            if (checkBox_Masculino.Checked)
            {
                sexo = "Masculino";
            }
            else if (checkBox_Feminino.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "";
            }
            if (checkBox_status.Checked)
            {
                status = "Ativo";
            }
            else
            {
                status = "Inativo";
            }

            if (txtcpf.Text == "")
            {
                MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpf.Select();
                Cursor = Cursors.Default;
                return;
            }
            CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);


            if (txtrg.Text == "")
            {
                RG = "0";
            }
            else
            {
                RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);
            }
            //String RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);

            DateTime dataa;
            DateTime.TryParse(txtnasc.Text + " " + "00:00:00", out dataa);

            DateTime datanasc = dataa;

            //DateTime datanasc = DateTime.Parse(nascimento);



            String renda = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

            LoginDaoComandos insertfotocliente = new LoginDaoComandos();
            if (excluirimage == "Update")
            {
                if (arquivobase == false)
                {
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotocliente.InsertFotoCliente(idCliente, imgContent, txtnomecli.Text);
                }
                else
                {
                    fsObj = File.OpenRead(arquivo);
                    // MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotocliente.UpdateFotoCliente(idCliente, imgContent);
                }
                if (insertfotocliente.mensagem == "OK")
                {

                }
                else
                {
                    MessageBox.Show(insertfotocliente.mensagem, "Atualizando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (excluirimage == "Excluir")
            {
                LoginDaoComandos excluircliente = new LoginDaoComandos();
                excluircliente.DeleteFotoCliente(idCliente);
                if (excluircliente.mensagem == "Excluido")
                {

                }
                else
                {
                    MessageBox.Show(insertfotocliente.mensagem, "Apagando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoginDaoComandos updatecliente = new LoginDaoComandos();

            updatecliente.UpdateConta(idCliente, txtagenciacliente.Text, txtcontacliente.Text, "C");
            if (updatecliente.mensagem == "Erro")
            {
                updatecliente.InsertConta(idCliente, txtagenciacliente.Text, txtcontacliente.Text, "C","0","0");
            }


            updatecliente.UpdateCliente(idCliente, txtnomecli.Text, txtemail.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoes.Text);

            Cursor = Cursors.Default;

            MessageBox.Show(updatecliente.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btn_editar.Visible = true;
            splitter1.Visible = false;
            btn_cancelar.Visible = false;
            splitter2.Visible = false;
            btn_salvar.Visible = false;


            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();

            if (ClienteSalvo != null)
                ClienteSalvo.Invoke();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = true;
            splitter1.Visible = false;
            splitter2.Visible = false;
            btn_cancelar.Visible = false;
            btn_salvar.Visible = false;
            splitter3.Visible = true;
            btn_excluir.Visible = true;

            excluirimage = "";

            DesabilitarEdicao();
            LoadDadosCliente();
            tabControl.SelectedTab = tabControl.TabPages["tabcliente"];

            //Close();
        }

        internal void setFoto(byte[] foto_Cli)
        {
            // throw new NotImplementedException();
            if (foto_Cli != null)
            {
                MemoryStream stmBLOBData = new MemoryStream(foto_Cli);
                img_foto.Image = Image.FromStream(stmBLOBData);
            }

        }

        private void Form_Dados_cliente_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabconjuge);
            tabControl.TabPages.Remove(tabconjuge1);
            tabControl.TabPages.Remove(tabconjuge2);
            tabControl.TabPages.Remove(tabconjuge3);

            LoadDadosCliente();

            if (cj == true)
            {
                tabControl.TabPages.Insert(1, tabconjuge);
                LoadDadosConjuge(idCliente, "0");
                gbrenda.Visible = true;
                lbl0.Visible = true;
                lblnomeclirenda.Visible = true;
                lblnomeclirenda.Text = txtnomecli.Text;
                lblrendacli.Visible = true;
                lblrendacli.Text = txtrendacli.Text;
                Resumerenda(txtrendacli.Text);
                int Rendacli = Int32.Parse(valor.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", ""));
                //int Rendacli = int.Parse(valor);


                lbl01.Visible = true;
                lblnomecj1.Visible = true;
                lblnomecj1.Text = txtnomeconjuge.Text;
                lblrendacj1.Visible = true;
                Resumerenda(txtrendacj.Text);
                 int Rendacj = Int32.Parse(valor.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", ""));
                //int Rendacj = int.Parse(valor);

                lblrendacj1.Text = txtrendacj.Text;

                lblrendabruta.Visible = true;
                txtrendatotal.Visible = true;
                


                
                int total = Rendacli + Rendacj;
                txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(total.ToString()));
            }
            if (cj1 == true)
            {
                tabControl.TabPages.Insert(2, tabconjuge1);
                LoadDadosCJ(idCliente, "1");
            }
            if (cj2 == true)
            {
                tabControl.TabPages.Insert(3, tabconjuge2);
                LoadDadosCJ1(idCliente, "2");
            }
            if (cj3 == true)
            {
                tabControl.TabPages.Insert(4, tabconjuge3);
                LoadDadosCJ2(idCliente, "3");
            }
        }
        public void Resumerenda(String renda)
        {
            valor = renda.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                renda = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                renda = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                renda = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (renda.StartsWith("0,"))
                {
                    renda = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (renda.Contains("00,"))
                {
                    renda = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    renda = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = renda;
        }
        public void LoadDadosCliente()
        {
            Cursor = Cursors.WaitCursor;
            Cliente cliente = null;

            LoginDaoComandos getcliente = new LoginDaoComandos();
            cliente = getcliente.GetCliente(idCliente);

            txtnomecli.Text = cliente.Nome_cliente;
            txtcpf.Text = cliente.CPF_cliente;
            txtrg.Text = cliente.RG_cliente;
            txtnasc.Text = cliente.Nascimento_cliente;
            txtemail.Text = cliente.Email_cliente;
            txttelefone.Text = cliente.Telefone_cliente;
            txtcelular.Text = cliente.Celular_cliente;
            txtrendacli.Text = cliente.Renda_cliente;
            txtagenciacliente.Text = cliente.Agencia_cliente;
            txtcontacliente.Text = cliente.Conta_cliente;
            txtobservacoes.Text = cliente.OBS_cliente;

            if (cliente.Sexo_cliente == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (cliente.Sexo_cliente == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (cliente.Status_cliente == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Cliente Ativo";
            }

            if (cliente.Status_cliente == "Inativo")
            {
                checkBox_status.Text = "Cliente Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Cliente
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
            #endregion

            cj = cliente.Conjuge_cliente;


            txtnomecli.Select(txtnomecli.Text.Length, 0);
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();
            Cursor = Cursors.Default;
        }
        public void LoadDadosConjuge(String idcliente, String idconjuge)
        {
            Cursor = Cursors.WaitCursor;
            Conjuge conj = null;

            LoginDaoComandos getconjuge = new LoginDaoComandos();
            conj = getconjuge.GetConjuge(idcliente, idconjuge);

            txtnomeconjuge.Text = conj.Nome_conjuge;
            txtcpfcj.Text = conj.CPF_conjuge;
            txtrgcj.Text = conj.RG_conjuge;
            txtnasccj.Text = conj.Nascimento_conjuge;
            txtemailcj.Text = conj.Email_conjuge;
            txttelefonecj.Text = conj.Telefone_conjuge;
            txtcelularcj.Text = conj.Celular_conjuge;
            txtrendacj.Text = conj.Renda_conjuge;
            txtagenciacj.Text = conj.Agencia_conjuge;
            txtcontacj.Text = conj.Conta_conjuge;
            txtobservacaocj.Text = conj.OBS_conjuge;

            if (conj.Sexo_conjuge == "Masculino")
            {
                checkBox_Masculinocj.Checked = true;

            }
            else if (conj.Sexo_conjuge == "Feminino")
            {
                checkBox_Femininocj.Checked = true;
            }


            if (conj.Status_conjuge == "Ativo")
            {
                checkBox_statuscj.Checked = true;
                checkBox_statuscj.ForeColor = System.Drawing.Color.Blue;
                checkBox_statuscj.Text = "Conjuge Ativo";
            }

            if (conj.Status_conjuge == "Inativo")
            {
                checkBox_statuscj.Text = "Conjuge Inativo";
                checkBox_statuscj.ForeColor = System.Drawing.Color.Red;
                checkBox_statuscj.Checked = false;
            }
            #region Valor Renda Conjuge
            valor = txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendacj.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacj.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacj.Text.StartsWith("0,"))
                {
                    txtrendacj.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacj.Text.Contains("00,"))
                {
                    txtrendacj.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacj.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacj.Text;
            txtrendacj.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacj.Select(txtrendacj.Text.Length, 0);
            #endregion

            cj1 = conj.Conjuge_conjuge;


            txtnomeconjuge.Select(txtnomeconjuge.Text.Length, 0);
            this.ActiveControl = txtnomeconjuge;
            txtnomeconjuge.Focus();
            Cursor = Cursors.Default;
        }
        public void LoadDadosCJ(String idcliente, String idconjuge)
        {
            Cursor = Cursors.WaitCursor;
            Conjuge conj = null;

            LoginDaoComandos getconjuge = new LoginDaoComandos();
            conj = getconjuge.GetConjuge(idcliente, idconjuge);

            txtnomecj1.Text = conj.Nome_conjuge;
            txtcpfcj1.Text = conj.CPF_conjuge;
            txtrgcj1.Text = conj.RG_conjuge;
            txtnasccj1.Text = conj.Nascimento_conjuge;
            txtemailcj1.Text = conj.Email_conjuge;
            txttelefonecj1.Text = conj.Telefone_conjuge;
            txtcelularcj1.Text = conj.Celular_conjuge;
            txtrendacj1.Text = conj.Renda_conjuge;
            txtagenciacj1.Text = conj.Agencia_conjuge;
            txtcontacj1.Text = conj.Conta_conjuge;
            txtobservacaocj1.Text = conj.OBS_conjuge;

            if (conj.Sexo_conjuge == "Masculino")
            {
                checkBox_Masculinocj1.Checked = true;

            }
            else if (conj.Sexo_conjuge == "Feminino")
            {
                checkBox_Femininocj1.Checked = true;
            }


            if (conj.Status_conjuge == "Ativo")
            {
                checkBox_statuscj1.Checked = true;
                checkBox_statuscj1.ForeColor = System.Drawing.Color.Blue;
                checkBox_statuscj1.Text = "Conjuge Ativo";
            }

            if (conj.Status_conjuge == "Inativo")
            {
                checkBox_statuscj1.Text = "Conjuge Inativo";
                checkBox_statuscj1.ForeColor = System.Drawing.Color.Red;
                checkBox_statuscj1.Checked = false;
            }
            #region Valor Renda Conjuge
            valor = txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj1.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendacj1.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacj1.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacj1.Text.StartsWith("0,"))
                {
                    txtrendacj1.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacj1.Text.Contains("00,"))
                {
                    txtrendacj1.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacj1.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacj1.Text;
            txtrendacj1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacj1.Select(txtrendacj1.Text.Length, 0);
            #endregion

            cj2 = conj.Conjuge_conjuge;


            txtnomecj1.Select(txtnomecj1.Text.Length, 0);
            this.ActiveControl = txtnomecj1;
            txtnomecj1.Focus();
            Cursor = Cursors.Default;
        }
        public void LoadDadosCJ1(String idcliente, String idconjuge)
        {
            Cursor = Cursors.WaitCursor;
            Conjuge conj = null;

            LoginDaoComandos getconjuge = new LoginDaoComandos();
            conj = getconjuge.GetConjuge(idcliente, idconjuge);

            txtnomecj2.Text = conj.Nome_conjuge;
            txtcpfcj2.Text = conj.CPF_conjuge;
            txtrgcj2.Text = conj.RG_conjuge;
            txtnasccj2.Text = conj.Nascimento_conjuge;
            txtemailcj2.Text = conj.Email_conjuge;
            txttelefonecj2.Text = conj.Telefone_conjuge;
            txtcelularcj2.Text = conj.Celular_conjuge;
            txtrendacj2.Text = conj.Renda_conjuge;
            txtagenciacj2.Text = conj.Agencia_conjuge;
            txtcontacj2.Text = conj.Conta_conjuge;
            txtobservacaocj2.Text = conj.OBS_conjuge;

            if (conj.Sexo_conjuge == "Masculino")
            {
                checkBox_Masculinocj2.Checked = true;

            }
            else if (conj.Sexo_conjuge == "Feminino")
            {
                checkBox_Femininocj2.Checked = true;
            }


            if (conj.Status_conjuge == "Ativo")
            {
                checkBox_statuscj2.Checked = true;
                checkBox_statuscj2.ForeColor = System.Drawing.Color.Blue;
                checkBox_statuscj2.Text = "Conjuge Ativo";
            }

            if (conj.Status_conjuge == "Inativo")
            {
                checkBox_statuscj2.Text = "Conjuge Inativo";
                checkBox_statuscj2.ForeColor = System.Drawing.Color.Red;
                checkBox_statuscj2.Checked = false;
            }
            #region Valor Renda Conjuge
            valor = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj2.Text = "0,00" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacj2.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendacj2.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacj2.Text.StartsWith("0,"))
                {
                    txtrendacj2.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacj2.Text.Contains("00,"))
                {
                    txtrendacj2.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacj2.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacj2.Text;
            txtrendacj2.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacj2.Select(txtrendacj2.Text.Length, 0);
            #endregion

            cj3 = conj.Conjuge_conjuge;


            txtnomecj2.Select(txtnomecj2.Text.Length, 0);
            this.ActiveControl = txtnomecj2;
            txtnomecj2.Focus();
            Cursor = Cursors.Default;
        }
        public void LoadDadosCJ2(String idcliente, String idconjuge)
        {
            Cursor = Cursors.WaitCursor;
            Conjuge conj = null;

            LoginDaoComandos getconjuge = new LoginDaoComandos();
            conj = getconjuge.GetConjuge(idcliente, idconjuge);

            txtnomecj3.Text = conj.Nome_conjuge;
            txtcpfcj3.Text = conj.CPF_conjuge;
            txtrgcj3.Text = conj.RG_conjuge;
            txtnasccj3.Text = conj.Nascimento_conjuge;
            txtemailcj3.Text = conj.Email_conjuge;
            txttelefonecj3.Text = conj.Telefone_conjuge;
            txtcelularcj3.Text = conj.Celular_conjuge;
            txtrendacj3.Text = conj.Renda_conjuge;
            txtagenciacj3.Text = conj.Agencia_conjuge;
            txtcontacj3.Text = conj.Conta_conjuge;
            txtobservacaocj3.Text = conj.OBS_conjuge;

            if (conj.Sexo_conjuge == "Masculino")
            {
                checkBox_Masculinocj3.Checked = true;

            }
            else if (conj.Sexo_conjuge == "Feminino")
            {
                checkBox_Femininocj3.Checked = true;
            }


            if (conj.Status_conjuge == "Ativo")
            {
                checkBox_statuscj3.Checked = true;
                checkBox_statuscj3.ForeColor = System.Drawing.Color.Blue;
                checkBox_statuscj3.Text = "Conjuge Ativo";
            }

            if (conj.Status_conjuge == "Inativo")
            {
                checkBox_statuscj3.Text = "Conjuge Inativo";
                checkBox_statuscj3.ForeColor = System.Drawing.Color.Red;
                checkBox_statuscj3.Checked = false;
            }
            #region Valor Renda Conjuge
            valor = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj3.Text = "0,00" + valor;
            }
            if (valor.Length == 3)
            {
                txtrendacj3.Text = "0,0" + valor;
            }
            if (valor.Length == 3)
            {
                txtrendacj3.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendacj3.Text.StartsWith("0,"))
                {
                    txtrendacj3.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendacj3.Text.Contains("00,"))
                {
                    txtrendacj3.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendacj3.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendacj3.Text;
            txtrendacj3.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendacj3.Select(txtrendacj3.Text.Length, 0);
            #endregion

            //cj3 = conj.Conjuge_conjuge;


            txtnomecj3.Select(txtnomecj3.Text.Length, 0);
            this.ActiveControl = txtnomecj3;
            txtnomecj3.Focus();
            Cursor = Cursors.Default;
        }

        public event Action ClienteSalvo;
        private void btn_add_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\Luis\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            Stream myStream = null;


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            foreach (string patcharquivo in ofd1.FileNames)
                            {
                                //MessageBox.Show(arquivo);
                                arquivo = patcharquivo;

                            }
                            arquivo = Path.GetFileName(arquivo);
                            arquivo = arquivo.Substring(0, arquivo.IndexOf("."));
                            //MessageBox.Show(arquivo);
                            var image = Image.FromStream(myStream);

                            var newImage = ResizeImage(image, 600, 400);
                            newImage.Save("c:\\Windows\\Temp\\" + arquivo + ".Jpeg", ImageFormat.Jpeg);

                            arquivo = @"C:\Windows\Temp\" + arquivo + ".Jpeg";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Le os arquivos selecionados 

                //MessageBox.Show(arquivo);
                img_foto.Image = new Bitmap(arquivo);
                img_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                btn_add_foto.Text = "Alterar";
                excluirimage = "Update";


            }
            Cursor = Cursors.Default;
        }
        Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);

                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (excluirimage == "Excluir")
            {

            }
            else if (excluirimage == "NoExluir")
            {

            }
            else
            {
                if (tabControl.SelectedTab == tabControl.TabPages["Foto"])
                {
                    if (img_foto.Image == null)

                    {
                        //MessageBox.Show("null");
                        LoginDaoComandos getfoto = new LoginDaoComandos();

                        getfoto.GetFotoCliente(idCliente);
                        setFoto(getfoto.GetFotoCliente(idCliente).Foto_cliente);
                        if (img_foto.Image == null)
                        {
                            btn_add_foto.Text = "Adicionar";
                            arquivobase = false;
                        }
                        else
                        {
                            arquivobase = true;
                            btn_add_foto.Text = "Alterar";
                        }

                    }

                }
            }
            Cursor = Cursors.Default;
        }

        private void btnconjuge_Click(object sender, EventArgs e)
        {

        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcpf_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {

        }

        private void txtrg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtrg_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_excluirconjuge_Click(object sender, EventArgs e)
        {

        }

        private void btnconjuge1_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluirconjuge1_Click(object sender, EventArgs e)
        {

        }

        private void btnconjuge2_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluirconjuge2_Click(object sender, EventArgs e)
        {

        }

        private void btnconjuge3_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluirconjuge3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_foto_Click(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja Excluir o Cliente: \n " + txtnomecli.Text + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                LoginDaoComandos deletecliente = new LoginDaoComandos();

                if (img_foto.Image != null)
                {
                    deletecliente.DeleteFotoCliente(idCliente);
                    deletecliente.DeleteCliente(idCliente);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ClienteSalvo != null)
                        ClienteSalvo.Invoke();
                    Close();
                }
                else
                {
                    deletecliente.DeleteCliente(idCliente);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ClienteSalvo != null)
                        ClienteSalvo.Invoke();
                    Close();
                }



            }

        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_limpar_foto_Click(object sender, EventArgs e)
        {
            img_foto.Image = null;
            btn_add_foto.Text = "Adicionar";
            if (img_foto.Image != null)
            {
                excluirimage = "NoExluir";
            }
            else
            {
                excluirimage = "Excluir";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_status_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_status.Checked)
            {
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Cliente Ativo";
                status = "Ativo";
            }
            else
            {
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Text = "Cliente Inativo";
                status = "Inativo";
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = true;
            splitter3.Visible = false;
            btn_excluir.Visible = false;


            HabilitarEdicao();
        }


        private void HabilitarEdicao()
        {
            txtnomecli.ReadOnly = false;
            txtcpf.ReadOnly = false;
            txtrg.ReadOnly = false;
            txtnasc.ReadOnly = false;
            txtemail.ReadOnly = false;
            txttelefone.ReadOnly = false;
            txtcelular.ReadOnly = false;
            txtrendacli.ReadOnly = false;
            checkBox_status.Enabled = true;
            checkBox_Masculino.Enabled = true;
            checkBox_Feminino.Enabled = true;
            txtagenciacliente.ReadOnly = false;
            txtcontacliente.ReadOnly = false;
            txtobservacoes.ReadOnly = false;

            img_foto.Enabled = true;
            if (img_foto.Image == null)
            {
                btn_add_foto.Text = "Adicionar";
            }
            else
            {
                btn_add_foto.Text = "Alterar";
            }
            btn_add_foto.Enabled = true;
            btn_limpar_foto.Enabled = true;
        }
        private void DesabilitarEdicao()
        {
            txtnomecli.ReadOnly = true;
            txtcpf.ReadOnly = true;
            txtrg.ReadOnly = true;
            txtnasc.ReadOnly = true;
            txtemail.ReadOnly = true;
            txttelefone.ReadOnly = true;
            txtcelular.ReadOnly = true;
            txtrendacli.ReadOnly = true;
            checkBox_status.Enabled = false;
            checkBox_Masculino.Enabled = false;
            checkBox_Feminino.Enabled = false;
            txtagenciacliente.ReadOnly = true;
            txtcontacliente.ReadOnly = true;
            txtobservacoes.ReadOnly = true;

            img_foto.Enabled = false;
            btn_add_foto.Enabled = false;
            btn_limpar_foto.Enabled = false;
        }
    }
}
