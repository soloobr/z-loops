using LM_Financiamentos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Financiamentos.Apresentacao
{
    public partial class Form_Cadastro_Fornecedor : Form
    {
        public Form_Cadastro_Fornecedor()
        {
            InitializeComponent();
        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Cadastro_Fornecedor_Load(object sender, EventArgs e)
        {
            Functions.Arredonda(btnclosecadforne, 12, true, true);
        }
    }
}
