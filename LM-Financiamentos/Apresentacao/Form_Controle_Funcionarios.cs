using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Funcionarios : Form
    {
        public string consultar;
        int funcionarioselecionado;
        int contgrid, contgridlast;
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
            //if(txtprocurar.Text == "")
            //{
            //     MessageBox.Show("Favor Digitar o número do crachá ou nome do Funcionário para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtprocurar.Focus();
            //}
            //else
            //{
            //    DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter adp = new DAL.DS_FuncionarioTableAdapters.FuncionariosTableAdapter();
            //    consultar = '%' + txtprocurar.Text + '%';

            //    if (adp.GetDataBy1(consultar) != null && adp.GetDataBy1(consultar).Rows.Count > 0)
            //    {
            //        dgv_funcionarios.DataSource = adp.GetDataBy1(consultar);
            //        dgv_funcionarios.Refresh();
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Não foi encontrado entradas para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtprocurar.Focus();
            //    }
            //}
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o número ou Nome do Funcionario para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {

                //DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter consulta = new DAL.DS_DocumentosTableAdapters.ProcessosTableAdapter();
                consultar = "%" + txtprocurar.Text + "%";

                LoginDaoComandos getfunciuonario = new LoginDaoComandos();
                Funcionario[] myArray = getfunciuonario.GetFuncionarios(consultar).ToArray();
                bool verifica = false;

                foreach (Funcionario c in myArray)
                {
                    if (c.Id_Funcionario != null)
                    {
                        verifica = true;
                    }
                }

                if (verifica)
                {
                    dgv_funcionarios.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_funcionarios.DataSource = getfunciuonario.GetFuncionarios(consultar);
                    dgv_funcionarios.Refresh();
                    verifica = false;
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Funcionario para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtprocurar.Focus();
                    Cursor.Current = Cursors.Default;
                }
            }
            Cursor = Cursors.Default;
        }

        private void Form_Controle_Funcionarios_Load(object sender, EventArgs e)
        {
            //txtprocurar.Select();
            //this.ActiveControl = txtprocurar;
            //txtprocurar.Focus();
            //// TODO: esta linha de código carrega dados na tabela 'dS_Funcionario.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionariosTableAdapter.Fill(this.dS_Funcionario.Funcionarios);


            Cursor = Cursors.WaitCursor;

            LoginDaoComandos getfuncionarios = new LoginDaoComandos();
            //dgv_clientes.Columns[3].DefaultCellStyle.Format = "d";
            dgv_funcionarios.AutoGenerateColumns = false;
            dgv_funcionarios.DataSource = getfuncionarios.GetFuncionarios("%");
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_clientes.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_funcionarios.Refresh();

            //String idfuncionario = getfuncionarios.GetFuncionario("%").Nome_Funcionario;

            //MessageBox.Show(idfuncionario);
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

            dgv_funcionarios.ClearSelection();

            int nRowIndex = dgv_funcionarios.Rows.Count - 1;
            dgv_funcionarios.Rows[nRowIndex].Selected = true;
            dgv_funcionarios.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_funcionarios.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {
            LoginDaoComandos getfuncionarios = new LoginDaoComandos();
            dgv_funcionarios.DataSource = getfuncionarios.GetFuncionarios("%");
            //MessageBox.Show(getfuncionarios.GetFuncionario("%").Id_Func.ToString());


        }

        private void dgv_funccionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form_Dados_Funcionario frm_dados_funcionarios = new Form_Dados_Funcionario();
            frm_dados_funcionarios.setIdFuncionario(dgv_funcionarios.SelectedRows[0].Cells["id"].Value.ToString());
            funcionarioselecionado = dgv_funcionarios.CurrentCell.RowIndex;
            contgrid = dgv_funcionarios.Rows.Count;
            frm_dados_funcionarios.FuncionarioSalvo += new Action(frm_dados_funcionario_FuncionarioSalvo);
            frm_dados_funcionarios.Show();
        }


        private void btn_excluir_func_Click(object sender, EventArgs e)
        {
            String idclienteexclude = dgv_funcionarios.SelectedRows[0].Cells["id"].Value.ToString();
            var result = MessageBox.Show("Deseja Excluir o Funcionário: \n " + dgv_funcionarios.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            frm_dados_funcionario.setIdFuncionario(dgv_funcionarios.SelectedRows[0].Cells["id"].Value.ToString());
            funcionarioselecionado = dgv_funcionarios.CurrentCell.RowIndex;
            contgrid = dgv_funcionarios.Rows.Count;
            frm_dados_funcionario.FuncionarioSalvo += new Action(frm_dados_funcionario_FuncionarioSalvo);
            frm_dados_funcionario.Show();
            Cursor = Cursors.Default;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoginDaoComandos getfuncionarios = new LoginDaoComandos();
            dgv_funcionarios.AutoGenerateColumns = false;
            dgv_funcionarios.DataSource = getfuncionarios.GetFuncionarios("%");
            dgv_funcionarios.Refresh();

            Cursor = Cursors.Default;
        }

        private void Form_Controle_Funcionarios_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        void frm_dados_funcionario_FuncionarioSalvo()
        {
            AtualizaGrid();
           
            contgridlast = dgv_funcionarios.Rows.Count;
           
            if (contgrid == contgridlast)
            {
                dgv_funcionarios.ClearSelection();
                dgv_funcionarios.Rows[funcionarioselecionado].Selected = true;
                dgv_funcionarios.Rows[funcionarioselecionado].Cells[0].Selected = true;
            }
        }

    }
}
