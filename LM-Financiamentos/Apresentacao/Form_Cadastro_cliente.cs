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
    public partial class Form_Cadastro_Cliente : Form
    {

        String sexo, status, idCliente, idConjuge, valor, arquivo, CPF, RG, Agencia, Conta, telefone, celular, sequencia;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        bool cj, cj1, cj2, cj3;
        bool conjuge;
        int newidcli, newidcj;



        public Form_Cadastro_Cliente()
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
            tabControl.TabPages.Remove(tabconjuge);
            tabControl.TabPages.Remove(tabconjuge1);
            tabControl.TabPages.Remove(tabconjuge2);
            tabControl.TabPages.Remove(tabconjuge3);
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
                if (!tabControl.TabPages.Contains(tabconjuge1))
                {
                    tabControl.TabPages.Insert(2, tabconjuge1);
                    tabControl.SelectedTab = tabconjuge1;
                    txtnomeconjuge1.Select();
                    cj1 = true;
                    conjuge = true;
                }
            }
        }

        private void btnconjuge2_Click(object sender, EventArgs e)
        {
            if (txtnomeconjuge1.Text == "")
            {
                MessageBox.Show("Campo Nome do Cônjuge 1 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomeconjuge1.Select();
            }
            else if (txtcpfcj1.Text == "")
            {
                MessageBox.Show("Campo CPF do Cônjuge 1 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpfcj1.Select();

            }
            else
            {
                if (txtnomecli != null && txtcpf != null)
                {
                    if (!tabControl.TabPages.Contains(tabconjuge2))
                    {
                        tabControl.TabPages.Insert(3, tabconjuge2);
                        tabControl.SelectedTab = tabconjuge2;
                        txtnomeconjuge2.Select();
                        cj2 = true;
                        conjuge = true;
                    }
                }
            }
        }

        private void btnconjuge3_Click(object sender, EventArgs e)
        {
            if (txtnomeconjuge2.Text == "")
            {
                MessageBox.Show("Campo Nome do Cônjuge 2 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomeconjuge2.Select();
            }
            else if (txtcpfcj2.Text == "")
            {
                MessageBox.Show("Campo CPF do Cônjuge 2 é necessário para adiconar novo Cônjuge!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpfcj2.Select();

            }
            else
            {
                if (!tabControl.TabPages.Contains(tabconjuge3))
                {
                    tabControl.TabPages.Insert(4, tabconjuge3);
                    tabControl.SelectedTab = tabconjuge3;
                    txtnomeconjuge3.Select();
                    cj3 = true;
                    conjuge = true;
                }
            }
        }

        private void btn_excluirconjuge3_Click(object sender, EventArgs e)
        {
            txtnomeconjuge3.Clear();
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
            txtobservacoescj3.Clear();
            tabControl.TabPages.Remove(tabconjuge3);
            tabControl.SelectedTab = tabconjuge2;
            cj3 = false;

        }

        private void btn_excluirconjuge2_Click(object sender, EventArgs e)
        {
            txtnomeconjuge2.Clear();
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
            txtobservacoescj2.Clear();
            tabControl.TabPages.Remove(tabconjuge2);
            tabControl.SelectedTab = tabconjuge1;
            cj2 = false;
        }

        private void btn_excluirconjuge1_Click(object sender, EventArgs e)
        {
            txtnomeconjuge1.Clear();
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
            txtobservacoescj1.Clear();
            tabControl.TabPages.Remove(tabconjuge1);
            tabControl.SelectedTab = tabconjuge;
            cj1 = false;
        }

        private void btn_excluirconjuge_Click(object sender, EventArgs e)
        {
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
            txtobservacoescj.Clear();
            tabControl.TabPages.Remove(tabconjuge);
            tabControl.SelectedTab = tabcliente;
            cj = false;
            conjuge = false;
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

        private void btnaddconjuge_Click(object sender, EventArgs e)
        {
            tabconjuge.Enabled = true;
        }

        private void btnconjuge_Click(object sender, EventArgs e)
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

                if (!tabControl.TabPages.Contains(tabconjuge))
                {
                    tabControl.TabPages.Insert(1, tabconjuge);
                    tabControl.SelectedTab = tabconjuge;
                    txtnomeconjuge.Select();
                    cj = true;
                    conjuge = true;
                }


            }

        }

        private void txtrg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtrg_KeyUp(object sender, KeyEventArgs e)
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
        public event Action ClienteSalvo;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtnomecli.Text == "")
            {
                MessageBox.Show("Campo Nome do Cliente é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabcliente;
                txtnomecli.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtcpf.Text == "")
            {
                MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabcliente;
                txtcpf.Select();
                Cursor = Cursors.Default;
                return;
            }
            CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);

            if (cj == true || cj1 == true || (cj2 == true) || cj3 == true)
            {

                if (cj == true)
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

                }
                if (cj1 == true)
                {
                    if (txtnomeconjuge1.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 1 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge1;
                        txtnomeconjuge1.Select();
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

                }
                if (cj2 == true)
                {
                    if (txtnomeconjuge2.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 2 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge2;
                        txtnomeconjuge2.Select();
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

                }
                if (cj3 == true)
                {
                    if (txtnomeconjuge3.Text == "")
                    {
                        MessageBox.Show("Campo Nome do Cônjuge 3 é necessário", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl.SelectedTab = tabconjuge3;
                        txtnomeconjuge3.Select();
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

                }
                conjuge = true;

            }
            else
            {
                conjuge = false;
            }



            status = "Ativo";

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

            if (txtrg.Text == "")
            {
                RG = "0";
            }
            else
            {
                RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);
            }

            DateTime dataa;
            DateTime.TryParse(txtnasc.Text + " " + "00:00:00", out dataa);

            DateTime datanasc = dataa;

            String renda = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            #region Telefone
            if (string.IsNullOrEmpty(txttelefone.Text))
            {
                if (string.IsNullOrEmpty(txtcelular.Text))
                {


                    MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControl.SelectedTab = tabcliente;
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



            LoginDaoComandos inserircliente = new LoginDaoComandos();

            newidcli = inserircliente.CadastrarCliente(txtnomecli.Text, txtemail.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoes.Text, conjuge);

            if (newidcli >= 0)
            {
                if (cj == true)
                {
                    SaveConjuges();
                }
                if (txtcontacliente != null && txtagenciacliente != null)
                {
                    idCliente = newidcli.ToString();

                    Conta = txtcontacliente.Text;
                    Agencia = txtagenciacliente.Text;

                    LoginDaoComandos updateconta = new LoginDaoComandos();

                    updateconta.InsertConta(idCliente, Agencia, Conta, "C","0","0");
                    if (updateconta.mensagem != "OK")
                    {
                        MessageBox.Show("Cliente Cadastrado! \n Agência e Conta com erro! \n " + updateconta.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }

                }
                if (excluirimage == "Update")
                {
                    LoginDaoComandos insertfotocliente = new LoginDaoComandos();
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotocliente.InsertFotoCliente(newidcli.ToString(), imgContent, txtnomecli.Text);

                    if (insertfotocliente.mensagem == "OK")
                    {
                        MessageBox.Show("Cliente Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor = Cursors.Default;
                        Close();
                        if (ClienteSalvo != null)
                            ClienteSalvo.Invoke();
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show(insertfotocliente.mensagem, "Inserindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.Default;
                    Close();
                    if (ClienteSalvo != null)
                        ClienteSalvo.Invoke();
                }
                Cursor = Cursors.Default;
            }
        }

        private void SaveConjuges()
        {
            #region Conjuge
            if (cj == true)
            {

                Cursor = Cursors.WaitCursor;
                //if (txtnomeconjuge.Text == "")
                //{
                //    MessageBox.Show("Campo Nome do Cônjuge é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtnomeconjuge.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}

                //if (txtcpfcj.Text == "")
                //{
                //    MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtcpfcj.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}
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
                //#region Telefone
                //if (string.IsNullOrEmpty(txttelefonecj.Text))
                //{
                //    if (string.IsNullOrEmpty(txtcelularcj.Text))
                //    {


                //        MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txttelefonecj.Select();
                //        Cursor = Cursors.Default;
                //        return;
                //    }

                //}
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
                //#endregion
                sequencia = "0";
                conjuge = cj1;
                if (newidcli >= 0)
                {
                    LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge.Text, txtemailcj.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj.Text, newidcli.ToString(), sequencia,conjuge);


                    if (txtcontacj != null && txtagenciacj != null)
                    {
                        idConjuge = newidcj.ToString();

                        Conta = txtcontacj.Text;
                        Agencia = txtagenciacj.Text;

                        LoginDaoComandos updateconta = new LoginDaoComandos();

                        updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ",idConjuge,"0");
                        if (updateconta.mensagem != "OK")
                        {
                            MessageBox.Show("Conta do Cônjuge não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            Close();

                        }
                        Cursor = Cursors.Default;
                    }


                }
            }
            #endregion
            #region Conjuge1
            if (cj1 == true)
            {

                Cursor = Cursors.WaitCursor;
                //if (txtnomeconjuge1.Text == "")
                //{
                //    MessageBox.Show("Campo Nome do Cônjuge 1 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtnomeconjuge1.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}

                //if (txtcpfcj1.Text == "")
                //{
                //    MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtcpfcj1.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}
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
                //#region Telefone
                //if (string.IsNullOrEmpty(txttelefonecj1.Text))
                //{
                //    if (string.IsNullOrEmpty(txtcelularcj1.Text))
                //    {


                //        MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txttelefonecj1.Select();
                //        Cursor = Cursors.Default;
                //        return;
                //    }

                //}
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
                //#endregion
                sequencia = "1";
                conjuge = cj2;
                if (newidcli >= 0)
                {
                    LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge1.Text, txtemailcj1.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj1.Text, newidcli.ToString(), sequencia, conjuge);


                    if (txtcontacj1 != null && txtagenciacj1 != null)
                    {
                        idConjuge = newidcj.ToString();

                        Conta = txtcontacj1.Text;
                        Agencia = txtagenciacj1.Text;

                        LoginDaoComandos updateconta = new LoginDaoComandos();

                        updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ",idConjuge,"1");
                        if (updateconta.mensagem != "OK")
                        {
                            MessageBox.Show("Conta do Cônjuge 1 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            Close();

                        }
                        Cursor = Cursors.Default;
                    }


                }
            }
            #endregion
            #region Conjuge2
            if (cj2 == true)
            {

                Cursor = Cursors.WaitCursor;
                //if (txtnomeconjuge2.Text == "")
                //{
                //    MessageBox.Show("Campo Nome do Cônjuge 2 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtnomeconjuge2.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}

                //if (txtcpfcj2.Text == "")
                //{
                //    MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtcpfcj2.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}
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
                //#region Telefone
                //if (string.IsNullOrEmpty(txttelefonecj2.Text))
                //{
                //    if (string.IsNullOrEmpty(txtcelularcj2.Text))
                //    {


                //        MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txttelefonecj2.Select();
                //        Cursor = Cursors.Default;
                //        return;
                //    }

                //}
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
                //#endregion
                sequencia = "2";
                conjuge = cj3;
                if (newidcli >= 0)
                {
                    LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge2.Text, txtemailcj2.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj2.Text, newidcli.ToString(), sequencia,conjuge);


                    if (txtcontacj2 != null && txtagenciacj2 != null)
                    {
                        idConjuge = newidcj.ToString();

                        Conta = txtcontacj2.Text;
                        Agencia = txtagenciacj2.Text;

                        LoginDaoComandos updateconta = new LoginDaoComandos();

                        updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ",idConjuge,"2");
                        if (updateconta.mensagem != "OK")
                        {
                            MessageBox.Show("Conta do Cônjuge 2 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            Close();

                        }
                        Cursor = Cursors.Default;
                    }


                }
            }
            #endregion
            #region Conjuge3
            if (cj3 == true)
            {

                Cursor = Cursors.WaitCursor;
                //if (txtnomeconjuge3.Text == "")
                //{
                //    MessageBox.Show("Campo Nome do Cônjuge 3 é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtnomeconjuge3.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}

                //if (txtcpfcj3.Text == "")
                //{
                //    MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtcpfcj3.Select();
                //    Cursor = Cursors.Default;
                //    return;
                //}
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
                //#region Telefone
                //if (string.IsNullOrEmpty(txttelefonecj3.Text))
                //{
                //    if (string.IsNullOrEmpty(txtcelularcj3.Text))
                //    {


                //        MessageBox.Show("É necessário preencher o campo Telefone ou Celular", "Necessário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        txttelefonecj3.Select();
                //        Cursor = Cursors.Default;
                //        return;
                //    }

                //}
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
                //#endregion
                sequencia = "3";
                conjuge = false;
                if (newidcli >= 0)
                {
                    LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge3.Text, txtemailcj3.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj3.Text, newidcli.ToString(), sequencia,conjuge);


                    if (txtcontacj3 != null && txtagenciacj3 != null)
                    {
                        idConjuge = newidcj.ToString();

                        Conta = txtcontacj3.Text;
                        Agencia = txtagenciacj3.Text;

                        LoginDaoComandos updateconta = new LoginDaoComandos();

                        updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ",idConjuge,"3");
                        if (updateconta.mensagem != "OK")
                        {
                            MessageBox.Show("Conta do Cônjuge 3 não Cadastrada!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            Close();

                        }
                        Cursor = Cursors.Default;
                    }


                }
            }
            #endregion
        }
    }
}
