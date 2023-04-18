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
    public partial class Form_Cadastro_Construtora : Form
    {
        String descricaoempre, listmessage, valor, CNPJ;
        int newidag;

        public string idconstrutora;

        private Form_Dados_Construtora newFormDadosAg { get; set; }

        public Form_Cadastro_Construtora()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Construtora)
                {
                    Form_Dados_Construtora formularioPai = (Form_Dados_Construtora)this.Owner;
                }
            }
        }
        public string AtributoAcessadoPorOutroForm
        {
            get;
            set;
        }
        public void setTextNome(String sNome)
        {
            txtdescricaoconstrutora.Text = sNome;
        }
        public void setAgCad(string idag)
        {
            if (idag != null)
            {
                idconstrutora = idag;
            }
        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_Construtora_Load(object sender, EventArgs e)
        {
            LoginDaoComandos countconstrutora = new LoginDaoComandos();

            int ultimoID = countconstrutora.CountConstrutora();
            int newidemp = ultimoID;

            txtconstrutora.Text = newidemp.ToString();
            txtdescricaoconstrutora.Select(txtdescricaoconstrutora.Text.Length, 0);
            this.ActiveControl = txtdescricaoconstrutora;
            txtdescricaoconstrutora.Focus();
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
               
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public event Action ConstrutoraSalvo;
        public event Action ConstrutoraSalvoEdit;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtdescricaoconstrutora.Text == "")
            {
                MessageBox.Show("Campo Descrição da Construtora é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtdescricaoconstrutora.Select();
                Cursor = Cursors.Default;
                return;
            }
            if (txtcnpj.Text == "")
            {
                MessageBox.Show("Campo CNPJ é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtcnpj.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço da Construtora é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            descricaoempre = txtdescricaoconstrutora.Text;
            

            #region Check Construtora
            LoginDaoComandos checkexisteag = new LoginDaoComandos();

            
            Construtora construtora = null;

            construtora = checkexisteag.GetNumConstrutora(descricaoempre);

            string idag = construtora.Id_construtora;
            string descriag = construtora.Descri_construtora;
            string end = construtora.End_construtora;

            var highScores = checkexisteag.GetConstrutoraM(descricaoempre);

            listmessage = "";
            foreach (var item in highScores)
            {
                
                listmessage =  listmessage + "\n" +  ($"{item.Id_construtora}")+ " - " + ($"{item.Descri_construtora}");
            }


            if (string.IsNullOrEmpty(idag))
            {

                LoginDaoComandos inserirconstrutora = new LoginDaoComandos();
                
                CNPJ = FormatCnpjCpf.SemFormatacao(txtcnpj.Text);

                newidag = inserirconstrutora.CadastrarConstrutora(txtdescricaoconstrutora.Text, CNPJ, txtend.Text);

                if (newidag >= 0)
                {
                        idconstrutora  = newidag.ToString();
                        MessageBox.Show("Construtora Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                        if (ConstrutoraSalvo != null)
                        ConstrutoraSalvo.Invoke();
                        Close();

                    Cursor = Cursors.Default;
                }

            }
            else
            {
                    var result = MessageBox.Show("Foi encontrado registro com essa Descrição ! \n \n Construtora: " + listmessage + " \n \n Confirma o cadastro ?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        LoginDaoComandos inserirconstrutora = new LoginDaoComandos();

                    CNPJ = FormatCnpjCpf.SemFormatacao(txtcnpj.Text);
                        newidag = inserirconstrutora.CadastrarConstrutora(txtdescricaoconstrutora.Text, CNPJ, txtend.Text);

                        if (newidag >= 0)
                        {
                            idconstrutora = newidag.ToString();
                            MessageBox.Show("Construtora Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            if (ConstrutoraSalvo != null)
                                ConstrutoraSalvo.Invoke();
                            Close();

                            Cursor = Cursors.Default;
                        }


                            /*
                            LoginDaoComandos updateconstrutora = new LoginDaoComandos();

                            updateconstrutora.UpdateConstrutora(idag, txtdescricaoconstrutora.Text, txtend.Text);

                            if (updateconstrutora.mensagem == "Erro")
                            {
                                MessageBox.Show("Não foi possivel atualizar o Construtora!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Cursor = Cursors.Default;
                                return;
                            }
                            else
                            {

                                idconstrutora = idag;

                                MessageBox.Show("Construtora Atualizado com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (ConstrutoraSalvo != null)
                                ConstrutoraSalvo.Invoke();
                                Cursor = Cursors.Default;
                                Close();
                            }*/

                    Cursor = Cursors.Default;
                    }
                    else
                    {
                        tabControl.SelectedTab = tabconstrutora;
                        txtdescricaoconstrutora.Select(txtdescricaoconstrutora.Text.Length, 0);
                        txtdescricaoconstrutora.Focus();
                        Cursor = Cursors.Default;
                        return;
                    }
            }
            #endregion
        }

        private void txtdescricaoconstrutora_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtend_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcpf_KeyDown(object sender, KeyEventArgs e)
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

        void frm_dados_construtora_ConstrutoraSalvoEdit()
        {
            idconstrutora = newFormDadosAg.idconstrutora.ToString();
            if (ConstrutoraSalvo != null)
                ConstrutoraSalvo.Invoke();
            Close();

            //MessageBox.Show(newForm.idconstrutora);
        }
    }
}
