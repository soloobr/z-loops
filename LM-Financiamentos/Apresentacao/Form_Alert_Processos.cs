using LMFinanciamentos.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Alert_Processos : Form
    {
        string idresponsavel, nomeresponsavel;

        public Form_Alert_Processos()
        {
            InitializeComponent();
        }

        private void Form_Alert_Processos_Load(object sender, EventArgs e)
        {
            LoginDaoComandos checkvalidade = new LoginDaoComandos();

            var highScores = checkvalidade.GetValidadeAnalise();

            dgv_process_alert.AutoGenerateColumns = false;
            dgv_process_alert.DataSource = checkvalidade.GetValidadeAnalise();
            dgv_process_alert.Refresh();


        }

        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setUserLoged(string idresp, string nomefunc)
        {
            if (idresp != null)
            {
                idresponsavel = idresp;
                //idresponsavelSelected = idresp;
            }
            if (nomefunc != null)
            {
                nomeresponsavel = nomefunc;
            }
        }
    }
}
