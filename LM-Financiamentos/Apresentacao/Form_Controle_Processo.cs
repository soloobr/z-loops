using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Processo : Form
    {
        public string consultar;
        int processoselecionado;
        int contgrid, contgridlast;
        string idresponsavel, nomeresponsavel, idresponsavelSelected;

        public Form_Controle_Processo()
        {
            InitializeComponent();
            
            // Form_Principal proc = new Form_Principal();
            // idresponsavel = proc.idresponsavel;

        }

        //public static string setUserLoged { get; set; }
        public void setFunc(Funcionario func, Saudacao saudacao)
        {
            idresponsavel = func.Id_Funcionario;
            nomeresponsavel = func.Nome_Funcionario;
        }

        public void setUserLoged(string idresp, string nomefunc)
        {
            if (idresp != null)
            {
                idresponsavel = idresp;
                idresponsavelSelected = idresp;
            }
            if (nomefunc != null)
            {
                nomeresponsavel = nomefunc;
            }
        }
        private void btncloseconf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void img_topo_Click(object sender, EventArgs e)
        {

        }

        private void Form_Controle_Documento_Load(object sender, EventArgs e)
        {
            txtprocurar.Select();
            this.ActiveControl = txtprocurar;
            txtprocurar.Focus();
            
            LoginDaoComandos getprocessos = new LoginDaoComandos();

            dgv_process.AutoGenerateColumns = false;
            dgv_process.DataSource = getprocessos.GetProcessosForResp("C", "V", "%", idresponsavel);
            dgv_process.Refresh();

            DestacarLinhaDataGridView();
            
            #region Carregar combobox visão
            Cursor = Cursors.WaitCursor;
            if (comboBoxFunc.DataSource is null)
            {
                comboBoxFunc.IntegralHeight = false;
                LoginDaoComandos getcombo = new LoginDaoComandos();
                #region Popular combobox
                comboBoxFunc.DataSource = getcombo.GetDataidfuncproc();
                comboBoxFunc.DisplayMember = "Login";
                comboBoxFunc.ValueMember = "id";
                int Idd = Convert.ToInt32(idresponsavel) ;
                for (int i = 0; i < comboBoxFunc.Items.Count; i++)
                {
                    comboBoxFunc.SelectedIndex = i;
                    if (Convert.ToInt32(comboBoxFunc.SelectedValue) == Idd)
                    { break; }
                }

                #endregion
                //DestacarLinhaDataGridView();
                //comboBoxFunc.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
            #endregion 
        }


        public void DestacarLinhaDataGridView()
        {
            foreach (DataGridViewRow row in dgv_process.Rows)
            {

                if(row.Cells[2].Value.ToString() != null && row.Cells[2].Value.ToString() != "Data")
                {
                    string dateString = row.Cells[2].Value.ToString();

                    var parameterDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var todaynegative7 = DateTime.Today.AddDays(-7);

                    int results = DateTime.Compare(parameterDate, todaynegative7);
                    if (results < 0)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                if (row.Cells[6].Value.ToString() == "Concluído")
                {
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                }


            }
        }
        private void btnprocurar_Click(object sender, EventArgs e)
        {
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o número do Processo ou nome do Cliente para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getprocessos = new LoginDaoComandos();
                Processo[] myArray = getprocessos.GetProcessos("C", "V", consultar).ToArray();
                bool verifica = false;

                foreach (Processo c in myArray)
                {
                    if (c.Id_processo != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_process.DataSource = getprocessos.GetProcessos("C", "V", consultar);
                    dgv_process.Refresh();
                    verifica = false;

                    DestacarLinhaDataGridView();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Processos para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                }

                int Idd = Convert.ToInt32(idresponsavel);
                for (int i = 0; i < comboBoxFunc.Items.Count; i++)
                {
                    comboBoxFunc.SelectedIndex = i;
                    if (Convert.ToInt32(comboBoxFunc.SelectedValue) == Idd)
                    { break; }
                }
            }

        }

        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Cursor = Cursors.WaitCursor;
                btnprocurar.Focus();
                btnprocurar.PerformClick();
                Cursor = Cursors.Default;
            }
        }

        private void btnnovodoc_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Processos frm_cadastro_documentos = new Form_Cadastro_Processos();
            frm_cadastro_documentos.ProcessoSalvo += new Action(frm_cadastro_documentos_ProcessoSalvo);
            frm_cadastro_documentos.setLabel("Em Preenchimento");
            frm_cadastro_documentos.setidUserLoged(idresponsavel);
            frm_cadastro_documentos.Show();
        }

        private void dgv_process_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Processos frm_dados_documentos = new Form_Dados_Processos();
            frm_dados_documentos.setIdProcess(dgv_process.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_documentos.setUserLoged(idresponsavel, nomeresponsavel);
            frm_dados_documentos.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            processoselecionado = dgv_process.CurrentCell.RowIndex;
            contgrid = dgv_process.Rows.Count;
            frm_dados_documentos.Show();
            Cursor = Cursors.Default;
        }

        void frm_dados_documentos_ProcessoSalvo()
        {

            AtualizaGrid();
            DestacarLinhaDataGridView();
            contgridlast = dgv_process.Rows.Count;
            if (contgrid == contgridlast)
            {
                dgv_process.ClearSelection();
                dgv_process.Rows[processoselecionado].Selected = true;
                dgv_process.Rows[processoselecionado].Cells[0].Selected = true;
                
            }
        }
        void frm_cadastro_documentos_ProcessoSalvo()
        {
            AtualizaGrid();

            dgv_process.ClearSelection();

            int nRowIndex = dgv_process.Rows.Count - 1;
            dgv_process.Rows[nRowIndex].Selected = true;
            dgv_process.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_process.FirstDisplayedScrollingRowIndex = nRowIndex;
            DestacarLinhaDataGridView();
        }
        private void AtualizaGrid()
        {
            if (idresponsavelSelected.Equals("01111")){
                LoginDaoComandos getprocessos = new LoginDaoComandos();
                dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
                dgv_process.Refresh();
                DestacarLinhaDataGridView();

            }
            else
            {
                LoginDaoComandos getprocessos = new LoginDaoComandos();
                dgv_process.DataSource = getprocessos.GetProcessosForResp("C", "V", "%", idresponsavelSelected);
                dgv_process.Refresh();
                DestacarLinhaDataGridView();
            }


        }

        private void dgv_process_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            if (dgv_process.Columns[e.ColumnIndex].Name == "Data")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    DateTime dt7 = DateTime.Now.AddDays(-7);
                    DateTime Agora = DateTime.Now;
                    Agora = new DateTime(Agora.Year, Agora.Month, Agora.Day);
                    dt7 = new DateTime(dt7.Year, dt7.Month, dt7.Day);
                    //MessageBox.Show(Convert.ToDateTime(Agora).ToString("dd/MM/yyyy"));
                    //MessageBox.Show(Convert.ToDateTime(dt7).ToString("dd/MM/yyyy"));

                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string dateString = (string)e.Value;
                    //stringValue = stringValue.ToLower();
                    //MessageBox.Show(dateString);
                    string format = "d";
                    //int result = DateTime.Compare(  DateTime.ParseExact(dateString, "dd/MM/yyyy", provider), dt7);
                    int result = DateTime.Compare(dt7, DateTime.ParseExact(dateString, "dd/MM/yyyy", provider));
                    //MessageBox.Show(Convert.ToDateTime(DateTime.ParseExact(dateString, "dd/MM/yyyy", provider)).ToString("dd/MM/yyyy"));
                    // MessageBox.Show(result.ToString());

                    TimeSpan diferenca = dt7 - DateTime.ParseExact(dateString, "dd/MM/yyyy", provider);

                    int dias = diferenca.Days;

                    var parameterDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var todaysDate = DateTime.Today;
                    var todaynegative7 = DateTime.Today.AddDays(-7);

                    //MessageBox.Show(" " + parameterDate.ToString() + " \a " + todaynegative7.ToString() + " ");
                    int results = DateTime.Compare(parameterDate, todaynegative7);
                    //MessageBox.Show(results.ToString());
                    //if (parameterDate <= todaynegative7 )
                    if (results < 0)
                    {
                        dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        //dgv_process.Rows[e.RowIndex].Cells["status"].Style.BackColor = Color.Red;
                        //dgv_process.Rows[e.RowIndex].Cells["status"].Style.ForeColor = Color.Red;

                    }
                    else
                    {

                        dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                        //dgv_process.Rows[e.RowIndex].Cells["status"].Style.BackColor = Color.White;
                        //dgv_process.Rows[e.RowIndex].Cells["status"].Style.ForeColor = Color.Black;

                    }
                }
            }
            */
        }
        private void comboBoxFunc_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBoxFunc.DataSource is null)
            {
                comboBoxFunc.IntegralHeight = false;
                LoginDaoComandos getcombo = new LoginDaoComandos();
                #region Popular combobox
                comboBoxFunc.DataSource = getcombo.GetDataidfuncproc();
                comboBoxFunc.DisplayMember = "Login";
                comboBoxFunc.ValueMember = "id";
                //comboBox_agencia.Text = "";

                #endregion

                comboBoxFunc.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void dgv_process_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_process_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*//MessageBox.Show(e.Value.ToString());
            if (dgv_process.Columns[e.ColumnIndex].Name == "status")
            {

                if (e.Value.ToString() == "Concluído")
                {
                    dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                }

            }
            if (dgv_process.Columns[e.ColumnIndex].Name == "Data")
            {
                if (e.Value.ToString() != null && e.Value.ToString() != "Data" )
                {
                    dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;
                    
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    string dateString = (string)e.Value;

                    var parameterDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var todaysDate = DateTime.Today;
                    var todaynegative7 = DateTime.Today.AddDays(-7);

                    int results = DateTime.Compare(parameterDate, todaynegative7);
                    if (results < 0)
                    {
                        dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgv_process.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            */
        }

        private void dgv_process_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxFunc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxFunc.Text.Equals("Todos"))
            {
                Cursor = Cursors.WaitCursor;

                dgv_process.AutoGenerateColumns = false;
                LoginDaoComandos getprocessos = new LoginDaoComandos();
                dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
                dgv_process.Refresh();
                txtprocurar.Clear();
                txtprocurar.Select();
                idresponsavelSelected = "01111";

                DestacarLinhaDataGridView();
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                idresponsavelSelected = comboBoxFunc.SelectedValue.ToString();
                LoginDaoComandos getprocessos = new LoginDaoComandos();

                dgv_process.AutoGenerateColumns = false;
                //dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
                dgv_process.DataSource = getprocessos.GetProcessosForResp("C", "V", "%", idresponsavelSelected);

                dgv_process.Refresh();
                DestacarLinhaDataGridView();
                Cursor = Cursors.Default;
            }
            

            //switch (comboBoxFunc.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            /*Cursor = Cursors.WaitCursor;

            dgv_process.AutoGenerateColumns = false;
            LoginDaoComandos getprocessos = new LoginDaoComandos();
            dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
            dgv_process.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();
            Cursor = Cursors.Default;*/
            Cursor = Cursors.WaitCursor;
            //idresponsavel = comboBoxFunc.SelectedValue.ToString();
            LoginDaoComandos getprocessos = new LoginDaoComandos();

            dgv_process.AutoGenerateColumns = false;
            //dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
            dgv_process.DataSource = getprocessos.GetProcessosForResp("C", "V", "%", idresponsavel);

            dgv_process.Refresh();

            int Idd = Convert.ToInt32(idresponsavel);
            for (int i = 0; i < comboBoxFunc.Items.Count; i++)
            {
                comboBoxFunc.SelectedIndex = i;
                if (Convert.ToInt32(comboBoxFunc.SelectedValue) == Idd)
                { break; }
            }
            DestacarLinhaDataGridView();
            Cursor = Cursors.Default;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Processos frm_dados_processo = new Form_Dados_Processos();
            frm_dados_processo.setIdProcess(dgv_process.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_processo.setUserLoged(idresponsavel, nomeresponsavel);
            processoselecionado = dgv_process.CurrentCell.RowIndex;
            frm_dados_processo.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            contgrid = dgv_process.Rows.Count;
            frm_dados_processo.Show();
            Cursor = Cursors.Default;
        }
    }
}
