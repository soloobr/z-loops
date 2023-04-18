
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Controle_Corretor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Controle_Corretor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcentro = new System.Windows.Forms.Panel();
            this.dgv_corretor = new System.Windows.Forms.DataGridView();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_excluir_func = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_editar_func = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_new_func = new System.Windows.Forms.Button();
            this.btnclosefunc = new System.Windows.Forms.Button();
            this.corretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCorretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corretor)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCorretorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcentro
            // 
            this.panelcentro.Controls.Add(this.dgv_corretor);
            this.panelcentro.Controls.Add(this.pnlcontrol);
            this.panelcentro.Controls.Add(this.paneltop);
            this.panelcentro.Controls.Add(this.panel2);
            this.panelcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentro.Location = new System.Drawing.Point(0, 0);
            this.panelcentro.Name = "panelcentro";
            this.panelcentro.Size = new System.Drawing.Size(1066, 500);
            this.panelcentro.TabIndex = 2;
            // 
            // dgv_corretor
            // 
            this.dgv_corretor.AllowUserToAddRows = false;
            this.dgv_corretor.AllowUserToDeleteRows = false;
            this.dgv_corretor.AllowUserToOrderColumns = true;
            this.dgv_corretor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_corretor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_corretor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_corretor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_corretor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_corretor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_corretor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_corretor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.CPF,
            this.Email,
            this.Endereco});
            this.dgv_corretor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_corretor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_corretor.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_corretor.Location = new System.Drawing.Point(0, 195);
            this.dgv_corretor.MultiSelect = false;
            this.dgv_corretor.Name = "dgv_corretor";
            this.dgv_corretor.RowHeadersVisible = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_corretor.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_corretor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_corretor.Size = new System.Drawing.Size(1066, 253);
            this.dgv_corretor.TabIndex = 12;
            this.dgv_corretor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funccionarios_CellDoubleClick);
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.btn_reload);
            this.pnlcontrol.Controls.Add(this.lblprocurar);
            this.pnlcontrol.Controls.Add(this.btnprocurar);
            this.pnlcontrol.Controls.Add(this.txtprocurar);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 57);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(1066, 138);
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
            this.btn_reload.TabIndex = 3;
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
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(1066, 57);
            this.paneltop.TabIndex = 9;
            // 
            // lbl_topo
            // 
            this.lbl_topo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(56, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(339, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Corretores";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = ((System.Drawing.Image)(resources.GetObject("img_topo.Image")));
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Size = new System.Drawing.Size(52, 49);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btn_excluir_func);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.btn_editar_func);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.btn_new_func);
            this.panel2.Controls.Add(this.btnclosefunc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1066, 52);
            this.panel2.TabIndex = 8;
            // 
            // btn_excluir_func
            // 
            this.btn_excluir_func.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluir_func.CausesValidation = false;
            this.btn_excluir_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_excluir_func.FlatAppearance.BorderSize = 0;
            this.btn_excluir_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_func.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluir_func.Location = new System.Drawing.Point(238, 10);
            this.btn_excluir_func.Name = "btn_excluir_func";
            this.btn_excluir_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluir_func.Size = new System.Drawing.Size(104, 32);
            this.btn_excluir_func.TabIndex = 34;
            this.btn_excluir_func.Text = "Excluir";
            this.btn_excluir_func.UseCompatibleTextRendering = true;
            this.btn_excluir_func.UseVisualStyleBackColor = false;
            this.btn_excluir_func.Click += new System.EventHandler(this.btn_excluir_func_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(228, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 33;
            this.splitter2.TabStop = false;
            // 
            // btn_editar_func
            // 
            this.btn_editar_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_editar_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar_func.FlatAppearance.BorderSize = 0;
            this.btn_editar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_func.Location = new System.Drawing.Point(124, 10);
            this.btn_editar_func.Name = "btn_editar_func";
            this.btn_editar_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_editar_func.Size = new System.Drawing.Size(104, 32);
            this.btn_editar_func.TabIndex = 32;
            this.btn_editar_func.Text = "Editar";
            this.btn_editar_func.UseCompatibleTextRendering = true;
            this.btn_editar_func.UseVisualStyleBackColor = false;
            this.btn_editar_func.Click += new System.EventHandler(this.btn_editar_func_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(114, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 32);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // btn_new_func
            // 
            this.btn_new_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_new_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_new_func.FlatAppearance.BorderSize = 0;
            this.btn_new_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new_func.Location = new System.Drawing.Point(10, 10);
            this.btn_new_func.Name = "btn_new_func";
            this.btn_new_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_new_func.Size = new System.Drawing.Size(104, 32);
            this.btn_new_func.TabIndex = 30;
            this.btn_new_func.Text = "Novo";
            this.btn_new_func.UseCompatibleTextRendering = true;
            this.btn_new_func.UseVisualStyleBackColor = false;
            this.btn_new_func.Click += new System.EventHandler(this.btn_new_func_Click);
            // 
            // btnclosefunc
            // 
            this.btnclosefunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosefunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosefunc.FlatAppearance.BorderSize = 0;
            this.btnclosefunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosefunc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosefunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosefunc.Location = new System.Drawing.Point(952, 10);
            this.btnclosefunc.Name = "btnclosefunc";
            this.btnclosefunc.Size = new System.Drawing.Size(104, 32);
            this.btnclosefunc.TabIndex = 2;
            this.btnclosefunc.Text = "Fechar";
            this.btnclosefunc.UseVisualStyleBackColor = false;
            this.btnclosefunc.Click += new System.EventHandler(this.btnclosecadfunc_Click);
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataMember = "Corretors";
            // 
            // id
            // 
            this.id.DataPropertyName = "id_corretor";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle16;
            this.id.FillWeight = 30F;
            this.id.HeaderText = "Nº";
            this.id.Name = "id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome_corretor";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle17;
            this.Nome.FillWeight = 90F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF_corretor";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CPF.DefaultCellStyle = dataGridViewCellStyle18;
            this.CPF.FillWeight = 70F;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email_corretor";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Email.DefaultCellStyle = dataGridViewCellStyle19;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco_corretor";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Endereco.DefaultCellStyle = dataGridViewCellStyle20;
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            // 
            // Form_Controle_Corretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 500);
            this.Controls.Add(this.panelcentro);
            this.Name = "Form_Controle_Corretor";
            this.Text = "Corretor";
            this.Load += new System.EventHandler(this.Form_Controle_Corretor_Load);
            this.Shown += new System.EventHandler(this.Form_Controle_Corretor_Shown);
            this.panelcentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corretor)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCorretorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentro;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclosefunc;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.BindingSource dSCorretorBindingSource;
        // private DAL.DS_Corretor dS_Corretor;
        private System.Windows.Forms.BindingSource corretorBindingSource;
        //private DAL.DS_CorretorTableAdapters.CorretorsTableAdapter corretorTableAdapter;
        private System.Windows.Forms.Button btn_excluir_func;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_editar_func;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_new_func;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.DataGridView dgv_corretor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
    }
}