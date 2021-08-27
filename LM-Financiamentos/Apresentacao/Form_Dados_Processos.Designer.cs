
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Processos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Processos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsalvardoc = new System.Windows.Forms.Button();
            this.processosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Documentos = new LMFinanciamentos.DAL.DS_Documentos();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lblnumeroprocesso = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.btncloseconf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelardoc = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.grpbSituacao = new System.Windows.Forms.GroupBox();
            this.tableLayoutsitua = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelstatuscpf = new System.Windows.Forms.Panel();
            this.dtpcpf = new System.Windows.Forms.DateTimePicker();
            this.lblacpf = new System.Windows.Forms.Label();
            this.txtStatusCPF = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelstatusciweb = new System.Windows.Forms.Panel();
            this.dtpciweb = new System.Windows.Forms.DateTimePicker();
            this.lblaciweb = new System.Windows.Forms.Label();
            this.txtciweb = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelstatuscadmut = new System.Windows.Forms.Panel();
            this.dtpcadmut = new System.Windows.Forms.DateTimePicker();
            this.lblacadmut = new System.Windows.Forms.Label();
            this.txtcadmut = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelstatusir = new System.Windows.Forms.Panel();
            this.dtpir = new System.Windows.Forms.DateTimePicker();
            this.lblair = new System.Windows.Forms.Label();
            this.txtir = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelstatusfgts = new System.Windows.Forms.Panel();
            this.dtpfgtscli = new System.Windows.Forms.DateTimePicker();
            this.lblafgtscli = new System.Windows.Forms.Label();
            this.txtfgts = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panelfunc = new System.Windows.Forms.Panel();
            this.groupBoxdadospessoais = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxClient = new System.Windows.Forms.TextBox();
            this.txtcontacliente = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtagenciacliente = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.txtrenda = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_corretora = new System.Windows.Forms.ComboBox();
            this.lblcorretora = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBox_corretor = new System.Windows.Forms.ComboBox();
            this.lblcorretor = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.comboBox_empreendimentos = new System.Windows.Forms.ComboBox();
            this.lblempresendimentos = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutSituacao = new System.Windows.Forms.TableLayoutPanel();
            this.pnlpa = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.dtppa = new System.Windows.Forms.DateTimePicker();
            this.lblapa = new System.Windows.Forms.Label();
            this.comboBox_PA = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.pnlsictd = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.dtpsictd = new System.Windows.Forms.DateTimePicker();
            this.lblasictd = new System.Windows.Forms.Label();
            this.comboBox_SICTD = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.pnlsiopi = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.dtpsiopi = new System.Windows.Forms.DateTimePicker();
            this.lblasiopi = new System.Windows.Forms.Label();
            this.comboBox_SIOPI = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlfgts = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dtpfgts = new System.Windows.Forms.DateTimePicker();
            this.lblafgts = new System.Windows.Forms.Label();
            this.comboBox_saque = new System.Windows.Forms.ComboBox();
            this.lblsaque = new System.Windows.Forms.Label();
            this.pnleng = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dtpeng = new System.Windows.Forms.DateTimePicker();
            this.lblaeng = new System.Windows.Forms.Label();
            this.comboBox_statuseng = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.pnlAnalise = new System.Windows.Forms.Panel();
            this.paneldataanalise = new System.Windows.Forms.Panel();
            this.dtpanalise = new System.Windows.Forms.DateTimePicker();
            this.lblaanalise = new System.Windows.Forms.Label();
            this.comboBox_analise = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabcartorio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxsituacao = new System.Windows.Forms.GroupBox();
            this.pnlsituacao = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.dtpcartorio = new System.Windows.Forms.DateTimePicker();
            this.lblacartorio = new System.Windows.Forms.Label();
            this.comboBox_statuscartorio = new System.Windows.Forms.ComboBox();
            this.lblstatuscart = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblenderecocartorio = new System.Windows.Forms.Label();
            this.lblnomecartorio = new System.Windows.Forms.Label();
            this.lbldescricart = new System.Windows.Forms.Label();
            this.groupBoxcartorio = new System.Windows.Forms.GroupBox();
            this.pnlenviar = new System.Windows.Forms.Panel();
            this.btnenviar = new System.Windows.Forms.Button();
            this.pnlnome = new System.Windows.Forms.Panel();
            this.comboBox_nomecartorio = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabdoc = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Arquivos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baixar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_tipoProcesso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.comboBox_tipoArquivo = new System.Windows.Forms.ComboBox();
            this.btnSelecionarArquivos = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes = new LMFinanciamentos.DAL.DS_Clientes();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panelfuncresp = new System.Windows.Forms.Panel();
            this.lbldata = new System.Windows.Forms.Label();
            this.lbldatalbl = new System.Windows.Forms.Label();
            this.lblfunc = new System.Windows.Forms.Label();
            this.lblfuncresponsavel = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processosTableAdapter = new LMFinanciamentos.DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new LMFinanciamentos.DAL.DS_ClientesTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabcliente.SuspendLayout();
            this.grpbSituacao.SuspendLayout();
            this.tableLayoutsitua.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelstatuscpf.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelstatusciweb.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelstatuscadmut.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelstatusir.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelstatusfgts.SuspendLayout();
            this.groupBoxdadospessoais.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabvendedor.SuspendLayout();
            this.panel20.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabimovel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutSituacao.SuspendLayout();
            this.pnlpa.SuspendLayout();
            this.panel34.SuspendLayout();
            this.pnlsictd.SuspendLayout();
            this.panel30.SuspendLayout();
            this.pnlsiopi.SuspendLayout();
            this.panel29.SuspendLayout();
            this.pnlfgts.SuspendLayout();
            this.panel27.SuspendLayout();
            this.pnleng.SuspendLayout();
            this.panel28.SuspendLayout();
            this.pnlAnalise.SuspendLayout();
            this.paneldataanalise.SuspendLayout();
            this.tabcartorio.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxsituacao.SuspendLayout();
            this.pnlsituacao.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel19.SuspendLayout();
            this.groupBoxcartorio.SuspendLayout();
            this.pnlenviar.SuspendLayout();
            this.pnlnome.SuspendLayout();
            this.tabdoc.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arquivos)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            this.panelfuncresp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
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
            this.paneltop.Controls.Add(this.lblnumeroprocesso);
            this.paneltop.Controls.Add(this.lblstatus);
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(1112, 57);
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
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblstatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblstatus.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Black;
            this.lblstatus.Location = new System.Drawing.Point(729, 4);
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
            this.btncloseconf.Location = new System.Drawing.Point(998, 10);
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
            this.panel1.Location = new System.Drawing.Point(0, 603);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1112, 52);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabcliente);
            this.tabControl.Controls.Add(this.tabvendedor);
            this.tabControl.Controls.Add(this.tabimovel);
            this.tabControl.Controls.Add(this.tabcartorio);
            this.tabControl.Controls.Add(this.tabdoc);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1112, 546);
            this.tabControl.TabIndex = 14;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.grpbSituacao);
            this.tabcliente.Controls.Add(this.groupBoxdadospessoais);
            this.tabcliente.Location = new System.Drawing.Point(4, 32);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(1104, 510);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // grpbSituacao
            // 
            this.grpbSituacao.Controls.Add(this.tableLayoutsitua);
            this.grpbSituacao.Controls.Add(this.panelfunc);
            this.grpbSituacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSituacao.Location = new System.Drawing.Point(20, 222);
            this.grpbSituacao.Name = "grpbSituacao";
            this.grpbSituacao.Padding = new System.Windows.Forms.Padding(6);
            this.grpbSituacao.Size = new System.Drawing.Size(1064, 185);
            this.grpbSituacao.TabIndex = 7;
            this.grpbSituacao.TabStop = false;
            this.grpbSituacao.Text = "Situações:";
            // 
            // tableLayoutsitua
            // 
            this.tableLayoutsitua.ColumnCount = 5;
            this.tableLayoutsitua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutsitua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutsitua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutsitua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutsitua.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutsitua.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutsitua.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutsitua.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutsitua.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutsitua.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutsitua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutsitua.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutsitua.Name = "tableLayoutsitua";
            this.tableLayoutsitua.RowCount = 1;
            this.tableLayoutsitua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutsitua.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutsitua.Size = new System.Drawing.Size(1052, 153);
            this.tableLayoutsitua.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.panelstatuscpf);
            this.panel4.Controls.Add(this.txtStatusCPF);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(204, 147);
            this.panel4.TabIndex = 15;
            // 
            // panelstatuscpf
            // 
            this.panelstatuscpf.Controls.Add(this.dtpcpf);
            this.panelstatuscpf.Controls.Add(this.lblacpf);
            this.panelstatuscpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstatuscpf.Location = new System.Drawing.Point(8, 59);
            this.panelstatuscpf.Name = "panelstatuscpf";
            this.panelstatuscpf.Size = new System.Drawing.Size(188, 84);
            this.panelstatuscpf.TabIndex = 23;
            // 
            // dtpcpf
            // 
            this.dtpcpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpcpf.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpcpf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcpf.Location = new System.Drawing.Point(0, 27);
            this.dtpcpf.Name = "dtpcpf";
            this.dtpcpf.Size = new System.Drawing.Size(188, 27);
            this.dtpcpf.TabIndex = 2;
            this.dtpcpf.Visible = false;
            // 
            // lblacpf
            // 
            this.lblacpf.AutoSize = true;
            this.lblacpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblacpf.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacpf.Location = new System.Drawing.Point(0, 0);
            this.lblacpf.Name = "lblacpf";
            this.lblacpf.Padding = new System.Windows.Forms.Padding(2);
            this.lblacpf.Size = new System.Drawing.Size(73, 27);
            this.lblacpf.TabIndex = 0;
            this.lblacpf.Text = "Alterado:";
            this.lblacpf.Visible = false;
            // 
            // txtStatusCPF
            // 
            this.txtStatusCPF.AutoCompleteCustomSource.AddRange(new string[] {
            "Não Consultado",
            "Com Restrição",
            "Divergente RF",
            "Nada Consta",
            "Bloqueado em outro CCA"});
            this.txtStatusCPF.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatusCPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStatusCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatusCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatusCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCPF.FormattingEnabled = true;
            this.txtStatusCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtStatusCPF.Items.AddRange(new object[] {
            "Não Consultado",
            "Com Restrição",
            "Divergente RF",
            "Nada Consta",
            "Bloqueado em outro CCA"});
            this.txtStatusCPF.Location = new System.Drawing.Point(8, 31);
            this.txtStatusCPF.Name = "txtStatusCPF";
            this.txtStatusCPF.Size = new System.Drawing.Size(188, 28);
            this.txtStatusCPF.TabIndex = 20;
            this.txtStatusCPF.SelectionChangeCommitted += new System.EventHandler(this.txtStatusCPF_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(8, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Situação CPF:";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.panelstatusciweb);
            this.panel5.Controls.Add(this.txtciweb);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(213, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(204, 147);
            this.panel5.TabIndex = 14;
            // 
            // panelstatusciweb
            // 
            this.panelstatusciweb.Controls.Add(this.dtpciweb);
            this.panelstatusciweb.Controls.Add(this.lblaciweb);
            this.panelstatusciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstatusciweb.Location = new System.Drawing.Point(8, 59);
            this.panelstatusciweb.Name = "panelstatusciweb";
            this.panelstatusciweb.Size = new System.Drawing.Size(188, 84);
            this.panelstatusciweb.TabIndex = 24;
            // 
            // dtpciweb
            // 
            this.dtpciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpciweb.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpciweb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpciweb.Location = new System.Drawing.Point(0, 27);
            this.dtpciweb.Name = "dtpciweb";
            this.dtpciweb.Size = new System.Drawing.Size(188, 27);
            this.dtpciweb.TabIndex = 3;
            this.dtpciweb.Visible = false;
            // 
            // lblaciweb
            // 
            this.lblaciweb.AutoSize = true;
            this.lblaciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblaciweb.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaciweb.Location = new System.Drawing.Point(0, 0);
            this.lblaciweb.Name = "lblaciweb";
            this.lblaciweb.Padding = new System.Windows.Forms.Padding(2);
            this.lblaciweb.Size = new System.Drawing.Size(73, 27);
            this.lblaciweb.TabIndex = 0;
            this.lblaciweb.Text = "Alterado:";
            this.lblaciweb.Visible = false;
            // 
            // txtciweb
            // 
            this.txtciweb.AutoCompleteCustomSource.AddRange(new string[] {
            "Não Consultado",
            "Ativo",
            "Inativo",
            "Nada Consta"});
            this.txtciweb.BackColor = System.Drawing.SystemColors.Control;
            this.txtciweb.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtciweb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtciweb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtciweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciweb.FormattingEnabled = true;
            this.txtciweb.Items.AddRange(new object[] {
            "Não Consultado",
            "Ativo",
            "Inativo",
            "Nada Consta"});
            this.txtciweb.Location = new System.Drawing.Point(8, 31);
            this.txtciweb.Name = "txtciweb";
            this.txtciweb.Size = new System.Drawing.Size(188, 28);
            this.txtciweb.TabIndex = 20;
            this.txtciweb.SelectionChangeCommitted += new System.EventHandler(this.txtciweb_SelectionChangeCommitted);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Location = new System.Drawing.Point(8, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(188, 23);
            this.label21.TabIndex = 19;
            this.label21.Text = "Situação Ciweb:";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.panelstatuscadmut);
            this.panel6.Controls.Add(this.txtcadmut);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(423, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8);
            this.panel6.Size = new System.Drawing.Size(204, 147);
            this.panel6.TabIndex = 13;
            // 
            // panelstatuscadmut
            // 
            this.panelstatuscadmut.Controls.Add(this.dtpcadmut);
            this.panelstatuscadmut.Controls.Add(this.lblacadmut);
            this.panelstatuscadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstatuscadmut.Location = new System.Drawing.Point(8, 59);
            this.panelstatuscadmut.Name = "panelstatuscadmut";
            this.panelstatuscadmut.Size = new System.Drawing.Size(188, 84);
            this.panelstatuscadmut.TabIndex = 24;
            // 
            // dtpcadmut
            // 
            this.dtpcadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpcadmut.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpcadmut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcadmut.Location = new System.Drawing.Point(0, 27);
            this.dtpcadmut.Name = "dtpcadmut";
            this.dtpcadmut.Size = new System.Drawing.Size(188, 27);
            this.dtpcadmut.TabIndex = 4;
            this.dtpcadmut.Visible = false;
            // 
            // lblacadmut
            // 
            this.lblacadmut.AutoSize = true;
            this.lblacadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblacadmut.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacadmut.Location = new System.Drawing.Point(0, 0);
            this.lblacadmut.Name = "lblacadmut";
            this.lblacadmut.Padding = new System.Windows.Forms.Padding(2);
            this.lblacadmut.Size = new System.Drawing.Size(73, 27);
            this.lblacadmut.TabIndex = 0;
            this.lblacadmut.Text = "Alterado:";
            this.lblacadmut.Visible = false;
            // 
            // txtcadmut
            // 
            this.txtcadmut.BackColor = System.Drawing.SystemColors.Control;
            this.txtcadmut.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtcadmut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcadmut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcadmut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadmut.FormattingEnabled = true;
            this.txtcadmut.Items.AddRange(new object[] {
            "Não Consultado",
            "Ativo",
            "Inativo",
            "Nada Consta"});
            this.txtcadmut.Location = new System.Drawing.Point(8, 31);
            this.txtcadmut.Name = "txtcadmut";
            this.txtcadmut.Size = new System.Drawing.Size(188, 28);
            this.txtcadmut.TabIndex = 20;
            this.txtcadmut.SelectionChangeCommitted += new System.EventHandler(this.txtcadmut_SelectionChangeCommitted);
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(8, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(188, 23);
            this.label22.TabIndex = 19;
            this.label22.Text = "Situação Cadmut:";
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.panelstatusir);
            this.panel7.Controls.Add(this.txtir);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(633, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(8);
            this.panel7.Size = new System.Drawing.Size(204, 147);
            this.panel7.TabIndex = 12;
            // 
            // panelstatusir
            // 
            this.panelstatusir.Controls.Add(this.dtpir);
            this.panelstatusir.Controls.Add(this.lblair);
            this.panelstatusir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstatusir.Location = new System.Drawing.Point(8, 59);
            this.panelstatusir.Name = "panelstatusir";
            this.panelstatusir.Size = new System.Drawing.Size(188, 84);
            this.panelstatusir.TabIndex = 24;
            // 
            // dtpir
            // 
            this.dtpir.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpir.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpir.Location = new System.Drawing.Point(0, 27);
            this.dtpir.Name = "dtpir";
            this.dtpir.Size = new System.Drawing.Size(188, 27);
            this.dtpir.TabIndex = 5;
            this.dtpir.Visible = false;
            // 
            // lblair
            // 
            this.lblair.AutoSize = true;
            this.lblair.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblair.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblair.Location = new System.Drawing.Point(0, 0);
            this.lblair.Name = "lblair";
            this.lblair.Padding = new System.Windows.Forms.Padding(2);
            this.lblair.Size = new System.Drawing.Size(73, 27);
            this.lblair.TabIndex = 0;
            this.lblair.Text = "Alterado:";
            this.lblair.Visible = false;
            // 
            // txtir
            // 
            this.txtir.BackColor = System.Drawing.SystemColors.Control;
            this.txtir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.FormattingEnabled = true;
            this.txtir.Items.AddRange(new object[] {
            "Não Consultado",
            "Isento",
            "Declarado"});
            this.txtir.Location = new System.Drawing.Point(8, 31);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(188, 28);
            this.txtir.TabIndex = 20;
            this.txtir.SelectionChangeCommitted += new System.EventHandler(this.txtir_SelectionChangeCommitted);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Location = new System.Drawing.Point(8, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(188, 23);
            this.label23.TabIndex = 19;
            this.label23.Text = "Declaração IR:";
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Controls.Add(this.panelstatusfgts);
            this.panel8.Controls.Add(this.txtfgts);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(843, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(8);
            this.panel8.Size = new System.Drawing.Size(206, 147);
            this.panel8.TabIndex = 11;
            // 
            // panelstatusfgts
            // 
            this.panelstatusfgts.Controls.Add(this.dtpfgtscli);
            this.panelstatusfgts.Controls.Add(this.lblafgtscli);
            this.panelstatusfgts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstatusfgts.Location = new System.Drawing.Point(8, 59);
            this.panelstatusfgts.Name = "panelstatusfgts";
            this.panelstatusfgts.Size = new System.Drawing.Size(190, 84);
            this.panelstatusfgts.TabIndex = 24;
            // 
            // dtpfgtscli
            // 
            this.dtpfgtscli.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpfgtscli.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpfgtscli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfgtscli.Location = new System.Drawing.Point(0, 27);
            this.dtpfgtscli.Name = "dtpfgtscli";
            this.dtpfgtscli.Size = new System.Drawing.Size(190, 27);
            this.dtpfgtscli.TabIndex = 6;
            this.dtpfgtscli.Visible = false;
            // 
            // lblafgtscli
            // 
            this.lblafgtscli.AutoSize = true;
            this.lblafgtscli.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblafgtscli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafgtscli.Location = new System.Drawing.Point(0, 0);
            this.lblafgtscli.Name = "lblafgtscli";
            this.lblafgtscli.Padding = new System.Windows.Forms.Padding(2);
            this.lblafgtscli.Size = new System.Drawing.Size(73, 27);
            this.lblafgtscli.TabIndex = 0;
            this.lblafgtscli.Text = "Alterado:";
            this.lblafgtscli.Visible = false;
            // 
            // txtfgts
            // 
            this.txtfgts.BackColor = System.Drawing.SystemColors.Control;
            this.txtfgts.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfgts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfgts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtfgts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfgts.FormattingEnabled = true;
            this.txtfgts.Items.AddRange(new object[] {
            "Não Consultado",
            "Já subsidiado",
            "Não subsidiado"});
            this.txtfgts.Location = new System.Drawing.Point(8, 31);
            this.txtfgts.Name = "txtfgts";
            this.txtfgts.Size = new System.Drawing.Size(190, 28);
            this.txtfgts.TabIndex = 20;
            this.txtfgts.SelectionChangeCommitted += new System.EventHandler(this.txtfgts_SelectionChangeCommitted);
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Location = new System.Drawing.Point(8, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(190, 23);
            this.label24.TabIndex = 19;
            this.label24.Text = "FGTS:";
            // 
            // panelfunc
            // 
            this.panelfunc.Location = new System.Drawing.Point(308, 148);
            this.panelfunc.Name = "panelfunc";
            this.panelfunc.Size = new System.Drawing.Size(200, 100);
            this.panelfunc.TabIndex = 8;
            // 
            // groupBoxdadospessoais
            // 
            this.groupBoxdadospessoais.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxdadospessoais.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxdadospessoais.Location = new System.Drawing.Point(20, 20);
            this.groupBoxdadospessoais.Name = "groupBoxdadospessoais";
            this.groupBoxdadospessoais.Size = new System.Drawing.Size(1064, 202);
            this.groupBoxdadospessoais.TabIndex = 6;
            this.groupBoxdadospessoais.TabStop = false;
            this.groupBoxdadospessoais.Text = "Dados Pessoais:";
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
            this.tableLayoutPanel1.Controls.Add(this.txtagenciacliente, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label45, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtrg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.txtrenda, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 176);
            this.tableLayoutPanel1.TabIndex = 3;
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
            // txtagenciacliente
            // 
            this.txtagenciacliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtagenciacliente.Enabled = false;
            this.txtagenciacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacliente.Location = new System.Drawing.Point(373, 137);
            this.txtagenciacliente.Name = "txtagenciacliente";
            this.txtagenciacliente.Size = new System.Drawing.Size(159, 24);
            this.txtagenciacliente.TabIndex = 28;
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
            this.label1.Size = new System.Drawing.Size(352, 23);
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
            // txtrenda
            // 
            this.txtrenda.Enabled = false;
            this.txtrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrenda.Location = new System.Drawing.Point(3, 137);
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.Size = new System.Drawing.Size(216, 24);
            this.txtrenda.TabIndex = 32;
            this.txtrenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrenda_KeyPress);
            this.txtrenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrenda_KeyUp);
            this.txtrenda.Leave += new System.EventHandler(this.txtrenda_Leave);
            // 
            // tabvendedor
            // 
            this.tabvendedor.Controls.Add(this.panel20);
            this.tabvendedor.Location = new System.Drawing.Point(4, 32);
            this.tabvendedor.Name = "tabvendedor";
            this.tabvendedor.Padding = new System.Windows.Forms.Padding(15);
            this.tabvendedor.Size = new System.Drawing.Size(1104, 510);
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
            this.panel20.Size = new System.Drawing.Size(1074, 216);
            this.panel20.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 374F));
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
            this.tableLayoutPanel8.RowCount = 8;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1074, 191);
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
            this.tabimovel.Size = new System.Drawing.Size(1104, 510);
            this.tabimovel.TabIndex = 3;
            this.tabimovel.Text = "Dados do Imóvel";
            this.tabimovel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 291);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1064, 125);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(1058, 119);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imóvel:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1046, 87);
            this.tableLayoutPanel2.TabIndex = 21;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.comboBox_corretora);
            this.panel2.Controls.Add(this.lblcorretora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(342, 81);
            this.panel2.TabIndex = 28;
            // 
            // comboBox_corretora
            // 
            this.comboBox_corretora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_corretora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_corretora.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_corretora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_corretora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_corretora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_corretora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_corretora.FormattingEnabled = true;
            this.comboBox_corretora.Location = new System.Drawing.Point(3, 26);
            this.comboBox_corretora.Name = "comboBox_corretora";
            this.comboBox_corretora.Size = new System.Drawing.Size(336, 28);
            this.comboBox_corretora.TabIndex = 22;
            this.comboBox_corretora.SelectionChangeCommitted += new System.EventHandler(this.comboBox_corretora_SelectionChangeCommitted);
            this.comboBox_corretora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_corretora_MouseClick);
            // 
            // lblcorretora
            // 
            this.lblcorretora.AutoSize = true;
            this.lblcorretora.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcorretora.Location = new System.Drawing.Point(3, 3);
            this.lblcorretora.Name = "lblcorretora";
            this.lblcorretora.Size = new System.Drawing.Size(96, 23);
            this.lblcorretora.TabIndex = 4;
            this.lblcorretora.Text = "Construtora:";
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.comboBox_corretor);
            this.panel11.Controls.Add(this.lblcorretor);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(351, 3);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(3);
            this.panel11.Size = new System.Drawing.Size(342, 81);
            this.panel11.TabIndex = 29;
            // 
            // comboBox_corretor
            // 
            this.comboBox_corretor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_corretor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_corretor.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_corretor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_corretor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_corretor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_corretor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_corretor.FormattingEnabled = true;
            this.comboBox_corretor.Location = new System.Drawing.Point(3, 26);
            this.comboBox_corretor.Name = "comboBox_corretor";
            this.comboBox_corretor.Size = new System.Drawing.Size(336, 28);
            this.comboBox_corretor.TabIndex = 24;
            this.comboBox_corretor.SelectionChangeCommitted += new System.EventHandler(this.comboBox_corretor_SelectionChangeCommitted);
            this.comboBox_corretor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_corretor_MouseClick);
            // 
            // lblcorretor
            // 
            this.lblcorretor.AutoSize = true;
            this.lblcorretor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcorretor.Location = new System.Drawing.Point(3, 3);
            this.lblcorretor.Name = "lblcorretor";
            this.lblcorretor.Size = new System.Drawing.Size(71, 23);
            this.lblcorretor.TabIndex = 23;
            this.lblcorretor.Text = "Corretor:";
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.Controls.Add(this.comboBox_empreendimentos);
            this.panel12.Controls.Add(this.lblempresendimentos);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(699, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(3);
            this.panel12.Size = new System.Drawing.Size(344, 81);
            this.panel12.TabIndex = 30;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint_1);
            // 
            // comboBox_empreendimentos
            // 
            this.comboBox_empreendimentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_empreendimentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_empreendimentos.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_empreendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_empreendimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_empreendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_empreendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_empreendimentos.FormattingEnabled = true;
            this.comboBox_empreendimentos.Location = new System.Drawing.Point(3, 26);
            this.comboBox_empreendimentos.Name = "comboBox_empreendimentos";
            this.comboBox_empreendimentos.Size = new System.Drawing.Size(338, 28);
            this.comboBox_empreendimentos.TabIndex = 28;
            this.comboBox_empreendimentos.SelectionChangeCommitted += new System.EventHandler(this.comboBox_empreendimentos_SelectionChangeCommitted);
            this.comboBox_empreendimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_empreendimentos_MouseClick);
            // 
            // lblempresendimentos
            // 
            this.lblempresendimentos.AutoSize = true;
            this.lblempresendimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblempresendimentos.Location = new System.Drawing.Point(3, 3);
            this.lblempresendimentos.Name = "lblempresendimentos";
            this.lblempresendimentos.Size = new System.Drawing.Size(132, 23);
            this.lblempresendimentos.TabIndex = 27;
            this.lblempresendimentos.Text = "Empreendimento:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 179);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1064, 112);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1058, 106);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Caixa:";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Controls.Add(this.panel26, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1046, 74);
            this.tableLayoutPanel9.TabIndex = 10;
            // 
            // panel26
            // 
            this.panel26.AutoSize = true;
            this.panel26.Controls.Add(this.valorfinanciado);
            this.panel26.Controls.Add(this.label32);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(786, 3);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(3);
            this.panel26.Size = new System.Drawing.Size(257, 68);
            this.panel26.TabIndex = 10;
            // 
            // valorfinanciado
            // 
            this.valorfinanciado.Dock = System.Windows.Forms.DockStyle.Top;
            this.valorfinanciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorfinanciado.Location = new System.Drawing.Point(3, 24);
            this.valorfinanciado.Name = "valorfinanciado";
            this.valorfinanciado.Size = new System.Drawing.Size(251, 26);
            this.valorfinanciado.TabIndex = 22;
            this.valorfinanciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorfinanciado_KeyPress);
            this.valorfinanciado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valorfinanciado_KeyUp);
            this.valorfinanciado.Leave += new System.EventHandler(this.valorfinanciado_Leave);
            // 
            // label32
            // 
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Location = new System.Drawing.Point(3, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(251, 21);
            this.label32.TabIndex = 19;
            this.label32.Text = "Valor Financiado:";
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.Controls.Add(this.valorimovel);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(525, 3);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(3);
            this.panel10.Size = new System.Drawing.Size(255, 68);
            this.panel10.TabIndex = 9;
            // 
            // valorimovel
            // 
            this.valorimovel.Dock = System.Windows.Forms.DockStyle.Top;
            this.valorimovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorimovel.Location = new System.Drawing.Point(3, 24);
            this.valorimovel.Name = "valorimovel";
            this.valorimovel.Size = new System.Drawing.Size(249, 26);
            this.valorimovel.TabIndex = 20;
            this.valorimovel.TextChanged += new System.EventHandler(this.valorimovel_TextChanged);
            this.valorimovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorimovel_KeyPress);
            this.valorimovel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valorimovel_KeyUp);
            this.valorimovel.Leave += new System.EventHandler(this.valorimovel_Leave);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Valor do Imóvel:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.comboBox_programa);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(264, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(255, 68);
            this.panel3.TabIndex = 8;
            // 
            // comboBox_programa
            // 
            this.comboBox_programa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_programa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_programa.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_programa.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_programa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_programa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_programa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_programa.FormattingEnabled = true;
            this.comboBox_programa.Location = new System.Drawing.Point(3, 24);
            this.comboBox_programa.Name = "comboBox_programa";
            this.comboBox_programa.Size = new System.Drawing.Size(249, 28);
            this.comboBox_programa.TabIndex = 20;
            this.comboBox_programa.SelectionChangeCommitted += new System.EventHandler(this.comboBox_programa_SelectionChangeCommitted);
            this.comboBox_programa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_programa_MouseClick);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(249, 21);
            this.label15.TabIndex = 19;
            this.label15.Text = "Programa:";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.Controls.Add(this.comboBox_agencia);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(255, 68);
            this.panel9.TabIndex = 7;
            // 
            // comboBox_agencia
            // 
            this.comboBox_agencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_agencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_agencia.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_agencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_agencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_agencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_agencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_agencia.FormattingEnabled = true;
            this.comboBox_agencia.Location = new System.Drawing.Point(3, 26);
            this.comboBox_agencia.Name = "comboBox_agencia";
            this.comboBox_agencia.Size = new System.Drawing.Size(249, 28);
            this.comboBox_agencia.TabIndex = 20;
            this.comboBox_agencia.SelectionChangeCommitted += new System.EventHandler(this.comboBox_agencia_SelectionChangeCommitted);
            this.comboBox_agencia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_agencia_MouseClick);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(249, 23);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1064, 159);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutSituacao);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(1058, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situações:";
            // 
            // tableLayoutSituacao
            // 
            this.tableLayoutSituacao.ColumnCount = 6;
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutSituacao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutSituacao.Controls.Add(this.pnlpa, 5, 0);
            this.tableLayoutSituacao.Controls.Add(this.pnlsictd, 3, 0);
            this.tableLayoutSituacao.Controls.Add(this.pnlsiopi, 2, 0);
            this.tableLayoutSituacao.Controls.Add(this.pnlfgts, 4, 0);
            this.tableLayoutSituacao.Controls.Add(this.pnleng, 1, 0);
            this.tableLayoutSituacao.Controls.Add(this.pnlAnalise, 0, 0);
            this.tableLayoutSituacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSituacao.Location = new System.Drawing.Point(8, 28);
            this.tableLayoutSituacao.Name = "tableLayoutSituacao";
            this.tableLayoutSituacao.RowCount = 1;
            this.tableLayoutSituacao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSituacao.Size = new System.Drawing.Size(1042, 117);
            this.tableLayoutSituacao.TabIndex = 13;
            // 
            // pnlpa
            // 
            this.pnlpa.AutoSize = true;
            this.pnlpa.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlpa.Controls.Add(this.panel34);
            this.pnlpa.Controls.Add(this.comboBox_PA);
            this.pnlpa.Controls.Add(this.label44);
            this.pnlpa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpa.Location = new System.Drawing.Point(868, 3);
            this.pnlpa.Name = "pnlpa";
            this.pnlpa.Padding = new System.Windows.Forms.Padding(8);
            this.pnlpa.Size = new System.Drawing.Size(171, 111);
            this.pnlpa.TabIndex = 14;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.dtppa);
            this.panel34.Controls.Add(this.lblapa);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel34.Location = new System.Drawing.Point(8, 55);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(150, 48);
            this.panel34.TabIndex = 24;
            // 
            // dtppa
            // 
            this.dtppa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtppa.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtppa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtppa.Location = new System.Drawing.Point(0, 21);
            this.dtppa.Name = "dtppa";
            this.dtppa.Size = new System.Drawing.Size(150, 27);
            this.dtppa.TabIndex = 33;
            this.dtppa.Visible = false;
            // 
            // lblapa
            // 
            this.lblapa.AutoSize = true;
            this.lblapa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblapa.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapa.Location = new System.Drawing.Point(0, 0);
            this.lblapa.Name = "lblapa";
            this.lblapa.Padding = new System.Windows.Forms.Padding(2);
            this.lblapa.Size = new System.Drawing.Size(73, 27);
            this.lblapa.TabIndex = 0;
            this.lblapa.Text = "Alterado:";
            this.lblapa.Visible = false;
            // 
            // comboBox_PA
            // 
            this.comboBox_PA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_PA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_PA.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_PA.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_PA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PA.DropDownWidth = 160;
            this.comboBox_PA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_PA.FormattingEnabled = true;
            this.comboBox_PA.Items.AddRange(new object[] {
            "Não Consultado",
            "Conforme",
            "Inconforme"});
            this.comboBox_PA.Location = new System.Drawing.Point(8, 31);
            this.comboBox_PA.Name = "comboBox_PA";
            this.comboBox_PA.Size = new System.Drawing.Size(155, 24);
            this.comboBox_PA.TabIndex = 20;
            this.comboBox_PA.SelectionChangeCommitted += new System.EventHandler(this.comboBox_PA_SelectionChangeCommitted);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Top;
            this.label44.Location = new System.Drawing.Point(8, 8);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(32, 23);
            this.label44.TabIndex = 19;
            this.label44.Text = "PA:";
            // 
            // pnlsictd
            // 
            this.pnlsictd.AutoSize = true;
            this.pnlsictd.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlsictd.Controls.Add(this.panel30);
            this.pnlsictd.Controls.Add(this.comboBox_SICTD);
            this.pnlsictd.Controls.Add(this.label25);
            this.pnlsictd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlsictd.Location = new System.Drawing.Point(522, 3);
            this.pnlsictd.Name = "pnlsictd";
            this.pnlsictd.Padding = new System.Windows.Forms.Padding(8);
            this.pnlsictd.Size = new System.Drawing.Size(167, 111);
            this.pnlsictd.TabIndex = 11;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.dtpsictd);
            this.panel30.Controls.Add(this.lblasictd);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel30.Location = new System.Drawing.Point(8, 55);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(150, 48);
            this.panel30.TabIndex = 26;
            // 
            // dtpsictd
            // 
            this.dtpsictd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpsictd.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpsictd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsictd.Location = new System.Drawing.Point(0, 21);
            this.dtpsictd.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dtpsictd.Name = "dtpsictd";
            this.dtpsictd.Size = new System.Drawing.Size(150, 27);
            this.dtpsictd.TabIndex = 31;
            this.dtpsictd.Visible = false;
            // 
            // lblasictd
            // 
            this.lblasictd.AutoSize = true;
            this.lblasictd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblasictd.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasictd.Location = new System.Drawing.Point(0, 0);
            this.lblasictd.Name = "lblasictd";
            this.lblasictd.Padding = new System.Windows.Forms.Padding(2);
            this.lblasictd.Size = new System.Drawing.Size(73, 27);
            this.lblasictd.TabIndex = 0;
            this.lblasictd.Text = "Alterado:";
            this.lblasictd.Visible = false;
            // 
            // comboBox_SICTD
            // 
            this.comboBox_SICTD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_SICTD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_SICTD.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SICTD.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SICTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SICTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SICTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SICTD.FormattingEnabled = true;
            this.comboBox_SICTD.Items.AddRange(new object[] {
            "Não Consultado",
            "Enviado",
            "Não Enviado"});
            this.comboBox_SICTD.Location = new System.Drawing.Point(8, 31);
            this.comboBox_SICTD.Name = "comboBox_SICTD";
            this.comboBox_SICTD.Size = new System.Drawing.Size(151, 24);
            this.comboBox_SICTD.TabIndex = 20;
            this.comboBox_SICTD.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SICTD_SelectionChangeCommitted);
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(8, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 23);
            this.label25.TabIndex = 19;
            this.label25.Text = "SICTD:";
            // 
            // pnlsiopi
            // 
            this.pnlsiopi.AutoSize = true;
            this.pnlsiopi.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlsiopi.Controls.Add(this.panel29);
            this.pnlsiopi.Controls.Add(this.comboBox_SIOPI);
            this.pnlsiopi.Controls.Add(this.label13);
            this.pnlsiopi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlsiopi.Location = new System.Drawing.Point(349, 3);
            this.pnlsiopi.Name = "pnlsiopi";
            this.pnlsiopi.Padding = new System.Windows.Forms.Padding(8);
            this.pnlsiopi.Size = new System.Drawing.Size(167, 111);
            this.pnlsiopi.TabIndex = 10;
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.dtpsiopi);
            this.panel29.Controls.Add(this.lblasiopi);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel29.Location = new System.Drawing.Point(8, 55);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(150, 48);
            this.panel29.TabIndex = 25;
            // 
            // dtpsiopi
            // 
            this.dtpsiopi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpsiopi.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsiopi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpsiopi.Location = new System.Drawing.Point(0, 21);
            this.dtpsiopi.Name = "dtpsiopi";
            this.dtpsiopi.Size = new System.Drawing.Size(150, 27);
            this.dtpsiopi.TabIndex = 30;
            this.dtpsiopi.Visible = false;
            // 
            // lblasiopi
            // 
            this.lblasiopi.AutoSize = true;
            this.lblasiopi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblasiopi.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasiopi.Location = new System.Drawing.Point(0, 0);
            this.lblasiopi.Name = "lblasiopi";
            this.lblasiopi.Padding = new System.Windows.Forms.Padding(2);
            this.lblasiopi.Size = new System.Drawing.Size(73, 27);
            this.lblasiopi.TabIndex = 0;
            this.lblasiopi.Text = "Alterado:";
            this.lblasiopi.Visible = false;
            // 
            // comboBox_SIOPI
            // 
            this.comboBox_SIOPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_SIOPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_SIOPI.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SIOPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SIOPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SIOPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SIOPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SIOPI.FormattingEnabled = true;
            this.comboBox_SIOPI.Items.AddRange(new object[] {
            "Não Consultado",
            "Enviado",
            "Não Enviado"});
            this.comboBox_SIOPI.Location = new System.Drawing.Point(8, 31);
            this.comboBox_SIOPI.Name = "comboBox_SIOPI";
            this.comboBox_SIOPI.Size = new System.Drawing.Size(151, 24);
            this.comboBox_SIOPI.TabIndex = 20;
            this.comboBox_SIOPI.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SIOPI_SelectionChangeCommitted);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "SIOPI:";
            // 
            // pnlfgts
            // 
            this.pnlfgts.AutoSize = true;
            this.pnlfgts.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlfgts.Controls.Add(this.panel27);
            this.pnlfgts.Controls.Add(this.comboBox_saque);
            this.pnlfgts.Controls.Add(this.lblsaque);
            this.pnlfgts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfgts.Location = new System.Drawing.Point(695, 3);
            this.pnlfgts.Name = "pnlfgts";
            this.pnlfgts.Padding = new System.Windows.Forms.Padding(8);
            this.pnlfgts.Size = new System.Drawing.Size(167, 111);
            this.pnlfgts.TabIndex = 9;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.dtpfgts);
            this.panel27.Controls.Add(this.lblafgts);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel27.Location = new System.Drawing.Point(8, 55);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(150, 48);
            this.panel27.TabIndex = 24;
            // 
            // dtpfgts
            // 
            this.dtpfgts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpfgts.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpfgts.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfgts.Location = new System.Drawing.Point(0, 21);
            this.dtpfgts.Name = "dtpfgts";
            this.dtpfgts.Size = new System.Drawing.Size(150, 27);
            this.dtpfgts.TabIndex = 32;
            this.dtpfgts.Visible = false;
            // 
            // lblafgts
            // 
            this.lblafgts.AutoSize = true;
            this.lblafgts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblafgts.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafgts.Location = new System.Drawing.Point(0, 0);
            this.lblafgts.Name = "lblafgts";
            this.lblafgts.Padding = new System.Windows.Forms.Padding(2);
            this.lblafgts.Size = new System.Drawing.Size(73, 27);
            this.lblafgts.TabIndex = 0;
            this.lblafgts.Text = "Alterado:";
            this.lblafgts.Visible = false;
            // 
            // comboBox_saque
            // 
            this.comboBox_saque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_saque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_saque.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_saque.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_saque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_saque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_saque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_saque.FormattingEnabled = true;
            this.comboBox_saque.Items.AddRange(new object[] {
            "Não Consultado",
            "Total",
            "Parcial",
            "Não Usar"});
            this.comboBox_saque.Location = new System.Drawing.Point(8, 31);
            this.comboBox_saque.Name = "comboBox_saque";
            this.comboBox_saque.Size = new System.Drawing.Size(151, 24);
            this.comboBox_saque.TabIndex = 20;
            this.comboBox_saque.SelectionChangeCommitted += new System.EventHandler(this.comboBox_saque_SelectionChangeCommitted);
            // 
            // lblsaque
            // 
            this.lblsaque.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsaque.Location = new System.Drawing.Point(8, 8);
            this.lblsaque.Name = "lblsaque";
            this.lblsaque.Size = new System.Drawing.Size(151, 23);
            this.lblsaque.TabIndex = 19;
            this.lblsaque.Text = "Saque FGTS:";
            // 
            // pnleng
            // 
            this.pnleng.AutoSize = true;
            this.pnleng.BackColor = System.Drawing.Color.Gainsboro;
            this.pnleng.Controls.Add(this.panel28);
            this.pnleng.Controls.Add(this.comboBox_statuseng);
            this.pnleng.Controls.Add(this.label28);
            this.pnleng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnleng.Location = new System.Drawing.Point(176, 3);
            this.pnleng.Name = "pnleng";
            this.pnleng.Padding = new System.Windows.Forms.Padding(8);
            this.pnleng.Size = new System.Drawing.Size(167, 111);
            this.pnleng.TabIndex = 8;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.dtpeng);
            this.panel28.Controls.Add(this.lblaeng);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel28.Location = new System.Drawing.Point(8, 55);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(150, 48);
            this.panel28.TabIndex = 23;
            // 
            // dtpeng
            // 
            this.dtpeng.CustomFormat = "";
            this.dtpeng.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpeng.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpeng.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpeng.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpeng.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpeng.Location = new System.Drawing.Point(0, 21);
            this.dtpeng.Margin = new System.Windows.Forms.Padding(5);
            this.dtpeng.Name = "dtpeng";
            this.dtpeng.Size = new System.Drawing.Size(150, 27);
            this.dtpeng.TabIndex = 29;
            this.dtpeng.Visible = false;
            // 
            // lblaeng
            // 
            this.lblaeng.AutoSize = true;
            this.lblaeng.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblaeng.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaeng.Location = new System.Drawing.Point(0, 0);
            this.lblaeng.Name = "lblaeng";
            this.lblaeng.Padding = new System.Windows.Forms.Padding(2);
            this.lblaeng.Size = new System.Drawing.Size(73, 27);
            this.lblaeng.TabIndex = 0;
            this.lblaeng.Text = "Alterado:";
            this.lblaeng.Visible = false;
            // 
            // comboBox_statuseng
            // 
            this.comboBox_statuseng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_statuseng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_statuseng.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_statuseng.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_statuseng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statuseng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_statuseng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_statuseng.FormattingEnabled = true;
            this.comboBox_statuseng.Items.AddRange(new object[] {
            "Não Consultado",
            "Aguardando Pagamento",
            "Aprovado Abaixo",
            "Aprovado Normal",
            "Contestação",
            "Solicitado"});
            this.comboBox_statuseng.Location = new System.Drawing.Point(8, 31);
            this.comboBox_statuseng.Name = "comboBox_statuseng";
            this.comboBox_statuseng.Size = new System.Drawing.Size(151, 24);
            this.comboBox_statuseng.TabIndex = 20;
            this.comboBox_statuseng.SelectionChangeCommitted += new System.EventHandler(this.comboBox_statuseng_SelectionChangeCommitted);
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Location = new System.Drawing.Point(8, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 23);
            this.label28.TabIndex = 19;
            this.label28.Text = "Status Eng.:";
            // 
            // pnlAnalise
            // 
            this.pnlAnalise.AutoSize = true;
            this.pnlAnalise.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAnalise.Controls.Add(this.paneldataanalise);
            this.pnlAnalise.Controls.Add(this.comboBox_analise);
            this.pnlAnalise.Controls.Add(this.label29);
            this.pnlAnalise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnalise.Location = new System.Drawing.Point(3, 3);
            this.pnlAnalise.Name = "pnlAnalise";
            this.pnlAnalise.Padding = new System.Windows.Forms.Padding(8);
            this.pnlAnalise.Size = new System.Drawing.Size(167, 111);
            this.pnlAnalise.TabIndex = 7;
            // 
            // paneldataanalise
            // 
            this.paneldataanalise.Controls.Add(this.dtpanalise);
            this.paneldataanalise.Controls.Add(this.lblaanalise);
            this.paneldataanalise.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneldataanalise.Location = new System.Drawing.Point(8, 55);
            this.paneldataanalise.Name = "paneldataanalise";
            this.paneldataanalise.Size = new System.Drawing.Size(150, 48);
            this.paneldataanalise.TabIndex = 22;
            // 
            // dtpanalise
            // 
            this.dtpanalise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpanalise.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpanalise.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpanalise.Location = new System.Drawing.Point(0, 21);
            this.dtpanalise.Name = "dtpanalise";
            this.dtpanalise.Size = new System.Drawing.Size(150, 27);
            this.dtpanalise.TabIndex = 1;
            this.dtpanalise.Visible = false;
            // 
            // lblaanalise
            // 
            this.lblaanalise.AutoSize = true;
            this.lblaanalise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblaanalise.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaanalise.Location = new System.Drawing.Point(0, 0);
            this.lblaanalise.Name = "lblaanalise";
            this.lblaanalise.Padding = new System.Windows.Forms.Padding(2);
            this.lblaanalise.Size = new System.Drawing.Size(73, 27);
            this.lblaanalise.TabIndex = 0;
            this.lblaanalise.Text = "Alterado:";
            this.lblaanalise.Visible = false;
            // 
            // comboBox_analise
            // 
            this.comboBox_analise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_analise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_analise.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_analise.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_analise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_analise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.comboBox_analise.Location = new System.Drawing.Point(8, 31);
            this.comboBox_analise.Name = "comboBox_analise";
            this.comboBox_analise.Size = new System.Drawing.Size(151, 24);
            this.comboBox_analise.TabIndex = 20;
            this.comboBox_analise.SelectionChangeCommitted += new System.EventHandler(this.comboBox_analise_SelectionChangeCommitted);
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(8, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 23);
            this.label29.TabIndex = 19;
            this.label29.Text = "Status Análise:";
            // 
            // tabcartorio
            // 
            this.tabcartorio.Controls.Add(this.tableLayoutPanel6);
            this.tabcartorio.Controls.Add(this.groupBoxcartorio);
            this.tabcartorio.Location = new System.Drawing.Point(4, 32);
            this.tabcartorio.Name = "tabcartorio";
            this.tabcartorio.Padding = new System.Windows.Forms.Padding(20);
            this.tabcartorio.Size = new System.Drawing.Size(1104, 510);
            this.tabcartorio.TabIndex = 1;
            this.tabcartorio.Text = "Cartório";
            this.tabcartorio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85185F));
            this.tableLayoutPanel6.Controls.Add(this.groupBoxsituacao, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(20, 132);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1064, 181);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // groupBoxsituacao
            // 
            this.groupBoxsituacao.Controls.Add(this.pnlsituacao);
            this.groupBoxsituacao.Controls.Add(this.panel16);
            this.groupBoxsituacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxsituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.groupBoxsituacao.Location = new System.Drawing.Point(3, 3);
            this.groupBoxsituacao.Name = "groupBoxsituacao";
            this.groupBoxsituacao.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxsituacao.Size = new System.Drawing.Size(1058, 145);
            this.groupBoxsituacao.TabIndex = 6;
            this.groupBoxsituacao.TabStop = false;
            this.groupBoxsituacao.Text = "Situação:";
            // 
            // pnlsituacao
            // 
            this.pnlsituacao.Controls.Add(this.panel21);
            this.pnlsituacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlsituacao.Location = new System.Drawing.Point(340, 26);
            this.pnlsituacao.Name = "pnlsituacao";
            this.pnlsituacao.Padding = new System.Windows.Forms.Padding(3);
            this.pnlsituacao.Size = new System.Drawing.Size(534, 113);
            this.pnlsituacao.TabIndex = 7;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.comboBox_statuscartorio);
            this.panel21.Controls.Add(this.lblstatuscart);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(3, 3);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(3);
            this.panel21.Size = new System.Drawing.Size(334, 107);
            this.panel21.TabIndex = 7;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.dtpcartorio);
            this.panel22.Controls.Add(this.lblacartorio);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel22.Location = new System.Drawing.Point(3, 50);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(160, 54);
            this.panel22.TabIndex = 23;
            // 
            // dtpcartorio
            // 
            this.dtpcartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpcartorio.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.dtpcartorio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcartorio.Location = new System.Drawing.Point(0, 27);
            this.dtpcartorio.Name = "dtpcartorio";
            this.dtpcartorio.Size = new System.Drawing.Size(160, 27);
            this.dtpcartorio.TabIndex = 3;
            this.dtpcartorio.Visible = false;
            // 
            // lblacartorio
            // 
            this.lblacartorio.AutoSize = true;
            this.lblacartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblacartorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacartorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblacartorio.Location = new System.Drawing.Point(0, 0);
            this.lblacartorio.Name = "lblacartorio";
            this.lblacartorio.Padding = new System.Windows.Forms.Padding(2);
            this.lblacartorio.Size = new System.Drawing.Size(73, 27);
            this.lblacartorio.TabIndex = 0;
            this.lblacartorio.Text = "Alterado:";
            // 
            // comboBox_statuscartorio
            // 
            this.comboBox_statuscartorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_statuscartorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_statuscartorio.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_statuscartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_statuscartorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statuscartorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_statuscartorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_statuscartorio.FormattingEnabled = true;
            this.comboBox_statuscartorio.Items.AddRange(new object[] {
            "Entregue",
            "A retirar",
            "Aguardando",
            "Retirado"});
            this.comboBox_statuscartorio.Location = new System.Drawing.Point(3, 26);
            this.comboBox_statuscartorio.Name = "comboBox_statuscartorio";
            this.comboBox_statuscartorio.Size = new System.Drawing.Size(328, 24);
            this.comboBox_statuscartorio.TabIndex = 20;
            this.comboBox_statuscartorio.SelectionChangeCommitted += new System.EventHandler(this.comboBox_statuscartorio_SelectionChangeCommitted);
            // 
            // lblstatuscart
            // 
            this.lblstatuscart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstatuscart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblstatuscart.Location = new System.Drawing.Point(3, 3);
            this.lblstatuscart.Name = "lblstatuscart";
            this.lblstatuscart.Size = new System.Drawing.Size(328, 23);
            this.lblstatuscart.TabIndex = 19;
            this.lblstatuscart.Text = "Status:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel19);
            this.panel16.Controls.Add(this.lbldescricart);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(6, 26);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(3);
            this.panel16.Size = new System.Drawing.Size(334, 113);
            this.panel16.TabIndex = 6;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.lblenderecocartorio);
            this.panel19.Controls.Add(this.lblnomecartorio);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 26);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(328, 84);
            this.panel19.TabIndex = 25;
            // 
            // lblenderecocartorio
            // 
            this.lblenderecocartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblenderecocartorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenderecocartorio.Location = new System.Drawing.Point(0, 27);
            this.lblenderecocartorio.Name = "lblenderecocartorio";
            this.lblenderecocartorio.Padding = new System.Windows.Forms.Padding(2);
            this.lblenderecocartorio.Size = new System.Drawing.Size(328, 27);
            this.lblenderecocartorio.TabIndex = 26;
            this.lblenderecocartorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnomecartorio
            // 
            this.lblnomecartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblnomecartorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecartorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnomecartorio.Location = new System.Drawing.Point(0, 0);
            this.lblnomecartorio.Name = "lblnomecartorio";
            this.lblnomecartorio.Padding = new System.Windows.Forms.Padding(2);
            this.lblnomecartorio.Size = new System.Drawing.Size(328, 27);
            this.lblnomecartorio.TabIndex = 25;
            this.lblnomecartorio.Text = "Selecione o Cartório";
            this.lblnomecartorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldescricart
            // 
            this.lbldescricart.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldescricart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldescricart.Location = new System.Drawing.Point(3, 3);
            this.lbldescricart.Name = "lbldescricart";
            this.lbldescricart.Size = new System.Drawing.Size(328, 23);
            this.lbldescricart.TabIndex = 19;
            this.lbldescricart.Text = "Descrição Cartório:";
            // 
            // groupBoxcartorio
            // 
            this.groupBoxcartorio.Controls.Add(this.pnlenviar);
            this.groupBoxcartorio.Controls.Add(this.pnlnome);
            this.groupBoxcartorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxcartorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.groupBoxcartorio.Location = new System.Drawing.Point(20, 20);
            this.groupBoxcartorio.Name = "groupBoxcartorio";
            this.groupBoxcartorio.Size = new System.Drawing.Size(1064, 112);
            this.groupBoxcartorio.TabIndex = 18;
            this.groupBoxcartorio.TabStop = false;
            this.groupBoxcartorio.Text = "Cartório";
            // 
            // pnlenviar
            // 
            this.pnlenviar.Controls.Add(this.btnenviar);
            this.pnlenviar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlenviar.Location = new System.Drawing.Point(373, 23);
            this.pnlenviar.Name = "pnlenviar";
            this.pnlenviar.Size = new System.Drawing.Size(200, 86);
            this.pnlenviar.TabIndex = 1;
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnenviar.FlatAppearance.BorderSize = 0;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnenviar.Location = new System.Drawing.Point(10, 23);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(104, 32);
            this.btnenviar.TabIndex = 4;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // pnlnome
            // 
            this.pnlnome.Controls.Add(this.comboBox_nomecartorio);
            this.pnlnome.Controls.Add(this.label14);
            this.pnlnome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlnome.Location = new System.Drawing.Point(3, 23);
            this.pnlnome.Name = "pnlnome";
            this.pnlnome.Padding = new System.Windows.Forms.Padding(5);
            this.pnlnome.Size = new System.Drawing.Size(370, 86);
            this.pnlnome.TabIndex = 0;
            // 
            // comboBox_nomecartorio
            // 
            this.comboBox_nomecartorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_nomecartorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_nomecartorio.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_nomecartorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_nomecartorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nomecartorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_nomecartorio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nomecartorio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox_nomecartorio.FormattingEnabled = true;
            this.comboBox_nomecartorio.Location = new System.Drawing.Point(5, 28);
            this.comboBox_nomecartorio.Name = "comboBox_nomecartorio";
            this.comboBox_nomecartorio.Size = new System.Drawing.Size(360, 31);
            this.comboBox_nomecartorio.TabIndex = 16;
            this.comboBox_nomecartorio.SelectionChangeCommitted += new System.EventHandler(this.comboBox_nomecartorio_SelectionChangeCommitted);
            this.comboBox_nomecartorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_nomecartorio_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(5, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 23);
            this.label14.TabIndex = 15;
            this.label14.Text = "Selecionar Cartório:";
            // 
            // tabdoc
            // 
            this.tabdoc.Controls.Add(this.groupBox7);
            this.tabdoc.Controls.Add(this.tableLayoutPanel7);
            this.tabdoc.Location = new System.Drawing.Point(4, 32);
            this.tabdoc.Name = "tabdoc";
            this.tabdoc.Padding = new System.Windows.Forms.Padding(20);
            this.tabdoc.Size = new System.Drawing.Size(1104, 510);
            this.tabdoc.TabIndex = 2;
            this.tabdoc.Text = "Documentação";
            this.tabdoc.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.dataGridView_Arquivos);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(20, 238);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(1064, 224);
            this.groupBox7.TabIndex = 28;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Anexos:";
            // 
            // dataGridView_Arquivos
            // 
            this.dataGridView_Arquivos.AllowUserToAddRows = false;
            this.dataGridView_Arquivos.AllowUserToDeleteRows = false;
            this.dataGridView_Arquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Arquivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Arquivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Arquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Arquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Tipo,
            this.descricao,
            this.data,
            this.status,
            this.apagar,
            this.Baixar,
            this.ver,
            this.Extensao});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Arquivos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Arquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Arquivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Arquivos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Arquivos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_Arquivos.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_Arquivos.MultiSelect = false;
            this.dataGridView_Arquivos.Name = "dataGridView_Arquivos";
            this.dataGridView_Arquivos.RowHeadersVisible = false;
            this.dataGridView_Arquivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_Arquivos.Size = new System.Drawing.Size(1052, 192);
            this.dataGridView_Arquivos.TabIndex = 0;
            this.dataGridView_Arquivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Arquivos_CellClick);
            this.dataGridView_Arquivos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_Arquivos_CellPainting);
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Numero.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "0";
            this.Numero.DefaultCellStyle = dataGridViewCellStyle1;
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Tipo.DataPropertyName = "Tipo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 250;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 250;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 250;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.data.DataPropertyName = "Data";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data.DefaultCellStyle = dataGridViewCellStyle4;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.DataPropertyName = "Status";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle5;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // apagar
            // 
            this.apagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            this.apagar.DefaultCellStyle = dataGridViewCellStyle6;
            this.apagar.FillWeight = 30F;
            this.apagar.HeaderText = "Excluir";
            this.apagar.MinimumWidth = 60;
            this.apagar.Name = "apagar";
            this.apagar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.apagar.Width = 62;
            // 
            // Baixar
            // 
            this.Baixar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
            this.Baixar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Baixar.FillWeight = 30F;
            this.Baixar.HeaderText = "Baixar";
            this.Baixar.MinimumWidth = 60;
            this.Baixar.Name = "Baixar";
            this.Baixar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Baixar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Baixar.Width = 62;
            // 
            // ver
            // 
            this.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ver.FillWeight = 30F;
            this.ver.HeaderText = "Ver";
            this.ver.MinimumWidth = 60;
            this.ver.Name = "ver";
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ver.Width = 62;
            // 
            // Extensao
            // 
            this.Extensao.DataPropertyName = "Extensao";
            this.Extensao.HeaderText = "Arquivo";
            this.Extensao.Name = "Extensao";
            this.Extensao.Width = 84;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1064, 218);
            this.tableLayoutPanel7.TabIndex = 24;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel10);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1058, 212);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Anexar";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 6;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 496F));
            this.tableLayoutPanel10.Controls.Add(this.comboBox_tipoProcesso, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.btnAnexar, 5, 3);
            this.tableLayoutPanel10.Controls.Add(this.comboBox_tipoArquivo, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.btnSelecionarArquivos, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.txtArquivo, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.txtdescricao, 0, 5);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 6;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1052, 186);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // comboBox_tipoProcesso
            // 
            this.comboBox_tipoProcesso.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_tipoProcesso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tipoProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tipoProcesso.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipoProcesso.FormattingEnabled = true;
            this.comboBox_tipoProcesso.Location = new System.Drawing.Point(3, 87);
            this.comboBox_tipoProcesso.Name = "comboBox_tipoProcesso";
            this.comboBox_tipoProcesso.Size = new System.Drawing.Size(229, 31);
            this.comboBox_tipoProcesso.TabIndex = 37;
            this.comboBox_tipoProcesso.SelectionChangeCommitted += new System.EventHandler(this.comboBox_tipoProcesso_SelectionChangeCommitted);
            this.comboBox_tipoProcesso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_tipoProcesso_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo de Arquivo:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Observação:";
            this.label4.Visible = false;
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnAnexar.FlatAppearance.BorderSize = 0;
            this.btnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexar.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnexar.Location = new System.Drawing.Point(559, 87);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(109, 32);
            this.btnAnexar.TabIndex = 33;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // comboBox_tipoArquivo
            // 
            this.comboBox_tipoArquivo.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel10.SetColumnSpan(this.comboBox_tipoArquivo, 3);
            this.comboBox_tipoArquivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_tipoArquivo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipoArquivo.FormattingEnabled = true;
            this.comboBox_tipoArquivo.Location = new System.Drawing.Point(238, 87);
            this.comboBox_tipoArquivo.Name = "comboBox_tipoArquivo";
            this.comboBox_tipoArquivo.Size = new System.Drawing.Size(315, 31);
            this.comboBox_tipoArquivo.TabIndex = 32;
            this.comboBox_tipoArquivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_tipoArquivo_MouseClick);
            // 
            // btnSelecionarArquivos
            // 
            this.btnSelecionarArquivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnSelecionarArquivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionarArquivos.FlatAppearance.BorderSize = 0;
            this.btnSelecionarArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelecionarArquivos.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarArquivos.Image")));
            this.btnSelecionarArquivos.Location = new System.Drawing.Point(403, 26);
            this.btnSelecionarArquivos.Name = "btnSelecionarArquivos";
            this.btnSelecionarArquivos.Size = new System.Drawing.Size(44, 32);
            this.btnSelecionarArquivos.TabIndex = 18;
            this.btnSelecionarArquivos.UseVisualStyleBackColor = false;
            this.btnSelecionarArquivos.Click += new System.EventHandler(this.btnSelecionarArquivos_Click);
            // 
            // txtArquivo
            // 
            this.tableLayoutPanel10.SetColumnSpan(this.txtArquivo, 2);
            this.txtArquivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArquivo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(3, 26);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(394, 27);
            this.txtArquivo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Arquivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tipo de Processo:";
            // 
            // txtdescricao
            // 
            this.tableLayoutPanel10.SetColumnSpan(this.txtdescricao, 3);
            this.txtdescricao.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(3, 145);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(352, 30);
            this.txtdescricao.TabIndex = 35;
            this.txtdescricao.Visible = false;
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
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.dSClientesBindingSource;
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
            // panelfuncresp
            // 
            this.panelfuncresp.Controls.Add(this.lbldata);
            this.panelfuncresp.Controls.Add(this.lbldatalbl);
            this.panelfuncresp.Controls.Add(this.lblfunc);
            this.panelfuncresp.Controls.Add(this.lblfuncresponsavel);
            this.panelfuncresp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfuncresp.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelfuncresp.Location = new System.Drawing.Point(0, 560);
            this.panelfuncresp.Name = "panelfuncresp";
            this.panelfuncresp.Padding = new System.Windows.Forms.Padding(10);
            this.panelfuncresp.Size = new System.Drawing.Size(1112, 43);
            this.panelfuncresp.TabIndex = 15;
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbldata.Location = new System.Drawing.Point(137, 10);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(42, 23);
            this.lbldata.TabIndex = 13;
            this.lbldata.Text = "Data";
            // 
            // lbldatalbl
            // 
            this.lbldatalbl.AutoSize = true;
            this.lbldatalbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbldatalbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbldatalbl.Location = new System.Drawing.Point(10, 10);
            this.lbldatalbl.Name = "lbldatalbl";
            this.lbldatalbl.Size = new System.Drawing.Size(127, 23);
            this.lbldatalbl.TabIndex = 12;
            this.lbldatalbl.Text = "Data do Processo:";
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblfunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lblfunc.Location = new System.Drawing.Point(761, 10);
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
            this.lblfuncresponsavel.Location = new System.Drawing.Point(955, 10);
            this.lblfuncresponsavel.Name = "lblfuncresponsavel";
            this.lblfuncresponsavel.Size = new System.Drawing.Size(147, 23);
            this.lblfuncresponsavel.TabIndex = 9;
            this.lblfuncresponsavel.Text = "Nome Funcionário(a)";
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "pdf";
            this.ofd1.FileName = "openFileDialog";
            this.ofd1.Title = "Localizar Arquivos";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            // 
            // processosTableAdapter
            // 
            this.processosTableAdapter.ClearBeforeFill = true;
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
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.dS_Clientes;
            // 
            // Form_Dados_Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1112, 655);
            this.Controls.Add(this.panelfuncresp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Processos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Processo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dados_Documentos_Load);
            this.Shown += new System.EventHandler(this.Form_Dados_Processos_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Dados_Documentos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.processosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Documentos)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabcliente.ResumeLayout(false);
            this.grpbSituacao.ResumeLayout(false);
            this.tableLayoutsitua.ResumeLayout(false);
            this.tableLayoutsitua.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelstatuscpf.ResumeLayout(false);
            this.panelstatuscpf.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelstatusciweb.ResumeLayout(false);
            this.panelstatusciweb.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelstatuscadmut.ResumeLayout(false);
            this.panelstatuscadmut.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panelstatusir.ResumeLayout(false);
            this.panelstatusir.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panelstatusfgts.ResumeLayout(false);
            this.panelstatusfgts.PerformLayout();
            this.groupBoxdadospessoais.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabvendedor.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabimovel.ResumeLayout(false);
            this.tabimovel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutSituacao.ResumeLayout(false);
            this.tableLayoutSituacao.PerformLayout();
            this.pnlpa.ResumeLayout(false);
            this.pnlpa.PerformLayout();
            this.panel34.ResumeLayout(false);
            this.panel34.PerformLayout();
            this.pnlsictd.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.pnlsiopi.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.pnlfgts.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.pnleng.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.pnlAnalise.ResumeLayout(false);
            this.paneldataanalise.ResumeLayout(false);
            this.paneldataanalise.PerformLayout();
            this.tabcartorio.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBoxsituacao.ResumeLayout(false);
            this.pnlsituacao.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.groupBoxcartorio.ResumeLayout(false);
            this.pnlenviar.ResumeLayout(false);
            this.pnlnome.ResumeLayout(false);
            this.pnlnome.PerformLayout();
            this.tabdoc.ResumeLayout(false);
            this.tabdoc.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Arquivos)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            this.panelfuncresp.ResumeLayout(false);
            this.panelfuncresp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnsalvardoc;
        private DAL.DS_Documentos dS_Documentos;
        private System.Windows.Forms.BindingSource dSDocumentosBindingSource;
        private System.Windows.Forms.BindingSource processosBindingSource;
        private DAL.DS_Clientes dS_Clientes;
        private System.Windows.Forms.BindingSource dSClientesBindingSource;
        //private DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        //private DAL.DS_Funcionario dS_Funcionario;
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
        private System.Windows.Forms.TabPage tabcartorio;
        private System.Windows.Forms.TabPage tabdoc;
        private System.Windows.Forms.TabPage tabimovel;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DAL.DS_ClientesTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        //private System.Windows.Forms.BindingSource statusCiwebBindingSource;
        //private System.Windows.Forms.BindingSource statusCadmutBindingSource;
        //private System.Windows.Forms.BindingSource statusFGTSBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBoxsituacao;
        private System.Windows.Forms.Panel pnlsituacao;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbldescricart;
        private System.Windows.Forms.GroupBox groupBoxcartorio;
        private System.Windows.Forms.Panel pnlenviar;
        public System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Panel pnlnome;
        private System.Windows.Forms.ComboBox comboBox_nomecartorio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
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
        private System.Windows.Forms.TextBox txtcontavendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textnomevendedor;
        private System.Windows.Forms.Label lblnumeroprocesso;
        private System.Windows.Forms.Panel panelfuncresp;
        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lblfuncresponsavel;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lbldatalbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSituacao;
        private System.Windows.Forms.Panel pnlpa;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Label lblapa;
        private System.Windows.Forms.ComboBox comboBox_PA;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel pnlsictd;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblasictd;
        private System.Windows.Forms.ComboBox comboBox_SICTD;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel pnlsiopi;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label lblasiopi;
        private System.Windows.Forms.ComboBox comboBox_SIOPI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlfgts;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label lblafgts;
        private System.Windows.Forms.ComboBox comboBox_saque;
        private System.Windows.Forms.Label lblsaque;
        private System.Windows.Forms.Panel pnleng;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label lblaeng;
        private System.Windows.Forms.ComboBox comboBox_statuseng;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel pnlAnalise;
        private System.Windows.Forms.Panel paneldataanalise;
        private System.Windows.Forms.Label lblaanalise;
        private System.Windows.Forms.ComboBox comboBox_analise;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox grpbSituacao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutsitua;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelstatuscpf;
        private System.Windows.Forms.Label lblacpf;
        private System.Windows.Forms.ComboBox txtStatusCPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelstatusciweb;
        private System.Windows.Forms.Label lblaciweb;
        private System.Windows.Forms.ComboBox txtciweb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelstatuscadmut;
        private System.Windows.Forms.Label lblacadmut;
        private System.Windows.Forms.ComboBox txtcadmut;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelstatusir;
        private System.Windows.Forms.Label lblair;
        private System.Windows.Forms.ComboBox txtir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelstatusfgts;
        private System.Windows.Forms.Label lblafgtscli;
        private System.Windows.Forms.ComboBox txtfgts;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelfunc;
        private System.Windows.Forms.GroupBox groupBoxdadospessoais;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ComboBoxClient;
        private System.Windows.Forms.TextBox txtcontacliente;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtagenciacliente;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox valorfinanciado;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox valorimovel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_programa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox_agencia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_corretora;
        private System.Windows.Forms.Label lblcorretora;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBox_corretor;
        private System.Windows.Forms.Label lblcorretor;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox comboBox_empreendimentos;
        private System.Windows.Forms.Label lblempresendimentos;
        private System.Windows.Forms.TextBox txtrenda;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label lblacartorio;
        private System.Windows.Forms.ComboBox comboBox_statuscartorio;
        private System.Windows.Forms.Label lblstatuscart;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblenderecocartorio;
        private System.Windows.Forms.Label lblnomecartorio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        public System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.ComboBox comboBox_tipoArquivo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSelecionarArquivos;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.DateTimePicker dtppa;
        private System.Windows.Forms.DateTimePicker dtpsictd;
        private System.Windows.Forms.DateTimePicker dtpsiopi;
        private System.Windows.Forms.DateTimePicker dtpfgts;
        private System.Windows.Forms.DateTimePicker dtpeng;
        private System.Windows.Forms.DateTimePicker dtpanalise;
        private System.Windows.Forms.DateTimePicker dtpcpf;
        private System.Windows.Forms.DateTimePicker dtpciweb;
        private System.Windows.Forms.DateTimePicker dtpcadmut;
        private System.Windows.Forms.DateTimePicker dtpir;
        private System.Windows.Forms.DateTimePicker dtpfgtscli;
        private System.Windows.Forms.DateTimePicker dtpcartorio;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridView_Arquivos;
        private System.Windows.Forms.ComboBox comboBox_tipoProcesso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn apagar;
        private System.Windows.Forms.DataGridViewButtonColumn Baixar;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensao;
        //private System.Windows.Forms.BindingSource corretoraBindingSource;
        //private System.Windows.Forms.BindingSource corretoresBindingSource;
        //private System.Windows.Forms.BindingSource vendedorBindingSource;
        //private System.Windows.Forms.BindingSource empreendimentosBindingSource;
        //private System.Windows.Forms.BindingSource statusCartorioBindingSource;
        //private System.Windows.Forms.BindingSource cartorioBindingSource;
    }
}