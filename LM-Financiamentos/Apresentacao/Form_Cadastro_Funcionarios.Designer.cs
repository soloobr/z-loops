
namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Cadastro_Funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cadastro_Funcionarios));
            this.panelcentro = new System.Windows.Forms.Panel();
            this.dgv_funccionarios = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crachaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Funcionario = new LMFinanciamentos.DAL.DS_Funcionario();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.lblprocurar = new System.Windows.Forms.Label();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclosecadfunc = new System.Windows.Forms.Button();
            this.dSFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new LMFinanciamentos.DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            this.panelcentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funccionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).BeginInit();
            this.pnlcontrol.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcentro
            // 
            this.panelcentro.Controls.Add(this.dgv_funccionarios);
            this.panelcentro.Controls.Add(this.pnlcontrol);
            this.panelcentro.Controls.Add(this.paneltop);
            this.panelcentro.Controls.Add(this.panel2);
            this.panelcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentro.Location = new System.Drawing.Point(0, 0);
            this.panelcentro.Name = "panelcentro";
            this.panelcentro.Size = new System.Drawing.Size(917, 390);
            this.panelcentro.TabIndex = 2;
            // 
            // dgv_funccionarios
            // 
            this.dgv_funccionarios.AllowUserToAddRows = false;
            this.dgv_funccionarios.AutoGenerateColumns = false;
            this.dgv_funccionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funccionarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_funccionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_funccionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_funccionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_funccionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funccionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.crachaDataGridViewTextBoxColumn});
            this.dgv_funccionarios.DataSource = this.funcionariosBindingSource;
            this.dgv_funccionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funccionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_funccionarios.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_funccionarios.Location = new System.Drawing.Point(0, 195);
            this.dgv_funccionarios.MultiSelect = false;
            this.dgv_funccionarios.Name = "dgv_funccionarios";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_funccionarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_funccionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funccionarios.Size = new System.Drawing.Size(917, 143);
            this.dgv_funccionarios.TabIndex = 12;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nascimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // crachaDataGridViewTextBoxColumn
            // 
            this.crachaDataGridViewTextBoxColumn.DataPropertyName = "Cracha";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crachaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.crachaDataGridViewTextBoxColumn.HeaderText = "Cracha";
            this.crachaDataGridViewTextBoxColumn.Name = "crachaDataGridViewTextBoxColumn";
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
            // pnlcontrol
            // 
            this.pnlcontrol.Controls.Add(this.lblprocurar);
            this.pnlcontrol.Controls.Add(this.btnprocurar);
            this.pnlcontrol.Controls.Add(this.txtprocurar);
            this.pnlcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcontrol.Location = new System.Drawing.Point(0, 57);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(917, 138);
            this.pnlcontrol.TabIndex = 11;
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
            this.paneltop.Size = new System.Drawing.Size(917, 57);
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
            this.panel2.Controls.Add(this.btnclosecadfunc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(917, 52);
            this.panel2.TabIndex = 8;
            // 
            // btnclosecadfunc
            // 
            this.btnclosecadfunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecadfunc.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosecadfunc.FlatAppearance.BorderSize = 0;
            this.btnclosecadfunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecadfunc.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosecadfunc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecadfunc.Location = new System.Drawing.Point(803, 10);
            this.btnclosecadfunc.Name = "btnclosecadfunc";
            this.btnclosecadfunc.Size = new System.Drawing.Size(104, 32);
            this.btnclosecadfunc.TabIndex = 2;
            this.btnclosecadfunc.Text = "Fechar";
            this.btnclosecadfunc.UseVisualStyleBackColor = false;
            this.btnclosecadfunc.Click += new System.EventHandler(this.btnclosecadfunc_Click);
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
            // Form_Cadastro_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 390);
            this.Controls.Add(this.panelcentro);
            this.Name = "Form_Cadastro_Funcionarios";
            this.Text = "Form_Cadastro_Funcionarios";
            this.Load += new System.EventHandler(this.Form_Cadastro_Funcionarios_Load);
            this.panelcentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funccionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionario)).EndInit();
            this.pnlcontrol.ResumeLayout(false);
            this.pnlcontrol.PerformLayout();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentro;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclosecadfunc;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.Label lblprocurar;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.DataGridView dgv_funccionarios;
        private System.Windows.Forms.BindingSource dSFuncionarioBindingSource;
        private DAL.DS_Funcionario dS_Funcionario;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crachaDataGridViewTextBoxColumn;
    }
}