
using LMFinanciamentos.DAL;
using LMFinanciamentos.Modelo;
using System;
using System.Windows;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Dados_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dados_Funcionario));
            this.panelcentralcadcli = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabfuncionario = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcracha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
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
            this.lblfuncionario = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtnasc = new System.Windows.Forms.MaskedTextBox();
            this.txtnomefuncionario = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.txtpermission = new System.Windows.Forms.ComboBox();
            this.Foto = new System.Windows.Forms.TabPage();
            this.btn_limpar_foto = new System.Windows.Forms.Button();
            this.btn_add_foto = new System.Windows.Forms.Button();
            this.img_foto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_excluir_func = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btn_cancelar_func = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_salvar_func = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_editar_func = new System.Windows.Forms.Button();
            this.btnclosefunc = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.panelcentralcadcli.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabfuncionario.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabfuncionario);
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
            // tabfuncionario
            // 
            this.tabfuncionario.Controls.Add(this.tableLayoutPanel1);
            this.tabfuncionario.Location = new System.Drawing.Point(4, 32);
            this.tabfuncionario.Name = "tabfuncionario";
            this.tabfuncionario.Padding = new System.Windows.Forms.Padding(20);
            this.tabfuncionario.Size = new System.Drawing.Size(971, 472);
            this.tabfuncionario.TabIndex = 0;
            this.tabfuncionario.Text = "Dados do Funcionario";
            this.tabfuncionario.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtcracha, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtendereco, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtrendacli, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtcelular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txttelefone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblcpf, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtcpf, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblfuncionario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblemail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnasc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnomefuncionario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtrg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox_status, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtpermission, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 266);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 61;
            this.label6.Text = "Permissão:";
            // 
            // txtcracha
            // 
            this.txtcracha.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtcracha.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcracha.Location = new System.Drawing.Point(373, 143);
            this.txtcracha.Name = "txtcracha";
            this.txtcracha.ReadOnly = true;
            this.txtcracha.Size = new System.Drawing.Size(170, 27);
            this.txtcracha.TabIndex = 9;
            this.txtcracha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nº Crachá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "Endereço:";
            // 
            // txtendereco
            // 
            this.txtendereco.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtendereco.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(3, 143);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.ReadOnly = true;
            this.txtendereco.Size = new System.Drawing.Size(355, 27);
            this.txtendereco.TabIndex = 8;
            this.txtendereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Renda Bruta:";
            this.label4.Visible = false;
            // 
            // txtrendacli
            // 
            this.txtrendacli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrendacli.Location = new System.Drawing.Point(712, 85);
            this.txtrendacli.Name = "txtrendacli";
            this.txtrendacli.ReadOnly = true;
            this.txtrendacli.Size = new System.Drawing.Size(216, 27);
            this.txtrendacli.TabIndex = 7;
            this.txtrendacli.Visible = false;
            this.txtrendacli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            this.txtrendacli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrendacli_KeyPress);
            this.txtrendacli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtrendacli_KeyUp);
            this.txtrendacli.Leave += new System.EventHandler(this.txtrendacli_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "RG:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Feminino);
            this.groupBox2.Controls.Add(this.checkBox_Masculino);
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(226, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            // 
            // checkBox_Feminino
            // 
            this.checkBox_Feminino.AutoSize = true;
            this.checkBox_Feminino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Feminino.Enabled = false;
            this.checkBox_Feminino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Feminino.Location = new System.Drawing.Point(98, 25);
            this.checkBox_Feminino.Name = "checkBox_Feminino";
            this.checkBox_Feminino.Size = new System.Drawing.Size(86, 41);
            this.checkBox_Feminino.TabIndex = 8;
            this.checkBox_Feminino.TabStop = true;
            this.checkBox_Feminino.Text = "Feminino";
            this.checkBox_Feminino.UseVisualStyleBackColor = true;
            this.checkBox_Feminino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // checkBox_Masculino
            // 
            this.checkBox_Masculino.AutoSize = true;
            this.checkBox_Masculino.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBox_Masculino.Enabled = false;
            this.checkBox_Masculino.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Masculino.Location = new System.Drawing.Point(5, 25);
            this.checkBox_Masculino.Name = "checkBox_Masculino";
            this.checkBox_Masculino.Size = new System.Drawing.Size(93, 41);
            this.checkBox_Masculino.TabIndex = 7;
            this.checkBox_Masculino.TabStop = true;
            this.checkBox_Masculino.Text = "Masculino";
            this.checkBox_Masculino.UseVisualStyleBackColor = true;
            this.checkBox_Masculino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(549, 85);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(157, 27);
            this.txtcelular.TabIndex = 6;
            this.txtcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(549, 59);
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
            this.txttelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
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
            this.label1.Location = new System.Drawing.Point(712, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
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
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
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
            this.txtcpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // lblfuncionario
            // 
            this.lblfuncionario.AutoSize = true;
            this.lblfuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblfuncionario.Location = new System.Drawing.Point(3, 0);
            this.lblfuncionario.Name = "lblfuncionario";
            this.lblfuncionario.Size = new System.Drawing.Size(364, 23);
            this.lblfuncionario.TabIndex = 51;
            this.lblfuncionario.Text = "Nome do Funcionario:";
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
            this.txtnasc.Location = new System.Drawing.Point(712, 26);
            this.txtnasc.Mask = "00/00/0000";
            this.txtnasc.Name = "txtnasc";
            this.txtnasc.ReadOnly = true;
            this.txtnasc.Size = new System.Drawing.Size(110, 27);
            this.txtnasc.TabIndex = 3;
            this.txtnasc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtnasc.ValidatingType = typeof(System.DateTime);
            this.txtnasc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // txtnomefuncionario
            // 
            this.txtnomefuncionario.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomefuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.txtnomefuncionario.Location = new System.Drawing.Point(3, 26);
            this.txtnomefuncionario.Name = "txtnomefuncionario";
            this.txtnomefuncionario.ReadOnly = true;
            this.txtnomefuncionario.Size = new System.Drawing.Size(364, 30);
            this.txtnomefuncionario.TabIndex = 0;
            this.txtnomefuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(549, 26);
            this.txtrg.Name = "txtrg";
            this.txtrg.ReadOnly = true;
            this.txtrg.Size = new System.Drawing.Size(157, 27);
            this.txtrg.TabIndex = 2;
            this.txtrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_status.Enabled = false;
            this.checkBox_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_status.Location = new System.Drawing.Point(373, 192);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(170, 71);
            this.checkBox_status.TabIndex = 12;
            this.checkBox_status.Text = "Funcionário Ativo";
            this.checkBox_status.UseVisualStyleBackColor = true;
            this.checkBox_status.CheckedChanged += new System.EventHandler(this.checkBox_status_CheckedChanged);
            // 
            // txtpermission
            // 
            this.txtpermission.Enabled = false;
            this.txtpermission.FormattingEnabled = true;
            this.txtpermission.Items.AddRange(new object[] {
            "Operador(a)",
            "Supervisor(a)",
            "Gerente",
            "Master"});
            this.txtpermission.Location = new System.Drawing.Point(549, 143);
            this.txtpermission.Name = "txtpermission";
            this.txtpermission.Size = new System.Drawing.Size(157, 31);
            this.txtpermission.TabIndex = 10;
            this.txtpermission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnomefuncionario_KeyDown);
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
            this.panel1.Controls.Add(this.btn_excluir_func);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btn_cancelar_func);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_salvar_func);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btn_editar_func);
            this.panel1.Controls.Add(this.btnclosefunc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 565);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(979, 52);
            this.panel1.TabIndex = 8;
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
            this.btn_excluir_func.Location = new System.Drawing.Point(352, 10);
            this.btn_excluir_func.Name = "btn_excluir_func";
            this.btn_excluir_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluir_func.Size = new System.Drawing.Size(104, 32);
            this.btn_excluir_func.TabIndex = 16;
            this.btn_excluir_func.Text = "Excluir";
            this.btn_excluir_func.UseCompatibleTextRendering = true;
            this.btn_excluir_func.UseVisualStyleBackColor = false;
            this.btn_excluir_func.Click += new System.EventHandler(this.btn_excluir_func_Click);
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
            // btn_cancelar_func
            // 
            this.btn_cancelar_func.BackColor = System.Drawing.Color.SlateGray;
            this.btn_cancelar_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_cancelar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar_func.Location = new System.Drawing.Point(238, 10);
            this.btn_cancelar_func.Name = "btn_cancelar_func";
            this.btn_cancelar_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_cancelar_func.Size = new System.Drawing.Size(104, 32);
            this.btn_cancelar_func.TabIndex = 15;
            this.btn_cancelar_func.Text = "Cancelar";
            this.btn_cancelar_func.UseCompatibleTextRendering = true;
            this.btn_cancelar_func.UseVisualStyleBackColor = false;
            this.btn_cancelar_func.Visible = false;
            this.btn_cancelar_func.Click += new System.EventHandler(this.btn_cancelar_func_Click);
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
            // btn_salvar_func
            // 
            this.btn_salvar_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_salvar_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_salvar_func.FlatAppearance.BorderSize = 0;
            this.btn_salvar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_salvar_func.Location = new System.Drawing.Point(124, 10);
            this.btn_salvar_func.Name = "btn_salvar_func";
            this.btn_salvar_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_salvar_func.Size = new System.Drawing.Size(104, 32);
            this.btn_salvar_func.TabIndex = 14;
            this.btn_salvar_func.Text = "Salvar";
            this.btn_salvar_func.UseCompatibleTextRendering = true;
            this.btn_salvar_func.UseVisualStyleBackColor = false;
            this.btn_salvar_func.Visible = false;
            this.btn_salvar_func.Click += new System.EventHandler(this.btn_salvar_func_Click);
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
            // btn_editar_func
            // 
            this.btn_editar_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_editar_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar_func.FlatAppearance.BorderSize = 0;
            this.btn_editar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_func.Location = new System.Drawing.Point(10, 10);
            this.btn_editar_func.Name = "btn_editar_func";
            this.btn_editar_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_editar_func.Size = new System.Drawing.Size(104, 32);
            this.btn_editar_func.TabIndex = 13;
            this.btn_editar_func.Text = "Editar";
            this.btn_editar_func.UseCompatibleTextRendering = true;
            this.btn_editar_func.UseVisualStyleBackColor = false;
            this.btn_editar_func.Click += new System.EventHandler(this.btn_editar_func_Click);
            // 
            // btnclosefunc
            // 
            this.btnclosefunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosefunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosefunc.FlatAppearance.BorderSize = 0;
            this.btnclosefunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosefunc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosefunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosefunc.Location = new System.Drawing.Point(865, 10);
            this.btnclosefunc.Name = "btnclosefunc";
            this.btnclosefunc.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosefunc.Size = new System.Drawing.Size(104, 32);
            this.btnclosefunc.TabIndex = 17;
            this.btnclosefunc.Text = "Fechar";
            this.btnclosefunc.UseCompatibleTextRendering = true;
            this.btnclosefunc.UseVisualStyleBackColor = false;
            this.btnclosefunc.Click += new System.EventHandler(this.btnclosefunc_Click);
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
            this.lbl_topo.Size = new System.Drawing.Size(320, 49);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Dados do Funcionário";
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
            // Form_Dados_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 617);
            this.Controls.Add(this.panelcentralcadcli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dados_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Funcionario";
            this.Load += new System.EventHandler(this.Form_Dados_Funcionario_Load);
            this.panelcentralcadcli.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabfuncionario.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_editar_func;
        private System.Windows.Forms.Button btnclosefunc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabfuncionario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblfuncionario;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TabPage Foto;
        private System.Windows.Forms.Button btn_add_foto;
        private System.Windows.Forms.PictureBox img_foto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtnasc;
        private System.Windows.Forms.RadioButton checkBox_Masculino;
        private System.Windows.Forms.RadioButton checkBox_Feminino;
        private System.Windows.Forms.TextBox txtnomefuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrendacli;
        private System.Windows.Forms.Button btn_cancelar_func;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_salvar_func;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox checkBox_status;
        private OpenFileDialog ofd1;
        private Button btn_limpar_foto;
        private Button btn_excluir_func;
        private Splitter splitter3;
        private Label label6;
        private TextBox txtcracha;
        private Label label5;
        private Label label2;
        private TextBox txtendereco;
        private ComboBox txtpermission;
    }
}