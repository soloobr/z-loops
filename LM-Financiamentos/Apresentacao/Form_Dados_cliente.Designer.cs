
using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Windows;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Cliente));
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbrenda = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblnomecj4 = new System.Windows.Forms.Label();
            this.lbl04 = new System.Windows.Forms.Label();
            this.lblrendacj4 = new System.Windows.Forms.Label();
            this.lblrendacj3 = new System.Windows.Forms.Label();
            this.lblrendacj2 = new System.Windows.Forms.Label();
            this.lblrendacj1 = new System.Windows.Forms.Label();
            this.lblrendacli = new System.Windows.Forms.Label();
            this.lblnomecj3 = new System.Windows.Forms.Label();
            this.lblnomecj2 = new System.Windows.Forms.Label();
            this.lblnomecj1 = new System.Windows.Forms.Label();
            this.lblnomeclirenda = new System.Windows.Forms.Label();
            this.lblrendabruta = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl03 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.txtrendatotal = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtobservacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontacliente = new System.Windows.Forms.TextBox();
            this.txtagenciacliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnaonjuge = new System.Windows.Forms.Button();
            this.tabconjuge = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btbsalvarcj = new System.Windows.Forms.Button();
            this.btncancelcj = new System.Windows.Forms.Button();
            this.btncj = new System.Windows.Forms.Button();
            this.btn_excluircj = new System.Windows.Forms.Button();
            this.txtobservacaocj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontacj = new System.Windows.Forms.TextBox();
            this.txtagenciacj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrendacj = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Femininocj = new System.Windows.Forms.RadioButton();
            this.checkBox_Masculinocj = new System.Windows.Forms.RadioButton();
            this.txtcelularcj = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttelefonecj = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemailcj = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcpfcj = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnasccj = new System.Windows.Forms.MaskedTextBox();
            this.txtnomeconjuge = new System.Windows.Forms.TextBox();
            this.txtrgcj = new System.Windows.Forms.TextBox();
            this.checkBox_statuscj = new System.Windows.Forms.CheckBox();
            this.tabconjuge1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsalvarcj1 = new System.Windows.Forms.Button();
            this.btncancelcj1 = new System.Windows.Forms.Button();
            this.btn_excluircj1 = new System.Windows.Forms.Button();
            this.btncj1 = new System.Windows.Forms.Button();
            this.txtobservacaocj1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtcontacj1 = new System.Windows.Forms.TextBox();
            this.txtagenciacj1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtrendacj1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Femininocj1 = new System.Windows.Forms.RadioButton();
            this.checkBox_Masculinocj1 = new System.Windows.Forms.RadioButton();
            this.txtcelularcj1 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txttelefonecj1 = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtemailcj1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtcpfcj1 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtnasccj1 = new System.Windows.Forms.MaskedTextBox();
            this.txtnomecj1 = new System.Windows.Forms.TextBox();
            this.txtrgcj1 = new System.Windows.Forms.TextBox();
            this.checkBox_statuscj1 = new System.Windows.Forms.CheckBox();
            this.tabconjuge2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsalvarcj2 = new System.Windows.Forms.Button();
            this.btncancelcj2 = new System.Windows.Forms.Button();
            this.btn_excluircj2 = new System.Windows.Forms.Button();
            this.btncj2 = new System.Windows.Forms.Button();
            this.txtobservacaocj2 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtcontacj2 = new System.Windows.Forms.TextBox();
            this.txtagenciacj2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtrendacj2 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_Femininocj2 = new System.Windows.Forms.RadioButton();
            this.checkBox_Masculinocj2 = new System.Windows.Forms.RadioButton();
            this.txtcelularcj2 = new System.Windows.Forms.MaskedTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txttelefonecj2 = new System.Windows.Forms.MaskedTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtemailcj2 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtcpfcj2 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtnasccj2 = new System.Windows.Forms.MaskedTextBox();
            this.txtnomecj2 = new System.Windows.Forms.TextBox();
            this.txtrgcj2 = new System.Windows.Forms.TextBox();
            this.checkBox_statuscj2 = new System.Windows.Forms.CheckBox();
            this.tabconjuge3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnsalvarcj3 = new System.Windows.Forms.Button();
            this.btncancelcj3 = new System.Windows.Forms.Button();
            this.btn_excluircj3 = new System.Windows.Forms.Button();
            this.txtobservacaocj3 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtcontacj3 = new System.Windows.Forms.TextBox();
            this.txtagenciacj3 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtrendacj3 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_Femininocj3 = new System.Windows.Forms.RadioButton();
            this.checkBox_Masculinocj3 = new System.Windows.Forms.RadioButton();
            this.txtcelularcj3 = new System.Windows.Forms.MaskedTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txttelefonecj3 = new System.Windows.Forms.MaskedTextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtemailcj3 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtcpfcj3 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtnasccj3 = new System.Windows.Forms.MaskedTextBox();
            this.txtnomecj3 = new System.Windows.Forms.TextBox();
            this.txtrgcj3 = new System.Windows.Forms.TextBox();
            this.checkBox_statuscj3 = new System.Windows.Forms.CheckBox();
            this.Foto = new System.Windows.Forms.TabPage();
            this.btn_limpar_foto = new System.Windows.Forms.Button();
            this.btn_add_foto = new System.Windows.Forms.Button();
            this.img_foto = new System.Windows.Forms.PictureBox();
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
            this.panel3.SuspendLayout();
            this.gbrenda.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabcliente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabconjuge.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabconjuge1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabconjuge2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabconjuge3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.panelcentralcadcli.Size = new System.Drawing.Size(1022, 686);
            this.panelcentralcadcli.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1022, 577);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.gbrenda);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 371);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(982, 197);
            this.panel3.TabIndex = 16;
            // 
            // gbrenda
            // 
            this.gbrenda.AutoSize = true;
            this.gbrenda.Controls.Add(this.tableLayoutPanel6);
            this.gbrenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbrenda.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrenda.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbrenda.Location = new System.Drawing.Point(5, 5);
            this.gbrenda.Name = "gbrenda";
            this.gbrenda.Padding = new System.Windows.Forms.Padding(10);
            this.gbrenda.Size = new System.Drawing.Size(972, 187);
            this.gbrenda.TabIndex = 4;
            this.gbrenda.TabStop = false;
            this.gbrenda.Text = "Resumo Renda";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.lblnomecj4, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.lbl04, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblrendacj4, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.lblrendacj3, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblrendacj2, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblrendacj1, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblrendacli, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblnomecj3, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblnomecj2, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lblnomecj1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblnomeclirenda, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblrendabruta, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lbl01, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl02, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl03, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl0, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtrendatotal, 2, 5);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(10, 32);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(952, 145);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // lblnomecj4
            // 
            this.lblnomecj4.AutoSize = true;
            this.lblnomecj4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnomecj4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecj4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblnomecj4.Location = new System.Drawing.Point(56, 84);
            this.lblnomecj4.Name = "lblnomecj4";
            this.lblnomecj4.Size = new System.Drawing.Size(76, 21);
            this.lblnomecj4.TabIndex = 71;
            this.lblnomecj4.Text = "Cônjuge 4";
            this.lblnomecj4.Visible = false;
            // 
            // lbl04
            // 
            this.lbl04.AutoSize = true;
            this.lbl04.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl04.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl04.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl04.Location = new System.Drawing.Point(3, 84);
            this.lbl04.Name = "lbl04";
            this.lbl04.Size = new System.Drawing.Size(47, 21);
            this.lbl04.TabIndex = 70;
            this.lbl04.Text = "CJ 03";
            this.lbl04.Visible = false;
            // 
            // lblrendacj4
            // 
            this.lblrendacj4.AutoSize = true;
            this.lblrendacj4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendacj4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrendacj4.Location = new System.Drawing.Point(197, 84);
            this.lblrendacj4.Name = "lblrendacj4";
            this.lblrendacj4.Size = new System.Drawing.Size(44, 21);
            this.lblrendacj4.TabIndex = 69;
            this.lblrendacj4.Text = "Valor";
            this.lblrendacj4.Visible = false;
            // 
            // lblrendacj3
            // 
            this.lblrendacj3.AutoSize = true;
            this.lblrendacj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendacj3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrendacj3.Location = new System.Drawing.Point(197, 63);
            this.lblrendacj3.Name = "lblrendacj3";
            this.lblrendacj3.Size = new System.Drawing.Size(44, 21);
            this.lblrendacj3.TabIndex = 68;
            this.lblrendacj3.Text = "Valor";
            this.lblrendacj3.Visible = false;
            // 
            // lblrendacj2
            // 
            this.lblrendacj2.AutoSize = true;
            this.lblrendacj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendacj2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrendacj2.Location = new System.Drawing.Point(197, 42);
            this.lblrendacj2.Name = "lblrendacj2";
            this.lblrendacj2.Size = new System.Drawing.Size(44, 21);
            this.lblrendacj2.TabIndex = 67;
            this.lblrendacj2.Text = "Valor";
            this.lblrendacj2.Visible = false;
            // 
            // lblrendacj1
            // 
            this.lblrendacj1.AutoSize = true;
            this.lblrendacj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendacj1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrendacj1.Location = new System.Drawing.Point(197, 21);
            this.lblrendacj1.Name = "lblrendacj1";
            this.lblrendacj1.Size = new System.Drawing.Size(44, 21);
            this.lblrendacj1.TabIndex = 66;
            this.lblrendacj1.Text = "Valor";
            this.lblrendacj1.Visible = false;
            // 
            // lblrendacli
            // 
            this.lblrendacli.AutoSize = true;
            this.lblrendacli.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblrendacli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendacli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblrendacli.Location = new System.Drawing.Point(197, 0);
            this.lblrendacli.Name = "lblrendacli";
            this.lblrendacli.Size = new System.Drawing.Size(752, 21);
            this.lblrendacli.TabIndex = 65;
            this.lblrendacli.Text = "Valor";
            // 
            // lblnomecj3
            // 
            this.lblnomecj3.AutoSize = true;
            this.lblnomecj3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnomecj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecj3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblnomecj3.Location = new System.Drawing.Point(56, 63);
            this.lblnomecj3.Name = "lblnomecj3";
            this.lblnomecj3.Size = new System.Drawing.Size(76, 21);
            this.lblnomecj3.TabIndex = 64;
            this.lblnomecj3.Text = "Cônjuge 3";
            this.lblnomecj3.Visible = false;
            // 
            // lblnomecj2
            // 
            this.lblnomecj2.AutoSize = true;
            this.lblnomecj2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnomecj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecj2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblnomecj2.Location = new System.Drawing.Point(56, 42);
            this.lblnomecj2.Name = "lblnomecj2";
            this.lblnomecj2.Size = new System.Drawing.Size(76, 21);
            this.lblnomecj2.TabIndex = 63;
            this.lblnomecj2.Text = "Cônjuge 2";
            this.lblnomecj2.Visible = false;
            // 
            // lblnomecj1
            // 
            this.lblnomecj1.AutoSize = true;
            this.lblnomecj1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnomecj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomecj1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblnomecj1.Location = new System.Drawing.Point(56, 21);
            this.lblnomecj1.Name = "lblnomecj1";
            this.lblnomecj1.Size = new System.Drawing.Size(72, 21);
            this.lblnomecj1.TabIndex = 62;
            this.lblnomecj1.Text = "Cônjuge 1";
            this.lblnomecj1.Visible = false;
            // 
            // lblnomeclirenda
            // 
            this.lblnomeclirenda.AutoSize = true;
            this.lblnomeclirenda.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblnomeclirenda.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomeclirenda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblnomeclirenda.Location = new System.Drawing.Point(56, 0);
            this.lblnomeclirenda.Name = "lblnomeclirenda";
            this.lblnomeclirenda.Size = new System.Drawing.Size(55, 21);
            this.lblnomeclirenda.TabIndex = 61;
            this.lblnomeclirenda.Text = "Cliente";
            // 
            // lblrendabruta
            // 
            this.lblrendabruta.AutoSize = true;
            this.lblrendabruta.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblrendabruta.Location = new System.Drawing.Point(56, 105);
            this.lblrendabruta.Name = "lblrendabruta";
            this.lblrendabruta.Size = new System.Drawing.Size(135, 20);
            this.lblrendabruta.TabIndex = 60;
            this.lblrendabruta.Text = "Renda Bruta Total:";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl01.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl01.Location = new System.Drawing.Point(3, 21);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(47, 21);
            this.lbl01.TabIndex = 59;
            this.lbl01.Text = "CJ";
            this.lbl01.Visible = false;
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl02.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl02.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl02.Location = new System.Drawing.Point(3, 42);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(47, 21);
            this.lbl02.TabIndex = 58;
            this.lbl02.Text = "CJ 01";
            this.lbl02.Visible = false;
            // 
            // lbl03
            // 
            this.lbl03.AutoSize = true;
            this.lbl03.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl03.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl03.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl03.Location = new System.Drawing.Point(3, 63);
            this.lbl03.Name = "lbl03";
            this.lbl03.Size = new System.Drawing.Size(47, 21);
            this.lbl03.TabIndex = 57;
            this.lbl03.Text = "CJ 02";
            this.lbl03.Visible = false;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl0.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl0.Location = new System.Drawing.Point(3, 0);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(47, 21);
            this.lbl0.TabIndex = 56;
            this.lbl0.Text = "Cli.";
            // 
            // txtrendatotal
            // 
            this.txtrendatotal.Location = new System.Drawing.Point(197, 108);
            this.txtrendatotal.Name = "txtrendatotal";
            this.txtrendatotal.ReadOnly = true;
            this.txtrendatotal.Size = new System.Drawing.Size(147, 29);
            this.txtrendatotal.TabIndex = 72;
            this.txtrendatotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabcliente);
            this.tabControl.Controls.Add(this.tabconjuge);
            this.tabControl.Controls.Add(this.tabconjuge1);
            this.tabControl.Controls.Add(this.tabconjuge2);
            this.tabControl.Controls.Add(this.tabconjuge3);
            this.tabControl.Controls.Add(this.Foto);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(20, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(982, 351);
            this.tabControl.TabIndex = 15;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcliente.Location = new System.Drawing.Point(4, 30);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(974, 317);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtobservacoes, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtcontacliente, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtagenciacliente, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtrendacli, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 5);
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
            this.tableLayoutPanel1.Controls.Add(this.checkBox_status, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnaonjuge, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 286);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtobservacoes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtobservacoes, 3);
            this.txtobservacoes.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacoes.Location = new System.Drawing.Point(3, 216);
            this.txtobservacoes.Name = "txtobservacoes";
            this.txtobservacoes.ReadOnly = true;
            this.txtobservacoes.Size = new System.Drawing.Size(589, 29);
            this.txtobservacoes.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 71;
            this.label6.Text = "Observações:";
            // 
            // txtcontacliente
            // 
            this.txtcontacliente.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacliente.Location = new System.Drawing.Point(184, 139);
            this.txtcontacliente.Name = "txtcontacliente";
            this.txtcontacliente.ReadOnly = true;
            this.txtcontacliente.Size = new System.Drawing.Size(183, 29);
            this.txtcontacliente.TabIndex = 9;
            // 
            // txtagenciacliente
            // 
            this.txtagenciacliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtagenciacliente.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacliente.Location = new System.Drawing.Point(3, 139);
            this.txtagenciacliente.Name = "txtagenciacliente";
            this.txtagenciacliente.ReadOnly = true;
            this.txtagenciacliente.Size = new System.Drawing.Size(175, 29);
            this.txtagenciacliente.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "Agencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Renda:";
            // 
            // txtrendacli
            // 
            this.txtrendacli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacli.Location = new System.Drawing.Point(761, 83);
            this.txtrendacli.Name = "txtrendacli";
            this.txtrendacli.ReadOnly = true;
            this.txtrendacli.Size = new System.Drawing.Size(167, 29);
            this.txtrendacli.TabIndex = 7;
            this.txtrendacli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacli_KeyPress);
            this.txtrendacli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacli_KeyUp);
            this.txtrendacli.Leave += new System.EventHandler(this.txtrendacli_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "RG:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Feminino);
            this.groupBox2.Controls.Add(this.checkBox_Masculino);
            this.groupBox2.Location = new System.Drawing.Point(373, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(193, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            // 
            // checkBox_Feminino
            // 
            this.checkBox_Feminino.AutoSize = true;
            this.checkBox_Feminino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Feminino.Enabled = false;
            this.checkBox_Feminino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Feminino.Location = new System.Drawing.Point(98, 27);
            this.checkBox_Feminino.Name = "checkBox_Feminino";
            this.checkBox_Feminino.Size = new System.Drawing.Size(85, 39);
            this.checkBox_Feminino.TabIndex = 12;
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
            this.checkBox_Masculino.Location = new System.Drawing.Point(5, 27);
            this.checkBox_Masculino.Name = "checkBox_Masculino";
            this.checkBox_Masculino.Size = new System.Drawing.Size(93, 39);
            this.checkBox_Masculino.TabIndex = 11;
            this.checkBox_Masculino.TabStop = true;
            this.checkBox_Masculino.Text = "Masculino";
            this.checkBox_Masculino.UseVisualStyleBackColor = true;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(598, 83);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(157, 29);
            this.txtcelular.TabIndex = 6;
            this.txtcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(598, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 21);
            this.label20.TabIndex = 51;
            this.label20.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttelefone.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(373, 83);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.ReadOnly = true;
            this.txttelefone.Size = new System.Drawing.Size(219, 29);
            this.txttelefone.TabIndex = 5;
            this.txttelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 21);
            this.label19.TabIndex = 51;
            this.label19.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(761, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Data Nasc.";
            // 
            // txtemail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtemail, 2);
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemail.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(3, 83);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(364, 29);
            this.txtemail.TabIndex = 4;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(373, 0);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(39, 21);
            this.lblcpf.TabIndex = 51;
            this.lblcpf.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcpf.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(373, 24);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.ReadOnly = true;
            this.txtcpf.Size = new System.Drawing.Size(219, 32);
            this.txtcpf.TabIndex = 1;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress_1);
            this.txtcpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpf_KeyUp_1);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblcliente, 2);
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(3, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(364, 21);
            this.lblcliente.TabIndex = 51;
            this.lblcliente.Text = "Nome do Cliente:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblemail, 2);
            this.lblemail.Location = new System.Drawing.Point(3, 59);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 21);
            this.lblemail.TabIndex = 51;
            this.lblemail.Text = "Email:";
            // 
            // txtnasc
            // 
            this.txtnasc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasc.Location = new System.Drawing.Point(761, 24);
            this.txtnasc.Mask = "00/00/0000";
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.ReadOnly = true;
            this.txtnasc.Size = new System.Drawing.Size(110, 29);
            this.txtnasc.TabIndex = 3;
            this.txtnasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomecli
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtnomecli, 2);
            this.txtnomecli.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecli.Location = new System.Drawing.Point(3, 24);
            this.txtnomecli.Name = "txtnomecli";
            this.txtnomecli.ReadOnly = true;
            this.txtnomecli.Size = new System.Drawing.Size(364, 32);
            this.txtnomecli.TabIndex = 0;
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(598, 24);
            this.txtrg.Name = "txtrg";
            this.txtrg.ReadOnly = true;
            this.txtrg.Size = new System.Drawing.Size(157, 29);
            this.txtrg.TabIndex = 2;
            this.txtrg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrg_KeyUp_1);
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_status.Enabled = false;
            this.checkBox_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_status.Location = new System.Drawing.Point(598, 118);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.SetRowSpan(this.checkBox_status, 2);
            this.checkBox_status.Size = new System.Drawing.Size(157, 71);
            this.checkBox_status.TabIndex = 13;
            this.checkBox_status.Text = "Cliente Ativo";
            this.checkBox_status.UseVisualStyleBackColor = true;
            this.checkBox_status.CheckedChanged += new System.EventHandler(this.checkBox_status_CheckedChanged);
            // 
            // btnaonjuge
            // 
            this.btnaonjuge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaonjuge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnaonjuge.FlatAppearance.BorderSize = 0;
            this.btnaonjuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaonjuge.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaonjuge.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaonjuge.Location = new System.Drawing.Point(3, 251);
            this.btnaonjuge.Name = "btnaonjuge";
            this.btnaonjuge.Padding = new System.Windows.Forms.Padding(4);
            this.btnaonjuge.Size = new System.Drawing.Size(175, 32);
            this.btnaonjuge.TabIndex = 73;
            this.btnaonjuge.Text = "Adicionar Cônjuge";
            this.btnaonjuge.UseCompatibleTextRendering = true;
            this.btnaonjuge.UseVisualStyleBackColor = false;
            this.btnaonjuge.Visible = false;
            this.btnaonjuge.Click += new System.EventHandler(this.btnaonjuge_Click);
            // 
            // tabconjuge
            // 
            this.tabconjuge.Controls.Add(this.tableLayoutPanel2);
            this.tabconjuge.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconjuge.Location = new System.Drawing.Point(4, 30);
            this.tabconjuge.Name = "tabconjuge";
            this.tabconjuge.Padding = new System.Windows.Forms.Padding(20);
            this.tabconjuge.Size = new System.Drawing.Size(974, 317);
            this.tabconjuge.TabIndex = 4;
            this.tabconjuge.Text = "Cônjuge";
            this.tabconjuge.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btbsalvarcj, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.btncancelcj, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.btncj, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.btn_excluircj, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.txtobservacaocj, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtcontacj, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtagenciacj, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtrendacj, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtcelularcj, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txttelefonecj, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtemailcj, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtcpfcj, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtnasccj, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtnomeconjuge, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtrgcj, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_statuscj, 3, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 324);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btbsalvarcj
            // 
            this.btbsalvarcj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btbsalvarcj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btbsalvarcj.FlatAppearance.BorderSize = 0;
            this.btbsalvarcj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbsalvarcj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbsalvarcj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btbsalvarcj.Location = new System.Drawing.Point(3, 251);
            this.btbsalvarcj.Name = "btbsalvarcj";
            this.btbsalvarcj.Padding = new System.Windows.Forms.Padding(4);
            this.btbsalvarcj.Size = new System.Drawing.Size(181, 32);
            this.btbsalvarcj.TabIndex = 79;
            this.btbsalvarcj.Text = "Salvar";
            this.btbsalvarcj.UseCompatibleTextRendering = true;
            this.btbsalvarcj.UseVisualStyleBackColor = false;
            this.btbsalvarcj.Click += new System.EventHandler(this.btbsalvarcj_Click);
            // 
            // btncancelcj
            // 
            this.btncancelcj.BackColor = System.Drawing.Color.SlateGray;
            this.btncancelcj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelcj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelcj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelcj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelcj.Location = new System.Drawing.Point(190, 251);
            this.btncancelcj.Name = "btncancelcj";
            this.btncancelcj.Padding = new System.Windows.Forms.Padding(4);
            this.btncancelcj.Size = new System.Drawing.Size(183, 32);
            this.btncancelcj.TabIndex = 78;
            this.btncancelcj.Text = "Cancelar";
            this.btncancelcj.UseCompatibleTextRendering = true;
            this.btncancelcj.UseVisualStyleBackColor = false;
            this.btncancelcj.Click += new System.EventHandler(this.btncancelcj_Click);
            // 
            // btncj
            // 
            this.btncj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncj.FlatAppearance.BorderSize = 0;
            this.btncj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncj.Location = new System.Drawing.Point(3, 289);
            this.btncj.Name = "btncj";
            this.btncj.Padding = new System.Windows.Forms.Padding(4);
            this.btncj.Size = new System.Drawing.Size(181, 32);
            this.btncj.TabIndex = 77;
            this.btncj.Text = "Adicionar + Cônjuge";
            this.btncj.UseCompatibleTextRendering = true;
            this.btncj.UseVisualStyleBackColor = false;
            this.btncj.Visible = false;
            this.btncj.Click += new System.EventHandler(this.btnconjuge1_Click);
            // 
            // btn_excluircj
            // 
            this.btn_excluircj.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluircj.CausesValidation = false;
            this.btn_excluircj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluircj.FlatAppearance.BorderSize = 0;
            this.btn_excluircj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluircj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluircj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluircj.Location = new System.Drawing.Point(190, 289);
            this.btn_excluircj.Name = "btn_excluircj";
            this.btn_excluircj.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluircj.Size = new System.Drawing.Size(183, 32);
            this.btn_excluircj.TabIndex = 76;
            this.btn_excluircj.Text = "Excluir Cônjuge";
            this.btn_excluircj.UseCompatibleTextRendering = true;
            this.btn_excluircj.UseVisualStyleBackColor = false;
            this.btn_excluircj.Visible = false;
            this.btn_excluircj.Click += new System.EventHandler(this.btn_excluirconjuge_Click_1);
            // 
            // txtobservacaocj
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtobservacaocj, 3);
            this.txtobservacaocj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacaocj.Location = new System.Drawing.Point(3, 216);
            this.txtobservacaocj.Name = "txtobservacaocj";
            this.txtobservacaocj.ReadOnly = true;
            this.txtobservacaocj.Size = new System.Drawing.Size(589, 29);
            this.txtobservacaocj.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Observações:";
            // 
            // txtcontacj
            // 
            this.txtcontacj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacj.Location = new System.Drawing.Point(190, 139);
            this.txtcontacj.Name = "txtcontacj";
            this.txtcontacj.ReadOnly = true;
            this.txtcontacj.Size = new System.Drawing.Size(183, 29);
            this.txtcontacj.TabIndex = 9;
            // 
            // txtagenciacj
            // 
            this.txtagenciacj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtagenciacj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacj.Location = new System.Drawing.Point(3, 139);
            this.txtagenciacj.Name = "txtagenciacj";
            this.txtagenciacj.ReadOnly = true;
            this.txtagenciacj.Size = new System.Drawing.Size(181, 29);
            this.txtagenciacj.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 69;
            this.label8.Text = "Agencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 70;
            this.label9.Text = "Conta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(767, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 55;
            this.label10.Text = "Renda:";
            // 
            // txtrendacj
            // 
            this.txtrendacj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacj.Location = new System.Drawing.Point(767, 83);
            this.txtrendacj.Name = "txtrendacj";
            this.txtrendacj.ReadOnly = true;
            this.txtrendacj.Size = new System.Drawing.Size(167, 29);
            this.txtrendacj.TabIndex = 7;
            this.txtrendacj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacj_KeyPress);
            this.txtrendacj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacj_KeyUp);
            this.txtrendacj.Leave += new System.EventHandler(this.txtrendacj_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "RG:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Femininocj);
            this.groupBox1.Controls.Add(this.checkBox_Masculinocj);
            this.groupBox1.Location = new System.Drawing.Point(379, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(193, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // checkBox_Femininocj
            // 
            this.checkBox_Femininocj.AutoSize = true;
            this.checkBox_Femininocj.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Femininocj.Enabled = false;
            this.checkBox_Femininocj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Femininocj.Location = new System.Drawing.Point(98, 27);
            this.checkBox_Femininocj.Name = "checkBox_Femininocj";
            this.checkBox_Femininocj.Size = new System.Drawing.Size(85, 39);
            this.checkBox_Femininocj.TabIndex = 12;
            this.checkBox_Femininocj.TabStop = true;
            this.checkBox_Femininocj.Text = "Feminino";
            this.checkBox_Femininocj.UseVisualStyleBackColor = true;
            // 
            // checkBox_Masculinocj
            // 
            this.checkBox_Masculinocj.AutoSize = true;
            this.checkBox_Masculinocj.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculinocj.Enabled = false;
            this.checkBox_Masculinocj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculinocj.Location = new System.Drawing.Point(5, 27);
            this.checkBox_Masculinocj.Name = "checkBox_Masculinocj";
            this.checkBox_Masculinocj.Size = new System.Drawing.Size(93, 39);
            this.checkBox_Masculinocj.TabIndex = 11;
            this.checkBox_Masculinocj.TabStop = true;
            this.checkBox_Masculinocj.Text = "Masculino";
            this.checkBox_Masculinocj.UseVisualStyleBackColor = true;
            // 
            // txtcelularcj
            // 
            this.txtcelularcj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelularcj.Location = new System.Drawing.Point(604, 83);
            this.txtcelularcj.Mask = "(99) 00000-0000";
            this.txtcelularcj.Name = "txtcelularcj";
            this.txtcelularcj.ReadOnly = true;
            this.txtcelularcj.Size = new System.Drawing.Size(157, 29);
            this.txtcelularcj.TabIndex = 6;
            this.txtcelularcj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Celular:";
            // 
            // txttelefonecj
            // 
            this.txttelefonecj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttelefonecj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonecj.Location = new System.Drawing.Point(379, 83);
            this.txttelefonecj.Mask = "(99) 0000-0000";
            this.txttelefonecj.Name = "txttelefonecj";
            this.txttelefonecj.ReadOnly = true;
            this.txttelefonecj.Size = new System.Drawing.Size(219, 29);
            this.txttelefonecj.TabIndex = 5;
            this.txttelefonecj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 51;
            this.label13.Text = "Telefone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(767, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 21);
            this.label14.TabIndex = 51;
            this.label14.Text = "Data Nasc.";
            // 
            // txtemailcj
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtemailcj, 2);
            this.txtemailcj.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemailcj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcj.Location = new System.Drawing.Point(3, 83);
            this.txtemailcj.Name = "txtemailcj";
            this.txtemailcj.ReadOnly = true;
            this.txtemailcj.Size = new System.Drawing.Size(364, 29);
            this.txtemailcj.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(379, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 21);
            this.label15.TabIndex = 51;
            this.label15.Text = "CPF:";
            // 
            // txtcpfcj
            // 
            this.txtcpfcj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcpfcj.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfcj.Location = new System.Drawing.Point(379, 24);
            this.txtcpfcj.Name = "txtcpfcj";
            this.txtcpfcj.ReadOnly = true;
            this.txtcpfcj.Size = new System.Drawing.Size(219, 32);
            this.txtcpfcj.TabIndex = 1;
            this.txtcpfcj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpfcj_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label16, 2);
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(370, 21);
            this.label16.TabIndex = 51;
            this.label16.Text = "Nome do Cônjuge:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label17, 2);
            this.label17.Location = new System.Drawing.Point(3, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 21);
            this.label17.TabIndex = 51;
            this.label17.Text = "Email:";
            // 
            // txtnasccj
            // 
            this.txtnasccj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasccj.Location = new System.Drawing.Point(767, 24);
            this.txtnasccj.Mask = "00/00/0000";
            this.txtnasccj.Name = "txtnasccj";
            this.txtnasccj.ReadOnly = true;
            this.txtnasccj.Size = new System.Drawing.Size(110, 29);
            this.txtnasccj.TabIndex = 3;
            this.txtnasccj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasccj.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomeconjuge
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtnomeconjuge, 2);
            this.txtnomeconjuge.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomeconjuge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomeconjuge.Location = new System.Drawing.Point(3, 24);
            this.txtnomeconjuge.Name = "txtnomeconjuge";
            this.txtnomeconjuge.ReadOnly = true;
            this.txtnomeconjuge.Size = new System.Drawing.Size(364, 32);
            this.txtnomeconjuge.TabIndex = 0;
            // 
            // txtrgcj
            // 
            this.txtrgcj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgcj.Location = new System.Drawing.Point(604, 24);
            this.txtrgcj.Name = "txtrgcj";
            this.txtrgcj.ReadOnly = true;
            this.txtrgcj.Size = new System.Drawing.Size(157, 29);
            this.txtrgcj.TabIndex = 2;
            this.txtrgcj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrgcj_KeyUp);
            // 
            // checkBox_statuscj
            // 
            this.checkBox_statuscj.AutoSize = true;
            this.checkBox_statuscj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_statuscj.Enabled = false;
            this.checkBox_statuscj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_statuscj.Location = new System.Drawing.Point(604, 118);
            this.checkBox_statuscj.Name = "checkBox_statuscj";
            this.checkBox_statuscj.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.SetRowSpan(this.checkBox_statuscj, 2);
            this.checkBox_statuscj.Size = new System.Drawing.Size(157, 71);
            this.checkBox_statuscj.TabIndex = 13;
            this.checkBox_statuscj.Text = "Cônjuge Ativo";
            this.checkBox_statuscj.UseVisualStyleBackColor = true;
            // 
            // tabconjuge1
            // 
            this.tabconjuge1.Controls.Add(this.tableLayoutPanel3);
            this.tabconjuge1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconjuge1.Location = new System.Drawing.Point(4, 30);
            this.tabconjuge1.Name = "tabconjuge1";
            this.tabconjuge1.Padding = new System.Windows.Forms.Padding(20);
            this.tabconjuge1.Size = new System.Drawing.Size(974, 317);
            this.tabconjuge1.TabIndex = 5;
            this.tabconjuge1.Text = "Cônjuge 1";
            this.tabconjuge1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnsalvarcj1, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.btncancelcj1, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.btn_excluircj1, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.btncj1, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.txtobservacaocj1, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtcontacj1, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtagenciacj1, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label21, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label22, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label23, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtrendacj1, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label24, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtcelularcj1, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label25, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txttelefonecj1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label26, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label27, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtemailcj1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtcpfcj1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label30, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtnasccj1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtnomecj1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtrgcj1, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_statuscj1, 3, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 324);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnsalvarcj1
            // 
            this.btnsalvarcj1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnsalvarcj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsalvarcj1.FlatAppearance.BorderSize = 0;
            this.btnsalvarcj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarcj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarcj1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsalvarcj1.Location = new System.Drawing.Point(3, 251);
            this.btnsalvarcj1.Name = "btnsalvarcj1";
            this.btnsalvarcj1.Padding = new System.Windows.Forms.Padding(4);
            this.btnsalvarcj1.Size = new System.Drawing.Size(181, 32);
            this.btnsalvarcj1.TabIndex = 81;
            this.btnsalvarcj1.Text = "Salvar";
            this.btnsalvarcj1.UseCompatibleTextRendering = true;
            this.btnsalvarcj1.UseVisualStyleBackColor = false;
            this.btnsalvarcj1.Click += new System.EventHandler(this.btnsalvarcj1_Click);
            // 
            // btncancelcj1
            // 
            this.btncancelcj1.BackColor = System.Drawing.Color.SlateGray;
            this.btncancelcj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelcj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelcj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelcj1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelcj1.Location = new System.Drawing.Point(190, 251);
            this.btncancelcj1.Name = "btncancelcj1";
            this.btncancelcj1.Padding = new System.Windows.Forms.Padding(4);
            this.btncancelcj1.Size = new System.Drawing.Size(183, 32);
            this.btncancelcj1.TabIndex = 80;
            this.btncancelcj1.Text = "Cancelar";
            this.btncancelcj1.UseCompatibleTextRendering = true;
            this.btncancelcj1.UseVisualStyleBackColor = false;
            this.btncancelcj1.Click += new System.EventHandler(this.btncancelcj1_Click);
            // 
            // btn_excluircj1
            // 
            this.btn_excluircj1.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluircj1.CausesValidation = false;
            this.btn_excluircj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluircj1.FlatAppearance.BorderSize = 0;
            this.btn_excluircj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluircj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluircj1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluircj1.Location = new System.Drawing.Point(190, 289);
            this.btn_excluircj1.Name = "btn_excluircj1";
            this.btn_excluircj1.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluircj1.Size = new System.Drawing.Size(183, 32);
            this.btn_excluircj1.TabIndex = 74;
            this.btn_excluircj1.Text = "Excluir Cônjuge 1";
            this.btn_excluircj1.UseCompatibleTextRendering = true;
            this.btn_excluircj1.UseVisualStyleBackColor = false;
            this.btn_excluircj1.Visible = false;
            this.btn_excluircj1.Click += new System.EventHandler(this.btn_excluirconjuge1_Click);
            // 
            // btncj1
            // 
            this.btncj1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncj1.FlatAppearance.BorderSize = 0;
            this.btncj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncj1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncj1.Location = new System.Drawing.Point(3, 289);
            this.btncj1.Name = "btncj1";
            this.btncj1.Padding = new System.Windows.Forms.Padding(4);
            this.btncj1.Size = new System.Drawing.Size(181, 32);
            this.btncj1.TabIndex = 73;
            this.btncj1.Text = "Adicionar + Cônjuge";
            this.btncj1.UseCompatibleTextRendering = true;
            this.btncj1.UseVisualStyleBackColor = false;
            this.btncj1.Visible = false;
            this.btncj1.Click += new System.EventHandler(this.btnconjuge2_Click);
            // 
            // txtobservacaocj1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtobservacaocj1, 3);
            this.txtobservacaocj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacaocj1.Location = new System.Drawing.Point(3, 216);
            this.txtobservacaocj1.Name = "txtobservacaocj1";
            this.txtobservacaocj1.ReadOnly = true;
            this.txtobservacaocj1.Size = new System.Drawing.Size(589, 29);
            this.txtobservacaocj1.TabIndex = 72;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 21);
            this.label18.TabIndex = 71;
            this.label18.Text = "Observações:";
            // 
            // txtcontacj1
            // 
            this.txtcontacj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacj1.Location = new System.Drawing.Point(190, 139);
            this.txtcontacj1.Name = "txtcontacj1";
            this.txtcontacj1.ReadOnly = true;
            this.txtcontacj1.Size = new System.Drawing.Size(183, 29);
            this.txtcontacj1.TabIndex = 9;
            // 
            // txtagenciacj1
            // 
            this.txtagenciacj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtagenciacj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacj1.Location = new System.Drawing.Point(3, 139);
            this.txtagenciacj1.Name = "txtagenciacj1";
            this.txtagenciacj1.ReadOnly = true;
            this.txtagenciacj1.Size = new System.Drawing.Size(181, 29);
            this.txtagenciacj1.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 21);
            this.label21.TabIndex = 69;
            this.label21.Text = "Agencia:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(190, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 21);
            this.label22.TabIndex = 70;
            this.label22.Text = "Conta:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(767, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 21);
            this.label23.TabIndex = 55;
            this.label23.Text = "Renda:";
            // 
            // txtrendacj1
            // 
            this.txtrendacj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacj1.Location = new System.Drawing.Point(767, 83);
            this.txtrendacj1.Name = "txtrendacj1";
            this.txtrendacj1.ReadOnly = true;
            this.txtrendacj1.Size = new System.Drawing.Size(167, 29);
            this.txtrendacj1.TabIndex = 7;
            this.txtrendacj1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacj1_KeyPress);
            this.txtrendacj1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacj1_KeyUp);
            this.txtrendacj1.Leave += new System.EventHandler(this.txtrendacj1_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(604, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 21);
            this.label24.TabIndex = 52;
            this.label24.Text = "RG:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_Femininocj1);
            this.groupBox3.Controls.Add(this.checkBox_Masculinocj1);
            this.groupBox3.Location = new System.Drawing.Point(379, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(193, 71);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo:";
            // 
            // checkBox_Femininocj1
            // 
            this.checkBox_Femininocj1.AutoSize = true;
            this.checkBox_Femininocj1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Femininocj1.Enabled = false;
            this.checkBox_Femininocj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Femininocj1.Location = new System.Drawing.Point(98, 27);
            this.checkBox_Femininocj1.Name = "checkBox_Femininocj1";
            this.checkBox_Femininocj1.Size = new System.Drawing.Size(85, 39);
            this.checkBox_Femininocj1.TabIndex = 12;
            this.checkBox_Femininocj1.TabStop = true;
            this.checkBox_Femininocj1.Text = "Feminino";
            this.checkBox_Femininocj1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Masculinocj1
            // 
            this.checkBox_Masculinocj1.AutoSize = true;
            this.checkBox_Masculinocj1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculinocj1.Enabled = false;
            this.checkBox_Masculinocj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculinocj1.Location = new System.Drawing.Point(5, 27);
            this.checkBox_Masculinocj1.Name = "checkBox_Masculinocj1";
            this.checkBox_Masculinocj1.Size = new System.Drawing.Size(93, 39);
            this.checkBox_Masculinocj1.TabIndex = 11;
            this.checkBox_Masculinocj1.TabStop = true;
            this.checkBox_Masculinocj1.Text = "Masculino";
            this.checkBox_Masculinocj1.UseVisualStyleBackColor = true;
            // 
            // txtcelularcj1
            // 
            this.txtcelularcj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelularcj1.Location = new System.Drawing.Point(604, 83);
            this.txtcelularcj1.Mask = "(99) 00000-0000";
            this.txtcelularcj1.Name = "txtcelularcj1";
            this.txtcelularcj1.ReadOnly = true;
            this.txtcelularcj1.Size = new System.Drawing.Size(157, 29);
            this.txtcelularcj1.TabIndex = 6;
            this.txtcelularcj1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(604, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 21);
            this.label25.TabIndex = 51;
            this.label25.Text = "Celular:";
            // 
            // txttelefonecj1
            // 
            this.txttelefonecj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttelefonecj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonecj1.Location = new System.Drawing.Point(379, 83);
            this.txttelefonecj1.Mask = "(99) 0000-0000";
            this.txttelefonecj1.Name = "txttelefonecj1";
            this.txttelefonecj1.ReadOnly = true;
            this.txttelefonecj1.Size = new System.Drawing.Size(219, 29);
            this.txttelefonecj1.TabIndex = 5;
            this.txttelefonecj1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(379, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 21);
            this.label26.TabIndex = 51;
            this.label26.Text = "Telefone:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Location = new System.Drawing.Point(767, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(167, 21);
            this.label27.TabIndex = 51;
            this.label27.Text = "Data Nasc.";
            // 
            // txtemailcj1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtemailcj1, 2);
            this.txtemailcj1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemailcj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcj1.Location = new System.Drawing.Point(3, 83);
            this.txtemailcj1.Name = "txtemailcj1";
            this.txtemailcj1.ReadOnly = true;
            this.txtemailcj1.Size = new System.Drawing.Size(364, 29);
            this.txtemailcj1.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(379, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 21);
            this.label28.TabIndex = 51;
            this.label28.Text = "CPF:";
            // 
            // txtcpfcj1
            // 
            this.txtcpfcj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcpfcj1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfcj1.Location = new System.Drawing.Point(379, 24);
            this.txtcpfcj1.Name = "txtcpfcj1";
            this.txtcpfcj1.ReadOnly = true;
            this.txtcpfcj1.Size = new System.Drawing.Size(219, 32);
            this.txtcpfcj1.TabIndex = 1;
            this.txtcpfcj1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpfcj1_KeyUp);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label29, 2);
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Location = new System.Drawing.Point(3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(370, 21);
            this.label29.TabIndex = 51;
            this.label29.Text = "Nome do Cônjuge 1:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label30, 2);
            this.label30.Location = new System.Drawing.Point(3, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 21);
            this.label30.TabIndex = 51;
            this.label30.Text = "Email:";
            // 
            // txtnasccj1
            // 
            this.txtnasccj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasccj1.Location = new System.Drawing.Point(767, 24);
            this.txtnasccj1.Mask = "00/00/0000";
            this.txtnasccj1.Name = "txtnasccj1";
            this.txtnasccj1.ReadOnly = true;
            this.txtnasccj1.Size = new System.Drawing.Size(110, 29);
            this.txtnasccj1.TabIndex = 3;
            this.txtnasccj1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasccj1.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomecj1
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtnomecj1, 2);
            this.txtnomecj1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecj1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecj1.Location = new System.Drawing.Point(3, 24);
            this.txtnomecj1.Name = "txtnomecj1";
            this.txtnomecj1.ReadOnly = true;
            this.txtnomecj1.Size = new System.Drawing.Size(364, 32);
            this.txtnomecj1.TabIndex = 0;
            // 
            // txtrgcj1
            // 
            this.txtrgcj1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgcj1.Location = new System.Drawing.Point(604, 24);
            this.txtrgcj1.Name = "txtrgcj1";
            this.txtrgcj1.ReadOnly = true;
            this.txtrgcj1.Size = new System.Drawing.Size(157, 29);
            this.txtrgcj1.TabIndex = 2;
            this.txtrgcj1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrgcj1_KeyUp);
            // 
            // checkBox_statuscj1
            // 
            this.checkBox_statuscj1.AutoSize = true;
            this.checkBox_statuscj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_statuscj1.Enabled = false;
            this.checkBox_statuscj1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_statuscj1.Location = new System.Drawing.Point(604, 118);
            this.checkBox_statuscj1.Name = "checkBox_statuscj1";
            this.checkBox_statuscj1.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.SetRowSpan(this.checkBox_statuscj1, 2);
            this.checkBox_statuscj1.Size = new System.Drawing.Size(157, 71);
            this.checkBox_statuscj1.TabIndex = 13;
            this.checkBox_statuscj1.Text = "Cônjuge Ativo";
            this.checkBox_statuscj1.UseVisualStyleBackColor = true;
            // 
            // tabconjuge2
            // 
            this.tabconjuge2.Controls.Add(this.tableLayoutPanel4);
            this.tabconjuge2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconjuge2.Location = new System.Drawing.Point(4, 30);
            this.tabconjuge2.Name = "tabconjuge2";
            this.tabconjuge2.Padding = new System.Windows.Forms.Padding(20);
            this.tabconjuge2.Size = new System.Drawing.Size(974, 317);
            this.tabconjuge2.TabIndex = 6;
            this.tabconjuge2.Text = "Cônjuge 2";
            this.tabconjuge2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnsalvarcj2, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.btncancelcj2, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.btn_excluircj2, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.btncj2, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.txtobservacaocj2, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.txtcontacj2, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtagenciacj2, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label32, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label33, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label34, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtrendacj2, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.label35, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtcelularcj2, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.label36, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txttelefonecj2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label37, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label38, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtemailcj2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label39, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtcpfcj2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label40, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label41, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtnasccj2, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtnomecj2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtrgcj2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_statuscj2, 3, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 12;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(934, 324);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnsalvarcj2
            // 
            this.btnsalvarcj2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnsalvarcj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsalvarcj2.FlatAppearance.BorderSize = 0;
            this.btnsalvarcj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarcj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarcj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsalvarcj2.Location = new System.Drawing.Point(3, 251);
            this.btnsalvarcj2.Name = "btnsalvarcj2";
            this.btnsalvarcj2.Padding = new System.Windows.Forms.Padding(4);
            this.btnsalvarcj2.Size = new System.Drawing.Size(183, 32);
            this.btnsalvarcj2.TabIndex = 82;
            this.btnsalvarcj2.Text = "Salvar";
            this.btnsalvarcj2.UseCompatibleTextRendering = true;
            this.btnsalvarcj2.UseVisualStyleBackColor = false;
            this.btnsalvarcj2.Click += new System.EventHandler(this.btnsalvarcj2_Click);
            // 
            // btncancelcj2
            // 
            this.btncancelcj2.BackColor = System.Drawing.Color.SlateGray;
            this.btncancelcj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelcj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelcj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelcj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelcj2.Location = new System.Drawing.Point(192, 251);
            this.btncancelcj2.Name = "btncancelcj2";
            this.btncancelcj2.Padding = new System.Windows.Forms.Padding(4);
            this.btncancelcj2.Size = new System.Drawing.Size(183, 32);
            this.btncancelcj2.TabIndex = 81;
            this.btncancelcj2.Text = "Cancelar";
            this.btncancelcj2.UseCompatibleTextRendering = true;
            this.btncancelcj2.UseVisualStyleBackColor = false;
            this.btncancelcj2.Click += new System.EventHandler(this.btncancelcj2_Click);
            // 
            // btn_excluircj2
            // 
            this.btn_excluircj2.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluircj2.CausesValidation = false;
            this.btn_excluircj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluircj2.FlatAppearance.BorderSize = 0;
            this.btn_excluircj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluircj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluircj2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluircj2.Location = new System.Drawing.Point(192, 289);
            this.btn_excluircj2.Name = "btn_excluircj2";
            this.btn_excluircj2.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluircj2.Size = new System.Drawing.Size(183, 32);
            this.btn_excluircj2.TabIndex = 76;
            this.btn_excluircj2.Text = "Excluir Cônjuge 2";
            this.btn_excluircj2.UseCompatibleTextRendering = true;
            this.btn_excluircj2.UseVisualStyleBackColor = false;
            this.btn_excluircj2.Visible = false;
            this.btn_excluircj2.Click += new System.EventHandler(this.btn_excluirconjuge2_Click);
            // 
            // btncj2
            // 
            this.btncj2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btncj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncj2.FlatAppearance.BorderSize = 0;
            this.btncj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncj2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncj2.Location = new System.Drawing.Point(3, 289);
            this.btncj2.Name = "btncj2";
            this.btncj2.Padding = new System.Windows.Forms.Padding(4);
            this.btncj2.Size = new System.Drawing.Size(183, 32);
            this.btncj2.TabIndex = 75;
            this.btncj2.Text = "Adicionar + Cônjuge";
            this.btncj2.UseCompatibleTextRendering = true;
            this.btncj2.UseVisualStyleBackColor = false;
            this.btncj2.Visible = false;
            this.btncj2.Click += new System.EventHandler(this.btnconjuge3_Click);
            // 
            // txtobservacaocj2
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txtobservacaocj2, 3);
            this.txtobservacaocj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacaocj2.Location = new System.Drawing.Point(3, 216);
            this.txtobservacaocj2.Name = "txtobservacaocj2";
            this.txtobservacaocj2.ReadOnly = true;
            this.txtobservacaocj2.Size = new System.Drawing.Size(589, 29);
            this.txtobservacaocj2.TabIndex = 72;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 192);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 21);
            this.label31.TabIndex = 71;
            this.label31.Text = "Observações:";
            // 
            // txtcontacj2
            // 
            this.txtcontacj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacj2.Location = new System.Drawing.Point(192, 139);
            this.txtcontacj2.Name = "txtcontacj2";
            this.txtcontacj2.ReadOnly = true;
            this.txtcontacj2.Size = new System.Drawing.Size(183, 29);
            this.txtcontacj2.TabIndex = 9;
            // 
            // txtagenciacj2
            // 
            this.txtagenciacj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtagenciacj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacj2.Location = new System.Drawing.Point(3, 139);
            this.txtagenciacj2.Name = "txtagenciacj2";
            this.txtagenciacj2.ReadOnly = true;
            this.txtagenciacj2.Size = new System.Drawing.Size(183, 29);
            this.txtagenciacj2.TabIndex = 8;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 115);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 21);
            this.label32.TabIndex = 69;
            this.label32.Text = "Agencia:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(192, 115);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 21);
            this.label33.TabIndex = 70;
            this.label33.Text = "Conta:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(769, 59);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 21);
            this.label34.TabIndex = 55;
            this.label34.Text = "Renda:";
            // 
            // txtrendacj2
            // 
            this.txtrendacj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacj2.Location = new System.Drawing.Point(769, 83);
            this.txtrendacj2.Name = "txtrendacj2";
            this.txtrendacj2.ReadOnly = true;
            this.txtrendacj2.Size = new System.Drawing.Size(167, 29);
            this.txtrendacj2.TabIndex = 7;
            this.txtrendacj2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacj2_KeyPress);
            this.txtrendacj2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacj2_KeyUp);
            this.txtrendacj2.Leave += new System.EventHandler(this.txtrendacj2_Leave);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(606, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 21);
            this.label35.TabIndex = 52;
            this.label35.Text = "RG:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_Femininocj2);
            this.groupBox4.Controls.Add(this.checkBox_Masculinocj2);
            this.groupBox4.Location = new System.Drawing.Point(381, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.SetRowSpan(this.groupBox4, 2);
            this.groupBox4.Size = new System.Drawing.Size(193, 71);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo:";
            // 
            // checkBox_Femininocj2
            // 
            this.checkBox_Femininocj2.AutoSize = true;
            this.checkBox_Femininocj2.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Femininocj2.Enabled = false;
            this.checkBox_Femininocj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Femininocj2.Location = new System.Drawing.Point(98, 27);
            this.checkBox_Femininocj2.Name = "checkBox_Femininocj2";
            this.checkBox_Femininocj2.Size = new System.Drawing.Size(85, 39);
            this.checkBox_Femininocj2.TabIndex = 12;
            this.checkBox_Femininocj2.TabStop = true;
            this.checkBox_Femininocj2.Text = "Feminino";
            this.checkBox_Femininocj2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Masculinocj2
            // 
            this.checkBox_Masculinocj2.AutoSize = true;
            this.checkBox_Masculinocj2.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculinocj2.Enabled = false;
            this.checkBox_Masculinocj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculinocj2.Location = new System.Drawing.Point(5, 27);
            this.checkBox_Masculinocj2.Name = "checkBox_Masculinocj2";
            this.checkBox_Masculinocj2.Size = new System.Drawing.Size(93, 39);
            this.checkBox_Masculinocj2.TabIndex = 11;
            this.checkBox_Masculinocj2.TabStop = true;
            this.checkBox_Masculinocj2.Text = "Masculino";
            this.checkBox_Masculinocj2.UseVisualStyleBackColor = true;
            // 
            // txtcelularcj2
            // 
            this.txtcelularcj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelularcj2.Location = new System.Drawing.Point(606, 83);
            this.txtcelularcj2.Mask = "(99) 00000-0000";
            this.txtcelularcj2.Name = "txtcelularcj2";
            this.txtcelularcj2.ReadOnly = true;
            this.txtcelularcj2.Size = new System.Drawing.Size(157, 29);
            this.txtcelularcj2.TabIndex = 6;
            this.txtcelularcj2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(606, 59);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(63, 21);
            this.label36.TabIndex = 51;
            this.label36.Text = "Celular:";
            // 
            // txttelefonecj2
            // 
            this.txttelefonecj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttelefonecj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonecj2.Location = new System.Drawing.Point(381, 83);
            this.txttelefonecj2.Mask = "(99) 0000-0000";
            this.txttelefonecj2.Name = "txttelefonecj2";
            this.txttelefonecj2.ReadOnly = true;
            this.txttelefonecj2.Size = new System.Drawing.Size(219, 29);
            this.txttelefonecj2.TabIndex = 5;
            this.txttelefonecj2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(381, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 21);
            this.label37.TabIndex = 51;
            this.label37.Text = "Telefone:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Top;
            this.label38.Location = new System.Drawing.Point(769, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(167, 21);
            this.label38.TabIndex = 51;
            this.label38.Text = "Data Nasc.";
            // 
            // txtemailcj2
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txtemailcj2, 2);
            this.txtemailcj2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemailcj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcj2.Location = new System.Drawing.Point(3, 83);
            this.txtemailcj2.Name = "txtemailcj2";
            this.txtemailcj2.ReadOnly = true;
            this.txtemailcj2.Size = new System.Drawing.Size(364, 29);
            this.txtemailcj2.TabIndex = 4;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(381, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(39, 21);
            this.label39.TabIndex = 51;
            this.label39.Text = "CPF:";
            // 
            // txtcpfcj2
            // 
            this.txtcpfcj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcpfcj2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfcj2.Location = new System.Drawing.Point(381, 24);
            this.txtcpfcj2.Name = "txtcpfcj2";
            this.txtcpfcj2.ReadOnly = true;
            this.txtcpfcj2.Size = new System.Drawing.Size(219, 32);
            this.txtcpfcj2.TabIndex = 1;
            this.txtcpfcj2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpfcj2_KeyUp);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label40, 2);
            this.label40.Dock = System.Windows.Forms.DockStyle.Top;
            this.label40.Location = new System.Drawing.Point(3, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(372, 21);
            this.label40.TabIndex = 51;
            this.label40.Text = "Nome do Cônjuge 2:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label41, 2);
            this.label41.Location = new System.Drawing.Point(3, 59);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 21);
            this.label41.TabIndex = 51;
            this.label41.Text = "Email:";
            // 
            // txtnasccj2
            // 
            this.txtnasccj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasccj2.Location = new System.Drawing.Point(769, 24);
            this.txtnasccj2.Mask = "00/00/0000";
            this.txtnasccj2.Name = "txtnasccj2";
            this.txtnasccj2.ReadOnly = true;
            this.txtnasccj2.Size = new System.Drawing.Size(110, 29);
            this.txtnasccj2.TabIndex = 3;
            this.txtnasccj2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasccj2.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomecj2
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txtnomecj2, 2);
            this.txtnomecj2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecj2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecj2.Location = new System.Drawing.Point(3, 24);
            this.txtnomecj2.Name = "txtnomecj2";
            this.txtnomecj2.ReadOnly = true;
            this.txtnomecj2.Size = new System.Drawing.Size(364, 32);
            this.txtnomecj2.TabIndex = 0;
            // 
            // txtrgcj2
            // 
            this.txtrgcj2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgcj2.Location = new System.Drawing.Point(606, 24);
            this.txtrgcj2.Name = "txtrgcj2";
            this.txtrgcj2.ReadOnly = true;
            this.txtrgcj2.Size = new System.Drawing.Size(157, 29);
            this.txtrgcj2.TabIndex = 2;
            this.txtrgcj2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrgcj2_KeyUp);
            // 
            // checkBox_statuscj2
            // 
            this.checkBox_statuscj2.AutoSize = true;
            this.checkBox_statuscj2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_statuscj2.Enabled = false;
            this.checkBox_statuscj2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_statuscj2.Location = new System.Drawing.Point(606, 118);
            this.checkBox_statuscj2.Name = "checkBox_statuscj2";
            this.checkBox_statuscj2.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.SetRowSpan(this.checkBox_statuscj2, 2);
            this.checkBox_statuscj2.Size = new System.Drawing.Size(157, 71);
            this.checkBox_statuscj2.TabIndex = 13;
            this.checkBox_statuscj2.Text = "Cônjuge Ativo";
            this.checkBox_statuscj2.UseVisualStyleBackColor = true;
            // 
            // tabconjuge3
            // 
            this.tabconjuge3.Controls.Add(this.tableLayoutPanel5);
            this.tabconjuge3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabconjuge3.Location = new System.Drawing.Point(4, 30);
            this.tabconjuge3.Name = "tabconjuge3";
            this.tabconjuge3.Padding = new System.Windows.Forms.Padding(20);
            this.tabconjuge3.Size = new System.Drawing.Size(974, 317);
            this.tabconjuge3.TabIndex = 7;
            this.tabconjuge3.Text = "Cônjuge 3";
            this.tabconjuge3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.btnsalvarcj3, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.btncancelcj3, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.btn_excluircj3, 0, 11);
            this.tableLayoutPanel5.Controls.Add(this.txtobservacaocj3, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.label42, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.txtcontacj3, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.txtagenciacj3, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label43, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label44, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label45, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtrendacj3, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.label46, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.txtcelularcj3, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.label47, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.txttelefonecj3, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label48, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label49, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtemailcj3, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label50, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtcpfcj3, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label51, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label52, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtnasccj3, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtnomecj3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtrgcj3, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.checkBox_statuscj3, 3, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 12;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(934, 324);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnsalvarcj3
            // 
            this.btnsalvarcj3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnsalvarcj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsalvarcj3.FlatAppearance.BorderSize = 0;
            this.btnsalvarcj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvarcj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarcj3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsalvarcj3.Location = new System.Drawing.Point(3, 251);
            this.btnsalvarcj3.Name = "btnsalvarcj3";
            this.btnsalvarcj3.Padding = new System.Windows.Forms.Padding(4);
            this.btnsalvarcj3.Size = new System.Drawing.Size(183, 32);
            this.btnsalvarcj3.TabIndex = 84;
            this.btnsalvarcj3.Text = "Salvar";
            this.btnsalvarcj3.UseCompatibleTextRendering = true;
            this.btnsalvarcj3.UseVisualStyleBackColor = false;
            this.btnsalvarcj3.Click += new System.EventHandler(this.btnsalvarcj3_Click);
            // 
            // btncancelcj3
            // 
            this.btncancelcj3.BackColor = System.Drawing.Color.SlateGray;
            this.btncancelcj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btncancelcj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelcj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelcj3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelcj3.Location = new System.Drawing.Point(192, 251);
            this.btncancelcj3.Name = "btncancelcj3";
            this.btncancelcj3.Padding = new System.Windows.Forms.Padding(4);
            this.btncancelcj3.Size = new System.Drawing.Size(183, 32);
            this.btncancelcj3.TabIndex = 83;
            this.btncancelcj3.Text = "Cancelar";
            this.btncancelcj3.UseCompatibleTextRendering = true;
            this.btncancelcj3.UseVisualStyleBackColor = false;
            this.btncancelcj3.Click += new System.EventHandler(this.btncancelcj3_Click);
            // 
            // btn_excluircj3
            // 
            this.btn_excluircj3.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluircj3.CausesValidation = false;
            this.btn_excluircj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_excluircj3.FlatAppearance.BorderSize = 0;
            this.btn_excluircj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluircj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluircj3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_excluircj3.Location = new System.Drawing.Point(3, 289);
            this.btn_excluircj3.Name = "btn_excluircj3";
            this.btn_excluircj3.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluircj3.Size = new System.Drawing.Size(183, 32);
            this.btn_excluircj3.TabIndex = 76;
            this.btn_excluircj3.Text = "Excluir Cônjuge 3";
            this.btn_excluircj3.UseCompatibleTextRendering = true;
            this.btn_excluircj3.UseVisualStyleBackColor = false;
            this.btn_excluircj3.Visible = false;
            this.btn_excluircj3.Click += new System.EventHandler(this.btn_excluirconjuge3_Click);
            // 
            // txtobservacaocj3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.txtobservacaocj3, 3);
            this.txtobservacaocj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacaocj3.Location = new System.Drawing.Point(3, 216);
            this.txtobservacaocj3.Name = "txtobservacaocj3";
            this.txtobservacaocj3.ReadOnly = true;
            this.txtobservacaocj3.Size = new System.Drawing.Size(589, 29);
            this.txtobservacaocj3.TabIndex = 72;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 192);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 21);
            this.label42.TabIndex = 71;
            this.label42.Text = "Observações:";
            // 
            // txtcontacj3
            // 
            this.txtcontacj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacj3.Location = new System.Drawing.Point(192, 139);
            this.txtcontacj3.Name = "txtcontacj3";
            this.txtcontacj3.ReadOnly = true;
            this.txtcontacj3.Size = new System.Drawing.Size(183, 29);
            this.txtcontacj3.TabIndex = 9;
            // 
            // txtagenciacj3
            // 
            this.txtagenciacj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtagenciacj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciacj3.Location = new System.Drawing.Point(3, 139);
            this.txtagenciacj3.Name = "txtagenciacj3";
            this.txtagenciacj3.ReadOnly = true;
            this.txtagenciacj3.Size = new System.Drawing.Size(183, 29);
            this.txtagenciacj3.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 115);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(70, 21);
            this.label43.TabIndex = 69;
            this.label43.Text = "Agencia:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(192, 115);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(55, 21);
            this.label44.TabIndex = 70;
            this.label44.Text = "Conta:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(769, 59);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 21);
            this.label45.TabIndex = 55;
            this.label45.Text = "Renda:";
            // 
            // txtrendacj3
            // 
            this.txtrendacj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacj3.Location = new System.Drawing.Point(769, 83);
            this.txtrendacj3.Name = "txtrendacj3";
            this.txtrendacj3.ReadOnly = true;
            this.txtrendacj3.Size = new System.Drawing.Size(167, 29);
            this.txtrendacj3.TabIndex = 7;
            this.txtrendacj3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacj3_KeyPress);
            this.txtrendacj3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacj3_KeyUp);
            this.txtrendacj3.Leave += new System.EventHandler(this.txtrendacj3_Leave);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(606, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(32, 21);
            this.label46.TabIndex = 52;
            this.label46.Text = "RG:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_Femininocj3);
            this.groupBox5.Controls.Add(this.checkBox_Masculinocj3);
            this.groupBox5.Location = new System.Drawing.Point(381, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.SetRowSpan(this.groupBox5, 2);
            this.groupBox5.Size = new System.Drawing.Size(193, 71);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sexo:";
            // 
            // checkBox_Femininocj3
            // 
            this.checkBox_Femininocj3.AutoSize = true;
            this.checkBox_Femininocj3.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Femininocj3.Enabled = false;
            this.checkBox_Femininocj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Femininocj3.Location = new System.Drawing.Point(98, 27);
            this.checkBox_Femininocj3.Name = "checkBox_Femininocj3";
            this.checkBox_Femininocj3.Size = new System.Drawing.Size(85, 39);
            this.checkBox_Femininocj3.TabIndex = 12;
            this.checkBox_Femininocj3.TabStop = true;
            this.checkBox_Femininocj3.Text = "Feminino";
            this.checkBox_Femininocj3.UseVisualStyleBackColor = true;
            // 
            // checkBox_Masculinocj3
            // 
            this.checkBox_Masculinocj3.AutoSize = true;
            this.checkBox_Masculinocj3.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculinocj3.Enabled = false;
            this.checkBox_Masculinocj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculinocj3.Location = new System.Drawing.Point(5, 27);
            this.checkBox_Masculinocj3.Name = "checkBox_Masculinocj3";
            this.checkBox_Masculinocj3.Size = new System.Drawing.Size(93, 39);
            this.checkBox_Masculinocj3.TabIndex = 11;
            this.checkBox_Masculinocj3.TabStop = true;
            this.checkBox_Masculinocj3.Text = "Masculino";
            this.checkBox_Masculinocj3.UseVisualStyleBackColor = true;
            // 
            // txtcelularcj3
            // 
            this.txtcelularcj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelularcj3.Location = new System.Drawing.Point(606, 83);
            this.txtcelularcj3.Mask = "(99) 00000-0000";
            this.txtcelularcj3.Name = "txtcelularcj3";
            this.txtcelularcj3.ReadOnly = true;
            this.txtcelularcj3.Size = new System.Drawing.Size(157, 29);
            this.txtcelularcj3.TabIndex = 6;
            this.txtcelularcj3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(606, 59);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(63, 21);
            this.label47.TabIndex = 51;
            this.label47.Text = "Celular:";
            // 
            // txttelefonecj3
            // 
            this.txttelefonecj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttelefonecj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonecj3.Location = new System.Drawing.Point(381, 83);
            this.txttelefonecj3.Mask = "(99) 0000-0000";
            this.txttelefonecj3.Name = "txttelefonecj3";
            this.txttelefonecj3.ReadOnly = true;
            this.txttelefonecj3.Size = new System.Drawing.Size(219, 29);
            this.txttelefonecj3.TabIndex = 5;
            this.txttelefonecj3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(381, 59);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(71, 21);
            this.label48.TabIndex = 51;
            this.label48.Text = "Telefone:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Dock = System.Windows.Forms.DockStyle.Top;
            this.label49.Location = new System.Drawing.Point(769, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(167, 21);
            this.label49.TabIndex = 51;
            this.label49.Text = "Data Nasc.";
            // 
            // txtemailcj3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.txtemailcj3, 2);
            this.txtemailcj3.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtemailcj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcj3.Location = new System.Drawing.Point(3, 83);
            this.txtemailcj3.Name = "txtemailcj3";
            this.txtemailcj3.ReadOnly = true;
            this.txtemailcj3.Size = new System.Drawing.Size(364, 29);
            this.txtemailcj3.TabIndex = 4;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(381, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(39, 21);
            this.label50.TabIndex = 51;
            this.label50.Text = "CPF:";
            // 
            // txtcpfcj3
            // 
            this.txtcpfcj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcpfcj3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfcj3.Location = new System.Drawing.Point(381, 24);
            this.txtcpfcj3.Name = "txtcpfcj3";
            this.txtcpfcj3.ReadOnly = true;
            this.txtcpfcj3.Size = new System.Drawing.Size(219, 32);
            this.txtcpfcj3.TabIndex = 1;
            this.txtcpfcj3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpfcj3_KeyUp);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label51, 2);
            this.label51.Dock = System.Windows.Forms.DockStyle.Top;
            this.label51.Location = new System.Drawing.Point(3, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(372, 21);
            this.label51.TabIndex = 51;
            this.label51.Text = "Nome do Cônjuge 3:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label52, 2);
            this.label52.Location = new System.Drawing.Point(3, 59);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(52, 21);
            this.label52.TabIndex = 51;
            this.label52.Text = "Email:";
            // 
            // txtnasccj3
            // 
            this.txtnasccj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnasccj3.Location = new System.Drawing.Point(769, 24);
            this.txtnasccj3.Mask = "00/00/0000";
            this.txtnasccj3.Name = "txtnasccj3";
            this.txtnasccj3.ReadOnly = true;
            this.txtnasccj3.Size = new System.Drawing.Size(110, 29);
            this.txtnasccj3.TabIndex = 3;
            this.txtnasccj3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasccj3.ValidatingType = typeof(System.DateTime);
            // 
            // txtnomecj3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.txtnomecj3, 2);
            this.txtnomecj3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecj3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomecj3.Location = new System.Drawing.Point(3, 24);
            this.txtnomecj3.Name = "txtnomecj3";
            this.txtnomecj3.ReadOnly = true;
            this.txtnomecj3.Size = new System.Drawing.Size(364, 32);
            this.txtnomecj3.TabIndex = 0;
            // 
            // txtrgcj3
            // 
            this.txtrgcj3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrgcj3.Location = new System.Drawing.Point(606, 24);
            this.txtrgcj3.Name = "txtrgcj3";
            this.txtrgcj3.ReadOnly = true;
            this.txtrgcj3.Size = new System.Drawing.Size(157, 29);
            this.txtrgcj3.TabIndex = 2;
            this.txtrgcj3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrgcj3_KeyUp);
            // 
            // checkBox_statuscj3
            // 
            this.checkBox_statuscj3.AutoSize = true;
            this.checkBox_statuscj3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_statuscj3.Enabled = false;
            this.checkBox_statuscj3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_statuscj3.Location = new System.Drawing.Point(606, 118);
            this.checkBox_statuscj3.Name = "checkBox_statuscj3";
            this.checkBox_statuscj3.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel5.SetRowSpan(this.checkBox_statuscj3, 2);
            this.checkBox_statuscj3.Size = new System.Drawing.Size(157, 71);
            this.checkBox_statuscj3.TabIndex = 13;
            this.checkBox_statuscj3.Text = "Cônjuge Ativo";
            this.checkBox_statuscj3.UseVisualStyleBackColor = true;
            // 
            // Foto
            // 
            this.Foto.AutoScroll = true;
            this.Foto.Controls.Add(this.btn_limpar_foto);
            this.Foto.Controls.Add(this.btn_add_foto);
            this.Foto.Controls.Add(this.img_foto);
            this.Foto.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foto.Location = new System.Drawing.Point(4, 30);
            this.Foto.Name = "Foto";
            this.Foto.Padding = new System.Windows.Forms.Padding(20);
            this.Foto.Size = new System.Drawing.Size(974, 317);
            this.Foto.TabIndex = 3;
            this.Foto.Text = "Foto Cliente";
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
            this.btn_limpar_foto.Location = new System.Drawing.Point(193, 271);
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
            this.btn_add_foto.Location = new System.Drawing.Point(70, 271);
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
            this.img_foto.Location = new System.Drawing.Point(70, 14);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(227, 251);
            this.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_foto.TabIndex = 0;
            this.img_foto.TabStop = false;
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
            this.panel1.Location = new System.Drawing.Point(0, 634);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1022, 52);
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
            this.btn_excluir.TabIndex = 17;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseCompatibleTextRendering = true;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // splitter3
            // 
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
            this.btn_cancelar.TabIndex = 16;
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
            this.btn_salvar.TabIndex = 15;
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
            this.btn_editar.TabIndex = 14;
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
            this.btnclosecli.Location = new System.Drawing.Point(908, 10);
            this.btnclosecli.Name = "btnclosecli";
            this.btnclosecli.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosecli.Size = new System.Drawing.Size(104, 32);
            this.btnclosecli.TabIndex = 18;
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
            this.paneltop.Size = new System.Drawing.Size(1022, 57);
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
            this.lbl_topo.Size = new System.Drawing.Size(270, 49);
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
            // Form_Dados_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 686);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Cliente";
            this.Load += new System.EventHandler(this.Form_Dados_cliente_Load);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbrenda.ResumeLayout(false);
            this.gbrenda.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabcliente.ResumeLayout(false);
            this.tabcliente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabconjuge.ResumeLayout(false);
            this.tabconjuge.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabconjuge1.ResumeLayout(false);
            this.tabconjuge1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabconjuge2.ResumeLayout(false);
            this.tabconjuge2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabconjuge3.ResumeLayout(false);
            this.tabconjuge3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private Button btn_excluir;
        private Splitter splitter3;
        private TextBox txtcontacliente;
        private TextBox txtagenciacliente;
        private Label label2;
        private Label label5;
        private TextBox txtobservacoes;
        private Label label6;
        private TabPage tabconjuge;
        private TabPage tabconjuge1;
        private TabPage tabconjuge2;
        private TabPage tabconjuge3;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtobservacaocj;
        private Label label7;
        private TextBox txtcontacj;
        private TextBox txtagenciacj;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtrendacj;
        private Label label11;
        private GroupBox groupBox1;
        private RadioButton checkBox_Femininocj;
        private RadioButton checkBox_Masculinocj;
        private MaskedTextBox txtcelularcj;
        private Label label12;
        private MaskedTextBox txttelefonecj;
        private Label label13;
        private Label label14;
        private TextBox txtemailcj;
        private Label label15;
        private TextBox txtcpfcj;
        private Label label16;
        private Label label17;
        private MaskedTextBox txtnasccj;
        private TextBox txtnomeconjuge;
        private TextBox txtrgcj;
        private CheckBox checkBox_statuscj;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtobservacaocj1;
        private Label label18;
        private TextBox txtcontacj1;
        private TextBox txtagenciacj1;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtrendacj1;
        private Label label24;
        private GroupBox groupBox3;
        private RadioButton checkBox_Femininocj1;
        private RadioButton checkBox_Masculinocj1;
        private MaskedTextBox txtcelularcj1;
        private Label label25;
        private MaskedTextBox txttelefonecj1;
        private Label label26;
        private Label label27;
        private TextBox txtemailcj1;
        private Label label28;
        private TextBox txtcpfcj1;
        private Label label29;
        private Label label30;
        private MaskedTextBox txtnasccj1;
        private TextBox txtnomecj1;
        private TextBox txtrgcj1;
        private CheckBox checkBox_statuscj1;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtobservacaocj2;
        private Label label31;
        private TextBox txtcontacj2;
        private TextBox txtagenciacj2;
        private Label label32;
        private Label label33;
        private Label label34;
        private TextBox txtrendacj2;
        private Label label35;
        private GroupBox groupBox4;
        private RadioButton checkBox_Femininocj2;
        private RadioButton checkBox_Masculinocj2;
        private MaskedTextBox txtcelularcj2;
        private Label label36;
        private MaskedTextBox txttelefonecj2;
        private Label label37;
        private Label label38;
        private TextBox txtemailcj2;
        private Label label39;
        private TextBox txtcpfcj2;
        private Label label40;
        private Label label41;
        private MaskedTextBox txtnasccj2;
        private TextBox txtnomecj2;
        private TextBox txtrgcj2;
        private CheckBox checkBox_statuscj2;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtobservacaocj3;
        private Label label42;
        private TextBox txtcontacj3;
        private TextBox txtagenciacj3;
        private Label label43;
        private Label label44;
        private Label label45;
        private TextBox txtrendacj3;
        private Label label46;
        private GroupBox groupBox5;
        private RadioButton checkBox_Femininocj3;
        private RadioButton checkBox_Masculinocj3;
        private MaskedTextBox txtcelularcj3;
        private Label label47;
        private MaskedTextBox txttelefonecj3;
        private Label label48;
        private Label label49;
        private TextBox txtemailcj3;
        private Label label50;
        private TextBox txtcpfcj3;
        private Label label51;
        private Label label52;
        private MaskedTextBox txtnasccj3;
        private TextBox txtnomecj3;
        private TextBox txtrgcj3;
        private CheckBox checkBox_statuscj3;
        private Button btn_excluircj;
        private Button btncj;
        private Button btnaonjuge;
        private Button btncj1;
        private Button btn_excluircj1;
        private Button btn_excluircj3;
        private Button btbsalvarcj;
        private Button btncancelcj;
        private Button btnsalvarcj1;
        private Button btncancelcj1;
        private Button btncancelcj2;
        private Button btnsalvarcj2;
        private Button btn_excluircj2;
        private Button btncj2;
        private Button btnsalvarcj3;
        private Button btncancelcj3;
        private Panel panel3;
        private GroupBox gbrenda;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblnomecj4;
        private Label lbl04;
        private Label lblrendacj4;
        private Label lblrendacj3;
        private Label lblrendacj2;
        private Label lblrendacj1;
        private Label lblrendacli;
        private Label lblnomecj3;
        private Label lblnomecj2;
        private Label lblnomecj1;
        private Label lblnomeclirenda;
        private Label lblrendabruta;
        private Label lbl01;
        private Label lbl02;
        private Label lbl03;
        private Label lbl0;
        private TextBox txtrendatotal;
    }
}