
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Cadastro_Processos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Processos));
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
            this.ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblstatus = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.btncloseconf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelardoc = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.processosTableAdapter = new LMFinanciamentos.DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtfgts = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtir = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtcadmut = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtciweb = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.txtStatusCPF = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcontacliente = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
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
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.tabvendedor = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcontavendedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textagenciavendedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.textnomevendedor = new System.Windows.Forms.ComboBox();
            this.textcelularvendedor = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texttelefonevendedor = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textemailvendedor = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textcnpjcpf = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tabimovel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_empreendimentos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_corretor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcorretora = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.valorfinanciado = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.valorimovel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_programa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox_agencia = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new LMFinanciamentos.DAL.DS_ClientesTableAdapters.ClientesTableAdapter();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
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
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel32.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tabvendedor.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tabimovel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
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
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(56, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(333, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Cadastro de Processo";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.ProgressBar);
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
            // ProgressBar
            // 
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(558, 4);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.ShadowDecoration.Parent = this.ProgressBar;
            this.ProgressBar.ShowPercentage = true;
            this.ProgressBar.Size = new System.Drawing.Size(49, 49);
            this.ProgressBar.TabIndex = 6;
            this.ProgressBar.Text = "ProgressBar";
            this.ProgressBar.Visible = false;
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblstatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblstatus.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Location = new System.Drawing.Point(0, 521);
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
            this.btncancelardoc.Click += new System.EventHandler(this.btncancelardoc_Click);
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
            this.tabControl.Controls.Add(this.tabvendedor);
            this.tabControl.Controls.Add(this.tabimovel);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 464);
            this.tabControl.TabIndex = 14;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.button4);
            this.tabcliente.Controls.Add(this.groupBox1);
            this.tabcliente.Controls.Add(this.panel2);
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Location = new System.Drawing.Point(4, 32);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(984, 428);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(526, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(944, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situações:";
            this.groupBox1.Visible = false;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.txtfgts);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(738, 26);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(183, 116);
            this.panel8.TabIndex = 10;
            // 
            // txtfgts
            // 
            this.txtfgts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfgts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfgts.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtfgts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfgts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtfgts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfgts.FormattingEnabled = true;
            this.txtfgts.Items.AddRange(new object[] {
            "Não Consultado",
            "Já subsidiado",
            "Não subsidiado"});
            this.txtfgts.Location = new System.Drawing.Point(3, 26);
            this.txtfgts.Name = "txtfgts";
            this.txtfgts.Size = new System.Drawing.Size(177, 24);
            this.txtfgts.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Location = new System.Drawing.Point(3, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 23);
            this.label24.TabIndex = 19;
            this.label24.Text = "FGTS:";
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.txtir);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(555, 26);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(183, 116);
            this.panel7.TabIndex = 9;
            // 
            // txtir
            // 
            this.txtir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtir.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.FormattingEnabled = true;
            this.txtir.Items.AddRange(new object[] {
            "Não consultado",
            "Isento",
            "Declarado"});
            this.txtir.Location = new System.Drawing.Point(3, 26);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(177, 24);
            this.txtir.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Location = new System.Drawing.Point(3, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 23);
            this.label23.TabIndex = 19;
            this.label23.Text = "Declaração IR:";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.txtcadmut);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(372, 26);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(183, 116);
            this.panel6.TabIndex = 8;
            // 
            // txtcadmut
            // 
            this.txtcadmut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcadmut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcadmut.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcadmut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcadmut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcadmut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadmut.FormattingEnabled = true;
            this.txtcadmut.Items.AddRange(new object[] {
            "Não consultado",
            "Ativo",
            "Inativo",
            "Nada consta"});
            this.txtcadmut.Location = new System.Drawing.Point(3, 26);
            this.txtcadmut.Name = "txtcadmut";
            this.txtcadmut.Size = new System.Drawing.Size(177, 24);
            this.txtcadmut.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(3, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 23);
            this.label22.TabIndex = 19;
            this.label22.Text = "Situação Cadmut:";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.txtciweb);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(189, 26);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(183, 116);
            this.panel5.TabIndex = 7;
            // 
            // txtciweb
            // 
            this.txtciweb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtciweb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtciweb.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtciweb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtciweb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtciweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciweb.FormattingEnabled = true;
            this.txtciweb.Items.AddRange(new object[] {
            "Não Consultado",
            "Ativo",
            "Inativo ",
            "Nada consta"});
            this.txtciweb.Location = new System.Drawing.Point(3, 26);
            this.txtciweb.Name = "txtciweb";
            this.txtciweb.Size = new System.Drawing.Size(177, 24);
            this.txtciweb.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Location = new System.Drawing.Point(3, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 23);
            this.label21.TabIndex = 19;
            this.label21.Text = "Situação Ciweb:";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.panel32);
            this.panel4.Controls.Add(this.txtStatusCPF);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(6, 26);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(183, 116);
            this.panel4.TabIndex = 6;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.label47);
            this.panel32.Controls.Add(this.label48);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel32.Location = new System.Drawing.Point(3, 50);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(177, 63);
            this.panel32.TabIndex = 23;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Dock = System.Windows.Forms.DockStyle.Top;
            this.label47.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(0, 27);
            this.label47.Name = "label47";
            this.label47.Padding = new System.Windows.Forms.Padding(2);
            this.label47.Size = new System.Drawing.Size(122, 27);
            this.label47.TabIndex = 1;
            this.label47.Text = "__/ ___/ ____";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Top;
            this.label48.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(0, 0);
            this.label48.Name = "label48";
            this.label48.Padding = new System.Windows.Forms.Padding(2);
            this.label48.Size = new System.Drawing.Size(49, 27);
            this.label48.TabIndex = 0;
            this.label48.Text = "Data:";
            // 
            // txtStatusCPF
            // 
            this.txtStatusCPF.AutoCompleteCustomSource.AddRange(new string[] {
            "Não Consultado",
            "Com Restrição",
            "Divergente RF",
            "Nada Consta",
            "Bloqueado em outro CCA"});
            this.txtStatusCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStatusCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatusCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtStatusCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCPF.FormattingEnabled = true;
            this.txtStatusCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStatusCPF.Items.AddRange(new object[] {
            "Não Consultado",
            "Com Restrição",
            "Divergente RF",
            "Nada Consta",
            "Bloqueado em outro CCA"});
            this.txtStatusCPF.Location = new System.Drawing.Point(3, 26);
            this.txtStatusCPF.Name = "txtStatusCPF";
            this.txtStatusCPF.Size = new System.Drawing.Size(177, 24);
            this.txtStatusCPF.TabIndex = 20;
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
            this.panel2.Size = new System.Drawing.Size(944, 15);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtcontacliente, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label46, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtagencia, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label45, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtrg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtrenda, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtcelular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttelefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtnasc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcpf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblemail, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 191);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtcontacliente
            // 
            this.txtcontacliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcontacliente.Enabled = false;
            this.txtcontacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacliente.Location = new System.Drawing.Point(589, 140);
            this.txtcontacliente.Name = "txtcontacliente";
            this.txtcontacliente.Size = new System.Drawing.Size(159, 24);
            this.txtcontacliente.TabIndex = 30;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(589, 114);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 23);
            this.label46.TabIndex = 29;
            this.label46.Text = "Conta:";
            // 
            // txtagencia
            // 
            this.txtagencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtagencia.Enabled = false;
            this.txtagencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagencia.Location = new System.Drawing.Point(424, 140);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(159, 24);
            this.txtagencia.TabIndex = 28;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(424, 114);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(71, 23);
            this.label45.TabIndex = 27;
            this.label45.Text = "Agência:";
            // 
            // txtrg
            // 
            this.txtrg.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtrg.Enabled = false;
            this.txtrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(589, 26);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(159, 24);
            this.txtrg.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "RG:";
            // 
            // panel19
            // 
            this.panel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Controls.Add(this.ComboBoxClient);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 26);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(415, 34);
            this.panel19.TabIndex = 24;
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxClient.DropDownHeight = 104;
            this.ComboBoxClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxClient.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.IntegralHeight = false;
            this.ComboBoxClient.Location = new System.Drawing.Point(0, 0);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(413, 36);
            this.ComboBoxClient.TabIndex = 9;
            this.ComboBoxClient.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxClient_SelectionChangeCommitted);
            this.ComboBoxClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxClient_KeyDown);
            this.ComboBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxClient_KeyPress);
            this.ComboBoxClient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxClient_KeyUp);
            // 
            // txtrenda
            // 
            this.txtrenda.Enabled = false;
            this.txtrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenda.Location = new System.Drawing.Point(3, 140);
            this.txtrenda.Mask = "$9.999,00";
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.Size = new System.Drawing.Size(155, 22);
            this.txtrenda.TabIndex = 7;
            // 
            // txtcelular
            // 
            this.txtcelular.Enabled = false;
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(589, 89);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(157, 22);
            this.txtcelular.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(589, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 23);
            this.label20.TabIndex = 23;
            this.label20.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(424, 89);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(157, 22);
            this.txttelefone.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(424, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 23);
            this.label19.TabIndex = 21;
            this.label19.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Renda:";
            // 
            // txtnasc
            // 
            this.txtnasc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtnasc.Enabled = false;
            this.txtnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(754, 26);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(135, 22);
            this.txtnasc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(754, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Nasc.";
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(3, 89);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(364, 22);
            this.txtemail.TabIndex = 5;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(424, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(39, 23);
            this.lblcpf.TabIndex = 10;
            this.lblcpf.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcpf.Enabled = false;
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(424, 26);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(159, 24);
            this.txtcpf.TabIndex = 3;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(3, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(415, 23);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Nome do Cliente:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 63);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 23);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "Email:";
            // 
            // tabvendedor
            // 
            this.tabvendedor.Controls.Add(this.panel20);
            this.tabvendedor.Location = new System.Drawing.Point(4, 32);
            this.tabvendedor.Name = "tabvendedor";
            this.tabvendedor.Padding = new System.Windows.Forms.Padding(15);
            this.tabvendedor.Size = new System.Drawing.Size(984, 428);
            this.tabvendedor.TabIndex = 4;
            this.tabvendedor.Text = "Dados do Vendedor";
            this.tabvendedor.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.tableLayoutPanel8);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(15, 15);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(954, 216);
            this.panel20.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.txtcontavendedor, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.textagenciavendedor, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel21, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.textcelularvendedor, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.texttelefonevendedor, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.textemailvendedor, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.textcnpjcpf, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 7;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(954, 191);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // txtcontavendedor
            // 
            this.txtcontavendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcontavendedor.Enabled = false;
            this.txtcontavendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontavendedor.Location = new System.Drawing.Point(754, 26);
            this.txtcontavendedor.Name = "txtcontavendedor";
            this.txtcontavendedor.Size = new System.Drawing.Size(159, 24);
            this.txtcontavendedor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Conta:";
            // 
            // textagenciavendedor
            // 
            this.textagenciavendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.textagenciavendedor.Enabled = false;
            this.textagenciavendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textagenciavendedor.Location = new System.Drawing.Point(589, 26);
            this.textagenciavendedor.Name = "textagenciavendedor";
            this.textagenciavendedor.Size = new System.Drawing.Size(159, 24);
            this.textagenciavendedor.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Agência:";
            // 
            // panel21
            // 
            this.panel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.textnomevendedor);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(3, 26);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(415, 34);
            this.panel21.TabIndex = 24;
            // 
            // textnomevendedor
            // 
            this.textnomevendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textnomevendedor.DropDownHeight = 104;
            this.textnomevendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textnomevendedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomevendedor.FormattingEnabled = true;
            this.textnomevendedor.IntegralHeight = false;
            this.textnomevendedor.Location = new System.Drawing.Point(0, 0);
            this.textnomevendedor.Name = "textnomevendedor";
            this.textnomevendedor.Size = new System.Drawing.Size(413, 36);
            this.textnomevendedor.TabIndex = 9;
            this.textnomevendedor.SelectionChangeCommitted += new System.EventHandler(this.textnomevendedor_SelectionChangeCommitted);
            this.textnomevendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textnomevendedor_KeyDown);
            this.textnomevendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnomevendedor_KeyPress);
            this.textnomevendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textnomevendedor_KeyUp);
            // 
            // textcelularvendedor
            // 
            this.textcelularvendedor.Enabled = false;
            this.textcelularvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcelularvendedor.Location = new System.Drawing.Point(589, 89);
            this.textcelularvendedor.Mask = "(99) 00000-0000";
            this.textcelularvendedor.Name = "textcelularvendedor";
            this.textcelularvendedor.Size = new System.Drawing.Size(157, 22);
            this.textcelularvendedor.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Celular:";
            // 
            // texttelefonevendedor
            // 
            this.texttelefonevendedor.Enabled = false;
            this.texttelefonevendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttelefonevendedor.Location = new System.Drawing.Point(424, 89);
            this.texttelefonevendedor.Mask = "(99) 0000-0000";
            this.texttelefonevendedor.Name = "texttelefonevendedor";
            this.texttelefonevendedor.Size = new System.Drawing.Size(157, 22);
            this.texttelefonevendedor.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Telefone:";
            // 
            // textemailvendedor
            // 
            this.textemailvendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textemailvendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textemailvendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.textemailvendedor.Enabled = false;
            this.textemailvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemailvendedor.Location = new System.Drawing.Point(3, 89);
            this.textemailvendedor.Name = "textemailvendedor";
            this.textemailvendedor.Size = new System.Drawing.Size(364, 22);
            this.textemailvendedor.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(424, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 23);
            this.label26.TabIndex = 10;
            this.label26.Text = "CPF/CNPJ:";
            // 
            // textcnpjcpf
            // 
            this.textcnpjcpf.Dock = System.Windows.Forms.DockStyle.Left;
            this.textcnpjcpf.Enabled = false;
            this.textcnpjcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcnpjcpf.Location = new System.Drawing.Point(424, 26);
            this.textcnpjcpf.Name = "textcnpjcpf";
            this.textcnpjcpf.Size = new System.Drawing.Size(159, 24);
            this.textcnpjcpf.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(415, 23);
            this.label27.TabIndex = 1;
            this.label27.Text = "Nome do Vendor:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 23);
            this.label30.TabIndex = 11;
            this.label30.Text = "Email:";
            // 
            // tabimovel
            // 
            this.tabimovel.Controls.Add(this.tableLayoutPanel5);
            this.tabimovel.Controls.Add(this.tableLayoutPanel4);
            this.tabimovel.Location = new System.Drawing.Point(4, 32);
            this.tabimovel.Name = "tabimovel";
            this.tabimovel.Padding = new System.Windows.Forms.Padding(20);
            this.tabimovel.Size = new System.Drawing.Size(984, 428);
            this.tabimovel.TabIndex = 3;
            this.tabimovel.Text = "Dados do Imóvel";
            this.tabimovel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 150);
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
            this.groupBox4.Text = "Imóvel:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox_empreendimentos, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_corretor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtcorretora, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 127);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // comboBox_empreendimentos
            // 
            this.comboBox_empreendimentos.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_empreendimentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_empreendimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_empreendimentos.DropDownWidth = 118;
            this.comboBox_empreendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_empreendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_empreendimentos.FormattingEnabled = true;
            this.comboBox_empreendimentos.Location = new System.Drawing.Point(595, 26);
            this.comboBox_empreendimentos.MaxDropDownItems = 10;
            this.comboBox_empreendimentos.Name = "comboBox_empreendimentos";
            this.comboBox_empreendimentos.Size = new System.Drawing.Size(318, 24);
            this.comboBox_empreendimentos.TabIndex = 27;
            this.comboBox_empreendimentos.SelectedIndexChanged += new System.EventHandler(this.comboBox_empreendimentos_SelectedIndexChanged);
            this.comboBox_empreendimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_empreendimentos_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(595, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Empreendimento:";
            // 
            // comboBox_corretor
            // 
            this.comboBox_corretor.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_corretor.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_corretor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_corretor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_corretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_corretor.FormattingEnabled = true;
            this.comboBox_corretor.Location = new System.Drawing.Point(299, 26);
            this.comboBox_corretor.MaxDropDownItems = 10;
            this.comboBox_corretor.Name = "comboBox_corretor";
            this.comboBox_corretor.Size = new System.Drawing.Size(268, 24);
            this.comboBox_corretor.TabIndex = 23;
            this.comboBox_corretor.SelectedIndexChanged += new System.EventHandler(this.comboBox_corretor_SelectedIndexChanged);
            this.comboBox_corretor.SelectionChangeCommitted += new System.EventHandler(this.comboBox_corretor_SelectionChangeCommitted);
            this.comboBox_corretor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_corretor_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(299, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Corretor:";
            // 
            // txtcorretora
            // 
            this.txtcorretora.BackColor = System.Drawing.SystemColors.Control;
            this.txtcorretora.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcorretora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcorretora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcorretora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorretora.FormattingEnabled = true;
            this.txtcorretora.Location = new System.Drawing.Point(3, 26);
            this.txtcorretora.MaxDropDownItems = 10;
            this.txtcorretora.Name = "txtcorretora";
            this.txtcorretora.Size = new System.Drawing.Size(290, 24);
            this.txtcorretora.TabIndex = 21;
            this.txtcorretora.SelectedIndexChanged += new System.EventHandler(this.txtcorretora_SelectedIndexChanged);
            this.txtcorretora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcorretora_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Corretora:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(944, 130);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel26);
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
            // panel26
            // 
            this.panel26.AutoSize = true;
            this.panel26.Controls.Add(this.valorfinanciado);
            this.panel26.Controls.Add(this.label32);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel26.Location = new System.Drawing.Point(555, 26);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(3);
            this.panel26.Size = new System.Drawing.Size(183, 74);
            this.panel26.TabIndex = 9;
            // 
            // valorfinanciado
            // 
            this.valorfinanciado.Dock = System.Windows.Forms.DockStyle.Left;
            this.valorfinanciado.Location = new System.Drawing.Point(3, 26);
            this.valorfinanciado.Name = "valorfinanciado";
            this.valorfinanciado.Size = new System.Drawing.Size(177, 27);
            this.valorfinanciado.TabIndex = 27;
            this.valorfinanciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorfinanciado_KeyPress);
            this.valorfinanciado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valorfinanciado_KeyUp);
            this.valorfinanciado.Leave += new System.EventHandler(this.valorfinanciado_Leave);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Location = new System.Drawing.Point(3, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(129, 23);
            this.label32.TabIndex = 19;
            this.label32.Text = "Valor Financiado:";
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.valorimovel);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(372, 26);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(183, 74);
            this.panel10.TabIndex = 8;
            // 
            // valorimovel
            // 
            this.valorimovel.Dock = System.Windows.Forms.DockStyle.Left;
            this.valorimovel.Location = new System.Drawing.Point(3, 26);
            this.valorimovel.Name = "valorimovel";
            this.valorimovel.Size = new System.Drawing.Size(177, 27);
            this.valorimovel.TabIndex = 27;
            this.valorimovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorproduto_KeyPress);
            this.valorimovel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valorproduto_KeyUp);
            this.valorimovel.Leave += new System.EventHandler(this.valorproduto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Valor do Imóvel:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.comboBox_programa);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(189, 26);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(183, 74);
            this.panel3.TabIndex = 7;
            // 
            // comboBox_programa
            // 
            this.comboBox_programa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_programa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_programa.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_programa.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_programa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_programa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_programa.FormattingEnabled = true;
            this.comboBox_programa.Location = new System.Drawing.Point(3, 26);
            this.comboBox_programa.MaxDropDownItems = 10;
            this.comboBox_programa.Name = "comboBox_programa";
            this.comboBox_programa.Size = new System.Drawing.Size(177, 24);
            this.comboBox_programa.TabIndex = 20;
            this.comboBox_programa.SelectionChangeCommitted += new System.EventHandler(this.comboBox_programa_SelectionChangeCommitted);
            this.comboBox_programa.DataSourceChanged += new System.EventHandler(this.comboBox_programa_DataSourceChanged);
            this.comboBox_programa.DisplayMemberChanged += new System.EventHandler(this.comboBox_programa_DisplayMemberChanged);
            this.comboBox_programa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_programa_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 23);
            this.label15.TabIndex = 19;
            this.label15.Text = "Programa:";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.comboBox_agencia);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(6, 26);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(183, 74);
            this.panel9.TabIndex = 6;
            // 
            // comboBox_agencia
            // 
            this.comboBox_agencia.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_agencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_agencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_agencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_agencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_agencia.FormattingEnabled = true;
            this.comboBox_agencia.Location = new System.Drawing.Point(3, 26);
            this.comboBox_agencia.MaxDropDownItems = 10;
            this.comboBox_agencia.Name = "comboBox_agencia";
            this.comboBox_agencia.Size = new System.Drawing.Size(177, 24);
            this.comboBox_agencia.TabIndex = 20;
            this.comboBox_agencia.SelectedIndexChanged += new System.EventHandler(this.comboBox_agencia_SelectedIndexChanged);
            this.comboBox_agencia.SelectionChangeCommitted += new System.EventHandler(this.comboBox_agencia_SelectionChangeCommitted);
            this.comboBox_agencia.Click += new System.EventHandler(this.comboBox_agencia_Click);
            this.comboBox_agencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_agencia_MouseClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 37);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Luis Eduardo",
            "Karine",
            "Vinicius"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dS_Clientes;
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
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dS_Clientes;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.dSClientesBindingSource;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form_Cadastro_Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Cadastro_Processos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Processos";
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.tabvendedor.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.tabimovel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
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
        private System.Windows.Forms.TabPage tabimovel;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        //private System.Windows.Forms.BindingSource statusCiwebBindingSource;
        //private System.Windows.Forms.BindingSource statusCadmutBindingSource;
        //private System.Windows.Forms.BindingSource statusFGTSBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox_empreendimentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_corretor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtcorretora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_programa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox_agencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.ComboBox ComboBoxClient;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabvendedor;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textagenciavendedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.ComboBox textnomevendedor;
        private System.Windows.Forms.MaskedTextBox textcelularvendedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox texttelefonevendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textemailvendedor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textcnpjcpf;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtcontavendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontacliente;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox valorimovel;
        private System.Windows.Forms.TextBox valorfinanciado;
        //private System.Windows.Forms.BindingSource corretoraBindingSource;
        //private System.Windows.Forms.BindingSource corretoresBindingSource;
        //private System.Windows.Forms.BindingSource vendedorBindingSource;
        //private System.Windows.Forms.BindingSource empreendimentosBindingSource;
        //private System.Windows.Forms.BindingSource statusCartorioBindingSource;
        //private System.Windows.Forms.BindingSource cartorioBindingSource;
    }
}