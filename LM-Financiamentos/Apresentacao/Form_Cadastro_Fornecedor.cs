using LMFinanciamentos.Modelo;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Cadastro_Fornecedor : Form
    {
        public Form_Cadastro_Fornecedor()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_Fornecedor_Load(object sender, EventArgs e)
        {
            Functions.Arredonda(btnclosecadforne, 12, true, true);
        }

        private void btnclosecadforne_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
