using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using LMFinanciamentos.DAL;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Configuracao : Form
    {
        private string idFunc;
        public int id;
        public string login;
        public string senha;
        public string novasenha;
        string idserver;

        public Form_Configuracao()
        {
            InitializeComponent();
        }
        public void setID(string id)
        {
            idFunc = id;
        }
        private void Form_Configuracao_Load(object sender, EventArgs e)
        {


            Functions.Arredonda(btncloseconf, 12, true, true);

            var btn = new Button();
            btn.Size = new Size(35, txt_novasenha.ClientSize.Height + 2);
            btn.Dock = DockStyle.Right;
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.showpass20;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;

            var btn1 = new Button();
            btn1.Size = new Size(35, txt_novasenha.ClientSize.Height + 2);
            btn1.Dock = DockStyle.Right;
            btn1.Cursor = Cursors.Default;
            btn1.Image = Properties.Resources.showpass20;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.ForeColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;


            btn.MouseDown += new MouseEventHandler(pictureBoxEye_MouseDown);
            btn.MouseUp += new MouseEventHandler(pictureBoxEye_MouseUp);
            btn1.MouseDown += new MouseEventHandler(pictureBoxEye_MouseDown_1);
            btn1.MouseUp += new MouseEventHandler(pictureBoxEye_MouseUp_1);

            txt_novasenha.Controls.Add(btn);
            txt_confirmasenha.Controls.Add(btn1);

            LoginDaoComandos server = new LoginDaoComandos();

            txtnameserver.Text = server.GetServer().Nome_Server;
            txtcaminhoarquivos.Text = server.GetServer().ServerFilesPath_Server;
            idserver = server.GetServer().id_Server;
        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void OpenLoginForm()
        {
            Application.Run(new Form_Login());
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_altersenha_Click(object sender, EventArgs e)
        {
            if (pnl_submenualtersenha.Visible == true)
            {
                pnl_submenualtersenha.Visible = false;
                txt_novasenha.Clear();
                txt_confirmasenha.Clear();
            }
            else
            {
                pnl_submenualtersenha.Visible = true;
                txt_novasenha.Focus();

                txt_novasenha.UseSystemPasswordChar = true;
                txt_confirmasenha.UseSystemPasswordChar = true;
            }
        }
        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txt_novasenha.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txt_novasenha.UseSystemPasswordChar = true;
        }

        private void btn_cancelsenha_Click(object sender, EventArgs e)
        {
            if (pnl_submenualtersenha.Visible == true)
            {
                pnl_submenualtersenha.Visible = false;
                txt_novasenha.Clear();
                txt_confirmasenha.Clear();
            }
            else
            {
                pnl_submenualtersenha.Visible = true;
                txt_novasenha.Focus();
            }
        }

        private void pictureBoxEye_MouseDown_1(object sender, MouseEventArgs e)
        {
            txt_confirmasenha.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp_1(object sender, MouseEventArgs e)
        {
            txt_confirmasenha.UseSystemPasswordChar = true;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txt_novasenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Nova Senha ", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_novasenha.Focus();
            }
            else
            {
                if (txt_confirmasenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Confirmar Senha ", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_confirmasenha.Focus();
                }
                else
                {
                    if (txt_novasenha.Text.Equals(txt_confirmasenha.Text))
                    {
                        DAL.DS_FuncionarioTableAdapters.LoginTableAdapter adp = new DAL.DS_FuncionarioTableAdapters.LoginTableAdapter();

                        novasenha = txt_novasenha.Text;
                        id = 1;

                        try
                        {
                            adp.UpdateSenha(novasenha, id);
                            MessageBox.Show("Senha Alterada com sucesso! ", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //lbl_error_confere.Visible = false;
                            pnl_submenualtersenha.Visible = false;
                        }
                        catch (Exception err)
                        {
                            throw new Exception("Erro ao obter funcionário: " + err.Message);
                            //throw MessageBox.Show(err.ToString, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }
                    }
                    else
                    {
                        txt_novasenha.Focus();
                        //lbl_error_confere.Visible = true;
                    }

                }
            }
        }
        private void setLogin(Funcionario func)
        {
            //id = func.Id_func;
            //login = func.Login_Func;
            //senha = func.Senha_Func;

        }

        private void btnsalvarserver_Click(object sender, EventArgs e)
        {
            LoginDaoComandos upserver = new LoginDaoComandos();
            upserver.SaveServer(idserver, txtnameserver.Text, txtcaminhoarquivos.Text);
            MessageBox.Show(upserver.mensagem);
        }
    }
}
