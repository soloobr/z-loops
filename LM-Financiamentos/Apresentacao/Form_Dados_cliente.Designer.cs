
using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Windows;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_cliente));
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
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
            this.txtStatusCPF = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrendacli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Feminino = new System.Windows.Forms.RadioButton();
            this.checkBox_Masculino = new System.Windows.Forms.RadioButton();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtnasc = new System.Windows.Forms.MaskedTextBox();
            this.txtnomecli = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.Foto = new System.Windows.Forms.TabPage();
            this.btn_limpar_foto = new System.Windows.Forms.Button();
            this.btn_add_foto = new System.Windows.Forms.Button();
            this.img_foto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabcliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Foto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).BeginInit();
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
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 508);
            this.panel2.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabcliente);
            this.tabControl.Controls.Add(this.Foto);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(979, 508);
            this.tabControl.TabIndex = 15;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.groupBox1);
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Location = new System.Drawing.Point(4, 32);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(971, 472);
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
            this.groupBox1.Location = new System.Drawing.Point(20, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(931, 106);
            this.groupBox1.TabIndex = 52;
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
            this.panel8.Size = new System.Drawing.Size(183, 74);
            this.panel8.TabIndex = 10;
            // 
            // txtfgts
            // 
            this.txtfgts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfgts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtfgts.DisplayMember = "Descricao";
            this.txtfgts.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtfgts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtfgts.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfgts.FormattingEnabled = true;
            this.txtfgts.Location = new System.Drawing.Point(3, 26);
            this.txtfgts.Name = "txtfgts";
            this.txtfgts.Size = new System.Drawing.Size(177, 31);
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
            this.panel7.Size = new System.Drawing.Size(183, 74);
            this.panel7.TabIndex = 9;
            // 
            // txtir
            // 
            this.txtir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtir.DisplayMember = "Descricao";
            this.txtir.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtir.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtir.FormattingEnabled = true;
            this.txtir.Location = new System.Drawing.Point(3, 26);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(177, 31);
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
            this.panel6.Size = new System.Drawing.Size(183, 74);
            this.panel6.TabIndex = 8;
            // 
            // txtcadmut
            // 
            this.txtcadmut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcadmut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcadmut.DisplayMember = "Descricao";
            this.txtcadmut.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcadmut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtcadmut.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadmut.FormattingEnabled = true;
            this.txtcadmut.Location = new System.Drawing.Point(3, 26);
            this.txtcadmut.Name = "txtcadmut";
            this.txtcadmut.Size = new System.Drawing.Size(177, 31);
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
            this.panel5.Size = new System.Drawing.Size(183, 74);
            this.panel5.TabIndex = 7;
            // 
            // txtciweb
            // 
            this.txtciweb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtciweb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtciweb.DisplayMember = "Descricao";
            this.txtciweb.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtciweb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtciweb.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtciweb.FormattingEnabled = true;
            this.txtciweb.Location = new System.Drawing.Point(3, 26);
            this.txtciweb.Name = "txtciweb";
            this.txtciweb.Size = new System.Drawing.Size(177, 31);
            this.txtciweb.TabIndex = 10;
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
            this.panel4.Controls.Add(this.txtStatusCPF);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(6, 26);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(183, 74);
            this.panel4.TabIndex = 6;
            // 
            // txtStatusCPF
            // 
            this.txtStatusCPF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStatusCPF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStatusCPF.DisplayMember = "Descricao";
            this.txtStatusCPF.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStatusCPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtStatusCPF.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusCPF.FormattingEnabled = true;
            this.txtStatusCPF.Location = new System.Drawing.Point(3, 26);
            this.txtStatusCPF.Name = "txtStatusCPF";
            this.txtStatusCPF.Size = new System.Drawing.Size(177, 31);
            this.txtStatusCPF.TabIndex = 9;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtrendacli, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtcelular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttelefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcpf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblemail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnasc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnomecli, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtrg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_status, 1, 6);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 196);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Renda Bruta:";
            // 
            // txtrendacli
            // 
            this.txtrendacli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacli.Location = new System.Drawing.Point(701, 85);
            this.txtrendacli.Name = "txtrendacli";
            this.txtrendacli.ReadOnly = true;
            this.txtrendacli.Size = new System.Drawing.Size(216, 27);
            this.txtrendacli.TabIndex = 54;
            this.txtrendacli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacli_KeyPress);
            this.txtrendacli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacli_KeyUp);
            this.txtrendacli.Leave += new System.EventHandler(this.txtrendacli_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "RG:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Feminino);
            this.groupBox2.Controls.Add(this.checkBox_Masculino);
            this.groupBox2.Location = new System.Drawing.Point(3, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 52);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            // 
            // checkBox_Feminino
            // 
            this.checkBox_Feminino.AutoSize = true;
            this.checkBox_Feminino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Feminino.Enabled = false;
            this.checkBox_Feminino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Feminino.Location = new System.Drawing.Point(96, 23);
            this.checkBox_Feminino.Name = "checkBox_Feminino";
            this.checkBox_Feminino.Size = new System.Drawing.Size(86, 26);
            this.checkBox_Feminino.TabIndex = 8;
            this.checkBox_Feminino.TabStop = true;
            this.checkBox_Feminino.Text = "Feminino";
            this.checkBox_Feminino.UseVisualStyleBackColor = true;
            // 
            // checkBox_Masculino
            // 
            this.checkBox_Masculino.AutoSize = true;
            this.checkBox_Masculino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculino.Enabled = false;
            this.checkBox_Masculino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculino.Location = new System.Drawing.Point(3, 23);
            this.checkBox_Masculino.Name = "checkBox_Masculino";
            this.checkBox_Masculino.Size = new System.Drawing.Size(93, 26);
            this.checkBox_Masculino.TabIndex = 7;
            this.checkBox_Masculino.TabStop = true;
            this.checkBox_Masculino.Text = "Masculino";
            this.checkBox_Masculino.UseVisualStyleBackColor = true;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(538, 85);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(157, 27);
            this.txtcelular.TabIndex = 6;
            this.txtcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 23);
            this.label20.TabIndex = 51;
            this.label20.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(373, 85);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.ReadOnly = true;
            this.txttelefone.Size = new System.Drawing.Size(157, 27);
            this.txttelefone.TabIndex = 5;
            this.txttelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 23);
            this.label19.TabIndex = 51;
            this.label19.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(701, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Data Nasc.";
            // 
            // txtemail
            // 
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(3, 85);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(364, 27);
            this.txtemail.TabIndex = 4;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(373, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(39, 23);
            this.lblcpf.TabIndex = 51;
            this.lblcpf.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcpf.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(373, 26);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.ReadOnly = true;
            this.txtcpf.Size = new System.Drawing.Size(159, 30);
            this.txtcpf.TabIndex = 1;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(3, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(364, 23);
            this.lblcliente.TabIndex = 51;
            this.lblcliente.Text = "Nome do Cliente:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(3, 59);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 23);
            this.lblemail.TabIndex = 51;
            this.lblemail.Text = "Email:";
            // 
            // txtnasc
            // 
            this.txtnasc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(701, 26);
            this.txtnasc.Mask = "00/00/0000";
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.ReadOnly = true;
            this.txtnasc.Size = new System.Drawing.Size(110, 27);
            this.txtnasc.TabIndex = 3;
            this.txtnasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomecli
            // 
            this.txtnomecli.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecli.Location = new System.Drawing.Point(3, 26);
            this.txtnomecli.Name = "txtnomecli";
            this.txtnomecli.ReadOnly = true;
            this.txtnomecli.Size = new System.Drawing.Size(364, 30);
            this.txtnomecli.TabIndex = 0;
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(538, 26);
            this.txtrg.Name = "txtrg";
            this.txtrg.ReadOnly = true;
            this.txtrg.Size = new System.Drawing.Size(157, 27);
            this.txtrg.TabIndex = 2;
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_status.Enabled = false;
            this.checkBox_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_status.Location = new System.Drawing.Point(373, 118);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(159, 75);
            this.checkBox_status.TabIndex = 56;
            this.checkBox_status.Text = "Cliente Ativo";
            this.checkBox_status.UseVisualStyleBackColor = true;
            this.checkBox_status.CheckedChanged += new System.EventHandler(this.checkBox_status_CheckedChanged);
            // 
            // Foto
            // 
            this.Foto.Controls.Add(this.btn_limpar_foto);
            this.Foto.Controls.Add(this.btn_add_foto);
            this.Foto.Controls.Add(this.img_foto);
            this.Foto.Location = new System.Drawing.Point(4, 32);
            this.Foto.Name = "Foto";
            this.Foto.Padding = new System.Windows.Forms.Padding(20);
            this.Foto.Size = new System.Drawing.Size(971, 472);
            this.Foto.TabIndex = 3;
            this.Foto.Text = "Foto";
            this.Foto.UseVisualStyleBackColor = true;
            // 
            // btn_limpar_foto
            // 
            this.btn_limpar_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_limpar_foto.Enabled = false;
            this.btn_limpar_foto.FlatAppearance.BorderSize = 0;
            this.btn_limpar_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_limpar_foto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpar_foto.Location = new System.Drawing.Point(187, 316);
            this.btn_limpar_foto.Name = "btn_limpar_foto";
            this.btn_limpar_foto.Padding = new System.Windows.Forms.Padding(4);
            this.btn_limpar_foto.Size = new System.Drawing.Size(104, 31);
            this.btn_limpar_foto.TabIndex = 5;
            this.btn_limpar_foto.Text = "Limpar";
            this.btn_limpar_foto.UseVisualStyleBackColor = false;
            this.btn_limpar_foto.Click += new System.EventHandler(this.btn_limpar_foto_Click);
            // 
            // btn_add_foto
            // 
            this.btn_add_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_add_foto.Enabled = false;
            this.btn_add_foto.FlatAppearance.BorderSize = 0;
            this.btn_add_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_add_foto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_foto.Location = new System.Drawing.Point(64, 316);
            this.btn_add_foto.Name = "btn_add_foto";
            this.btn_add_foto.Padding = new System.Windows.Forms.Padding(4);
            this.btn_add_foto.Size = new System.Drawing.Size(104, 31);
            this.btn_add_foto.TabIndex = 3;
            this.btn_add_foto.Text = "Adicionar";
            this.btn_add_foto.UseVisualStyleBackColor = false;
            this.btn_add_foto.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // img_foto
            // 
            this.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_foto.Enabled = false;
            this.img_foto.InitialImage = null;
            this.img_foto.Location = new System.Drawing.Point(64, 34);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(227, 262);
            this.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_foto.TabIndex = 0;
            this.img_foto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
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
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Location = new System.Drawing.Point(238, 10);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Size = new System.Drawing.Size(104, 32);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseCompatibleTextRendering = true;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(228, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 24;
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
            this.btn_salvar.Location = new System.Drawing.Point(124, 10);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Padding = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Size = new System.Drawing.Size(104, 32);
            this.btn_salvar.TabIndex = 23;
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
            this.btn_editar.TabIndex = 19;
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
            this.btnclosecli.TabIndex = 20;
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
            this.paneltop.Size = new System.Drawing.Size(979, 57);
            this.paneltop.TabIndex = 6;
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
            this.lbl_topo.Size = new System.Drawing.Size(317, 49);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Dados do Cliente";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = ((System.Drawing.Image)(resources.GetObject("img_topo.Image")));
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Padding = new System.Windows.Forms.Padding(5);
            this.img_topo.Size = new System.Drawing.Size(42, 49);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form_Dados_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Cliente";
            this.Load += new System.EventHandler(this.Form_Dados_cliente_Load);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Foto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabcliente;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TabPage Foto;
        private System.Windows.Forms.Button btn_add_foto;
        private System.Windows.Forms.PictureBox img_foto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtnasc;
        private System.Windows.Forms.RadioButton checkBox_Masculino;
        private System.Windows.Forms.RadioButton checkBox_Feminino;
        private System.Windows.Forms.TextBox txtnomecli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrendacli;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox checkBox_status;
        private OpenFileDialog ofd1;
        private Button btn_limpar_foto;
    }
}