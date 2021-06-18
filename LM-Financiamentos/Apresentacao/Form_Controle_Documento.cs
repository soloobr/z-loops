using System;
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
            this.processosTableAdapter.Fill(this.dS_Documentos.Processos);
            // TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);

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
                DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";


                if(consulta.GetDataConsulta(consultar) != null && consulta.GetDataConsulta(consultar).Rows.Count > 0)
                {
                    dgv_process.DataSource = consulta.GetDataConsulta(consultar);
                    dgv_process.Refresh();
                }
                else
                {
                    MessageBox.Show("Não foi encontrado entradas para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
