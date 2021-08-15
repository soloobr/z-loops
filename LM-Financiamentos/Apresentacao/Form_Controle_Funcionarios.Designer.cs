
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Controle_Funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Controle_Funcionarios));
            this.panelcentro = new System.Windows.Forms.Panel();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cracha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.btn_reload = new System.Windows.Forms.Button();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_excluir_func = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_editar_func = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_new_func = new System.Windows.Forms.Button();
            this.btnclosefunc = new System.Windows.Forms.Button();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Funcionario = new LMFinanciamentos.DAL.DS_Funcionario();
            this.dSFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new LMFinanciamentos.DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            this.panelcentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcentro
            // 
            this.panelcentro.Controls.Add(this.dgv_funcionarios);
            this.panelcentro.Controls.Add(this.pnlcontrol);
            this.panelcentro.Controls.Add(this.paneltop);
            this.panelcentro.Controls.Add(this.panel2);
            this.panelcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentro.Location = new System.Drawing.Point(0, 0);
            this.panelcentro.Name = "panelcentro";
            this.panelcentro.Size = new System.Drawing.Size(1066, 500);
            this.panelcentro.TabIndex = 2;
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.AllowUserToAddRows = false;
            this.dgv_funcionarios.AllowUserToDeleteRows = false;
            this.dgv_funcionarios.AllowUserToOrderColumns = true;
            this.dgv_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funcionarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_funcionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_funcionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_funcionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Email,
            this.Telefone,
            this.Endereco,
            this.Nascimento,
            this.Sexo,
            this.CPF,
            this.Cracha});
            this.dgv_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funcionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_funcionarios.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_funcionarios.Location = new System.Drawing.Point(0, 195);
            this.dgv_funcionarios.MultiSelect = false;
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_funcionarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionarios.Size = new System.Drawing.Size(1066, 253);
            this.dgv_funcionarios.TabIndex = 12;
            this.dgv_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_funccionarios_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_Funcionario";
            this.id.HeaderText = "Nº";
            this.id.Name = "id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome_Funcionario";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email_Funcionario";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone_Funcionario";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco_Funcionario";
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            // 
            // Nascimento
            // 
            this.Nascimento.DataPropertyName = "Nascimento_Funcionario";
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo_Funcionario";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF_Funcionario";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // Cracha
            // 
            this.Cracha.DataPropertyName = "Cracha_Funcionario";
            this.Cracha.HeaderText = "Cracha";
            this.Cracha.Name = "Cracha";
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.btn_reload);
            this.pnlcontrol.Controls.Add(this.lblprocurar);
            this.pnlcontrol.Controls.Add(this.btnprocurar);
            this.pnlcontrol.Controls.Add(this.txtprocurar);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 57);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(1066, 138);
            this.pnlcontrol.TabIndex = 11;
            // 
            // btn_reload
            // 
            this.btn_reload.AutoSize = true;
            this.btn_reload.BackColor = System.Drawing.Color.Silver;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Image = ((System.Drawing.Image)(resources.GetObject("btn_reload.Image")));
            this.btn_reload.Location = new System.Drawing.Point(294, 44);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Padding = new System.Windows.Forms.Padding(2);
            this.btn_reload.Size = new System.Drawing.Size(38, 30);
            this.btn_reload.TabIndex = 3;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
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
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.paneltop.Controls.Add(this.lbl_topo);
            this.paneltop.Controls.Add(this.img_topo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Padding = new System.Windows.Forms.Padding(4);
            this.paneltop.Size = new System.Drawing.Size(1066, 57);
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
            this.lbl_topo.Size = new System.Drawing.Size(401, 49);
            this.lbl_topo.TabIndex = 6;
            this.lbl_topo.Text = "Cadastro de Funcionários";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btn_excluir_func);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.btn_editar_func);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.btn_new_func);
            this.panel2.Controls.Add(this.btnclosefunc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1066, 52);
            this.panel2.TabIndex = 8;
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
            this.btn_excluir_func.Location = new System.Drawing.Point(238, 10);
            this.btn_excluir_func.Name = "btn_excluir_func";
            this.btn_excluir_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_excluir_func.Size = new System.Drawing.Size(104, 32);
            this.btn_excluir_func.TabIndex = 34;
            this.btn_excluir_func.Text = "Excluir";
            this.btn_excluir_func.UseCompatibleTextRendering = true;
            this.btn_excluir_func.UseVisualStyleBackColor = false;
            this.btn_excluir_func.Click += new System.EventHandler(this.btn_excluir_func_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(228, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 32);
            this.splitter2.TabIndex = 33;
            this.splitter2.TabStop = false;
            // 
            // btn_editar_func
            // 
            this.btn_editar_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_editar_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_editar_func.FlatAppearance.BorderSize = 0;
            this.btn_editar_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_func.Location = new System.Drawing.Point(124, 10);
            this.btn_editar_func.Name = "btn_editar_func";
            this.btn_editar_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_editar_func.Size = new System.Drawing.Size(104, 32);
            this.btn_editar_func.TabIndex = 32;
            this.btn_editar_func.Text = "Editar";
            this.btn_editar_func.UseCompatibleTextRendering = true;
            this.btn_editar_func.UseVisualStyleBackColor = false;
            this.btn_editar_func.Click += new System.EventHandler(this.btn_editar_func_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(114, 10);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 32);
            this.splitter1.TabIndex = 31;
            this.splitter1.TabStop = false;
            // 
            // btn_new_func
            // 
            this.btn_new_func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btn_new_func.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_new_func.FlatAppearance.BorderSize = 0;
            this.btn_new_func.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_func.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_func.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new_func.Location = new System.Drawing.Point(10, 10);
            this.btn_new_func.Name = "btn_new_func";
            this.btn_new_func.Padding = new System.Windows.Forms.Padding(4);
            this.btn_new_func.Size = new System.Drawing.Size(104, 32);
            this.btn_new_func.TabIndex = 30;
            this.btn_new_func.Text = "Novo";
            this.btn_new_func.UseCompatibleTextRendering = true;
            this.btn_new_func.UseVisualStyleBackColor = false;
            this.btn_new_func.Click += new System.EventHandler(this.btn_new_func_Click);
            // 
            // btnclosefunc
            // 
            this.btnclosefunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosefunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosefunc.FlatAppearance.BorderSize = 0;
            this.btnclosefunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosefunc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosefunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosefunc.Location = new System.Drawing.Point(952, 10);
            this.btnclosefunc.Name = "btnclosefunc";
            this.btnclosefunc.Size = new System.Drawing.Size(104, 32);
            this.btnclosefunc.TabIndex = 2;
            this.btnclosefunc.Text = "Fechar";
            this.btnclosefunc.UseVisualStyleBackColor = false;
            this.btnclosefunc.Click += new System.EventHandler(this.btnclosecadfunc_Click);
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
            // dSFuncionarioBindingSource
            // 
            this.dSFuncionarioBindingSource.DataSource = this.dS_Funcionario;
            this.dSFuncionarioBindingSource.Position = 0;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Controle_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 500);
            this.Controls.Add(this.panelcentro);
            this.Name = "Form_Controle_Funcionarios";
            this.Text = "Form_Cadastro_Funcionarios";
            this.Load += new System.EventHandler(this.Form_Controle_Funcionarios_Load);
            this.Shown += new System.EventHandler(this.Form_Controle_Funcionarios_Shown);
            this.panelcentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentro;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclosefunc;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.BindingSource dSFuncionarioBindingSource;
        private DAL.DS_Funcionario dS_Funcionario;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Button btn_excluir_func;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_editar_func;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_new_func;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.DataGridView dgv_funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cracha;
    }
}