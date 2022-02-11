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
    public partial class Form_Cadastro_Cliente : Form
    {

        String sexo, status, idCliente, idConjuge, valor, arquivo, CPF, RG, Agencia, Conta, telefone, celular, sequencia;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        bool cj, cj1, cj2, cj3;
        bool conjuge;
        int newidcli, newidcj, checkcpf;



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

            txtnomecli.Select(txtnomecli.Text.Length, 0);
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();

            Settxtrenda(txtrendacli);
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
                    Settxtrenda(txtrendacj1);
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
                        Settxtrenda(txtrendacj2);
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
                    Settxtrenda(txtrendacj3);
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
                    Settxtrenda(txtrendacj);
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

        private void Settxtrenda(TextBox nametxt)
        {
            valor = nametxt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                nametxt.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                nametxt.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                nametxt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (nametxt.Text.StartsWith("0,"))
                {
                    nametxt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (nametxt.Text.Contains("00,"))
                {
                    nametxt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    nametxt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = nametxt.Text;
            nametxt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            nametxt.Select(nametxt.Text.Length, 0);
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

            #region Check CPF
            LoginDaoComandos checkexistecpf = new LoginDaoComandos();

            
            Cliente cliente = null;

            cliente = checkexistecpf.GetCPFCliente(CPF);

            string idcli = cliente.Id_cliente;
            string nomecli = cliente.Nome_cliente;
            string cpf = cliente.CPF_cliente;

            if (string.IsNullOrEmpty(cliente.CPF_cliente))
            {

                //MessageBox.Show("Existe CPF" + cliente.CPF_cliente);
                //return;





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

                SomaRenda();
                String rendabruta = txtrendatotal.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

                LoginDaoComandos inserircliente = new LoginDaoComandos();

                newidcli = inserircliente.CadastrarCliente(txtnomecli.Text, txtemail.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, rendabruta, txtobservacoes.Text, conjuge);

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

                        updateconta.InsertConta(idCliente, Agencia, Conta, "C", "0", "0");
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
            else
            {
                var result = MessageBox.Show("Já Existe um Cadastro com este CPF \n CPF: "+ cpf  + " \n Cliente: " + nomecli + " \n Deseja Editalo ?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente();
                    frm_dados_clientes.setIdCliente(idcli);
                    //clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                    //frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                    frm_dados_clientes.Show();
                    Cursor = Cursors.Default;
                    //MessageBox.Show("Já Existe um Cadastro com este CPF \n Deseja Editalo ?", "Cadastro",);
                    Close();
                }
                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }
            #endregion
        }

        private void SaveConjuges()
        {
            #region Conjuge
            if (cj == true)
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
                conjuge = cj1;
                if (newidcli >= 0)
                {
                    LoginDaoComandos inserirconjuge = new LoginDaoComandos();

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge.Text, txtemailcj.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj.Text, newidcli.ToString(), sequencia, conjuge);


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

                        updateconta.InsertConta(newidcli.ToString(), Agencia, Conta, "CJ", idConjuge, "1");
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

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge2.Text, txtemailcj2.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj2.Text, newidcli.ToString(), sequencia, conjuge);


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

                    newidcj = inserirconjuge.CadastrarConjuge(txtnomeconjuge3.Text, txtemailcj3.Text, telefone, celular, CPF, RG, datanasc, sexo, status, renda, txtobservacoescj3.Text, newidcli.ToString(), sequencia, conjuge);


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


                }
            }
            #endregion
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
                lblnomecj2.Text = txtnomeconjuge1.Text;
            }
            else
            {
                vl3 = 0;
                lblrendacj2.Text = txtrendacj1.Text;
                lblnomecj2.Text = txtnomeconjuge1.Text;
            }
            if (txtrendacj2.Text != "")
            {
                vl4 = decimal.Parse(txtrendacj2.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj3.Text = txtrendacj2.Text;
                lblnomecj3.Text = txtnomeconjuge2.Text;
            }
            else
            {
                vl4 = 0;
                lblrendacj3.Text = txtrendacj2.Text;
                lblnomecj3.Text = txtnomeconjuge2.Text;
            }
            if (txtrendacj3.Text != "")
            {
                vl5 = decimal.Parse(txtrendacj3.Text.Replace("R$", "").Replace(" ", "").Replace("00,", ""));
                lblrendacj4.Text = txtrendacj3.Text;
                lblnomecj4.Text = txtnomeconjuge3.Text;
            }
            else
            {
                vl5 = 0;
                lblrendacj4.Text = txtrendacj3.Text;
                lblnomecj4.Text = txtnomeconjuge3.Text;
            }

            result = vl1 + vl2 + vl3 + vl4 + vl5;


            txtrendatotal.Text = string.Format("{0:C}", Convert.ToDouble(result.ToString()));
            btn_salvar.Select();

            return result;
        }
    }
}
