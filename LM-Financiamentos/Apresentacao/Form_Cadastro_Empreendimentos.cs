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
    public partial class Form_Cadastro_Empreendimentos : Form
    {
        String descricaoempre, listmessage;
        int newidag;

        public string idempreendimento;

        private Form_Dados_Empreendimentos newFormDadosAg { get; set; }

        public Form_Cadastro_Empreendimentos()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Empreendimentos)
                {
                    Form_Dados_Empreendimentos formularioPai = (Form_Dados_Empreendimentos)this.Owner;
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
            txtdescricaoempreendimento.Text = sNome;
        }
        public void setAgCad(string idag)
        {
            if (idag != null)
            {
                idempreendimento = idag;
            }
        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_Empreendimentos_Load(object sender, EventArgs e)
        {
            LoginDaoComandos countempreendimentos = new LoginDaoComandos();

            int ultimoID = countempreendimentos.CountEmpreendimentos();
            int newidemp = ultimoID;

            txtampreendimento.Text = newidemp.ToString();
            txtdescricaoempreendimento.Select(txtdescricaoempreendimento.Text.Length, 0);
            this.ActiveControl = txtdescricaoempreendimento;
            txtdescricaoempreendimento.Focus();
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
        public event Action EmpreendimentoSalvo;
        public event Action EmpreendimentoSalvoEdit;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtdescricaoempreendimento.Text == "")
            {
                MessageBox.Show("Campo Descrição do Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabampreendimento;
                txtdescricaoempreendimento.Select();
                Cursor = Cursors.Default;
                return;
            }
            /*
            if (txtampreendimento.Text == "")
            {
                MessageBox.Show("Campo Nº da Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabampreendimento;
                txtampreendimento.Select();
                Cursor = Cursors.Default;
                return;
            }*/

            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço do Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabampreendimento;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            descricaoempre = txtdescricaoempreendimento.Text;

            #region Check Empreendimento
            LoginDaoComandos checkexisteag = new LoginDaoComandos();

            
            Empreendimento ampreendimento = null;

            ampreendimento = checkexisteag.GetNumEmpreendimento(descricaoempre);

            string idag = ampreendimento.Id_empreendimentos;
            string descriag = ampreendimento.Descri_empreendimentos;
            string end = ampreendimento.End_empreendimentos;

            var highScores = checkexisteag.GetEmpreendimentosM(descricaoempre);

            listmessage = "";
            foreach (var item in highScores)
            {
                
                listmessage =  listmessage + "\n" +  ($"{item.Id_empreendimentos}")+ " - " + ($"{item.Descri_empreendimentos}");
            }


            if (string.IsNullOrEmpty(idag))
            {

                LoginDaoComandos inserirampreendimento = new LoginDaoComandos();

                newidag = inserirampreendimento.CadastrarEmpreendimento(txtdescricaoempreendimento.Text, txtend.Text);

                if (newidag >= 0)
                {
                        idempreendimento  = newidag.ToString();
                        MessageBox.Show("Empreendimento Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                        if (EmpreendimentoSalvo != null)
                        EmpreendimentoSalvo.Invoke();
                        Close();

                    Cursor = Cursors.Default;
                }

            }
            else
            {
                    var result = MessageBox.Show("Foi encontrado registro com essa Descrição ! \n \n Empreendimentos: " + listmessage + " \n \n Confirma o cadastro ?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        LoginDaoComandos inserirampreendimento = new LoginDaoComandos();

                        newidag = inserirampreendimento.CadastrarEmpreendimento(txtdescricaoempreendimento.Text, txtend.Text);

                        if (newidag >= 0)
                        {
                            idempreendimento = newidag.ToString();
                            MessageBox.Show("Empreendimento Cadastrado com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            if (EmpreendimentoSalvo != null)
                                EmpreendimentoSalvo.Invoke();
                            Close();

                            Cursor = Cursors.Default;
                        }


                            /*
                            LoginDaoComandos updateampreendimento = new LoginDaoComandos();

                            updateampreendimento.UpdateEmpreendimento(idag, txtdescricaoempreendimento.Text, txtend.Text);

                            if (updateampreendimento.mensagem == "Erro")
                            {
                                MessageBox.Show("Não foi possivel atualizar o Empreendimento!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Cursor = Cursors.Default;
                                return;
                            }
                            else
                            {

                                idempreendimento = idag;

                                MessageBox.Show("Empreendimento Atualizado com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (EmpreendimentoSalvo != null)
                                EmpreendimentoSalvo.Invoke();
                                Cursor = Cursors.Default;
                                Close();
                            }*/

                    Cursor = Cursors.Default;
                    }
                    else
                    {
                        tabControl.SelectedTab = tabampreendimento;
                        txtdescricaoempreendimento.Select(txtdescricaoempreendimento.Text.Length, 0);
                        txtdescricaoempreendimento.Focus();
                        Cursor = Cursors.Default;
                        return;
                    }
            }
            #endregion
        }

        private void txtdescricaoempreendimento_KeyDown(object sender, KeyEventArgs e)
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

        void frm_dados_ampreendimento_EmpreendimentoSalvoEdit()
        {
            idempreendimento = newFormDadosAg.idempreendimento.ToString();
            if (EmpreendimentoSalvo != null)
                EmpreendimentoSalvo.Invoke();
            Close();

            //MessageBox.Show(newForm.idempreendimento);
        }
    }
}
