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
    public partial class Form_Dados_Empreendimentos : Form
    {
        string descricaoempre, idEmpreendimento;
        int newidag;

        public string idempreendimento;


        string sexo, status, idVendedor, valor, renda, nascimento, arquivo, CNPJ, CPF, Empreendimento, Conta, telefone, celular;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        private string idProcesso;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;

        public Form_Dados_Empreendimentos()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Empreendimentos)
                {
                    Form_Dados_Empreendimentos formularioPai = (Form_Dados_Empreendimentos)this.Owner;
                }
                if (this.Owner is Form_Cadastro_Empreendimentos)
                {
                    Form_Cadastro_Empreendimentos formularioPai = (Form_Cadastro_Empreendimentos)this.Owner;
                }
            }
        }
        public void habilitar()
        {
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = true;

            splitter3.Visible = false;
            btn_excluir.Visible = false;


            HabilitarEdicao();
            txtdescricaoag.Select();
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
        public event Action EmpreendimentoSalvoEdit;
        
        public void setTextNome(String sNome)
        {
           // txtnomeempreendimento.Text = sNome;

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
                   // e.Handled = (txtrendaempreendimento.Text.Contains(","));
                }
                else
                    e.Handled = true;
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
                MessageBox.Show("Campo Descrição da Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabempreendimento;
                txtdescricaoag.Select();
                Cursor = Cursors.Default;
                return;
            }
            /*
            if (txtempreendimento.Text == "")
            {
                MessageBox.Show("Campo Nº da Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabempreendimento;
                txtempreendimento.Select();
                Cursor = Cursors.Default;
                return;
            }*/

            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço da Empreendimento é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabempreendimento;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            //descricaoempre = txtdescricaoag.Text;

            #region Update Empreendimento
            LoginDaoComandos updateempreendimento = new LoginDaoComandos();

            updateempreendimento.UpdateEmpreendimento(idempreendimento, txtdescricaoag.Text, txtend.Text);

            if (updateempreendimento.mensagem == "Erro")
            {
                MessageBox.Show("Não foi possivel atualizar o Empreendimento!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }
            else
            {
                MessageBox.Show("Empreendimento Atualizado com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (EmpreendimentoSalvo != null)
                    EmpreendimentoSalvo.Invoke();
                Cursor = Cursors.Default;
                Close();
            }
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
            
            if (EmpreendimentoSalvo != null)
                EmpreendimentoSalvo.Invoke();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = true;
            splitter1.Visible = true;
            splitter2.Visible = false;
            btn_cancelar.Visible = false;
            btn_salvar.Visible = false;
            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();
            LoadDadosEmpreendimento();
            tabControl.SelectedTab = tabControl.TabPages["tabempreendimento"];
            Cursor = Cursors.Default;
            //Close();
        }


        private void Form_Dados_Empreendimentos_Load(object sender, EventArgs e)
        {
            LoadDadosEmpreendimento();
        }
        public void setIdEmpreendimento(string idag)
        {
            idempreendimento = idag;
        }
        public void LoadDadosEmpreendimento()
        {
            Cursor = Cursors.WaitCursor;
            Empreendimento empreendimento = new Empreendimento();

            LoginDaoComandos getempreendimento = new LoginDaoComandos();
            empreendimento = getempreendimento.GetEmpreendimento(idempreendimento);

            txtempreendimento.Text = empreendimento.Id_empreendimentos;
            txtdescricaoag.Text = empreendimento.Descri_empreendimentos;
            txtend.Text = empreendimento.End_empreendimentos;
            
            /*
            if (empreendimento.Sexo_empreendimento == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (empreendimento.Sexo_empreendimento == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (empreendimento.Status_empreendimento == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Vendedor Ativo";
            }

            if (empreendimento.Status_empreendimento == "Inativo")
            {
                checkBox_status.Text = "Vendedor Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Vendedor
            valor = txtrendaempreendimento.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendaempreendimento.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendaempreendimento.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendaempreendimento.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendaempreendimento.Text.StartsWith("0,"))
                {
                    txtrendaempreendimento.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendaempreendimento.Text.Contains("00,"))
                {
                    txtrendaempreendimento.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendaempreendimento.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendaempreendimento.Text;
            txtrendaempreendimento.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendaempreendimento.Select(txtrendaempreendimento.Text.Length, 0);
            #endregion

            txtnomeempreendimento.Select(txtnomeempreendimento.Text.Length, 0);
            this.ActiveControl = txtnomeempreendimento;
            txtnomeempreendimento.Focus();*/
            Cursor = Cursors.Default;
        }
        public event Action EmpreendimentoSalvo;
        

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            descricaoempre = txtdescricaoag.Text;
                var result = MessageBox.Show("Deseja Excluir o  Empreendimento: \n \n " + txtempreendimento.Text + " - "+ descricaoempre + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deleteempreendimento = new LoginDaoComandos();

                DataTable dt = deleteempreendimento.GetProcessoEmpreendimento(idempreendimento);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] rows = dt.Select();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        idProcesso = rows[i]["id"].ToString();
                    }
                    var result1 = MessageBox.Show("Não Foi possível Excluir o Empreendimento: \n \n " + txtempreendimento.Text+ " - " + descricaoempre + ".  \n \n Existe Processo Ativo para esse Empreendimento. \n \n Deseja Alterar o Empreendimento do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                        MessageBox.Show("Empreendimento não Excluído!");
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {

                    deleteempreendimento.DeleteEmpreendimentoID(idempreendimento);
                    //idempreendimento = "7";
                    MessageBox.Show(deleteempreendimento.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (EmpreendimentoSalvoEdit != null)
                        EmpreendimentoSalvoEdit.Invoke();
                    if (EmpreendimentoSalvo != null)
                        EmpreendimentoSalvo.Invoke();
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

            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = true;

            splitter3.Visible = false;
            btn_excluir.Visible = false;


            HabilitarEdicao();
            txtdescricaoag.Select();
        }


        private void HabilitarEdicao()
        {
            txtempreendimento.ReadOnly = true;
            txtdescricaoag.ReadOnly = false;
            txtend.ReadOnly = false;
            
        }
        private void DesabilitarEdicao()
        {
            txtempreendimento.ReadOnly = true;
            txtdescricaoag.ReadOnly = true;
            txtend.ReadOnly = true;
            
        }
    }
}
