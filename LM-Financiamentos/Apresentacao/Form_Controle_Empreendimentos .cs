using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Empreendimentos : Form
    {
        string sexo, status, idvendedor, idProcesso, idresponsavel, idresponsavelSelected, nomeresponsavel;
        public string consultar;
        int empreendimentoselecionada;
        int contgrid, contgridlast;
        public Form_Controle_Empreendimentos()
        {
            InitializeComponent();
            //dgv_empreendimentos.Columns["Nascimento"].DefaultCellStyle.Format = "D";
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

        private void Form_Controle_Empreendimentos_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getempreendimentos = new LoginDaoComandos();
            //dgv_empreendimentos.Columns[3].DefaultCellStyle.Format = "d";
            dgv_empreendimentos.AutoGenerateColumns = false;
            dgv_empreendimentos.DataSource = getempreendimentos.GetEmpreendimentos("%");
            //this.dgv_empreendimentos.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_empreendimentos.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_empreendimentos.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_empreendimentos.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action EmpreendimentoSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Empreendimentos frm_cadastro_empreendimentos = new Form_Cadastro_Empreendimentos();

            frm_cadastro_empreendimentos.EmpreendimentoSalvo += new Action(frm_cadastro_empreendimentos_EmpreendimentoSalvo);
            //frm_cadastro_vendedors.setLabel("Em Preenchimento");
            frm_cadastro_empreendimentos.Show();
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

        private void Form_Controle_Empreendimentos_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_empreendimentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Empreendimentos frm_dados_empreendimentos = new Form_Dados_Empreendimentos();
            frm_dados_empreendimentos.setIdEmpreendimento(dgv_empreendimentos.SelectedRows[0].Cells["idd"].Value.ToString());
            frm_dados_empreendimentos.setUserLoged(idresponsavel, nomeresponsavel);
            empreendimentoselecionada = dgv_empreendimentos.CurrentCell.RowIndex;
            frm_dados_empreendimentos.EmpreendimentoSalvo += new Action(frm_dados_empreendimentos_EmpreendimentoSalvo);
            //frm_dados_empreendimentos.habilitar();
            contgrid = dgv_empreendimentos.Rows.Count;
            frm_dados_empreendimentos.Show();
            Cursor = Cursors.Default;
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o Nome do Empreendimento para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getempreendimentos = new LoginDaoComandos();
                Empreendimento[] myArray = getempreendimentos.GetEmpreendimentos(consultar).ToArray();
                bool verifica = false;

                foreach (Empreendimento c in myArray)
                {
                    if (c.Id_empreendimentos != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    //dgv_empreendimentos.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_empreendimentos.AutoGenerateColumns = false;
                    dgv_empreendimentos.DataSource = getempreendimentos.GetEmpreendimentos(consultar);
                    dgv_empreendimentos.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Empreendimento para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        void frm_dados_empreendimentos_EmpreendimentoSalvo()
        {
            AtualizaGrid();
            contgridlast = dgv_empreendimentos.Rows.Count;

            if (contgrid == contgridlast)
            {
                //MessageBox.Show(empreendimentoselecionada.ToString());
                dgv_empreendimentos.ClearSelection();
                dgv_empreendimentos.Rows[empreendimentoselecionada].Selected = true;
                dgv_empreendimentos.Rows[empreendimentoselecionada].Cells[0].Selected = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Empreendimentos frm_dados_empreendimentos = new Form_Dados_Empreendimentos();
            frm_dados_empreendimentos.setIdEmpreendimento(dgv_empreendimentos.SelectedRows[0].Cells["idd"].Value.ToString());
            frm_dados_empreendimentos.setUserLoged(idresponsavel, nomeresponsavel);
            empreendimentoselecionada = dgv_empreendimentos.CurrentCell.RowIndex;
            frm_dados_empreendimentos.EmpreendimentoSalvo += new Action(frm_dados_empreendimentos_EmpreendimentoSalvo);
            frm_dados_empreendimentos.habilitar();
            contgrid = dgv_empreendimentos.Rows.Count;
            frm_dados_empreendimentos.Show();
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (dgv_empreendimentos.Columns[0].DataPropertyName == "Id_empreendimentos")
            {
                String idempreendimentosexclude = dgv_empreendimentos.SelectedRows[0].Cells["idd"].Value.ToString();
                var result = MessageBox.Show("Deseja Excluir o Empreendimento: \n \n " + dgv_empreendimentos.SelectedRows[0].Cells["idd"].Value.ToString() + " - " + dgv_empreendimentos.SelectedRows[0].Cells["Descricao"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deleteempreendimentos = new LoginDaoComandos();

                    DataTable dt = deleteempreendimentos.GetProcessoEmpreendimento(idempreendimentosexclude);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow[] rows = dt.Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            idProcesso = rows[i]["id"].ToString();
                        }
                        var result1 = MessageBox.Show("Não Foi possível Excluir o Empreendimento: \n \n " + dgv_empreendimentos.SelectedRows[0].Cells["idd"].Value.ToString() + " - " + dgv_empreendimentos.SelectedRows[0].Cells["Descricao"].Value.ToString() + ".  \n \n Existe Processo Ativo para esse Empreendimento. \n \n Deseja Alterar o Empreendimento do Processo: " + idProcesso +" ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                            MessageBox.Show("Empreendimento não Excluído!");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    
                    else
                    {
                        deleteempreendimentos.DeleteEmpreendimentoID(idempreendimentosexclude);
                        MessageBox.Show(deleteempreendimentos.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoginDaoComandos getempreendimentos = new LoginDaoComandos();
            dgv_empreendimentos.AutoGenerateColumns = false;
            dgv_empreendimentos.DataSource = getempreendimentos.GetEmpreendimentos("%");
            dgv_empreendimentos.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();

            Cursor = Cursors.Default;
        }

        private void btnclosvend_Click(object sender, EventArgs e)
        {
            Close();
        }

        void frm_cadastro_empreendimentos_EmpreendimentoSalvo()
        {
            AtualizaGrid();

            dgv_empreendimentos.ClearSelection();

            int nRowIndex = dgv_empreendimentos.Rows.Count - 1;
            //empreendimentoselecionada = dgv_empreendimentos.Rows.Count - 1;
            dgv_empreendimentos.Rows[nRowIndex].Selected = true;
            dgv_empreendimentos.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_empreendimentos.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getagendas = new LoginDaoComandos();
            dgv_empreendimentos.AutoGenerateColumns = false;
            dgv_empreendimentos.DataSource = getagendas.GetEmpreendimentos("%");
            dgv_empreendimentos.Refresh();
        }


    }
}
