
using System;
using System.Windows.Forms;

namespace LM_Financiamentos
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlcenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbllogin = new System.Windows.Forms.Label();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.btnlogar = new System.Windows.Forms.Button();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.imglogin = new System.Windows.Forms.PictureBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltop = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlcenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelbutton.SuspendLayout();
            this.panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).BeginInit();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LM_Financiamentos.Properties.Resources.user128;
            this.pictureBox1.Location = new System.Drawing.Point(42, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Location = new System.Drawing.Point(0, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(100, 23);
            this.lbl_Login.TabIndex = 0;
            // 
            // lbl_senha
            // 
            this.lbl_senha.Location = new System.Drawing.Point(0, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(100, 23);
            this.lbl_senha.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(0, 0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 0;
            // 
            // pnlcenter
            // 
            this.pnlcenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.pnlcenter.Controls.Add(this.panel1);
            this.pnlcenter.Controls.Add(this.panelbutton);
            this.pnlcenter.Controls.Add(this.panelcenter);
            this.pnlcenter.Controls.Add(this.pnltop);
            this.pnlcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcenter.Location = new System.Drawing.Point(0, 0);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(284, 403);
            this.pnlcenter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.lblsenha);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.panel1.Size = new System.Drawing.Size(284, 136);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtpassword
            // 
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpassword.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpassword.Location = new System.Drawing.Point(50, 86);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(184, 27);
            this.txtpassword.TabIndex = 43;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsenha.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsenha.Location = new System.Drawing.Point(50, 63);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(57, 23);
            this.lblsenha.TabIndex = 42;
            this.lblsenha.Text = "Senha:";
            // 
            // txt_login
            // 
            this.txt_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_login.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_login.Location = new System.Drawing.Point(50, 36);
            this.txt_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(184, 27);
            this.txt_login.TabIndex = 41;
            this.txt_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_login_KeyPress_2);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lbllogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 26);
            this.panel2.TabIndex = 40;
            // 
            // lbllogin
            // 
            this.lbllogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbllogin.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogin.Location = new System.Drawing.Point(0, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(184, 26);
            this.lbllogin.TabIndex = 38;
            this.lbllogin.Text = "Login:";
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.panelbutton.Controls.Add(this.btnlogar);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbutton.Location = new System.Drawing.Point(0, 303);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Padding = new System.Windows.Forms.Padding(70, 30, 70, 30);
            this.panelbutton.Size = new System.Drawing.Size(284, 100);
            this.panelbutton.TabIndex = 22;
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnlogar.FlatAppearance.BorderSize = 0;
            this.btnlogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnlogar.Location = new System.Drawing.Point(70, 30);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Padding = new System.Windows.Forms.Padding(5);
            this.btnlogar.Size = new System.Drawing.Size(144, 40);
            this.btnlogar.TabIndex = 33;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = false;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.Controls.Add(this.imglogin);
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcenter.Location = new System.Drawing.Point(0, 33);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Padding = new System.Windows.Forms.Padding(50, 10, 50, 0);
            this.panelcenter.Size = new System.Drawing.Size(284, 126);
            this.panelcenter.TabIndex = 21;
            this.panelcenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcenter_Paint);
            // 
            // imglogin
            // 
            this.imglogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.imglogin.Image = global::LM_Financiamentos.Properties.Resources.icons8_name_tag_96;
            this.imglogin.Location = new System.Drawing.Point(50, 10);
            this.imglogin.Name = "imglogin";
            this.imglogin.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.imglogin.Size = new System.Drawing.Size(184, 96);
            this.imglogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imglogin.TabIndex = 29;
            this.imglogin.TabStop = false;
            this.imglogin.Click += new System.EventHandler(this.imglogin_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lbltop);
            this.pnltop.Controls.Add(this.btnsair);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(284, 33);
            this.pnltop.TabIndex = 20;
            this.pnltop.TabStop = true;
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltop.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(252, 33);
            this.lbltop.TabIndex = 12;
            this.lbltop.Text = "LM Financiamentos";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.btnsair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsair.Image = global::LM_Financiamentos.Properties.Resources.delete16;
            this.btnsair.Location = new System.Drawing.Point(252, 0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Padding = new System.Windows.Forms.Padding(5);
            this.btnsair.Size = new System.Drawing.Size(32, 33);
            this.btnsair.TabIndex = 11;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form_Login
            // 
            this.ClientSize = new System.Drawing.Size(284, 403);
            this.Controls.Add(this.pnlcenter);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Login_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlcenter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelbutton.ResumeLayout(false);
            this.panelcenter.ResumeLayout(false);
            this.panelcenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlcenter;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbltop;
        private Panel panelbutton;
        private Button btnlogar;
        private Panel panelcenter;
        private PictureBox imglogin;
        private Panel panel1;
        private TextBox txtpassword;
        private Label lblsenha;
        private TextBox txt_login;
        private Panel panel2;
        private Label lbllogin;
        //private System.Windows.Forms.Button btn_sair;


    }
}