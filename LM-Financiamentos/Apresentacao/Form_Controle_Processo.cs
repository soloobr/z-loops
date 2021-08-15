using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Processo : Form
    {
        public string consultar;
        int processoselecionado;
        int contgrid, contgridlast;
        string idresponsavel, nomeresponsavel;

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
            dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
            dgv_process.Refresh();
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
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Processos para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
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
            frm_dados_documentos.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            processoselecionado = dgv_process.CurrentCell.RowIndex;
            contgrid = dgv_process.Rows.Count;
            frm_dados_documentos.Show();
            Cursor = Cursors.Default;
        }

        void frm_dados_documentos_ProcessoSalvo()
        {

            AtualizaGrid();
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
        }
        private void AtualizaGrid()
        {

            LoginDaoComandos getprocessos = new LoginDaoComandos();
            dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
            dgv_process.Refresh();

        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            dgv_process.AutoGenerateColumns = false;
            LoginDaoComandos getprocessos = new LoginDaoComandos();
            dgv_process.DataSource = getprocessos.GetProcessos("C", "V", "%");
            dgv_process.Refresh();
            txtprocurar.Clear();
            txtprocurar.Select();
            Cursor = Cursors.Default;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Processos frm_dados_processo = new Form_Dados_Processos();
            frm_dados_processo.setIdProcess(dgv_process.SelectedRows[0].Cells["id"].Value.ToString());
            processoselecionado = dgv_process.CurrentCell.RowIndex;
            frm_dados_processo.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            contgrid = dgv_process.Rows.Count;
            frm_dados_processo.Show();
            Cursor = Cursors.Default;
        }
    }
}
