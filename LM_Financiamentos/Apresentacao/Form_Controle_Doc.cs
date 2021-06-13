using LM_Financiamentos.Modelo;
using System;
using System.Windows.Forms;


namespace LM_Financiamentos
{
    public partial class Form_Controle_Doc : Form
    {
        public Form_Controle_Doc()
        {
            InitializeComponent();
        }

        private void Form_Controle_Doc_Load(object sender, EventArgs e)
        {
            //Functions.Arredonda(btnclosecdoc, 10, true, true);
        }
        private void btncloseconf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclosecdoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
