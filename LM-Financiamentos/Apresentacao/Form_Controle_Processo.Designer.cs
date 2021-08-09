
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Controle_Processo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Controle_Processo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnovodoc = new System.Windows.Forms.Button();
            this.btncloseconf = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Funcionario = new LMFinanciamentos.DAL.DS_Funcionario();
            this.funcionariosTableAdapter = new LMFinanciamentos.DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            this.dSClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes = new LMFinanciamentos.DAL.DS_Clientes();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.processosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Documentos = new LMFinanciamentos.DAL.DS_Documentos();
            this.processosTableAdapter = new LMFinanciamentos.DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
            this.dgv_process = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corretora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnnovodoc);
            this.panel1.Controls.Add(this.btncloseconf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1010, 52);
            this.panel1.TabIndex = 8;
            // 
            // btnnovodoc
            // 
            this.btnnovodoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnnovodoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnnovodoc.FlatAppearance.BorderSize = 0;
            this.btnnovodoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnovodoc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovodoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnovodoc.Location = new System.Drawing.Point(10, 10);
            this.btnnovodoc.Name = "btnnovodoc";
            this.btnnovodoc.Size = new System.Drawing.Size(104, 32);
            this.btnnovodoc.TabIndex = 3;
            this.btnnovodoc.Text = "Novo";
            this.btnnovodoc.UseVisualStyleBackColor = false;
            this.btnnovodoc.Click += new System.EventHandler(this.btnnovodoc_Click);
            // 
            // btncloseconf
            // 
            this.btncloseconf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncloseconf.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncloseconf.FlatAppearance.BorderSize = 0;
            this.btncloseconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseconf.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseconf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncloseconf.Location = new System.Drawing.Point(896, 10);
            this.btncloseconf.Name = "btncloseconf";
            this.btncloseconf.Size = new System.Drawing.Size(104, 32);
            this.btncloseconf.TabIndex = 2;
            this.btncloseconf.Text = "Fechar";
            this.btncloseconf.UseVisualStyleBackColor = false;
            this.btncloseconf.Click += new System.EventHandler(this.btncloseconf_Click);
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
            this.paneltop.Size = new System.Drawing.Size(1010, 57);
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
            this.lbl_topo.Size = new System.Drawing.Size(390, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Controle de Processos";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.img_topo.Click += new System.EventHandler(this.img_topo_Click);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.dS_Funcionario;
            // 
            // dS_Funcionario
            // 
            this.dS_Funcionario.DataSetName = "DS_Funcionario";
            this.dS_Funcionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // dSClientesBindingSource
            // 
            this.dSClientesBindingSource.DataSource = this.dS_Clientes;
            this.dSClientesBindingSource.Position = 0;
            // 
            // dS_Clientes
            // 
            this.dS_Clientes.DataSetName = "DS_Clientes";
            this.dS_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.lblprocurar);
            this.pnlcontrol.Controls.Add(this.btnprocurar);
            this.pnlcontrol.Controls.Add(this.txtprocurar);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 57);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(1010, 138);
            this.pnlcontrol.TabIndex = 10;
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
            // processosBindingSource
            // 
            this.processosBindingSource.DataMember = "Processos";
            this.processosBindingSource.DataSource = this.dSDocumentosBindingSource;
            // 
            // dSDocumentosBindingSource
            // 
            this.dSDocumentosBindingSource.DataSource = this.dS_Documentos;
            this.dSDocumentosBindingSource.Position = 0;
            // 
            // dS_Documentos
            // 
            this.dS_Documentos.DataSetName = "DS_Documentos";
            this.dS_Documentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processosTableAdapter
            // 
            this.processosTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_process
            // 
            this.dgv_process.AllowUserToAddRows = false;
            this.dgv_process.AllowUserToDeleteRows = false;
            this.dgv_process.AllowUserToOrderColumns = true;
            this.dgv_process.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_process.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_process.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_process.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_process.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_process.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_process.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_process.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cliente,
            this.Data,
            this.Funcionario,
            this.Corretora,
            this.Corretor});
            this.dgv_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_process.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_process.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_process.Location = new System.Drawing.Point(0, 195);
            this.dgv_process.MultiSelect = false;
            this.dgv_process.Name = "dgv_process";
            this.dgv_process.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_process.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = " - ";
            this.dgv_process.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_process.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_process.Size = new System.Drawing.Size(1010, 143);
            this.dgv_process.TabIndex = 13;
            this.dgv_process.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_process_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_processo";
            this.Id.HeaderText = "Nº Processo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nome_cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data_processo";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Funcionario
            // 
            this.Funcionario.DataPropertyName = "Nome_responsavel";
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            // 
            // Corretora
            // 
            this.Corretora.DataPropertyName = "Descricao_corretora";
            this.Corretora.HeaderText = "Corretora";
            this.Corretora.Name = "Corretora";
            this.Corretora.ReadOnly = true;
            // 
            // Corretor
            // 
            this.Corretor.DataPropertyName = "Nome_corretor";
            this.Corretor.HeaderText = "Corretor";
            this.Corretor.Name = "Corretor";
            this.Corretor.ReadOnly = true;
            // 
            // Form_Controle_Processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 390);
            this.Controls.Add(this.dgv_process);
            this.Controls.Add(this.pnlcontrol);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Controle_Processo";
            this.Text = "Form_Controle_Documento";
            this.Load += new System.EventHandler(this.Form_Controle_Documento_Load);
            this.panel1.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private DAL.DS_Funcionario dS_Funcionario;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource dSClientesBindingSource;
        private DAL.DS_Clientes dS_Clientes;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.BindingSource dSDocumentosBindingSource;
        private DAL.DS_Documentos dS_Documentos;
        private System.Windows.Forms.BindingSource processosBindingSource;
        private DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter processosTableAdapter;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.Label lblprocurar;
        public System.Windows.Forms.Button btncloseconf;
        public System.Windows.Forms.Button btnnovodoc;
        private System.Windows.Forms.DataGridView dgv_process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corretora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corretor;
    }
}