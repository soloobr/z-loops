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
    public partial class Form_Dados_cliente : Form
    {
        String sexo, status, idCliente, valor, renda, nascimento, arquivo;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;


        public Form_Dados_cliente()
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

            String CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);

            String RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);

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

            }else if(excluirimage == "Excluir")
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
            updatecliente.UpdateCliente(idCliente, txtnomecli.Text, txtemail.Text, txttelefone.Text, txtcelular.Text, CPF, RG, datanasc, sexo, status, renda);

            Cursor = Cursors.Default;

            MessageBox.Show(updatecliente.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btn_editar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = false;
            btn_cancelar.Visible = false;



            DesabilitarEdicao();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = false;
            btn_cancelar.Visible = false;

            excluirimage = "";

            DesabilitarEdicao();
            LoadDadosCliente();
            tabControl.SelectedTab = tabControl.TabPages["tabcliente"]; 

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

        private void Form_Dados_cliente_Load(object sender, EventArgs e)
        {
            LoadDadosCliente();
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

            txtnomecli.Select(txtnomecli.Text.Length, 0);
            this.ActiveControl = txtnomecli;
            txtnomecli.Focus();
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
            splitter1.Visible = false;
            btn_salvar.Visible = true;
            btn_cancelar.Visible = true;


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

            img_foto.Enabled = false;
            btn_add_foto.Enabled = false;
            btn_limpar_foto.Enabled = false;
        }
    }
}
