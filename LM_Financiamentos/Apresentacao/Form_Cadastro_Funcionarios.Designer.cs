
namespace LM_Financiamentos.Apresentacao
{
    partial class Form_Cadastro_Funcionarios
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
            this.panelcentro = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclosecadfunc = new System.Windows.Forms.Button();
            this.panelcentro.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcentro
            // 
            this.panelcentro.Controls.Add(this.paneltop);
            this.panelcentro.Controls.Add(this.panel2);
            this.panelcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentro.Location = new System.Drawing.Point(0, 0);
            this.panelcentro.Name = "panelcentro";
            this.panelcentro.Size = new System.Drawing.Size(800, 450);
            this.panelcentro.TabIndex = 2;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(5);
            this.paneltop.Size = new System.Drawing.Size(800, 66);
            this.paneltop.TabIndex = 9;
            // 
            // lbl_topo
            // 
            this.lbl_topo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(37, 5);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(395, 56);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Cadastro de Funcionarios";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = global::LM_Financiamentos.Properties.Resources.icons8_contacts_32;
            this.img_topo.Location = new System.Drawing.Point(5, 5);
            this.img_topo.Name = "img_topo";
            this.img_topo.Size = new System.Drawing.Size(32, 56);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btnclosecadfunc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 8;
            // 
            // btnclosecadfunc
            // 
            this.btnclosecadfunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecadfunc.FlatAppearance.BorderSize = 0;
            this.btnclosecadfunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecadfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclosecadfunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecadfunc.Location = new System.Drawing.Point(12, 12);
            this.btnclosecadfunc.Name = "btnclosecadfunc";
            this.btnclosecadfunc.Padding = new System.Windows.Forms.Padding(5);
            this.btnclosecadfunc.Size = new System.Drawing.Size(121, 36);
            this.btnclosecadfunc.TabIndex = 2;
            this.btnclosecadfunc.Text = "Fechar";
            this.btnclosecadfunc.UseVisualStyleBackColor = false;
            this.btnclosecadfunc.Click += new System.EventHandler(this.btnclosecadfunc_Click);
            // 
            // Form_Cadastro_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcentro);
            this.Name = "Form_Cadastro_Funcionarios";
            this.Text = "Form_Cadastro_Funcionarios";
            this.panelcentro.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentro;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclosecadfunc;
    }
}