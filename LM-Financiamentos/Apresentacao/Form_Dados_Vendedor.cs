using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Vendedor : Form
    {
        string sexo, status, idVendedor, valor, renda, nascimento, arquivo, CNPJ, CPF, Agencia, Conta, telefone, celular;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        private string idProcesso;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;

        public Form_Dados_Vendedor()
        {
            InitializeComponent();
        }
        public void setIdVendedor(string idvend)
        {
            idVendedor = idvend;
        }
        public void setUserLoged(string idresp, string nomefunc)
        {
            if (idresp != null)
            {
                idresponsavel = idresp;
                idresponsavelSelected = idresp;
            }
            if (nomefunc != null)
            {
                nomeresponsavel = nomefunc;
            }
        }
        public void setTextNome(String sNome)
        {
            txtnomevendedor.Text = sNome;

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
                    e.Handled = (txtrendavendedor.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrendacli_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtrendavendedor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendavendedor.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendavendedor.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendavendedor.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendavendedor.Text.StartsWith("0,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendavendedor.Text.Contains("00,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendavendedor.Text;
            txtrendavendedor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendavendedor.Select(txtrendavendedor.Text.Length, 0);
        }

        private void txtrendacli_Leave(object sender, EventArgs e)
        {
            valor = txtrendavendedor.Text.Replace("R$", "");
            txtrendavendedor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;



            if (txtnomevendedor.Text == "")
            {
                MessageBox.Show("Campo Nome do Vendedor é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomevendedor.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtcpf.Text == "" && txtcnpj.Text == "")
            {
                MessageBox.Show("Campo CPF ou CNPJ é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpf.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtcpf.Text == "")
            {
                CPF = "0";
            }
            else
            {
                CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);

            }

            if (txtcnpj.Text == "")
            {
                CNPJ = "0";
            }
            else
            {
                CNPJ = FormatCnpjCpf.SemFormatacao(txtcnpj.Text);
            }
            //String RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);
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

            //DateTime dataa;
            //DateTime.TryParse(txtnasc.Text + " " + "00:00:00", out dataa);

            //DateTime datanasc = dataa;

            //DateTime datanasc = DateTime.Parse(nascimento);



            String renda = txtrendavendedor.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

            LoginDaoComandos insertfotovendedor = new LoginDaoComandos();
            if (excluirimage == "Update")
            {
                if (arquivobase == false)
                {
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotovendedor.InsertFotoVendedor(idVendedor, imgContent, txtnomevendedor.Text);
                }
                else
                {
                    fsObj = File.OpenRead(arquivo);
                    // MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotovendedor.UpdateFotoVendedor(idVendedor, imgContent);
                }
                if (insertfotovendedor.mensagem == "OK")
                {

                }
                else
                {
                    MessageBox.Show(insertfotovendedor.mensagem, "Atualizando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (excluirimage == "Excluir")
            {
                LoginDaoComandos excluirvendedor = new LoginDaoComandos();
                excluirvendedor.DeleteFotoVendedor(idVendedor);
                if (excluirvendedor.mensagem == "Excluido")
                {

                }
                else
                {
                    MessageBox.Show(insertfotovendedor.mensagem, "Apagando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (txtcontavendedor.Text != null && txtagenciavendedor.Text != null)
            {

                Conta = txtcontavendedor.Text;
                Agencia = txtagenciavendedor.Text;

                LoginDaoComandos updateconta = new LoginDaoComandos();

                updateconta.UpdateConta(idVendedor, Agencia, Conta, "V");

                //MessageBox.Show(updateconta.mensagem);
                if (updateconta.mensagem == "Erro")
                {
                    updateconta.InsertConta(idVendedor, Agencia, Conta, "V", "0", "0");
                }

            }
            else if (txtagenciavendedor.Text != null && txtcontavendedor.Text == null)
            {
                MessageBox.Show("é necessario preenchar a conta!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtagenciavendedor == null && txtcontavendedor != null)
            {
                MessageBox.Show("é necessario preenchar a Agância!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoginDaoComandos updatevendedor = new LoginDaoComandos();

            updatevendedor.UpdateVendedor(idVendedor, txtnomevendedor.Text, CPF, CNPJ, txtemail.Text, telefone, celular, status);

            Cursor = Cursors.Default;

            MessageBox.Show(updatevendedor.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btn_editar.Visible = true;
            splitter1.Visible = false;
            btn_cancelar.Visible = false;
            splitter2.Visible = false;
            btn_salvar.Visible = false;


            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();

            if (VendedorSalvo != null)
                VendedorSalvo.Invoke();

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
            LoadDadosVendedor();
            tabControl.SelectedTab = tabControl.TabPages["tabvendedor"];

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

        private void Form_Dados_Vendedor_Load(object sender, EventArgs e)
        {
            LoadDadosVendedor();
        }

        public void LoadDadosVendedor()
        {
            Cursor = Cursors.WaitCursor;
            Vendedor vendedor = null;

            LoginDaoComandos getvendedor = new LoginDaoComandos();
            vendedor = getvendedor.GetVendedor(idVendedor);

            txtnomevendedor.Text = vendedor.Nome_vendedor;
            txtcpf.Text = vendedor.CPF_vendedor;
            txtcnpj.Text = vendedor.CNPJ_vendedor;
            txtnasc.Text = vendedor.Nascimento_vendedor;
            txtemail.Text = vendedor.Email_vendedor;
            txttelefone.Text = vendedor.Telefone_vendedor;
            txtcelular.Text = vendedor.Celular_vendedor;
            txtrendavendedor.Text = vendedor.Renda_vendedor;
            txtagenciavendedor.Text = vendedor.Agencia_vendedor;
            txtcontavendedor.Text = vendedor.Conta_vendedor;

            if (vendedor.Sexo_vendedor == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (vendedor.Sexo_vendedor == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (vendedor.Status_vendedor == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Vendedor Ativo";
            }

            if (vendedor.Status_vendedor == "Inativo")
            {
                checkBox_status.Text = "Vendedor Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Vendedor
            valor = txtrendavendedor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendavendedor.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendavendedor.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendavendedor.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendavendedor.Text.StartsWith("0,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendavendedor.Text.Contains("00,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendavendedor.Text;
            txtrendavendedor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendavendedor.Select(txtrendavendedor.Text.Length, 0);
            #endregion

            txtnomevendedor.Select(txtnomevendedor.Text.Length, 0);
            this.ActiveControl = txtnomevendedor;
            txtnomevendedor.Focus();
            Cursor = Cursors.Default;
        }
        public event Action VendedorSalvo;
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

        private void txtcpf_KeyUp(object sender, KeyEventArgs e)
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

        private void txtcnpj_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcnpj.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((c == '.') && (txtcnpj.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtcnpj.Text = txtcnpj.Text.Remove(cont, 1);
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((cont == 10) && (c != '/') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(10, @"/");
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }


                if ((cont == 14) && (c != '-') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(15, "-");
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((c == '-') && (cont != 16) && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Remove(cont, 1);
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                cont++;
            }

            valor = txtcnpj.Text;
            if (valor.Length >= 19)
            {
                MessageBox.Show("Limete maximo para o CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcnpj.Text = txtcnpj.Text.Remove(txtcnpj.Text.Length - 1);
                txtcnpj.Select(txtcnpj.Text.Length, 0);
            }
        }

        private void txtcnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtcnpj.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }

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

                        getfoto.GetFotoVendedor(idVendedor);
                        setFoto(getfoto.GetFotoVendedor(idVendedor).Foto_vendedor);
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

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
                String idvendedorexclude = idVendedor;
                var result = MessageBox.Show("Deseja Excluir o Vendedor: \n \n " + txtnomevendedor.Text + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deletevendedor = new LoginDaoComandos();

                    DataTable dt = deletevendedor.GetProcessoVendedor(idvendedorexclude);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow[] rows = dt.Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            idProcesso = rows[i]["id"].ToString();
                        }
                        var result1 = MessageBox.Show("Não Foi possível Excluir o Vendedor: \n \n " + txtnomevendedor.Text + " !  \n  \n Existe Processo Ativo para esse Vendedor. \n \n Deseja Alterar o Vendedor do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (result1 == DialogResult.Yes)
                        {
                            Form_Dados_Processos frm_dados_documentos = new Form_Dados_Processos();
                            frm_dados_documentos.setIdProcess(idProcesso);
                            frm_dados_documentos.setUserLoged(idresponsavel, nomeresponsavel);
                            frm_dados_documentos.setTABcontrol(1);
                            frm_dados_documentos.Show();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vendedor não Excluído!");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    if (img_foto.Image != null)
                    {
                        deletevendedor.DeleteFotoVendedor(idVendedor);
                        MessageBox.Show(deletevendedor.mensagem, "Excluidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (VendedorSalvo != null)
                            VendedorSalvo.Invoke();
                        Close();
                    }
                    else
                    {
                        deletevendedor.DeleteVendedor(idVendedor);
                        MessageBox.Show(deletevendedor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (VendedorSalvo != null)
                            VendedorSalvo.Invoke();
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
                checkBox_status.Text = "Vendedor Ativo";
                status = "Ativo";
            }
            else
            {
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Text = "Vendedor Inativo";
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
            txtnomevendedor.Select();
        }


        private void HabilitarEdicao()
        {
            txtnomevendedor.ReadOnly = false;
            txtcpf.ReadOnly = false;
            txtcnpj.ReadOnly = false;
            txtnasc.ReadOnly = false;
            txtemail.ReadOnly = false;
            txttelefone.ReadOnly = false;
            txtcelular.ReadOnly = false;
            txtrendavendedor.ReadOnly = false;
            checkBox_status.Enabled = true;
            checkBox_Masculino.Enabled = true;
            checkBox_Feminino.Enabled = true;
            txtagenciavendedor.ReadOnly = false;
            txtcontavendedor.ReadOnly = false;

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
            txtnomevendedor.ReadOnly = true;
            txtcpf.ReadOnly = true;
            txtcnpj.ReadOnly = true;
            txtnasc.ReadOnly = true;
            txtemail.ReadOnly = true;
            txttelefone.ReadOnly = true;
            txtcelular.ReadOnly = true;
            txtrendavendedor.ReadOnly = true;
            checkBox_status.Enabled = false;
            checkBox_Masculino.Enabled = false;
            checkBox_Feminino.Enabled = true;
            txtcontavendedor.ReadOnly = true;

            img_foto.Enabled = false;
            btn_add_foto.Enabled = false;
            btn_limpar_foto.Enabled = false;
        }
    }
}
