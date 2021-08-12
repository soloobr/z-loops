using LMFinanciamentos.DAL;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Funcionarios : Form
    {
        public string consultar;
        int funcionarioselecionado;
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
            //txtprocurar.Select();
            //this.ActiveControl = txtprocurar;
            //txtprocurar.Focus();
            //// TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);


            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getfuncionarios = new LoginDaoComandos();
            //dgv_clientes.Columns[3].DefaultCellStyle.Format = "d";
            dgv_funccionarios.AutoGenerateColumns = false;
            dgv_funccionarios.DataSource = getfuncionarios.GetFuncionario("%");
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_clientes.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_funccionarios.Refresh();

            Cursor = Cursors.Default;
        }
        public event Action FuncionarioSalvo;
        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void btn_new_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Funcionario frm_cadastro_funcionarios = new Form_Cadastro_Funcionario();

            frm_cadastro_funcionarios.FuncionarioSalvo += new Action(frm_cadastro_funcionarios_FuncionarioSalvo);
            //frm_cadastro_clientes.setLabel("Em Preenchimento");
            frm_cadastro_funcionarios.Show();
            Cursor = Cursors.Default;
        }
        void frm_cadastro_funcionarios_FuncionarioSalvo()
        {
            AtualizaGrid();

            dgv_funccionarios.ClearSelection();

            int nRowIndex = dgv_funccionarios.Rows.Count - 1;
            dgv_funccionarios.Rows[nRowIndex].Selected = true;
            dgv_funccionarios.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_funccionarios.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getfuncionarios = new LoginDaoComandos();
            dgv_funccionarios.DataSource = getfuncionarios.GetFuncionario("%");
            //MessageBox.Show(getfuncionarios.GetFuncionario("%").Id_Func.ToString());


        }

        private void dgv_funccionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Dados_Funcionario frm_dados_funcionarios = new Form_Dados_Funcionario();
            frm_dados_funcionarios.setIdFuncionario(dgv_funccionarios.SelectedRows[0].Cells["id"].Value.ToString());
            funcionarioselecionado = dgv_funccionarios.CurrentCell.RowIndex;
            frm_dados_funcionarios.FuncionarioSalvo += new Action(frm_dados_funcionario_FuncionarioSalvo);
            frm_dados_funcionarios.Show();
        }


        private void btn_excluir_func_Click(object sender, EventArgs e)
        {
            String idclienteexclude = dgv_funccionarios.SelectedRows[0].Cells["id"].Value.ToString();
            var result = MessageBox.Show("Deseja Excluir o Funcionário: \n " + dgv_funccionarios.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                LoginDaoComandos deletecliente = new LoginDaoComandos();

                if (deletecliente.GetFotoCliente(idclienteexclude).Foto_cliente != null)
                {
                    //MessageBox.Show("Tem foto");
                    deletecliente.DeleteFotoFuncionario(idclienteexclude);
                    deletecliente.DeleteFuncionario(idclienteexclude);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (FuncionarioSalvo != null)
                        FuncionarioSalvo.Invoke();
                    AtualizaGrid();
                }
                else
                {
                    deletecliente.DeleteFuncionario(idclienteexclude);
                    MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (FuncionarioSalvo != null)
                        FuncionarioSalvo.Invoke();
                    AtualizaGrid();
                }



            }
        }

        private void btn_editar_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Dados_Funcionario frm_dados_funcionario = new Form_Dados_Funcionario();
            frm_dados_funcionario.setIdFuncionario(dgv_funccionarios.SelectedRows[0].Cells["id"].Value.ToString());
            funcionarioselecionado = dgv_funccionarios.CurrentCell.RowIndex;
            frm_dados_funcionario.FuncionarioSalvo += new Action(frm_dados_funcionario_FuncionarioSalvo);
            frm_dados_funcionario.Show();
            Cursor = Cursors.Default;
        }
        void frm_dados_funcionario_FuncionarioSalvo()
        {
            AtualizaGrid();

            dgv_funccionarios.ClearSelection();
            dgv_funccionarios.Rows[funcionarioselecionado].Selected = true;
            dgv_funccionarios.Rows[funcionarioselecionado].Cells[0].Selected = true;
        }

    }
}
