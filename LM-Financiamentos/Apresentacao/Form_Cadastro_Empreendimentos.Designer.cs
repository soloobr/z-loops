
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Cadastro_Empreendimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Empreendimentos));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btnclosecli = new System.Windows.Forms.Button();
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabampreendimento = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtampreendimento = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtdescricaoempreendimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelcentralcadcli.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabampreendimento.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btnclosecli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(555, 52);
            this.panel1.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(124, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Size = new System.Drawing.Size(104, 32);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseCompatibleTextRendering = true;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(114, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 26;
            this.splitter2.TabStop = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salvar.Location = new System.Drawing.Point(10, 10);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Size = new System.Drawing.Size(104, 32);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseCompatibleTextRendering = true;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btnclosecli
            // 
            this.btnclosecli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecli.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosecli.FlatAppearance.BorderSize = 0;
            this.btnclosecli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosecli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecli.Location = new System.Drawing.Point(441, 10);
            this.btnclosecli.Name = "btnclosecli";
            this.btnclosecli.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosecli.Size = new System.Drawing.Size(104, 32);
            this.btnclosecli.TabIndex = 5;
            this.btnclosecli.Text = "Fechar";
            this.btnclosecli.UseCompatibleTextRendering = true;
            this.btnclosecli.UseVisualStyleBackColor = false;
            this.btnclosecli.Click += new System.EventHandler(this.btnclosecli_Click);
            // 
            // panelcentralcadcli
            // 
            this.panelcentralcadcli.Controls.Add(this.panel2);
            this.panelcentralcadcli.Controls.Add(this.panel1);
            this.panelcentralcadcli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentralcadcli.Location = new System.Drawing.Point(0, 0);
            this.panelcentralcadcli.Name = "panelcentralcadcli";
            this.panelcentralcadcli.Size = new System.Drawing.Size(555, 320);
            this.panelcentralcadcli.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 178);
            this.panel2.TabIndex = 11;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabampreendimento);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(555, 213);
            this.tabControl.TabIndex = 10;
            // 
            // tabampreendimento
            // 
            this.tabampreendimento.Controls.Add(this.tableLayoutPanel1);
            this.tabampreendimento.Location = new System.Drawing.Point(4, 32);
            this.tabampreendimento.Name = "tabampreendimento";
            this.tabampreendimento.Size = new System.Drawing.Size(547, 177);
            this.tabampreendimento.TabIndex = 2;
            this.tabampreendimento.Text = "Cadastrar:";
            this.tabampreendimento.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtend, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtampreendimento, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtdescricaoempreendimento, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 121);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtend
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtend, 2);
            this.txtend.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(3, 82);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(461, 27);
            this.txtend.TabIndex = 2;
            this.txtend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtend_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "Endereço:";
            // 
            // txtampreendimento
            // 
            this.txtampreendimento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtampreendimento.Location = new System.Drawing.Point(3, 26);
            this.txtampreendimento.Name = "txtampreendimento";
            this.txtampreendimento.ReadOnly = true;
            this.txtampreendimento.Size = new System.Drawing.Size(166, 27);
            this.txtampreendimento.TabIndex = 0;
            this.txtampreendimento.Text = "---";
            this.txtampreendimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(175, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(369, 23);
            this.lblcliente.TabIndex = 51;
            this.lblcliente.Text = "Descrição:";
            // 
            // txtdescricaoempreendimento
            // 
            this.txtdescricaoempreendimento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricaoempreendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtdescricaoempreendimento.Location = new System.Drawing.Point(175, 26);
            this.txtdescricaoempreendimento.Name = "txtdescricaoempreendimento";
            this.txtdescricaoempreendimento.Size = new System.Drawing.Size(196, 27);
            this.txtdescricaoempreendimento.TabIndex = 1;
            this.txtdescricaoempreendimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdescricaoempreendimento_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nº Empreendimento:";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 32);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(555, 50);
            this.paneltop.TabIndex = 11;
            // 
            // lbl_topo
            // 
            this.lbl_topo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(46, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(462, 42);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Cadastro de Empreendimentos";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = ((System.Drawing.Image)(resources.GetObject("img_topo.Image")));
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Padding = new System.Windows.Forms.Padding(5);
            this.img_topo.Size = new System.Drawing.Size(42, 42);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.lbl_title);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Size = new System.Drawing.Size(555, 32);
            this.panelBarraTitulo.TabIndex = 10;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lbl_title.Location = new System.Drawing.Point(2, 2);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(206, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "LM Financiamentos";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(529, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(10);
            this.btnMinimizar.Size = new System.Drawing.Size(24, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            // 
            // Form_Cadastro_Empreendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 320);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelcentralcadcli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Cadastro_Empreendimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form_Cadastro_Empreendimentos_Load);
            this.panel1.ResumeLayout(false);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabampreendimento.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btnclosecli;
        private System.Windows.Forms.Panel panelcentralcadcli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabampreendimento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtampreendimento;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtdescricaoempreendimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}