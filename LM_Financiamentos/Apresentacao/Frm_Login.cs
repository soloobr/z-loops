using LM_Financiamentos.Apresentacao;
using LM_Financiamentos.DAL;
using LM_Financiamentos.Entidades;
using LM_Financiamentos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Financiamentos
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
            var btnl = new Button();
            btnl.Size = new Size(35, txtSenha.ClientSize.Height + 2);
            btnl.Dock = DockStyle.Right;
            btnl.Cursor = Cursors.Default;
            btnl.Image = Properties.Resources.showpass20;
            btnl.FlatStyle = FlatStyle.Flat;
            btnl.ForeColor = Color.White;
            btnl.FlatAppearance.BorderSize = 0;

            btnl.MouseDown += new MouseEventHandler(pictureBoxEyeL_MouseDown);
            btnl.MouseUp += new MouseEventHandler(pictureBoxEyeL_MouseUp);

            txtSenha.Controls.Add(btnl);
        }
        private void pictureBoxEyeL_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void pictureBoxEyeL_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        private void btn_logar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    this.Hide();
                    LoginDaoComandos gett = new LoginDaoComandos();
                    gett.GetFunc(txtLogin.Text, txtSenha.Text);

                    MessageBox.Show("Logado com sucesso:1 " + gett.NomeFunc, "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormPrincipal frm_Principal = new FormPrincipal();
                    frm_Principal.Show();
                    
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
        */
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //btn_logar.Focus();
                //btn_logar.PerformClick();
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                txtSenha.Focus();
            }
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            

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

                    func = gett.GetFunc(txtLogin.Text, txtSenha.Text);
                    Byte[] foto = func.Foto_Func;
                    ola = saudar.GetSaudacao();

                    //MessageBox.Show("Logado com sucesso! ", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Principal frm_Principal = new Form_Principal();
                    //Form_Configuracao form_Configuracao = new Form_Configuracao();
                    //dadosfunc.Id_func = func.Id_func;
                    //dadosfunc.Nome_Func = func.Nome_Func;
                    //dadosfunc.Login_Func = func.Login_Func;
                    //dadosfunc.Senha_Func = func.Senha_Func;
                    //dadosfunc.Permision = func.Permision;

                    //frm_Principal.setID(func);
                    frm_Principal.setFoto(func.Foto_Func);
                    frm_Principal.setLabel(func, ola);
                    frm_Principal.Show();
                    

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

        private void Frm_Login_DockChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_Login_Paint(object sender, PaintEventArgs e)
        {
            Functions.Arredonda(pFormulario: this, 20, true, true);
        }

        private void Frm_Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
