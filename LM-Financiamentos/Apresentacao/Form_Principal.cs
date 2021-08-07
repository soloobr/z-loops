using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        public void setLabel(Funcionario func, Saudacao saudacao)
        {
            lblfunc.Text = func.Nome_Func;
            lblsaudacao.Text = saudacao.Saudacoes;
        }
        public void setFoto(Funcionario imagem)
        {
            MemoryStream stmBLOBData = new MemoryStream(imagem.Foto_Func);
            img_foto.Image = Image.FromStream(stmBLOBData);

        }
        internal void setFoto(byte[] foto_Func)
        {
            // throw new NotImplementedException();
            MemoryStream stmBLOBData = new MemoryStream(foto_Func);
            img_foto.Image = Image.FromStream(stmBLOBData);
        }
        private void hideSubMenu()
        {
            panelsubmenucadastro.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
                //subMenuIco.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                //subMenuIco.Visible = false;
            }

        }
        private void Form_Principal_Load(object sender, EventArgs e)
        {
            //Cursor = Cursors.Default;
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
                sw = 600;
                sh = 600;
            }
            /*
            List<Funcionario> lFunc = new List<Funcionario>();

            
            lFunc.Add(new Funcionario 
            { 
                Nome_Func = linha.Nome 
            });
            */
        }
        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }



        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Deseja encerrar o Programa?", "Saindo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        //Capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {


            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }


        #endregion
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Controle_Documento"] == null)
                btncontroledoc.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form_Cadastro_cliente"] == null)
            {
                if (Application.OpenForms["Form_Cadastro_Funcionarios"] == null)
                {
                    btncadastro.BackColor = Color.FromArgb(4, 41, 68);
                    btncadastrocliente.BackColor = Color.FromArgb(4, 41, 68);
                }
                else
                {
                    btncadastrocliente.BackColor = Color.FromArgb(4, 41, 68);
                }

            }
            if (Application.OpenForms["Form_Cadastro_Funcionarios"] == null)
            {
                if (Application.OpenForms["Form_Cadastro_cliente"] == null)
                {
                    btncadastro.BackColor = Color.FromArgb(4, 41, 68);
                    btncadastrocfuncionarios.BackColor = Color.FromArgb(4, 41, 68);
                }
                else
                {
                    btncadastrocfuncionarios.BackColor = Color.FromArgb(4, 41, 68);
                }
            }

            if (Application.OpenForms["Form_Configuracao"] == null)
                btnconf.BackColor = Color.FromArgb(4, 41, 68);

        }

        private void btncadfor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Cadastro_Fornecedor>();
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadfor.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Configuracao>();
            btnconf.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelsubmenucadastro);

        }

        private void btncdoc_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Controle_Processo>();
            btncdoc.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnmenuleft_Click(object sender, EventArgs e)
        {
            btnmenurigth.Visible = true;
            btnmenuleft.Visible = false;
            panelMenu.Size = new Size(45, 583);
            panelLogo.Visible = false;
            //img_foto.Visible = false;
            //lblsaudacao.Visible = false;
            lblfunc.Visible = false;
            hideSubMenu();
            btncontroledoc.Text = " ";
            btncadastro.Text = " ";
            btnconf.Text = " ";

        }

        private void btnmenurigth_Click(object sender, EventArgs e)
        {
            btnmenurigth.Visible = false;
            btnmenuleft.Visible = true;
            panelMenu.Size = new Size(230, 583);
            panelLogo.Visible = true;
            //img_foto.Visible = true;
            //lblsaudacao.Visible = true;
            lblfunc.Visible = true;
            btncontroledoc.Text = "Controle de Documentos";
            btncadastro.Text = "Cadastro";
            btncadastro.Text = "Configurações";
        }

        private void btnicocad_Click(object sender, EventArgs e)
        {
            btnmenurigth.Visible = false;
            btnmenuleft.Visible = true;
            panelMenu.Size = new Size(230, 583);
            showSubMenu(panelsubmenucadastro);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void img_center_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnconf_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AbrirFormulario<Form_Configuracao>();
            btnconf.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btncontroledoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AbrirFormulario<Form_Controle_Processo>();
            btncontroledoc.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();

        }
        private void btncadastro_Click_1(object sender, EventArgs e)
        {
            if (panelLogo.Visible == false)
            {
                btnmenurigth.Visible = false;
                btnmenuleft.Visible = true;
                panelMenu.Size = new Size(230, 583);
                //panelLogo.Visible = true;
                btncontroledoc.Text = "Controle de Documentos";
                btncadastro.Text = "Cadastro";
                btnconf.Text = "Configurações";
                showSubMenu(panelsubmenucadastro);
            }
            else
            {
                showSubMenu(panelsubmenucadastro);
            }

        }

        private void btncadastrocliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Controle_cliente>();
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocliente.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btncadastrocfuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form_Cadastro_Funcionarios>();
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocfuncionarios.BackColor = Color.FromArgb(12, 61, 92);
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelformularios.Controls.Add(childForm);
            panelformularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
