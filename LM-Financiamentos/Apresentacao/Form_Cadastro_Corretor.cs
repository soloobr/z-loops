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
    public partial class Form_Cadastro_Corretor : Form
    {

        String sexo, status,  valor, CPF, RG;
        String excluirimage, permission;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;

        public string idCorretor;

        public Form_Cadastro_Corretor()
        {
            InitializeComponent();

        }

        public void setTextNome(String sNome)
        {
            txtnomecorretor.Text = sNome;

        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_Corretor_Load(object sender, EventArgs e)
        {

            //txtnomecli.Select();
            //txtnomecli.ScrollToCaret();
            //txtnomecli.Focus();

            txtnomecorretor.Select(txtnomecorretor.Text.Length, 0);
            this.ActiveControl = txtnomecorretor;
            txtnomecorretor.Focus();

            
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
        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacli.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }*/
        }

        private void txtnomecli_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
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

        private void txtrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtrendacli.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }*/


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
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public event Action CorretorSalvo;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            if (string.IsNullOrEmpty(txtnomecorretor.Text))
            {
                MessageBox.Show("Campo Nome do Corretor é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecorretor.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtcpf.Text == "")
            {
                MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpf.Select();
                Cursor = Cursors.Default;
                return;
            }
            CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);

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

            status = "Ativo";

            if (txtpermission.Text != "")
            {
                if (txtpermission.Text == "Operador(a)")
                {
                    permission = "3";
                }
                else if (txtpermission.Text == "Supervisor(a)")
                {
                    permission = "2";
                }
                else if (txtpermission.Text == "Gerente")
                {
                    permission = "1";
                }
                else if (txtpermission.Text == "Master")
                {
                    permission = "0";
                }

            }
            else
            {
                permission = "3";
            }

            LoginDaoComandos inserircorretor = new LoginDaoComandos();

            int newidfunc = inserircorretor.CadastrarCorretor(txtnomecorretor.Text, CPF, txtemail.Text, datanasc, txttelefone.Text, txtcelular.Text, txtendereco.Text, RG, sexo, status); 

            if (newidfunc >= 0)
            {
              
                idCorretor = newidfunc.ToString();

                    MessageBox.Show("Corretor Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (CorretorSalvo != null)
                        CorretorSalvo.Invoke();

                    Cursor = Cursors.Default;
                    Close();
            
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro ao Cadastrar o Corretor!", "Cadastrando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
    }
}
