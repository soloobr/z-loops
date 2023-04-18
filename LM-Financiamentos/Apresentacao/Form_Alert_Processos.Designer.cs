namespace LMFinanciamentos.Apresentacao
{
    partial class Form_Alert_Processos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert_Processos));
            this.paneltop = new System.Windows.Forms.Panel();
            this.lbl_topo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclosecli = new System.Windows.Forms.Button();
            this.img_topo = new System.Windows.Forms.PictureBox();
            this.dgv_process_alert = new System.Windows.Forms.DataGridView();
            this.idconstrutora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process_alert)).BeginInit();
            this.SuspendLayout();
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
            this.paneltop.Size = new System.Drawing.Size(800, 63);
            this.paneltop.TabIndex = 7;
            // 
            // lbl_topo
            // 
            this.lbl_topo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_topo.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_topo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.lbl_topo.Location = new System.Drawing.Point(62, 4);
            this.lbl_topo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_topo.Name = "lbl_topo";
            this.lbl_topo.Size = new System.Drawing.Size(738, 55);
            this.lbl_topo.TabIndex = 50;
            this.lbl_topo.Text = "Alerta - Processos com Pendências";
            this.lbl_topo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnclosecli);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 9;
            // 
            // btnclosecli
            // 
            this.btnclosecli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnclosecli.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclosecli.FlatAppearance.BorderSize = 0;
            this.btnclosecli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosecli.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosecli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclosecli.Location = new System.Drawing.Point(686, 10);
            this.btnclosecli.Name = "btnclosecli";
            this.btnclosecli.Padding = new System.Windows.Forms.Padding(4);
            this.btnclosecli.Size = new System.Drawing.Size(104, 32);
            this.btnclosecli.TabIndex = 17;
            this.btnclosecli.Text = "Fechar";
            this.btnclosecli.UseCompatibleTextRendering = true;
            this.btnclosecli.UseVisualStyleBackColor = false;
            this.btnclosecli.Click += new System.EventHandler(this.btnclosecli_Click);
            // 
            // img_topo
            // 
            this.img_topo.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_topo.Image = global::LMFinanciamentos.Properties.Resources.alert48;
            this.img_topo.Location = new System.Drawing.Point(4, 4);
            this.img_topo.Name = "img_topo";
            this.img_topo.Padding = new System.Windows.Forms.Padding(5);
            this.img_topo.Size = new System.Drawing.Size(58, 55);
            this.img_topo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img_topo.TabIndex = 5;
            this.img_topo.TabStop = false;
            // 
            // dgv_process_alert
            // 
            this.dgv_process_alert.AllowUserToAddRows = false;
            this.dgv_process_alert.AllowUserToDeleteRows = false;
            this.dgv_process_alert.AllowUserToOrderColumns = true;
            this.dgv_process_alert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_process_alert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_process_alert.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_process_alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_process_alert.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_process_alert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_process_alert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_process_alert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_process_alert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconstrutora,
            this.Responsavel,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_process_alert.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_process_alert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_process_alert.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_process_alert.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_process_alert.Location = new System.Drawing.Point(0, 63);
            this.dgv_process_alert.MultiSelect = false;
            this.dgv_process_alert.Name = "dgv_process_alert";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_process_alert.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_process_alert.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = " - ";
            this.dgv_process_alert.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_process_alert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_process_alert.Size = new System.Drawing.Size(800, 335);
            this.dgv_process_alert.TabIndex = 13;
            // 
            // idconstrutora
            // 
            this.idconstrutora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idconstrutora.DataPropertyName = "Id_processo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0000";
            this.idconstrutora.DefaultCellStyle = dataGridViewCellStyle2;
            this.idconstrutora.HeaderText = "Nº";
            this.idconstrutora.Name = "idconstrutora";
            this.idconstrutora.Width = 80;
            // 
            // Responsavel
            // 
            this.Responsavel.DataPropertyName = "Nome_responsavel";
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.Name = "Responsavel";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "H_DiferencaDayStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Form_Alert_Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_process_alert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Alert_Processos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.Load += new System.EventHandler(this.Form_Alert_Processos_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_topo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_process_alert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lbl_topo;
        private System.Windows.Forms.PictureBox img_topo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclosecli;
        private System.Windows.Forms.DataGridView dgv_process_alert;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconstrutora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}