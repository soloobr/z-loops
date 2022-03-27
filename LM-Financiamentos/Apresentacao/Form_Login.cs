using LMFinanciamentos.Apresentacao;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace LMFinanciamentos
{
    public partial class Form_Login : Form
    {
        string servidor;
        public Form_Login()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();

            try
            {
                var appVersion = Assembly.GetExecutingAssembly().GetName().Version;

                if (!webClient.DownloadString("https://lmfinanciamentos.com.br/update/LMversion").Contains(appVersion.ToString())) 
                { 
                    if(MessageBox.Show("Existe uma nova versão do Program! \n Deseja Atualizar Agora?", "Atualização", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) using (var client = new WebClient())
                        {
                            Process.Start("UpdateLM.exe");
                            this.Close();
                        }                
                }

            }
            catch
            {

            }

        }

        private string _server;

        public string server
        {
            get => _server;
            set => _server = value;
        }
        private void pictureBoxEyeL_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxEyeL_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Paint(object sender, PaintEventArgs e)
        {
            Functions.Arredonda(pFormulario: this, 20, true, true);
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtpassword.Focus();
            }
        }

        private void txt_login_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtpassword.Focus();
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(35, txtpassword.ClientSize.Height + 2);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.showpass20;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;

            btn.MouseDown += new MouseEventHandler(pictureBoxEyeL_MouseDown);
            btn.MouseUp += new MouseEventHandler(pictureBoxEyeL_MouseUp);

            txtpassword.Controls.Add(btn);
            Functions.Arredonda(btnlogar, 12, true, true);
            txt_login.Select();
            this.ActiveControl = txt_login;
            txt_login.Focus();
        }

        private void Form_Login_Paint(object sender, PaintEventArgs e)
        {
            Functions.Arredonda(this, 20, true, true);


        }

        private void imglogin_Click(object sender, EventArgs e)
        {

        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (txt_login.Text == "")
            {
                lblverifica.Text = "*Preencher o campo Login";
                lblverifica.Visible = true;
                txt_login.Focus();
                Cursor = Cursors.Default;
            }
            else if (txtpassword.Text == "")
            {

                lblverifica.Text = "*Preencher o campo Passwor";
                lblverifica.Visible = true;
                txtpassword.Focus();
                Cursor = Cursors.Default;
            }
            else
            {
                Controle controle = new Controle();
                controle.acessar(txt_login.Text, txtpassword.Text, servidor);


                Funcionario func = null;

                Saudacao ola = null;

                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        this.Hide();
                        LoginDaoComandos gett = new LoginDaoComandos();
                        gett.server = servidor;
                        Functions saudar = new Functions();

                        // Funcionario dadosfunc = new Funcionario();

                        func = gett.GetFunc(txt_login.Text, txtpassword.Text);
                        //Byte[] foto = func.Foto_Func;
                        ola = saudar.GetSaudacao();

                        //MessageBox.Show("Logado com sucesso! ", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Principal frm_Principal = new Form_Principal();
                        if (func.Foto_Funcionario != null)
                        {
                            frm_Principal.setFoto(func.Foto_Funcionario);
                        }
                        frm_Principal.setLabel(func, ola);
                        frm_Principal.setServer(servidor);
                        frm_Principal.Show();
                        lblverifica.Visible = false;
                        string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                        //var MyIni = new IniFile();
                        //var MyIni = new IniFile(basePath+@"\LM-Settings.ini");
                        //MyIni.Write("DefaultVolume", "0");
                    }
                    else
                    {
                        MessageBox.Show("Login Não Encontrado, Verifique login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }

            }

            Cursor = Cursors.Default;

        }

        private void txt_login_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnlogar.Focus();
                btnlogar.PerformClick();
            }
        }

        private void lbltop_Click(object sender, EventArgs e)
        {

        }

        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.F12)
            {
                comboBox_server.Visible = true;
                lblserver.Visible = true;

                comboBox_server.SelectedIndex = 1;
                txtpassword.Text = "236985";
                txt_login.Text = "lgomes";

            }
        }

        private void comboBox_server_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var MyIni = new IniFile(basePath + @"\LM-Settings.ini");

            String usuario = Path.GetFileName(basePath);


            if (comboBox_server.Text == "OnLINE")
            {
                servidor = "ONLINE";
                MyIni.Write("StringConnection", "ONLINE", usuario);
            }
            if (comboBox_server.Text == "Local")
            {
                MyIni.Write("StringConnection", "LOCAL", usuario);
                servidor = "LOCAL";
            }
            if (comboBox_server.Text == "HOMOLOGACAO")
            {
                MyIni.Write("StringConnection", "HOMOLOGACAO", usuario);
                servidor = "LOCAL";
            }
        }

        private void comboBox_server_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnlogar.Focus();
                btnlogar.PerformClick();
            }
        }

        private void txt_login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                //SendKeys.Send("{TAB}");
                txtpassword.Select(txtpassword.Text.Length, 0);
                this.ActiveControl = txtpassword;
                txtpassword.Focus();
            }
        }
    }
}
