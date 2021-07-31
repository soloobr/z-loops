using ComponentFactory.Krypton.Toolkit;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using br.corp.bonus630.FullText;
using System.Data;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Processos : Form
    {

        bool Next;
        string valor, svalorimovel, svalorfinanciado, idCartorio;
        ToFullText tft;


        string  idProcess, datacpf, dataciweb, datacadmut, datair, datafgts, dataanalise, dataeng, datastatus, statusprocesso, datasiopi, datasictd, datasaquefgts, datapa, datacartorio;

        //private int cadastrar = 0;
        //private int newProgressValue;

        public Form_Dados_Processos()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            tft = new ToFullText();
            //bPopCombo = false;
        }
        public void setLabel(string statuslbl)
        {
            lblstatus.Text = statuslbl;
        }
        public void setIdProcess(string idprocesso)
        {
            idProcess = idprocesso.PadLeft(4, '0');
        }
        
        private void Form_Dados_Documentos_Load(object sender, EventArgs e)
        {
            Processo process = null;
            LoginDaoComandos gettpross = new LoginDaoComandos();
            process = gettpross.GetProcesso(idProcess);

            var parsedDate = DateTime.Parse(process.Data_processo);
            string asString = parsedDate.ToString("dd/MMMM/yyyy");

            #region Processos
            lblnumeroprocesso.Text = idProcess;
            lblfuncresponsavel.Text = process.Nome_responsavel;
            lbldata.Text = asString;

            svalorimovel = process.Valor_imovel;
            valorimovel.Text = process.Valor_imovel;
            valorimovel.Select(valorimovel.Text.Length, 0);

            valorfinanciado.Text = process.ValorFinanciado_imovel;
            valorfinanciado.Select(valorfinanciado.Text.Length, 0);
            #endregion

            #region Cliente
            ComboBoxClient.Text = process.Nome_cliente;
            txtcpf.Text = process.CPF_cliente;
            txtrg.Text = process.RG_cliente;
            txtnasc.Text = process.Nascimento_cliente;
            txtemail.Text = process.Email_cliente;
            txttelefone.Text = process.Telefone_cliente;
            txtcelular.Text = process.Celular_cliente;
            txtrenda.Text = process.Renda_cliente;
            txtrenda.Select(txtrenda.Text.Length, 0);
            txtagenciacliente.Text = process.Agencia_cliente;
            txtcontacliente.Text = process.Conta_cliente;
            txtStatusCPF.Text = process.StatusCPF_cliente;
            txtciweb.Text = process.StatusCiweb_cliente;
            txtcadmut.Text = process.StatusCadmut_cliente;
            txtir.Text = process.StatusIR_cliente;
            txtfgts.Text = process.StatusFGTS_cliente;

            #region Valor Renda Cliente
            valor = txtrenda.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrenda.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrenda.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrenda.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrenda.Text.StartsWith("0,"))
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrenda.Text.Contains("00,"))
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrenda.Text;
            txtrenda.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrenda.Select(txtrenda.Text.Length, 0);
            #endregion

            if (process.H_DataStatusCPF != "")
            {
                if (process.H_DataStatusCPF != "01/01/0001 00:00:00")
                {
                    lbldatacpf.Text = process.H_DataStatusCPF;
                    lbldatacpf.Visible = true;
                }
            }
            if (process.H_DataStatusCiweb != "")
            {
                if (process.H_DataStatusCiweb != "01/01/0001 00:00:00")
                {
                    lbldataciweb.Text = process.H_DataStatusCiweb;
                    lbldataciweb.Visible = true;
                }
            }
            if (process.H_DataStatusCadmut != "")
            {
                if (process.H_DataStatusCadmut != "01/01/0001 00:00:00")
                {
                    lbldatacadmut.Text = process.H_DataStatusCadmut;
                    lbldatacadmut.Visible = true;
                }
            }
            if (process.H_DataStatusIR != "")
            {
                if (process.H_DataStatusIR != "01/01/0001 00:00:00")
                {
                    lbldatair.Text = process.H_DataStatusIR;
                    lbldatair.Visible = true;
                }
            }
            if (process.H_DataStatusFGTS != "")
            {
                if (process.H_DataStatusFGTS != "01/01/0001 00:00:00")
                {
                    lbldatafgts.Text = process.H_DataStatusFGTS;
                    lbldatafgts.Visible = true;
                }
            }

            #endregion

            #region Vendedor
            textnomevendedor.Text = process.Nome_vendedor;
            if(process.CNPJ_vendedor == "")
            {
                textcnpjcpf.Text = process.CPF_vendedor;
            }
            else
            {
                textcnpjcpf.Text = process.CNPJ_vendedor;
            }
            textemailvendedor.Text = process.Email_vendedor;
            texttelefonevendedor.Text = process.Telefone_vendedor;
            textcelularvendedor.Text = process.Celular_vendedor;
            //txtrenda.Text = process.Renda_vendedor;
            textagenciavendedor.Text = process.Agencia_vendedor;
            txtcontavendedor.Text = process.Conta_vendedor;
            #endregion

            #region Popular combobox
            comboBox_agencia.DataSource = gettpross.GetDataAgencia();
            comboBox_agencia.DisplayMember = "Agencia";
            comboBox_agencia.ValueMember = "Id";


            comboBox_programa.DataSource = gettpross.GetDataPrograma();
            comboBox_programa.DisplayMember = "Descricao";
            comboBox_programa.ValueMember = "Id";

            comboBox_corretora.DataSource = gettpross.GetDataCorretora();
            comboBox_corretora.DisplayMember = "Descricao";
            comboBox_corretora.ValueMember = "Id";

            comboBox_corretor.DataSource = gettpross.GetDataCorretores();
            comboBox_corretor.DisplayMember = "Nome";
            comboBox_corretor.ValueMember = "Id";

            comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
            comboBox_empreendimentos.DisplayMember = "Descricao";
            comboBox_empreendimentos.ValueMember = "Id";

            #endregion

            #region imovel

            comboBox_analise.Text = process.StatusAnalise_cliente;
            comboBox_statuseng.Text = process.StatusEng_cliente;
            comboBox_saque.Text = process.SaqueFGTS_cliente;
            comboBox_SIOPI.Text = process.SIOPI_cliente;
            comboBox_SICTD.Text = process.SICTD_cliente;
            comboBox_PA.Text = process.StatusPA_cliente;
            comboBox_agencia.Text = process.AgenciaImovel_imovel.PadLeft(4, '0'); 
            comboBox_programa.Text = process.Programa_imovel;
            valorimovel.Text = process.Valor_imovel;
            valorfinanciado.Text = process.ValorFinanciado_imovel;
            comboBox_corretora.Text = process.Descricao_corretora;
            comboBox_corretor.Text = process.Nome_corretor;
            comboBox_empreendimentos.Text = process.EmpDescricao_imovel;

            lbldataanalise.Text = process.H_DataStatusAnalise;
            lbldataeng.Text = process.H_DataStatusEng;
            lbldatasaquefgts.Text = process.H_DataSaqueFGTS;
            lbldatasiopi.Text = process.H_DataSIOP;
            lbldatasictd.Text = process.H_DataSICTD;
            lbldatapa.Text = process.H_DataPA;

            if (process.H_DataStatusAnalise != "")
            {
                if (process.H_DataStatusAnalise != "01/01/0001 00:00:00")
                {
                    lbldataanalise.Text = process.H_DataStatusAnalise;
                    lbldataanalise.Visible = true;
                    //MessageBox.Show(process.H_DataStatusAnalise);
                }
            }
            if (process.H_DataStatusEng != "")
            {
                if (process.H_DataStatusEng != "01/01/0001 00:00:00")
                {
                    lbldataeng.Text = process.H_DataStatusEng;
                    lbldataeng.Visible = true;
                }
            }
            if (process.H_DataSIOP != "")
            {
                if (process.H_DataSIOP != "01/01/0001 00:00:00")
                {
                    lbldatasiopi.Text = process.H_DataSIOP;
                    lbldatasiopi.Visible = true;
                }
            }
            if (process.H_DataSICTD != "")
            {
                if (process.H_DataSICTD != "01/01/0001 00:00:00")
                {
                    lbldatasictd.Text = process.H_DataSICTD;
                    lbldatasictd.Visible = true;
                }
            }
            if (process.H_DataSaqueFGTS != "")
            {
                if (process.H_DataSaqueFGTS != "01/01/0001 00:00:00")
                {
                    lbldatasaquefgts.Text = process.H_DataStatusFGTS;
                    lbldatasaquefgts.Visible = true;
                }
            }
            if (process.H_DataPA != "")
            {
                if (process.H_DataPA != "01/01/0001 00:00:00")
                {
                    lbldatapa.Text = process.H_DataPA;
                    lbldatapa.Visible = true;
                }
            }
            #endregion

            #region Cartorio

            comboBox_nomecartorio.DataSource = gettpross.GetDataCartorio();
            comboBox_nomecartorio.DisplayMember = "Descricao";
            comboBox_nomecartorio.ValueMember = "Id";
            comboBox_nomecartorio.SelectedIndex = -1;

            idCartorio = process.id_Carftorio;

            comboBox_statuscartorio.Text = process.StatusCartorio;
            if (process.H_DataStatusCartorio != "" && process.H_DataStatusCartorio != "01/01/0001 00:00:00")
            {
                lbldatacartorio.Text = process.H_DataStatusCartorio;
                lbldatacartorio.Visible = true;
                lblnomecartorio.Text = process.Descricao_Carftorio;

            }
            
            


            #endregion

            #region Checkstatus

            Next = true;

            if (Next)
            {
                switch (process.StatusCPF_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar CPF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar CPF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Com Restrição":
                        lblstatus.Text = "CPF Com Restrição";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Divergente RF":
                        lblstatus.Text = "CPF Divergente RF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Bloqueado em outro CCA":
                        lblstatus.Text = "CPF Bloqueado em outro CCA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (process.StatusCiweb_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar Ciweb";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar Ciweb";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Ativo":
                        lblstatus.Text = "Ciweb Ativo";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Inativo":
                        lblstatus.Text = "Ciweb Inativo";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (process.StatusCadmut_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar Cadmut";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar Cadmut";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Ativo":
                        lblstatus.Text = "Cadmut Ativo";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Inativo":
                        lblstatus.Text = "Cadmut Inativo";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (process.StatusIR_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar IR";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar IR";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Isento":
                        lblstatus.Text = "Isento de IR";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Declarado":
                        lblstatus.Text = "IR Declarado";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                }
            }

            if (Next)
            {
                switch (process.StatusFGTS_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar FGTS";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar FGTS";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Já subsidiado":
                        lblstatus.Text = "FGTS Já subsidiado";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não subsidiado":
                        
                        lblstatus.Text = "FGTS Não subsidiado";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                }
            }



            #endregion



        }
        public event Action ProcessoSalvo;

        private void Get_Status ()
        {
            #region Checkstatus

            Next = true;

            if (Next)
            {
                switch (txtStatusCPF.Text)
                {
                    case "":
                        statusprocesso = "Consultar CPF";
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar CPF";
                           Next = false;
                        break;
                    case "Com Restrição":
                        statusprocesso = "CPF Com Restrição";
                        Next = false;
                        break;
                    case "Divergente RF":
                        statusprocesso = "CPF Divergente RF";
                        Next = false;
                        break;
                    case "Bloqueado em outro CCA":
                        statusprocesso = "CPF Bloqueado em outro CCA";
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (txtciweb.Text)
                {
                    case "":
                        statusprocesso = "Consultar Ciweb";
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar Ciweb";
                        Next = false;
                        break;
                    case "Ativo":
                        statusprocesso = "Ciweb Ativo";
                        Next = true;
                        break;
                    case "Inativo":
                        statusprocesso = "Ciweb Inativo";
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (txtcadmut.Text)
                {
                    case "":
                        statusprocesso = "Consultar Cadmut";
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar Cadmut";
                        Next = false;
                        break;
                    case "Ativo":
                        statusprocesso = "Cadmut Ativo";
                        Next = true;
                        break;
                    case "Inativo":
                        statusprocesso = "Cadmut Inativo";
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                switch (txtir.Text)
                {
                    case "":
                        statusprocesso = "Consultar IR";
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar IR";
                        Next = false;
                        break;
                    case "Isento":
                        statusprocesso = "Isento de IR";
                        Next = true;
                        break;
                    case "Declarado":
                        statusprocesso = "IR Declarado";
                        Next = true;
                        break;
                }
            }

            if (Next)
            {
                switch (txtfgts.Text)
                {
                    case "":
                        statusprocesso = "Consultar FGTS";
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar FGTS";
                        Next = false;
                        break;
                    case "Já subsidiado":
                        statusprocesso = "FGTS Já subsidiado";
                        Next = false;
                        break;
                    case "Não subsidiado":
                        statusprocesso = "FGTS Não subsidiado";
                        Next = true;
                        break;
                }
            }



            #endregion

        }

        private void btncloseconf_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvardoc_Click(object sender, EventArgs e)
        {
            Get_Status();
            LoginDaoComandos updateprocesso = new LoginDaoComandos();

            #region Check Datas
            if (lbldatacpf.Text != "__/ ___/ ____")
            {
                datacpf = lbldatacpf.Text;
            }
            else
            {
                datacpf = "01/01/0001 00:00:00";
            }

            if (lbldataciweb.Text != "__/ ___/ ____")
            {
                dataciweb = lbldataciweb.Text;
            }
            else
            {
                dataciweb = "01/01/0001 00:00:00";
            }

            if (lbldatacadmut.Text != "__/ ___/ ____")
            {
                datacadmut = lbldatacadmut.Text;
            }
            else
            {
                datacadmut = "01/01/0001 00:00:00";
            }

            if (lbldatair.Text != "__/ ___/ ____")
            {
                datair = lbldatair.Text;
            }
            else
            {
                datair = "01/01/0001 00:00:00";
            }

            if (lbldatair.Text != "__/ ___/ ____")
            {
                datafgts = lbldatafgts.Text;
            }
            else
            {
                datafgts = "01/01/0001 00:00:00";
            }



            if (lbldataanalise.Text != "__/ ___/ ____")
            {
                dataanalise = lbldataanalise.Text;
            }
            else
            {
                dataanalise = "01/01/0001 00:00:00";
            }

            if (lbldataeng.Text != "__/ ___/ ____")
            {
                dataeng = lbldataeng.Text;
               }
            else
            {
                dataeng = "01/01/0001 00:00:00";
            }

            if (lbldatasiopi.Text != "__/ ___/ ____")
            {
                datasiopi = lbldatasiopi.Text;
            }
            else
            {
                datasiopi = "01/01/0001 00:00:00";
            }


            if (lbldatasictd.Text != "__/ ___/ ____")
            {
                datasictd = lbldatasictd.Text;
            }
            else
            {
                datasictd = "01/01/0001 00:00:00";
            }

            if (lbldatasaquefgts.Text != "__/ ___/ ____")
            {
                datasaquefgts = lbldatasaquefgts.Text;
            }
            else
            {
                datasaquefgts = "01/01/0001 00:00:00";
            }

            if (lbldatapa.Text != "__/ ___/ ____")
            {
                datapa = lbldatapa.Text;
            }
            else
            {
                datapa = "01/01/0001 00:00:00";
            }

            if (lbldatacartorio.Text != "__/ ___/ ____")
            {
                datacartorio = lbldatacartorio.Text;
            }
            else
            {
                datacartorio = "01/01/0001 00:00:00";
            }

            if (lblstatus.Text != "__/ ___/ ____")
            {
                datastatus = lblstatus.Text;
            }
            else
            {
                datastatus = "01/01/0001 00:00:00";
            }
            #endregion


            DateTime datecpf = DateTime.Parse(datacpf);
            DateTime dateciweb = DateTime.Parse(dataciweb);
            DateTime datecadmut = DateTime.Parse(datacadmut);
            DateTime dateir = DateTime.Parse(datair);
            DateTime datefgts = DateTime.Parse(datafgts);
            DateTime dateanalise = DateTime.Parse(dataanalise);
            DateTime dateeng = DateTime.Parse(dataeng);

            DateTime datesiopi = DateTime.Parse(datasiopi);
            DateTime datesictd = DateTime.Parse(datasictd);
            DateTime datesaquefgts = DateTime.Parse(datasaquefgts);
            DateTime datepa = DateTime.Parse(datapa);
            DateTime datecartorio = DateTime.Parse(datacartorio);
            //DateTime datestatus = DateTime.Parse(datastatus);

            lblstatus.Text = statusprocesso;

            String Valorimov = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            String Valorfinan = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            //MessageBox.Show(Valorimov);

            //if (comboBox_agencia.SelectedValue == null)
            //{
            //    return;
            //}
            string comboagencia = comboBox_agencia.SelectedValue.ToString();

            //if (comboBox_programa.SelectedValue == null)
            //{
            //    return;
            //}
            string comboprograma = comboBox_programa.SelectedValue.ToString();

            string combocorretora = comboBox_corretora.SelectedValue.ToString();
            string combocorretores = comboBox_corretor.SelectedValue.ToString();
            string combocoempreendimentos = comboBox_empreendimentos.SelectedValue.ToString();

            //MessageBox.Show(idCartorio);


                      updateprocesso.UpdateProcesso(idProcess, comboagencia, comboprograma, combocorretora, combocorretores, combocoempreendimentos, txtStatusCPF.Text, txtciweb.Text, txtcadmut.Text, txtir.Text, txtfgts.Text, datecpf, dateciweb, datecadmut, dateir, datefgts, dateanalise, dateeng, datesiopi, datesictd, datesaquefgts, datepa, Valorimov, Valorfinan, idCartorio, comboBox_statuscartorio.Text, datecartorio,  statusprocesso);
            MessageBox.Show(updateprocesso.mensagem);


            if (ProcessoSalvo != null)
            //{
                ProcessoSalvo.Invoke();
            //}
                

            Close();

        }
       
        private void btncancelardoc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Dados_Documentos_Paint(object sender, PaintEventArgs e)
        {
            Functions.Arredonda(pnlAnalise, 15, true, true);
            Functions.Arredonda(pnleng, 15, true, true);
            Functions.Arredonda(pnlfgts, 15, true, true);
            Functions.Arredonda(pnlsiopi, 15, true, true);
            Functions.Arredonda(pnlsictd, 15, true, true);
            Functions.Arredonda(pnlpa, 15, true, true);
            Functions.Arredonda(btnenviar, 10, true, true);
        }

        private void comboBox_analise_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldataanalise.Text = "";

            switch (comboBox_analise.SelectedItem.ToString()) 
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data;
                    lbldataanalise.Visible = true;
                    break;
                case "Aprovado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data1;
                    lbldataanalise.Visible = true;
                    break;
                case "Condicionado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data2;
                    lbldataanalise.Visible = true;
                    break;
                case "Em analise":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data3;
                    lbldataanalise.Visible = true;
                    break;
                case "Reprovado":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data4;
                    lbldataanalise.Visible = true;
                    break;
                case "Comando":
                    String Data5 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data5;
                    lbldataanalise.Visible = true;
                    break;
                case "Desistiu":
                    String Data6 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Visible = true;
                    lbldataanalise.Text = Data6;
                    lbldataanalise.Visible = true;
                    break;
                case "Bloqueado em ourto CCA":
                    String Data7 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataanalise.Text = Data7;
                    lbldataanalise.Visible = true;
                    break;
        }
    
    }

        private void comboBox_statuseng_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldataeng.Text = "";

            switch (comboBox_statuseng.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data0 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data0;
                    lbldataeng.Visible = true;
                    break;
                case "Aguardando Pagamento":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data;
                    lbldataeng.Visible = true;
                    break;
                case "Aprovado Abaixo":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data1;
                    lbldataeng.Visible = true;
                    break;
                case "Aprovado Normal":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data2;
                    lbldataeng.Visible = true;
                    break;
                case "Contestação":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data3;
                    lbldataeng.Visible = true;
                    break;
                case "Solicitado":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldataeng.Text = Data4;
                    lbldataeng.Visible = true;
                    break;
            }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorimovel.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "");
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void txt_valor_KeyUp(object sender, KeyEventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorimovel.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorimovel.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorimovel.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorimovel.Text.StartsWith("0,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorimovel.Text.Contains("00,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorimovel.Text;
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorimovel.Select(valorimovel.Text.Length, 0);
        }

        private void valorimovel_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorimovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorimovel.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void valorimovel_Leave(object sender, EventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "");
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void valorimovel_KeyUp(object sender, KeyEventArgs e)
        {
            valor = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorimovel.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorimovel.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorimovel.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorimovel.Text.StartsWith("0,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorimovel.Text.Contains("00,"))
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorimovel.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorimovel.Text;
            valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorimovel.Select(valorimovel.Text.Length, 0);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tabimovel"])//your specific tabname
            {
                #region Valor Imovel
                valor = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    valorimovel.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    valorimovel.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    valorimovel.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (valorimovel.Text.StartsWith("0,"))
                    {
                        valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (valorimovel.Text.Contains("00,"))
                    {
                        valorimovel.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        valorimovel.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = valorimovel.Text;
                valorimovel.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                valorimovel.Select(valorimovel.Text.Length, 0);
                #endregion

                #region Valor Financiado
                valor = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    valorfinanciado.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    valorfinanciado.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    valorfinanciado.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (valorfinanciado.Text.StartsWith("0,"))
                    {
                        valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (valorfinanciado.Text.Contains("00,"))
                    {
                        valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        valorfinanciado.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = valorfinanciado.Text;
                valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                valorfinanciado.Select(valorfinanciado.Text.Length, 0);
                #endregion

                LoginDaoComandos getitenscomboagengia = new LoginDaoComandos();


                #region Popular combobox
                //comboBox_agencia.DataSource = getitenscomboagengia.GetDataAgencia();
                //comboBox_agencia.DisplayMember = "Agencia";
                //comboBox_agencia.ValueMember = "Id";
               

                //comboBox_programa.DataSource = getitenscomboagengia.GetDataPrograma();
                //comboBox_programa.DisplayMember = "Descricao";
                //comboBox_programa.ValueMember = "Id";
                #endregion
            }
            if (tabControl.SelectedTab == tabControl.TabPages["tabcliente"])//your specific tabname
            {
                #region Valor Renda Cliente
                valor = txtrenda.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    txtrenda.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    txtrenda.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    txtrenda.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (txtrenda.Text.StartsWith("0,"))
                    {
                        txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (txtrenda.Text.Contains("00,"))
                    {
                        txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        txtrenda.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = txtrenda.Text;
                txtrenda.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                txtrenda.Select(txtrenda.Text.Length, 0);
                #endregion
            }
        }

        private void comboBox_empreendimentos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public class ConverteListaDataTable
        {
            public static DataTable ConverteListaString(List<string[]> lista)
            {
                // Cria Novo DataTable
                DataTable table = new DataTable();
                // Numero maximo de colunas
                int columns = 0;
                foreach (var array in lista)
                {
                    if (array.Length > columns)
                    {
                        columns = array.Length;
                    }
                }
                // incluir colunas
                for (int i = 0; i < columns; i++)
                {
                    table.Columns.Add();
                }
                // inclui linhas
                foreach (var array in lista)
                {
                    table.Rows.Add(array);
                }
                return table;
            }
        }
        private void valorfinanciado_KeyUp(object sender, KeyEventArgs e)
        {
            valor = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                valorfinanciado.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                valorfinanciado.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                valorfinanciado.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (valorfinanciado.Text.StartsWith("0,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (valorfinanciado.Text.Contains("00,"))
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    valorfinanciado.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = valorfinanciado.Text;
            valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            valorfinanciado.Select(valorfinanciado.Text.Length, 0);
        }

        private void valorfinanciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorfinanciado.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void valorfinanciado_Leave(object sender, EventArgs e)
        {
            valor = valorfinanciado.Text.Replace("R$", "");
            valorfinanciado.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtrenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (valorimovel.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtrenda_KeyUp(object sender, KeyEventArgs e)
        {
            valor = txtrenda.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txtrenda.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txtrenda.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txtrenda.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txtrenda.Text.StartsWith("0,"))
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txtrenda.Text.Contains("00,"))
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txtrenda.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txtrenda.Text;
            txtrenda.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txtrenda.Select(txtrenda.Text.Length, 0);
        }

        private void txtrenda_Leave(object sender, EventArgs e)
        {
            valor = txtrenda.Text.Replace("R$", "");
            txtrenda.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if(comboBox_nomecartorio.Text == "")
            {
                MessageBox.Show("Favor Selecione o cartorio");
                comboBox_nomecartorio.DroppedDown = true;
            }
            else
            {
                if(lblnomecartorio.Text != comboBox_nomecartorio.Text && lblnomecartorio.Text != "Selecione o Cartório" && lblnomecartorio.Text != "")
                {
                    if (MessageBox.Show("Já entregue ao Cartório: "+ "\n" +  lblnomecartorio.Text + "\n" + " Deseja alterar o cartório?", "Systema Informa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        
                        idCartorio = comboBox_nomecartorio.SelectedValue.ToString();

                        //MessageBox.Show(comboBox_nomecartorio.SelectedValue.ToString());
                        lblnomecartorio.Text = comboBox_nomecartorio.Text;
                        int index = comboBox_statuscartorio.FindString("Entregue");
                        comboBox_statuscartorio.SelectedIndex = index;

                        String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lbldatacartorio.Text = Data;
                        lbldatacartorio.Visible = true;

                        comboBox_nomecartorio.SelectedIndex = -1;
                    }
                    else
                    {
                        comboBox_nomecartorio.SelectedIndex = -1;
                    }

                }
                else
                {
                    idCartorio = comboBox_nomecartorio.SelectedValue.ToString();
                    lblnomecartorio.Text = comboBox_nomecartorio.Text;
                    int index = comboBox_statuscartorio.FindString("Entregue");
                    comboBox_statuscartorio.SelectedIndex = index;

                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatacartorio.Text = Data;
                    lbldatacartorio.Visible = true;

                    comboBox_nomecartorio.SelectedIndex = -1;
                }
            }
            

            




        }

        private void comboBox_statuscartorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(lblnomecartorio.Text == "Selecione o Cartório")
            {
                comboBox_statuscartorio.SelectedIndex = -1;
                MessageBox.Show("Favor Selecione o cartorio");
                comboBox_nomecartorio.DroppedDown = true;
            }else if(lblnomecartorio.Text == "")
            {
                comboBox_statuscartorio.SelectedIndex = -1;
                MessageBox.Show("Favor Selecione o cartorio");
                comboBox_nomecartorio.DroppedDown = true;
            }
            else
            {
                lbldatacartorio.Text = "";

                switch (comboBox_statuscartorio.SelectedItem.ToString())
                {
                    case "Entregue":
                        String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lbldatacartorio.Text = Data;
                        lbldatacartorio.Visible = true;
                        break;
                    case "A retirar":
                        String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lbldatacartorio.Text = Data1;
                        lbldatacartorio.Visible = true;
                        break;
                    case "Aguardando":
                        String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lbldatacartorio.Text = Data2;
                        lbldatacartorio.Visible = true;
                        break;
                    case "Retirado":
                        String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lbldatacartorio.Text = Data3;
                        lbldatacartorio.Visible = true;
                        break;
                }
            }
            
           
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            //label31.Text = tft.showText(txt_valor.Text);
        }

        private void comboBox_SIOPI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatasiopi.Text = "";
            switch (comboBox_SIOPI.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasiopi.Text = Data;
                    lbldatasiopi.Visible = true;
                    break;
                case "Enviado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasiopi.Text = Data1;
                    lbldatasiopi.Visible = true;
                    break;
                case "Não Enviado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasiopi.Text = Data2;
                    lbldatasiopi.Visible = true;
                    break;
            }
        }

        private void comboBox_SICTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatasictd.Text = "";
            switch (comboBox_SICTD.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasictd.Text = Data;
                    lbldatasictd.Visible = true;
                    break;
                case "Enviado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasictd.Text = Data1;
                    lbldatasictd.Visible = true;
                    break;
                case "Não Enviado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasictd.Text = Data2;
                    lbldatasictd.Visible = true;
                    break;
            }
        }

        private void comboBox_saque_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatasaquefgts.Text = "";
            switch (comboBox_saque.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasaquefgts.Text = Data;
                    lbldatasaquefgts.Visible = true;
                    break;
                case "Total":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasaquefgts.Text = Data1;
                    lbldatasaquefgts.Visible = true;
                    break;
                case "Parcial":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasaquefgts.Text = Data2;
                    lbldatasaquefgts.Visible = true;
                    break;
                case "Não Usar":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatasaquefgts.Text = Data3;
                    lbldatasaquefgts.Visible = true;
                    break;
             }
        }

        private void comboBox_PA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatapa.Text = "";
            switch (comboBox_PA.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatapa.Text = Data;
                    lbldatapa.Visible = true;
                    break;
                case "Conforme":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatapa.Text = Data1;
                    lbldatapa.Visible = true;
                    break;
                case "Inconforme":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    lbldatapa.Text = Data2;
                    lbldatapa.Visible = true;
                    break;
            }
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void txtStatusCPF_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtStatusCPF_SelectionChangeCommitted(object sender, EventArgs e)
        {

            lbldatacpf.Text = "";


            switch (txtStatusCPF.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    lbldatacpf.Text = Data ;
                    lbldatacpf.Visible = true;
                    break;
                case "Com Restrição":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    lbldatacpf.Text = Data1;
                    lbldatacpf.Visible = true;
                    break;
                case "Divergente RF":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    lbldatacpf.Text = Data2;
                    lbldatacpf.Visible = true;
                    break;
                case "Nada Consta":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    lbldatacpf.Text = Data3;
                    lbldatacpf.Visible = true;
                    break;
                case "Bloqueado em outro CCA":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    lbldatacpf.Text = Data4;
                    lbldatacpf.Visible = true;
                    break;
            }
        }

        private void txtciweb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldataciweb.Text = "";


            switch (txtciweb.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    lbldataciweb.Text = Data;
                    lbldataciweb.Visible = true;
                    break;
                case "Ativo":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    lbldataciweb.Text = Data1;
                    lbldataciweb.Visible = true;
                    break;
                case "Inativo":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    lbldataciweb.Text = Data2;
                    lbldataciweb.Visible = true;
                    break;
                case "Nada Consta":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    lbldataciweb.Text = Data3;
                    lbldataciweb.Visible = true;
                    break;
                    //case "Bloqueado em outro CCA":
                    //    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //    //lbldataciweb.Visible = true;
                    //    lbldataciweb.Text = Data4;
                    //    lbldataciweb.Visible = true;
                    //    break;
            }
        }



        private void txtir_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatair.Text = "";

            switch (txtir.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatair.Visible = true;
                    lbldatair.Text = Data;
                    lbldatair.Visible = true;
                    break;
                case "Isento":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatair.Visible = true;
                    lbldatair.Text = Data1;
                    lbldatair.Visible = true;
                    break;
                case "Declarado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatair.Visible = true;
                    lbldatair.Text = Data2;
                    lbldatair.Visible = true;
                    break;
                //case "Nada Consta":
                //    String Data3 = DateTime.Now.ToString("M/d/yyyy");
                //    lbldatair.Visible = true;
                //    lbldatair.Text = Data3;
                //    lbldatair.Visible = true;
                //    break;
                //case "Bloqueado em outro CCA":
                //    String Data4 = DateTime.Now.ToString("M/d/yyyy");
                //    lbldatair.Visible = true;
                //    lbldatair.Text = Data4;
                //    lbldatair.Visible = true;
                //    break;
            }
        }

        private void txtfgts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatafgts.Text = "";

            switch (txtfgts.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatafgts.Visible = true;
                    lbldatafgts.Text = Data;
                    lbldatafgts.Visible = true;
                    break;
                case "Já subsidiado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    // lbldatafgts.Visible = true;
                    lbldatafgts.Text = Data1;
                    lbldatafgts.Visible = true;
                    break;
                case "Não subsidiado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    // lbldatafgts.Visible = true;
                    lbldatafgts.Text = Data2;
                    lbldatafgts.Visible = true;
                    break;
                //case "Nada Consta":
                //    String Data3 = DateTime.Now.ToString("M/d/yyyy");
                //    lbldatafgts.Visible = true;
                //    lbldatafgts.Text = Data3;
                //    lbldatafgts.Visible = true;
                //    break;
                //case "Bloqueado em outro CCA":
                //    String Data4 = DateTime.Now.ToString("M/d/yyyy");
                //    lbldatafgts.Visible = true;
                //    lbldatafgts.Text = Data4;
                //    lbldatafgts.Visible = true;
                //    break;
            }
        }

        private void txtcadmut_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbldatacadmut.Text = "";

            switch (txtciweb.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatacadmut.Visible = true;
                    lbldatacadmut.Text = Data;
                    lbldatacadmut.Visible = true;
                    break;
                case "Ativo":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatacadmut.Visible = true;
                    lbldatacadmut.Text = Data1;
                    lbldatacadmut.Visible = true;
                    break;
                case "Inativo":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatacadmut.Visible = true;
                    lbldatacadmut.Text = Data2;
                    lbldatacadmut.Visible = true;
                    break;
                case "Nada Consta":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatacadmut.Visible = true;
                    lbldatacadmut.Text = Data3;
                    lbldatacadmut.Visible = true;
                    break;

            }
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

  
    }
}
