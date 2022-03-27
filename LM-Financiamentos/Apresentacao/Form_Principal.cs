using LMFinanciamentos.DAL;
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
        public string idresponsavel, nomeresponsavel, idResp, servidor;
        public Form_Principal()
        {
            InitializeComponent();
            hideSubMenu();
        }
        public void setLabel(Funcionario func, Saudacao saudacao)
        {

            lblfunc.Text = func.Nome_Funcionario;
            lblsaudacao.Text = saudacao.Saudacoes;
            idresponsavel = func.Id_Funcionario;
            nomeresponsavel = func.Nome_Funcionario;
            idResp = func.Id_Funcionario;
        }
        public void setServer(String server)
        {

            servidor = server;

        }
        internal void setFoto(byte[] foto_Func)
        {
            // throw new NotImplementedException();
            if (foto_Func != null)
            {
                MemoryStream stmBLOBData = new MemoryStream(foto_Func);
                img_foto.Image = Image.FromStream(stmBLOBData);
            }

        }
        private void hideSubMenu()
        {
            if (panelsubmenucadastro.Visible == true)
            panelsubmenucadastro.Visible = false;
            if (panelsubmenuimovel.Visible == true)
                panelsubmenuimovel.Visible = false;

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

            #region Checbox Foto
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var MyIni = new IniFile(basePath + @"\LM-Settings.ini");
            String usuario = Path.GetFileName(basePath);
            var DefaultVolume = MyIni.Read("DefaultVolume", usuario);

            if (DefaultVolume.ToString() == "1")
            {
                img_foto.Image = Properties.Resources.contacts_250;
            }
            #endregion

            //Cursor = Cursors.Default;
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
                sw = 600;
                sh = 600;
            }
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
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        #endregion
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
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
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Controle_Processo"] == null)
            {
                btncontroledoc.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Controle_Cliente"] == null)
            {
                btncadastrocliente.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Configuracao"] == null)
            {
                btnconf.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Controle_Agencias"] == null)
            {
                btncaixa.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Controle_Empreendimentos"] == null)
            {
                btnempreendimentos.BackColor = Color.FromArgb(4, 41, 68);
            }

            if (Application.OpenForms["Form_Controle_Cliente"] == null && Application.OpenForms["Form_Controle_Vendedor"] == null && Application.OpenForms["Form_Controle_Funcionarios"] == null )
            {
                btncadastro.BackColor = Color.FromArgb(4, 41, 68);
                btncadastrocliente.BackColor = Color.FromArgb(4, 41, 68);
                btncadastrocvendedor.BackColor = Color.FromArgb(4, 41, 68);
                btncadastrocfuncionarios.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Controle_Empreendimentos"] == null  && Application.OpenForms["Form_Controle_Corretor"] == null && Application.OpenForms["Form_Controle_Construtora"] == null)
            {
                btnimovel.BackColor = Color.FromArgb(4, 41, 68);
                btncadastroconstrutora.BackColor = Color.FromArgb(4, 41, 68);
                btncadastrocorretor.BackColor = Color.FromArgb(4, 41, 68);
                btnempreendimentos.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["Form_Controle_Cliente"] == null)
                btncadastrocliente.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form_Controle_Vendedor"] == null)
                btncadastrocvendedor.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form_Controle_Funcionarios"] == null)
                btncadastrocfuncionarios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form_Controle_Construtora"] == null)
                btncadastroconstrutora.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Form_Controle_Corretor"] == null)
                btncadastrocorretor.BackColor = Color.FromArgb(4, 41, 68);


        }
        private void btnmenuleft_Click(object sender, EventArgs e)
        {
            btnmenurigth.Visible = true;
            btnmenuleft.Visible = false;
            panelMenu.Size = new Size(48, 583);
            panelLogo.Visible = false;
            //img_foto.Visible = false;
            //lblsaudacao.Visible = false;
            lblfunc.Visible = false;
            hideSubMenu();
            btncontroledoc.Text = " ";
            btncadastro.Text = " ";
            btnconf.Text = " ";
            btncaixa.Text = " ";
            btnimovel.Text = " ";

        }

        private void btnmenurigth_Click(object sender, EventArgs e)
        {
            btnmenurigth.Visible = false;
            btnmenuleft.Visible = true;
            panelMenu.Size = new Size(230, 583);
            panelLogo.Visible = true;
            lblfunc.Visible = true;
            btncontroledoc.Text = "Controle de Documentos";
            btncadastro.Text = "Cadastro";
            btncaixa.Text = "Caixa";
            btnimovel.Text = "Imovél";
            btnconf.Text = "Configurações";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private Form_Configuracao Configuracoes = null;
        private void btnconf_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Application.OpenForms.OfType<Form_Configuracao>().Count() > 0)
            {
                this.Configuracoes.WindowState = FormWindowState.Normal;
                Configuracoes.BringToFront();
            }
            else
            {
                this.Configuracoes = new Form_Configuracao();
                this.Configuracoes.setID(idresponsavel);
                this.Configuracoes.Text = "Configurações";//titulo do formulario
                this.Configuracoes.TopLevel = false;

                this.Configuracoes.TopLevel = false;
                this.Configuracoes.FormBorderStyle = FormBorderStyle.None;
                this.Configuracoes.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(Configuracoes);
                this.panelformularios.Tag = Configuracoes;
                this.Configuracoes.Show();
                this.Configuracoes.BringToFront();
                this.Configuracoes.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            btnconf.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();






            //Cursor = Cursors.WaitCursor;
            //AbrirFormulario<Form_Configuracao>();
            //btnconf.BackColor = Color.FromArgb(12, 61, 92);
            //hideSubMenu();
            Cursor = Cursors.Default;
        }
        private Form_Controle_Processo BuscarProcessos = null;
        private Form_Controle_Cliente BuscarClientes = null;
        private Form_Controle_Vendedor BuscarVendedor = null;
        private Form_Controle_Agencias BuscarAgencias = null;
        private Form_Controle_Empreendimentos BuscarEmpreendimentos = null;
        private Form_Controle_Construtora BuscarConstrutora = null;
        private Form_Controle_Corretor BuscarCorretor = null;


        private void Form_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var MyIni = new IniFile(basePath + @"\LM-Settings.ini");
            String usuario = Path.GetFileName(basePath);
            MyIni.DeleteKey("StringConnection", usuario);
        }

        private void btncaixa_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Form_Controle_Agencias>().Count() > 0)
            {
                this.BuscarAgencias.WindowState = FormWindowState.Normal;
                BuscarAgencias.BringToFront();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                this.BuscarAgencias = new Form_Controle_Agencias();
                this.BuscarAgencias.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarAgencias.Text = "Buscar Agências";//titulo do formulario
                this.BuscarAgencias.TopLevel = false;

                this.BuscarAgencias.TopLevel = false;
                this.BuscarAgencias.FormBorderStyle = FormBorderStyle.None;
                this.BuscarAgencias.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarAgencias);
                this.panelformularios.Tag = BuscarAgencias;
                this.BuscarAgencias.Show();
                this.BuscarAgencias.BringToFront();
                this.BuscarAgencias.FormClosed += new FormClosedEventHandler(CloseForms);
                //this.BuscarAgencias.DestacarLinhaDataGridView();
                Cursor.Current = Cursors.Default;

            }
            btncaixa.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }

        private void btnimovel_Click(object sender, EventArgs e)
        {
            if (panelLogo.Visible == false)
            {
                btnmenurigth.Visible = false;
                btnmenuleft.Visible = true;
                panelMenu.Size = new Size(230, 583);
                btncontroledoc.Text = "Controle de Documentos";
                btncadastro.Text = "Cadastro";
                btncaixa.Text = "Caixa";
                btnimovel.Text = "Imovél";
                btnconf.Text = "Configurações";
                showSubMenu(panelsubmenuimovel);
            }
            else
            {
                showSubMenu(panelsubmenuimovel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Controle_Empreendimentos>().Count() > 0)
            {
                this.BuscarEmpreendimentos.WindowState = FormWindowState.Normal;
                BuscarEmpreendimentos.BringToFront();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                this.BuscarEmpreendimentos = new Form_Controle_Empreendimentos();
                this.BuscarEmpreendimentos.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarEmpreendimentos.Text = "Buscar Empreendimentos";//titulo do formulario
                this.BuscarEmpreendimentos.TopLevel = false;

                this.BuscarEmpreendimentos.TopLevel = false;
                this.BuscarEmpreendimentos.FormBorderStyle = FormBorderStyle.None;
                this.BuscarEmpreendimentos.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarEmpreendimentos);
                this.panelformularios.Tag = BuscarEmpreendimentos;
                this.BuscarEmpreendimentos.Show();
                this.BuscarEmpreendimentos.BringToFront();
                this.BuscarEmpreendimentos.FormClosed += new FormClosedEventHandler(CloseForms);
                Cursor = Cursors.Default;

            }
            btnimovel.BackColor = Color.FromArgb(12, 61, 92);
            btnempreendimentos.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }

        private void btncadastroconstrutora_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Controle_Construtora>().Count() > 0)
            {
                this.BuscarConstrutora.WindowState = FormWindowState.Normal;
                BuscarConstrutora.BringToFront();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                this.BuscarConstrutora = new Form_Controle_Construtora();
                this.BuscarConstrutora.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarConstrutora.Text = "Buscar Construtora";//titulo do formulario
                this.BuscarConstrutora.TopLevel = false;

                this.BuscarConstrutora.TopLevel = false;
                this.BuscarConstrutora.FormBorderStyle = FormBorderStyle.None;
                this.BuscarConstrutora.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarConstrutora);
                this.panelformularios.Tag = BuscarConstrutora;
                this.BuscarConstrutora.Show();
                this.BuscarConstrutora.BringToFront();
                this.BuscarConstrutora.FormClosed += new FormClosedEventHandler(CloseForms);
                Cursor = Cursors.Default;

            }
            btnimovel.BackColor = Color.FromArgb(12, 61, 92);
            btncadastroconstrutora.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }

        private void btncadastrocorretor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Controle_Corretor>().Count() > 0)
            {
                this.BuscarCorretor.WindowState = FormWindowState.Normal;
                BuscarCorretor.BringToFront();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                this.BuscarCorretor = new Form_Controle_Corretor();
                this.BuscarCorretor.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarCorretor.Text = "Buscar Corretor";//titulo do formulario
                this.BuscarCorretor.TopLevel = false;

                this.BuscarCorretor.TopLevel = false;
                this.BuscarCorretor.FormBorderStyle = FormBorderStyle.None;
                this.BuscarCorretor.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarCorretor);
                this.panelformularios.Tag = BuscarCorretor;
                this.BuscarCorretor.Show();
                this.BuscarCorretor.BringToFront();
                this.BuscarCorretor.FormClosed += new FormClosedEventHandler(CloseForms);
                Cursor = Cursors.Default;

            }
            btnimovel.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocorretor.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }

        private void btncontroledoc_Click(object sender, EventArgs e)
        {
           
            if (Application.OpenForms.OfType<Form_Controle_Processo>().Count() > 0)
            {
                this.BuscarProcessos.WindowState = FormWindowState.Normal;
                BuscarProcessos.BringToFront();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                this.BuscarProcessos = new Form_Controle_Processo();
                this.BuscarProcessos.setUserLoged(idresponsavel, nomeresponsavel);
                
                this.BuscarProcessos.Text = "Buscar Processos";//titulo do formulario
                this.BuscarProcessos.TopLevel = false;

                this.BuscarProcessos.TopLevel = false;
                this.BuscarProcessos.FormBorderStyle = FormBorderStyle.None;
                this.BuscarProcessos.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarProcessos);
                this.panelformularios.Tag = BuscarProcessos;
                this.BuscarProcessos.Show();
                this.BuscarProcessos.BringToFront();
                this.BuscarProcessos.FormClosed += new FormClosedEventHandler(CloseForms);
                this.BuscarProcessos.DestacarLinhaDataGridView();
                Cursor.Current = Cursors.Default;

            }
            btncontroledoc.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }
        private void btncadastro_Click_1(object sender, EventArgs e)
        {
            if (panelLogo.Visible == false)
            {
                btnmenurigth.Visible = false;
                btnmenuleft.Visible = true;
                panelMenu.Size = new Size(230, 583);
                btncontroledoc.Text = "Controle de Documentos";
                btncadastro.Text = "Cadastro";
                btncaixa.Text = "Caixa";
                btnimovel.Text = "Imovél";
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
            if (Application.OpenForms.OfType<Form_Controle_Cliente>().Count() > 0)
            {
                this.BuscarClientes.WindowState = FormWindowState.Normal;
                BuscarClientes.BringToFront();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                this.BuscarClientes = new Form_Controle_Cliente();
                this.BuscarClientes.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarClientes.Text = "Buscar Clientes";//titulo do formulario
                this.BuscarClientes.TopLevel = false;

                this.BuscarClientes.TopLevel = false;
                this.BuscarClientes.FormBorderStyle = FormBorderStyle.None;
                this.BuscarClientes.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarClientes);
                this.panelformularios.Tag = BuscarClientes;
                this.BuscarClientes.Show();
                this.BuscarClientes.BringToFront();
                this.BuscarClientes.FormClosed += new FormClosedEventHandler(CloseForms);
                Cursor = Cursors.Default;

            }
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocliente.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }

        private void btncadastrocfuncionarios_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AbrirFormulario<Form_Controle_Funcionarios>();
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocfuncionarios.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
            Cursor = Cursors.Default;
        }

        private void btncadastrocvendedor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Controle_Vendedor>().Count() > 0)
            {
                this.BuscarVendedor.WindowState = FormWindowState.Normal;
                BuscarVendedor.BringToFront();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                this.BuscarVendedor = new Form_Controle_Vendedor();
                this.BuscarVendedor.setUserLoged(idresponsavel, nomeresponsavel);

                this.BuscarVendedor.Text = "Buscar Vendedores";//titulo do formulario
                this.BuscarVendedor.TopLevel = false;

                this.BuscarVendedor.TopLevel = false;
                this.BuscarVendedor.FormBorderStyle = FormBorderStyle.None;
                this.BuscarVendedor.Dock = DockStyle.Fill;
                this.panelformularios.Controls.Add(BuscarVendedor);
                this.panelformularios.Tag = BuscarVendedor;
                this.BuscarVendedor.Show();
                this.BuscarVendedor.BringToFront();
                this.BuscarVendedor.FormClosed += new FormClosedEventHandler(CloseForms);
                Cursor = Cursors.Default;
            }
            btncadastro.BackColor = Color.FromArgb(12, 61, 92);
            btncadastrocvendedor.BackColor = Color.FromArgb(12, 61, 92);
            hideSubMenu();
        }
    }
}
