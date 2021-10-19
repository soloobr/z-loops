using br.corp.bonus630.FullText;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Processos : Form
    {

        bool Next;
        string valor, svalorimovel, svalorfinanciado, idCartorio;
        string curFile, NewFile, extension, Local, idArquivo, numArquivo, descArquivo, dataAruivo, statusArquivo, idcombotipodoc;
        string idagencia, idprograma, idcorretora, idcorretor, idempreendimentos, caminho;
        string StatusCPF, datacpf, ciweb, dataciweb, cadmut, datacadmut, ir, datair, fgts, datafgts, obs;
        int count;
        FileStream fs;
        BinaryReader br;
        byte ImageData;
        ToFullText tft;
        int ultimoID;
        DateTime datecpf, dateciweb, datecadmut, dateir, datefgts, dateanalise, dateeng, datesiopi, datesictd, datesaquefgts, datepa, datecartorio;
        string idresponsavel, nomeresponsavel, nomeuserloged;

        //string idProcess, datacpf, dataciweb, datacadmut, datair, datafgts, dataanalise, dataeng, datastatus, statusprocesso, datasiopi, datasictd, datasaquefgts, datapa, datacartorio;
        string idProcess, dataanalise, dataeng, datastatus, statusprocesso, datasiopi, datasictd, datasaquefgts, datapa, datacartorio;


        public Form_Dados_Processos()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            tft = new ToFullText();
        }
        public void setLabel(string statuslbl)
        {
            lblstatus.Text = statuslbl;
        }
        public void setIdProcess(string idprocesso)
        {
            idProcess = idprocesso.PadLeft(4, '0');
        }
        public void setUserLoged(string idresp, string nomefunc)
        {
            if (idresp != null)
            {
                idresponsavel = idresp;
            }
            if (nomefunc != null)
            {
                nomeuserloged = nomefunc;
            }
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
            nomeresponsavel = process.Nome_responsavel;
            lbldata.Text = asString;

            svalorimovel = process.Valor_imovel;
            valorimovel.Text = process.Valor_imovel;
            valorimovel.Select(valorimovel.Text.Length, 0);

            valorfinanciado.Text = process.ValorFinanciado_imovel;
            valorfinanciado.Select(valorfinanciado.Text.Length, 0);

            txtobservacao.Text = process.Obs_processo;
            #endregion

            #region Cliente
            ComboBoxClient.Text = process.Nome_cliente;
            txtcpf.Text = process.CPF_cliente;
            txtrg.Text = process.RG_cliente;
            txtnasc.Text = process.Nascimento_cliente;
            txtemail.Text = process.Email_cliente;
            txttelefone.Text = process.Telefone_cliente;
            txtcelular.Text = process.Celular_cliente;
            if (String.IsNullOrEmpty(process.RendaBruta_cliente) || process.RendaBruta_cliente == "0")
            {
                txtrenda.Text = process.Renda_cliente;

            }
            else
            {
                txtrenda.Text = process.RendaBruta_cliente;
                lblrentabruta.Text = lblrentabruta.Text + " + renda Cônjuges";
            }

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
            //txtrenda1.Text = string.Format("{0:C}", Convert.ToDouble(valor));
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

            if (process.CNPJ_vendedor != "0")
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
            //txtrenda.Text = process.Renda_vendedor;
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
                if (process.H_DataStatusEng != "01/01/0001 00:00:00")
                {
                    lblaeng.Visible = true;
                    dtpeng.Visible = true;
                    dtpeng.Value = DateTime.Parse(process.H_DataStatusEng);
                }
            }
            if (process.H_DataSIOP != "")
            {
                if (process.H_DataSIOP != "01/01/0001 00:00:00")
                {
                    lblasiopi.Visible = true;
                    dtpsiopi.Visible = true;
                    dtpsiopi.Value = DateTime.Parse(process.H_DataSIOP);
                }
            }
            if (process.H_DataSICTD != "")
            {
                if (process.H_DataSICTD != "01/01/0001 00:00:00")
                {
                    lblasictd.Visible = true;
                    dtpsictd.Visible = true;
                    dtpsictd.Value = DateTime.Parse(process.H_DataSICTD);
                }
            }
            if (process.H_DataSaqueFGTS != "")
            {
                if (process.H_DataSaqueFGTS != "01/01/0001 00:00:00")
                {
                    lblafgts.Visible = true;
                    dtpfgts.Visible = true;
                    dtpfgts.Value = DateTime.Parse(process.H_DataSaqueFGTS);
                }
            }
            if (process.H_DataPA != "")
            {
                if (process.H_DataPA != "01/01/0001 00:00:00")
                {
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
            if (Next)
            {
                switch (process.StatusAnalise_cliente)
                {
                    case "":
                        lblstatus.Text = "Realizar Analise";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Realizar Analise";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Aprovado":
                        lblstatus.Text = "Analise Aprovada";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Em analise":
                        lblstatus.Text = "Em Analise";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Reprovado":
                        lblstatus.Text = "Analise Reprovada";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Comando":
                        lblstatus.Text = "Comando";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Desistiu":
                        lblstatus.Text = "Desistensia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Bloqueado em ourto CCA":
                        lblstatus.Text = "Bloqueado em ourto CCA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Condicionado":
                        lblstatus.Text = "Condicionado";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (process.StatusEng_cliente)
                {
                    case "":
                        lblstatus.Text = "Iniciar Engenharia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Iniciar Engenharia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Aguardando Pagamento":
                        lblstatus.Text = "Aguardando Pagamento";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Aprovado abaixo":
                        lblstatus.Text = "Aprovado abaixo";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Aprovado Normal":
                        lblstatus.Text = "Aprovado Normal";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Contestação":
                        lblstatus.Text = "Engenharia com Contestação";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Solicitado":
                        lblstatus.Text = "Solicitado";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (process.SIOPI_cliente)
                {
                    case "":
                        lblstatus.Text = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Enviado":
                        lblstatus.Text = "Enviado SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Não Enviado":
                        lblstatus.Text = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (process.SICTD_cliente)
                {
                    case "":
                        lblstatus.Text = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Enviado":
                        lblstatus.Text = "Enviado SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Não Enviado":
                        lblstatus.Text = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (process.SaqueFGTS_cliente)
                {
                    case "":
                        lblstatus.Text = "Usar FGTS?";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Usar FGTS?";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Total":
                        lblstatus.Text = "FGTS Total";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Parcial":
                        lblstatus.Text = "FGTS Parcial";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Não Usar":
                        lblstatus.Text = "Não Usar FGTS";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                }
            }
            if (Next)
            {
                switch (process.StatusPA_cliente)
                {
                    case "":
                        lblstatus.Text = "Consultar PA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        lblstatus.Text = "Consultar PA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Conforme":
                        lblstatus.Text = "PA Conforme";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Inconforme":
                        lblstatus.Text = "PA Inconforme";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }

            if (Next)
            {
                lblstatus.Text = "Concluído";
                lblstatus.ForeColor = Color.Blue;
            }



            #endregion

            Cursor = Cursors.Default;

            if (process.Nome_responsavel == nomeuserloged)
            {
                HabilitarEdicao();
            }

            

        }
        public event Action ProcessoSalvo;

        private void Get_Status()
        {
            #region Checkstatus

            Next = true;

            if (Next)
            {
                switch (txtStatusCPF.Text)
                {
                    case "":
                        statusprocesso = "Consultar CPF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar CPF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Com Restrição":
                        statusprocesso = "CPF Com Restrição";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Divergente RF":
                        statusprocesso = "CPF Divergente RF";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Bloqueado em outro CCA":
                        statusprocesso = "CPF Bloqueado em outro CCA";
                        lblstatus.ForeColor = Color.Red;
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
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar Ciweb";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Ativo":
                        statusprocesso = "Ciweb Ativo";
                        Next = true;
                        break;
                    case "Inativo":
                        statusprocesso = "Ciweb Inativo";
                        lblstatus.ForeColor = Color.Red;
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
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar Cadmut";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Ativo":
                        statusprocesso = "Cadmut Ativo";
                        Next = true;
                        break;
                    case "Inativo":
                        statusprocesso = "Cadmut Inativo";
                        lblstatus.ForeColor = Color.Red;
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
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar IR";
                        lblstatus.ForeColor = Color.Red;
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
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar FGTS";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Já subsidiado":
                        statusprocesso = "FGTS Já subsidiado";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não subsidiado":
                        statusprocesso = "FGTS Não subsidiado";
                        Next = true;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_analise.Text)
                {
                    case "":
                        statusprocesso = "Realizar Analise";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Realizar Analise";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Aprovado":
                        statusprocesso = "Analise Aprovada";
                        Next = true;
                        break;
                    case "Em analise":
                        statusprocesso = "Em Analise";
                        lblstatus.ForeColor = Color.Yellow;
                        Next = false;
                        break;
                    case "Reprovado":
                        statusprocesso = "Analise Reprovada";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Comando":
                        statusprocesso = "Comando";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Desistiu":
                        statusprocesso = "Desistensia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Bloqueado em ourto CCA":
                        statusprocesso = "Bloqueado em ourto CCA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Condicionado":
                        statusprocesso = "Condicionado";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_statuseng.Text)
                {
                    case "":
                        statusprocesso = "Iniciar Engenharia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Iniciar Engenharia";
                        Next = false;
                        break;
                    case "Aguardando Pagamento":
                        statusprocesso = "Aguardando Pagamento";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Aprovado abaixo":
                        statusprocesso = "Engenharia Aprovado abaixo";
                        Next = true;
                        break;
                    case "Aprovado Normal":
                        lblstatus.Text = "Engenharia Aprovado Normal";
                        lblstatus.ForeColor = Color.Red;
                        Next = true;
                        break;
                    case "Contestação":
                        statusprocesso = "Engenharia com Contestação";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Solicitado":
                        statusprocesso = "Solicitado Engenharia";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_SIOPI.Text)
                {
                    case "":
                        statusprocesso = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Enviado":
                        statusprocesso = "Enviado SIOPI";
                        Next = true;
                        break;
                    case "Não Enviado":
                        statusprocesso = "Enviar SIOPI";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_SICTD.Text)
                {
                    case "":
                        statusprocesso = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Enviado":
                        statusprocesso = "Enviado SICTD";
                        Next = true;
                        break;
                    case "Não Enviado":
                        statusprocesso = "Enviar SICTD";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_saque.Text)
                {
                    case "":
                        statusprocesso = "Usar FGTS?";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Usar FGTS?";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Total":
                        statusprocesso = "FGTS Total";
                        Next = true;
                        break;
                    case "Parcial":
                        statusprocesso = "FGTS Parcial";
                        Next = true;
                        break;
                    case "Não Usar":
                        statusprocesso = "Não Usar FGTS";
                        Next = true;
                        break;
                }
            }
            if (Next)
            {
                switch (comboBox_PA.Text)
                {
                    case "":
                        statusprocesso = "Consultar PA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Não Consultado":
                        statusprocesso = "Consultar PA";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                    case "Conforme":
                        statusprocesso = "PA Conforme";
                        lblstatus.ForeColor = Color.Blue;
                        Next = true;
                        break;
                    case "Inconforme":
                        statusprocesso = "PA Inconforme";
                        lblstatus.ForeColor = Color.Red;
                        Next = false;
                        break;
                }
            }
            if(Next)
            {
                statusprocesso = "Concluído";
                lblstatus.ForeColor = Color.Blue;
            }

            #endregion

            }

            private void btncloseconf_Click(object sender, EventArgs e)
        {
            if (ProcessoSalvo != null)
                ProcessoSalvo.Invoke();

            Close();
        }

        private void btnsalvardoc_Click(object sender, EventArgs e)
        {
           

        }

        private void btncancelardoc_Click(object sender, EventArgs e)
        {
            txtStatusCPF.Text = StatusCPF;
            dtpcpf.Text = datacpf;
            txtciweb.Text = ciweb;
            dtpciweb.Text = dataciweb;
            txtcadmut.Text = cadmut;
            dtpcadmut.Text = datacadmut;
            txtir.Text = ir;
            dtpir.Text = datair;
            txtfgts.Text = fgts;
            dtpfgts.Text = datafgts;
            txtobservacao.Text = obs;

            //btn_editar.Visible = true;
            //splitter1.Visible = false;
            //splitter2.Visible = false;
            //btncancelardoc.Visible = false;
            //btnsalvardoc.Visible = false;
            //splitter3.Visible = true;
            //btn_excluir.Visible = true;

            DesabilitarEdicao();
            //Close();
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
            switch (comboBox_analise.SelectedItem.ToString())
            {
                case "Não Consultado":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Aprovado":
                    String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Condicionado":
                    //String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Em analise":
                    //String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Reprovado":
                    //String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Comando":
                    //String Data5 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Desistiu":
                    //String Data6 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
                case "Bloqueado em ourto CCA":
                    //String Data7 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    break;
            }

        }

        private void comboBox_statuseng_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox_statuseng.SelectedItem.ToString())
            {
                case "Não Consultado":
                    //String Data0 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
                    //String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Aprovado Normal":
                    //String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Contestação":
                    //String Data3 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpeng.Value = DateTime.Now;
                    dtpeng.Visible = true;
                    lblaeng.Visible = true;
                    break;
                case "Solicitado":
                    //String Data4 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_open_in_popup_16.Width;
                var h = Properties.Resources.icons8_open_in_popup_16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_open_in_popup_16, new Rectangle(x, y, w, h));
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

                String iddoc = row.Cells[0].Value.ToString().PadLeft(2, '0');
                String extension = row.Cells[8].Value.ToString();
                String pasta = idProcess;

                DialogResult dialogResult = MessageBox.Show("Confima a exclusão do arquivo " + idProcess + iddoc + extension, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                        MessageBox.Show("O arquivo " + Excluir + " não foi encontrado! \n Contate o Suporte Técnico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                switch (row.Cells[8].Value.ToString())
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
                        sfd.Filter = "Word Documents|*.doc";
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
                sfd.FileName = idProcess + row.Cells[0].Value.ToString().PadLeft(2, '0') + row.Cells[8].Value.ToString(); //"Mac_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
                sfd.RestoreDirectory = true;

                String Filedownload = Local + @"\" + idProcess + @"\" + sfd.FileName;
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
                    MessageBox.Show("Arquivo não encontrado \n Contate o Suporte Técnico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.ColumnIndex == dataGridView_Arquivos.Columns["Ver"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Arquivos.Rows[e.RowIndex];


                //SaveFileDialog sfd = new SaveFileDialog();

                #region Filter
                //switch (row.Cells[8].Value.ToString())
                //{
                //    case ".pdf":
                //        sfd.Filter = "PDF document (*.pdf)|*.pdf";
                //        break;
                //    case ".jpeg":
                //        sfd.Filter = "JPEG Image(.jpeg)| *.jpeg";
                //        break;
                //    case ".jpg":
                //        sfd.Filter = "JPG Image(.jpg)| *.jpg";
                //        break;
                //    case ".png":
                //        sfd.Filter = "Png Image(.png)| *.png";
                //        break;
                //    case ".doc":
                //        sfd.Filter = "Word Documents|*.doc";
                //        break;
                //    case ".docx":
                //        sfd.Filter = "Word Documents|*.docx";
                //        break;
                //    case ".xlsx":
                //        sfd.Filter = "Excel Worksheets|*.xlsx";
                //        break;
                //    case ".xls":
                //        sfd.Filter = "Excel Worksheets|*.xls";
                //        break;
                //    default:
                //        sfd.Filter = "All files (*.*)|*.*";
                //        break;
                //}
                #endregion
                string caminhoRaiz = AppDomain.CurrentDomain.BaseDirectory;
                //sfd.Filter = "PDF document (*.pdf)|*.pdf| All files (*.*)|*.*";
                //string sfdname = saveFileDialog1.FileName;
                //sfd.Title = "Salvar Arquivo";
                String FileName = idProcess + row.Cells[0].Value.ToString().PadLeft(2, '0') + row.Cells[8].Value.ToString();
                //sfd.RestoreDirectory = true;

                String Filedownload = Local + @"\" + idProcess + @"\" + FileName;
                //MessageBox.Show(Filedownload);

                if (File.Exists(Filedownload))
                {
                    //if (sfd.ShowDialog() == DialogResult.OK)
                    //{

                    // Download(Filedownload, caminhoRaiz);
                    //MessageBox.Show(caminhoRaiz + Filedownload, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(Filedownload);
                    //}


                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado \n Contate o Suporte Técnico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox_tipoProcesso_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_tipoProcesso.DataSource is null)
            {
                comboBox_tipoProcesso.IntegralHeight = false;
                LoginDaoComandos getcombo = new LoginDaoComandos();
                #region Popular combobox
                comboBox_tipoProcesso.DataSource = getcombo.GetDataTipoProc();
                comboBox_tipoProcesso.DisplayMember = "Descricao";
                comboBox_tipoProcesso.ValueMember = "id";
                //comboBox_agencia.Text = "";

                #endregion

                comboBox_tipoProcesso.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnalterresp_Click(object sender, EventArgs e)
        {
            if (comboBox_resp.Visible == true)
            {
                comboBox_resp.Visible = false;
            }else if (comboBox_resp.Visible == false)
            {
                comboBox_resp.Visible = true;
            }
        }

        private void comboBox_resp_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_resp.DataSource is null)
            {
                comboBox_resp.IntegralHeight = false;
                LoginDaoComandos getcombo = new LoginDaoComandos();
                #region Popular combobox
                comboBox_resp.DataSource = getcombo.GetDataRespProc();
                comboBox_resp.DisplayMember = "Nome";
                comboBox_resp.ValueMember = "id";
                //comboBox_agencia.Text = "";

                #endregion

                comboBox_resp.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void comboBox_resp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Transferir a resposabilidade deste Prcesso para o Colaborador(a): \n "+ comboBox_resp.Text + " ? ", "Alterar Responsável", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                idresponsavel = comboBox_resp.SelectedValue.ToString();
                LoginDaoComandos updateprocesso = new LoginDaoComandos();

                updateprocesso.UpdateRespProcesso(idProcess, idresponsavel);

                if (updateprocesso.mensagem == "Responsável Alterado com Sucesso")
                {
                    
                    //HabilitarEdicao();
                    lblfuncresponsavel.Text = comboBox_resp.Text;
                    comboBox_resp.Visible = false;
                    comboBox_resp.Text = "";
                    MessageBox.Show(updateprocesso.mensagem);

                }
                else
                {
                    MessageBox.Show(updateprocesso.mensagem);
                    comboBox_resp.Visible = false;
                }

            }
            else
            {
                comboBox_resp.Visible = false;
            }
        }

        private void btnsalvardoc_Click_1(object sender, EventArgs e)
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
            if (dtpeng.Text != "")
            {
                dateeng = DateTime.Parse(dtpeng.Text);
            }
            else
            {
                dateeng = DateTime.Parse("01/01/0001 00:00:00");
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

            updateprocesso.UpdateProcesso(idProcess, cpf, datecpf, ciweb, dateciweb, cadmut, datecadmut, ir, dateir, fgts, datefgts, analise, dateanalise, eng, dateeng, siopi, datesiopi, sictd, datesictd, saquefgts, datesaquefgts, pa, datepa, idagencia, idprograma, Valorimov, Valorfinan, combocorretora, combocorretores, combocoempreendimentos, idCartorio, cartorio, datecartorio, statusprocesso, txtobservacao.Text);
            MessageBox.Show(updateprocesso.mensagem, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (ProcessoSalvo != null)
                ProcessoSalvo.Invoke();

            //Close();


            DesabilitarEdicao();
        }

        private void comboBox_tipoArquivo_MouseClick(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox_tipoProcesso.Text))
            {
                MessageBox.Show("Selecione o tipo de Processo!", "Informção Necessaria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_tipoProcesso.Select();
                //comboBox_tipoProcesso.DroppedDown = true;
                return;

            }
            //Cursor = Cursors.WaitCursor;
            //if (comboBox_tipoArquivo.DataSource is null)
            //{
            //comboBox_tipoArquivo.IntegralHeight = false;
            //LoginDaoComandos getcombo = new LoginDaoComandos();
            //#region Popular combobox
            //comboBox_tipoArquivo.DataSource = getcombo.GetDataTipoDoc(idcombotipodoc);
            //comboBox_tipoArquivo.DisplayMember = "Descricao";
            //comboBox_tipoArquivo.ValueMember = "id";
            ////comboBox_agencia.Text = "";
            //#endregion

            //comboBox_tipoArquivo.DroppedDown = true;
            //Cursor = Cursors.Default;
            //}
            //else
            //{
            //    Cursor = Cursors.Default;
            //}
        }
        private void HabilitarEdicao()
        {
            GetValueEdit();
            #region Cliente
            //ComboBoxClient.ReadOnly = false;
            //txtcpf.ReadOnly = false;
            //txtrg.ReadOnly = false;
            //txtnasc.ReadOnly = false;
            //txtemail.ReadOnly = false;
            //txttelefone.ReadOnly = false;
            //txtcelular.ReadOnly = false;
            //txtrenda.ReadOnly = false;
            txtStatusCPF.Enabled = true;
            txtciweb.Enabled = true;
            txtcadmut.Enabled = true;
            txtir.Enabled = true;
            txtfgts.Enabled = true;
            dtpcpf.Enabled = true;
            dtpciweb.Enabled = true;
            dtpcadmut.Enabled = true;
            dtpir.Enabled = true;
            dtpfgtscli.Enabled = true;


            txtagenciacliente.ReadOnly = false;
            txtcontacliente.ReadOnly = false;
            txtobservacao.ReadOnly = false;
            #endregion

            #region Vendedor
            textnomevendedor.ReadOnly = false;
            textcnpjcpf.ReadOnly = false;
            textagenciavendedor.ReadOnly = false;
            txtcontavendedor.ReadOnly = false;
            textemailvendedor.ReadOnly = false;
            texttelefonevendedor.ReadOnly = false;
            textcelularvendedor.ReadOnly = false;
            #endregion

            #region Processo
            comboBox_analise.Enabled = true;
            dtpanalise.Enabled = true;
            comboBox_statuseng.Enabled = true;
            dtpeng.Enabled = true;
            comboBox_SIOPI.Enabled = true;
            dtpsiopi.Enabled = true;
            comboBox_SICTD.Enabled = true;
            dtpsictd.Enabled = true;
            comboBox_saque.Enabled = true;
            dtpfgts.Enabled = true;
            comboBox_PA.Enabled = true;
            dtppa.Enabled = true;
            comboBox_agencia.Enabled = true;
            comboBox_programa.Enabled = true;
            valorimovel.Enabled = true;
            valorfinanciado.Enabled = true;
            comboBox_corretora.Enabled = true;
            comboBox_corretor.Enabled = true;
            comboBox_empreendimentos.Enabled = true;
            comboBox_nomecartorio.Enabled = true;
            btnenviar.Enabled = true;
            comboBox_statuscartorio.Enabled = true;
            dtpcartorio.Enabled = true;
            txtArquivo.Enabled = true;
            btnSelecionarArquivos.Enabled = true;
            comboBox_tipoProcesso.Enabled = true;
            comboBox_tipoArquivo.Enabled = true;
            btnAnexar.Enabled = true;
            txtdescricao.Enabled = true;
            dataGridView_Arquivos.Enabled = true;

            #endregion

            #region Botões
            btn_editar.Visible = false;
            splitter2.Visible = true;
            btncancelardoc.Visible = true;
            splitter1.Visible = false;
            btnsalvardoc.Visible = true;
            //splitter3.Visible = false;
            // btn_excluir.Visible = false;
            #endregion

        }

        private void txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btncancelardoc_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (nomeresponsavel == nomeuserloged)
            {
                HabilitarEdicao();
            }
            else
            {
                
                if (MessageBox.Show("Você não e o Responsável deste Processo! \n  Tomar a resposabilidade deste Prcesso?", "Alterar Responsável", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoginDaoComandos updateprocesso = new LoginDaoComandos();

                    updateprocesso.UpdateRespProcesso(idProcess, idresponsavel);

                    if (updateprocesso.mensagem == "Responsável Alterado com Sucesso")
                    {
                        
                        HabilitarEdicao();
                        lblfuncresponsavel.Text = nomeuserloged;
                        MessageBox.Show(updateprocesso.mensagem);
                        
                    }
                    else
                    {
                        MessageBox.Show(updateprocesso.mensagem);
                    }
                    
                }
                else
                {

                }
            }



            //HabilitarEdicao();
        }
        private void GetValueEdit()
        {
            StatusCPF = txtStatusCPF.Text;
            datacpf = dtpcpf.Text;
            ciweb = txtciweb.Text;
            dataciweb = dtpciweb.Text;
            cadmut = txtcadmut.Text;
            datacadmut = dtpcadmut.Text;
            ir = txtir.Text;
            datair = dtpir.Text;
            fgts = txtfgts.Text;
            datafgts = dtpfgts.Text;
            obs = txtobservacao.Text;
        }
        private void DesabilitarEdicao()
        {
            #region Cliente
            ComboBoxClient.ReadOnly = true;
            txtcpf.ReadOnly = true;
            txtrg.ReadOnly = true;
            txtnasc.ReadOnly = true;
            txtemail.ReadOnly = true;
            txttelefone.ReadOnly = true;
            txtcelular.ReadOnly = true;
            txtrenda.ReadOnly = true;
            txtStatusCPF.Enabled = false;
            txtciweb.Enabled = false;
            txtcadmut.Enabled = false;
            txtir.Enabled = false;
            txtfgts.Enabled = false;
            dtpcpf.Enabled = false;
            dtpciweb.Enabled = false;
            dtpcadmut.Enabled = false;
            dtpir.Enabled = false;
            dtpfgtscli.Enabled = false;


            txtagenciacliente.ReadOnly = true;
            txtcontacliente.ReadOnly = true;
            txtobservacao.ReadOnly = true;
            #endregion

            #region Vendedor
            textnomevendedor.ReadOnly = true;
            textcnpjcpf.ReadOnly = true;
            textagenciavendedor.ReadOnly = true;
            txtcontavendedor.ReadOnly = true;
            textemailvendedor.ReadOnly = true;
            texttelefonevendedor.ReadOnly = true;
            textcelularvendedor.ReadOnly = true;
            #endregion

            #region Processo
            comboBox_analise.Enabled = false;
            dtpanalise.Enabled = false;
            comboBox_statuseng.Enabled = false;
            dtpeng.Enabled = false;
            comboBox_SIOPI.Enabled = false;
            dtpsiopi.Enabled = false;
            comboBox_SICTD.Enabled = false;
            dtpsictd.Enabled = false;
            comboBox_saque.Enabled = false;
            dtpfgts.Enabled = false;
            comboBox_PA.Enabled = false;
            dtppa.Enabled = false;
            comboBox_agencia.Enabled = false;
            comboBox_programa.Enabled = false;
            valorimovel.Enabled = false;
            valorfinanciado.Enabled = false;
            comboBox_corretora.Enabled = false;
            comboBox_corretor.Enabled = false;
            comboBox_empreendimentos.Enabled = false;
            comboBox_nomecartorio.Enabled = false;
            btnenviar.Enabled = false;
            comboBox_statuscartorio.Enabled = false;
            dtpcartorio.Enabled = false;
            txtArquivo.Enabled = false;
            btnSelecionarArquivos.Enabled = false;
            comboBox_tipoProcesso.Enabled = false;
            comboBox_tipoArquivo.Enabled = false;
            btnAnexar.Enabled = false;
            txtdescricao.Enabled = false;
            dataGridView_Arquivos.Enabled = false;

            #endregion

            #region Botões
            btn_editar.Visible = true;
            splitter1.Visible = false;
            btncancelardoc.Visible = false;
            splitter2.Visible = false;
            btnsalvardoc.Visible = false;
            #endregion
        }


        private void comboBox_tipoProcesso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            #region Popular combobox
            idcombotipodoc = comboBox_tipoProcesso.SelectedValue.ToString();

            comboBox_tipoArquivo.DataSource = null;
            //comboBox_tipoArquivo.Items.Clear();
            comboBox_tipoArquivo.IntegralHeight = false;
            LoginDaoComandos getcombo = new LoginDaoComandos();

            comboBox_tipoArquivo.DataSource = getcombo.GetDataTipoDoc(idcombotipodoc);
            comboBox_tipoArquivo.DisplayMember = "Descricao";
            comboBox_tipoArquivo.ValueMember = "id";
            comboBox_tipoArquivo.SelectedIndex = -1;
            //comboBox_agencia.Text = "";
            #endregion
            Cursor = Cursors.Default;
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
            if (comboBox_nomecartorio.Text == "")
            {
                MessageBox.Show("Favor Selecione o cartorio");
                comboBox_nomecartorio.DroppedDown = true;
            }
            else
            {
                if (lblnomecartorio.Text != comboBox_nomecartorio.Text && lblnomecartorio.Text != "Selecione o Cartório" && lblnomecartorio.Text != "")
                {
                    if (MessageBox.Show("Já entregue ao Cartório: " + "\n" + lblnomecartorio.Text + "\n" + " Deseja alterar o cartório?", "Systema Informa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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

            if (String.IsNullOrEmpty(txtArquivo.Text))
            {
                MessageBox.Show("Selecione o Arquivo para Anexar");
                txtArquivo.Select();
                txtArquivo.Focus();
                Cursor = Cursors.Default;
                return;
            }
            else if (String.IsNullOrEmpty(comboBox_tipoProcesso.Text))
            {
                MessageBox.Show("Selecione o Tipo de Processo para Anexar");
                comboBox_tipoProcesso.Select();
                Cursor = Cursors.Default;
                return;
            }
            else if (String.IsNullOrEmpty(comboBox_tipoArquivo.Text))
            {
                MessageBox.Show("Selecione o Tipo de Documento para Anexar");
                comboBox_tipoArquivo.Select();
                comboBox_tipoArquivo.DroppedDown = true;
                Cursor = Cursors.Default;
                return;
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

                        //if(txtdescricao.Text == "")
                        //{
                        //    descArquivo = comboBox_tipoArquivo.Text + " do Cliente";
                        //}
                        //else
                        //{
                        //    descArquivo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtdescricao.Text.ToLower());
                        //}
                        descArquivo = comboBox_tipoArquivo.Text;
                        caminho = Local + @"\" + idProcess + @"\";

                        String stipo = comboBox_tipoProcesso.Text;
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
                        int ultimoID = enviar.CriarDocumento(idProcess, stipo, descArquivo, ImageData, extension, caminho, statusArquivo);
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
                        comboBox_tipoArquivo.DataSource = null;
                        comboBox_tipoProcesso.SelectedItem = -1;
                        Cursor = Cursors.Default;
                        MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        #endregion

                    }
                    else
                    {
                        Directory.CreateDirectory(Local + @"\" + idProcess);

                        //Salvo referencia
                        #region Salvar no Banco

                        LoginDaoComandos enviar = new LoginDaoComandos();

                        //if(txtdescricao.Text == "")
                        //{
                        //    descArquivo = comboBox_tipoArquivo.Text + " do Cliente";
                        //}
                        //else
                        //{
                        //    descArquivo = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtdescricao.Text.ToLower());
                        //}
                        descArquivo = comboBox_tipoArquivo.Text;
                        caminho = Local + @"\" + idProcess + @"\";

                        String stipo = comboBox_tipoProcesso.Text;
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
                        int ultimoID = enviar.CriarDocumento(idProcess, stipo, descArquivo, ImageData, extension, caminho, statusArquivo);
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
                        comboBox_tipoArquivo.DataSource = null;
                        comboBox_tipoArquivo.SelectedItem = -1;
                        Cursor = Cursors.Default;
                        MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        #endregion

                    }

                }
            }
            Cursor = Cursors.Default;
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
                // enviar.CriarDocumento( idProcess, stipo, descArquivo, ImageData, extension,caminho, statusArquivo);
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
            if (lblnomecartorio.Text == "Selecione o Cartório")
            {
                comboBox_statuscartorio.SelectedIndex = -1;
                MessageBox.Show("Favor Selecione o cartorio");
                comboBox_nomecartorio.DroppedDown = true;
            }
            else if (lblnomecartorio.Text == "")
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
