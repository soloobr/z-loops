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
        String sexo, status, idCliente, idConjuge, valor, renda, rendaconjuges, rendabruta, nascimento, arquivo, RG, CPF, telefone, celular, Agencia, Conta, sequencia;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase ;
        bool conjuge;
        bool[] cjativo = { false, false, false, false};

        string[] idconj = { "idCJ", "idCJ1", "idCJ2", "idCJ3" };
        int[] textbox = { 0, 1, 2, 3 };

        int newidcli, newidcj;


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

            if (cjativo[0]== true || cjativo[1]== true || (cjativo[2]== true) || cjativo[3]== true)
            {

                if (cjativo[0]== true)
                {
                    if (txtnomeconjuge.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge;
                        txtnomeconjuge.Select();
                        Cursor = Cursors.Default;
                        return;
                    }

                    if (txtcpfcj.Text == "")
                    {
                        MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge;
                        txtcpfcj.Select();
                        Cursor = Cursors.Default;
                        return;
                    }
                    #region Telefone

                    if (string.IsNullOrEmpty(txttelefonecj.Text))
                    {
                        if (string.IsNullOrEmpty(txtcelularcj.Text))
                        {
                            MessageBox.Show("É necessário preencher o campo Celular!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge;
                            txtcelularcj.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else if (string.IsNullOrEmpty(txttelefonecj.Text) && txtcelularcj.Text != "")
                        {
                        }
                        else
                        {
                            MessageBox.Show("É necessário preencher o campo Telefone!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge;
                            txttelefonecj.Select();
                            Cursor = Cursors.Default;
                            return;
                        }

                    }

                    #endregion

                    SomaRenda();
                    //MessageBox.Show(txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", ""));
                    if (string.IsNullOrEmpty(txtrendacj.Text) || txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "000")
                    {
                        rendabruta = txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                    else
                    {
                        rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                }
                if (cjativo[1]== true)
                {
                    if (txtnomecj1.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 1 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge1;
                        txtnomecj1.Select();
                        Cursor = Cursors.Default;
                        return;
                    }

                    if (txtcpfcj1.Text == "")
                    {
                        MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge1;
                        txtcpfcj1.Select();
                        Cursor = Cursors.Default;
                        return;
                    }
                    #region Telefone
                    if (string.IsNullOrEmpty(txttelefonecj1.Text))
                    {
                        if (string.IsNullOrEmpty(txtcelularcj1.Text))
                        {
                            MessageBox.Show("É necessário preencher o campo Celular!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge1;
                            txtcelularcj1.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else if (string.IsNullOrEmpty(txttelefonecj1.Text) && txtcelularcj1.Text != "")
                        {
                        }
                        else
                        {
                            MessageBox.Show("É necessário preencher o campo Telefone!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge1;
                            txttelefonecj1.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    #endregion

                    SomaRenda();
                    if (string.IsNullOrEmpty(txtrendacj1.Text) || txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
                    {
                        rendabruta = txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                    else
                    {
                        rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                }
                if (cjativo[2]== true)
                {
                    if (txtnomecj2.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 2 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge2;
                        txtnomecj2.Select();
                        Cursor = Cursors.Default;
                        return;
                    }

                    if (txtcpfcj2.Text == "")
                    {
                        MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge2;
                        txtcpfcj2.Select();
                        Cursor = Cursors.Default;
                        return;
                    }
                    #region Telefone
                    if (string.IsNullOrEmpty(txttelefonecj2.Text))
                    {
                        if (string.IsNullOrEmpty(txtcelularcj2.Text))
                        {
                            MessageBox.Show("É necessário preencher o campo Celular!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge2;
                            txtcelularcj2.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else if (string.IsNullOrEmpty(txttelefonecj2.Text) && txtcelularcj2.Text != "")
                        {
                        }
                        else
                        {
                            MessageBox.Show("É necessário preencher o campo Telefone!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge2;
                            txttelefonecj2.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    #endregion

                    SomaRenda();
                    if (string.IsNullOrEmpty(txtrendacj2.Text) || txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
                    {
                        rendabruta = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                    else
                    {
                        rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }

                }
                if (cjativo[3]== true)
                {
                    if (txtnomecj3.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 3 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge3;
                        txtnomecj3.Select();
                        Cursor = Cursors.Default;
                        return;
                    }

                    if (txtcpfcj3.Text == "")
                    {
                        MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge3;
                        txtcpfcj3.Select();
                        Cursor = Cursors.Default;
                        return;
                    }
                    #region Telefone
                    if (string.IsNullOrEmpty(txttelefonecj3.Text))
                    {
                        if (string.IsNullOrEmpty(txtcelularcj3.Text))
                        {
                            MessageBox.Show("É necessário preencher o campo Celular!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge3;
                            txtcelularcj3.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else if (string.IsNullOrEmpty(txttelefonecj3.Text) && txtcelularcj3.Text != "")
                        {
                        }
                        else
                        {
                            MessageBox.Show("É necessário preencher o campo Telefone!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tabControl.SelectedTab = tabconjuge3;
                            txttelefonecj3.Select();
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    #endregion

                    SomaRenda();
                    if (string.IsNullOrEmpty(txtrendacj.Text) || txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
                    {
                        rendabruta = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }
                    else
                    {
                        rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                    }

                }
                conjuge = true;

            }
            else
            {
                conjuge = false;
            }
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
                updatecliente.InsertConta(idCliente, txtagenciacliente.Text, txtcontacliente.Text, "C", "0", "0");
            }



            updatecliente.UpdateCliente(idCliente, txtnomecli.Text, txtemail.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, rendabruta, txtobservacoes.Text);

            Cursor = Cursors.Default;

            MessageBox.Show(updatecliente.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveConjuges();

            btn_editar.Visible = true;
            splitter1.Visible = false;
            btn_cancelar.Visible = false;
            splitter2.Visible = false;
            btn_salvar.Visible = false;


            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();
            SomaRenda();
            tabControl.SelectedTab = tabcliente;

            if (ClienteSalvo != null)
                ClienteSalvo.Invoke();

        }
        private void AtualizaRendaBruta()
        {
            SomaRenda();
            if (string.IsNullOrEmpty(txtrendacj.Text) || txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "000")
            {
                rendabruta = txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            else
            {
                rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            //SomaRenda();
            if (string.IsNullOrEmpty(txtrendacj1.Text) || txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
            {
            rendabruta = txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            else
            {
                rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            //SomaRenda();
            if (string.IsNullOrEmpty(txtrendacj2.Text) || txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
            {
                rendabruta = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            else
            {
                rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }

            //SomaRenda();
            if (string.IsNullOrEmpty(txtrendacj.Text) || txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "") == "0")
            {
                rendabruta = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
            else
            {
                rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            }
        }
        private void SaveConjuges()
        {
            #region Conjuge
            if (cjativo[0]== true)
            {

                Cursor = Cursors.WaitCursor;
                CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj.Text);

                status = "Ativo";

                if (checkBox_Masculinocj.Checked)
                {
                    sexo = "Masculino";
                }
                else if (checkBox_Femininocj.Checked)
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "";
                }

                if (txtrgcj.Text == "")
                {
                    RG = "0";
                }
                else
                {
                    RG = FormatCnpjCpf.SemFormatacao(txtrgcj.Text);
                }

                DateTime dataa;
                DateTime.TryParse(txtnasccj.Text + " " + "00:00:00", out dataa);

                DateTime datanasc = dataa;

                String renda = txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

                txtcelularcj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtcelularcj.Text != "")
                {
                    celular = txtcelularcj.Text;

                }
                txttelefonecj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txttelefonecj.Text != "")
                {
                    telefone = txttelefonecj.Text;
                }
                sequencia = "0";
                conjuge = cjativo[1];

                LoginDaoComandos updateconjuge = new LoginDaoComandos();

                updateconjuge.UpdateConjuge(idconj[0], txtnomeconjuge.Text, txtemailcj.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacaocj.Text, idCliente, sequencia, conjuge);


                if (txtcontacj != null && txtagenciacj != null)
                {

                    Conta = txtcontacj.Text;
                    Agencia = txtagenciacj.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.UpdateContaConjuge(idconj[0], Agencia, Conta, "CJ");
                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Conta do Cônjuge não Atualizada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;


                    }
                    Cursor = Cursors.Default;
                }



            }
            #endregion
            #region Conjuge1
            if (cjativo[1]== true)
            {

                Cursor = Cursors.WaitCursor;
                CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj1.Text);

                status = "Ativo";

                if (checkBox_Masculinocj1.Checked)
                {
                    sexo = "Masculino";
                }
                else if (checkBox_Femininocj1.Checked)
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "";
                }

                if (txtrgcj1.Text == "")
                {
                    RG = "0";
                }
                else
                {
                    RG = FormatCnpjCpf.SemFormatacao(txtrgcj1.Text);
                }

                DateTime dataa;
                DateTime.TryParse(txtnasccj1.Text + " " + "00:00:00", out dataa);

                DateTime datanasc = dataa;

                String renda = txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                txtcelularcj1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtcelularcj1.Text != "")
                {
                    celular = txtcelularcj1.Text;

                }
                txttelefonecj1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txttelefonecj1.Text != "")
                {
                    telefone = txttelefonecj1.Text;
                }

                sequencia = "1";
                conjuge = cjativo[2];

                LoginDaoComandos updateconjuge = new LoginDaoComandos();

                updateconjuge.UpdateConjuge(idconj[1], txtnomecj1.Text, txtemailcj1.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacaocj1.Text, idCliente, sequencia, conjuge);


                if (txtcontacj1 != null && txtagenciacj1 != null)
                {
                    Conta = txtcontacj1.Text;
                    Agencia = txtagenciacj1.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.UpdateContaConjuge(idconj[1], Agencia, Conta, "CJ");

                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Conta do Cônjuge 1 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        //Close();

                    }
                    Cursor = Cursors.Default;
                }


            }
            #endregion
            #region Conjuge2
            if (cjativo[2]== true)
            {

                Cursor = Cursors.WaitCursor;
                CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj2.Text);

                status = "Ativo";

                if (checkBox_Masculinocj2.Checked)
                {
                    sexo = "Masculino";
                }
                else if (checkBox_Femininocj2.Checked)
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "";
                }

                if (txtrgcj2.Text == "")
                {
                    RG = "0";
                }
                else
                {
                    RG = FormatCnpjCpf.SemFormatacao(txtrgcj2.Text);
                }

                DateTime dataa;
                DateTime.TryParse(txtnasccj2.Text + " " + "00:00:00", out dataa);

                DateTime datanasc = dataa;

                String renda = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                txtcelularcj2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtcelularcj2.Text != "")
                {
                    celular = txtcelularcj2.Text;

                }
                txttelefonecj2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txttelefonecj2.Text != "")
                {
                    telefone = txttelefonecj2.Text;
                }
                sequencia = "2";
                conjuge = cjativo[3];

                LoginDaoComandos updateconjuge = new LoginDaoComandos();

                updateconjuge.UpdateConjuge(idconj[2], txtnomecj2.Text, txtemailcj2.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacaocj2.Text, idCliente, sequencia, conjuge);


                if (txtcontacj2 != null && txtagenciacj2 != null)
                {
                    Conta = txtcontacj2.Text;
                    Agencia = txtagenciacj2.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.UpdateContaConjuge(idconj[2], Agencia, Conta, "CJ");
                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Conta do Cônjuge 2 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        Close();

                    }
                    Cursor = Cursors.Default;
                }


            }
            #endregion
            #region Conjuge3
            if (cjativo[3]== true)
            {

                Cursor = Cursors.WaitCursor;
                CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj3.Text);

                status = "Ativo";

                if (checkBox_Masculinocj3.Checked)
                {
                    sexo = "Masculino";
                }
                else if (checkBox_Femininocj3.Checked)
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "";
                }

                if (txtrgcj3.Text == "")
                {
                    RG = "0";
                }
                else
                {
                    RG = FormatCnpjCpf.SemFormatacao(txtrgcj3.Text);
                }

                DateTime dataa;
                DateTime.TryParse(txtnasccj3.Text + " " + "00:00:00", out dataa);

                DateTime datanasc = dataa;

                String renda = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                txtcelularcj3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txtcelularcj3.Text != "")
                {
                    celular = txtcelularcj3.Text;

                }
                txttelefonecj3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (txttelefonecj3.Text != "")
                {
                    telefone = txttelefonecj3.Text;
                }
                sequencia = "3";
                conjuge = false;

                LoginDaoComandos updateconjuge = new LoginDaoComandos();

                updateconjuge.UpdateConjuge(idconj[3], txtnomecj3.Text, txtemailcj3.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacaocj3.Text, idCliente, sequencia, conjuge);


                if (txtcontacj3 != null && txtagenciacj3 != null)
                {

                    Conta = txtcontacj3.Text;
                    Agencia = txtagenciacj3.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.UpdateContaConjuge(idconj[3], Agencia, Conta, "CJ");
                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Conta do Cônjuge 3 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                        //Close();

                    }
                    Cursor = Cursors.Default;
                }


            }
            #endregion
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
            SomaRenda();
            LoginDaoComandos getconjuge = new LoginDaoComandos();


            var highScores = getconjuge.GetidConjuges(idCliente);

            int cont = 0;
            foreach (var item in highScores)
            {

                //string("idCJ" + cont.ToString()) = 
                idconj[cont] = ($"{item.Id_conjuge,-15}");
                cjativo[cont] = true;
                //MessageBox.Show(idconj[cont]);
                // idCJ + sequencia = ($"{item.Id_conjuge,-15});
                //MessageBox.Show($"{item.Id_conjuge,-15}{item.Conjuge_conjuge}");
                cont = cont + 1;
            }



            if (cjativo[0] == true)
            {
                tabControl.TabPages.Insert(1, tabconjuge);
                LoadDadosConjuge(idCliente, idconj[0]);
                gbrenda.Visible = true;
                lbl0.Visible = true;
                lblnomeclirenda.Visible = true;
                lblnomeclirenda.Text = txtnomecli.Text;
                lblrendacli.Visible = true;
                lblrendacli.Text = txtrendacli.Text;

                lbl01.Visible = true;
                lblnomecj1.Visible = true;
                lblnomecj1.Text = txtnomeconjuge.Text;
                lblrendacj1.Visible = true;
                lblrendacj1.Text = txtrendacj.Text;

                lblrendabruta.Visible = true;
                txtrendatotal.Visible = true;

                txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(SomaRenda().ToString()));

                btbsalvarcj.Visible = false;
                btncancelcj.Visible = false;
                //btncj.Visible = true;
               // btn_excluircj.Visible = true;
            }
            if (cjativo[1] == true)
            {
                tabControl.TabPages.Insert(2, tabconjuge1);
                LoadDadosCJ(idCliente, idconj[1]);

                lbl02.Visible = true;
                lblnomecj2.Visible = true;
                lblnomecj2.Text = txtnomecj1.Text;
                lblrendacj2.Visible = true;
                lblrendacj2.Text = txtrendacj1.Text;

                lblrendabruta.Visible = true;
                txtrendatotal.Visible = true;

                txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(SomaRenda().ToString()));

                btnsalvarcj1.Visible = false;
                btncancelcj1.Visible = false;
                //btncj1.Visible = true;
                //btn_excluircj1.Visible = true;
            }
            if (cjativo[2] == true)
            {
                tabControl.TabPages.Insert(3, tabconjuge2);
                LoadDadosCJ1(idCliente, idconj[2]);

                lbl03.Visible = true;
                lblnomecj3.Visible = true;
                lblnomecj3.Text = txtnomecj2.Text;
                lblrendacj3.Visible = true;
                lblrendacj3.Text = txtrendacj2.Text;

                lblrendabruta.Visible = true;
                txtrendatotal.Visible = true;

                txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(SomaRenda().ToString()));

                btnsalvarcj2.Visible = false;
                btncancelcj2.Visible = false;
                //btncj2.Visible = true;
                //btn_excluircj2.Visible = true;
            }
            if (cjativo[3] == true)
            {
                tabControl.TabPages.Insert(4, tabconjuge3);
                LoadDadosCJ2(idCliente, idconj[3]);

                lbl04.Visible = true;
                lblnomecj4.Visible = true;
                lblnomecj4.Text = txtnomecj3.Text;
                lblrendacj4.Visible = true;
                lblrendacj4.Text = txtrendacj3.Text;

                lblrendabruta.Visible = true;
                txtrendatotal.Visible = true;
                txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(SomaRenda().ToString()));

                btnsalvarcj3.Visible = false;
                btncancelcj3.Visible = false;
                //btncj3.Visible = true;
                //btn_excluircj3.Visible = true;
            }
        }
        public decimal SomaRenda()
        {
            gbrenda.Visible = true;

            decimal vl1, vl2, vl3, vl4, vl5, result;
            if (txtrendacj.Text != "")
            {
                vl1 = decimal.Parse(txtrendacj.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj1.Text = txtrendacj.Text;
                lblnomecj1.Text = txtnomeconjuge.Text;
            }
            else
            {
                lblrendacj1.Text = txtrendacj.Text;
                lblnomecj1.Text = txtnomeconjuge.Text;
                vl1 = 0;
            }
            if (txtrendacli.Text != "")
            {
                vl2 = decimal.Parse(txtrendacli.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacli.Text = txtrendacli.Text;
                lblnomeclirenda.Text = txtnomecli.Text;
            }
            else
            {
                vl2 = 0;
                lblrendacli.Text = txtrendacli.Text;
                lblnomeclirenda.Text = txtnomecli.Text;
            }
            if (txtrendacj1.Text != "")
            {
                vl3 = decimal.Parse(txtrendacj1.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj2.Text = txtrendacj1.Text;
                lblnomecj2.Text = txtnomecj1.Text;
            }
            else
            {
                vl3 = 0;
                lblrendacj2.Text = txtrendacj1.Text;
                lblnomecj2.Text = txtnomecj1.Text;
            }
            if (txtrendacj2.Text != "")
            {
                vl4 = decimal.Parse(txtrendacj2.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj3.Text = txtrendacj2.Text;
                lblnomecj3.Text = txtnomecj2.Text;
            }
            else
            {
                vl4 = 0;
                lblrendacj3.Text = txtrendacj2.Text;
                lblnomecj3.Text = txtnomecj2.Text;
            }
            if (txtrendacj3.Text != "")
            {
                vl5 = decimal.Parse(txtrendacj3.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj4.Text = txtrendacj3.Text;
                lblnomecj4.Text = txtnomecj3.Text;
            }
            else
            {
                vl5 = 0;
                lblrendacj4.Text = txtrendacj3.Text;
                lblnomecj4.Text = txtnomecj3.Text;
            }

            result = vl1 + vl2 + vl3 + vl4 + vl5;


            txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(result.ToString()));
            btn_salvar.Select();

            return result;
        }
        public decimal SomaRendaConjuges()
        {
            //gbrenda.Visible = true;

            decimal vl1, vl2, vl3, vl4, vl5, result;
            if (txtrendacj.Text != "")
            {
                vl1 = decimal.Parse(txtrendacj.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
               // lblrendacj1.Text = txtrendacj.Text;
                //lblnomecj1.Text = txtnomeconjuge.Text;
            }
            else
            {
                //lblrendacj1.Text = txtrendacj.Text;
               // lblnomecj1.Text = txtnomeconjuge.Text;
                vl1 = 0;
            }
            if (txtrendacli.Text != "")
            {
                vl2 = decimal.Parse(txtrendacli.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                //lblrendacli.Text = txtrendacli.Text;
                //lblnomeclirenda.Text = txtnomecli.Text;
            }
            else
            {
                vl2 = 0;
                //lblrendacli.Text = txtrendacli.Text;
                //lblnomeclirenda.Text = txtnomecli.Text;
            }
            if (txtrendacj1.Text != "")
            {
                vl3 = decimal.Parse(txtrendacj1.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                //lblrendacj2.Text = txtrendacj1.Text;
                //lblnomecj2.Text = txtnomecj1.Text;
            }
            else
            {
                vl3 = 0;
            //    lblrendacj2.Text = txtrendacj1.Text;
              //  lblnomecj2.Text = txtnomecj1.Text;
            }
            if (txtrendacj2.Text != "")
            {
                vl4 = decimal.Parse(txtrendacj2.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                //lblrendacj3.Text = txtrendacj2.Text;
                //lblnomecj3.Text = txtnomecj2.Text;
            }
            else
            {
                vl4 = 0;
            //    lblrendacj3.Text = txtrendacj2.Text;
              //  lblnomecj3.Text = txtnomecj2.Text;
            }
            if (txtrendacj3.Text != "")
            {
                vl5 = decimal.Parse(txtrendacj3.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                //lblrendacj4.Text = txtrendacj3.Text;
                //lblnomecj4.Text = txtnomecj3.Text;
            }
            else
            {
                vl5 = 0;
            //    lblrendacj4.Text = txtrendacj3.Text;
             //   lblnomecj4.Text = txtnomecj3.Text;
            }

            result = vl1 + vl2 + vl3 + vl4 + vl5;


            rendaconjuges = result.ToString();
           // btn_salvar.Select();

            return result;
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

            //cjativo[0]= cliente.Conjuge_cliente;


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

            idconj[0] = conj.Id_conjuge;
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

            //cjativo[1]= conj.Conjuge_conjuge;


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

            idconj[1] = conj.Id_conjuge;
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

            //cjativo[2]= conj.Conjuge_conjuge;


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

            idconj[2] = conj.Id_conjuge;
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

            //cjativo[3]= conj.Conjuge_conjuge;


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

            idconj[3] = conj.Id_conjuge;
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

            //cjativo[3]= conj.Conjuge_conjuge;


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

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void txtrendacj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacj.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacj1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacj1.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacj2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacj2.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacj3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacj3.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacj_KeyUp(object sender, KeyEventArgs e)
        {
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
        }

        private void txtrendacj1_KeyUp(object sender, KeyEventArgs e)
        {
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
        }

        private void txtrendacj2_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj2.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
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
        }

        private void txtrendacj3_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendacj3.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendacj3.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
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
        }

        private void txtrendacj_Leave(object sender, EventArgs e)
        {
            valor = txtrendacj.Text.Replace("R$", "");
            txtrendacj.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txtrendacj1_Leave(object sender, EventArgs e)
        {
            valor = txtrendacj1.Text.Replace("R$", "");
            txtrendacj1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txtrendacj2_Leave(object sender, EventArgs e)
        {
            valor = txtrendacj2.Text.Replace("R$", "");
            txtrendacj2.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txtrendacj3_Leave(object sender, EventArgs e)
        {
            valor = txtrendacj3.Text.Replace("R$", "");
            txtrendacj3.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txtcpf_KeyUp_1(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpf.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }
                if ((c == '.') && (txtcpf.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpf.Text = txtcpf.Text.Remove(cont, 1);
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Insert(11, "-");
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Remove(cont, 1);
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpf.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpf.Text = txtcpf.Text.Remove(txtcpf.Text.Length - 1);
                txtcpf.Select(txtcpf.Text.Length, 0);
            }
        }

        private void txtrgcj_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrgcj.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrgcj.Text.Length >= cont))
                {
                    txtrgcj.Text = txtrgcj.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrgcj.Select(txtrgcj.Text.Length, 0);
                }
                if ((c == '.') && (txtrgcj.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrgcj.Text = txtrgcj.Text.Remove(cont, 1);
                    txtrgcj.Select(txtrgcj.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrgcj.Text.Length >= cont))
                {
                    txtrgcj.Text = txtrgcj.Text.Remove(cont, 1);
                    txtrgcj.Select(txtrgcj.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrgcj.Text.Length >= cont))
                {
                    txtrgcj.Text = txtrgcj.Text.Insert(10, "-");
                    txtrgcj.Select(txtrgcj.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrgcj.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrgcj.Text = txtrgcj.Text.Remove(txtrgcj.Text.Length - 1);
                txtrgcj.Select(txtrgcj.Text.Length, 0);
            }
        }

        private void txtrgcj1_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrgcj1.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrgcj1.Text.Length >= cont))
                {
                    txtrgcj1.Text = txtrgcj1.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrgcj1.Select(txtrgcj1.Text.Length, 0);
                }
                if ((c == '.') && (txtrgcj1.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrgcj1.Text = txtrgcj1.Text.Remove(cont, 1);
                    txtrgcj1.Select(txtrgcj1.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrgcj1.Text.Length >= cont))
                {
                    txtrgcj1.Text = txtrgcj1.Text.Remove(cont, 1);
                    txtrgcj1.Select(txtrgcj1.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrgcj1.Text.Length >= cont))
                {
                    txtrgcj1.Text = txtrgcj1.Text.Insert(10, "-");
                    txtrgcj1.Select(txtrgcj1.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrgcj1.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrgcj1.Text = txtrgcj1.Text.Remove(txtrgcj1.Text.Length - 1);
                txtrgcj1.Select(txtrgcj1.Text.Length, 0);
            }
        }

        private void btn_excluirconjuge_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma a Exclusão do Conjuge: \n Nome: " + txtnomeconjuge.Text + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginDaoComandos deleteconjuge = new LoginDaoComandos();


                deleteconjuge.DeleteConjuge(idconj[0]);

                MessageBox.Show(deleteconjuge.mensagem, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl.TabPages.Remove(tabconjuge);

                //txtrendacj.Text = "";
                LiparConjuge(0);
                lbl01.Visible = false;
                lblnomecj1.Visible = false;
                lblrendacj1.Visible = false;
                SomaRenda();


                //deleteconjuge.UpdateCJCliente(idCliente, false);
                deleteconjuge.UpdateRendaBrutaCliente(idCliente, rendaconjuges);

                cjativo[0]= false;


                if (cjativo[0]== true || cjativo[1]== true || cjativo[2]== true || cjativo[3]== true)
                {
                }
                else
                {
                    deleteconjuge.UpdateCJCliente(idCliente, false);
                   
                }


            }
        }

        private void txtrgcj2_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrgcj2.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrgcj2.Text.Length >= cont))
                {
                    txtrgcj2.Text = txtrgcj2.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrgcj2.Select(txtrgcj2.Text.Length, 0);
                }
                if ((c == '.') && (txtrgcj2.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrgcj2.Text = txtrgcj2.Text.Remove(cont, 1);
                    txtrgcj2.Select(txtrgcj2.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrgcj2.Text.Length >= cont))
                {
                    txtrgcj2.Text = txtrgcj2.Text.Remove(cont, 1);
                    txtrgcj2.Select(txtrgcj2.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrgcj2.Text.Length >= cont))
                {
                    txtrgcj2.Text = txtrgcj2.Text.Insert(10, "-");
                    txtrgcj2.Select(txtrgcj2.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrgcj2.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrgcj2.Text = txtrgcj2.Text.Remove(txtrgcj2.Text.Length - 1);
                txtrgcj2.Select(txtrgcj2.Text.Length, 0);
            }
        }

        private void btnaonjuge_Click(object sender, EventArgs e)
        {

            if (txtnomecli.Text == "")
            {
                MessageBox.Show("Campo Nome do Cliente é necessário para adiconar Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecli.Select();
            }
            else if (txtcpf.Text == "")
            {
                MessageBox.Show("Campo CPF do Cliente é necessário para adiconar Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpf.Select();

            }
            else
            {
                IniciarCadConjuge();
            }
        }
        private void IniciarCadConjuge()
        {
            if (!tabControl.TabPages.Contains(tabconjuge))
            {
                tabControl.TabPages.Insert(1, tabconjuge);
                tabControl.SelectedTab = tabconjuge;
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
                txtnomeconjuge.Select();

                cjativo[0] = true;
                conjuge = true;
                btncj.Visible = false;
                btn_excluircj.Visible = false;
                
            }
            else if (!tabControl.TabPages.Contains(tabconjuge1))
            {
                tabControl.TabPages.Insert(2, tabconjuge1);
                tabControl.SelectedTab = tabconjuge1;
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
                txtnomecj1.Select();
                cjativo[1] = true;
                conjuge = true;
                btncj1.Visible = false;
                btn_excluircj1.Visible = false;
            }
            else if (!tabControl.TabPages.Contains(tabconjuge2))
            {
                tabControl.TabPages.Insert(3, tabconjuge2);
                tabControl.SelectedTab = tabconjuge2;
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
                txtnomecj2.Select();
                cjativo[2] = true;
                conjuge = true;
                btncj2.Visible = false;
                btn_excluircj2.Visible = false;

            }
            else if (!tabControl.TabPages.Contains(tabconjuge3))
            {
                tabControl.TabPages.Insert(4, tabconjuge3);
                tabControl.SelectedTab = tabconjuge3;
                #region Valor Renda Conjuge

                valor = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    txtrendacj3.Text = "0,00" + valor;
                }
                if (valor.Length == 2)
                {
                    txtrendacj3.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
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
                txtnomecj3.Select();
                cjativo[3] = true;
                conjuge = true;
                //btncj.Visible = false;
                btn_excluircj3.Visible = false;
            }
            else
            {
                MessageBox.Show("Limite máximo para adicionar Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private string InsertConjuges(int position)
        {
            try
            {
                switch (position)
                {
                    case 0:
                        Cursor = Cursors.WaitCursor;
                        if (txtnomeconjuge.Text == "")
                        {
                            MessageBox.Show("Campo Nome do Cônjuge  é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtnomeconjuge.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }

                        if (txtcpfcj.Text == "")
                        {
                            MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtcpfcj.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }
                        CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj.Text);

                        status = "Ativo";

                        if (checkBox_Masculinocj.Checked)
                        {
                            sexo = "Masculino";
                        }
                        else if (checkBox_Femininocj.Checked)
                        {
                            sexo = "Feminino";
                        }
                        else
                        {
                            sexo = "";
                        }

                        if (txtrgcj.Text == "")
                        {
                            RG = "0";
                        }
                        else
                        {
                            RG = FormatCnpjCpf.SemFormatacao(txtrgcj.Text);
                        }

                        DateTime dataa;
                        DateTime.TryParse(txtnasccj.Text + " " + "00:00:00", out dataa);

                        DateTime datanasc = dataa;

                        String renda = txtrendacj.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

                        if (string.IsNullOrEmpty(txttelefonecj.Text))
                        {
                            if (string.IsNullOrEmpty(txtcelularcj.Text))
                            {
                                MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txttelefonecj.Select();
                                Cursor = Cursors.Default;
                                return "FALSE";
                                break;
                            }

                        }
                        txtcelularcj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txtcelularcj.Text != "")
                        {
                            celular = txtcelularcj.Text;

                        }
                        txttelefonecj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txttelefonecj.Text != "")
                        {
                            telefone = txttelefonecj.Text;
                        }
                        sequencia = "0";
                        conjuge = cjativo[1];

                        LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                        newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge.Text, txtemailcj.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacaocj.Text, idCliente, sequencia, conjuge);
                        if(newidcj >0)
                        {
                            idconj[0] = newidcj.ToString();

                            if (txtcontacj != null && txtagenciacj != null)
                            {
                                idConjuge = newidcj.ToString();

                                Conta = txtcontacj.Text;
                                Agencia = txtagenciacj.Text;

                                LoginDaoComandos updateconta = new LoginDaoComandos();

                                updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ", idConjuge, "0");
                                if (updateconta.mensagem != "OK")
                                {
                                    MessageBox.Show("Conta do Cônjuge não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Cursor = Cursors.Default;
                                    Close();

                                }
                                Cursor = Cursors.Default;
                            }



                            inserirconjuge.UpdateCJCliente(idCliente, true);

                            btbsalvarcj.Visible = false;
                            btncancelcj.Visible = false;

                            btncj.Visible = true;
                            btn_excluircj.Visible = true;

                            lbl01.Visible = true;
                            lblnomecj1.Visible = true;
                            lblrendacj1.Visible = true;

                            return "OK";

                        }


                        break;

                    case 1:
                        Cursor = Cursors.WaitCursor;
                        if (txtnomecj1.Text == "")
                        {
                            MessageBox.Show("Campo Nome do Cônjuge 1 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtnomecj1.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }

                        if (txtcpfcj1.Text == "")
                        {
                            MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtcpfcj1.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }
                        CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj1.Text);

                        status = "Ativo";

                        if (checkBox_Masculinocj1.Checked)
                        {
                            sexo = "Masculino";
                        }
                        else if (checkBox_Femininocj1.Checked)
                        {
                            sexo = "Feminino";
                        }
                        else
                        {
                            sexo = "";
                        }

                        if (txtrgcj1.Text == "")
                        {
                            RG = "0";
                        }
                        else
                        {
                            RG = FormatCnpjCpf.SemFormatacao(txtrgcj1.Text);
                        }

                        DateTime dataa1;
                        DateTime.TryParse(txtnasccj1.Text + " " + "00:00:00", out dataa1);

                        DateTime datanasc1 = dataa1;

                        String renda1 = txtrendacj1.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

                        txtcelularcj1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txtcelularcj1.Text != "")
                        {
                            celular = txtcelularcj1.Text;

                        }
                        txttelefonecj1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txttelefonecj1.Text != "")
                        {
                            telefone = txttelefonecj1.Text;
                        }
                        sequencia = "1";
                        conjuge = cjativo[2];

                        LoginDaoComandos inserirconjuge1 = new LoginDaoComandos();

                        newidcj = inserirconjuge1.CadastrarConjuge(txtnomecj1.Text, txtemailcj1.Text, telefone, celular, CPF, RG, datanasc1, sexo, status, renda1, txtobservacaocj1.Text, idCliente, sequencia, conjuge);
                        if (newidcj > 0)
                        {
                            idconj[1] = newidcj.ToString();

                            if (txtcontacj1 != null && txtagenciacj1 != null)
                            {
                                idConjuge = newidcj.ToString();

                                Conta = txtcontacj1.Text;
                                Agencia = txtagenciacj1.Text;

                                LoginDaoComandos updateconta = new LoginDaoComandos();

                                updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ", idConjuge, "1");
                                if (updateconta.mensagem != "OK")
                                {
                                    MessageBox.Show("Conta do Cônjuge 1 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Cursor = Cursors.Default;
                                    Close();

                                }
                                Cursor = Cursors.Default;
                            }

                            inserirconjuge1.UpdateCJCliente(idCliente, true);
                            btnsalvarcj1.Visible = false;
                            btncancelcj1.Visible = false;

                            btncj1.Visible = true;
                            btn_excluircj1.Visible = true;

                            lbl02.Visible = true;
                            lblnomecj2.Visible = true;
                            lblrendacj2.Visible = true;

                            return "OK";

                        }


                        break;

                    case 2:

                        Cursor = Cursors.WaitCursor;
                        if (txtnomecj2.Text == "")
                        {
                            MessageBox.Show("Campo Nome do Cônjuge 2 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtnomecj2.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }

                        if (txtcpfcj2.Text == "")
                        {
                            MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtcpfcj2.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }
                        CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj2.Text);

                        status = "Ativo";

                        if (checkBox_Masculinocj2.Checked)
                        {
                            sexo = "Masculino";
                        }
                        else if (checkBox_Femininocj2.Checked)
                        {
                            sexo = "Feminino";
                        }
                        else
                        {
                            sexo = "";
                        }

                        if (txtrgcj2.Text == "")
                        {
                            RG = "0";
                        }
                        else
                        {
                            RG = FormatCnpjCpf.SemFormatacao(txtrgcj2.Text);
                        }

                        DateTime dataa2;
                        DateTime.TryParse(txtnasccj2.Text + " " + "00:00:00", out dataa2);

                        DateTime datanasc2 = dataa2;

                        String renda2 = txtrendacj2.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

                        if (string.IsNullOrEmpty(txttelefonecj2.Text))
                        {
                            if (string.IsNullOrEmpty(txtcelularcj3.Text))
                            {


                                MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txttelefonecj2.Select();
                                Cursor = Cursors.Default;
                                return "FALSE";
                                break;
                            }

                        }
                        txtcelularcj2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txtcelularcj2.Text != "")
                        {
                            celular = txtcelularcj2.Text;

                        }
                        txttelefonecj2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txttelefonecj2.Text != "")
                        {
                            telefone = txttelefonecj2.Text;
                        }

                        sequencia = "2";
                        conjuge = cjativo[3];

                        LoginDaoComandos inserirconjuge2 = new LoginDaoComandos();

                        newidcj = inserirconjuge2.CadastrarConjuge(txtnomecj2.Text, txtemailcj2.Text, telefone, celular, CPF, RG, datanasc2, sexo, status, renda2, txtobservacaocj2.Text, idCliente, sequencia, conjuge);
                        if (newidcj > 0)
                        {
                            idconj[2] = newidcj.ToString();

                            if (txtcontacj2 != null && txtagenciacj2 != null)
                            {
                                idConjuge = newidcj.ToString();

                                Conta = txtcontacj2.Text;
                                Agencia = txtagenciacj2.Text;

                                LoginDaoComandos updateconta = new LoginDaoComandos();

                                updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ", idConjuge, "2");
                                if (updateconta.mensagem != "OK")
                                {
                                    MessageBox.Show("Conta do Cônjuge 2 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Cursor = Cursors.Default;
                                    Close();

                                }
                                Cursor = Cursors.Default;
                            }
                            inserirconjuge2.UpdateCJCliente(idCliente, true);
                            btnsalvarcj2.Visible = false;
                            btncancelcj2.Visible = false;

                            btncj2.Visible = true;
                            btn_excluircj2.Visible = true;

                            lbl03.Visible = true;
                            lblnomecj3.Visible = true;
                            lblrendacj3.Visible = true;
                            return "OK";

                        }


                        break;

                    case 3:

                        Cursor = Cursors.WaitCursor;
                        if (txtnomecj3.Text == "")
                        {
                            MessageBox.Show("Campo Nome do Cônjuge 3 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtnomecj3.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }

                        if (txtcpfcj3.Text == "")
                        {
                            MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtcpfcj3.Select();
                            Cursor = Cursors.Default;
                            return "FALSE";
                            break;
                        }
                        CPF = FormatCnpjCpf.SemFormatacao(txtcpfcj3.Text);

                        status = "Ativo";

                        if (checkBox_Masculinocj3.Checked)
                        {
                            sexo = "Masculino";
                        }
                        else if (checkBox_Femininocj3.Checked)
                        {
                            sexo = "Feminino";
                        }
                        else
                        {
                            sexo = "";
                        }

                        if (txtrgcj3.Text == "")
                        {
                            RG = "0";
                        }
                        else
                        {
                            RG = FormatCnpjCpf.SemFormatacao(txtrgcj3.Text);
                        }

                        DateTime dataa3;
                        DateTime.TryParse(txtnasccj3.Text + " " + "00:00:00", out dataa3);

                        DateTime datanasc3 = dataa3;

                        String renda3 = txtrendacj3.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
                        #region Telefone
                        if (string.IsNullOrEmpty(txttelefonecj3.Text))
                        {
                            if (string.IsNullOrEmpty(txtcelularcj3.Text))
                            {


                                MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txttelefonecj3.Select();
                                Cursor = Cursors.Default;
                                return "FALSE";
                                break;
                            }

                        }
                        txtcelularcj3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txtcelularcj3.Text != "")
                        {
                            celular = txtcelularcj3.Text;

                        }
                        txttelefonecj3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (txttelefonecj3.Text != "")
                        {
                            telefone = txttelefonecj3.Text;
                        }

                        #endregion
                        sequencia = "3";
                        conjuge = false;


                        LoginDaoComandos inserirconjuge3 = new LoginDaoComandos();

                        newidcj = inserirconjuge3.CadastrarConjuge(txtnomecj3.Text, txtemailcj3.Text, telefone, celular, CPF, RG, datanasc3, sexo, status, renda3, txtobservacaocj3.Text, idCliente, sequencia, conjuge);
                        if (newidcj > 0)
                        {
                            idconj[3] = newidcj.ToString();

                        if (txtcontacj3 != null && txtagenciacj3 != null)
                        {
                            idConjuge = newidcj.ToString();

                            Conta = txtcontacj3.Text;
                            Agencia = txtagenciacj3.Text;

                            LoginDaoComandos updateconta = new LoginDaoComandos();

                            updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ", idConjuge, "3");
                            if (updateconta.mensagem != "OK")
                            {
                                MessageBox.Show("Conta do Cônjuge 3 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Cursor = Cursors.Default;
                                Close();

                            }
                            Cursor = Cursors.Default;
                        }
                        inserirconjuge3.UpdateCJCliente(idCliente, true);

                        //return "INSERIDO";
                        btnsalvarcj3.Visible = false;
                        btncancelcj3.Visible = false;

                        // btnconjuge3.Visible = true;
                        btn_excluircj3.Visible = true;

                        lbl04.Visible = true;
                        lblnomecj4.Visible = true;
                        lblrendacj4.Visible = true;
                            return "OK";

                        }


                        break;
                }
            }
            catch (Exception)
            {
                return "ERROR";
                //throw;
            }
            return "ERROR";
        }

        private void btnconjuge1_Click(object sender, EventArgs e)
        {
            if (txtnomeconjuge.Text == "")
            {
                MessageBox.Show("Campo Nome do Cônjuge é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomeconjuge.Select();
            }
            else if (txtcpfcj.Text == "")
            {
                MessageBox.Show("Campo CPF do Cônjuge é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpfcj.Select();

            }
            else
            {
                IniciarCadConjuge();
                //if (!tabControl.TabPages.Contains(tabconjuge1))
                //{
                //    tabControl.TabPages.Insert(2, tabconjuge1);
                //    tabControl.SelectedTab = tabconjuge1;
                //    //Settxtrenda(txtrendacj1);
                //    txtnomecj1.Select();
                //    cjativo[1]= true;
                //    conjuge = true;
                //    btncj1.Visible = false;
                //    btn_excluircj1.Visible = false;


                //}else
                //{
                //    tabControl.SelectedTab = tabconjuge1;
                //    txtnomeconjuge.Select();
                //}
            }
        }

        private void btnconjuge2_Click(object sender, EventArgs e)
        {
            if (txtnomecj1.Text == "")
            {
                MessageBox.Show("Campo Nome do Cônjuge 1 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecj1.Select();
            }
            else if (txtcpfcj1.Text == "")
            {
                MessageBox.Show("Campo CPF do Cônjuge 1 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpfcj1.Select();

            }
            else
            {
                IniciarCadConjuge();
                //if (txtnomecli != null && txtcpf != null)
                //{
                //    if (!tabControl.TabPages.Contains(tabconjuge2))
                //    {
                //        tabControl.TabPages.Insert(3, tabconjuge2);
                //        tabControl.SelectedTab = tabconjuge2;
                //        //Settxtrenda(txtrendacj2);
                //        txtnomecj2.Select();
                //        cjativo[2]= true;
                //        conjuge = true;
                //        btncj2.Visible = false;
                //        btn_excluircj2.Visible = false;
                //    }
                //    else
                //    {
                //        tabControl.SelectedTab = tabconjuge2;
                //        txtnomeconjuge.Select();
                //    }
                //}
            }
        }

        private void btnconjuge3_Click(object sender, EventArgs e)
        {
            if (txtnomecj2.Text == "")
            {
                MessageBox.Show("Campo Nome do Cônjuge 2 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecj2.Select();
            }
            else if (txtcpfcj2.Text == "")
            {
                MessageBox.Show("Campo CPF do Cônjuge 2 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpfcj2.Select();

            }
            else
            {
                IniciarCadConjuge();
                //if (!tabControl.TabPages.Contains(tabconjuge3))
                //{
                //    tabControl.TabPages.Insert(4, tabconjuge3);
                //    tabControl.SelectedTab = tabconjuge3;
                //    //Settxtrenda(txtrendacj3);
                //    txtnomecj3.Select();
                //    cjativo[3]= true;
                //    conjuge = true;
                //    //btncj.Visible = false;
                //    btn_excluircj3.Visible = false;
                //}
                //else
                //{
                //    tabControl.SelectedTab = tabconjuge3;
                //    txtnomeconjuge.Select();
                //}
            }
        }

        private void btn_excluirconjuge3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma a Exclusão do Conjuge 3: \n Nome: " + txtnomecj3.Text + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginDaoComandos deleteconjuge = new LoginDaoComandos();


                deleteconjuge.DeleteConjuge(idconj[3]);

                MessageBox.Show(deleteconjuge.mensagem, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl.TabPages.Remove(tabconjuge3);

                LiparConjuge(3);

                //txtrendacj3.Text = "";

                lbl04.Visible = false;
                lblnomecj4.Visible = false;
                lblrendacj4.Visible = false;
                SomaRenda();

                cjativo[3]= false;

                deleteconjuge.UpdateRendaBrutaCliente(idCliente, rendaconjuges);

                if (cjativo[0]== true || cjativo[1]== true || cjativo[2]== true || cjativo[3]== true)
                {
                }
                else
                {
                    deleteconjuge.UpdateCJCliente(idCliente, false);
                    
                }
            }
        }
        private void LiparConjuge(int textBox)
        {
            switch (textBox)
            {
                case 0:
                    txtnomeconjuge.Clear();
                    txtcpfcj.Clear();
                    txtrgcj.Clear();
                    txtnasccj.Clear();
                    txtemailcj.Clear();
                    txttelefonecj.Clear();
                    txtcelularcj.Clear();
                    txtrendacj.Clear();
                    txtagenciacj.Clear();
                    txtcontacj.Clear();
                    checkBox_Masculinocj.Checked = false;
                    checkBox_Femininocj.Checked = false;
                    checkBox_statuscj.Checked = false;
                    txtobservacaocj.Clear();
                    btbsalvarcj.Visible = true;
                    btncancelcj.Visible = true;
                    btncj.Visible = false;
                    btn_excluircj.Visible = false;
                    break;
                case 1:
                    txtnomecj1.Clear();
                    txtcpfcj1.Clear();
                    txtrgcj1.Clear();
                    txtnasccj1.Clear();
                    txtemailcj1.Clear();
                    txttelefonecj1.Clear();
                    txtcelularcj1.Clear();
                    txtrendacj1.Clear();
                    txtagenciacj1.Clear();
                    txtcontacj1.Clear();
                    checkBox_Masculinocj1.Checked = false;
                    checkBox_Femininocj1.Checked = false;
                    checkBox_statuscj1.Checked = false;
                    txtobservacaocj1.Clear();
                    btnsalvarcj1.Visible = true;
                    btncancelcj1.Visible = true;
                    btncj1.Visible = false;
                    btn_excluircj1.Visible = false;
                    break;
                case 2:
                    txtnomecj2.Clear();
                    txtcpfcj2.Clear();
                    txtrgcj2.Clear();
                    txtnasccj2.Clear();
                    txtemailcj2.Clear();
                    txttelefonecj2.Clear();
                    txtcelularcj2.Clear();
                    txtrendacj2.Clear();
                    txtagenciacj2.Clear();
                    txtcontacj2.Clear();
                    checkBox_Masculinocj2.Checked = false;
                    checkBox_Femininocj2.Checked = false;
                    checkBox_statuscj2.Checked = false;
                    txtobservacaocj2.Clear();
                    btnsalvarcj2.Visible = true;
                    btncancelcj2.Visible = true;
                    btncj2.Visible = false;
                    btn_excluircj2.Visible = false;
                    break;
                case 3:
                    txtnomecj3.Clear();
                    txtcpfcj3.Clear();
                    txtrgcj3.Clear();
                    txtnasccj3.Clear();
                    txtemailcj3.Clear();
                    txttelefonecj3.Clear();
                    txtcelularcj3.Clear();
                    txtrendacj3.Clear();
                    txtagenciacj3.Clear();
                    txtcontacj3.Clear();
                    checkBox_Masculinocj3.Checked = false;
                    checkBox_Femininocj3.Checked = false;
                    checkBox_statuscj3.Checked = false;
                    txtobservacaocj3.Clear();
                    btnsalvarcj3.Visible = true;
                    btncancelcj3.Visible = true;
                    //btncj3.Visible = false;
                    btn_excluircj3.Visible = false;
                    break;

            }

        }
        private void btn_excluirconjuge2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma a Exclusão do Conjuge 2: \n Nome:  " + txtnomecj2.Text + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginDaoComandos deleteconjuge = new LoginDaoComandos();


                deleteconjuge.DeleteConjuge(idconj[2]);

                MessageBox.Show(deleteconjuge.mensagem, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl.TabPages.Remove(tabconjuge2);
                //txtrendacj2.Text = "";
                LiparConjuge(2);
                lbl03.Visible = false;
                lblnomecj3.Visible = false;
                lblrendacj3.Visible = false;
                SomaRenda();

                cjativo[2]= false;

                deleteconjuge.UpdateRendaBrutaCliente(idCliente, rendaconjuges);

                if (cjativo[0]== true || cjativo[1]== true || cjativo[2]== true || cjativo[3]== true)
                {
                }
                else
                {
                    deleteconjuge.UpdateCJCliente(idCliente, false);
                    
                }
            }
        }

        private void btn_excluirconjuge1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma a Exclusão do Conjuge 1: \n Nome: " + txtnomecj1.Text + " ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginDaoComandos deleteconjuge = new LoginDaoComandos();


                deleteconjuge.DeleteConjuge(idconj[1]);

                MessageBox.Show(deleteconjuge.mensagem, "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                tabControl.TabPages.Remove(tabconjuge1);
                //txtrendacj1.Text = "";
                LiparConjuge(1);
                lbl02.Visible = false;
                lblnomecj2.Visible = false;
                lblrendacj2.Visible = false;
                SomaRenda();

                cjativo[1]= false;

                deleteconjuge.UpdateRendaBrutaCliente(idCliente, rendaconjuges);

                if (cjativo[0]== true || cjativo[1]== true || cjativo[2]== true || cjativo[3]== true)
                {
                }
                else
                {
                    deleteconjuge.UpdateCJCliente(idCliente, false);
                   
                }
            }
        }

        private void btnsalvarcj1_Click(object sender, EventArgs e)
        {
            if (InsertConjuges(1) == "OK")
            {
                SomaRenda();
                MessageBox.Show("Cônjuge inserido com Sucesso!", "Inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

            }

            //btnsalvarcj1.Visible = false;
            //btncancelcj1.Visible = false;

            //btncj1.Visible = true;
            //btn_excluircj1.Visible = true;

            //lbl02.Visible = true;
            //lblnomecj2.Visible = true;
            //lblrendacj2.Visible = true;

            //SomaRenda();
        }

        private void btnsalvarcj2_Click(object sender, EventArgs e)
        {
            if (InsertConjuges(2) == "OK")
            {
                SomaRenda();
                MessageBox.Show("Cônjuge inserido com Sucesso!", "Inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

            }

            //btnsalvarcj2.Visible = false;
            //btncancelcj2.Visible = false;

            //btncj2.Visible = true;
            //btn_excluircj2.Visible = true;

            //lbl03.Visible = true;
            //lblnomecj3.Visible = true;
            //lblrendacj3.Visible = true;

            //SomaRenda();
        }

        private void btnsalvarcj3_Click(object sender, EventArgs e)
        {
            if (InsertConjuges(3) == "OK")
            {
                SomaRenda();
                MessageBox.Show("Cônjuge inserido com Sucesso!", "Inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

            }

            //btnsalvarcj3.Visible = false;
            //btncancelcj3.Visible = false;

            //// btnconjuge3.Visible = true;
            //btn_excluircj3.Visible = true;

            //lbl04.Visible = true;
            //lblnomecj4.Visible = true;
            //lblrendacj4.Visible = true;

        }

        private void btbsalvarcj_Click(object sender, EventArgs e)
        {
            if (InsertConjuges(0) == "OK")
            {
                SomaRenda();
                MessageBox.Show("Cônjuge inserido com Sucesso!", "Inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {

            }

            //btbsalvarcj.Visible = false;
            //btncancelcj.Visible = false;

            //btncj.Visible = true;
            //btn_excluircj.Visible = true;

            //lbl01.Visible = true;
            //lblnomecj1.Visible = true;
            //lblrendacj1.Visible = true;

           // SomaRenda();
        }

        private void txtrgcj3_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrgcj3.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrgcj3.Text.Length >= cont))
                {
                    txtrgcj3.Text = txtrgcj3.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrgcj3.Select(txtrgcj3.Text.Length, 0);
                }
                if ((c == '.') && (txtrgcj3.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrgcj3.Text = txtrgcj3.Text.Remove(cont, 1);
                    txtrgcj3.Select(txtrgcj3.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrgcj3.Text.Length >= cont))
                {
                    txtrgcj3.Text = txtrgcj3.Text.Remove(cont, 1);
                    txtrgcj3.Select(txtrgcj3.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrgcj3.Text.Length >= cont))
                {
                    txtrgcj3.Text = txtrgcj3.Text.Insert(10, "-");
                    txtrgcj3.Select(txtrgcj3.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrgcj3.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrgcj3.Text = txtrgcj3.Text.Remove(txtrgcj3.Text.Length - 1);
                txtrgcj3.Select(txtrgcj3.Text.Length, 0);
            }
        }

        private void txtcpf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtcpf.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrg_KeyUp_1(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrg.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                if ((c == '.') && (txtrg.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrg.Text = txtrg.Text.Remove(cont, 1);
                    txtrg.Select(txtrg.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Remove(cont, 1);
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Insert(10, "-");
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrg.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrg.Text = txtrg.Text.Remove(txtrg.Text.Length - 1);
                txtrg.Select(txtrg.Text.Length, 0);
            }
        }

        private void btncancelcj_Click(object sender, EventArgs e)
        {
            LiparConjuge(0);
            tabControl.TabPages.Remove(tabconjuge);
            tabControl.SelectedTab = tabcliente;
            txtnomecli.Select();
            cjativo[0] = false;
        }

        private void btncancelcj1_Click(object sender, EventArgs e)
        {
            LiparConjuge(1);
            tabControl.TabPages.Remove(tabconjuge1);
            tabControl.SelectedTab = tabconjuge;
            txtnomeconjuge.Select();
            cjativo[1] = false;
        }

        private void btncancelcj2_Click(object sender, EventArgs e)
        {
            LiparConjuge(2);
            tabControl.TabPages.Remove(tabconjuge2);
            tabControl.SelectedTab = tabconjuge1;
            txtnomecj1.Select();
            cjativo[2] = false;
        }

        private void btncancelcj3_Click(object sender, EventArgs e)
        {
            LiparConjuge(3);
            tabControl.TabPages.Remove(tabconjuge3);
            tabControl.SelectedTab = tabconjuge2;
            txtnomecj2.Select();
            cjativo[3] = false;
        }

        private void txtcpfcj_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpfcj.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpfcj.Text.Length >= cont))
                {
                    txtcpfcj.Text = txtcpfcj.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpfcj.Select(txtcpfcj.Text.Length, 0);
                }
                if ((c == '.') && (txtcpfcj.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpfcj.Text = txtcpfcj.Text.Remove(cont, 1);
                    txtcpfcj.Select(txtcpfcj.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpfcj.Text.Length >= cont))
                {
                    txtcpfcj.Text = txtcpfcj.Text.Insert(11, "-");
                    txtcpfcj.Select(txtcpfcj.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpfcj.Text.Length >= cont))
                {
                    txtcpfcj.Text = txtcpfcj.Text.Remove(cont, 1);
                    txtcpfcj.Select(txtcpfcj.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpfcj.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpfcj.Text = txtcpfcj.Text.Remove(txtcpfcj.Text.Length - 1);
                txtcpfcj.Select(txtcpfcj.Text.Length, 0);
            }
        }

        private void txtcpfcj1_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpfcj1.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpfcj1.Text.Length >= cont))
                {
                    txtcpfcj1.Text = txtcpfcj1.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpfcj1.Select(txtcpfcj1.Text.Length, 0);
                }
                if ((c == '.') && (txtcpfcj1.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpfcj1.Text = txtcpfcj1.Text.Remove(cont, 1);
                    txtcpfcj1.Select(txtcpfcj1.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpfcj1.Text.Length >= cont))
                {
                    txtcpfcj1.Text = txtcpfcj1.Text.Insert(11, "-");
                    txtcpfcj1.Select(txtcpfcj1.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpfcj1.Text.Length >= cont))
                {
                    txtcpfcj1.Text = txtcpfcj1.Text.Remove(cont, 1);
                    txtcpfcj1.Select(txtcpfcj1.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpfcj1.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpfcj1.Text = txtcpfcj1.Text.Remove(txtcpfcj1.Text.Length - 1);
                txtcpfcj1.Select(txtcpfcj1.Text.Length, 0);
            }
        }

        private void txtcpfcj2_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpfcj2.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpfcj2.Text.Length >= cont))
                {
                    txtcpfcj2.Text = txtcpfcj2.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpfcj2.Select(txtcpfcj2.Text.Length, 0);
                }
                if ((c == '.') && (txtcpfcj2.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpfcj2.Text = txtcpfcj2.Text.Remove(cont, 1);
                    txtcpfcj2.Select(txtcpfcj2.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpfcj2.Text.Length >= cont))
                {
                    txtcpfcj2.Text = txtcpfcj2.Text.Insert(11, "-");
                    txtcpfcj2.Select(txtcpfcj2.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpfcj2.Text.Length >= cont))
                {
                    txtcpfcj2.Text = txtcpfcj2.Text.Remove(cont, 1);
                    txtcpfcj2.Select(txtcpfcj2.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpfcj2.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpfcj2.Text = txtcpfcj2.Text.Remove(txtcpfcj2.Text.Length - 1);
                txtcpfcj2.Select(txtcpfcj2.Text.Length, 0);
            }
        }

        private void txtcpfcj3_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpfcj3.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpfcj3.Text.Length >= cont))
                {
                    txtcpfcj3.Text = txtcpfcj3.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpfcj3.Select(txtcpfcj3.Text.Length, 0);
                }
                if ((c == '.') && (txtcpfcj3.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpfcj3.Text = txtcpfcj3.Text.Remove(cont, 1);
                    txtcpfcj3.Select(txtcpfcj3.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpfcj3.Text.Length >= cont))
                {
                    txtcpfcj3.Text = txtcpfcj3.Text.Insert(11, "-");
                    txtcpfcj3.Select(txtcpfcj3.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpfcj3.Text.Length >= cont))
                {
                    txtcpfcj3.Text = txtcpfcj3.Text.Remove(cont, 1);
                    txtcpfcj3.Select(txtcpfcj3.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpfcj3.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpfcj3.Text = txtcpfcj3.Text.Remove(txtcpfcj3.Text.Length - 1);
                txtcpfcj3.Select(txtcpfcj3.Text.Length, 0);
            }
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
            btnaonjuge.Visible = true;
            btncj.Visible = true;
            btncj1.Visible = true;
            btncj2.Visible = true;
            btn_excluircj.Visible = true;
            btn_excluircj1.Visible = true;
            btn_excluircj2.Visible = true;
            btn_excluircj3.Visible = true;

            txtagenciacliente.ReadOnly = false;
            txtcontacliente.ReadOnly = false;
            txtobservacoes.ReadOnly = false;

            #region Conjuges
            txtnomeconjuge.ReadOnly = false;
            txtcpfcj.ReadOnly = false;
            txtrgcj.ReadOnly = false;
            txtnasccj.ReadOnly = false;
            txtemailcj.ReadOnly = false;
            txttelefonecj.ReadOnly = false;
            txtcelularcj.ReadOnly = false;
            txtrendacj.ReadOnly = false;
            checkBox_statuscj.Enabled = true;
            checkBox_Masculinocj.Enabled = true;
            checkBox_Femininocj.Enabled = true;
            txtagenciacj.ReadOnly = false;
            txtcontacj.ReadOnly = false;
            txtobservacaocj.ReadOnly = false;

            txtnomecj1.ReadOnly = false;
            txtcpfcj1.ReadOnly = false;
            txtrgcj1.ReadOnly = false;
            txtnasccj1.ReadOnly = false;
            txtemailcj1.ReadOnly = false;
            txttelefonecj1.ReadOnly = false;
            txtcelularcj1.ReadOnly = false;
            txtrendacj1.ReadOnly = false;
            checkBox_statuscj1.Enabled = true;
            checkBox_Masculinocj1.Enabled = true;
            checkBox_Femininocj1.Enabled = true;
            txtagenciacj1.ReadOnly = false;
            txtcontacj1.ReadOnly = false;
            txtobservacaocj1.ReadOnly = false;

            txtnomecj2.ReadOnly = false;
            txtcpfcj2.ReadOnly = false;
            txtrgcj2.ReadOnly = false;
            txtnasccj2.ReadOnly = false;
            txtemailcj2.ReadOnly = false;
            txttelefonecj2.ReadOnly = false;
            txtcelularcj2.ReadOnly = false;
            txtrendacj2.ReadOnly = false;
            checkBox_statuscj2.Enabled = true;
            checkBox_Masculinocj2.Enabled = true;
            checkBox_Femininocj2.Enabled = true;
            txtagenciacj2.ReadOnly = false;
            txtcontacj2.ReadOnly = false;
            txtobservacaocj2.ReadOnly = false;

            txtnomecj3.ReadOnly = false;
            txtcpfcj3.ReadOnly = false;
            txtrgcj3.ReadOnly = false;
            txtnasccj3.ReadOnly = false;
            txtemailcj3.ReadOnly = false;
            txttelefonecj3.ReadOnly = false;
            txtcelularcj3.ReadOnly = false;
            txtrendacj3.ReadOnly = false;
            checkBox_statuscj3.Enabled = true;
            checkBox_Masculinocj3.Enabled = true;
            checkBox_Femininocj3.Enabled = true;
            txtagenciacj3.ReadOnly = false;
            txtcontacj3.ReadOnly = false;
            txtobservacaocj3.ReadOnly = false;

            #endregion

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

            btnaonjuge.Visible = false;
            btncj.Visible = false;
            btncj1.Visible = false;
            btncj2.Visible = false;
            btn_excluircj.Visible = false;
            btn_excluircj1.Visible = false;
            btn_excluircj2.Visible = false;
            btn_excluircj3.Visible = false;

            #region Conjuges
            txtnomeconjuge.ReadOnly = true;
            txtcpfcj.ReadOnly = true;
            txtrgcj.ReadOnly = true;
            txtnasccj.ReadOnly = true;
            txtemailcj.ReadOnly = true;
            txttelefonecj.ReadOnly = true;
            txtcelularcj.ReadOnly = true;
            txtrendacj.ReadOnly = true;
            checkBox_statuscj.Enabled = false;
            checkBox_Masculinocj.Enabled = false;
            checkBox_Femininocj.Enabled = false;
            txtagenciacj.ReadOnly = true;
            txtcontacj.ReadOnly = true;
            txtobservacaocj.ReadOnly = true;

            txtnomecj1.ReadOnly = true;
            txtcpfcj1.ReadOnly = true;
            txtrgcj1.ReadOnly = true;
            txtnasccj1.ReadOnly = true;
            txtemailcj1.ReadOnly = true;
            txttelefonecj1.ReadOnly = true;
            txtcelularcj1.ReadOnly = true;
            txtrendacj1.ReadOnly = true;
            checkBox_statuscj1.Enabled = false;
            checkBox_Masculinocj1.Enabled = false;
            checkBox_Femininocj1.Enabled = false;
            txtagenciacj1.ReadOnly = true;
            txtcontacj1.ReadOnly = true;
            txtobservacaocj1.ReadOnly = true;

            txtnomecj2.ReadOnly = true;
            txtcpfcj2.ReadOnly = true;
            txtrgcj2.ReadOnly = true;
            txtnasccj2.ReadOnly = true;
            txtemailcj2.ReadOnly = true;
            txttelefonecj2.ReadOnly = true;
            txtcelularcj2.ReadOnly = true;
            txtrendacj2.ReadOnly = true;
            checkBox_statuscj2.Enabled = false;
            checkBox_Masculinocj2.Enabled = false;
            checkBox_Femininocj2.Enabled = false;
            txtagenciacj2.ReadOnly = true;
            txtcontacj2.ReadOnly = true;
            txtobservacaocj2.ReadOnly = true;

            txtnomecj3.ReadOnly = true;
            txtcpfcj3.ReadOnly = true;
            txtrgcj3.ReadOnly = true;
            txtnasccj3.ReadOnly = true;
            txtemailcj3.ReadOnly = true;
            txttelefonecj3.ReadOnly = true;
            txtcelularcj3.ReadOnly = true;
            txtrendacj3.ReadOnly = true;
            checkBox_statuscj3.Enabled = false;
            checkBox_Masculinocj3.Enabled = false;
            checkBox_Femininocj3.Enabled = false;
            txtagenciacj3.ReadOnly = true;
            txtcontacj3.ReadOnly = true;
            txtobservacaocj3.ReadOnly = true;

            #endregion


            img_foto.Enabled = false;
            btn_add_foto.Enabled = false;
            btn_limpar_foto.Enabled = false;
        }
    }
}
