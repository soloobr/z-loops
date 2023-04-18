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
    public partial class Form_Dados_Construtora : Form
    {
        string descricaoempre, idConstrutora;
        int newidag;

        public string idconstrutora;


        string sexo, status, idVendedor, valor, renda, nascimento, arquivo, CNPJ, CPF, Construtora, Conta, telefone, celular;
        String excluirimage;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;
        private string idProcesso;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;

        public Form_Dados_Construtora()
        {
            InitializeComponent();
            if (this.Owner != null)
            {
                if (this.Owner is Form_Dados_Processos)
                {
                    Form_Dados_Processos formularioPai = (Form_Dados_Processos)this.Owner;
                }
                if (this.Owner is Form_Dados_Construtora)
                {
                    Form_Dados_Construtora formularioPai = (Form_Dados_Construtora)this.Owner;
                }
                if (this.Owner is Form_Cadastro_Construtora)
                {
                    Form_Cadastro_Construtora formularioPai = (Form_Cadastro_Construtora)this.Owner;
                }
            }
        }
        public void setIdVendedor(string idvend)
        {
            idVendedor = idvend;
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
            txtdescricao.Select();
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
        public event Action ConstrutoraSalvoEdit;
        
        public void setTextNome(String sNome)
        {
           // txtnomeconstrutora.Text = sNome;

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
                   // e.Handled = (txtrendaconstrutora.Text.Contains(","));
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

        private void txtcnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtcnpj_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcnpj.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((c == '.') && (txtcnpj.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtcnpj.Text = txtcnpj.Text.Remove(cont, 1);
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((cont == 10) && (c != '/') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(10, @"/");
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }


                if ((cont == 14) && (c != '-') && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Insert(15, "-");
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                if ((c == '-') && (cont != 16) && (txtcnpj.Text.Length >= cont))
                {
                    txtcnpj.Text = txtcnpj.Text.Remove(cont, 1);
                    txtcnpj.Select(txtcnpj.Text.Length, 0);
                }
                cont++;
            }

            valor = txtcnpj.Text;
            if (valor.Length >= 19)
            {
                MessageBox.Show("Limete maximo para o CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcnpj.Text = txtcnpj.Text.Remove(txtcnpj.Text.Length - 1);
                txtcnpj.Select(txtcnpj.Text.Length, 0);
            }
        }

        private void txtcnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txtcnpj.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (txtdescricao.Text == "")
            {
                MessageBox.Show("Campo Descrição da Construtora é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtdescricao.Select();
                Cursor = Cursors.Default;
                return;
            }
            if (txtcnpj.Text == "")
            {
                MessageBox.Show("Campo CNPJ é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtcnpj.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (txtend.Text == "")
            {
                MessageBox.Show("Campo Endereço da Construtora é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabconstrutora;
                txtend.Select();
                Cursor = Cursors.Default;
                return;
            }
            //descricaoempre = txtdescricaoag.Text;

            #region Update Construtora
            LoginDaoComandos updateconstrutora = new LoginDaoComandos();

            CNPJ = FormatCnpjCpf.SemFormatacao(txtcnpj.Text);

            updateconstrutora.UpdateConstrutora(idconstrutora, txtdescricao.Text, CNPJ, txtend.Text);

            if (updateconstrutora.mensagem == "Erro")
            {
                MessageBox.Show("Não foi possivel atualizar o Construtora!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }
            else
            {
                MessageBox.Show("Construtora Atualizada com Sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ConstrutoraSalvo != null)
                    ConstrutoraSalvo.Invoke();
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
            
            if (ConstrutoraSalvo != null)
                ConstrutoraSalvo.Invoke();

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
            LoadDadosConstrutora();
            tabControl.SelectedTab = tabControl.TabPages["tabconstrutora"];
            Cursor = Cursors.Default;
            //Close();
        }


        private void Form_Dados_Construtora_Load(object sender, EventArgs e)
        {
            LoadDadosConstrutora();
        }
        public void setIdConstrutora(string idag)
        {
            idconstrutora = idag;
        }
        public void LoadDadosConstrutora()
        {
            Cursor = Cursors.WaitCursor;
            Construtora construtora = new Construtora();

            LoginDaoComandos getconstrutora = new LoginDaoComandos();
            construtora = getconstrutora.GetConstrutoraC(idconstrutora);

            txtconstrutora.Text = construtora.Id_construtora;
            txtdescricao.Text = construtora.Descri_construtora;
            txtcnpj.Text = FormatCnpjCpf.FormatCNPJ(construtora.CNPJ_construtora);
            txtend.Text = construtora.End_construtora;
            

            /*
            if (construtora.Sexo_construtora == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (construtora.Sexo_construtora == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }


            if (construtora.Status_construtora == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Vendedor Ativo";
            }

            if (construtora.Status_construtora == "Inativo")
            {
                checkBox_status.Text = "Vendedor Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            #region Valor Renda Vendedor
            valor = txtrendaconstrutora.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrendaconstrutora.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrendaconstrutora.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrendaconstrutora.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrendaconstrutora.Text.StartsWith("0,"))
                {
                    txtrendaconstrutora.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrendaconstrutora.Text.Contains("00,"))
                {
                    txtrendaconstrutora.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrendaconstrutora.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrendaconstrutora.Text;
            txtrendaconstrutora.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrendaconstrutora.Select(txtrendaconstrutora.Text.Length, 0);
            #endregion

            txtnomeconstrutora.Select(txtnomeconstrutora.Text.Length, 0);
            this.ActiveControl = txtnomeconstrutora;
            txtnomeconstrutora.Focus();*/
            Cursor = Cursors.Default;
        }
        public event Action ConstrutoraSalvo;
        

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            descricaoempre = txtdescricao.Text;
                var result = MessageBox.Show("Deseja Excluir o  Construtora: \n \n " + txtconstrutora.Text + " - "+ descricaoempre + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deleteconstrutora = new LoginDaoComandos();

                DataTable dt = deleteconstrutora.GetProcessoConstrutora(idconstrutora);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] rows = dt.Select();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        idProcesso = rows[i]["id"].ToString();
                    }
                    var result1 = MessageBox.Show("Não Foi possível Excluir o Construtora: \n \n " + txtconstrutora.Text+ " - " + descricaoempre + ".  \n \n Existe Processo Ativo para esse Construtora. \n \n Deseja Alterar o Construtora do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                        MessageBox.Show("Construtora não Excluído!");
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {

                    deleteconstrutora.DeleteConstrutoraID(idconstrutora);
                    //idconstrutora = "7";
                    MessageBox.Show(deleteconstrutora.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ConstrutoraSalvoEdit != null)
                        ConstrutoraSalvoEdit.Invoke();
                    if (ConstrutoraSalvo != null)
                        ConstrutoraSalvo.Invoke();
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
            txtdescricao.Select();
        }


        public void HabilitarEdicao()
        {
            txtconstrutora.ReadOnly = true;
            txtdescricao.ReadOnly = false;
            txtcnpj.ReadOnly = false;
            txtend.ReadOnly = false;
            
        }
        public void DesabilitarEdicao()
        {
            txtconstrutora.ReadOnly = true;
            txtdescricao.ReadOnly = true;
            txtcnpj.ReadOnly = true;
            txtend.ReadOnly = true;
            
        }
    }
}
