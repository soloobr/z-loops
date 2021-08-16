using LMFinanciamentos.Apresentacao;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LMFinanciamentos
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
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
            if (txt_login.Text == "")
            {
                lblverifica.Text = "*Preencher o campo Login";
                lblverifica.Visible = true;
                txt_login.Focus();
            }
            else if (txtpassword.Text == "")
            {

                lblverifica.Text = "*Preencher o campo Passwor";
                lblverifica.Visible = true;
                txtpassword.Focus();

            }
            else
            {

                Controle controle = new Controle();
                controle.acessar(txt_login.Text, txtpassword.Text);


                Funcionario func = null;

                Saudacao ola = null;

                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        this.Hide();
                        LoginDaoComandos gett = new LoginDaoComandos();
                        Functions saudar = new Functions();
                        // Funcionario dadosfunc = new Funcionario();

                        func = gett.GetFunc(txt_login.Text, txtpassword.Text);
                        //Byte[] foto = func.Foto_Func;
                        ola = saudar.GetSaudacao();

                        //MessageBox.Show("Logado com sucesso! ", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_Principal frm_Principal = new Form_Principal();
                        if(func.Foto_Funcionario != null)
                        {
                            frm_Principal.setFoto(func.Foto_Funcionario);
                        }
                        frm_Principal.setLabel(func, ola);
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
    }
}
