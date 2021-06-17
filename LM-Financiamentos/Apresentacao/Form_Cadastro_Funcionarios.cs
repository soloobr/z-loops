using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Funcionarios : Form
    {
        public string consultar;
        public Form_Cadastro_Funcionarios()
        {
            InitializeComponent();
        }

        private void btnclosecadfunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter adp = new DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            //DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter consulta = new DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            consultar = '%'+txtprocurar.Text+'%';
            //consultar = txtprocurar.Text;
            
            dataGridView1.DataSource = adp.f(consultar);
            dataGridView1.Refresh();

        }

        private void Form_Cadastro_Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);

        }
    }
}
