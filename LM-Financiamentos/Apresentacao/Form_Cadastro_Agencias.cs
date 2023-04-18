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
    public partial class Form_Cadastro_Agencias : Form
    {
        String AG;
        int newidag;

        public string idagencia;

        private Form_Dados_Agencias newFormDadosAg { get; set; }

        public Form_Cadastro_Agencias()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Agencias)
                {
                    Form_Dados_Agencias formularioPai = (Form_Dados_Agencias)this.Owner;
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
            txtdescricaoag.Text = sNome;
        }
        public void setAgCad(string idag)
        {
            if (idag != null)
            {
                idagencia = idag;
            }
        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cadastro_Agencias_Load(object sender, EventArgs e)
        {

            txtagencia.Select(txtagencia.Text.Length, 0);
            this.ActiveControl = txtagencia;
            txtagencia.Focus();
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
        public event Action AgenciaSalvo;
        //public event Action AgenciaSalvoEdit;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (txtagencia.Text == "")
            {
                MessageBox.Show("Campo Nº da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtagencia.Select();
                Cursor = Cursors.Default;
                return;
            }
            if (txtdescricaoag.Text == "")
            {
                MessageBox.Show("Campo Descrição da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtdescricaoag.Select();
                Cursor = Cursors.Default;
                return;
            }


            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            AG = txtagencia.Text;

            #region Check Agencia
            LoginDaoComandos checkexisteag = new LoginDaoComandos();

            
            Agencia agencia = null;

            agencia = checkexisteag.GetNumAgencia(AG);

            string idag = agencia.Id_agencia;
            string descriag = agencia.Descri_agencia;
            string end = agencia.End_Agencia;
            string numag = agencia.Num_Agencia;

            if (string.IsNullOrEmpty(idag))
            {

                LoginDaoComandos inseriragencia = new LoginDaoComandos();

                newidag = inseriragencia.CadastrarAgencia(txtdescricaoag.Text, txtagencia.Text, txtend.Text);

                if (newidag >= 0)
                {
                        idagencia  = newidag.ToString();
                        MessageBox.Show("Agência Cadastrada com Sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                        if (AgenciaSalvo != null)
                            AgenciaSalvo.Invoke();
                        Close();

                    Cursor = Cursors.Default;
                }

            }
            else
            {
                    var result = MessageBox.Show("Já existe um cadastro desta Agência \n AG: "+ numag + " \n Descrição: " + descriag + " \n Deseja Subistituír ?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        LoginDaoComandos updateagencia = new LoginDaoComandos();

                        updateagencia.UpdateAgencia(idag, txtdescricaoag.Text, txtagencia.Text, txtend.Text);

                        if (updateagencia.mensagem == "Erro")
                        {
                            MessageBox.Show("Não foi possivel atualizar a Agência!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {

                            idagencia = idag;

                            MessageBox.Show("Agência Atualizada com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (AgenciaSalvo != null)
                                AgenciaSalvo.Invoke();
                            Cursor = Cursors.Default;
                            Close();
                        }

                    /*
                        newFormDadosAg = new Form_Dados_Agencias();
                        //newFormDadosAg.AtributoAcessadoPorOutroForm = "TEXTO";
                        newFormDadosAg.AgenciaSalvoEdit += new Action(frm_dados_agencia_AgenciaSalvoEdit);
                        newFormDadosAg.setIdAgencia(idag);
                        newFormDadosAg.Owner = this;
                        newFormDadosAg.Show();
                    //MessageBox.Show(idag);
                    //Form_Dados_Agencias frm_dados_agencias = new Form_Dados_Agencias();
                    //    frm_dados_agencias.setIdAgencia(idag);
                        //frm_dados_agencias.Show();
                        
                        
                       // if (AgenciaSalvo != null)
                       //     AgenciaSalvo.Invoke();
                        //Close();
                    */
                    Cursor = Cursors.Default;
                }
                    else
                    {
                        tabControl.SelectedTab = tabagencia;
                        txtagencia.Select();
                        Cursor = Cursors.Default;
                        return;
                    }
            }
            #endregion
        }

        void frm_dados_agencia_AgenciaSalvoEdit()
        {
            idagencia = newFormDadosAg.idagencia.ToString();
            if (AgenciaSalvo != null)
                AgenciaSalvo.Invoke();
            Close();

            //MessageBox.Show(newForm.idagencia);
        }

        private void txtagencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtdescricaoag_KeyDown(object sender, KeyEventArgs e)
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

        private void txtagencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
