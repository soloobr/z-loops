using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Agencias : Form
    {
        string AG, idAgencia;
        int newidag;

        public string idagencia;


        string sexo, status, idVendedor, valor, renda, nascimento, arquivo, CNPJ, CPF, Agencia, Conta, telefone, celular;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        private string idProcesso;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;

        public Form_Dados_Agencias()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Agencias)
                {
                    Form_Dados_Agencias formularioPai = (Form_Dados_Agencias)this.Owner;
                }
                if (this.Owner is Form_Cadastro_Agencias)
                {
                    Form_Cadastro_Agencias formularioPai = (Form_Cadastro_Agencias)this.Owner;
                }
            }
        }
        public void setIdVendedor(string idvend)
        {
            idVendedor = idvend;
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
        public event Action AgenciaSalvoEdit;
        
        public void setTextNome(String sNome)
        {
           // txtnomevendedor.Text = sNome;

        }
        private void btnclosecli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtrendacli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                   // e.Handled = (txtrendavendedor.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtagencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtdescricaoag_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtend_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (txtdescricaoag.Text == "")
            {
                MessageBox.Show("Campo Descrição da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtdescricaoag.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtagencia.Text == "")
            {
                MessageBox.Show("Campo Nº da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtagencia.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço da Agencia é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabagencia;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            //AG = txtagencia.Text;

            #region Check Agencia
            //LoginDaoComandos checkexisteag = new LoginDaoComandos();


            //Agencia agencia = null;

            //agencia = checkexisteag.GetNumAgencia(AG);

            //string idag = agencia.Id_agencia;
            //string descriag = agencia.Descri_agencia;
            //string numag = agencia.Num_Agencia;

            //if (string.IsNullOrEmpty(agencia.Id_agencia))
            //{

                LoginDaoComandos updateagencia = new LoginDaoComandos();

                 updateagencia.UpdateAgencia(idagencia, txtdescricaoag.Text, txtagencia.Text, txtend.Text);
                
               // idagencia = txtagencia.Text;

                if (updateagencia.mensagem == "Erro")
                {
                    MessageBox.Show("Não foi possivel atualizar a Agência!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                    return;
                }
                else
                {
                   // LoginDaoComandos getagencia = new LoginDaoComandos();

                    //Agencia numagencia = null;

                    //numagencia = getagencia.GetNumAgencia(AG);
                    //idagencia = agencia.Id_agencia;

                    MessageBox.Show("Agencia Atualizada com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (AgenciaSalvo != null)
                        AgenciaSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
                }



            /*}
            else
            {
                //var result = MessageBox.Show("Já existe um cadastro desta Agência \n AG: " + numag + " \n Descrição: " + descriag + " \n Deseja editalo ?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("Já existe um cadastro desta Agência \n AG: " + numag + " \n Descrição: " + descriag + " \n Verifique!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                /*if (result == DialogResult.Yes)
                {

                    Form_Dados_Agencias frm_dados_agencias = new Form_Dados_Agencias();
                    frm_dados_agencias.setIdAgencia(idagencia);
                    frm_dados_agencias.Show();
                    Cursor = Cursors.Default;
                    Close();
                }
                else
                {
                    Cursor = Cursors.Default;
                    return;
                }
            } */
            #endregion
            Cursor = Cursors.Default;

            btn_editar.Visible = true;
            splitter1.Visible = false;
            btn_cancelar.Visible = false;
            splitter2.Visible = false;
            btn_salvar.Visible = false;


            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();
            
            if (AgenciaSalvoEdit != null)
                AgenciaSalvoEdit.Invoke();

        }

        private void Form_Dados_Agencias_Shown(object sender, EventArgs e)
        {
            
            txtdescricaoag.Select(txtdescricaoag.Text.Length, 0);
            this.ActiveControl = txtdescricaoag;
            txtdescricaoag.Focus();
           // txtdescricaoag.SelectionStart = txtdescricaoag.Text.Length;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarEdicao();
        }


        private void Form_Dados_Agencia_Load(object sender, EventArgs e)
        {
            LoadDadosAgencia();
        }
        public void setIdAgencia(string idag)
        {
            idagencia = idag;
        }
        public void habilitar()
        {
            /*
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = false;
            btn_salvar.Visible = true;

            splitter3.Visible = false;
            btn_excluir.Visible = false; */

            btn_editar.Visible = false;
            splitter1.Visible = false;
            btn_salvar.Visible = true;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter3.Visible = false;
            btn_excluir.Visible = false;

            HabilitarEdicao();
            //txtdescricaoag.Select();
            txtdescricaoag.Select(txtdescricaoag.Text.Length, 0);
            this.ActiveControl = txtdescricaoag;
            txtdescricaoag.Focus();


        }
        public void LoadDadosAgencia()
        {
            Cursor = Cursors.WaitCursor;
            Agencia vendedor = new Agencia();

            LoginDaoComandos getvendedor = new LoginDaoComandos();
            vendedor = getvendedor.GetAgencia(idagencia);

            txtagencia.Text = vendedor.Num_Agencia;
            txtdescricaoag.Text = vendedor.Descri_agencia;
            txtend.Text = vendedor.End_Agencia;
            
            /*
            if (vendedor.Sexo_vendedor == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (vendedor.Sexo_vendedor == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (vendedor.Status_vendedor == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Vendedor Ativo";
            }

            if (vendedor.Status_vendedor == "Inativo")
            {
                checkBox_status.Text = "Vendedor Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Vendedor
            valor = txtrendavendedor.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendavendedor.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendavendedor.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendavendedor.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendavendedor.Text.StartsWith("0,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendavendedor.Text.Contains("00,"))
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendavendedor.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendavendedor.Text;
            txtrendavendedor.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendavendedor.Select(txtrendavendedor.Text.Length, 0);
            #endregion

            txtnomevendedor.Select(txtnomevendedor.Text.Length, 0);
            this.ActiveControl = txtnomevendedor;
            txtnomevendedor.Focus();*/
            Cursor = Cursors.Default;
        }
        public event Action AgenciaSalvo;
        

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
                AG = txtagencia.Text;
                var result = MessageBox.Show("Deseja Excluir a  Agência: \n \n " + txtagencia.Text + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deleteagencia = new LoginDaoComandos();

                DataTable dt = deleteagencia.GetProcessoAgencia(idagencia);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] rows = dt.Select();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        idProcesso = rows[i]["id"].ToString();
                    }
                    var result1 = MessageBox.Show("Não Foi possível Excluir a Agência: \n \n " + txtagencia.Text + " !  \n \n Existe Processo Ativo para essa Agência. \n \n Deseja Alterar a Agência do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result1 == DialogResult.Yes)
                    {
                        Form_Dados_Processos frm_dados_documentos = new Form_Dados_Processos();
                        frm_dados_documentos.setIdProcess(idProcesso);
                        frm_dados_documentos.setUserLoged(idresponsavel, nomeresponsavel);
                        frm_dados_documentos.setTABcontrol(2);
                        frm_dados_documentos.Show();
                        Cursor = Cursors.Default;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Agência não Excluído!");
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {

                    deleteagencia.DeleteAgenciaID(idagencia);
                    idagencia = "7";
                    MessageBox.Show(deleteagencia.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (AgenciaSalvoEdit != null)
                        AgenciaSalvoEdit.Invoke();
                    if (AgenciaSalvo != null)
                        AgenciaSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
                }
            
            }

        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void btn_editar_Click(object sender, EventArgs e)
        {

            habilitar();
                /*
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = false;
            btn_salvar.Visible = true;

            splitter3.Visible = false;
            btn_excluir.Visible = false;


            HabilitarEdicao();
            txtagencia.Select();*/
        }


        private void HabilitarEdicao()
        {
            //txtagencia.ReadOnly = false;
            txtdescricaoag.ReadOnly = false;
            txtend.ReadOnly = false;
            
        }
        private void DesabilitarEdicao()
        {
            txtagencia.ReadOnly = true;
            txtdescricaoag.ReadOnly = true;
            txtend.ReadOnly = true;

            btn_editar.Visible = true;
            splitter1.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = false;
            btn_salvar.Visible = false;
            splitter3.Visible = true;
            btn_excluir.Visible = true;

            LoadDadosAgencia();
            //tabControl.SelectedTab = tabControl.TabPages["tabagencia"];
        }
    }
}
