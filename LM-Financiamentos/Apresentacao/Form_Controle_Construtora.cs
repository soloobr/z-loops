using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Construtora : Form
    {
        string sexo, status, idvendedor, idProcesso, idresponsavel, idresponsavelSelected, nomeresponsavel;
        public string consultar;
        int construtoraelecionada;
        int contgrid, contgridlast;
        public Form_Controle_Construtora()
        {
            InitializeComponent();
            //dgv_construtora.Columns["Nascimento"].DefaultCellStyle.Format = "D";
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

        private void Form_Controle_Construtora_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getconstrutora = new LoginDaoComandos();
            //dgv_construtora.Columns[3].DefaultCellStyle.Format = "d";
            dgv_construtora.AutoGenerateColumns = false;
            dgv_construtora.DataSource = getconstrutora.GetConstrutora("%");
            //this.dgv_construtora.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_construtora.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_construtora.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_construtora.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action ConstrutoraSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Construtora frm_cadastro_construtora = new Form_Cadastro_Construtora();

            frm_cadastro_construtora.ConstrutoraSalvo += new Action(frm_cadastro_construtora_ConstrutoraSalvo);
            //frm_cadastro_vendedors.setLabel("Em Preenchimento");
            frm_cadastro_construtora.Show();
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

        private void Form_Controle_Construtora_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_construtora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Construtora frm_dados_construtora = new Form_Dados_Construtora();
            frm_dados_construtora.setIdConstrutora(dgv_construtora.SelectedRows[0].Cells["idconstrutora"].Value.ToString());
            frm_dados_construtora.setUserLoged(idresponsavel, nomeresponsavel);
            //frm_dados_construtora.habilitar();
            construtoraelecionada = dgv_construtora.CurrentCell.RowIndex;
            frm_dados_construtora.ConstrutoraSalvo += new Action(frm_dados_construtora_ConstrutoraSalvo);
            contgrid = dgv_construtora.Rows.Count;
            frm_dados_construtora.Show();
            Cursor = Cursors.Default;
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar a Descrição ou CNPJ da Construtora para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getconstrutora = new LoginDaoComandos();
                Construtora[] myArray = getconstrutora.GetConstrutora(consultar).ToArray();
                bool verifica = false;

                foreach (Construtora c in myArray)
                {
                    if (c.Id_construtora != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    //dgv_construtora.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_construtora.AutoGenerateColumns = false;
                    dgv_construtora.DataSource = getconstrutora.GetConstrutora(consultar);
                    dgv_construtora.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrada Construtora para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        void frm_dados_construtora_ConstrutoraSalvo()
        {
            AtualizaGrid();
            contgridlast = dgv_construtora.Rows.Count;

            if (contgrid == contgridlast)
            {
                //MessageBox.Show(construtoraelecionada.ToString());
                dgv_construtora.ClearSelection();
                dgv_construtora.Rows[construtoraelecionada].Selected = true;
                dgv_construtora.Rows[construtoraelecionada].Cells[0].Selected = true;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Construtora frm_dados_construtora = new Form_Dados_Construtora();
            frm_dados_construtora.setIdConstrutora(dgv_construtora.SelectedRows[0].Cells["idconstrutora"].Value.ToString());
            frm_dados_construtora.setUserLoged(idresponsavel, nomeresponsavel);
            frm_dados_construtora.habilitar();
            construtoraelecionada = dgv_construtora.CurrentCell.RowIndex;
            frm_dados_construtora.ConstrutoraSalvo += new Action(frm_dados_construtora_ConstrutoraSalvo);
            contgrid = dgv_construtora.Rows.Count;
            frm_dados_construtora.Show();
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            if (dgv_construtora.Columns[0].DataPropertyName == "Id_construtora")
            {
                String idconstrutoraexclude = dgv_construtora.SelectedRows[0].Cells["idconstrutora"].Value.ToString();
                var result = MessageBox.Show("Deseja Excluir a Construtora: \n \n " + dgv_construtora.SelectedRows[0].Cells["idconstrutora"].Value.ToString() + " - " + dgv_construtora.SelectedRows[0].Cells["Descricao"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deleteconstrutora = new LoginDaoComandos();

                    DataTable dt = deleteconstrutora.GetProcessoConstrutora(idconstrutoraexclude);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow[] rows = dt.Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            idProcesso = rows[i]["id"].ToString();
                        }
                        var result1 = MessageBox.Show("Não Foi possível Excluir a Construtora: \n \n " + dgv_construtora.SelectedRows[0].Cells["idconstrutora"].Value.ToString() + " - " + dgv_construtora.SelectedRows[0].Cells["Descricao"].Value.ToString() + ".  \n \n Existe Processo Ativo para essa Construtora. \n \n Deseja Alterar a Construtora do Processo: " + idProcesso +" ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                            MessageBox.Show("Construtora não Excluído!");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    
                    else
                    {
                        deleteconstrutora.DeleteConstrutoraID(idconstrutoraexclude);
                        MessageBox.Show(deleteconstrutora.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoginDaoComandos getconstrutora = new LoginDaoComandos();
            dgv_construtora.AutoGenerateColumns = false;
            dgv_construtora.DataSource = getconstrutora.GetConstrutora("%");
            dgv_construtora.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();

            Cursor = Cursors.Default;
        }

        private void btnclosvend_Click(object sender, EventArgs e)
        {
            Close();
        }

        void frm_cadastro_construtora_ConstrutoraSalvo()
        {
            AtualizaGrid();

            dgv_construtora.ClearSelection();

            int nRowIndex = dgv_construtora.Rows.Count - 1;
            //construtoraelecionada = dgv_construtora.Rows.Count - 1;
            dgv_construtora.Rows[nRowIndex].Selected = true;
            dgv_construtora.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_construtora.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getagendas = new LoginDaoComandos();
            dgv_construtora.AutoGenerateColumns = false;
            dgv_construtora.DataSource = getagendas.GetConstrutora("%");
            dgv_construtora.Refresh();
        }


    }
}
