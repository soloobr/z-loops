
using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Windows;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Construtora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Construtora));
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabconstrutora = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtconstrutora = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btnclosecli = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panelcentralcadcli.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabconstrutora.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcentralcadcli
            // 
            this.panelcentralcadcli.Controls.Add(this.panel2);
            this.panelcentralcadcli.Controls.Add(this.panel1);
            this.panelcentralcadcli.Controls.Add(this.paneltop);
            this.panelcentralcadcli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentralcadcli.Location = new System.Drawing.Point(0, 0);
            this.panelcentralcadcli.Name = "panelcentralcadcli";
            this.panelcentralcadcli.Size = new System.Drawing.Size(979, 617);
            this.panelcentralcadcli.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 500);
            this.panel2.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabconstrutora);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(979, 213);
            this.tabControl.TabIndex = 11;
            // 
            // tabconstrutora
            // 
            this.tabconstrutora.Controls.Add(this.tableLayoutPanel1);
            this.tabconstrutora.Location = new System.Drawing.Point(4, 32);
            this.tabconstrutora.Name = "tabconstrutora";
            this.tabconstrutora.Size = new System.Drawing.Size(971, 177);
            this.tabconstrutora.TabIndex = 2;
            this.tabconstrutora.Text = "Construtora";
            this.tabconstrutora.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblcnpj, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcnpj, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtend, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtconstrutora, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtdescricao, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 121);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(501, 0);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(50, 23);
            this.lblcnpj.TabIndex = 71;
            this.lblcnpj.Text = "CNPJ:";
            // 
            // txtcnpj
            // 
            this.txtcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcnpj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(501, 26);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.ReadOnly = true;
            this.txtcnpj.Size = new System.Drawing.Size(216, 27);
            this.txtcnpj.TabIndex = 2;
            this.txtcnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcnpj_KeyDown);
            this.txtcnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcnpj_KeyPress);
            this.txtcnpj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcnpj_KeyUp);
            // 
            // txtend
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtend, 3);
            this.txtend.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(3, 82);
            this.txtend.Name = "txtend";
            this.txtend.ReadOnly = true;
            this.txtend.Size = new System.Drawing.Size(548, 27);
            this.txtend.TabIndex = 3;
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
            // txtconstrutora
            // 
            this.txtconstrutora.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconstrutora.Location = new System.Drawing.Point(3, 26);
            this.txtconstrutora.Name = "txtconstrutora";
            this.txtconstrutora.ReadOnly = true;
            this.txtconstrutora.Size = new System.Drawing.Size(166, 27);
            this.txtconstrutora.TabIndex = 0;
            this.txtconstrutora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(175, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(320, 23);
            this.lblcliente.TabIndex = 51;
            this.lblcliente.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtdescricao.Location = new System.Drawing.Point(175, 26);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.ReadOnly = true;
            this.txtdescricao.Size = new System.Drawing.Size(320, 27);
            this.txtdescricao.TabIndex = 1;
            this.txtdescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdescricaoag_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nº Construtora:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btnclosecli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(979, 52);
            this.panel1.TabIndex = 8;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluir.CausesValidation = false;
            this.btn_excluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluir.Location = new System.Drawing.Point(352, 10);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Size = new System.Drawing.Size(104, 32);
            this.btn_excluir.TabIndex = 16;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseCompatibleTextRendering = true;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitter3.Location = new System.Drawing.Point(342, 10);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(10, 32);
            this.splitter3.TabIndex = 30;
            this.splitter3.TabStop = false;
            this.splitter3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter3_SplitterMoved);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(238, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Size = new System.Drawing.Size(104, 32);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseCompatibleTextRendering = true;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitter2.Location = new System.Drawing.Point(228, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 24;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_salvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salvar.Location = new System.Drawing.Point(124, 10);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Size = new System.Drawing.Size(104, 32);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseCompatibleTextRendering = true;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Visible = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(114, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 32);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            this.splitter1.Visible = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar.Location = new System.Drawing.Point(10, 10);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_editar.Size = new System.Drawing.Size(104, 32);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseCompatibleTextRendering = true;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btnclosecli
            // 
            this.btnclosecli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecli.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosecli.FlatAppearance.BorderSize = 0;
            this.btnclosecli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosecli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecli.Location = new System.Drawing.Point(865, 10);
            this.btnclosecli.Name = "btnclosecli";
            this.btnclosecli.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosecli.Size = new System.Drawing.Size(104, 32);
            this.btnclosecli.TabIndex = 17;
            this.btnclosecli.Text = "Fechar";
            this.btnclosecli.UseCompatibleTextRendering = true;
            this.btnclosecli.UseVisualStyleBackColor = false;
            this.btnclosecli.Click += new System.EventHandler(this.btnclosecli_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(979, 65);
            this.paneltop.TabIndex = 6;
            // 
            // lbl_topo
            // 
            this.lbl_topo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(62, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(348, 57);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Dados do Construtora";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = ((System.Drawing.Image)(resources.GetObject("img_topo.Image")));
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Padding = new System.Windows.Forms.Padding(5);
            this.img_topo.Size = new System.Drawing.Size(58, 57);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form_Dados_Construtora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Construtora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Construtora";
            this.Load += new System.EventHandler(this.Form_Dados_Construtora_Load);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabconstrutora.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panelcentralcadcli;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btnclosecli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Splitter splitter1;
        private OpenFileDialog ofd1;
        private Button btn_excluir;
        private Splitter splitter3;
        private TabControl tabControl;
        private TabPage tabconstrutora;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtend;
        private Label label6;
        private TextBox txtconstrutora;
        private Label lblcliente;
        private TextBox txtdescricao;
        private Label label2;
        private Label lblcnpj;
        private TextBox txtcnpj;
    }
}