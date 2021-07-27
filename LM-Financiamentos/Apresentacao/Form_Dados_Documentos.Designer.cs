
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Documentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Documentos));
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
            this.lblnumeroprocesso = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelfunc = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelstatusfgts = new System.Windows.Forms.Panel();
            this.lbldatafgts = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.txtfgts = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelstatusir = new System.Windows.Forms.Panel();
            this.lbldatair = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtir = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelstatuscadmut = new System.Windows.Forms.Panel();
            this.lbldatacadmut = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtcadmut = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelstatusciweb = new System.Windows.Forms.Panel();
            this.lbldataciweb = new System.Windows.Forms.Label();
            this.lbldataciwe11 = new System.Windows.Forms.Label();
            this.txtciweb = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelstatuscpf = new System.Windows.Forms.Panel();
            this.lbldatacpf = new System.Windows.Forms.Label();
            this.lblstatuscpf = new System.Windows.Forms.Label();
            this.txtStatusCPF = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxClient = new System.Windows.Forms.TextBox();
            this.txtcontacliente = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.textcelularvendedor = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.texttelefonevendedor = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textemailvendedor = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textcnpjcpf = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textnomevendedor = new System.Windows.Forms.TextBox();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.valorproduto = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_programa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.comboBox_agencia = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.lblpa = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.lblsictd = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.lblsiopi = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.lblsaquefgts = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox_saque = new System.Windows.Forms.ComboBox();
            this.lblsaque = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.lblstatuseng = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.comboBox_statuseng = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.paneldataanalise = new System.Windows.Forms.Panel();
            this.lblstatusanalise = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBox_analise = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabdocumentos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.comboBox_statuscartorio = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.comboBox_nomecartorio = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabdoc = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panelfuncresp = new System.Windows.Forms.Panel();
            this.lblfunc = new System.Windows.Forms.Label();
            this.lblfuncresponsavel = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblstatuscartorio = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lbldatastatus = new System.Windows.Forms.Label();
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
            this.panelstatusfgts.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelstatusir.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelstatuscadmut.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelstatusciweb.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelstatuscpf.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabvendedor.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
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
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel12.SuspendLayout();
            this.paneldataanalise.SuspendLayout();
            this.tabdocumentos.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tabdoc.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.panelfuncresp.SuspendLayout();
            this.panel19.SuspendLayout();
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
            this.lbl_topo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_topo.Location = new System.Drawing.Point(56, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(206, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Processo Nº:";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbldatastatus);
            this.paneltop.Controls.Add(this.lblnumeroprocesso);
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
            // lblnumeroprocesso
            // 
            this.lblnumeroprocesso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblnumeroprocesso.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnumeroprocesso.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroprocesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lblnumeroprocesso.Location = new System.Drawing.Point(262, 4);
            this.lblnumeroprocesso.Margin = new System.Windows.Forms.Padding(3);
            this.lblnumeroprocesso.Name = "lblnumeroprocesso";
            this.lblnumeroprocesso.Size = new System.Drawing.Size(206, 49);
            this.lblnumeroprocesso.TabIndex = 8;
            this.lblnumeroprocesso.Text = "0000";
            this.lblnumeroprocesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.Location = new System.Drawing.Point(0, 515);
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
            this.tabControl.Controls.Add(this.tabdocumentos);
            this.tabControl.Controls.Add(this.tabdoc);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(992, 458);
            this.tabControl.TabIndex = 14;
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.groupBox1);
            this.tabcliente.Controls.Add(this.panel2);
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Location = new System.Drawing.Point(4, 32);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(984, 422);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelfunc);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(944, 142);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situações:";
            // 
            // panelfunc
            // 
            this.panelfunc.Location = new System.Drawing.Point(308, 148);
            this.panelfunc.Name = "panelfunc";
            this.panelfunc.Size = new System.Drawing.Size(200, 100);
            this.panelfunc.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.panelstatusfgts);
            this.panel8.Controls.Add(this.txtfgts);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(738, 26);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(183, 110);
            this.panel8.TabIndex = 10;
            // 
            // panelstatusfgts
            // 
            this.panelstatusfgts.Controls.Add(this.lbldatafgts);
            this.panelstatusfgts.Controls.Add(this.label56);
            this.panelstatusfgts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelstatusfgts.Location = new System.Drawing.Point(3, 50);
            this.panelstatusfgts.Name = "panelstatusfgts";
            this.panelstatusfgts.Size = new System.Drawing.Size(177, 57);
            this.panelstatusfgts.TabIndex = 24;
            // 
            // lbldatafgts
            // 
            this.lbldatafgts.AutoSize = true;
            this.lbldatafgts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldatafgts.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatafgts.Location = new System.Drawing.Point(0, 27);
            this.lbldatafgts.Name = "lbldatafgts";
            this.lbldatafgts.Padding = new System.Windows.Forms.Padding(4);
            this.lbldatafgts.Size = new System.Drawing.Size(126, 31);
            this.lbldatafgts.TabIndex = 1;
            this.lbldatafgts.Text = "__/ ___/ ____";
            this.lbldatafgts.Visible = false;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Top;
            this.label56.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(0, 0);
            this.label56.Name = "label56";
            this.label56.Padding = new System.Windows.Forms.Padding(2);
            this.label56.Size = new System.Drawing.Size(73, 27);
            this.label56.TabIndex = 0;
            this.label56.Text = "Alterado:";
            this.label56.Visible = false;
            // 
            // txtfgts
            // 
            this.txtfgts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfgts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfgts.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.txtfgts.SelectionChangeCommitted += new System.EventHandler(this.txtfgts_SelectionChangeCommitted);
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
            this.panel7.Controls.Add(this.panelstatusir);
            this.panel7.Controls.Add(this.txtir);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(555, 26);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(183, 110);
            this.panel7.TabIndex = 9;
            // 
            // panelstatusir
            // 
            this.panelstatusir.Controls.Add(this.lbldatair);
            this.panelstatusir.Controls.Add(this.label54);
            this.panelstatusir.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelstatusir.Location = new System.Drawing.Point(3, 50);
            this.panelstatusir.Name = "panelstatusir";
            this.panelstatusir.Size = new System.Drawing.Size(177, 57);
            this.panelstatusir.TabIndex = 24;
            this.panelstatusir.Paint += new System.Windows.Forms.PaintEventHandler(this.panel33_Paint);
            // 
            // lbldatair
            // 
            this.lbldatair.AutoSize = true;
            this.lbldatair.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldatair.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatair.Location = new System.Drawing.Point(0, 27);
            this.lbldatair.Name = "lbldatair";
            this.lbldatair.Padding = new System.Windows.Forms.Padding(4);
            this.lbldatair.Size = new System.Drawing.Size(126, 31);
            this.lbldatair.TabIndex = 1;
            this.lbldatair.Text = "__/ ___/ ____";
            this.lbldatair.Visible = false;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Top;
            this.label54.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(0, 0);
            this.label54.Name = "label54";
            this.label54.Padding = new System.Windows.Forms.Padding(2);
            this.label54.Size = new System.Drawing.Size(73, 27);
            this.label54.TabIndex = 0;
            this.label54.Text = "Alterado:";
            this.label54.Visible = false;
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // txtir
            // 
            this.txtir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.FormattingEnabled = true;
            this.txtir.Items.AddRange(new object[] {
            "Não Consultado",
            "Isento",
            "Declarado"});
            this.txtir.Location = new System.Drawing.Point(3, 26);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(177, 24);
            this.txtir.TabIndex = 20;
            this.txtir.SelectionChangeCommitted += new System.EventHandler(this.txtir_SelectionChangeCommitted);
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
            this.panel6.Controls.Add(this.panelstatuscadmut);
            this.panel6.Controls.Add(this.txtcadmut);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(372, 26);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(183, 110);
            this.panel6.TabIndex = 8;
            // 
            // panelstatuscadmut
            // 
            this.panelstatuscadmut.Controls.Add(this.lbldatacadmut);
            this.panelstatuscadmut.Controls.Add(this.label52);
            this.panelstatuscadmut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelstatuscadmut.Location = new System.Drawing.Point(3, 50);
            this.panelstatuscadmut.Name = "panelstatuscadmut";
            this.panelstatuscadmut.Size = new System.Drawing.Size(177, 57);
            this.panelstatuscadmut.TabIndex = 24;
            // 
            // lbldatacadmut
            // 
            this.lbldatacadmut.AutoSize = true;
            this.lbldatacadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldatacadmut.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacadmut.Location = new System.Drawing.Point(0, 27);
            this.lbldatacadmut.Name = "lbldatacadmut";
            this.lbldatacadmut.Padding = new System.Windows.Forms.Padding(4);
            this.lbldatacadmut.Size = new System.Drawing.Size(126, 31);
            this.lbldatacadmut.TabIndex = 1;
            this.lbldatacadmut.Text = "__/ ___/ ____";
            this.lbldatacadmut.Visible = false;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Dock = System.Windows.Forms.DockStyle.Top;
            this.label52.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(0, 0);
            this.label52.Name = "label52";
            this.label52.Padding = new System.Windows.Forms.Padding(2);
            this.label52.Size = new System.Drawing.Size(73, 27);
            this.label52.TabIndex = 0;
            this.label52.Text = "Alterado:";
            this.label52.Visible = false;
            // 
            // txtcadmut
            // 
            this.txtcadmut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcadmut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtcadmut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcadmut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcadmut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadmut.FormattingEnabled = true;
            this.txtcadmut.Items.AddRange(new object[] {
            "Não Consultado",
            "Ativo",
            "Inativo",
            "Nada Consta"});
            this.txtcadmut.Location = new System.Drawing.Point(3, 26);
            this.txtcadmut.Name = "txtcadmut";
            this.txtcadmut.Size = new System.Drawing.Size(177, 24);
            this.txtcadmut.TabIndex = 20;
            this.txtcadmut.SelectionChangeCommitted += new System.EventHandler(this.txtcadmut_SelectionChangeCommitted);
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
            this.panel5.Controls.Add(this.panelstatusciweb);
            this.panel5.Controls.Add(this.txtciweb);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(189, 26);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(183, 110);
            this.panel5.TabIndex = 7;
            // 
            // panelstatusciweb
            // 
            this.panelstatusciweb.Controls.Add(this.lbldataciweb);
            this.panelstatusciweb.Controls.Add(this.lbldataciwe11);
            this.panelstatusciweb.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelstatusciweb.Location = new System.Drawing.Point(3, 50);
            this.panelstatusciweb.Name = "panelstatusciweb";
            this.panelstatusciweb.Size = new System.Drawing.Size(177, 57);
            this.panelstatusciweb.TabIndex = 24;
            // 
            // lbldataciweb
            // 
            this.lbldataciweb.AutoSize = true;
            this.lbldataciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldataciweb.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataciweb.Location = new System.Drawing.Point(0, 27);
            this.lbldataciweb.Name = "lbldataciweb";
            this.lbldataciweb.Padding = new System.Windows.Forms.Padding(4);
            this.lbldataciweb.Size = new System.Drawing.Size(126, 31);
            this.lbldataciweb.TabIndex = 1;
            this.lbldataciweb.Text = "__/ ___/ ____";
            this.lbldataciweb.Visible = false;
            // 
            // lbldataciwe11
            // 
            this.lbldataciwe11.AutoSize = true;
            this.lbldataciwe11.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldataciwe11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldataciwe11.Location = new System.Drawing.Point(0, 0);
            this.lbldataciwe11.Name = "lbldataciwe11";
            this.lbldataciwe11.Padding = new System.Windows.Forms.Padding(2);
            this.lbldataciwe11.Size = new System.Drawing.Size(73, 27);
            this.lbldataciwe11.TabIndex = 0;
            this.lbldataciwe11.Text = "Alterado:";
            this.lbldataciwe11.Visible = false;
            // 
            // txtciweb
            // 
            this.txtciweb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtciweb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtciweb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtciweb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtciweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciweb.FormattingEnabled = true;
            this.txtciweb.Items.AddRange(new object[] {
            "Não Consultado",
            "Ativo",
            "Inativo",
            "Nada Consta"});
            this.txtciweb.Location = new System.Drawing.Point(3, 26);
            this.txtciweb.Name = "txtciweb";
            this.txtciweb.Size = new System.Drawing.Size(177, 24);
            this.txtciweb.TabIndex = 20;
            this.txtciweb.SelectionChangeCommitted += new System.EventHandler(this.txtciweb_SelectionChangeCommitted);
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
            this.panel4.Controls.Add(this.panelstatuscpf);
            this.panel4.Controls.Add(this.txtStatusCPF);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(6, 26);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(183, 110);
            this.panel4.TabIndex = 6;
            // 
            // panelstatuscpf
            // 
            this.panelstatuscpf.Controls.Add(this.lbldatacpf);
            this.panelstatuscpf.Controls.Add(this.lblstatuscpf);
            this.panelstatuscpf.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelstatuscpf.Location = new System.Drawing.Point(3, 50);
            this.panelstatuscpf.Name = "panelstatuscpf";
            this.panelstatuscpf.Size = new System.Drawing.Size(177, 57);
            this.panelstatuscpf.TabIndex = 23;
            // 
            // lbldatacpf
            // 
            this.lbldatacpf.AutoSize = true;
            this.lbldatacpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldatacpf.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatacpf.Location = new System.Drawing.Point(0, 27);
            this.lbldatacpf.Name = "lbldatacpf";
            this.lbldatacpf.Padding = new System.Windows.Forms.Padding(4);
            this.lbldatacpf.Size = new System.Drawing.Size(126, 31);
            this.lbldatacpf.TabIndex = 1;
            this.lbldatacpf.Text = "__/ ___/ ____";
            this.lbldatacpf.Visible = false;
            // 
            // lblstatuscpf
            // 
            this.lblstatuscpf.AutoSize = true;
            this.lblstatuscpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstatuscpf.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuscpf.Location = new System.Drawing.Point(0, 0);
            this.lblstatuscpf.Name = "lblstatuscpf";
            this.lblstatuscpf.Padding = new System.Windows.Forms.Padding(2);
            this.lblstatuscpf.Size = new System.Drawing.Size(73, 27);
            this.lblstatuscpf.TabIndex = 0;
            this.lblstatuscpf.Text = "Alterado:";
            this.lblstatuscpf.Visible = false;
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
            this.txtStatusCPF.SelectionChangeCommitted += new System.EventHandler(this.txtStatusCPF_SelectionChangeCommitted);
            this.txtStatusCPF.SelectedValueChanged += new System.EventHandler(this.txtStatusCPF_SelectedValueChanged);
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcontacliente, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label46, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtagencia, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label45, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtrg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
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
            // ComboBoxClient
            // 
            this.ComboBoxClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxClient.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxClient.Location = new System.Drawing.Point(3, 26);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.ReadOnly = true;
            this.ComboBoxClient.Size = new System.Drawing.Size(364, 31);
            this.ComboBoxClient.TabIndex = 31;
            // 
            // txtcontacliente
            // 
            this.txtcontacliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcontacliente.Enabled = false;
            this.txtcontacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacliente.Location = new System.Drawing.Point(538, 137);
            this.txtcontacliente.Name = "txtcontacliente";
            this.txtcontacliente.Size = new System.Drawing.Size(159, 24);
            this.txtcontacliente.TabIndex = 30;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(538, 111);
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
            this.txtagencia.Location = new System.Drawing.Point(373, 137);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(159, 24);
            this.txtagencia.TabIndex = 28;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(373, 111);
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
            this.txtrg.Location = new System.Drawing.Point(538, 26);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(159, 24);
            this.txtrg.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "RG:";
            // 
            // txtrenda
            // 
            this.txtrenda.Enabled = false;
            this.txtrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenda.Location = new System.Drawing.Point(3, 137);
            this.txtrenda.Mask = "$9.999,00";
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.Size = new System.Drawing.Size(155, 22);
            this.txtrenda.TabIndex = 7;
            // 
            // txtcelular
            // 
            this.txtcelular.Enabled = false;
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(538, 86);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(157, 22);
            this.txtcelular.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 23);
            this.label20.TabIndex = 23;
            this.label20.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(373, 86);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(157, 22);
            this.txttelefone.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 23);
            this.label19.TabIndex = 21;
            this.label19.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
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
            this.txtnasc.Location = new System.Drawing.Point(703, 26);
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.Size = new System.Drawing.Size(135, 22);
            this.txtnasc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(703, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Nasc.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(3, 86);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(364, 22);
            this.txtemail.TabIndex = 5;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(373, 0);
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
            this.txtcpf.Location = new System.Drawing.Point(373, 26);
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
            this.lblcliente.Size = new System.Drawing.Size(364, 23);
            this.lblcliente.TabIndex = 1;
            this.lblcliente.Text = "Nome do Cliente:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 60);
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
            this.tabvendedor.Size = new System.Drawing.Size(984, 422);
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
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.txtcontavendedor, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.textagenciavendedor, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.textcelularvendedor, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.texttelefonevendedor, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.textemailvendedor, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.textcnpjcpf, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.textnomevendedor, 0, 1);
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
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(954, 191);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // txtcontavendedor
            // 
            this.txtcontavendedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcontavendedor.Enabled = false;
            this.txtcontavendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontavendedor.Location = new System.Drawing.Point(703, 26);
            this.txtcontavendedor.Name = "txtcontavendedor";
            this.txtcontavendedor.Size = new System.Drawing.Size(159, 24);
            this.txtcontavendedor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 0);
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
            this.textagenciavendedor.Location = new System.Drawing.Point(538, 26);
            this.textagenciavendedor.Name = "textagenciavendedor";
            this.textagenciavendedor.Size = new System.Drawing.Size(159, 24);
            this.textagenciavendedor.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Agência:";
            // 
            // textcelularvendedor
            // 
            this.textcelularvendedor.Enabled = false;
            this.textcelularvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcelularvendedor.Location = new System.Drawing.Point(538, 86);
            this.textcelularvendedor.Mask = "(99) 00000-0000";
            this.textcelularvendedor.Name = "textcelularvendedor";
            this.textcelularvendedor.Size = new System.Drawing.Size(157, 22);
            this.textcelularvendedor.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Celular:";
            // 
            // texttelefonevendedor
            // 
            this.texttelefonevendedor.Enabled = false;
            this.texttelefonevendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttelefonevendedor.Location = new System.Drawing.Point(373, 86);
            this.texttelefonevendedor.Mask = "(99) 0000-0000";
            this.texttelefonevendedor.Name = "texttelefonevendedor";
            this.texttelefonevendedor.Size = new System.Drawing.Size(157, 22);
            this.texttelefonevendedor.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 60);
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
            this.textemailvendedor.Location = new System.Drawing.Point(3, 86);
            this.textemailvendedor.Name = "textemailvendedor";
            this.textemailvendedor.Size = new System.Drawing.Size(364, 22);
            this.textemailvendedor.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(373, 0);
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
            this.textcnpjcpf.Location = new System.Drawing.Point(373, 26);
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
            this.label27.Size = new System.Drawing.Size(364, 23);
            this.label27.TabIndex = 1;
            this.label27.Text = "Nome do Vendor:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 23);
            this.label30.TabIndex = 11;
            this.label30.Text = "Email:";
            // 
            // textnomevendedor
            // 
            this.textnomevendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textnomevendedor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomevendedor.Location = new System.Drawing.Point(3, 26);
            this.textnomevendedor.Name = "textnomevendedor";
            this.textnomevendedor.ReadOnly = true;
            this.textnomevendedor.Size = new System.Drawing.Size(364, 31);
            this.textnomevendedor.TabIndex = 29;
            // 
            // tabimovel
            // 
            this.tabimovel.Controls.Add(this.tableLayoutPanel5);
            this.tabimovel.Controls.Add(this.tableLayoutPanel4);
            this.tabimovel.Controls.Add(this.tableLayoutPanel3);
            this.tabimovel.Location = new System.Drawing.Point(4, 32);
            this.tabimovel.Name = "tabimovel";
            this.tabimovel.Padding = new System.Windows.Forms.Padding(20);
            this.tabimovel.Size = new System.Drawing.Size(984, 422);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 309);
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
            this.comboBox_empreendimentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_empreendimentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_empreendimentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_empreendimentos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_empreendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_empreendimentos.FormattingEnabled = true;
            this.comboBox_empreendimentos.Location = new System.Drawing.Point(595, 26);
            this.comboBox_empreendimentos.Name = "comboBox_empreendimentos";
            this.comboBox_empreendimentos.Size = new System.Drawing.Size(318, 24);
            this.comboBox_empreendimentos.TabIndex = 27;
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
            this.comboBox_corretor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_corretor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_corretor.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_corretor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_corretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_corretor.FormattingEnabled = true;
            this.comboBox_corretor.Location = new System.Drawing.Point(299, 26);
            this.comboBox_corretor.Name = "comboBox_corretor";
            this.comboBox_corretor.Size = new System.Drawing.Size(268, 24);
            this.comboBox_corretor.TabIndex = 23;
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
            this.txtcorretora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcorretora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcorretora.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcorretora.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcorretora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorretora.FormattingEnabled = true;
            this.txtcorretora.Location = new System.Drawing.Point(3, 26);
            this.txtcorretora.Name = "txtcorretora";
            this.txtcorretora.Size = new System.Drawing.Size(290, 24);
            this.txtcorretora.TabIndex = 21;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 179);
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
            this.panel26.Controls.Add(this.maskedTextBox1);
            this.panel26.Controls.Add(this.label32);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel26.Location = new System.Drawing.Point(533, 26);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(3);
            this.panel26.Size = new System.Drawing.Size(161, 74);
            this.panel26.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 26);
            this.maskedTextBox1.Mask = "$999.999,00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(155, 24);
            this.maskedTextBox1.TabIndex = 26;
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
            this.panel10.Controls.Add(this.valorproduto);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(372, 26);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(161, 74);
            this.panel10.TabIndex = 8;
            // 
            // valorproduto
            // 
            this.valorproduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.valorproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorproduto.Location = new System.Drawing.Point(3, 26);
            this.valorproduto.Mask = "$999.999,00";
            this.valorproduto.Name = "valorproduto";
            this.valorproduto.Size = new System.Drawing.Size(155, 24);
            this.valorproduto.TabIndex = 26;
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
            this.comboBox_programa.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_programa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_programa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_programa.FormattingEnabled = true;
            this.comboBox_programa.Location = new System.Drawing.Point(3, 26);
            this.comboBox_programa.Name = "comboBox_programa";
            this.comboBox_programa.Size = new System.Drawing.Size(177, 24);
            this.comboBox_programa.TabIndex = 20;
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
            this.comboBox_agencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_agencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_agencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_agencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_agencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_agencia.FormattingEnabled = true;
            this.comboBox_agencia.Location = new System.Drawing.Point(3, 26);
            this.comboBox_agencia.Name = "comboBox_agencia";
            this.comboBox_agencia.Size = new System.Drawing.Size(177, 24);
            this.comboBox_agencia.TabIndex = 20;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(944, 159);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel25);
            this.groupBox2.Controls.Add(this.panel24);
            this.groupBox2.Controls.Add(this.panel23);
            this.groupBox2.Controls.Add(this.panel22);
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.panel12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(938, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situações:";
            // 
            // panel25
            // 
            this.panel25.AutoSize = true;
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel25.Controls.Add(this.panel31);
            this.panel25.Controls.Add(this.comboBox3);
            this.panel25.Controls.Add(this.label31);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel25.Location = new System.Drawing.Point(794, 26);
            this.panel25.Name = "panel25";
            this.panel25.Padding = new System.Windows.Forms.Padding(3);
            this.panel25.Size = new System.Drawing.Size(143, 121);
            this.panel25.TabIndex = 11;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.lblpa);
            this.panel31.Controls.Add(this.label44);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel31.Location = new System.Drawing.Point(3, 50);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(135, 66);
            this.panel31.TabIndex = 27;
            // 
            // lblpa
            // 
            this.lblpa.AutoSize = true;
            this.lblpa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblpa.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpa.Location = new System.Drawing.Point(0, 27);
            this.lblpa.Name = "lblpa";
            this.lblpa.Padding = new System.Windows.Forms.Padding(2);
            this.lblpa.Size = new System.Drawing.Size(122, 27);
            this.lblpa.TabIndex = 1;
            this.lblpa.Text = "__/ ___/ ____";
            this.lblpa.Visible = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Top;
            this.label44.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(0, 0);
            this.label44.Name = "label44";
            this.label44.Padding = new System.Windows.Forms.Padding(2);
            this.label44.Size = new System.Drawing.Size(73, 27);
            this.label44.TabIndex = 0;
            this.label44.Text = "Alterado:";
            this.label44.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Conforme ",
            "Não Conforme"});
            this.comboBox3.Location = new System.Drawing.Point(3, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 24);
            this.comboBox3.TabIndex = 20;
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Top;
            this.label31.Location = new System.Drawing.Point(3, 3);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(135, 23);
            this.label31.TabIndex = 19;
            this.label31.Text = "PA:";
            // 
            // panel24
            // 
            this.panel24.AutoSize = true;
            this.panel24.Controls.Add(this.panel30);
            this.panel24.Controls.Add(this.comboBox2);
            this.panel24.Controls.Add(this.label25);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel24.Location = new System.Drawing.Point(653, 26);
            this.panel24.Name = "panel24";
            this.panel24.Padding = new System.Windows.Forms.Padding(3);
            this.panel24.Size = new System.Drawing.Size(141, 121);
            this.panel24.TabIndex = 10;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.lblsictd);
            this.panel30.Controls.Add(this.label42);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel30.Location = new System.Drawing.Point(3, 50);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(135, 68);
            this.panel30.TabIndex = 26;
            // 
            // lblsictd
            // 
            this.lblsictd.AutoSize = true;
            this.lblsictd.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblsictd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsictd.Location = new System.Drawing.Point(0, 27);
            this.lblsictd.Name = "lblsictd";
            this.lblsictd.Padding = new System.Windows.Forms.Padding(2);
            this.lblsictd.Size = new System.Drawing.Size(122, 27);
            this.lblsictd.TabIndex = 1;
            this.lblsictd.Text = "__/ ___/ ____";
            this.lblsictd.Visible = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Dock = System.Windows.Forms.DockStyle.Top;
            this.label42.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(0, 0);
            this.label42.Name = "label42";
            this.label42.Padding = new System.Windows.Forms.Padding(2);
            this.label42.Size = new System.Drawing.Size(73, 27);
            this.label42.TabIndex = 0;
            this.label42.Text = "Alterado:";
            this.label42.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Enviado",
            "Não Enviado"});
            this.comboBox2.Location = new System.Drawing.Point(3, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 24);
            this.comboBox2.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(3, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 23);
            this.label25.TabIndex = 19;
            this.label25.Text = "SICTD:";
            // 
            // panel23
            // 
            this.panel23.AutoSize = true;
            this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel23.Controls.Add(this.panel29);
            this.panel23.Controls.Add(this.comboBox1);
            this.panel23.Controls.Add(this.label13);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(510, 26);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(3);
            this.panel23.Size = new System.Drawing.Size(143, 121);
            this.panel23.TabIndex = 9;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.lblsiopi);
            this.panel29.Controls.Add(this.label40);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel29.Location = new System.Drawing.Point(3, 50);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(135, 66);
            this.panel29.TabIndex = 25;
            // 
            // lblsiopi
            // 
            this.lblsiopi.AutoSize = true;
            this.lblsiopi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblsiopi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsiopi.Location = new System.Drawing.Point(0, 27);
            this.lblsiopi.Name = "lblsiopi";
            this.lblsiopi.Padding = new System.Windows.Forms.Padding(2);
            this.lblsiopi.Size = new System.Drawing.Size(122, 27);
            this.lblsiopi.TabIndex = 1;
            this.lblsiopi.Text = "__/ ___/ ____";
            this.lblsiopi.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Top;
            this.label40.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Padding = new System.Windows.Forms.Padding(2);
            this.label40.Size = new System.Drawing.Size(73, 27);
            this.label40.TabIndex = 0;
            this.label40.Text = "Alterado:";
            this.label40.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Enviado",
            "Não Enviado"});
            this.comboBox1.Location = new System.Drawing.Point(3, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "SIOPI:";
            // 
            // panel22
            // 
            this.panel22.AutoSize = true;
            this.panel22.Controls.Add(this.panel27);
            this.panel22.Controls.Add(this.comboBox_saque);
            this.panel22.Controls.Add(this.lblsaque);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(344, 26);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(3);
            this.panel22.Size = new System.Drawing.Size(166, 121);
            this.panel22.TabIndex = 8;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.lblsaquefgts);
            this.panel27.Controls.Add(this.label38);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel27.Location = new System.Drawing.Point(3, 50);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(160, 68);
            this.panel27.TabIndex = 24;
            // 
            // lblsaquefgts
            // 
            this.lblsaquefgts.AutoSize = true;
            this.lblsaquefgts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblsaquefgts.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaquefgts.Location = new System.Drawing.Point(0, 27);
            this.lblsaquefgts.Name = "lblsaquefgts";
            this.lblsaquefgts.Padding = new System.Windows.Forms.Padding(2);
            this.lblsaquefgts.Size = new System.Drawing.Size(122, 27);
            this.lblsaquefgts.TabIndex = 1;
            this.lblsaquefgts.Text = "__/ ___/ ____";
            this.lblsaquefgts.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Top;
            this.label38.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(0, 0);
            this.label38.Name = "label38";
            this.label38.Padding = new System.Windows.Forms.Padding(2);
            this.label38.Size = new System.Drawing.Size(73, 27);
            this.label38.TabIndex = 0;
            this.label38.Text = "Alterado:";
            this.label38.Visible = false;
            // 
            // comboBox_saque
            // 
            this.comboBox_saque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_saque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_saque.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_saque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_saque.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_saque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_saque.FormattingEnabled = true;
            this.comboBox_saque.Items.AddRange(new object[] {
            "Total",
            "Parcial",
            "Não Usar"});
            this.comboBox_saque.Location = new System.Drawing.Point(3, 26);
            this.comboBox_saque.Name = "comboBox_saque";
            this.comboBox_saque.Size = new System.Drawing.Size(160, 24);
            this.comboBox_saque.TabIndex = 20;
            // 
            // lblsaque
            // 
            this.lblsaque.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsaque.Location = new System.Drawing.Point(3, 3);
            this.lblsaque.Name = "lblsaque";
            this.lblsaque.Size = new System.Drawing.Size(160, 23);
            this.lblsaque.TabIndex = 19;
            this.lblsaque.Text = "Saque FGTS:";
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.panel28);
            this.panel11.Controls.Add(this.comboBox_statuseng);
            this.panel11.Controls.Add(this.label28);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(176, 26);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(3);
            this.panel11.Size = new System.Drawing.Size(168, 121);
            this.panel11.TabIndex = 7;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.lblstatuseng);
            this.panel28.Controls.Add(this.label36);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel28.Location = new System.Drawing.Point(3, 50);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(160, 66);
            this.panel28.TabIndex = 23;
            // 
            // lblstatuseng
            // 
            this.lblstatuseng.AutoSize = true;
            this.lblstatuseng.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblstatuseng.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuseng.Location = new System.Drawing.Point(0, 27);
            this.lblstatuseng.Name = "lblstatuseng";
            this.lblstatuseng.Padding = new System.Windows.Forms.Padding(2);
            this.lblstatuseng.Size = new System.Drawing.Size(122, 27);
            this.lblstatuseng.TabIndex = 1;
            this.lblstatuseng.Text = "__/ ___/ ____";
            this.lblstatuseng.Click += new System.EventHandler(this.label35_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Top;
            this.label36.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Padding = new System.Windows.Forms.Padding(2);
            this.label36.Size = new System.Drawing.Size(73, 27);
            this.label36.TabIndex = 0;
            this.label36.Text = "Alterado:";
            // 
            // comboBox_statuseng
            // 
            this.comboBox_statuseng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_statuseng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_statuseng.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_statuseng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statuseng.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_statuseng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_statuseng.FormattingEnabled = true;
            this.comboBox_statuseng.Items.AddRange(new object[] {
            "Não Consultado",
            "Aguardando Pagamento",
            "Aprovado Abaixo",
            "Aprovado Normal",
            "Contestação",
            "Solicitado"});
            this.comboBox_statuseng.Location = new System.Drawing.Point(3, 26);
            this.comboBox_statuseng.Name = "comboBox_statuseng";
            this.comboBox_statuseng.Size = new System.Drawing.Size(160, 24);
            this.comboBox_statuseng.TabIndex = 20;
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Location = new System.Drawing.Point(3, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(160, 23);
            this.label28.TabIndex = 19;
            this.label28.Text = "Status Eng.:";
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.Controls.Add(this.paneldataanalise);
            this.panel12.Controls.Add(this.comboBox_analise);
            this.panel12.Controls.Add(this.label29);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(6, 26);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(5);
            this.panel12.Size = new System.Drawing.Size(170, 121);
            this.panel12.TabIndex = 6;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // paneldataanalise
            // 
            this.paneldataanalise.Controls.Add(this.lblstatusanalise);
            this.paneldataanalise.Controls.Add(this.label33);
            this.paneldataanalise.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldataanalise.Location = new System.Drawing.Point(5, 52);
            this.paneldataanalise.Name = "paneldataanalise";
            this.paneldataanalise.Size = new System.Drawing.Size(160, 64);
            this.paneldataanalise.TabIndex = 22;
            // 
            // lblstatusanalise
            // 
            this.lblstatusanalise.AutoSize = true;
            this.lblstatusanalise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstatusanalise.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusanalise.Location = new System.Drawing.Point(0, 27);
            this.lblstatusanalise.Name = "lblstatusanalise";
            this.lblstatusanalise.Padding = new System.Windows.Forms.Padding(2);
            this.lblstatusanalise.Size = new System.Drawing.Size(122, 27);
            this.lblstatusanalise.TabIndex = 1;
            this.lblstatusanalise.Text = "__/ ___/ ____";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Top;
            this.label33.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(2);
            this.label33.Size = new System.Drawing.Size(73, 27);
            this.label33.TabIndex = 0;
            this.label33.Text = "Alterado:";
            // 
            // comboBox_analise
            // 
            this.comboBox_analise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_analise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_analise.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_analise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_analise.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_analise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_analise.FormattingEnabled = true;
            this.comboBox_analise.Items.AddRange(new object[] {
            "Não Consultado",
            "Aprovado",
            "Condicionado",
            "Em analise",
            "Reprovado",
            "Comando",
            "Desistiu",
            "Bloqueado em ourto CCA"});
            this.comboBox_analise.Location = new System.Drawing.Point(5, 28);
            this.comboBox_analise.Name = "comboBox_analise";
            this.comboBox_analise.Size = new System.Drawing.Size(160, 24);
            this.comboBox_analise.TabIndex = 20;
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(5, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(160, 23);
            this.label29.TabIndex = 19;
            this.label29.Text = "Status Análise:";
            // 
            // tabdocumentos
            // 
            this.tabdocumentos.Controls.Add(this.tableLayoutPanel6);
            this.tabdocumentos.Controls.Add(this.groupBox5);
            this.tabdocumentos.Location = new System.Drawing.Point(4, 32);
            this.tabdocumentos.Name = "tabdocumentos";
            this.tabdocumentos.Padding = new System.Windows.Forms.Padding(20);
            this.tabdocumentos.Size = new System.Drawing.Size(984, 422);
            this.tabdocumentos.TabIndex = 1;
            this.tabdocumentos.Text = "Cartório";
            this.tabdocumentos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(20, 132);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(944, 181);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel15);
            this.groupBox6.Controls.Add(this.panel16);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.Size = new System.Drawing.Size(938, 145);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situação:";
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(340, 26);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(3);
            this.panel15.Size = new System.Drawing.Size(534, 113);
            this.panel15.TabIndex = 7;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.comboBox_statuscartorio);
            this.panel16.Controls.Add(this.label18);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(6, 26);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(3);
            this.panel16.Size = new System.Drawing.Size(334, 113);
            this.panel16.TabIndex = 6;
            // 
            // comboBox_statuscartorio
            // 
            this.comboBox_statuscartorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_statuscartorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_statuscartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_statuscartorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statuscartorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_statuscartorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_statuscartorio.FormattingEnabled = true;
            this.comboBox_statuscartorio.Items.AddRange(new object[] {
            "A retirar",
            "Aguardando",
            "Entregue",
            "Retirado"});
            this.comboBox_statuscartorio.Location = new System.Drawing.Point(3, 26);
            this.comboBox_statuscartorio.Name = "comboBox_statuscartorio";
            this.comboBox_statuscartorio.Size = new System.Drawing.Size(328, 24);
            this.comboBox_statuscartorio.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(3, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(328, 23);
            this.label18.TabIndex = 19;
            this.label18.Text = "Status:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel14);
            this.groupBox5.Controls.Add(this.panel13);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(20, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(944, 112);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cartorio";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(317, 23);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 86);
            this.panel14.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(10, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.comboBox_nomecartorio);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(3, 23);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(314, 86);
            this.panel13.TabIndex = 0;
            // 
            // comboBox_nomecartorio
            // 
            this.comboBox_nomecartorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_nomecartorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_nomecartorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_nomecartorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.comboBox_nomecartorio.FormattingEnabled = true;
            this.comboBox_nomecartorio.Location = new System.Drawing.Point(0, 23);
            this.comboBox_nomecartorio.Name = "comboBox_nomecartorio";
            this.comboBox_nomecartorio.Size = new System.Drawing.Size(314, 31);
            this.comboBox_nomecartorio.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nome:";
            // 
            // tabdoc
            // 
            this.tabdoc.Controls.Add(this.tableLayoutPanel7);
            this.tabdoc.Location = new System.Drawing.Point(4, 32);
            this.tabdoc.Name = "tabdoc";
            this.tabdoc.Padding = new System.Windows.Forms.Padding(20);
            this.tabdoc.Size = new System.Drawing.Size(984, 422);
            this.tabdoc.TabIndex = 2;
            this.tabdoc.Text = "Documentação";
            this.tabdoc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox7, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(944, 332);
            this.tableLayoutPanel7.TabIndex = 24;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Location = new System.Drawing.Point(3, 136);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(938, 132);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Anexos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.descricao,
            this.data,
            this.status,
            this.apagar});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 100);
            this.dataGridView1.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // apagar
            // 
            this.apagar.HeaderText = "Excluir";
            this.apagar.Name = "apagar";
            this.apagar.Text = "Excluir";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel17);
            this.groupBox8.Controls.Add(this.panel18);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(938, 112);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Anexar";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button1);
            this.panel17.Controls.Add(this.button3);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(317, 23);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(468, 86);
            this.panel17.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(51, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Anexar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(10, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 32);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.textBox1);
            this.panel18.Controls.Add(this.label8);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(3, 23);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(314, 86);
            this.panel18.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nome:";
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
            // panelfuncresp
            // 
            this.panelfuncresp.Controls.Add(this.lblfunc);
            this.panelfuncresp.Controls.Add(this.lblfuncresponsavel);
            this.panelfuncresp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfuncresp.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelfuncresp.Location = new System.Drawing.Point(0, 472);
            this.panelfuncresp.Name = "panelfuncresp";
            this.panelfuncresp.Padding = new System.Windows.Forms.Padding(10);
            this.panelfuncresp.Size = new System.Drawing.Size(992, 43);
            this.panelfuncresp.TabIndex = 15;
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblfunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lblfunc.Location = new System.Drawing.Point(641, 10);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(194, 23);
            this.lblfunc.TabIndex = 10;
            this.lblfunc.Text = "Funcionário(a) Responsável:";
            // 
            // lblfuncresponsavel
            // 
            this.lblfuncresponsavel.AutoSize = true;
            this.lblfuncresponsavel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblfuncresponsavel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncresponsavel.Location = new System.Drawing.Point(835, 10);
            this.lblfuncresponsavel.Name = "lblfuncresponsavel";
            this.lblfuncresponsavel.Size = new System.Drawing.Size(147, 23);
            this.lblfuncresponsavel.TabIndex = 9;
            this.lblfuncresponsavel.Text = "Nome Funcionário(a)";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.lblstatuscartorio);
            this.panel19.Controls.Add(this.label35);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(3, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(160, 60);
            this.panel19.TabIndex = 23;
            // 
            // lblstatuscartorio
            // 
            this.lblstatuscartorio.AutoSize = true;
            this.lblstatuscartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstatuscartorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuscartorio.Location = new System.Drawing.Point(0, 27);
            this.lblstatuscartorio.Name = "lblstatuscartorio";
            this.lblstatuscartorio.Padding = new System.Windows.Forms.Padding(2);
            this.lblstatuscartorio.Size = new System.Drawing.Size(122, 27);
            this.lblstatuscartorio.TabIndex = 1;
            this.lblstatuscartorio.Text = "__/ ___/ ____";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Top;
            this.label35.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Padding = new System.Windows.Forms.Padding(2);
            this.label35.Size = new System.Drawing.Size(73, 27);
            this.label35.TabIndex = 0;
            this.label35.Text = "Alterado:";
            // 
            // lbldatastatus
            // 
            this.lbldatastatus.AutoSize = true;
            this.lbldatastatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbldatastatus.Location = new System.Drawing.Point(468, 4);
            this.lbldatastatus.Name = "lbldatastatus";
            this.lbldatastatus.Size = new System.Drawing.Size(30, 13);
            this.lbldatastatus.TabIndex = 9;
            this.lbldatastatus.Text = "Data";
            // 
            // Form_Dados_Documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 567);
            this.Controls.Add(this.panelfuncresp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Documentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Processo";
            this.Load += new System.EventHandler(this.Form_Dados_Documentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabcliente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelstatusfgts.ResumeLayout(false);
            this.panelstatusfgts.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelstatusir.ResumeLayout(false);
            this.panelstatusir.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelstatuscadmut.ResumeLayout(false);
            this.panelstatuscadmut.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelstatusciweb.ResumeLayout(false);
            this.panelstatusciweb.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelstatuscpf.ResumeLayout(false);
            this.panelstatuscpf.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabvendedor.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.paneldataanalise.ResumeLayout(false);
            this.paneldataanalise.PerformLayout();
            this.tabdocumentos.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tabdoc.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.panelfuncresp.ResumeLayout(false);
            this.panelfuncresp.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBox_statuseng;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox comboBox_analise;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox comboBox_statuscartorio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox comboBox_nomecartorio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn apagar;
        private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.BindingSource statusAnaliseBindingSource;
       // private System.Windows.Forms.BindingSource dSCombobox1BindingSource;
       // private System.Windows.Forms.BindingSource statusEngBindingSource;
        //private System.Windows.Forms.BindingSource agenciaBindingSource;
        //private System.Windows.Forms.BindingSource programaBindingSource;
        private System.Windows.Forms.MaskedTextBox valorproduto;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabvendedor;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textagenciavendedor;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.ComboBox comboBox_saque;
        private System.Windows.Forms.Label lblsaque;
        private System.Windows.Forms.TextBox txtcontavendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel paneldataanalise;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label lblpa;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblsictd;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label lblsiopi;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label lblsaquefgts;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label lblstatuseng;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblstatusanalise;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtcontacliente;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panelstatuscpf;
        private System.Windows.Forms.Label lbldatacpf;
        private System.Windows.Forms.Label lblstatuscpf;
        private System.Windows.Forms.TextBox textnomevendedor;
        private System.Windows.Forms.TextBox ComboBoxClient;
        private System.Windows.Forms.Label lblnumeroprocesso;
        private System.Windows.Forms.Panel panelfunc;
        private System.Windows.Forms.Panel panelfuncresp;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lblfuncresponsavel;
        private System.Windows.Forms.Panel panelstatusfgts;
        private System.Windows.Forms.Label lbldatafgts;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Panel panelstatusir;
        private System.Windows.Forms.Label lbldatair;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panelstatuscadmut;
        private System.Windows.Forms.Label lbldatacadmut;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panelstatusciweb;
        private System.Windows.Forms.Label lbldataciweb;
        private System.Windows.Forms.Label lbldataciwe11;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblstatuscartorio;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lbldatastatus;
        //private System.Windows.Forms.BindingSource corretoraBindingSource;
        //private System.Windows.Forms.BindingSource corretoresBindingSource;
        //private System.Windows.Forms.BindingSource vendedorBindingSource;
        //private System.Windows.Forms.BindingSource empreendimentosBindingSource;
        //private System.Windows.Forms.BindingSource statusCartorioBindingSource;
        //private System.Windows.Forms.BindingSource cartorioBindingSource;
    }
}