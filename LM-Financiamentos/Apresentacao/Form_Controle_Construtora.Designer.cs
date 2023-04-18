
using System;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Controle_Construtora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Controle_Construtora));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_construtora = new System.Windows.Forms.DataGridView();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_editar = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_new_construtora = new System.Windows.Forms.Button();
            this.btnclosvend = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.idconstrutora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcentralcadcli.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_construtora)).BeginInit();
            this.pnlcontrol.SuspendLayout();
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
            this.panelcentralcadcli.Size = new System.Drawing.Size(1142, 617);
            this.panelcentralcadcli.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_construtora);
            this.panel2.Controls.Add(this.pnlcontrol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 508);
            this.panel2.TabIndex = 9;
            // 
            // dgv_construtora
            // 
            this.dgv_construtora.AllowUserToAddRows = false;
            this.dgv_construtora.AllowUserToDeleteRows = false;
            this.dgv_construtora.AllowUserToOrderColumns = true;
            this.dgv_construtora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_construtora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_construtora.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_construtora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_construtora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_construtora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_construtora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_construtora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_construtora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconstrutora,
            this.Descricao,
            this.CNPJ,
            this.Endereco});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_construtora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_construtora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_construtora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_construtora.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_construtora.Location = new System.Drawing.Point(0, 138);
            this.dgv_construtora.MultiSelect = false;
            this.dgv_construtora.Name = "dgv_construtora";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_construtora.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_construtora.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = " - ";
            this.dgv_construtora.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_construtora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_construtora.Size = new System.Drawing.Size(1142, 370);
            this.dgv_construtora.TabIndex = 12;
            this.dgv_construtora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_construtora_CellDoubleClick);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.btn_reload);
            this.pnlcontrol.Controls.Add(this.lblprocurar);
            this.pnlcontrol.Controls.Add(this.btnprocurar);
            this.pnlcontrol.Controls.Add(this.txtprocurar);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(1142, 138);
            this.pnlcontrol.TabIndex = 11;
            // 
            // btn_reload
            // 
            this.btn_reload.AutoSize = true;
            this.btn_reload.BackColor = System.Drawing.Color.Silver;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.Location = new System.Drawing.Point(294, 44);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Padding = new System.Windows.Forms.Padding(2);
            this.btn_reload.Size = new System.Drawing.Size(38, 30);
            this.btn_reload.TabIndex = 5;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // lblprocurar
            // 
            this.lblprocurar.AutoSize = true;
            this.lblprocurar.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprocurar.Location = new System.Drawing.Point(22, 20);
            this.lblprocurar.Name = "lblprocurar";
            this.lblprocurar.Size = new System.Drawing.Size(86, 22);
            this.lblprocurar.TabIndex = 2;
            this.lblprocurar.Text = "Procurar por:";
            // 
            // btnprocurar
            // 
            this.btnprocurar.AutoSize = true;
            this.btnprocurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnprocurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprocurar.FlatAppearance.BorderSize = 0;
            this.btnprocurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocurar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprocurar.Image = ((System.Drawing.Image)(resources.GetObject("btnprocurar.Image")));
            this.btnprocurar.Location = new System.Drawing.Point(250, 45);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Padding = new System.Windows.Forms.Padding(2);
            this.btnprocurar.Size = new System.Drawing.Size(38, 27);
            this.btnprocurar.TabIndex = 1;
            this.btnprocurar.UseVisualStyleBackColor = false;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // txtprocurar
            // 
            this.txtprocurar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprocurar.Location = new System.Drawing.Point(26, 45);
            this.txtprocurar.Name = "txtprocurar";
            this.txtprocurar.Size = new System.Drawing.Size(218, 27);
            this.txtprocurar.TabIndex = 0;
            this.txtprocurar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprocurar_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btn_new_construtora);
            this.panel1.Controls.Add(this.btnclosvend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1142, 52);
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
            this.btn_excluir.Location = new System.Drawing.Point(238, 10);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Size = new System.Drawing.Size(104, 32);
            this.btn_excluir.TabIndex = 29;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseCompatibleTextRendering = true;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(228, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_editar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar.Location = new System.Drawing.Point(124, 10);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_editar.Size = new System.Drawing.Size(104, 32);
            this.btn_editar.TabIndex = 27;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseCompatibleTextRendering = true;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(114, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 32);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // btn_new_construtora
            // 
            this.btn_new_construtora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_new_construtora.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_new_construtora.FlatAppearance.BorderSize = 0;
            this.btn_new_construtora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_construtora.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_construtora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new_construtora.Location = new System.Drawing.Point(10, 10);
            this.btn_new_construtora.Name = "btn_new_construtora";
            this.btn_new_construtora.Padding = new System.Windows.Forms.Padding(4);
            this.btn_new_construtora.Size = new System.Drawing.Size(104, 32);
            this.btn_new_construtora.TabIndex = 19;
            this.btn_new_construtora.Text = "Novo";
            this.btn_new_construtora.UseCompatibleTextRendering = true;
            this.btn_new_construtora.UseVisualStyleBackColor = false;
            this.btn_new_construtora.Click += new System.EventHandler(this.btn_new_client_Click);
            // 
            // btnclosvend
            // 
            this.btnclosvend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosvend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosvend.FlatAppearance.BorderSize = 0;
            this.btnclosvend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosvend.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosvend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosvend.Location = new System.Drawing.Point(1028, 10);
            this.btnclosvend.Name = "btnclosvend";
            this.btnclosvend.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosvend.Size = new System.Drawing.Size(104, 32);
            this.btnclosvend.TabIndex = 20;
            this.btnclosvend.Text = "Fechar";
            this.btnclosvend.UseCompatibleTextRendering = true;
            this.btnclosvend.UseVisualStyleBackColor = false;
            this.btnclosvend.Click += new System.EventHandler(this.btnclosvend_Click);
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
            this.paneltop.Size = new System.Drawing.Size(1142, 57);
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
            this.lbl_topo.Size = new System.Drawing.Size(198, 49);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Construtora";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = ((System.Drawing.Image)(resources.GetObject("img_topo.Image")));
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Padding = new System.Windows.Forms.Padding(5);
            this.img_topo.Size = new System.Drawing.Size(58, 49);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // idconstrutora
            // 
            this.idconstrutora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idconstrutora.DataPropertyName = "Id_construtora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0000";
            this.idconstrutora.DefaultCellStyle = dataGridViewCellStyle2;
            this.idconstrutora.HeaderText = "Nº";
            this.idconstrutora.Name = "idconstrutora";
            this.idconstrutora.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descri_construtora";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ_construtora";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "End_construtora";
            this.Endereco.FillWeight = 200F;
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.MinimumWidth = 35;
            this.Endereco.Name = "Endereco";
            // 
            // Form_Controle_Construtora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 617);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Controle_Construtora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Construtora";
            this.Load += new System.EventHandler(this.Form_Controle_Construtora_Load);
            this.Shown += new System.EventHandler(this.Form_Controle_Construtora_Shown);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_construtora)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
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
        private System.Windows.Forms.Button btn_new_construtora;
        private System.Windows.Forms.Button btnclosvend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.DataGridView dgv_construtora;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconstrutora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
    }
}