using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Agencias : Form
    {
        string sexo, status, idvendedor, idProcesso, idresponsavel, idresponsavelSelected, nomeresponsavel;
        public string consultar;
        int agenciaselecionada;
        int contgrid, contgridlast;
        public Form_Controle_Agencias()
        {
            InitializeComponent();
            //dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.Format = "D";
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
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Controle_Agencias_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getagendas = new LoginDaoComandos();
            //dgv_vendedores.Columns[3].DefaultCellStyle.Format = "d";
            dgv_agencias.AutoGenerateColumns = false;
            dgv_agencias.DataSource = getagendas.GetAgencias("%");
            //this.dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_vendedores.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_vendedores.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_agencias.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action AgenciaSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Agencias frm_cadastro_agencias = new Form_Cadastro_Agencias();

            frm_cadastro_agencias.AgenciaSalvo += new Action(frm_cadastro_agencias_AgenciaSalvo);
            //frm_cadastro_vendedors.setLabel("Em Preenchimento");
            frm_cadastro_agencias.Show();
            Cursor = Cursors.Default;
        }

        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == (char)Keys.Return)
            {
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void Form_Controle_Agencias_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_vendedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgv_vendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Agencias frm_dados_agencia = new Form_Dados_Agencias();
            frm_dados_agencia.setIdAgencia(dgv_agencias.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_agencia.setUserLoged(idresponsavel, nomeresponsavel);
            agenciaselecionada = dgv_agencias.CurrentCell.RowIndex;
            frm_dados_agencia.AgenciaSalvo += new Action(frm_dados_agencias_AgenciaSalvo);
            frm_dados_agencia.habilitar();
            contgrid = dgv_agencias.Rows.Count;
            frm_dados_agencia.Show();
            Cursor = Cursors.Default;
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o número ou Nome da Agência para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getagencia = new LoginDaoComandos();
                Agencia[] myArray = getagencia.GetAgencias(consultar).ToArray();
                bool verifica = false;

                foreach (Agencia c in myArray)
                {
                    if (c.Id_agencia != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_agencias.AutoGenerateColumns = false;
                    dgv_agencias.DataSource = getagencia.GetAgencias(consultar);
                    dgv_agencias.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Agência para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        private void dgv_vendedores_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dgv_vendedores.Rows[e.RowIndex].Selected = true;
        }

        private void dgv_vendedores_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_vendedores_CurrentCellChanged(object sender, EventArgs e)
        {


        }

        void frm_dados_agencias_AgenciaSalvo()
        {
            AtualizaGrid();
            contgridlast = dgv_agencias.Rows.Count;

            if (contgrid == contgridlast)
            {
                //MessageBox.Show(agenciaselecionada.ToString());
                dgv_agencias.ClearSelection();
                dgv_agencias.Rows[agenciaselecionada].Selected = true;
                dgv_agencias.Rows[agenciaselecionada].Cells[0].Selected = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Agencias frm_dados_agencias = new Form_Dados_Agencias();
            frm_dados_agencias.setIdAgencia(dgv_agencias.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_agencias.setUserLoged(idresponsavel, nomeresponsavel);
            agenciaselecionada = dgv_agencias.CurrentCell.RowIndex;
            frm_dados_agencias.AgenciaSalvo += new Action(frm_dados_agencias_AgenciaSalvo);
            frm_dados_agencias.habilitar();
            contgrid = dgv_agencias.Rows.Count;
            frm_dados_agencias.Show();
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (dgv_agencias.Columns[0].DataPropertyName == "Id_agencia")
            {
                String idagenciaexclude = dgv_agencias.SelectedRows[0].Cells["id"].Value.ToString();
                var result = MessageBox.Show("Deseja Excluir a Agência: \n \n " + dgv_agencias.SelectedRows[0].Cells["Agencia"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deleteagencia = new LoginDaoComandos();

                    DataTable dt = deleteagencia.GetProcessoAgencia(idagenciaexclude);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow[] rows = dt.Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            idProcesso = rows[i]["id"].ToString();
                        }
                        var result1 = MessageBox.Show("Não Foi possível Excluir a Agência: \n \n " + dgv_agencias.SelectedRows[0].Cells["Agencia"].Value.ToString() + " !  \n \n Existe Processo Ativo para essa Agência. \n \n Deseja Alterar a Agência do Processo: "+ idProcesso +" ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (result1 == DialogResult.Yes)
                        {
                            Form_Dados_Processos frm_dados_documentos = new Form_Dados_Processos();
                            frm_dados_documentos.setIdProcess(idProcesso);
                            frm_dados_documentos.setUserLoged(idresponsavel, nomeresponsavel);
                            frm_dados_documentos.setTABcontrol(2);
                            frm_dados_documentos.Show();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Agência não Excluído!");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    
                    else
                    {
                        deleteagencia.DeleteAgenciaID(idagenciaexclude);
                        MessageBox.Show(deleteagencia.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaGrid();
                        Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoginDaoComandos getagencias = new LoginDaoComandos();
            dgv_agencias.AutoGenerateColumns = false;
            dgv_agencias.DataSource = getagencias.GetAgencias("%");
            dgv_agencias.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();

            Cursor = Cursors.Default;
        }

        private void btnclosvend_Click(object sender, EventArgs e)
        {
            Close();
        }

        void frm_cadastro_agencias_AgenciaSalvo()
        {
            AtualizaGrid();

            dgv_agencias.ClearSelection();

            int nRowIndex = dgv_agencias.Rows.Count - 1;
            //agenciaselecionada = dgv_vendedores.Rows.Count - 1;
            dgv_agencias.Rows[nRowIndex].Selected = true;
            dgv_agencias.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_agencias.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getagendas = new LoginDaoComandos();
            dgv_agencias.AutoGenerateColumns = false;
            dgv_agencias.DataSource = getagendas.GetAgencias("%");
            dgv_agencias.Refresh();
        }


    }
}
