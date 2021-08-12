using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Funcionarios : Form
    {
        public string consultar;
        public Form_Controle_Funcionarios()
        {
            InitializeComponent();
        }

        private void btnclosecadfunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            if(txtprocurar.Text == "")
            {
                 MessageBox.Show("Favor Digitar o número do crachá ou nome do Funcionário para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {
                DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter adp = new DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
                consultar = '%' + txtprocurar.Text + '%';

                if (adp.GetDataBy1(consultar) != null && adp.GetDataBy1(consultar).Rows.Count > 0)
                {
                    dgv_funccionarios.DataSource = adp.GetDataBy1(consultar);
                    dgv_funccionarios.Refresh();
                }
                else 
                {
                    MessageBox.Show("Não foi encontrado entradas para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                }
            }

        }

        private void Form_Cadastro_Funcionarios_Load(object sender, EventArgs e)
        {
            txtprocurar.Select();
            this.ActiveControl = txtprocurar;
            txtprocurar.Focus();
            // TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);

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
