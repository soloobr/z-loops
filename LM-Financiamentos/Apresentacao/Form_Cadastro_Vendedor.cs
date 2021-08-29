using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Vendedor : Form
    {

        String sexo, status, idVendedor, valor, renda, nascimento, arquivo, CPF, CNPJ, Agencia, Conta, celular, telefone;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;



        public Form_Cadastro_Vendedor()
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

        private void Form_Cadastro_Vendedor_Load(object sender, EventArgs e)
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

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcpf_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

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

        private void txtrg_KeyUp(object sender, KeyEventArgs e)
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
        private void Settxtcpf()
        {
            valor = txtcpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
            if (valor.Length == 0)
            {
                txtcpf.Text = valor;
            }
            if (valor.Length == 1)
            {
                txtcpf.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtcpf.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtcpf.Text.StartsWith("0,"))
                {
                    txtcpf.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtcpf.Text.Contains("00,"))
                {
                    txtcpf.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtcpf.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtcpf.Text;
            txtcpf.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtcpf.Select(txtcpf.Text.Length, 0);
        }
        private void txtrendacli_Leave(object sender, EventArgs e)
        {
            valor = txtrendacli.Text.Replace("R$", "");
            txtrendacli.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_foto_Click(object sender, EventArgs e)
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
        public event Action VendedorSalvo;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtnomecli.Text == "")
            {
                MessageBox.Show("Campo Nome do Vendedor é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecli.Select();
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
            status = "Ativo";

            //if (checkBox_Masculino.Checked)
            //{
            //    sexo = "Masculino";
            //}
            //else if (checkBox_Feminino.Checked)
            //{
            //    sexo = "Feminino";
            //}
            //else
            //{
            //    sexo = "";
            //}



            //DateTime dataa;
            //DateTime.TryParse(txtnasc.Text + " " + "00:00:00", out dataa);

            //DateTime datanasc = dataa;

            //String renda = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

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

            LoginDaoComandos inserirvendedor = new LoginDaoComandos();

            int newidcli = inserirvendedor.CadastrarVendedor(txtnomecli.Text, txtemail.Text, telefone, celular, CPF, CNPJ, status);

            if (newidcli >= 0)
            {
                if (excluirimage == "Update")
                {
                    LoginDaoComandos insertfotovendedor = new LoginDaoComandos();
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotovendedor.InsertFotoVendedor(newidcli.ToString(), imgContent, txtnomecli.Text);

                    if (insertfotovendedor.mensagem == "OK")
                    {
                        //MessageBox.Show("Vendedor Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cursor = Cursors.Default;
                        //Close();
                        //if (VendedorSalvo != null)
                        //    VendedorSalvo.Invoke();
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(insertfotovendedor.mensagem, "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (txtcontavendedor != null && txtagenciavendedor != null)
                {
                    idVendedor = newidcli.ToString();

                    Conta = txtcontavendedor.Text;
                    Agencia = txtagenciavendedor.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.InsertConta(idVendedor, Agencia, Conta, "V", "0", "0");
                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Vendedor Cadastrado! \n Agencia e Conta com erro! \n " + updateconta.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                }
                else if (txtagenciavendedor != null && txtcontavendedor == null)
                {
                    MessageBox.Show("é necessario preenchar a conta!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtagenciavendedor == null && txtcontavendedor != null)
                {
                    MessageBox.Show("é necessario preenchar a Agância!", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Vendedor Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.Default;

                if (VendedorSalvo != null)
                    VendedorSalvo.Invoke();

                Cursor = Cursors.Default;
                Close();
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro ao Cadastrar o Vendedor!", "Cadastrando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
