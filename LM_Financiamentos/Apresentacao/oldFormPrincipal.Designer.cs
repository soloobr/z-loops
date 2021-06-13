
namespace LM_Financiamentos.Apresentacao
{
    partial class oldFormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnicocdoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnicocdoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnicocdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnicocdoc.ForeColor = System.Drawing.Color.Gainsboro;
            //this.btnicocdoc.Image = ((System.Drawing.Image)(resources.GetObject("btnicocdoc.Image")));
            this.btnicocdoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnicocdoc.Location = new System.Drawing.Point(0, 0);
            this.btnicocdoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnicocdoc.Name = "btnicocdoc";
            this.btnicocdoc.Size = new System.Drawing.Size(45, 46);
            this.btnicocdoc.TabIndex = 23;
            this.btnicocdoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnicocdoc.UseVisualStyleBackColor = true;
            this.btnicocdoc.Click += new System.EventHandler(this.btnicocdoc_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.img_foto);
            this.panelLogo.Controls.Add(this.lblsaudacao);
            this.panelLogo.Controls.Add(this.lblfunc);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 29);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10);
            this.panelLogo.Size = new System.Drawing.Size(230, 357);
            this.panelLogo.TabIndex = 18;
            // 
            // img_foto
            // 
            this.img_foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_foto.Image = global::LM_Financiamentos.Properties.Resources.icons8_contacts_250;
            this.img_foto.Location = new System.Drawing.Point(10, 10);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(210, 269);
            this.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_foto.TabIndex = 2;
            this.img_foto.TabStop = false;
            this.img_foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblsaudacao
            // 
            this.lblsaudacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblsaudacao.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsaudacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblsaudacao.Location = new System.Drawing.Point(10, 279);
            this.lblsaudacao.Name = "lblsaudacao";
            this.lblsaudacao.Size = new System.Drawing.Size(210, 34);
            this.lblsaudacao.TabIndex = 1;
            this.lblsaudacao.Text = "Ola!";
            this.lblsaudacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfunc
            // 
            this.lblfunc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblfunc.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblfunc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblfunc.Location = new System.Drawing.Point(10, 313);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(210, 34);
            this.lblfunc.TabIndex = 0;
            this.lblfunc.Text = "FuncionÃ¡rio";
            this.lblfunc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnmenurigth);
            this.panel1.Controls.Add(this.btnmenuleft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 29);
            this.panel1.TabIndex = 17;
            // 
            // btnmenurigth
            // 
            this.btnmenurigth.AutoSize = true;
            this.btnmenurigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmenurigth.FlatAppearance.BorderSize = 0;
            this.btnmenurigth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenurigth.Image = global::LM_Financiamentos.Properties.Resources.icons8_chevron_right_16;
            this.btnmenurigth.Location = new System.Drawing.Point(182, 0);
            this.btnmenurigth.Name = "btnmenurigth";
            this.btnmenurigth.Size = new System.Drawing.Size(24, 29);
            this.btnmenurigth.TabIndex = 1;
            this.btnmenurigth.UseVisualStyleBackColor = true;
            this.btnmenurigth.Visible = false;
            this.btnmenurigth.Click += new System.EventHandler(this.btnmenurigth_Click);
            // 
            // btnmenuleft
            // 
            this.btnmenuleft.AutoSize = true;
            this.btnmenuleft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmenuleft.FlatAppearance.BorderSize = 0;
            this.btnmenuleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenuleft.Image = global::LM_Financiamentos.Properties.Resources.icons8_chevron_left_16;
            this.btnmenuleft.Location = new System.Drawing.Point(206, 0);
            this.btnmenuleft.Name = "btnmenuleft";
            this.btnmenuleft.Size = new System.Drawing.Size(24, 29);
            this.btnmenuleft.TabIndex = 0;
            this.btnmenuleft.UseVisualStyleBackColor = true;
            this.btnmenuleft.Click += new System.EventHandler(this.btnmenuleft_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.lbl_title);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Size = new System.Drawing.Size(1192, 37);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_title.Location = new System.Drawing.Point(2, 2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(206, 34);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "LM Financiamentos";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1146, 12);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(14, 15);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1127, 12);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(14, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1146, 12);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(14, 15);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            //this.btnCerrar.Image = global::LM_Financiamentos.Properties.Resources.icons8_shutdown_16;
            this.btnCerrar.Location = new System.Drawing.Point(1165, 12);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(14, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Tag = "";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 620);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(569, 375);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primcipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_center)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCadastroSubMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelCadastroSubMenuIco.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lbl_title;
        //private System.Windows.Forms.Button nu;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.PictureBox img_center;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmenurigth;
        private System.Windows.Forms.Button btnmenuleft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncdoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Panel panelCadastroSubMenu;
        private System.Windows.Forms.Button btncadfor;
        private System.Windows.Forms.Button btncadcli;
        private System.Windows.Forms.Button btnconf;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelCadastroSubMenuIco;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnicocad;
        private System.Windows.Forms.Button btnicocdoc;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lblsaudacao;
        private System.Windows.Forms.PictureBox img_foto;
    }
}

