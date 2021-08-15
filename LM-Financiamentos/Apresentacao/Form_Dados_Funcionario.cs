using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Windows.Forms;
using System.Windows.Media;
using System.Collections.Generic;
using System.Drawing;
using LMFinanciamentos.Modelo;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Funcionario : Form
    {
        String sexo, status, idFuncionario, idLogin, valor, renda, nascimento, arquivo, RG, CPF;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;




        public Form_Dados_Funcionario()
        {
            InitializeComponent();
        }
        public void setIdFuncionario(string idfuncionario)
        {
            idFuncionario = idfuncionario;
        }
        public void setTextNome(String sNome)
        {
            txtnomefuncionario.Text = sNome;

        }
        private void btnclosefunc_Click(object sender, EventArgs e)
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
        private void btn_salvar_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtnomefuncionario.Text == "")
            {
                MessageBox.Show("Campo Nome do Funcionario é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomefuncionario.Select();
                Cursor = Cursors.Default;
                return;
            }

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
            }else
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
            
            LoginDaoComandos insertfotofuncionario = new LoginDaoComandos();
            if (excluirimage == "Update")
            {
                if (arquivobase == false)
                {
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotofuncionario.InsertFotoFuncionario(idFuncionario, imgContent, txtnomefuncionario.Text);
                }
                else
                {
                    fsObj = File.OpenRead(arquivo);
                   // MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    insertfotofuncionario.UpdateFotoFuncionario(idFuncionario, imgContent);
                }
                if (insertfotofuncionario.mensagem == "OK")
                {

                }
                else
                {
                    MessageBox.Show(insertfotofuncionario.mensagem, "Atualizando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }else if(excluirimage == "Excluir")
            {
                LoginDaoComandos excluirfuncionario = new LoginDaoComandos();
                excluirfuncionario.DeleteFotoFuncionario(idFuncionario);
                if (excluirfuncionario.mensagem == "Excluido")
                {

                }
                else
                {
                    MessageBox.Show(insertfotofuncionario.mensagem, "Apagando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            LoginDaoComandos updatefuncionario = new LoginDaoComandos();

            updatefuncionario.UpdateFuncionario(idFuncionario, txtnomefuncionario.Text, txtemail.Text, txttelefone.Text, txtcelular.Text, txtendereco.Text, datanasc, sexo, CPF, RG,  txtcracha.Text, idLogin, txtpermission.Text, status);

            Cursor = Cursors.Default;

            MessageBox.Show(updatefuncionario.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btn_editar_func.Visible = true;
            splitter1.Visible = false;
            btn_cancelar_func.Visible = false;
            splitter2.Visible = false;
            btn_salvar_func.Visible = false;
            
            
            splitter3.Visible = true;
            btn_excluir_func.Visible = true;

            DesabilitarEdicao();

            if (FuncionarioSalvo != null)
                FuncionarioSalvo.Invoke();

        }

        private void btn_cancelar_func_Click(object sender, EventArgs e)
        {
            btn_editar_func.Visible = true;
            splitter1.Visible = false;
            splitter2.Visible = false;
            btn_cancelar_func.Visible = false;
            btn_salvar_func.Visible = false;
            splitter3.Visible = true;
            btn_excluir_func.Visible = true;

            excluirimage = "";

            DesabilitarEdicao();
            LoadDadosFuncionario();
            tabControl.SelectedTab = tabControl.TabPages["tabfuncionario"]; 

            //Close();
        }

        internal void setFoto(byte[] foto_Cli)
        {
            // throw new NotImplementedException();
            if(foto_Cli != null)
            {
                MemoryStream stmBLOBData = new MemoryStream(foto_Cli);
                img_foto.Image = Image.FromStream(stmBLOBData);
            }

        }

        private void Form_Dados_Funcionario_Load(object sender, EventArgs e)
        {
            LoadDadosFuncionario();
         }
        public event Action FuncionarioSalvo;
        public void LoadDadosFuncionario()
        {
            Cursor = Cursors.WaitCursor;
            Funcionario funcionario = null;

            LoginDaoComandos getfuncionario = new LoginDaoComandos();
            funcionario = getfuncionario.GetFuncionario(idFuncionario);

            txtnomefuncionario.Text = funcionario.Nome_Funcionario;
            txtcpf.Text = funcionario.CPF_Funcionario;
            txtrg.Text = funcionario.RG_Funcionario;
            txtnasc.Text = funcionario.Nascimento_Funcionario;
            txtemail.Text = funcionario.Email_Funcionario;
            txttelefone.Text = funcionario.Telefone_Funcionario;
            txtcelular.Text = funcionario.Celular_Funcionario;
            txtrendacli.Text = funcionario.Renda_Funcionario;

            if (funcionario.Sexo_Funcionario == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (funcionario.Sexo_Funcionario == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (funcionario.Status_Funcionario == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Funcionario Ativo";
            }

            if (funcionario.Status_Funcionario == "Inativo")
            {
                checkBox_status.Text = "Funcionario Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Funcionario
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

            txtnomefuncionario.Select(txtnomefuncionario.Text.Length, 0);
            this.ActiveControl = txtnomefuncionario;
            txtnomefuncionario.Focus();
            Cursor = Cursors.Default;
        }
        
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
                            newImage.Save("c:\\Windows\\Temp\\"+arquivo+".Jpeg", ImageFormat.Jpeg);

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

                        getfoto.GetFotoFuncionario(idFuncionario);
                        setFoto(getfoto.GetFotoFuncionario(idFuncionario).Foto_Funcionario);
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

        private void btn_excluir_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var result = MessageBox.Show("Deseja Excluir o Funcionario: \n " + txtnomefuncionario.Text + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                LoginDaoComandos deletefuncionario = new LoginDaoComandos();

                if (img_foto.Image != null)
                {
                    deletefuncionario.DeleteFotoFuncionario(idFuncionario);
                    deletefuncionario.DeleteFuncionario(idFuncionario);
                    MessageBox.Show(deletefuncionario.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (FuncionarioSalvo != null)
                        FuncionarioSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();

                }
                else
                {
                    deletefuncionario.DeleteFuncionario(idFuncionario);
                    MessageBox.Show(deletefuncionario.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (FuncionarioSalvo != null)
                        FuncionarioSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
                }



            }
            Cursor = Cursors.Default;
        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_limpar_foto_Click(object sender, EventArgs e)
        {
            img_foto.Image = null;
            btn_add_foto.Text = "Adicionar";
            if(img_foto.Image != null){
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
                checkBox_status.Text = "Funcionario Ativo";
                status = "Ativo";
            }
            else
            {
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Text = "Funcionario Inativo";
                status = "Inativo";
            }
        }

        private void btn_editar_func_Click(object sender, EventArgs e)
        {
            btn_editar_func.Visible = false;
            splitter2.Visible = true;
            btn_cancelar_func.Visible = true;
            splitter1.Visible = true;
            btn_salvar_func.Visible = true;

            splitter3.Visible = false;
            btn_excluir_func.Visible = false;
            

            HabilitarEdicao();
            txtnomefuncionario.Select();
        }


        private void HabilitarEdicao()
        {
            txtnomefuncionario.ReadOnly = false;
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
            txtendereco.ReadOnly = false;
            txtcracha.ReadOnly = false;

            img_foto.Enabled = true;
            if(img_foto.Image == null)
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
            txtnomefuncionario.ReadOnly = true;
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
            txtendereco.ReadOnly = true;
            txtcracha.ReadOnly = true;

            img_foto.Enabled = false;
            btn_add_foto.Enabled = false;
            btn_limpar_foto.Enabled = false;
        }
    }
}
