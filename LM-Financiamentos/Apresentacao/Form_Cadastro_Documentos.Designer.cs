
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Cadastro_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Documentos));
            this.btnsalvardoc = new System.Windows.Forms.Button();
            this.dS_Documentos = new LMFinanciamentos.DAL.DS_Documentos();
            this.dSDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes = new LMFinanciamentos.DAL.DS_Clientes();
            this.dSClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new LMFinanciamentos.DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            this.dS_Funcionario = new LMFinanciamentos.DAL.DS_Funcionario();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_topo = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.btncloseconf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelardoc = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.processosTableAdapter = new LMFinanciamentos.DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtfgts = new System.Windows.Forms.ComboBox();
            this.statusFGTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Combobox = new LMFinanciamentos.DAL.DS_Combobox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtir = new System.Windows.Forms.ComboBox();
            this.statusIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtcadmut = new System.Windows.Forms.ComboBox();
            this.statusCadmutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtciweb = new System.Windows.Forms.ComboBox();
            this.statusCiwebBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStatusCPF = new System.Windows.Forms.ComboBox();
            this.statusCPFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtrenda = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnasc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtnomecli = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.tabproduto = new System.Windows.Forms.TabPage();
            this.tabdocumentos = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabdoc = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.statusCPFTableAdapter = new LMFinanciamentos.DAL.DS_ComboboxTableAdapters.StatusCPFTableAdapter();
            this.clientesTableAdapter = new LMFinanciamentos.DAL.DS_ClientesTableAdapters.ClientesTableAdapter();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.statusCiwebTableAdapter = new LMFinanciamentos.DAL.DS_ComboboxTableAdapters.StatusCiwebTableAdapter();
            this.statusCadmutTableAdapter = new LMFinanciamentos.DAL.DS_ComboboxTableAdapters.StatusCadmutTableAdapter();
            this.statusIRTableAdapter = new LMFinanciamentos.DAL.DS_ComboboxTableAdapters.StatusIRTableAdapter();
            this.statusFGTSTableAdapter = new LMFinanciamentos.DAL.DS_ComboboxTableAdapters.StatusFGTSTableAdapter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcorretora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabcliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusFGTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Combobox)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIRBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCadmutBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCiwebBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCPFBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.tabproduto.SuspendLayout();
            this.tabdocumentos.SuspendLayout();
            this.tabdoc.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalvardoc
            // 
            this.btnsalvardoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnsalvardoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsalvardoc.FlatAppearance.BorderSize = 0;
            this.btnsalvardoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvardoc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvardoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsalvardoc.Location = new System.Drawing.Point(10, 10);
            this.btnsalvardoc.Name = "btnsalvardoc";
            this.btnsalvardoc.Size = new System.Drawing.Size(104, 32);
            this.btnsalvardoc.TabIndex = 3;
            this.btnsalvardoc.Text = "Salvar";
            this.btnsalvardoc.UseVisualStyleBackColor = false;
            this.btnsalvardoc.Click += new System.EventHandler(this.btnsalvardoc_Click);
            // 
            // dS_Documentos
            // 
            this.dS_Documentos.DataSetName = "DS_Documentos";
            this.dS_Documentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSDocumentosBindingSource
            // 
            this.dSDocumentosBindingSource.DataSource = this.dS_Documentos;
            this.dSDocumentosBindingSource.Position = 0;
            // 
            // processosBindingSource
            // 
            this.processosBindingSource.DataMember = "Processos";
            this.processosBindingSource.DataSource = this.dSDocumentosBindingSource;
            // 
            // dS_Clientes
            // 
            this.dS_Clientes.DataSetName = "DS_Clientes";
            this.dS_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSClientesBindingSource
            // 
            this.dSClientesBindingSource.DataSource = this.dS_Clientes;
            this.dSClientesBindingSource.Position = 0;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Funcionario
            // 
            this.dS_Funcionario.DataSetName = "DS_Funcionario";
            this.dS_Funcionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.dS_Funcionario;
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
            this.lbl_topo.Size = new System.Drawing.Size(333, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Cadastro de Processo";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_topo.Click += new System.EventHandler(this.lbl_topo_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lblstatus);
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(992, 57);
            this.paneltop.TabIndex = 13;
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblstatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblstatus.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblstatus.ForeColor = System.Drawing.Color.Black;
            this.lblstatus.Location = new System.Drawing.Point(609, 4);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(3);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(379, 49);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "Status";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // btncloseconf
            // 
            this.btncloseconf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncloseconf.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncloseconf.FlatAppearance.BorderSize = 0;
            this.btncloseconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseconf.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseconf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncloseconf.Location = new System.Drawing.Point(878, 10);
            this.btncloseconf.Name = "btncloseconf";
            this.btncloseconf.Size = new System.Drawing.Size(104, 32);
            this.btncloseconf.TabIndex = 2;
            this.btncloseconf.Text = "Fechar";
            this.btncloseconf.UseVisualStyleBackColor = false;
            this.btncloseconf.Click += new System.EventHandler(this.btncloseconf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btncancelardoc);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnsalvardoc);
            this.panel1.Controls.Add(this.btncloseconf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 671);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(992, 52);
            this.panel1.TabIndex = 12;
            // 
            // btncancelardoc
            // 
            this.btncancelardoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncancelardoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncancelardoc.FlatAppearance.BorderSize = 0;
            this.btncancelardoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelardoc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelardoc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelardoc.Location = new System.Drawing.Point(124, 10);
            this.btncancelardoc.Name = "btncancelardoc";
            this.btncancelardoc.Size = new System.Drawing.Size(104, 32);
            this.btncancelardoc.TabIndex = 5;
            this.btncancelardoc.Text = "Cancelar";
            this.btncancelardoc.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(114, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 32);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // processosTableAdapter
            // 
            this.processosTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabcliente);
            this.tabControl.Controls.Add(this.tabproduto);
            this.tabControl.Controls.Add(this.tabdocumentos);
            this.tabControl.Controls.Add(this.tabdoc);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 614);
            this.tabControl.TabIndex = 14;
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.groupBox1);
            this.tabcliente.Controls.Add(this.panel2);
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Location = new System.Drawing.Point(4, 30);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(963, 495);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(923, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situações:";
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.txtfgts);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(738, 28);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(183, 72);
            this.panel8.TabIndex = 10;
            // 
            // txtfgts
            // 
            this.txtfgts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfgts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfgts.DataSource = this.statusFGTSBindingSource;
            this.txtfgts.DisplayMember = "Descricao";
            this.txtfgts.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtfgts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtfgts.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfgts.FormattingEnabled = true;
            this.txtfgts.Location = new System.Drawing.Point(3, 24);
            this.txtfgts.Name = "txtfgts";
            this.txtfgts.Size = new System.Drawing.Size(177, 29);
            this.txtfgts.TabIndex = 20;
            // 
            // statusFGTSBindingSource
            // 
            this.statusFGTSBindingSource.DataMember = "StatusFGTS";
            this.statusFGTSBindingSource.DataSource = this.dS_Combobox;
            // 
            // dS_Combobox
            // 
            this.dS_Combobox.DataSetName = "DS_Combobox";
            this.dS_Combobox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Location = new System.Drawing.Point(3, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 21);
            this.label24.TabIndex = 19;
            this.label24.Text = "FGTS:";
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.txtir);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(555, 28);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(183, 72);
            this.panel7.TabIndex = 9;
            // 
            // txtir
            // 
            this.txtir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtir.DataSource = this.statusIRBindingSource;
            this.txtir.DisplayMember = "Descricao";
            this.txtir.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtir.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.FormattingEnabled = true;
            this.txtir.Location = new System.Drawing.Point(3, 24);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(177, 29);
            this.txtir.TabIndex = 20;
            // 
            // statusIRBindingSource
            // 
            this.statusIRBindingSource.DataMember = "StatusIR";
            this.statusIRBindingSource.DataSource = this.dS_Combobox;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Location = new System.Drawing.Point(3, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 21);
            this.label23.TabIndex = 19;
            this.label23.Text = "Declaração IR:";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.txtcadmut);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(372, 28);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(183, 72);
            this.panel6.TabIndex = 8;
            // 
            // txtcadmut
            // 
            this.txtcadmut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcadmut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcadmut.DataSource = this.statusCadmutBindingSource;
            this.txtcadmut.DisplayMember = "Descricao";
            this.txtcadmut.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcadmut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcadmut.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadmut.FormattingEnabled = true;
            this.txtcadmut.Location = new System.Drawing.Point(3, 24);
            this.txtcadmut.Name = "txtcadmut";
            this.txtcadmut.Size = new System.Drawing.Size(177, 29);
            this.txtcadmut.TabIndex = 20;
            // 
            // statusCadmutBindingSource
            // 
            this.statusCadmutBindingSource.DataMember = "StatusCadmut";
            this.statusCadmutBindingSource.DataSource = this.dS_Combobox;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 21);
            this.label22.TabIndex = 19;
            this.label22.Text = "Situação Cadmut:";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.txtciweb);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(189, 28);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(183, 72);
            this.panel5.TabIndex = 7;
            // 
            // txtciweb
            // 
            this.txtciweb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtciweb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtciweb.DataSource = this.statusCiwebBindingSource;
            this.txtciweb.DisplayMember = "Descricao";
            this.txtciweb.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtciweb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtciweb.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciweb.FormattingEnabled = true;
            this.txtciweb.Location = new System.Drawing.Point(3, 24);
            this.txtciweb.Name = "txtciweb";
            this.txtciweb.Size = new System.Drawing.Size(177, 29);
            this.txtciweb.TabIndex = 20;
            // 
            // statusCiwebBindingSource
            // 
            this.statusCiwebBindingSource.DataMember = "StatusCiweb";
            this.statusCiwebBindingSource.DataSource = this.dS_Combobox;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 21);
            this.label21.TabIndex = 19;
            this.label21.Text = "Situação Ciweb:";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.txtStatusCPF);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(6, 28);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(183, 72);
            this.panel4.TabIndex = 6;
            // 
            // txtStatusCPF
            // 
            this.txtStatusCPF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStatusCPF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStatusCPF.DataSource = this.statusCPFBindingSource;
            this.txtStatusCPF.DisplayMember = "Descricao";
            this.txtStatusCPF.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStatusCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtStatusCPF.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCPF.FormattingEnabled = true;
            this.txtStatusCPF.Location = new System.Drawing.Point(3, 26);
            this.txtStatusCPF.Name = "txtStatusCPF";
            this.txtStatusCPF.Size = new System.Drawing.Size(177, 29);
            this.txtStatusCPF.TabIndex = 20;
            // 
            // statusCPFBindingSource
            // 
            this.statusCPFBindingSource.DataMember = "StatusCPF";
            this.statusCPFBindingSource.DataSource = this.dS_Combobox;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Situação CPF:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 15);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel1.Controls.Add(this.txtrenda, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtcelular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttelefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtnasc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcpf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnomecli, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblemail, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 191);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtrenda
            // 
            this.txtrenda.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenda.Location = new System.Drawing.Point(3, 139);
            this.txtrenda.Mask = "$9.999,00";
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.Size = new System.Drawing.Size(155, 29);
            this.txtrenda.TabIndex = 25;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(538, 83);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(157, 29);
            this.txtcelular.TabIndex = 24;
            this.txtcelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 21);
            this.label20.TabIndex = 23;
            this.label20.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(373, 83);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(157, 29);
            this.txttelefone.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 21);
            this.label19.TabIndex = 21;
            this.label19.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renda:";
            // 
            // txtnasc
            // 
            this.txtnasc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtnasc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(538, 24);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(135, 29);
            this.txtnasc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(538, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Nasc.";
            // 
            // txtemail
            // 
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(3, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(364, 29);
            this.txtemail.TabIndex = 14;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(373, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(39, 21);
            this.lblcpf.TabIndex = 10;
            this.lblcpf.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcpf.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(373, 24);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(159, 32);
            this.txtcpf.TabIndex = 6;
            this.txtcpf.TextChanged += new System.EventHandler(this.txtcpf_TextChanged_1);
            // 
            // txtnomecli
            // 
            this.txtnomecli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnomecli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtnomecli.DataSource = this.clientesBindingSource;
            this.txtnomecli.DisplayMember = "Nome";
            this.txtnomecli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnomecli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecli.FormattingEnabled = true;
            this.txtnomecli.Location = new System.Drawing.Point(3, 24);
            this.txtnomecli.Name = "txtnomecli";
            this.txtnomecli.Size = new System.Drawing.Size(364, 29);
            this.txtnomecli.TabIndex = 2;
            this.txtnomecli.SelectedIndexChanged += new System.EventHandler(this.txtnomecli_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dS_Clientes;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(3, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(364, 21);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Nome do Cliente:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 59);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 21);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "Email:";
            // 
            // tabproduto
            // 
            this.tabproduto.Controls.Add(this.tableLayoutPanel5);
            this.tabproduto.Controls.Add(this.tableLayoutPanel4);
            this.tabproduto.Controls.Add(this.tableLayoutPanel3);
            this.tabproduto.Location = new System.Drawing.Point(4, 30);
            this.tabproduto.Name = "tabproduto";
            this.tabproduto.Padding = new System.Windows.Forms.Padding(20);
            this.tabproduto.Size = new System.Drawing.Size(984, 580);
            this.tabproduto.TabIndex = 3;
            this.tabproduto.Text = "Dados Produto";
            this.tabproduto.UseVisualStyleBackColor = true;
            // 
            // tabdocumentos
            // 
            this.tabdocumentos.Controls.Add(this.textBox8);
            this.tabdocumentos.Controls.Add(this.label10);
            this.tabdocumentos.Controls.Add(this.textBox7);
            this.tabdocumentos.Controls.Add(this.label9);
            this.tabdocumentos.Controls.Add(this.textBox6);
            this.tabdocumentos.Controls.Add(this.label8);
            this.tabdocumentos.Location = new System.Drawing.Point(4, 30);
            this.tabdocumentos.Name = "tabdocumentos";
            this.tabdocumentos.Padding = new System.Windows.Forms.Padding(20);
            this.tabdocumentos.Size = new System.Drawing.Size(984, 580);
            this.tabdocumentos.TabIndex = 1;
            this.tabdocumentos.Text = "Cartório";
            this.tabdocumentos.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Location = new System.Drawing.Point(20, 141);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(944, 29);
            this.textBox8.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(20, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Data de Envio:";
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox7.Location = new System.Drawing.Point(20, 91);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(944, 29);
            this.textBox7.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(20, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome:";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(20, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(944, 29);
            this.textBox6.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            // 
            // tabdoc
            // 
            this.tabdoc.Controls.Add(this.button1);
            this.tabdoc.Controls.Add(this.label13);
            this.tabdoc.Controls.Add(this.textBox10);
            this.tabdoc.Controls.Add(this.label12);
            this.tabdoc.Controls.Add(this.textBox9);
            this.tabdoc.Controls.Add(this.label11);
            this.tabdoc.Location = new System.Drawing.Point(4, 30);
            this.tabdoc.Name = "tabdoc";
            this.tabdoc.Padding = new System.Windows.Forms.Padding(20);
            this.tabdoc.Size = new System.Drawing.Size(984, 580);
            this.tabdoc.TabIndex = 2;
            this.tabdoc.Text = "Documentação";
            this.tabdoc.UseVisualStyleBackColor = true;
            this.tabdoc.Click += new System.EventHandler(this.tabdoc_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adicionar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(20, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nome_Documento";
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox10.Location = new System.Drawing.Point(20, 91);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(944, 29);
            this.textBox10.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(20, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Data inclusão";
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Location = new System.Drawing.Point(20, 41);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(944, 29);
            this.textBox9.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(20, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Descrição:";
            // 
            // statusCPFTableAdapter
            // 
            this.statusCPFTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusCiwebTableAdapter
            // 
            this.statusCiwebTableAdapter.ClearBeforeFill = true;
            // 
            // statusCadmutTableAdapter
            // 
            this.statusCadmutTableAdapter.ClearBeforeFill = true;
            // 
            // statusIRTableAdapter
            // 
            this.statusIRTableAdapter.ClearBeforeFill = true;
            // 
            // statusFGTSTableAdapter
            // 
            this.statusFGTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(944, 130);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.panel12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(938, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situações:";
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.comboBox6);
            this.panel11.Controls.Add(this.label28);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(189, 28);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(3);
            this.panel11.Size = new System.Drawing.Size(183, 72);
            this.panel11.TabIndex = 7;
            // 
            // comboBox6
            // 
            this.comboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox6.DataSource = this.statusCiwebBindingSource;
            this.comboBox6.DisplayMember = "Descricao";
            this.comboBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(3, 24);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(177, 29);
            this.comboBox6.TabIndex = 20;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Location = new System.Drawing.Point(3, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(89, 21);
            this.label28.TabIndex = 19;
            this.label28.Text = "Status Eng.:";
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.Controls.Add(this.comboBox7);
            this.panel12.Controls.Add(this.label29);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(6, 28);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(3);
            this.panel12.Size = new System.Drawing.Size(183, 72);
            this.panel12.TabIndex = 6;
            // 
            // comboBox7
            // 
            this.comboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox7.DataSource = this.statusCPFBindingSource;
            this.comboBox7.DisplayMember = "Descricao";
            this.comboBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(3, 26);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(177, 29);
            this.comboBox7.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(3, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(177, 23);
            this.label29.TabIndex = 19;
            this.label29.Text = "Status Análise:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 150);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(944, 130);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(938, 106);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caixa:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(189, 28);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(183, 72);
            this.panel3.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DataSource = this.statusCiwebBindingSource;
            this.comboBox3.DisplayMember = "Descricao";
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(177, 29);
            this.comboBox3.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "Programa:";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.comboBox4);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(6, 28);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(183, 72);
            this.panel9.TabIndex = 6;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DataSource = this.statusCPFBindingSource;
            this.comboBox4.DisplayMember = "Descricao";
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(177, 29);
            this.comboBox4.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 23);
            this.label16.TabIndex = 19;
            this.label16.Text = "Agência:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 280);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(944, 213);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(938, 159);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produto:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtcorretora, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 125);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Empreendimento:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataSource = this.statusCPFBindingSource;
            this.comboBox2.DisplayMember = "Descricao";
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(685, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 29);
            this.comboBox2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(685, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vendedor:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.statusCPFBindingSource;
            this.comboBox1.DisplayMember = "Descricao";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 29);
            this.comboBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(344, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Corretor:";
            // 
            // txtcorretora
            // 
            this.txtcorretora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcorretora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcorretora.DataSource = this.statusCPFBindingSource;
            this.txtcorretora.DisplayMember = "Descricao";
            this.txtcorretora.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcorretora.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcorretora.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorretora.FormattingEnabled = true;
            this.txtcorretora.Location = new System.Drawing.Point(3, 24);
            this.txtcorretora.Name = "txtcorretora";
            this.txtcorretora.Size = new System.Drawing.Size(290, 29);
            this.txtcorretora.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Corretora:";
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.comboBox5);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(372, 28);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(183, 72);
            this.panel10.TabIndex = 8;
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox5.DataSource = this.statusCiwebBindingSource;
            this.comboBox5.DisplayMember = "Descricao";
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(3, 24);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(177, 29);
            this.comboBox5.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Valor do produto:";
            // 
            // comboBox8
            // 
            this.comboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox8.DataSource = this.statusCPFBindingSource;
            this.comboBox8.DisplayMember = "Descricao";
            this.comboBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(3, 80);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(318, 29);
            this.comboBox8.TabIndex = 27;
            // 
            // Form_Cadastro_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 723);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Cadastro_Documentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Cadastro_Documentos";
            this.Load += new System.EventHandler(this.Form_Cadastro_Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabcliente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusFGTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Combobox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIRBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCadmutBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCiwebBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusCPFBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.tabproduto.ResumeLayout(false);
            this.tabdocumentos.ResumeLayout(false);
            this.tabdocumentos.PerformLayout();
            this.tabdoc.ResumeLayout(false);
            this.tabdoc.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnsalvardoc;
        private DAL.DS_Documentos dS_Documentos;
        private System.Windows.Forms.BindingSource dSDocumentosBindingSource;
        private System.Windows.Forms.BindingSource processosBindingSource;
        private DAL.DS_Clientes dS_Clientes;
        private System.Windows.Forms.BindingSource dSClientesBindingSource;
        private DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private DAL.DS_Funcionario dS_Funcionario;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel paneltop;
        public System.Windows.Forms.Button btncloseconf;
        private System.Windows.Forms.Panel panel1;
        private DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter processosTableAdapter;
        public System.Windows.Forms.Button btncancelardoc;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabcliente;
        private System.Windows.Forms.TabPage tabdocumentos;
        private System.Windows.Forms.TabPage tabdoc;
        private System.Windows.Forms.TabPage tabproduto;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblstatus;
        private DAL.DS_Combobox dS_Combobox;
        private System.Windows.Forms.BindingSource statusCPFBindingSource;
        private DAL.DS_ComboboxTableAdapters.StatusCPFTableAdapter statusCPFTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox txtnomecli;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DAL.DS_ClientesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox txtfgts;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox txtir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox txtcadmut;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox txtciweb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox txtStatusCPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtrenda;
        private System.Windows.Forms.BindingSource statusCiwebBindingSource;
        private DAL.DS_ComboboxTableAdapters.StatusCiwebTableAdapter statusCiwebTableAdapter;
        private System.Windows.Forms.BindingSource statusCadmutBindingSource;
        private DAL.DS_ComboboxTableAdapters.StatusCadmutTableAdapter statusCadmutTableAdapter;
        private System.Windows.Forms.BindingSource statusIRBindingSource;
        private DAL.DS_ComboboxTableAdapters.StatusIRTableAdapter statusIRTableAdapter;
        private System.Windows.Forms.BindingSource statusFGTSBindingSource;
        private DAL.DS_ComboboxTableAdapters.StatusFGTSTableAdapter statusFGTSTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtcorretora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label29;
    }
}