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
    public partial class Form_Dados_Corretor : Form
    {
        String sexo, status, idCorretor, idLogin, valor, renda, nascimento, arquivo, RG, CPF;
        String excluirimage, idProcesso;
        String permission;
        FileStream fsObj = null;
        BinaryReader binRdr = null;
        bool arquivobase;

        public string idcorretor;
        private string idresponsavel;
        private string idresponsavelSelected;
        private string nomeresponsavel;
        public event Action CorretorSalvoEdit;

        public Form_Dados_Corretor()
        {
            InitializeComponent();
        }
        public void setIdCorretor(string idcor)
        {
            idCorretor = idcor;
        }
        public void setTextNome(String sNome)
        {
            txtnomecorretor.Text = sNome;

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
        private void btnclosefunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_salvar_func_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtnomecorretor.Text == "")
            {
                MessageBox.Show("Campo Nome do Corretor é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnomecorretor.Select();
                Cursor = Cursors.Default;
                return;
            }

            if (checkBox_Masculino.Checked)
            {
                sexo = "Masculino";
            }
            else if (checkBox_Feminino.Checked)
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "";
            }
            if (checkBox_status.Checked)
            {
                status = "Ativo";
            }
            else
            {
                status = "Inativo";
            }

            if (txtcpf.Text == "")
            {
                MessageBox.Show("Campo CPF é necessario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcpf.Select();
                Cursor = Cursors.Default;
                return;
            }
            CPF = FormatCnpjCpf.SemFormatacao(txtcpf.Text);


            if (txtrg.Text == "")
            {
                RG = "0";
            }
            else
            {
                RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);
            }
            //String RG = FormatCnpjCpf.SemFormatacao(txtrg.Text);

            DateTime dataa;
            DateTime.TryParse(txtnasc.Text + " " + "00:00:00", out dataa);

            DateTime datanasc = dataa;

            //DateTime datanasc = DateTime.Parse(nascimento);



            //String renda = txtrendacli.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

            //LoginDaoComandos insertfotocorretor = new LoginDaoComandos();
            /*if (excluirimage == "Update")
            {
                if (arquivobase == false)
                {
                    fsObj = File.OpenRead(arquivo);
                    //MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    //--insertfotocorretor.InsertFotoCorretor(idCorretor, imgContent, txtnomecorretor.Text);
                }
                else
                {
                    fsObj = File.OpenRead(arquivo);
                    // MessageBox.Show(fsObj.ToString());
                    byte[] imgContent = new byte[fsObj.Length];
                    binRdr = new BinaryReader(fsObj);
                    imgContent = binRdr.ReadBytes((int)fsObj.Length);

                    //--insertfotocorretor.UpdateFotoCorretor(idCorretor, imgContent);
                }
                if (insertfotocorretor.mensagem == "OK")
                {

                }
                else
                {
                    MessageBox.Show(insertfotocorretor.mensagem, "Atualizando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (excluirimage == "Excluir")
            {
                LoginDaoComandos excluircorretor = new LoginDaoComandos();
                //--excluircorretor.DeleteFotoCorretor(idCorretor);
                if (excluircorretor.mensagem == "Excluido")
                {

                }
                else
                {
                    MessageBox.Show(insertfotocorretor.mensagem, "Apagando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

            //idLogin = idCorretor;


            if (txtpermission.Text != "")
            {
                if (txtpermission.Text == "Operador(a)")
                {
                    permission = "3";
                }
                else if (txtpermission.Text == "Supervisor(a)")
                {
                    permission = "2";
                }
                else if (txtpermission.Text == "Gerente")
                {
                    permission = "1";
                }
                else if (txtpermission.Text == "Master")
                {
                    permission = "10";
                }

            }
            else
            {
                permission = "3";
            }

            LoginDaoComandos updatecorretor = new LoginDaoComandos();

            updatecorretor.UpdateCorretor(idCorretor, txtnomecorretor.Text, CPF, txtemail.Text, datanasc, txttelefone.Text, txtcelular.Text,txtendereco.Text, RG, sexo, status);

            Cursor = Cursors.Default;

            MessageBox.Show(updatecorretor.mensagem, "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btn_editar.Visible = true;
            splitter1.Visible = false;
            btn_cancelar.Visible = false;
            splitter2.Visible = false;
            btn_salvar.Visible = false;


            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();

            if (CorretorSalvo != null)
                CorretorSalvo.Invoke();

        }

        private void btn_cancelar_func_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = true;
            splitter1.Visible = true;
            splitter2.Visible = false;
            btn_cancelar.Visible = false;
            btn_salvar.Visible = false;
            splitter3.Visible = true;
            btn_excluir.Visible = true;

            DesabilitarEdicao();
            LoadDadosCorretor();
            tabControl.SelectedTab = tabControl.TabPages["tabcorretor"];

            //Close();
        }

        private void Form_Dados_Corretor_Load(object sender, EventArgs e)
        {
            LoadDadosCorretor();
        }
        public event Action CorretorSalvo;
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
            txtnomecorretor.Select();
        }
        public void LoadDadosCorretor()
        {
            Cursor = Cursors.WaitCursor;
            Corretor corretor = null;

            LoginDaoComandos getcorretor = new LoginDaoComandos();
            corretor = getcorretor.GetCorretorC(idCorretor);

            txtnomecorretor.Text = corretor.Nome_corretor;
            txtemail.Text = corretor.Email_corretor;
            txttelefone.Text = corretor.Telefone_corretor;
            txtrg.Text = corretor.RG_corretor;
            txtcpf.Text = corretor.CPF_corretor;
            txtrg.Text = corretor.RG_corretor;
            txtnasc.Text = corretor.Nascimento_corretor;


            txtcelular.Text = corretor.Celular_corretor;
            //txtrendacli.Text = corretor.Renda_corretor;
            txtendereco.Text = corretor.Endereco_corretor;
            //txtcracha.Text = corretor.Cracha_corretor;
            /*if (corretor.Permision != "")
            {
                if (corretor.Permision == "3")
                {
                    txtpermission.Text =  "Operador(a)";
                }
                else if (corretor.Permision == "2")
                {
                    txtpermission.Text = "Supervisor(a)";
                }
                else if (corretor.Permision == "1" )
                {
                    txtpermission.Text = "Gerente";
                }
                else if (corretor.Permision == "10")
                {
                    txtpermission.Text = "Master";
                }

            }
             
            */
            if (corretor.Sexo_corretor == "Masculino")
            {
                checkBox_Masculino.Checked = true;

            }
            else if (corretor.Sexo_corretor == "Feminino")
            {
                checkBox_Feminino.Checked = true;
            }

            
            if (corretor.Status_corretor == "Ativo")
            {
                checkBox_status.Checked = true;
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Corretor Ativo";
            }

            if (corretor.Status_corretor == "Inativo")
            {
                checkBox_status.Text = "Corretor Inativo";
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Checked = false;
            }
            
            txtnomecorretor.Select(txtnomecorretor.Text.Length, 0);
            this.ActiveControl = txtnomecorretor;
            txtnomecorretor.Focus();
            Cursor = Cursors.Default;
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            Cursor = Cursors.Default;
        }

        private void checkBox_status_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtcpf_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtcpf.Text)
            {
                if (((cont == 3) || (cont == 7)) && (c != '.') && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }
                if ((c == '.') && (txtcpf.Text.Length >= cont) && (cont != 3) && (cont != 7))
                {
                    txtcpf.Text = txtcpf.Text.Remove(cont, 1);
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }

                if ((cont == 11) && (c != '-') && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Insert(11, "-");
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }
                if ((c == '-') && (cont != 11) && (txtcpf.Text.Length >= cont))
                {
                    txtcpf.Text = txtcpf.Text.Remove(cont, 1);
                    txtcpf.Select(txtcpf.Text.Length, 0);
                }

                cont++;
            }
            valor = txtcpf.Text;
            if (valor.Length >= 15)
            {
                MessageBox.Show("Limete maximo para o CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtcpf.Text = txtcpf.Text.Remove(txtcpf.Text.Length - 1);
                txtcpf.Select(txtcpf.Text.Length, 0);
            }
        }

        private void txtrg_KeyUp(object sender, KeyEventArgs e)
        {
            int cont = 0;
            //int cursorPos = SelectionStart;

            foreach (Char c in txtrg.Text)
            {
                if (((cont == 2) || (cont == 6)) && (c != '.') && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Insert(cont, ".");
                    //SelectionStart = cursorPos + 1;
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                if ((c == '.') && (txtrg.Text.Length >= cont) && (cont != 2) && (cont != 6))
                {
                    txtrg.Text = txtrg.Text.Remove(cont, 1);
                    txtrg.Select(txtrg.Text.Length, 0);
                }


                if ((c == '-') && (cont != 10) && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Remove(cont, 1);
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                if ((cont == 10) && (c != '-') && (txtrg.Text.Length >= cont))
                {
                    txtrg.Text = txtrg.Text.Insert(10, "-");
                    txtrg.Select(txtrg.Text.Length, 0);
                }
                cont++;
            }

            valor = txtrg.Text;
            if (valor.Length >= 13)
            {
                MessageBox.Show("Limete maximo para o RG", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtrg.Text = txtrg.Text.Remove(txtrg.Text.Length - 1);
                txtrg.Select(txtrg.Text.Length, 0);
            }
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtnomecorretor_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btn_excluir_func_Click(object sender, EventArgs e)
        {

            string nome = txtnomecorretor.Text;
            var result = MessageBox.Show("Deseja Excluir o  Corretor: \n \n " + idCorretor + " - " + nome + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                LoginDaoComandos deletecorretor = new LoginDaoComandos();

                DataTable dt = deletecorretor.GetProcessoCorretor(idCorretor);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] rows = dt.Select();
                    for (int i = 0; i < rows.Length; i++)
                    {
                        idProcesso = rows[i]["id"].ToString();
                    }
                    var result1 = MessageBox.Show("Não Foi possível Excluir o Corretor: \n \n " + idCorretor + " - " + nome + ".  \n \n Existe Processo Ativo para esse Corretor. \n \n Deseja Alterar o Corretor do Processo: " + idProcesso + " ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                        MessageBox.Show("Corretor não Excluído!");
                        Cursor = Cursors.Default;
                        return;
                    }
                }
                else
                {

                    deletecorretor.DeleteCorretorID(idCorretor);
                    //idcorretor = "7";
                    MessageBox.Show(deletecorretor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (CorretorSalvoEdit != null)
                        CorretorSalvoEdit.Invoke();
                    if (CorretorSalvo != null)
                        CorretorSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
                }

            }




            /*



            Cursor = Cursors.WaitCursor;
            var result = MessageBox.Show("Deseja Excluir o Corretor: \n " + txtnomecorretor.Text + "  ?", "excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LoginDaoComandos deletecorretor = new LoginDaoComandos();

                    MessageBox.Show(deletecorretor.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (CorretorSalvo != null)
                        CorretorSalvo.Invoke();
                    Cursor = Cursors.Default;
                    Close();
            }*/
            Cursor = Cursors.Default;
        }

        private void splitter3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_status_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_status.Checked)
            {
                checkBox_status.ForeColor = System.Drawing.Color.Blue;
                checkBox_status.Text = "Corretor Ativo";
                status = "Ativo";
            }
            else
            {
                checkBox_status.ForeColor = System.Drawing.Color.Red;
                checkBox_status.Text = "Corretor Inativo";
                status = "Inativo";
            }
        }

        private void btn_editar_func_Click(object sender, EventArgs e)
        {
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btn_cancelar.Visible = true;
            splitter1.Visible = true;
            btn_salvar.Visible = true;

            splitter3.Visible = false;
            btn_excluir.Visible = false;


            HabilitarEdicao();
            txtnomecorretor.Select();
        }


        private void HabilitarEdicao()
        {
            txtnomecorretor.ReadOnly = false;
            txtcpf.ReadOnly = false;
            txtrg.ReadOnly = false;
            txtnasc.ReadOnly = false;
            txtemail.ReadOnly = false;
            txttelefone.ReadOnly = false;
            txtcelular.ReadOnly = false;
            //txtrendacli.ReadOnly = false;
            checkBox_status.Enabled = true;
            checkBox_Masculino.Enabled = true;
            checkBox_Feminino.Enabled = true;
            txtendereco.ReadOnly = false;
            //txtcracha.ReadOnly = false;
            txtpermission.Enabled = true;

        }
        private void DesabilitarEdicao()
        {
            txtnomecorretor.ReadOnly = true;
            txtcpf.ReadOnly = true;
            txtrg.ReadOnly = true;
            txtnasc.ReadOnly = true;
            txtemail.ReadOnly = true;
            txttelefone.ReadOnly = true;
            txtcelular.ReadOnly = true;
            //txtrendacli.ReadOnly = true;
            checkBox_status.Enabled = false;
            checkBox_Masculino.Enabled = false;
            checkBox_Feminino.Enabled = false;
            txtendereco.ReadOnly = true;
            //txtcracha.ReadOnly = true;
            txtpermission.Enabled = false;
        }
    }
}
