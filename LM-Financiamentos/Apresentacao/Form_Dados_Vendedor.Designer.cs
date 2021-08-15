
using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Windows;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Vendedor));
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabcliente = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrendavendedor = new System.Windows.Forms.TextBox();
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
            this.txtnomevendedor = new System.Windows.Forms.TextBox();
            this.txtcnpj = new System.Windows.Forms.TextBox();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.txtcontavendedor = new System.Windows.Forms.TextBox();
            this.txtagenciavendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl.SuspendLayout();
            this.tabcliente.SuspendLayout();
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
            this.tabcliente.Controls.Add(this.tableLayoutPanel1);
            this.tabcliente.Location = new System.Drawing.Point(4, 32);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.Padding = new System.Windows.Forms.Padding(20);
            this.tabcliente.Size = new System.Drawing.Size(971, 472);
            this.tabcliente.TabIndex = 0;
            this.tabcliente.Text = "Dados do Cliente";
            this.tabcliente.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtrendavendedor, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtcelular, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttelefone, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcpf, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblemail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnasc, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtnomevendedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtcnpj, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_status, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcontavendedor, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtagenciavendedor, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 187);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(166, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(750, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Renda Bruta:";
            // 
            // txtrendavendedor
            // 
            this.txtrendavendedor.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendavendedor.Location = new System.Drawing.Point(750, 85);
            this.txtrendavendedor.Name = "txtrendavendedor";
            this.txtrendavendedor.ReadOnly = true;
            this.txtrendavendedor.Size = new System.Drawing.Size(178, 27);
            this.txtrendavendedor.TabIndex = 7;
            this.txtrendavendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacli_KeyPress);
            this.txtrendavendedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacli_KeyUp);
            this.txtrendavendedor.Leave += new System.EventHandler(this.txtrendacli_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "CNPJ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Feminino);
            this.groupBox2.Controls.Add(this.checkBox_Masculino);
            this.groupBox2.Location = new System.Drawing.Point(559, 118);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(185, 68);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            this.groupBox2.Visible = false;
            // 
            // checkBox_Feminino
            // 
            this.checkBox_Feminino.AutoSize = true;
            this.checkBox_Feminino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Feminino.Enabled = false;
            this.checkBox_Feminino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Feminino.Location = new System.Drawing.Point(96, 23);
            this.checkBox_Feminino.Name = "checkBox_Feminino";
            this.checkBox_Feminino.Size = new System.Drawing.Size(86, 42);
            this.checkBox_Feminino.TabIndex = 10;
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
            this.checkBox_Masculino.Size = new System.Drawing.Size(93, 42);
            this.checkBox_Masculino.TabIndex = 9;
            this.checkBox_Masculino.TabStop = true;
            this.checkBox_Masculino.Text = "Masculino";
            this.checkBox_Masculino.UseVisualStyleBackColor = true;
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(559, 85);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(164, 27);
            this.txtcelular.TabIndex = 6;
            this.txtcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(559, 59);
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
            this.txttelefone.Size = new System.Drawing.Size(164, 27);
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
            this.label1.Location = new System.Drawing.Point(750, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Data Nasc.";
            this.label1.Visible = false;
            // 
            // txtemail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtemail, 2);
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
            this.txtcpf.Size = new System.Drawing.Size(180, 30);
            this.txtcpf.TabIndex = 1;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcliente.Location = new System.Drawing.Point(3, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(157, 23);
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
            this.txtnasc.Location = new System.Drawing.Point(750, 142);
            this.txtnasc.Mask = "00/00/0000";
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.ReadOnly = true;
            this.txtnasc.Size = new System.Drawing.Size(110, 27);
            this.txtnasc.TabIndex = 12;
            this.txtnasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasc.ValidatingType = typeof(System.DateTime);
            this.txtnasc.Visible = false;
            // 
            // txtnomevendedor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtnomevendedor, 2);
            this.txtnomevendedor.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomevendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomevendedor.Location = new System.Drawing.Point(3, 26);
            this.txtnomevendedor.Name = "txtnomevendedor";
            this.txtnomevendedor.ReadOnly = true;
            this.txtnomevendedor.Size = new System.Drawing.Size(364, 30);
            this.txtnomevendedor.TabIndex = 0;
            // 
            // txtcnpj
            // 
            this.txtcnpj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcnpj.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnpj.Location = new System.Drawing.Point(559, 26);
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.ReadOnly = true;
            this.txtcnpj.Size = new System.Drawing.Size(185, 27);
            this.txtcnpj.TabIndex = 2;
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_status.Enabled = false;
            this.checkBox_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_status.Location = new System.Drawing.Point(750, 3);
            this.checkBox_status.Name = "checkBox_status";
            this.tableLayoutPanel1.SetRowSpan(this.checkBox_status, 2);
            this.checkBox_status.Size = new System.Drawing.Size(178, 53);
            this.checkBox_status.TabIndex = 3;
            this.checkBox_status.Text = "Vendedor Ativo";
            this.checkBox_status.UseVisualStyleBackColor = true;
            this.checkBox_status.CheckedChanged += new System.EventHandler(this.checkBox_status_CheckedChanged);
            // 
            // txtcontavendedor
            // 
            this.txtcontavendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcontavendedor.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontavendedor.Location = new System.Drawing.Point(166, 142);
            this.txtcontavendedor.Name = "txtcontavendedor";
            this.txtcontavendedor.ReadOnly = true;
            this.txtcontavendedor.Size = new System.Drawing.Size(201, 27);
            this.txtcontavendedor.TabIndex = 8;
            // 
            // txtagenciavendedor
            // 
            this.txtagenciavendedor.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagenciavendedor.Location = new System.Drawing.Point(3, 142);
            this.txtagenciavendedor.Name = "txtagenciavendedor";
            this.txtagenciavendedor.ReadOnly = true;
            this.txtagenciavendedor.Size = new System.Drawing.Size(157, 27);
            this.txtagenciavendedor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Agencia:";
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
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.splitter3);
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
            this.btn_excluir.TabIndex = 16;
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
            this.btn_cancelar.TabIndex = 15;
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
            this.btn_salvar.TabIndex = 14;
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
            this.btn_editar.TabIndex = 13;
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
            this.btnclosecli.TabIndex = 17;
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
            this.lbl_topo.Text = "Dados do Vendedor";
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
            // Form_Dados_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Cliente";
            this.Load += new System.EventHandler(this.Form_Dados_Vendedor_Load);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabcliente.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtnomevendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrendavendedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox checkBox_status;
        private OpenFileDialog ofd1;
        private Button btn_limpar_foto;
        private Button btn_excluir;
        private Splitter splitter3;
        private TextBox txtcontavendedor;
        private TextBox txtagenciavendedor;
        private Label label5;
        private Label label2;
    }
}