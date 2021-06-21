
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Controle_Documento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Controle_Documento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_process = new System.Windows.Forms.DataGridView();
            this.processoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corretoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corretorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Documentos = new LMFinanciamentos.DAL.DS_Documentos();
            this.processosTableAdapter = new LMFinanciamentos.DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
            this.panel1.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(982, 52);
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
            this.btncloseconf.Location = new System.Drawing.Point(868, 10);
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
            this.paneltop.Size = new System.Drawing.Size(982, 57);
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
            this.lbl_topo.Text = "Controle de Documentos";
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
            this.pnlcontrol.Size = new System.Drawing.Size(982, 138);
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
            // dgv_process
            // 
            this.dgv_process.AllowUserToAddRows = false;
            this.dgv_process.AllowUserToDeleteRows = false;
            this.dgv_process.AllowUserToOrderColumns = true;
            this.dgv_process.AutoGenerateColumns = false;
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
            this.processoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.corretoraDataGridViewTextBoxColumn,
            this.corretorDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_process.DataSource = this.processosBindingSource;
            this.dgv_process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_process.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_process.Location = new System.Drawing.Point(0, 195);
            this.dgv_process.Name = "dgv_process";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_process.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = " - ";
            this.dgv_process.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_process.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_process.Size = new System.Drawing.Size(982, 143);
            this.dgv_process.TabIndex = 11;
            this.dgv_process.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_process_CellContentClick);
            // 
            // processoDataGridViewTextBoxColumn
            // 
            this.processoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.processoDataGridViewTextBoxColumn.DataPropertyName = "Processo";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.processoDataGridViewTextBoxColumn.HeaderText = "Nº Processo";
            this.processoDataGridViewTextBoxColumn.Name = "processoDataGridViewTextBoxColumn";
            this.processoDataGridViewTextBoxColumn.Width = 138;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 81;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // corretoraDataGridViewTextBoxColumn
            // 
            this.corretoraDataGridViewTextBoxColumn.DataPropertyName = "Corretora";
            this.corretoraDataGridViewTextBoxColumn.HeaderText = "Corretora";
            this.corretoraDataGridViewTextBoxColumn.Name = "corretoraDataGridViewTextBoxColumn";
            // 
            // corretorDataGridViewTextBoxColumn
            // 
            this.corretorDataGridViewTextBoxColumn.DataPropertyName = "Corretor";
            this.corretorDataGridViewTextBoxColumn.HeaderText = "Corretor";
            this.corretorDataGridViewTextBoxColumn.Name = "corretorDataGridViewTextBoxColumn";
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionário";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
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
            // Form_Controle_Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 390);
            this.Controls.Add(this.dgv_process);
            this.Controls.Add(this.pnlcontrol);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Controle_Documento";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_process;
        private System.Windows.Forms.BindingSource dSDocumentosBindingSource;
        private DAL.DS_Documentos dS_Documentos;
        private System.Windows.Forms.BindingSource processosBindingSource;
        private DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter processosTableAdapter;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn processoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corretoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corretorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btncloseconf;
        public System.Windows.Forms.Button btnnovodoc;
    }
}