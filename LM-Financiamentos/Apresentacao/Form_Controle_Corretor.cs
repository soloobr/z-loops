using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Corretor : Form
    {
        public string consultar, idProcesso, idCorretor, NomeCorretor;
        int corretorelecionado;
        int contgrid, contgridlast;

        private string idresponsavel;
        private string nomeresponsavel;
        private string idresponsavelSelected;
        

        public Form_Controle_Corretor()
        {
            InitializeComponent();
        }

        private void btnclosecadfunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            //if(txtprocurar.Text == "")
            //{
            //     MessageBox.Show("Favor Digitar o número do crachá ou nome do Funcionário para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtprocurar.Focus();
            //}
            //else
            //{
            //    DAL.DS_CorretorTableAdapters.CorretorTableAdapter adp = new DAL.DS_CorretorTableAdapters.CorretorTableAdapter();
            //    consultar = '%' + txtprocurar.Text + '%';

            //    if (adp.GetDataBy1(consultar) != null && adp.GetDataBy1(consultar).Rows.Count > 0)
            //    {
            //        dgv_corretor.DataSource = adp.GetDataBy1(consultar);
            //        dgv_corretor.Refresh();
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Não foi encontrado entradas para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtprocurar.Focus();
            //    }
            //}
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o Nome ou CPF do Corretor para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getcorretor = new LoginDaoComandos();
                Corretor[] myArray = getcorretor.GetCorretor(consultar).ToArray();
                bool verifica = false;

                foreach (Corretor c in myArray)
                {
                    if (c.Id_corretor != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_corretor.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_corretor.DataSource = getcorretor.GetCorretor(consultar);
                    dgv_corretor.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Corretor para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        private void Form_Controle_Corretor_Load(object sender, EventArgs e)
        {
            //txtprocurar.Select();
            //this.ActiveControl = txtprocurar;
            //txtprocurar.Focus();
            //// TODO: esta linha de código carrega dados na tabela 'dS_Corretor.Corretor'. Você pode movê-la ou removê-la conforme necessário.
            //this.corretorTableAdapter.Fill(this.dS_Corretor.Corretor);


            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getcorretor = new LoginDaoComandos();
            //dgv_corretors.Columns[3].DefaultCellStyle.Format = "d";
            dgv_corretor.AutoGenerateColumns = false;
            dgv_corretor.DataSource = getcorretor.GetCorretor("%");
            //this.dgv_corretors.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_corretors.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_corretors.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_corretor.Refresh();

            //String idfuncionario = getcorretor.GetCorretor("%").Nome_Corretor;

            //MessageBox.Show(idfuncionario);
            Cursor = Cursors.Default;
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
        public event Action CorretorSalvo;
        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void btn_new_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Corretor frm_cadastro_corretor = new Form_Cadastro_Corretor();

            frm_cadastro_corretor.CorretorSalvo += new Action(frm_cadastro_corretor_CorretorSalvo);
            //frm_cadastro_corretors.setLabel("Em Preenchimento");
            frm_cadastro_corretor.Show();
            Cursor = Cursors.Default;
        }
        void frm_cadastro_corretor_CorretorSalvo()
        {
            AtualizaGrid();

            dgv_corretor.ClearSelection();

            int nRowIndex = dgv_corretor.Rows.Count - 1;
            dgv_corretor.Rows[nRowIndex].Selected = true;
            dgv_corretor.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_corretor.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getcorretor = new LoginDaoComandos();
            dgv_corretor.DataSource = getcorretor.GetCorretor("%");
            //MessageBox.Show(getcorretor.GetCorretor("%").Id_Func.ToString());


        }

        private void dgv_funccionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Dados_Corretor frm_dados_corretor = new Form_Dados_Corretor();
            frm_dados_corretor.setIdCorretor(dgv_corretor.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_corretor.setUserLoged(idresponsavel, nomeresponsavel);
            corretorelecionado = dgv_corretor.CurrentCell.RowIndex;
            contgrid = dgv_corretor.Rows.Count;
            frm_dados_corretor.CorretorSalvo += new Action(frm_dados_funcionario_CorretorSalvo);
            frm_dados_corretor.Show();
        }


        private void btn_excluir_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            idCorretor = dgv_corretor.SelectedRows[0].Cells["id"].Value.ToString();
            NomeCorretor = dgv_corretor.SelectedRows[0].Cells["Nome"].Value.ToString();
            var result = MessageBox.Show("Deseja Excluir o Funcionário: \n \n " + idCorretor + " - " + NomeCorretor + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deletecorretor = new LoginDaoComandos();

                DataTable dt = deletecorretor.GetProcessoCorretor(idCorretor);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] rows = dt.Select();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        idProcesso = rows[i]["id"].ToString();
                    }
                    var result1 = MessageBox.Show("Não Foi possível Excluir o Corretor: \n \n " + idCorretor + " - " + NomeCorretor + ".  \n \n Existe Processo Ativo para esse Corretor. \n \n Deseja Alterar o Corretor do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                        MessageBox.Show("Corretor não Excluído!");
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {

                    deletecorretor.DeleteCorretorID(idCorretor);
                    //idcorretor = "7";
                    MessageBox.Show(deletecorretor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (CorretorSalvo != null)
                        CorretorSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
                }


            }
            Cursor = Cursors.Default;
        }

        private void btn_editar_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Corretor frm_dados_funcionario = new Form_Dados_Corretor();
            frm_dados_funcionario.setIdCorretor(dgv_corretor.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_funcionario.setUserLoged(idresponsavel, nomeresponsavel);
            corretorelecionado = dgv_corretor.CurrentCell.RowIndex;
            contgrid = dgv_corretor.Rows.Count;
            frm_dados_funcionario.CorretorSalvo += new Action(frm_dados_funcionario_CorretorSalvo);
            frm_dados_funcionario.habilitar();
            frm_dados_funcionario.Show();
            Cursor = Cursors.Default;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoginDaoComandos getcorretor = new LoginDaoComandos();
            dgv_corretor.AutoGenerateColumns = false;
            dgv_corretor.DataSource = getcorretor.GetCorretor("%");
            dgv_corretor.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();

            Cursor = Cursors.Default;
        }

        private void Form_Controle_Corretor_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        void frm_dados_funcionario_CorretorSalvo()
        {
            AtualizaGrid();

            contgridlast = dgv_corretor.Rows.Count;

            if (contgrid == contgridlast)
            {
                dgv_corretor.ClearSelection();
                dgv_corretor.Rows[corretorelecionado].Selected = true;
                dgv_corretor.Rows[corretorelecionado].Cells[0].Selected = true;
            }
        }

    }
}
