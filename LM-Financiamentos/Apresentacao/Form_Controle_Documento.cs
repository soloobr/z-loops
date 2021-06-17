using System;
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
            DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
           consultar = "%"+txtprocurar.Text+"%";
        
            dgv_process.DataSource = consulta.GetDataConsulta(consultar);
            dgv_process.Refresh();
        }
    }
}
