using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Controle_Cliente : Form
    {
        String sexo, status, idcliente;
        public string consultar;
        int clienteselecionado, conjugeselecionado;
        string[] idconj = { "idCJ", "idCJ1", "idCJ2", "idCJ3" };
        bool[] cjativo = { false, false, false, false };
        bool Delete = false;
        int newSortColumn;
        ListSortDirection newColumnDirection = ListSortDirection.Ascending;

        private int _previousIndex;
        private bool _sortDirection;

        private bool sortAscending = false;

        SortableBindingList<BuscarClientes> myList;
        SortableBindingList<BuscarConjuges> myListConjuges;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;
        private string idProcesso;

        public Form_Controle_Cliente()
        {
            InitializeComponent();
            dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "D";
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
                idresponsavelSelected = idresp;
            }
            if (nomefunc != null)
            {
                nomeresponsavel = nomefunc;
            }
        }
        private void Form_Cadastro_cliente_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            myList = new SortableBindingList<BuscarClientes>();

            LoginDaoComandos getclientes = new LoginDaoComandos();

           Cliente[] myArray = getclientes.GetClientes("%").ToArray();

            foreach (Cliente c in myArray)
            {
                myList.Add(new BuscarClientes(c.Id_cliente,c.Nome_cliente,c.Email_cliente,c.CPF_cliente,c.Celular_cliente, c.Nascimento_cliente));
            }

            //dgv_clientes.Columns[3].DefaultCellStyle.Format = "d";
            dgv_clientes.Columns[1].HeaderText = "Nome Cliente";
            dgv_clientes.AutoGenerateColumns = false;
            dgv_clientes.DataSource = myList;
            //dgv_clientes.DataSource = getclientes.GetClientes("%");
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //this.dgv_clientes.Columns["Nascimento"].DefaultCellStyle.ForeColor = Color.Blue;
            //this.dgv_clientes.DefaultCellStyle.ForeColor = Color.Blue;
            dgv_clientes.Refresh();

            Cursor = Cursors.Default;
        }

        public event Action ClienteSalvo;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_new_client_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Form_Cadastro_Cliente frm_cadastro_clientes = new Form_Cadastro_Cliente();

            frm_cadastro_clientes.ClienteSalvo += new Action(frm_cadastro_clientes_ClienteSalvo);
            //frm_cadastro_clientes.setLabel("Em Preenchimento");
            frm_cadastro_clientes.Show();
            Cursor = Cursors.Default;
        }

        private void txtprocurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == (char)Keys.Return)
            {
                btnprocurar.Focus();
                btnprocurar.PerformClick();
            }
        }

        private void Form_Controle_Cliente_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void dgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_cliente")
            {
                using (Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente()) // ;
                {
                    frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
                    clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                    frm_dados_clientes.setUserLoged(idresponsavel, nomeresponsavel);
                    frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                    //frm_dados_clientes.Show();
                    frm_dados_clientes.ShowDialog();
                    Delete = frm_dados_clientes.excluir;
                    frm_dados_clientes_ClienteSalvo();
                    //MessageBox.Show("Response from form2: " + Delete.ToString());
                }


                //Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente();
                //frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
                //clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                //frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                //frm_dados_clientes.Show();
            }
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_conjuge")
            {
                //conjugeselecionado = dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString();

                LoginDaoComandos getidcliente = new LoginDaoComandos();

                int idcliente = getidcliente.GetidCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());

                clienteselecionado = idcliente;

                using (Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente())// ;
                {
                    frm_dados_clientes.setIdCliente(idcliente.ToString());
                    clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                    frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                    //frm_dados_clientes.Show();
                    frm_dados_clientes.ShowDialog();
                    Delete = frm_dados_clientes.excluir;
                    frm_dados_clientes_ClienteSalvo();
                    //MessageBox.Show("Response from form2: " + Delete.ToString());
                }

                //Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente();
                //frm_dados_clientes.setIdCliente(idcliente.ToString());
                //clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                //frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                //frm_dados_clientes.Show();

            }
            Cursor = Cursors.Default;
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtprocurar.Text == "")
            {
                MessageBox.Show("Favor Digitar o CPF ou Nome do Cliente/Cônjuge para pesquisar!", "Campo Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprocurar.Focus();
            }
            else
            {
                consultar = ("%" + txtprocurar.Text + "%").Replace(",", "").Replace(".", "").Replace("-", "");

                if (rdbcpfcli.Checked)
                {
                    myList = new SortableBindingList<BuscarClientes>();

                    LoginDaoComandos getclientes = new LoginDaoComandos();

                    Cliente[] myArray = getclientes.GetClientes(consultar).ToArray();

                    bool verifica = false;
                    foreach (Cliente c in myArray)
                    {
                        myList.Add(new BuscarClientes(c.Id_cliente, c.Nome_cliente, c.Email_cliente, c.CPF_cliente, c.Celular_cliente, c.Nascimento_cliente));
                        if (c.Id_cliente != null)
                        {
                            verifica = true;
                        }
                    }

                    //LoginDaoComandos getclientes = new LoginDaoComandos();
                    //Cliente[] myArray = getclientes.GetClientes(consultar).ToArray();
                    //bool verifica = false;

                    //foreach (Cliente c in myArray)
                    //{
                    //    if (c.Id_cliente != null)
                    //    {
                    //        verifica = true;
                    //    }
                    //}

                    if (verifica)
                    {
                        dgv_clientes.Columns[1].HeaderText = "Nome Cliente";
                        dgv_clientes.Columns[0].DataPropertyName = "Id_cliente";
                        dgv_clientes.Columns[1].DataPropertyName = "Nome_cliente";
                        dgv_clientes.Columns[2].DataPropertyName = "CPF_cliente";
                        dgv_clientes.Columns[3].DataPropertyName = "Nascimento_cliente";
                        dgv_clientes.Columns[4].DataPropertyName = "Email_cliente";
                        dgv_clientes.Columns[5].DataPropertyName = "Celular_cliente";

                        dgv_clientes.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                        //dgv_clientes.DataSource = getclientes.GetClientes(consultar);
                        dgv_clientes.DataSource = myList;
                        dgv_clientes.Refresh();
                        verifica = false;
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado Clientes para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtprocurar.Focus();
                        Cursor.Current = Cursors.Default;
                    }
                }
                if (rdbcpfcj.Checked)
                {

                    myListConjuges = new SortableBindingList<BuscarConjuges>();

                    LoginDaoComandos getconjuges = new LoginDaoComandos();

                    Conjuge[] myArray = getconjuges.GetConjuges(consultar).ToArray();

                    bool verifica = false;
                    foreach (Conjuge c in myArray)
                    {
                        myListConjuges.Add(new BuscarConjuges(c.Id_conjuge, c.Nome_conjuge, c.Email_conjuge, c.CPF_conjuge, c.Celular_conjuge, c.Nascimento_conjuge));
                        if (c.Id_conjuge != null)
                        {
                            verifica = true;
                        }
                    }

                    //LoginDaoComandos getconjuges = new LoginDaoComandos();
                    //Conjuge[] myArray = getconjuges.GetConjuges(consultar).ToArray();
                    //bool verifica = false;

                    //foreach (Conjuge c in myArray)
                    //{
                    //    if (c.Id_conjuge != null)
                    //    {
                    //        verifica = true;
                    //    }
                    //}

                    if (verifica)
                    {
                        
                        
                        dgv_clientes.Columns[1].HeaderText = "Nome Cômjuge";
                        dgv_clientes.Columns[0].DataPropertyName = "Id_conjuge";
                        dgv_clientes.Columns[1].DataPropertyName = "Nome_conjuge";
                        dgv_clientes.Columns[2].DataPropertyName = "CPF_conjuge";
                        dgv_clientes.Columns[3].DataPropertyName = "Nascimento_conjuge";
                        dgv_clientes.Columns[4].DataPropertyName = "Email_conjuge";
                        dgv_clientes.Columns[5].DataPropertyName = "Celular_conjuge";

                        dgv_clientes.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                        //dgv_clientes.DataSource = getconjuges.GetConjuges(consultar);
                        dgv_clientes.DataSource = myListConjuges;
                        dgv_clientes.Refresh();
                        verifica = false;
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado Conjuges para a pesquisa: \n (" + txtprocurar.Text + ") ", "Não Encontrado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtprocurar.Focus();
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            Cursor = Cursors.Default;
        }

        private void dgv_clientes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dgv_clientes.Rows[e.RowIndex].Selected = true;
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgv_clientes_CurrentCellChanged(object sender, EventArgs e)
        {


        }

        void frm_dados_clientes_ClienteSalvo()
        {
            AtualizaGrid();

            //MessageBox.Show(Delete.ToString());
            if(Delete == true)
            {
                dgv_clientes.ClearSelection();

                int nRowIndex = dgv_clientes.Rows.Count - 1;
                //clienteselecionado = dgv_clientes.Rows.Count - 1;
                dgv_clientes.Rows[nRowIndex].Selected = true;
                dgv_clientes.Rows[nRowIndex].Cells[0].Selected = true;
                dgv_clientes.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            else
            {
                dgv_clientes.ClearSelection();
                dgv_clientes.Rows[clienteselecionado].Selected = true;
                dgv_clientes.Rows[clienteselecionado].Cells[0].Selected = true;
            }


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_cliente")
            {
                using (Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente()) // ;
                {
                    frm_dados_clientes.setIdCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
                    clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                    frm_dados_clientes.setUserLoged(idresponsavel, nomeresponsavel);
                    frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                    frm_dados_clientes.ShowDialog();
                    Delete = frm_dados_clientes.excluir;
                    frm_dados_clientes_ClienteSalvo();
                }
            }
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_conjuge")
            {
                LoginDaoComandos getidcliente = new LoginDaoComandos();

                int idcliente = getidcliente.GetidCliente(dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString());
                
                clienteselecionado = idcliente;

                using (Form_Dados_Cliente frm_dados_clientes = new Form_Dados_Cliente())// ;
                {
                    frm_dados_clientes.setIdCliente(idcliente.ToString());
                    clienteselecionado = dgv_clientes.CurrentCell.RowIndex;
                    frm_dados_clientes.ClienteSalvo += new Action(frm_dados_clientes_ClienteSalvo);
                    //frm_dados_clientes.Show();
                    frm_dados_clientes.ShowDialog();
                    Delete = frm_dados_clientes.excluir;
                    frm_dados_clientes_ClienteSalvo();
                    //MessageBox.Show("Response from form2: " + Delete.ToString());
                }
            }
            Cursor = Cursors.Default;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_cliente")
            {
                String idclienteexclude = dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString();

                var result = MessageBox.Show("Deseja Excluir o Cliente: \n \n " + dgv_clientes.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deletecliente = new LoginDaoComandos();

                    DataTable dt =deletecliente.GetProcessoCliente(idclienteexclude);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow[] rows = dt.Select();
                        for (int i = 0; i < rows.Length; i++)
                        {
                            idProcesso = rows[i]["id"].ToString();
                        }
                        /*
                         * MessageBox.Show("Não Foi possível Excluir o Cliente: \n \n " + dgv_clientes.SelectedRows[0].Cells["Nome"].Value.ToString() + " !  \n \n Existe Processo Ativo para esse Cliente, Verifique!", "excluir", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         Cursor = Cursors.Default;
                         return;*/

                        var result1 = MessageBox.Show("Não Foi possível Excluir o Cliente: \n \n " + dgv_clientes.SelectedRows[0].Cells["Nome"].Value.ToString() + " !  \n \n Existe Processo Ativo para esse Cliente. \n \n Deseja Visualizar o Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (result1 == DialogResult.Yes)
                        {
                            Form_Dados_Processos frm_dados_documentos = new Form_Dados_Processos();
                            frm_dados_documentos.setIdProcess(idProcesso);
                            frm_dados_documentos.setUserLoged(idresponsavel, nomeresponsavel);
                            frm_dados_documentos.setTABcontrol(0);
                            frm_dados_documentos.Show();
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vendedor não Excluído!");
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                    LoginDaoComandos getconjuge = new LoginDaoComandos();
                    var highScores = getconjuge.GetidConjuges(idclienteexclude);

                    int cont = 0;
                    foreach (var item in highScores)
                    {
                        idconj[cont] = ($"{item.Id_conjuge,-15}");
                        cjativo[cont] = true;
                        cont = cont + 1;
                    }
                    if (cjativo[0] == true)
                    {
                        var resultt = MessageBox.Show("Existe Conjuge para este Cliente! \n  Todos os Conjuges serão excluido. ", "excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (resultt == DialogResult.OK)
                        {
                            LoginDaoComandos deleteconjuge = new LoginDaoComandos();
                            if (cjativo[0] == true)
                            {
                                deleteconjuge.DeleteConjuge(idconj[0]);
                            }
                            if (cjativo[1] == true)
                            {
                                deleteconjuge.DeleteConjuge(idconj[1]);
                            }
                            if (cjativo[2] == true)
                            {
                                deleteconjuge.DeleteConjuge(idconj[2]);
                            }
                            if (cjativo[3] == true)
                            {
                                deleteconjuge.DeleteConjuge(idconj[3]);
                            }
                        }
                        else
                        {
                            return;
                        }

                    }

                    if (deletecliente.GetFotoCliente(idclienteexclude).Foto_cliente != null)
                    {
                        //MessageBox.Show("Tem foto");
                        deletecliente.DeleteFotoCliente(idclienteexclude);
                        deletecliente.DeleteCliente(idclienteexclude);
                        MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClienteSalvo = null;
                        //if (ClienteSalvo != null)
                        //    ClienteSalvo.Invoke();

                        AtualizaGrid();
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        deletecliente.DeleteCliente(idclienteexclude);
                        MessageBox.Show(deletecliente.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ClienteSalvo = null;
                        //if (ClienteSalvo != null)
                        //    ClienteSalvo.Invoke();
                        AtualizaGrid();
                        Cursor = Cursors.Default;
                    }



                }
            }
            if (dgv_clientes.Columns[0].DataPropertyName == "Id_conjuge")
            {
                String idconjugeexclude = dgv_clientes.SelectedRows[0].Cells["id"].Value.ToString();
                var result = MessageBox.Show("Deseja Excluir o Conjuge: \n " + dgv_clientes.SelectedRows[0].Cells["Nome"].Value.ToString() + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    LoginDaoComandos deleteconjuge = new LoginDaoComandos();
                    deleteconjuge.DeleteConjuge(idconjugeexclude);
                    MessageBox.Show(deleteconjuge.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ClienteSalvo != null)
                       ClienteSalvo.Invoke();
                    AtualizaGrid();
                    Cursor = Cursors.Default;
                }
            }

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dgv_clientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            DataGridViewColumn newColumn = dgv_clientes.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgv_clientes.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgv_clientes.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dgv_clientes.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void dgv_clientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach (DataGridViewColumn column in dgv_clientes.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.Programmatic;
            //}
        }

        private void dgv_clientes_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // //Try to sort based on the cells in the current column.
            //e.SortResult = System.String.Compare(
            //    e.CellValue1.ToString(), e.CellValue2.ToString());

            // // If the cells are equal, sort based on the ID column.
            // if (e.SortResult == 0 && e.Column.Name != "id")
            // {
            //     e.SortResult = System.String.Compare(
            //         dgv_clientes.Rows[e.RowIndex1].Cells["id"].Value.ToString(),
            //         dgv_clientes.Rows[e.RowIndex2].Cells["id"].Value.ToString());
            // }
            // e.Handled = true;
        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (rdbcpfcli.Checked)
            {
                myList = new SortableBindingList<BuscarClientes>();

                LoginDaoComandos getclientes = new LoginDaoComandos();

                Cliente[] myArray = getclientes.GetClientes("%").ToArray();

                //bool verifica = false;
                foreach (Cliente c in myArray)
                {
                    myList.Add(new BuscarClientes(c.Id_cliente, c.Nome_cliente, c.Email_cliente, c.CPF_cliente, c.Celular_cliente, c.Nascimento_cliente));
                    //if (c.Id_cliente != null)
                    //{
                    //    verifica = true;
                    //}
                }

                LoginDaoComandos getfunclientes = new LoginDaoComandos();
                dgv_clientes.AutoGenerateColumns = false;

                dgv_clientes.Columns[1].HeaderText = "Nome Cliente";
                dgv_clientes.Columns[0].DataPropertyName = "Id_cliente";
                dgv_clientes.Columns[1].DataPropertyName = "Nome_cliente";
                dgv_clientes.Columns[2].DataPropertyName = "CPF_cliente";
                dgv_clientes.Columns[3].DataPropertyName = "Nascimento_cliente";
                dgv_clientes.Columns[4].DataPropertyName = "Email_cliente";
                dgv_clientes.Columns[5].DataPropertyName = "Celular_cliente";

                //dgv_clientes.DataSource = getfunclientes.GetClientes("%");
                dgv_clientes.DataSource = myList;
                dgv_clientes.Refresh();
                txtprocurar.Clear();
                txtprocurar.Select();

                Cursor = Cursors.Default;
            }
            if (rdbcpfcj.Checked)
            {

                myListConjuges = new SortableBindingList<BuscarConjuges>();

                LoginDaoComandos getconjuges = new LoginDaoComandos();

                Conjuge[] myArray = getconjuges.GetConjuges("%").ToArray();

                //bool verifica = false;
                foreach (Conjuge c in myArray)
                {
                    myListConjuges.Add(new BuscarConjuges(c.Id_conjuge, c.Nome_conjuge, c.Email_conjuge, c.CPF_conjuge, c.Celular_conjuge, c.Nascimento_conjuge));
                    //if (c.Id_conjuge != null)
                    //{
                    //    verifica = true;
                    //}
                }
                //LoginDaoComandos getfunclientes = new LoginDaoComandos();
                dgv_clientes.AutoGenerateColumns = false;

                dgv_clientes.Columns[1].HeaderText = "Nome Conjuge";
                dgv_clientes.Columns[0].DataPropertyName = "Id_conjuge";
                dgv_clientes.Columns[1].DataPropertyName = "Nome_conjuge";
                dgv_clientes.Columns[2].DataPropertyName = "CPF_conjuge";
                dgv_clientes.Columns[3].DataPropertyName = "Nascimento_conjuge";
                dgv_clientes.Columns[4].DataPropertyName = "Email_conjuge";
                dgv_clientes.Columns[5].DataPropertyName = "Celular_conjuge";

                //dgv_clientes.DataSource = getfunclientes.GetConjuges("%");
                dgv_clientes.DataSource = myListConjuges;
                dgv_clientes.Refresh();
                txtprocurar.Clear();
                txtprocurar.Select();

                Cursor = Cursors.Default;
            }
            Cursor = Cursors.Default;
        }

        void frm_cadastro_clientes_ClienteSalvo()
        {
            AtualizaGrid();

            dgv_clientes.ClearSelection();

            int nRowIndex = dgv_clientes.Rows.Count - 1;
            //clienteselecionado = dgv_clientes.Rows.Count - 1;
            dgv_clientes.Rows[nRowIndex].Selected = true;
            dgv_clientes.Rows[nRowIndex].Cells[0].Selected = true;
            dgv_clientes.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void AtualizaGrid()
        {


            //LoginDaoComandos getclientes = new LoginDaoComandos();
            if (rdbcpfcli.Checked) 
            {
                myList = new SortableBindingList<BuscarClientes>();

                LoginDaoComandos getclientes = new LoginDaoComandos();

                Cliente[] myArray = getclientes.GetClientes("%").ToArray();

                //bool verifica = false;
                foreach (Cliente c in myArray)
                {
                    myList.Add(new BuscarClientes(c.Id_cliente, c.Nome_cliente, c.Email_cliente, c.CPF_cliente, c.Celular_cliente, c.Nascimento_cliente));
                }
                dgv_clientes.Columns[1].HeaderText = "Nome Cliente";
                dgv_clientes.Columns[0].DataPropertyName = "Id_cliente";
                dgv_clientes.Columns[1].DataPropertyName = "Nome_cliente";
                dgv_clientes.Columns[2].DataPropertyName = "CPF_cliente";
                dgv_clientes.Columns[3].DataPropertyName = "Nascimento_cliente";
                dgv_clientes.Columns[4].DataPropertyName = "Email_cliente";
                dgv_clientes.Columns[5].DataPropertyName = "Celular_cliente";
                dgv_clientes.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                //dgv_clientes.DataSource = getclientes.GetClientes("%");
                dgv_clientes.DataSource = myList;
                
            }
            if (rdbcpfcj.Checked)
            {
                myListConjuges = new SortableBindingList<BuscarConjuges>();

                LoginDaoComandos getconjuges = new LoginDaoComandos();

                Conjuge[] myArray = getconjuges.GetConjuges("%").ToArray();

                //bool verifica = false;
                foreach (Conjuge c in myArray)
                {
                    myListConjuges.Add(new BuscarConjuges(c.Id_conjuge, c.Nome_conjuge, c.Email_conjuge, c.CPF_conjuge, c.Celular_conjuge, c.Nascimento_conjuge));

                }
                
                dgv_clientes.Columns[1].HeaderText = "Nome Cômjuge";
                dgv_clientes.Columns[0].DataPropertyName = "Id_conjuge";
                dgv_clientes.Columns[1].DataPropertyName = "Nome_conjuge";
                dgv_clientes.Columns[2].DataPropertyName = "CPF_conjuge";
                dgv_clientes.Columns[3].DataPropertyName = "Nascimento_conjuge";
                dgv_clientes.Columns[4].DataPropertyName = "Email_conjuge";
                dgv_clientes.Columns[5].DataPropertyName = "Celular_conjuge";

                dgv_clientes.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv_clientes.DataSource = myListConjuges;
            }


        }


    }
}
