
namespace LM_Financiamentos.Apresentacao
{
    partial class Form_Cadastro_Fornecedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclosecadforne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnclosecadforne);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // btnclosecadforne
            // 
            this.btnclosecadforne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecadforne.FlatAppearance.BorderSize = 0;
            this.btnclosecadforne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecadforne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclosecadforne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecadforne.Location = new System.Drawing.Point(12, 12);
            this.btnclosecadforne.Name = "btnclosecadforne";
            this.btnclosecadforne.Padding = new System.Windows.Forms.Padding(5);
            this.btnclosecadforne.Size = new System.Drawing.Size(121, 36);
            this.btnclosecadforne.TabIndex = 2;
            this.btnclosecadforne.Text = "Fechar";
            this.btnclosecadforne.UseVisualStyleBackColor = false;
            this.btnclosecadforne.Click += new System.EventHandler(this.btncloseconf_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 390);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Fornecedor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Cadastro_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Cadastro_Fornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.Form_Cadastro_Fornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclosecadforne;
        private System.Windows.Forms.Label label1;
    }
}