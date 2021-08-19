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
using System.Security;

using System.IO;
using System.Net;
using System.ComponentModel;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Processos : Form
    {

        bool Next;
        string valor, svalorimovel, svalorfinanciado, idCartorio ;
        string curFile, NewFile, extension, Local, idArquivo, numArquivo, descArquivo, dataAruivo, statusArquivo;
        string idagencia, idprograma, idcorretora, idcorretor, idempreendimentos;
        int count;
        FileStream fs;
        BinaryReader br;
        byte ImageData;
        ToFullText tft;
        int ultimoID;
        DateTime datecpf, dateciweb, datecadmut, dateir, datefgts,  dateanalise, dateeng, datesiopi, datesictd, datesaquefgts, datepa, datecartorio;


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
            Cursor = Cursors.WaitCursor;
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
            #endregion

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

            #region Ajusta Datas
            if (process.H_DataStatusCPF != "")
            {
                if (process.H_DataStatusCPF != "01/01/0001 00:00:00")
                {
                    lblacpf.Visible = true;
                    dtpcpf.Visible = true;
                    dtpcpf.Value = DateTime.Parse(process.H_DataStatusCPF);
                }
            }
            if (process.H_DataStatusCiweb != "")
            {
                if (process.H_DataStatusCiweb != "01/01/0001 00:00:00")
                {
                    lblaciweb.Visible = true;
                    dtpciweb.Visible = true;
                    dtpciweb.Value = DateTime.Parse(process.H_DataStatusCiweb);
                }
            }
            if (process.H_DataStatusCadmut != "")
            {
                if (process.H_DataStatusCadmut != "01/01/0001 00:00:00")
                {
                    //lbldatacadmut.Text = process.H_DataStatusCadmut;
                    //lbldatacadmut.Visible = true;
                    lblacadmut.Visible = true;
                    dtpcadmut.Visible = true;
                    dtpcadmut.Value = DateTime.Parse(process.H_DataStatusCadmut);
                }
            }
            if (process.H_DataStatusIR != "")
            {
                if (process.H_DataStatusIR != "01/01/0001 00:00:00")
                {
                    //lbldatair.Text = process.H_DataStatusIR;
                    //lbldatair.Visible = true;
                    lblair.Visible = true;
                    dtpir.Visible = true;
                    dtpir.Value = DateTime.Parse(process.H_DataStatusIR);
                }
            }
            if (process.H_DataStatusFGTS != "")
            {
                if (process.H_DataStatusFGTS != "01/01/0001 00:00:00")
                {
                    //lbldatafgts.Text = process.H_DataStatusFGTS;
                    //lbldatafgts.Visible = true;
                    lblafgtscli.Visible = true;
                    dtpfgtscli.Visible = true;
                    dtpfgtscli.Value = DateTime.Parse(process.H_DataStatusFGTS);
                }
            }

            #endregion

            #region Vendedor
            textnomevendedor.Text = process.Nome_vendedor;
            
            if(process.CNPJ_vendedor != "0")
            {
                textcnpjcpf.Text = process.CNPJ_vendedor;
            }
            else
            {
                textcnpjcpf.Text = process.CPF_vendedor;
                
            }
            textemailvendedor.Text = process.Email_vendedor;
            texttelefonevendedor.Text = process.Telefone_vendedor;
            textcelularvendedor.Text = process.Celular_vendedor;
            txtrenda.Text = process.Renda_vendedor;
            textagenciavendedor.Text = process.Agencia_vendedor;
            txtcontavendedor.Text = process.Conta_vendedor;
            #endregion


            #region imovel

            comboBox_analise.Text = process.StatusAnalise_cliente;
            comboBox_statuseng.Text = process.StatusEng_cliente;
            comboBox_saque.Text = process.SaqueFGTS_cliente;
            comboBox_SIOPI.Text = process.SIOPI_cliente;
            comboBox_SICTD.Text = process.SICTD_cliente;
            comboBox_PA.Text = process.StatusPA_cliente;

            idagencia = process.Id_AgenciaImovel;
            //comboBox_agencia.Items.Add(process.AgenciaImovel_imovel.PadLeft(4, '0'));
            comboBox_agencia.Items.Add(process.AgenciaImovel_imovel);
            comboBox_agencia.Text = process.AgenciaImovel_imovel;
            

            idprograma = process.Id_Programa;
            comboBox_programa.Items.Add(process.Programa_imovel);
            comboBox_programa.Text = process.Programa_imovel;
            

            valorimovel.Text = process.Valor_imovel;
            valorfinanciado.Text = process.ValorFinanciado_imovel;

            idcorretora = process.Id_corretora;
            comboBox_corretora.Items.Add(process.Descricao_corretora);
            comboBox_corretora.Text = process.Descricao_corretora;
            

            idcorretor = process.Id_corretor;
            comboBox_corretor.Items.Add(process.Nome_corretor);
            comboBox_corretor.Text = process.Nome_corretor;
            

            idempreendimentos = process.id_Empreendimentos_imovel;
            comboBox_empreendimentos.Items.Add(process.EmpDescricao_imovel);
            comboBox_empreendimentos.Text = process.EmpDescricao_imovel;
            

            if (process.H_DataStatusAnalise != "")
            {
                if (process.H_DataStatusAnalise != "01/01/0001 00:00:00")
                {
                    ////lbldataanalise.Text = process.H_DataStatusAnalise;
                    ////lbldataanalise.Visible = true;
                    lblaanalise.Visible = true;
                    dtpanalise.Visible = true;
                    dtpanalise.Value = DateTime.Parse(process.H_DataStatusAnalise);
                    //MessageBox.Show(process.H_DataStatusAnalise);
                }
            }
            
            if (process.H_DataStatusEng != "")
            {
                //MessageBox.Show(process.H_DataStatusEng);
                //MessageBox.Show(DateTime.Parse(process.H_DataStatusEng).ToString());
                if (process.H_DataStatusEng != "01/01/0001 00:00:00")
                {
                    //lbldataeng.Text = process.H_DataStatusEng;
                    //lbldataeng.Visible = true;
                    lblaeng.Visible = true;
                    dtpeng.Visible = true;
                    dtpeng.Value = DateTime.Parse(process.H_DataStatusEng);
                }
            }
            if (process.H_DataSIOP != "")
            {
                if (process.H_DataSIOP != "01/01/0001 00:00:00")
                {
                    //lbldatasiopi.Text = process.H_DataSIOP;
                    //lbldatasiopi.Visible = true;
                    lblasiopi.Visible = true;
                    dtpsiopi.Visible = true;
                    dtpsiopi.Value = DateTime.Parse(process.H_DataSIOP);
                }
            }
            if (process.H_DataSICTD != "")
            {
                if (process.H_DataSICTD != "01/01/0001 00:00:00")
                {
                    //lbldatasictd.Text = process.H_DataSICTD;
                    //lbldatasictd.Visible = true;
                    lblasictd.Visible = true;
                    dtpsictd.Visible = true;
                    dtpsictd.Value = DateTime.Parse(process.H_DataSICTD);
                }
            }
            if (process.H_DataSaqueFGTS != "")
            {
                if (process.H_DataSaqueFGTS != "01/01/0001 00:00:00")
                {
                    //MessageBox.Show(process.H_DataStatusFGTS);
                    //lbldatasaquefgts.Text = process.H_DataStatusFGTS;
                    //lbldatasaquefgts.Visible = true;
                    lblafgts.Visible = true;
                    dtpfgts.Visible = true;
                    dtpfgts.Value = DateTime.Parse(process.H_DataSaqueFGTS);
                }
            }
            if (process.H_DataPA != "")
            {
                if (process.H_DataPA != "01/01/0001 00:00:00")
                {
                    //lbldatapa.Text = process.H_DataPA;
                    //lbldatapa.Visible = true;
                    lblapa.Visible = true;
                    dtppa.Visible = true;
                    dtppa.Value = DateTime.Parse(process.H_DataPA);
                }
            }
            #endregion

            #region Cartorio



            idCartorio = process.id_Carftorio;
            comboBox_nomecartorio.Items.Add(process.Descricao_Carftorio);

            comboBox_statuscartorio.Text = process.StatusCartorio;
            if (process.H_DataStatusCartorio != "" && process.H_DataStatusCartorio != "01/01/0001 00:00:00")
            {
                dtpcartorio.Value = DateTime.Parse(process.H_DataStatusCartorio);
                dtpcartorio.Visible = true;
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

            Cursor = Cursors.Default;

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
            //if (lbldatacpf.Text != "__/ ___/ ____")
            //{
            //    datacpf = lbldatacpf.Text;
            //}
            //else
            //{
            //    datacpf = "01/01/0001 00:00:00";
            //}

            //if (lbldataciweb.Text != "__/ ___/ ____")
            //{
            //    dataciweb = lbldataciweb.Text;
            //}
            //else
            //{
            //    dataciweb = "01/01/0001 00:00:00";
            //}

            //if (lbldatacadmut.Text != "__/ ___/ ____")
            //{
            //    datacadmut = lbldatacadmut.Text;
            //}
            //else
            //{
            //    datacadmut = "01/01/0001 00:00:00";
            //}

            //if (lbldatair.Text != "__/ ___/ ____")
            //{
            //    datair = lbldatair.Text;
            //}
            //else
            //{
            //    datair = "01/01/0001 00:00:00";
            //}

            //if (lbldatair.Text != "__/ ___/ ____")
            //{
            //    datafgts = lbldatafgts.Text;
            //}
            //else
            //{
            //    datafgts = "01/01/0001 00:00:00";
            //}



            //if (//lbldataanalise.Text != "__/ ___/ ____")
            //{
            //    dataanalise = //lbldataanalise.Text;
            //}
            //else
            //{
            //    dataanalise = "01/01/0001 00:00:00";
            //}

            //if (lbldataeng.Text != "__/ ___/ ____")
            //{
            //    dataeng = lbldataeng.Text;
            //   }
            //else
            //{
            //    dataeng = "01/01/0001 00:00:00";
            //}

            //if (lbldatasiopi.Text != "__/ ___/ ____")
            //{
            //    datasiopi = lbldatasiopi.Text;
            //}
            //else
            //{
            //    datasiopi = "01/01/0001 00:00:00";
            //}


            //if (lbldatasictd.Text != "__/ ___/ ____")
            //{
            //    datasictd = lbldatasictd.Text;
            //}
            //else
            //{
            //    datasictd = "01/01/0001 00:00:00";
            //}

            //if (lbldatasaquefgts.Text != "__/ ___/ ____")
            //{
            //    datasaquefgts = lbldatasaquefgts.Text;
            //}
            //else
            //{
            //    datasaquefgts = "01/01/0001 00:00:00";
            //}

            //if (lbldatapa.Text != "__/ ___/ ____")
            //{
            //    datapa = lbldatapa.Text;
            //}
            //else
            //{
            //    datapa = "01/01/0001 00:00:00";
            //}

            //if (lbldatacartorio.Text != "__/ ___/ ____")
            //{
            //    datacartorio = lbldatacartorio.Text;
            //}
            //else
            //{
            //    datacartorio = "01/01/0001 00:00:00";
            //}

            if (lblstatus.Text != "__/ ___/ ____")
            {
                datastatus = lblstatus.Text;
            }
            else
            {
                datastatus = "01/01/0001 00:00:00";
            }
            #endregion

            #region Combox Status

            String cpf = txtStatusCPF.Text;
            if (dtpcpf.Text != "")
            {
                datecpf = DateTime.Parse(dtpcpf.Text);
            }
            else
            {
                datecpf = DateTime.Parse("01/01/0001 00:00:00");
            }

            String ciweb = txtciweb.Text;
            if (dtpciweb.Text != "")
            {
                dateciweb = DateTime.Parse(dtpciweb.Text);
            }
            else
            {
                dateciweb = DateTime.Parse("01/01/0001 00:00:00");
            }

            String cadmut = txtcadmut.Text;
            if (dtpcadmut.Text != "")
            {
                datecadmut = DateTime.Parse(dtpcadmut.Text);
            }
            else
            {
                datecadmut = DateTime.Parse("01/01/0001 00:00:00");
            }

            String ir = txtir.Text;
            if (dtpir.Text != "")
            {
                dateir = DateTime.Parse(dtpir.Text);
            }
            else
            {
                dateir = DateTime.Parse("01/01/0001 00:00:00");
            }

            String fgts = txtfgts.Text;
            if (dtpfgtscli.Text != "")
            {
                datefgts = DateTime.Parse(dtpfgtscli.Text);
            }
            else
            {
                datefgts = DateTime.Parse("01/01/0001 00:00:00");
            }
            

            String analise = comboBox_analise.Text;
            //DateTime dateanalise = DateTime.Parse(dataanalise);
            if (dtpanalise.Text != "")
            {
                dateanalise = DateTime.Parse(dtpanalise.Text);
            }
            else
            {
                dateanalise = DateTime.Parse("01/01/0001 00:00:00");
            }
            String eng = comboBox_statuseng.Text;
            //DateTime dateeng = DateTime.Parse(dataeng);
            if(dtpeng.Text != "")
            {
                dateeng = DateTime.Parse(dtpeng.Text);
            }
            else
            {
                dateeng  = DateTime.Parse("01/01/0001 00:00:00");
            }
            String siopi = comboBox_SIOPI.Text;
            //DateTime datesiopi = DateTime.Parse(datasiopi);
            if (dtpsiopi.Text != "")
            {
                datesiopi = DateTime.Parse(dtpsiopi.Text);
            }
            else
            {
                datesiopi = DateTime.Parse("01/01/0001 00:00:00");
            }
            String sictd = comboBox_SICTD.Text;
            //DateTime datesictd = DateTime.Parse(datasictd);
            if (dtpsictd.Text != "")
            {
                datesictd = DateTime.Parse(dtpsictd.Text);
            }
            else
            {
                datesictd = DateTime.Parse("01/01/0001 00:00:00");
            }
            String saquefgts = comboBox_saque.Text;
            //DateTime datesaquefgts = DateTime.Parse(datasaquefgts);
            if (dtpfgts.Text != "")
            {
                datesaquefgts = DateTime.Parse(dtpfgts.Text);
            }
            else
            {
                datesaquefgts = DateTime.Parse("01/01/0001 00:00:00");
            }
            String pa = comboBox_PA.Text;
            //DateTime datepa = DateTime.Parse(datapa);
            if (dtppa.Text != "")
            {
                datepa = DateTime.Parse(dtppa.Text);

            }
            else
            {
                datepa = DateTime.Parse("01/01/0001 00:00:00");
            }
            //idagencia = comboBox_agencia.SelectedValue.ToString();

            //idprograma = comboBox_programa.SelectedValue.ToString();

            String Valorimov = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            String Valorfinan = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

            String combocorretora = idcorretora;
            String combocorretores = idcorretor;
            String combocoempreendimentos = idempreendimentos;

            if (dtpcartorio.Text == "")
            {
                idCartorio = "0";
            }//Get process load or set combobox click
            String cartorio = comboBox_statuscartorio.Text;
            if (dtpcartorio.Text != "")
            {
                datecartorio = DateTime.Parse(dtpcartorio.Text);
            }
            else
            {
                datecartorio = DateTime.Parse("01/01/0001 00:00:00");
            }


            lblstatus.Text = statusprocesso;
            //DateTime datestatus = DateTime.Parse(datastatus);
            #endregion

            updateprocesso.UpdateProcesso(idProcess, cpf, datecpf, ciweb, dateciweb, cadmut, datecadmut, ir,dateir,fgts,datefgts,analise,dateanalise,eng,dateeng,siopi,datesiopi,sictd,datesictd,saquefgts,datesaquefgts,pa,datepa,idagencia,idprograma,Valorimov,Valorfinan,combocorretora,combocorretores,combocoempreendimentos,idCartorio,cartorio,datecartorio,statusprocesso);
            MessageBox.Show(updateprocesso.mensagem,"Salvar",MessageBoxButtons.OK,MessageBoxIcon.Information);


            if (ProcessoSalvo != null)
                ProcessoSalvo.Invoke();

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
            //dtpanalise.Value = DateTime.Now;
            //dtpanalise.Visible = true;
            //lblaanalise.Visible = true;
            //lbldataanalise.Text = "";

            switch (comboBox_analise.SelectedItem.ToString())
            {
                case "Não Consultado":
                    //String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Aprovado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data1;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Condicionado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data2;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Em analise":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data3;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Reprovado":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data4;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Comando":
                    String Data5 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data5;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Desistiu":
                    String Data6 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Visible = true;
                    //lbldataanalise.Text = Data6;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Bloqueado em ourto CCA":
                    String Data7 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataanalise.Text = Data7;
                    //lbldataanalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
            }

        }

        private void comboBox_statuseng_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dtpeng.Value = DateTime.Now;
            //dtpeng.Visible = true;
            //lblaeng.Visible = true;
            //lbldataeng.Text = "";

            switch (comboBox_statuseng.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data0 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data0;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Aguardando Pagamento":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Aprovado Abaixo":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data1;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Aprovado Normal":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data2;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Contestação":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data3;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Solicitado":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataeng.Text = Data4;
                    //lbldataeng.Visible = true;
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
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

                LoginDaoComandos gettpross = new LoginDaoComandos();



                #region Popular combobox
                //comboBox_agencia.DataSource = gettpross.GetDataAgencia();
                //comboBox_agencia.DisplayMember = "Agencia";
                //comboBox_agencia.ValueMember = "Id";


                //comboBox_programa.DataSource = gettpross.GetDataPrograma();
                //comboBox_programa.DisplayMember = "Descricao";
                //comboBox_programa.ValueMember = "Id";

                //comboBox_corretora.DataSource = gettpross.GetDataCorretora();
                //comboBox_corretora.DisplayMember = "Descricao";
                //comboBox_corretora.ValueMember = "Id";

                //comboBox_corretor.DataSource = gettpross.GetDataCorretores();
                //comboBox_corretor.DisplayMember = "Nome";
                //comboBox_corretor.ValueMember = "Id";

                //comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
                //comboBox_empreendimentos.DisplayMember = "Descricao";
                //comboBox_empreendimentos.ValueMember = "Id";

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
            if (tabControl.SelectedTab == tabControl.TabPages["tabdoc"])
            {

                Cursor = Cursors.WaitCursor;
                #region Ducumentos
                LoginDaoComandos documento = new LoginDaoComandos();
                
                Local = documento.GetServer().ServerFilesPath_Server;
              
                dataGridView_Arquivos.AutoGenerateColumns = false;
                //dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                dataGridView_Arquivos.Refresh();

                Cursor = Cursors.Default;
                #endregion
            }
            if (tabControl.SelectedTab == tabControl.TabPages["tabcartorio"])
            {

                //Cursor = Cursors.WaitCursor;
                //#region Ducumentos
                //LoginDaoComandos documento = new LoginDaoComandos();

                //Local = documento.GetServer().ServerFilesPath_Server;

                //dataGridView_Arquivos.AutoGenerateColumns = false;
                ////dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                //dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                //dataGridView_Arquivos.Refresh();

                //comboBox_nomecartorio.DataSource = gettpross.GetDataCartorio();
                //comboBox_nomecartorio.DisplayMember = "Descricao";
                //comboBox_nomecartorio.ValueMember = "Id";
                //comboBox_nomecartorio.SelectedIndex = -1;

                //Cursor = Cursors.Default;
                //#endregion
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

        private void dataGridView_Arquivos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //if (e.ColumnIndex == 0)
            //{
            //    //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            //    //e.Value(value);
            //    //e.Handled = true;

            //}
                //I supposed your button column is at index 0
                if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_delete_file_16.Width;
                var h = Properties.Resources.icons8_delete_file_16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_delete_file_16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


            //I supposed your button column is at index 0
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_download_16.Width;
                var h = Properties.Resources.icons8_download_16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_download_16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            
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
        private void dataGridView_Arquivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_Arquivos.Columns["apagar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Arquivos.Rows[e.RowIndex];

                String iddoc = row.Cells[0].Value.ToString();
                String extension = row.Cells[7].Value.ToString();
                String pasta = idProcess;

                DialogResult dialogResult = MessageBox.Show("Confima a exclusão do arquivo "+ idProcess+ iddoc+ extension, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoginDaoComandos delete = new LoginDaoComandos();
                    #region Deletar arquivo fisico

                    String Excluir = delete.GetServer().ServerFilesPath_Server + @"\" + pasta + @"\" + idProcess + iddoc + extension;

                    if (File.Exists(Excluir))
                    {
                        delete.DeleteDocumento(iddoc);
                        File.Delete(Excluir);
                        MessageBox.Show(delete.mensagem, "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O arquivo " + Excluir + " não foi encontrado! \n Contate o Suporte Técnico!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
                #region Load Grid
                LoginDaoComandos documento = new LoginDaoComandos();

                dataGridView_Arquivos.AutoGenerateColumns = false;
                //dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                dataGridView_Arquivos.Refresh();
                txtArquivo.Clear();
                #endregion
            }

            if (e.ColumnIndex == dataGridView_Arquivos.Columns["Baixar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Arquivos.Rows[e.RowIndex];

                SaveFileDialog sfd = new SaveFileDialog();

                #region Filter
                switch (row.Cells[7].Value.ToString())
                {
                    case ".pdf":
                        sfd.Filter = "PDF document (*.pdf)|*.pdf";
                        break;
                    case ".jpeg":
                        sfd.Filter = "JPEG Image(.jpeg)| *.jpeg";
                        break;
                    case ".jpg":
                        sfd.Filter = "JPG Image(.jpg)| *.jpg";
                        break;
                    case ".png":
                        sfd.Filter = "Png Image(.png)| *.png";
                        break;
                    case ".doc":
                        sfd.Filter =  "Word Documents|*.doc";
                        break;
                    case ".docx":
                        sfd.Filter = "Word Documents|*.docx";
                        break;
                    case ".xlsx":
                        sfd.Filter = "Excel Worksheets|*.xlsx";
                        break;
                    case ".xls":
                        sfd.Filter = "Excel Worksheets|*.xls";
                        break;
                    default:
                        sfd.Filter = "All files (*.*)|*.*";
                        break;
                }
                #endregion

                //sfd.Filter = "PDF document (*.pdf)|*.pdf| All files (*.*)|*.*";
                //string sfdname = saveFileDialog1.FileName;
                sfd.Title = "Salvar Arquivo";
                sfd.FileName = idProcess + row.Cells[0].Value.ToString().PadLeft(2, '0') + row.Cells[7].Value.ToString(); //"Mac_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
                sfd.RestoreDirectory = true;

                String Filedownload = Local + @"\" + idProcess+@"\"+ sfd.FileName;
                //MessageBox.Show(Filedownload);

                if (File.Exists(Filedownload))
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Download(Filedownload, Path.GetFullPath(sfd.FileName));
                        MessageBox.Show("Arquivo Salvo!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado \n Contate o Suporte Técnico!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox_empreendimentos_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_empreendimentos.DataSource is null)
            {
                comboBox_empreendimentos.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
                comboBox_empreendimentos.DisplayMember = "Descricao";
                comboBox_empreendimentos.ValueMember = "Id";
                comboBox_empreendimentos.MaxDropDownItems = 10;
                //comboBox_empreendimentos.Text = "";
                #endregion

                comboBox_empreendimentos.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_corretora_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_corretora.DataSource is null)
            {
                comboBox_corretora.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_corretora.DataSource = gettpross.GetDataCorretora();
                comboBox_corretora.DisplayMember = "Descricao";
                comboBox_corretora.ValueMember = "Id";
                //txtcorretora.Text = "";
                #endregion

                comboBox_corretora.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_corretor_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_corretor.DataSource is null)
            {
                comboBox_corretor.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_corretor.DataSource = gettpross.GetDataCorretores();
                comboBox_corretor.DisplayMember = "Nome";
                comboBox_corretor.ValueMember = "Id";
                //comboBox_corretor.Text = "";
                #endregion

                comboBox_corretor.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_agencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idagencia = comboBox_agencia.SelectedValue.ToString();
        }

        private void comboBox_corretora_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idcorretora = comboBox_corretora.SelectedValue.ToString();
        }

        private void comboBox_empreendimentos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idempreendimentos = comboBox_empreendimentos.SelectedValue.ToString();
        }

        private void comboBox_programa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idprograma = comboBox_programa.SelectedValue.ToString();
        }

        private void comboBox_corretor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idcorretor = comboBox_corretor.SelectedValue.ToString();
        }

        private void comboBox_nomecartorio_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_nomecartorio.DataSource is null)
            {
                comboBox_nomecartorio.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_nomecartorio.DataSource = gettpross.GetDataCartorio();
                comboBox_nomecartorio.DisplayMember = "Descricao";
                comboBox_nomecartorio.ValueMember = "Id";
                //comboBox_agencia.Text = "";
                #endregion

                comboBox_nomecartorio.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_nomecartorio_SelectionChangeCommitted(object sender, EventArgs e)
        {

            idCartorio = comboBox_nomecartorio.SelectedValue.ToString();
        }

        private void Form_Dados_Processos_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        public void Download(string remoteUri, String folderdestino)
        {
            //string FilePath = Directory.GetCurrentDirectory() + "/tepdownload/" + Path.GetFileName(remoteUri); // path where download file to be saved, with filename, here I have taken file name from supplied remote url
            string FilePath = folderdestino;//+  Path.GetFileName(remoteUri); // path where download file to be saved, with filename, here I have taken file name from supplied remote url
            
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists("tepdownload"))
                    {
                        Directory.CreateDirectory("tepdownload");
                    }
                    Uri uri = new Uri(remoteUri);
                    //password username of your file server eg. ftp username and password
                    client.Credentials = new NetworkCredential("username", "password");
                    //delegate method, which will be called after file download has been complete.
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Extract);
                    //delegate method for progress notification handler.
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgessChanged);
                    // uri is the remote url where filed needs to be downloaded, and FilePath is the location where file to be saved
                    client.DownloadFileAsync(uri, FilePath);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Extract(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine("File has been downloaded.");
        }

        private void comboBox_agencia_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_agencia.DataSource is null)
            {
                comboBox_agencia.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_agencia.DataSource = gettpross.GetDataAgencia();
                comboBox_agencia.DisplayMember = "Agencia";
                comboBox_agencia.ValueMember = "Id";
                //comboBox_agencia.Text = "";
                #endregion

                comboBox_agencia.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_programa_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_programa.DataSource is null)
            {
                comboBox_programa.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_programa.DataSource = gettpross.GetDataPrograma();
                comboBox_programa.DisplayMember = "Descricao";
                comboBox_programa.ValueMember = "Id";
                //comboBox_agencia.Text = "";
                #endregion
                comboBox_programa.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        public void ProgessChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine($"Download status: {e.ProgressPercentage}%.");
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

                        //String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        dtpcartorio.Value = DateTime.Now;
                        dtpcartorio.Visible = true;

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
                    dtpcartorio.Value = DateTime.Now;
                    dtpcartorio.Visible = true;

                    comboBox_nomecartorio.SelectedIndex = -1;
                }
            }
            

            




        }
        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\Luis\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                    // cria um PictureBox
                    //try
                    //{
                    //    PictureBox pb = new PictureBox();
                    //    Image Imagem = Image.FromFile(arquivo);
                    //    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    //    //para exibir as imagens em tamanho natural 
                    //    //descomente as linhas abaixo e comente as duas seguintes
                    //    //pb.Height = loadedImage.Height;
                    //    //pb.Width = loadedImage.Width;
                    //    pb.Height = 100;
                    //    pb.Width = 100;
                    //    //atribui a imagem ao PictureBox - pb
                    //    pb.Image = Imagem;
                    //    //inclui a imagem no containter flowLayoutPanel
                    //    flowLayoutPanel1.Controls.Add(pb);
                    //}
                    //catch (SecurityException ex)
                    //{
                    //    // O usuário  não possui permissão para ler arquivos
                    //    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                    //                                "Mensagem : " + ex.Message + "\n\n" +
                    //                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    //}
                    //catch (Exception ex)
                    //{
                    //    // Não pode carregar a imagem (problemas de permissão)
                    //    MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(arquivo.LastIndexOf('\\'))
                    //                               + ". Você pode não ter permissão para ler o arquivo , ou " +
                    //                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    //}
                }
            }
        }
        private void btnAnexar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (txtArquivo.Text == "")
            {
                MessageBox.Show("Selecione o Arquivo para Anexar");
                txtArquivo.Select();
                txtArquivo.Focus();
                Cursor = Cursors.Default;
            }
            else if(comboBox_tipoArquivo.Text == "")
            {
                MessageBox.Show("Selecione o Tipo de Arquivo para Anexar");
                comboBox_tipoArquivo.Select();
                comboBox_tipoArquivo.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                curFile = txtArquivo.Text;
                if (File.Exists(curFile))
                {
                    if (Directory.Exists(Local + @"\" + idProcess)) //Pasta
                    {
                        //Salvo referencia
                        #region Salvar no Banco

                        LoginDaoComandos enviar = new LoginDaoComandos();

                        if(txtdescricao.Text == "")
                        {
                            descArquivo = comboBox_tipoArquivo.Text + " do Cliente";
                        }
                        else
                        {
                            descArquivo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtdescricao.Text.ToLower());
                        }
                        
                        String stipo = comboBox_tipoArquivo.Text;
                        numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                        statusArquivo = "Local";
                        ImageData = 0;
                        extension = Path.GetExtension(curFile);
                        //if (txtArquivo.Text.Length > 0)
                        //{
                        //    string FileName = txtArquivo.Text;

                        //fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                        //br = new BinaryReader(fs);
                        //ImageData = br.ReadBytes((int)fs.Length);
                        //br.Close();
                        //fs.Close();
                        int ultimoID = enviar.CriarDocumento( idProcess, stipo, descArquivo, ImageData, extension, statusArquivo);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        #endregion

                        #region Salva arquivo no Caminho do servidor
                        String counts = ultimoID.ToString().PadLeft(2, '0');
                        NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                        if (File.Exists(NewFile))
                        {
                            RenameFile(NewFile, NewFile + ".bkp");
                        }

                        RenameFile(curFile, NewFile);

                        
                        #endregion

                        #region  Load Grid

                        LoginDaoComandos documento = new LoginDaoComandos();

                        dataGridView_Arquivos.AutoGenerateColumns = false;
                        //dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                        dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                        dataGridView_Arquivos.Refresh();
                        dataGridView_Arquivos.ClearSelection();
                        int nRowIndex = dataGridView_Arquivos.Rows.Count - 1;
                        dataGridView_Arquivos.Rows[nRowIndex].Selected = true;
                        dataGridView_Arquivos.Rows[nRowIndex].Cells[0].Selected = true;

                        txtArquivo.Clear();
                        comboBox_tipoArquivo.Text = "";
                        txtdescricao.Clear();
                        Cursor = Cursors.Default;
                        MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        #endregion

                    }
                    else
                    {
                        Directory.CreateDirectory(Local + @"\" + idProcess);

                        #region Salvar no Banco

                        LoginDaoComandos enviar = new LoginDaoComandos();

                        descArquivo = comboBox_tipoArquivo.Text + " do Cliente";
                        String stipo = comboBox_tipoArquivo.Text;
                        numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                        statusArquivo = "Local";
                        ImageData = 0;
                        extension = Path.GetExtension(curFile);
                        //if (txtArquivo.Text.Length > 0)
                        //{
                        //    string FileName = txtArquivo.Text;

                        //fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                        //br = new BinaryReader(fs);
                        //ImageData = br.ReadBytes((int)fs.Length);
                        //br.Close();
                        //fs.Close();
                        int ultimoID = enviar.CriarDocumento(idProcess, stipo, descArquivo, ImageData, extension, statusArquivo);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        #endregion

                        #region Salva arquivo no Caminho do servidor
                        String counts = ultimoID.ToString().PadLeft(2, '0');
                        NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                        if (File.Exists(NewFile))
                        {
                            RenameFile(NewFile, NewFile + ".bkp");
                        }

                        RenameFile(curFile, NewFile);

                        #endregion

                        #region  Load Grid

                        LoginDaoComandos documento = new LoginDaoComandos();

                        dataGridView_Arquivos.AutoGenerateColumns = false;
                        //dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                        dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                        dataGridView_Arquivos.Refresh();
                        txtArquivo.Clear();
                        comboBox_tipoArquivo.Text = "";
                        Cursor = Cursors.Default;
                        MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        #endregion

                    }

                }
            }
        }
        public void EnviarDocumentos()
        {
            LoginDaoComandos enviar = new LoginDaoComandos();

            descArquivo = comboBox_tipoArquivo.Text + " do Cliente";
            String stipo = comboBox_tipoArquivo.Text;
            numArquivo = idProcess + count.ToString().PadLeft(2, '0');
            statusArquivo = "Local";

            if (txtArquivo.Text.Length > 0)
            {
                string FileName = txtArquivo.Text;

                //fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                //br = new BinaryReader(fs);
                //ImageData = br.ReadBytes((int)fs.Length);
                //br.Close();
                //fs.Close();
                enviar.CriarDocumento( idProcess, stipo, descArquivo, ImageData, extension, statusArquivo);
            }
            else
            {
                MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RenameFile(string originalName, string newName)
        {
            File.Move(originalName, newName);
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
                //lbldatacartorio.Text = "";

                switch (comboBox_statuscartorio.SelectedItem.ToString())
                {
                    case "Entregue":
                        String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        //lbldatacartorio.Text = Data;
                        //lbldatacartorio.Visible = true;
                        dtpcartorio.Value = DateTime.Now;
                        dtpcartorio.Visible = true;
                        lblacartorio.Visible = true;
                        break;
                    case "A retirar":
                        dtpcartorio.Value = DateTime.Now;
                        dtpcartorio.Visible = true;
                        lblacartorio.Visible = true;
                        break;
                    case "Aguardando":
                        dtpcartorio.Value = DateTime.Now;
                        dtpcartorio.Visible = true;
                        lblacartorio.Visible = true;
                        break;
                    case "Retirado":
                        dtpcartorio.Value = DateTime.Now;
                        dtpcartorio.Visible = true;
                        lblacartorio.Visible = true;
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
            //dtpsiopi.Value = DateTime.Now;
            //dtpsiopi.Visible = true;
            //lblasiopi.Visible = true;
            //lbldatasiopi.Text = "";
            switch (comboBox_SIOPI.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasiopi.Text = Data;
                    //lbldatasiopi.Visible = true;
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
                case "Enviado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasiopi.Text = Data1;
                    //lbldatasiopi.Visible = true;
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
                case "Não Enviado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasiopi.Text = Data2;
                    //lbldatasiopi.Visible = true;
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
            }
        }
        private void comboBox_SICTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dtpsictd.Value = DateTime.Now;
            //dtpsictd.Visible = true;
            //lblasictd.Visible = true;
            //lbldatasictd.Text = "";
            switch (comboBox_SICTD.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasictd.Text = Data;
                    //lbldatasictd.Visible = true;
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
                case "Enviado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                   // lbldatasictd.Text = Data1;
                   // lbldatasictd.Visible = true;
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
                case "Não Enviado":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasictd.Text = Data2;
                    //lbldatasictd.Visible = true;
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
            }
        }
        private void comboBox_saque_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dtpfgts.Value = DateTime.Now;
            //dtpfgts.Visible = true;
            //lblafgts.Visible = true;
            //lbldatasaquefgts.Text = "";
            switch (comboBox_saque.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasaquefgts.Text = Data;
                    //lbldatasaquefgts.Visible = true;
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Total":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasaquefgts.Text = Data1;
                    //lbldatasaquefgts.Visible = true;
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Parcial":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasaquefgts.Text = Data2;
                    //lbldatasaquefgts.Visible = true;
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Não Usar":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatasaquefgts.Text = Data3;
                    //lbldatasaquefgts.Visible = true;
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
            }
        }
        private void comboBox_PA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //dtppa.Value = DateTime.Now;
            //dtppa.Visible = true;
            //lblapa.Visible = true;
            //lbldatapa.Text = "";
            switch (comboBox_PA.SelectedItem.ToString())
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatapa.Text = Data;
                    //lbldatapa.Visible = true;
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
                    break;
                case "Conforme":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatapa.Text = Data1;
                    //lbldatapa.Visible = true;
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
                    break;
                case "Inconforme":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldatapa.Text = Data2;
                    //lbldatapa.Visible = true;
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
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

            //lbldatacpf.Text = "";


            switch (txtStatusCPF.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    //lbldatacpf.Text = Data ;
                    //lbldatacpf.Visible = true;
                    dtpcpf.Value = DateTime.Now;
                    dtpcpf.Visible = true;
                    lblacpf.Visible = true;
                    break;
                case "Com Restrição":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    //lbldatacpf.Text = Data1;
                    //lbldatacpf.Visible = true;
                    //dtpcpf.Value = DateTime.Now;
                    //dtpcpf.Visible = true;
                    //lblacpf.Visible = true;
                    break;
                case "Divergente RF":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    //lbldatacpf.Text = Data2;
                    //lbldatacpf.Visible = true;
                    dtpcpf.Value = DateTime.Now;
                    dtpcpf.Visible = true;
                    lblacpf.Visible = true;
                    break;
                case "Nada Consta":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    //lbldatacpf.Text = Data3;
                    //lbldatacpf.Visible = true;
                    dtpcpf.Value = DateTime.Now;
                    dtpcpf.Visible = true;
                    lblacpf.Visible = true;
                    break;
                case "Bloqueado em outro CCA":
                    String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lblstatuscpf.Visible = true;
                    //lbldatacpf.Text = Data4;
                    //lbldatacpf.Visible = true;
                    //dtpcpf.Value = DateTime.Now;
                    dtpcpf.Visible = true;
                    lblacpf.Visible = true;
                    break;
            }
        }
        private void txtciweb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //lbldataciweb.Text = "";


            switch (txtciweb.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    //lbldataciweb.Text = Data;
                    //lbldataciweb.Visible = true;
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Ativo":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    //lbldataciweb.Text = Data1;
                    //lbldataciweb.Visible = true;
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Inativo":
                    String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    //lbldataciweb.Text = Data2;
                    //lbldataciweb.Visible = true;
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Nada Consta":
                    String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    //lbldataciweb.Visible = true;
                    //lbldataciweb.Text = Data3;
                    //lbldataciweb.Visible = true;
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
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
            //lbldatair.Text = "";

            switch (txtir.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    dtpir.Value = DateTime.Now;
                    dtpir.Visible = true;
                    lblair.Visible = true;
                    break;
                case "Isento":
                    dtpir.Value = DateTime.Now;
                    dtpir.Visible = true;
                    lblair.Visible = true;
                    break;
                case "Declarado":
                    dtpir.Value = DateTime.Now;
                    dtpir.Visible = true;
                    lblair.Visible = true;
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
            //lbldatafgts.Text = "";

            switch (txtfgts.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpfgtscli.Value = DateTime.Now;
                    dtpfgtscli.Visible = true;
                    lblafgtscli.Visible = true;
                    break;
                case "Já subsidiado":
                    dtpfgtscli.Value = DateTime.Now;
                    dtpfgtscli.Visible = true;
                    lblafgtscli.Visible = true;
                    break;
                case "Não subsidiado":
                    dtpfgtscli.Value = DateTime.Now;
                    dtpfgtscli.Visible = true;
                    lblafgtscli.Visible = true;
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
            //lbldatacadmut.Text = "";

            switch (txtciweb.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    dtpcadmut.Value = DateTime.Now;
                    dtpcadmut.Visible = true;
                    lblacadmut.Visible = true;
                    break;
                case "Ativo":
                    dtpcadmut.Value = DateTime.Now;
                    dtpcadmut.Visible = true;
                    lblacadmut.Visible = true;
                    break;
                case "Inativo":
                    dtpcadmut.Value = DateTime.Now;
                    dtpcadmut.Visible = true;
                    lblacadmut.Visible = true;
                    break;
                case "Nada Consta":
                    dtpcadmut.Value = DateTime.Now;
                    dtpcadmut.Visible = true;
                    lblacadmut.Visible = true;
                    break;

            }
        }
        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}
