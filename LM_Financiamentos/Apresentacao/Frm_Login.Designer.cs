
namespace LM_Financiamentos
{
    partial class Frm_Login
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlcenter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogar = new System.Windows.Forms.Button();
            this.imglogin = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).BeginInit();
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
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.Location = new System.Drawing.Point(233, 84);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(57, 28);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_senha.Location = new System.Drawing.Point(225, 121);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(65, 28);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(296, 81);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(196, 31);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(296, 81);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(196, 31);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // pnlcenter
            // 
            this.pnlcenter.Controls.Add(this.txtpassword);
            this.pnlcenter.Controls.Add(this.txtusuario);
            this.pnlcenter.Controls.Add(this.button1);
            this.pnlcenter.Controls.Add(this.btnlogar);
            this.pnlcenter.Controls.Add(this.imglogin);
            this.pnlcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcenter.Location = new System.Drawing.Point(0, 0);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(513, 245);
            this.pnlcenter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(394, 141);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnlogar.FlatAppearance.BorderSize = 0;
            this.btnlogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlogar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogar.Location = new System.Drawing.Point(219, 141);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Padding = new System.Windows.Forms.Padding(5);
            this.btnlogar.Size = new System.Drawing.Size(121, 36);
            this.btnlogar.TabIndex = 6;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = false;
            // 
            // imglogin
            // 
            this.imglogin.Image = global::LM_Financiamentos.Properties.Resources.user128;
            this.imglogin.Location = new System.Drawing.Point(61, 49);
            this.imglogin.Name = "imglogin";
            this.imglogin.Size = new System.Drawing.Size(128, 128);
            this.imglogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imglogin.TabIndex = 5;
            this.imglogin.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.Location = new System.Drawing.Point(219, 62);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(248, 27);
            this.txtusuario.TabIndex = 8;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpassword.Location = new System.Drawing.Point(219, 103);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(248, 27);
            this.txtpassword.TabIndex = 9;
            // 
            // Frm_Login
            // 
            this.ClientSize = new System.Drawing.Size(513, 245);
            this.Controls.Add(this.pnlcenter);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlcenter.ResumeLayout(false);
            this.pnlcenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).EndInit();
            this.ResumeLayout(false);

        }

            #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlcenter;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.PictureBox imglogin;
        // private System.Windows.Forms.Button btn_logar;
        //private System.Windows.Forms.Button btn_sair;


    }
}