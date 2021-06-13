using System;
using System.Windows.Forms;
using LM_Financiamentos.Modelo;

namespace LM_Financiamentos.Apresentacao
{
    public partial class oldForm_Cadastro_cliente : Form
    {
        public oldForm_Cadastro_cliente()
        {
            InitializeComponent();
        }

        private void Form_Cadastro_cliente_Load(object sender, EventArgs e)
        {
            
            Functions.Arredonda(btnclosecadcli, 12, true, true);
            Functions.Arredonda(btneditarcli, 12, true, true);
            Functions.Arredonda(btn_excluircli, 12, true, true);
            Functions.Arredonda(btn_cancelcli, 12, true, true);
            Functions.Arredonda(btn_procurarcli,30, true, true);
            Functions.Arredonda(tx_procurarcli, 12, true, true);
        }



        private void btnclosecadcli_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_procurarcli_Click(object sender, EventArgs e)
        {
            if (tx_procurarcli.Visible == true)
            {
                tx_procurarcli.Visible = false;
            }
            else
            {
                tx_procurarcli.Visible = true;
                tx_procurarcli.Text = "";
                tx_procurarcli.Focus();
            }
            
        }


    }


}
