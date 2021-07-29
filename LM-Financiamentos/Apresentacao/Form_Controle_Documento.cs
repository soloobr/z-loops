using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Documento : Form
    {
        public string consultar;
        public Form_Controle_Documento()
        {
            InitializeComponent();
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
            // TODO: esta linha de código carrega dados na tabela 'dS_Documentos.Processos'. Você pode movê-la ou removê-la conforme necessário.
            //this.processosTableAdapter.Fill(this.dS_Documentos.Processos);
            // TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);

            LoginDaoComandos getprocessos = new LoginDaoComandos();

            dgv_process.AutoGenerateColumns = false;
            dgv_process.DataSource = getprocessos.GetProcessos("C","%");
            dgv_process.Refresh();


        }

        private void dgv_process_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                Processo[] myArray = getprocessos.GetProcessos("C", consultar).ToArray();
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
                    dgv_process.DataSource = getprocessos.GetProcessos("C", consultar);
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
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void btnnovodoc_Click(object sender, EventArgs e)
        {
            Form_Cadastro_Documentos frm_cadastro_documentos = new Form_Cadastro_Documentos();
            frm_cadastro_documentos.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            frm_cadastro_documentos.setLabel("Em Preenchimento");
            frm_cadastro_documentos.Show();
        }

        private void dgv_process_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Dados_Documentos frm_dados_documentos = new Form_Dados_Documentos();
            //frm_dados_documentos.setIdProcess(dgv_process.Rows[1].Cells[0].Value.ToString());
            frm_dados_documentos.setIdProcess(dgv_process.SelectedRows[0].Cells["id"].Value.ToString());
            frm_dados_documentos.ProcessoSalvo += new Action(frm_dados_documentos_ProcessoSalvo);
            //frm_dados_documentos.setIdProcess("1");
            frm_dados_documentos.Show();
        }

        void frm_dados_documentos_ProcessoSalvo()
        {
            AtualizaGrid();
        }
        private void AtualizaGrid()
        {
            // TODO: esta linha de código carrega dados na tabela 'dS_Documentos.Processos'. Você pode movê-la ou removê-la conforme necessário.
            //this.processosTableAdapter.Fill(this.dS_Documentos.Processos);
            // TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);
            //dS_Documentos.Reset();
            //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter.Fill(DAL.DS_Documentos.ProcessosDataTable.);
            
            LoginDaoComandos getprocessos = new LoginDaoComandos();
            dgv_process.DataSource = getprocessos.GetProcessos("C", "%");
            dgv_process.Refresh();

        }
    }
}
