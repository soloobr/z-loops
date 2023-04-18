using br.corp.bonus630.FullText;
using LMFinanciamentos.DAL;
using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Processos : Form
    {

        int agenciaselecionado;
        bool Next, bPopCombo, cadastrar, h_cartorio, h_nomecartorio, h_datacartorio, sucess;
        string valor, svalorimovel, svalorfinanciado, idCartorio;
        string curFile, NewFile, extension, Local, idArquivo, numArquivo, descArquivo, dataAruivo, statusArquivo, idcombotipodoc;
        string idVendedor, idVendedorold, idagencia, idprograma, idconstrutora, idcorretor, idempreendimentos, caminho;
        string StatusCPF, datacpf, ciweb, dataciweb, cadmut, datacadmut, ir, datair, fgts, datafgtscli, datafgts, obs, agencia;
        string  combag, combprograma, vlimovel, vlfinan, combconstrutora,combcorretor, combempreendimento;
        string combanalise, combstatuseng, combsiopi, combsictd, combsaque, combpa;
        string combdataanalise, combdatavalidadeanalise, respaprov, combdatastatuseng, combdatasiopi, combdatasictd, combdatasaque, combdatapa;
        string lastselectedprog, lastselectedag, lastselectedconstru, lastselectedcorretor, lastselectedempreendimentos;
        string lastselectedstatuscpf, lastselectedciweb, lastselectedcadmut, lastselectedir, lastselectedfgts;
        string descricao_carftorio, statuscartorio, h_datastatuscartorio;
        string lastselectedcartorio, listmessage;
        string nomeclienteDB, cpfclienteDB, rgclienteDB, nascclienteDB, emailclienteDB, telefoneclienteDB, celularclienteDB, rendaclienteDB, agenciaclienteDB, contaclienteDB;
        string cpfsave, ciwebsave, cadmutsave, irsave, fgtssave, observacaosave, analisesave, respaprovsave, engsave, siopisave, sictdsave, saquefgtssave, pasave,agenciasave,programasave, vlsave, vlfsave, statuscartoriosave, construtorasave, corretorsave,empreendimentosave, nomecartoriosave, statusacartoriosave;
        DateTime? datecpf, dateciweb, datecadmut, dateir, datefgts, dateanalise, datevalidadeanalise, dateeng, datesiopi, datesictd, datesaquefgts, datepa, datecartorio;
        int count;
        FileStream fs;
        BinaryReader br;
        byte ImageData;
        ToFullText tft;
        int ultimoID;
        bool checkeds = false;
        int countt = 0;

        string idresponsavel, nomeresponsavel, nomeuserloged, nomevendedor;

        private void dataGridView_Arquivos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            

           
        }

        private void dataGridView_Arquivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpanalise_CloseUp(object sender, EventArgs e)
        {

            if (dtpanalise.Value.ToString() == combdataanalise)
            {
                
                SetComboValidadeAnalise(combanalise, combdatavalidadeanalise);
                
            }
            else
            {
                switch (comboBox_analise.SelectedItem.ToString())
                {
                    case "Bloqueado em ourto CCA":
                        DateTime hojeAB = dtpanalise.Value;
                        dtpvalidadeanalise.Value = hojeAB.AddDays(180);
                        dtpvalidadeanalise.Visible = true;
                        lblavalidadeanalise.Visible = true;
                        break;
                    case "Aprovado":
                        DateTime hojeA = dtpanalise.Value;
                        dtpvalidadeanalise.Value = hojeA.AddDays(180);
                        dtpvalidadeanalise.Visible = true;
                        lblavalidadeanalise.Visible = true;
                        break;
                }
            }
        }

        private void dtpanalise_ValueChanged(object sender, EventArgs e)
        {

        }

        string arquivoselected;
        public List<string> listarquivo;
        //string idProcess, datacpf, dataciweb, datacadmut, datair, datafgts, dataanalise, dataeng, datastatus, statusprocesso, datasiopi, datasictd, datasaquefgts, datapa, datacartorio;
        string idProcess, dataanalise, dataeng, datastatus, statusprocesso, datasiopi, datasictd, datasaquefgts, datapa, datacartorio;

        private void dataGridViewHistoricoCartorio_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewHistoricoCartorio.ClearSelection();
        }

        private Form_Cadastro_Agencias newForm { get; set; }
        private Form_Cadastro_Construtora newFormConstrutora { get; set; }

        private Form_Cadastro_Corretor newFormCorretor { get; set; }

        private Form_Cadastro_Empreendimentos newFormEmpreendimentos { get; set; }

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
        public void setTABcontrol(int tab)
        {
            tabControl.SelectedIndex = tab;
        }
        public event Action ClienteSalvo;

        private void AddHeaderCheckbox()
        {

            // customize dataviewgrid, add checkbox column
            //DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            //checkboxColumn.Width = 30;
            //checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView_Arquivos.Columns.Insert(0, checkboxColumn);

            // add checkbox header
            Rectangle rect = dataGridView_Arquivos.GetCellDisplayRectangle(9, -1, true);

            // set checkbox header to center of header cell. +1 pixel to position correctly.
            rect.X = rect.Location.X + 8;
            rect.Y = rect.Location.Y + 10;
            rect.Width = rect.Size.Width;
            rect.Height = rect.Size.Height;

            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(15, 15);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);

            dataGridView_Arquivos.Controls.Add(checkboxHeader);
            /*
            CheckBox cb = new CheckBox();
            // your checkbox size
            cb.Size = new Size(15, 15);

            // datagridview checkbox header column cell size
            var cell = dataGridView_Arquivos.Columns[4].HeaderCell.Size;

            // calculate location
            cb.Location = new Point((cell.Width - cb.Size.Width) / 2, (cell.Height - cb.Size.Height) / 2);

            dataGridView_Arquivos.Controls.Add(cb);*/
        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
           

            if (checkeds == true)
            {
    
                foreach (DataGridViewRow row in dataGridView_Arquivos.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[9];
                    chk.Value = chk.FalseValue;
                    dataGridView_Arquivos.Columns[9].Frozen = false;

                }
                checkeds = false;
                pnlbtnexclude.Visible = false;
                countt = 0;
            }else if (checkeds == false)
            {
                int totalrowns = 0;
                foreach (DataGridViewRow row in dataGridView_Arquivos.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[9];
                    chk.Value = chk.TrueValue;
                    dataGridView_Arquivos.Columns[9].Frozen = true;
                    totalrowns = totalrowns + 1;
                }
                checkeds = true;
                pnlbtnexclude.Visible = true;
                countt = totalrowns;
            }
        }

        private void Form_Dados_Documentos_Load(object sender, EventArgs e)
        {
            
            Load_Dados_Process();
            #region Responsavel + Edição
            
            Processo process = null;

            LoginDaoComandos gettpross = new LoginDaoComandos();
            process = gettpross.GetProcesso(idProcess);

            if (process.Nome_responsavel == nomeuserloged)
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
                        nomeresponsavel = nomeuserloged;
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
            #endregion
            GetValueEdit();
        }

        public event Action ProcessoSalvo;
        private void Load_Dados_Process()
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
                valor = txtrenda.Text;
                txtrenda.Text = FormatCurrency(Convert.ToDouble(valor));

            }
            else
            {
                txtrenda.Text = process.RendaBruta_cliente;
                valor = txtrenda.Text;
                txtrenda.Text = FormatCurrency(Convert.ToDouble(valor));
                lblrentabruta.Text = lblrentabruta.Text + " + renda Cônjuges";
            }
            SetValor(txtrenda);
            txtagenciacliente.Text = process.Agencia_cliente;
            txtcontacliente.Text = process.Conta_cliente;
            if (string.IsNullOrEmpty(process.StatusCPF_cliente))
            {
                lblacpf.Visible = false;
                dtpcpf.Visible = false;
                dtpcpf.Value = DateTime.Parse("01/01/1999 00:00:00");
                lastselectedstatuscpf = "0";
            }
            else
            {
                txtStatusCPF.Text = process.StatusCPF_cliente;
                lblacpf.Visible = true;
                dtpcpf.Visible = true;
                dtpcpf.Value = DateTime.Parse(process.H_DataStatusCPF);
                lastselectedstatuscpf = process.StatusCPF_cliente;
            }
            if (string.IsNullOrEmpty(process.StatusCiweb_cliente))
            {
                lblaciweb.Visible = false;
                dtpciweb.Visible = false;
                dtpciweb.Value = DateTime.Parse("01/01/1999 00:00:00");
                lastselectedciweb = "0";
            }
            else
            {
                txtciweb.Text = process.StatusCiweb_cliente;
                lblaciweb.Visible = true;
                dtpciweb.Visible = true;
                dtpciweb.Value = DateTime.Parse(process.H_DataStatusCiweb);
                lastselectedciweb = process.StatusCiweb_cliente;
            }
            if (string.IsNullOrEmpty(process.StatusCadmut_cliente))
            {
                lblacadmut.Visible = false;
                dtpcadmut.Visible = false;
                dtpcadmut.Value = DateTime.Parse("01/01/1999 00:00:00");
                lastselectedcadmut = "0";
            }
            else
            {
                txtcadmut.Text = process.StatusCadmut_cliente;
                lblacadmut.Visible = true;
                dtpcadmut.Visible = true;
                dtpcadmut.Value = DateTime.Parse(process.H_DataStatusCadmut);
                lastselectedcadmut = process.StatusCadmut_cliente;
            }
            if (string.IsNullOrEmpty(process.StatusIR_cliente))
            {
                lblair.Visible = false;
                dtpir.Visible = false;
                dtpir.Value = DateTime.Parse("01/01/1999 00:00:00");
                lastselectedir = "0";
            }
            else
            {
                txtir.Text = process.StatusIR_cliente;
                lblair.Visible = true;
                dtpir.Visible = true;
                dtpir.Value = DateTime.Parse(process.H_DataStatusIR);
                lastselectedir = process.StatusIR_cliente;
            }
            if (string.IsNullOrEmpty(process.StatusFGTS_cliente))
            {
                lblafgtscli.Visible = false;
                dtpfgtscli.Visible = false;
                dtpfgtscli.Value = DateTime.Parse("01/01/1999 00:00:00");
                lastselectedfgts = "0";
            }
            else
            {
                txtfgts.Text = process.StatusFGTS_cliente;
                lblafgtscli.Visible = true;
                dtpfgtscli.Visible = true;
                dtpfgtscli.Value = DateTime.Parse(process.H_DataStatusIR);
                lastselectedfgts = process.StatusFGTS_cliente;
            }

            #endregion
            #region Vendedor
            textnomevendedor.Text = process.Nome_vendedor;

            //if (process.CNPJ_vendedor != "0")
            if (string.IsNullOrEmpty(process.CNPJ_vendedor) | process.CNPJ_vendedor != "00.000.000/0000-00")
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
            idVendedor = process.Id_vendedor;
            idVendedorold = process.Id_vendedor;
            #endregion
            #region imovel

            if (string.IsNullOrEmpty(process.Id_AgenciaImovel))
            {
                idagencia = "0";
                lastselectedag = "0";
            }
            else
            {
                idagencia = process.Id_AgenciaImovel;
                ComboboxItem itemag = new ComboboxItem();
                itemag.Text = process.AgenciaImovel_imovel;
                itemag.Value = Int32.Parse(idagencia);
                comboBox_agencia.Items.Add(itemag);
                comboBox_agencia.SelectedIndex = 0;
                lastselectedag = (comboBox_agencia.SelectedItem as ComboboxItem).Value.ToString();
            }
            if (string.IsNullOrEmpty(process.Id_Programa))
            {
                idprograma = "0";
                lastselectedprog = "0";
            }
            else
            {
                idprograma = process.Id_Programa;
                ComboboxItem itempg = new ComboboxItem();
                itempg.Text = process.Programa_imovel;
                itempg.Value = Int32.Parse(idprograma);
                comboBox_programa.Items.Add(itempg);
                comboBox_programa.SelectedIndex = 0;
                lastselectedprog = (comboBox_programa.SelectedItem as ComboboxItem).Value.ToString();
            }
            SetValor(valorimovel);
            SetValor(valorfinanciado);

            //valorimovel.Text = process.Valor_imovel;
            //valorfinanciado.Text = process.ValorFinanciado_imovel;
            if (string.IsNullOrEmpty(process.Id_construtora))
            {
                idconstrutora = "0";
                lastselectedconstru = "0";
            }
            else
            {
                idconstrutora = process.Id_construtora;
                ComboboxItem itemcontru = new ComboboxItem();
                itemcontru.Text = process.Descricao_construtora;
                itemcontru.Value = Int32.Parse(idconstrutora);
                comboBox_construtora.Items.Add(itemcontru);
                comboBox_construtora.SelectedIndex = 0;
                lastselectedconstru = (comboBox_construtora.SelectedItem as ComboboxItem).Value.ToString();
            }
            if (string.IsNullOrEmpty(process.Id_corretor))
            {
                idcorretor = "0";
                lastselectedcorretor = "0";
            }
            else
            {
                idcorretor = process.Id_corretor;
                ComboboxItem itemcorretor = new ComboboxItem();
                itemcorretor.Text = process.Nome_corretor;
                itemcorretor.Value = Int32.Parse(idcorretor);
                comboBox_corretor.Items.Add(itemcorretor);
                comboBox_corretor.SelectedIndex = 0;
                lastselectedcorretor = (comboBox_corretor.SelectedItem as ComboboxItem).Value.ToString();
            }
            if (string.IsNullOrEmpty(process.id_Empreendimentos_imovel))
            {
                idempreendimentos = "0";
                lastselectedempreendimentos = "0";
            }
            else
            {
                idempreendimentos = process.id_Empreendimentos_imovel;
                ComboboxItem itemempreendimentos = new ComboboxItem();
                itemempreendimentos.Text = process.EmpDescricao_imovel;
                itemempreendimentos.Value = Int32.Parse(idempreendimentos);
                comboBox_empreendimentos.Items.Add(itemempreendimentos);
                comboBox_empreendimentos.SelectedIndex = 0;
                lastselectedempreendimentos = (comboBox_empreendimentos.SelectedItem as ComboboxItem).Value.ToString();
            }
            if (string.IsNullOrEmpty(process.StatusAnalise_cliente))
            {
                lblaanalise.Visible = false;
                dtpanalise.Visible = false;
                dtpanalise.Value = new DateTime(2001, 10, 20);
                lblavalidadeanalise.Visible = false;
                dtpvalidadeanalise.Visible = false;
                dtpvalidadeanalise.Value = new DateTime(2001, 10, 20);
                lblranalise.Visible = false;
                lblaquem.Visible = false;
                pnlresp.Visible = false;
            }
            else
            {
                comboBox_analise.SelectedIndex = comboBox_analise.FindStringExact(process.StatusAnalise_cliente);
                lblaanalise.Visible = true;
                dtpanalise.Value = DateTime.Parse(process.H_DataStatusAnalise);
                dtpanalise.Visible = true;
                combdataanalise = dtpanalise.Value.ToString();
                respaprov = process.RespAprovacao_cliente;
                SetComboValidadeAnalise(process.StatusAnalise_cliente, process.H_DataValidadeStatusAnalise);


                //lblavalidadeanalise.Visible = true;
                //dtpvalidadeanalise.Value = DateTime.Parse(process.H_DataValidadeStatusAnalise);
                //dtpvalidadeanalise.Visible = true;
                combdatavalidadeanalise = dtpvalidadeanalise.Value.ToString();
                
            }
            if (string.IsNullOrEmpty(process.StatusEng_cliente))
            {
                lblaeng.Visible = false;
                dtpeng.Visible = false;
                dtpeng.Value = new DateTime(2001, 10, 20);
            }
            else
            {
                comboBox_statuseng.SelectedIndex = comboBox_statuseng.FindStringExact(process.StatusEng_cliente);
                //comboBox_statuseng.Text = process.StatusEng_cliente;
                lblaeng.Visible = true;
                dtpeng.Value = DateTime.Parse(process.H_DataStatusEng);
                dtpeng.Visible = true;
                combdatastatuseng = dtpeng.Value.ToString();

            }
            if (string.IsNullOrEmpty(process.SIOPI_cliente))
            {
                lblasiopi.Visible = false;
                dtpsiopi.Visible = false;
                dtpsiopi.Value = new DateTime(2001, 10, 20);
            }
            else
            {
                comboBox_SIOPI.SelectedIndex = comboBox_SIOPI.FindStringExact(process.SIOPI_cliente);
                //comboBox_SIOPI.Text = process.SIOPI_cliente;
                lblasiopi.Visible = true;
                dtpsiopi.Value = DateTime.Parse(process.H_DataSIOP);
                dtpsiopi.Visible = true;
                combdatasiopi = dtpsiopi.Value.ToString();

            }
            if (string.IsNullOrEmpty(process.SICTD_cliente))
            {
                lblasictd.Visible = false;
                dtpsictd.Visible = false;
                dtpsictd.Value = new DateTime(2001, 10, 20);
            }
            else
            {
                comboBox_SICTD.SelectedIndex = comboBox_SICTD.FindStringExact(process.SICTD_cliente);
                //comboBox_SICTD.Text = process.SICTD_cliente;
                lblasictd.Visible = true;
                dtpsictd.Value = DateTime.Parse(process.H_DataSICTD);
                dtpsictd.Visible = true;
                combdatasictd = dtpsictd.Value.ToString();
            }
            if (string.IsNullOrEmpty(process.SaqueFGTS_cliente))
            {
                lblafgts.Visible = false;
                dtpfgts.Visible = false;
                dtpfgts.Value = new DateTime(2001, 10, 20);
            }
            else
            {
                comboBox_saque.SelectedIndex = comboBox_saque.FindStringExact(process.SaqueFGTS_cliente);
                //comboBox_saque.Text = process.SaqueFGTS_cliente;
                lblafgts.Visible = true;
                dtpfgts.Value = DateTime.Parse(process.H_DataSaqueFGTS);
                dtpfgts.Visible = true;
                combdatasaque = dtpfgts.Value.ToString();
            }
            if (string.IsNullOrEmpty(process.StatusPA_cliente))
            {
                lblapa.Visible = false;
                dtppa.Visible = false;
                dtppa.Value = new DateTime(2001, 10, 20);
            }
            else
            {
                comboBox_PA.SelectedIndex = comboBox_PA.FindStringExact(process.StatusPA_cliente);
                //comboBox_PA.Text = process.StatusPA_cliente;
                lblapa.Visible = true;
                dtppa.Value = DateTime.Parse(process.H_DataPA);
                dtppa.Visible = true;
                combdatapa = dtppa.Value.ToString();
            }
           
            #endregion
            #region Cartorio



            //idCartorio = process.id_Carftorio;
            //comboBox_nomecartorio.Items.Add(process.Descricao_Carftorio);
            if (string.IsNullOrEmpty(process.Descricao_Carftorio))
            {
                idCartorio = "0";
                ComboboxItem itemcartorio = new ComboboxItem();
                itemcartorio.Text = "Selecione o Cartório";
                itemcartorio.Value = Int32.Parse(idCartorio);
                comboBox_nomecartorio.Items.Add(itemcartorio);
                comboBox_nomecartorio.SelectedIndex = 0;
                lastselectedcartorio = "";

                comboBox_statuscartorio.Text = "";
                lblacartorio.Visible = false;
                dtpcartorio.Visible = false;
                dtpcartorio.Value = new DateTime(2001, 10, 20);
            }
            else
            {

                lblnomecartorio.Text = process.Descricao_Carftorio;
                comboBox_statuscartorio.Text = process.StatusCartorio;
                dtpcartorio.Value = DateTime.Parse(process.H_DataStatusCartorio);
                dtpcartorio.Visible = true;
                lastselectedcartorio = process.Descricao_Carftorio;
                lblstatuscart.Visible = true;
                comboBox_statuscartorio.Visible = true;
                lblacartorio.Visible = true;
                dtpcartorio.Visible = true;

                idCartorio = process.id_Carftorio;
                descricao_carftorio = process.Descricao_Carftorio;
                statuscartorio = process.StatusCartorio;
                h_datastatuscartorio = process.H_DataStatusCartorio;
            }

            /*comboBox_statuscartorio.Text = process.StatusCartorio;
            if (process.H_DataStatusCartorio != "" && process.H_DataStatusCartorio != "01/01/0001 00:00:00")
            {


            }*/

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
        }
        public string FormatCurrency(double valor)
        {
            CultureInfo cultura = new CultureInfo("pt-BR");
            NumberFormatInfo formatoMoeda = cultura.NumberFormat;
            formatoMoeda.CurrencySymbol = "R$";
            return valor.ToString("C", formatoMoeda);
        }
        private void SetComboValidadeAnalise(string valor, string data)
        {
            switch (valor)
            {
                case "Não Consultado":

                    lblaanalise.Text = "Alterado:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Aprovado":

                    lblaanalise.Text = "Aprovado em:";
                    lblranalise.Text = respaprov;
                    lblranalise.Visible = true;
                    lblaquem.Visible = true;
                    pnlresp.Visible = true;
                    if (string.IsNullOrEmpty(data))
                    {
                        dtpvalidadeanalise.Value = new DateTime(2001, 10, 20);
                        dtpvalidadeanalise.Visible = false;
                        lblavalidadeanalise.Visible = false;
                    }
                    else
                    {
                        dtpvalidadeanalise.Value = DateTime.Parse(data);
                        dtpvalidadeanalise.Visible = true;
                        lblavalidadeanalise.Visible = true;
                    }
                    break;
                case "Condicionado":

                    lblaanalise.Text = "Condicionado em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Em analise":

                    lblaanalise.Text = "Iniciado:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Reprovado":

                    lblaanalise.Text = "Reprovado em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Comando":

                    lblaanalise.Text = "Comando em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Desistiu":

                    lblaanalise.Text = "Desistiu em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Bloqueado em ourto CCA":

                    lblaanalise.Text = "Analisado em:";
                    lblaquem.Text = "Responsável:";
                    lblranalise.Text = respaprov;
                    lblranalise.Visible = true;
                    lblaquem.Visible = true;
                    pnlresp.Visible = true;
                    if (string.IsNullOrEmpty(data))
                    {
                        dtpvalidadeanalise.Value = new DateTime(2001, 10, 20);
                        dtpvalidadeanalise.Visible = false;
                        lblavalidadeanalise.Visible = false;
                    }
                    else
                    {
                        dtpvalidadeanalise.Value = DateTime.Parse(data);
                        dtpvalidadeanalise.Visible = true;
                        lblavalidadeanalise.Visible = true;
                        
                    }

                    break;
            }
        }
        private void SetValor(TextBox textBox)
        {
            valor = textBox.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                textBox.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                textBox.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                textBox.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (textBox.Text.StartsWith("0,"))
                {
                    textBox.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (textBox.Text.Contains("00,"))
                {
                    textBox.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    textBox.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = textBox.Text;
            textBox.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            textBox.Select(textBox.Text.Length, 0);
        }
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
            Cursor = Cursors.WaitCursor;
            #region Combobox Cliente
            if (string.IsNullOrEmpty(StatusCPF))
            {
                txtStatusCPF.SelectedItem = null;
                lblacpf.Visible = false;
                dtpcpf.Visible = false;
            }
            else
            {
                txtStatusCPF.Text = StatusCPF;
                dtpcpf.Text = datacpf;
            }

            if (string.IsNullOrEmpty(ciweb))
            {
                txtciweb.SelectedItem = null;
                lblaciweb.Visible = false;
                dtpciweb.Visible = false;
            }
            else
            {
                txtciweb.Text = ciweb;
                dtpciweb.Text = dataciweb;
            }

            if (string.IsNullOrEmpty(cadmut))
            {
                txtcadmut.SelectedItem = null;
                lblacadmut.Visible = false;
                dtpcadmut.Visible = false;
            }
            else
            {
                txtcadmut.Text = cadmut;
                dtpcadmut.Text = datacadmut;
            }

            if (string.IsNullOrEmpty(ir))
            {
                txtir.SelectedItem = null;
                lblair.Visible = false;
                dtpir.Visible = false;
            }
            else
            {
                txtir.Text = ir;
                dtpir.Text = datair;
            }

            if (string.IsNullOrEmpty(fgts))
            {
                txtfgts.SelectedItem = null;
                lblafgtscli.Visible = false;
                dtpfgtscli.Visible = false;
            }
            else
            {
                txtfgts.Text = fgts;
                dtpfgtscli.Text = datafgtscli;
            }
            txtobservacao.Text = obs;
            #endregion

            #region Imovel
            if (string.IsNullOrEmpty(combanalise))
            {
                comboBox_analise.SelectedItem = null;
                lblaanalise.Visible = false;
                lblranalise.Visible = false;
                lblaquem.Visible = false;
                pnlresp.Visible = false;
                dtpanalise.Visible = false;
                lblavalidadeanalise.Visible = false;
                dtpvalidadeanalise.Visible = false;
                

            }
            else
            {
                comboBox_analise.Text = combanalise;

                lblaanalise.Visible = true;

                dtpanalise.Text = combdataanalise;
                if (string.IsNullOrEmpty(combdatavalidadeanalise))
                {
                    lblavalidadeanalise.Visible = false;
                    dtpvalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                }
                else
                {

                    lblavalidadeanalise.Visible = true;
                    dtpvalidadeanalise.Visible = true;
                    dtpvalidadeanalise.Text = combdatavalidadeanalise;
                    SetComboValidadeAnalise(combanalise, combdatavalidadeanalise);
                }

            }
            if (string.IsNullOrEmpty(combstatuseng))
            {
                comboBox_statuseng.SelectedItem = null;
                lblaeng.Visible = false;
                dtpeng.Visible = false;
            }
            else
            {
                comboBox_statuseng.Text = combstatuseng;
                lblaeng.Visible = true;
                dtpeng.Text = combdatastatuseng;
            }
            if (string.IsNullOrEmpty(combsiopi))
            {
                comboBox_SIOPI.SelectedItem = null;
                lblasiopi.Visible = false;
                dtpsiopi.Visible = false;
            }
            else
            {
                comboBox_SIOPI.Text = combsiopi;
                lblasiopi.Visible = true;
                dtpsiopi.Text = combdatasiopi;
            }
            if (string.IsNullOrEmpty(combsictd))
            {
                comboBox_SICTD.SelectedItem = null;
                lblasictd.Visible = false;
                dtpsictd.Visible = false;
            }
            else
            {
                comboBox_SICTD.Text = combsictd;
                lblasictd.Visible = true;
                dtpsictd.Text = combdatasictd;
            }
            if (string.IsNullOrEmpty(combsaque))
            {
                comboBox_saque.SelectedItem = null;
                lblafgts.Visible = false;
                dtpfgts.Visible = false;
            }
            else
            {
                comboBox_saque.Text = combsaque;
                lblafgts.Visible = true;
                dtpfgts.Text = combdatasaque;
            }
            if (string.IsNullOrEmpty(combpa))
            {
                comboBox_PA.SelectedItem = null;
                lblapa.Visible = false;
                dtppa.Visible = false;
            }
            else
            {
                comboBox_PA.Text = combpa;
                lblapa.Visible = true;
                dtppa.Text = combdatapa;
            }

            comboBox_agencia.Text = combag;
            if (string.IsNullOrEmpty(combag))
            {
                comboBox_agencia.SelectedItem = null;
            }
            else
            {
                comboBox_agencia.Text = combag;
            }
            if (string.IsNullOrEmpty(combprograma))
            {
                comboBox_programa.SelectedItem = null;
            }
            else
            {
                comboBox_programa.Text = combprograma;
            }
            valorimovel.Text = vlimovel;
            valorfinanciado.Text = vlfinan;
            comboBox_construtora.Text = combconstrutora;
            comboBox_corretor.Text = combcorretor;
            comboBox_empreendimentos.Text = combempreendimento;

            #endregion
            #region Cartorio
            if (string.IsNullOrEmpty(lastselectedcartorio))
            {
                comboBox_nomecartorio.DataSource = null;
                
                //comboBox_nomecartorio.Text = "Selecione o Cartorio";
                idCartorio = "0";
                ComboboxItem itemcartorio = new ComboboxItem();
                itemcartorio.Text = "Selecione o Cartório";
                itemcartorio.Value = Int32.Parse(idCartorio);
                comboBox_nomecartorio.Items.Add(itemcartorio);
                comboBox_nomecartorio.SelectedIndex = 0;
                comboBox_nomecartorio.IntegralHeight = true;

                comboBox_statuscartorio.SelectedItem = null;
                lblnomecartorio.Text = "Não iniciado";

                lblstatuscart.Visible = false;
                comboBox_statuscartorio.Visible = false;
                lblacartorio.Visible = false;
                dtpcartorio.Visible = false;


            }
            else
            {
                comboBox_nomecartorio.SelectedItem = null;
                comboBox_statuscartorio.Text = statuscartorio;
                lblnomecartorio.Text = descricao_carftorio;
                dtpcartorio.Value = DateTime.Parse(h_datastatuscartorio);

                lblstatuscart.Visible = true;
                comboBox_statuscartorio.Visible = true;
                lblacartorio.Visible = true;
                dtpcartorio.Visible = true;


            }

            //lastselectedcartorio = comboBox_nomecartorio.Text;
            #endregion
            string selecionado = idVendedorold;

            

            LoginDaoComandos gett = new LoginDaoComandos();
            Vendedor[] myArray = gett.GetVendedoresForid(selecionado).ToArray();
            foreach (Vendedor v in myArray)
            {
                idVendedor = v.Id_vendedor;
                textnomevendedor.Text = v.Nome_vendedor;

                if (string.IsNullOrEmpty(v.CNPJ_vendedor) || v.CNPJ_vendedor == "0")
                {
                    textcnpjcpf.Text = v.CPF_vendedor;

                }
                else
                {
                    textcnpjcpf.Text = v.CNPJ_vendedor;
                }
                textagenciavendedor.Text = v.Agencia_vendedor;
                txtcontavendedor.Text = v.Conta_vendedor;
                textemailvendedor.Text = v.Email_vendedor;
                texttelefonevendedor.Text = v.Telefone_vendedor;
                textcelularvendedor.Text = v.Celular_vendedor;
                idVendedor = v.Id_vendedor;
                nomevendedor = v.Nome_vendedor;
                tabControl.Select();
                tabControl.Focus();
            }

            Cursor = Cursors.Default;

            DesabilitarEdicao();
            //Close();
        }
        class ComboboxValue
        {
            public int Id { get; private set; }
            public string Name { get; private set; }

            public ComboboxValue(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
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
                    //pnlAnalise.Size = new Size(166, 125);
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Alterado:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Aprovado":
                    
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Aprovado em:";
                    DateTime hoje = DateTime.Now;
                    dtpvalidadeanalise.Value = hoje.AddDays(180);
                    dtpvalidadeanalise.Visible = true;
                    lblavalidadeanalise.Visible = true;
                    string[] useraprove1 = nomeuserloged.Split(' ');
                    respaprovsave = nomeuserloged;// useraprove[0] + " " + useraprove[1];
                    lblranalise.Text = respaprovsave;
                    lblranalise.Visible = true;
                    lblaquem.Visible = true;
                    lblaquem.Text = "Resp. Aprov. :";
                    pnlresp.Visible = true;
                    
                    break;
                case "Condicionado":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Condicionado em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Em analise":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Iniciado:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Reprovado":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Reprovado em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Comando":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Comando em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Desistiu":
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Desistiu em:";
                    dtpvalidadeanalise.Visible = false;
                    lblavalidadeanalise.Visible = false;
                    lblranalise.Visible = false;
                    lblaquem.Visible = false;
                    pnlresp.Visible = false;
                    break;
                case "Bloqueado em ourto CCA":
                    //pnlAnalise.Size = new Size(166, 231);
                    string[] useraprove = nomeuserloged.Split(' ');
                    respaprovsave = nomeuserloged;// useraprove[0] + " " + useraprove[1];
                    lblranalise.Text = respaprovsave;
                    lblaquem.Visible = true;
                    lblaquem.Text = "Responsável:";
                    lblranalise.Visible = true;
                    dtpanalise.Value = DateTime.Now;
                    dtpanalise.Visible = true;
                    lblaanalise.Visible = true;
                    lblaanalise.Text = "Analisado em:";
                    DateTime hojeB = DateTime.Now;
                    dtpvalidadeanalise.Value = hojeB.AddDays(180);
                    dtpvalidadeanalise.Visible = true;
                    lblavalidadeanalise.Visible = true;
                    pnlresp.Visible = true;
                    break;
            }
            tabControl.Refresh();
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
            #region Valor Imovel
            /* if (tabControl.SelectedTab == tabControl.TabPages["tabimovel"])//your specific tabname
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

                 //comboBox_construtora.DataSource = gettpross.GetDataConstrutora();
                 //comboBox_construtora.DisplayMember = "Descricao";
                 //comboBox_construtora.ValueMember = "Id";

                 //comboBox_corretor.DataSource = gettpross.GetDataCorretores();
                 //comboBox_corretor.DisplayMember = "Nome";
                 //comboBox_corretor.ValueMember = "Id";

                 //comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
                 //comboBox_empreendimentos.DisplayMember = "Descricao";
                 //comboBox_empreendimentos.ValueMember = "Id";

                 
             }*/
            #endregion
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

                AddHeaderCheckbox();

                Cursor = Cursors.Default;
                #endregion
            }
            if (tabControl.SelectedTab == tabControl.TabPages["tabcartorio"])
            {

                Cursor = Cursors.WaitCursor;

                Load_grid_Historico_Cartorio();
                //#region Ducumentos
                //LoginDaoComandos gethistorico = new LoginDaoComandos();

                //Local = documento.GetServer().ServerFilesPath_Server;

                //dataGridViewHistoricoCartorio.AutoGenerateColumns = false;
                ////dataGridViewHistoricoCartorio.Columns["Numero"].DefaultCellStyle.Format = "D6";
                //dataGridViewHistoricoCartorio.DataSource = gethistorico.GetHistoricoCartorio(idProcess);
                //dataGridViewHistoricoCartorio.Refresh();

                //comboBox_nomecartorio.DataSource = gettpross.GetDataCartorio();
                //comboBox_nomecartorio.DisplayMember = "Descricao";
                //comboBox_nomecartorio.ValueMember = "Id";
                //comboBox_nomecartorio.SelectedIndex = -1;

                Cursor = Cursors.Default;
                //#endregion
            }


        }
        private void Load_grid_Historico_Cartorio()
        {
            LoginDaoComandos gethistorico = new LoginDaoComandos();
            DataTable historico = new DataTable();

            historico = gethistorico.GetHistoricoCartorio(idProcess);
            if (historico.Rows.Count > 0)
            {
                groupBoxhistorico.Visible = true;
                dataGridViewHistoricoCartorio.AutoGenerateColumns = false;
                dataGridViewHistoricoCartorio.DataSource = historico;
                dataGridViewHistoricoCartorio.Refresh();
                //dataGridViewHistoricoCartorio.Rows[dataGridViewHistoricoCartorio.Rows.Count - 1].Selected = true;
                this.dataGridViewHistoricoCartorio.Sort(this.dataGridViewHistoricoCartorio.Columns["id"], ListSortDirection.Descending);
            }
            else
            {
                groupBoxhistorico.Visible = false;
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

        private void tableLayoutsitua_Paint(object sender, PaintEventArgs e)
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
                int exclude = 0;
                listmessage = "";
                foreach (DataGridViewRow roww in dataGridView_Arquivos.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)roww.Cells[9];
                    if(chk.Value == chk.TrueValue)
                    {
                        String iddoc = roww.Cells[0].Value.ToString().PadLeft(2, '0');
                        String extension = roww.Cells[8].Value.ToString();
                        //String pasta = idProcess;

                        listmessage = listmessage + "\n" + "Confima a exclusão do arquivo " + idProcess + iddoc + extension;
                        exclude = exclude + 1;
                    }
                }

                if (exclude < 2)
                {
                    DataGridViewRow row = dataGridView_Arquivos.Rows[e.RowIndex];

                    String iddoc = row.Cells[0].Value.ToString().PadLeft(2, '0');
                    String extension = row.Cells[8].Value.ToString();
                    String pasta = idProcess;
                    String reff = row.Cells[10].Value.ToString(); 

                    if (reff.Equals("0"))
                    {
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
                    }
                    else
                    {
                        foreach (DataGridViewRow roww in dataGridView_Arquivos.Rows)
                        {
                            String sref = roww.Cells[10].Value.ToString();
                            if (sref.Equals(reff))
                            {
                                 iddoc = roww.Cells[0].Value.ToString().PadLeft(2, '0');
                                 extension = roww.Cells[8].Value.ToString();
                                //String pasta = idProcess;

                                listmessage = listmessage + "\n" + "Confima a exclusão do arquivo " + idProcess + iddoc + extension;
                                //exclude = exclude + 1;
                            }
                        }
                        DialogResult dialogResult = MessageBox.Show(listmessage, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow roww in dataGridView_Arquivos.Rows)
                            {
                                String sref = roww.Cells[10].Value.ToString();
                                if (sref.Equals(reff))
                                {
                                     iddoc = roww.Cells[0].Value.ToString().PadLeft(2, '0');
                                     extension = roww.Cells[8].Value.ToString();
                                     pasta = idProcess;

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
                            }
                            //MessageBox.Show("O arquivo  não foi encontrado! \n Contate o Suporte Técnico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }

                    
                }else if (exclude > 1)
                {
                    DialogResult dialogResult = MessageBox.Show(listmessage, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow roww in dataGridView_Arquivos.Rows)
                        {
                            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)roww.Cells[9];
                            if (chk.Value == chk.TrueValue)
                            {
                                String iddoc = roww.Cells[0].Value.ToString().PadLeft(2, '0');
                                String extension = roww.Cells[8].Value.ToString();
                                String pasta = idProcess;

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
                        }
                        //MessageBox.Show("O arquivo  não foi encontrado! \n Contate o Suporte Técnico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }


                }
                #region Load Grid
                    LoginDaoComandos documento = new LoginDaoComandos();

                dataGridView_Arquivos.AutoGenerateColumns = false;
                //dataGridView_Arquivos.Columns["Numero"].DefaultCellStyle.Format = "D6";
                dataGridView_Arquivos.DataSource = documento.GetDataDocumentos(idProcess);
                dataGridView_Arquivos.Refresh();
                txtArquivo.Clear();
                pnlbtnexclude.Visible = false;
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
            if (e.ColumnIndex == dataGridView_Arquivos.Columns["Selecionar"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView_Arquivos.Rows[e.RowIndex].Cells[9];

                if (chk.Value == chk.TrueValue)
                {
                    
                    int A = Convert.ToInt32(dataGridView_Arquivos.Rows[e.RowIndex].Cells[10].Value.ToString());
                    if (A > 0)
                    {
                        foreach (DataGridViewRow row in dataGridView_Arquivos.Rows)
                        {
                            DataGridViewCheckBoxCell chkk = (DataGridViewCheckBoxCell)row.Cells[9];

                            if (Convert.ToInt32(row.Cells["Referencia"].Value.ToString()) == A)
                            {
                                chkk.Value = chk.FalseValue;
                                dataGridView_Arquivos.Columns[9].Frozen = false;
                                countt = countt - 1;
                            }
                        }
                        //pnlbtnexclude.Visible = true;
                        if (countt < 2)
                        {
                            pnlbtnexclude.Visible = false;
                        }

                    }
                    else
                    {
                        //dataGridView_Arquivos.Rows[e.RowIndex].Cells[9].Value = chk.FalseValue;
                        chk.Value = chk.FalseValue;
                        dataGridView_Arquivos.Columns[9].Frozen = false;
                        countt = countt - 1;
                        if (countt < 2)
                        {
                            pnlbtnexclude.Visible = false;
                        }

                    }
                    //dataGridView_Arquivos.Rows[e.RowIndex].Cells[9].Value = chk.FalseValue;
                }
                else 
                {
                    int A = Convert.ToInt32(dataGridView_Arquivos.Rows[e.RowIndex].Cells[10].Value.ToString());
                    if (A > 0)
                    {
                        foreach (DataGridViewRow row in dataGridView_Arquivos.Rows)
                        {
                            DataGridViewCheckBoxCell chkk = (DataGridViewCheckBoxCell)row.Cells[9];

                            if (Convert.ToInt32(row.Cells["Referencia"].Value.ToString()) == A)
                            {
                                chkk.Value = chk.TrueValue;
                                dataGridView_Arquivos.Columns[9].Frozen = true;
                                countt = countt + 1;
                            }
                        }
                        if (countt > 1)
                        {
                            pnlbtnexclude.Visible = true;
                        }
                        
                    }
                    else
                    {
                        dataGridView_Arquivos.Rows[e.RowIndex].Cells[9].Value = chk.FalseValue;
                        chk.Value = chk.TrueValue;
                        dataGridView_Arquivos.Columns[9].Frozen = true;
                        countt = countt + 1;
                        if (countt > 1)
                        {
                            pnlbtnexclude.Visible = true;
                        }
                    }
                    
                    
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
        private void textnomevendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);

            }
        }
        private bool HandlingRightClick { get; set; }
        private void comboBox_agencia_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right && !HandlingRightClick)
            {
               // HandlingRightClick = true;
                var result = MessageBox.Show("Deseja Adicionar nova Agência ?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    newForm = new Form_Cadastro_Agencias();
                    newForm.AtributoAcessadoPorOutroForm = "TEXTO";
                    newForm.AgenciaSalvo += new Action(frm_cadastro_agencia_AgenciaSalvo);
                    newForm.Owner = this;
                    newForm.Show();
                    Cursor = Cursors.Default;

                }
                /*if (!cmsRightClickMenu.Visible)
                    cmsRightClickMenu.Show(this, e.Location);
                else cmsRightClickMenu.Hide();*/
            }
            base.OnMouseDown(e);
        }
        private void comboBox_agencia_MouseUp(object sender, MouseEventArgs e)
        {
          //  HandlingRightClick = false;
            base.OnMouseUp(e);
        }
        private void comboBox_construtora_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && !HandlingRightClick)
            {
                // HandlingRightClick = true;
                var result = MessageBox.Show("Deseja Adicionar nova Construtora ?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    newFormConstrutora = new Form_Cadastro_Construtora();
                    newFormConstrutora.AtributoAcessadoPorOutroForm = "TEXTO";
                    newFormConstrutora.ConstrutoraSalvo += new Action(frm_cadastro_construtora_ConstrutoraSalvo);
                    newFormConstrutora.Owner = this;
                    newFormConstrutora.Show();
                    Cursor = Cursors.Default;

                }
                /*if (!cmsRightClickMenu.Visible)
                    cmsRightClickMenu.Show(this, e.Location);
                else cmsRightClickMenu.Hide();*/
            }
            base.OnMouseDown(e);
        }
        private void comboBox_construtora_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
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
        private void comboBox_corretor_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && !HandlingRightClick)
            {
                // HandlingRightClick = true;
                var result = MessageBox.Show("Deseja Adicionar novo Corretor ?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    newFormCorretor = new Form_Cadastro_Corretor();
                    //newFormCorretor.AtributoAcessadoPorOutroForm = "TEXTO";
                    newFormCorretor.CorretorSalvo += new Action(frm_cadastro_corretor_CorretorSalvo);
                    newFormCorretor.Owner = this;
                    newFormCorretor.Show();
                    Cursor = Cursors.Default;

                }
                /*if (!cmsRightClickMenu.Visible)
                    cmsRightClickMenu.Show(this, e.Location);
                else cmsRightClickMenu.Hide();*/
            }
            base.OnMouseDown(e);
        }
        private void textnomevendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var selected = this.textnomevendedor.GetItemText(this.textnomevendedor.SelectedItem);
            //MessageBox.Show(selected);

            String selecionado = this.textnomevendedor.GetItemText(this.textnomevendedor.SelectedItem);

            LoginDaoComandos gett = new LoginDaoComandos();
            Vendedor[] myArray = gett.GetVendedores(selecionado).ToArray();
            foreach (Vendedor v in myArray)
            {
                idVendedor = v.Id_vendedor;
                textnomevendedor.Text = v.Nome_vendedor;

               

                if (string.IsNullOrEmpty(v.CNPJ_vendedor) || v.CNPJ_vendedor == "0")
                {
                    textcnpjcpf.Text = v.CPF_vendedor;
                }
                else
                {
                    textcnpjcpf.Text = v.CNPJ_vendedor;
                }
                textagenciavendedor.Text = v.Agencia_vendedor;
                txtcontavendedor.Text = v.Conta_vendedor;
                textemailvendedor.Text = v.Email_vendedor;
                texttelefonevendedor.Text = v.Telefone_vendedor;
                textcelularvendedor.Text = v.Celular_vendedor;
                idVendedor = v.Id_vendedor;
                tabControl.Select();
                tabControl.Focus();
            }
            Cursor = Cursors.Default;
        }
        private void comboBox_empreendimentos_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && !HandlingRightClick)
            {
                // HandlingRightClick = true;
                var result = MessageBox.Show("Deseja Adicionar novo Empreendimento ?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    newFormEmpreendimentos = new Form_Cadastro_Empreendimentos();
                    //newFormCorretor.AtributoAcessadoPorOutroForm = "TEXTO";
                    newFormEmpreendimentos.EmpreendimentoSalvo += new Action(frm_cadastro_empreendimentos_EmpreendimentoSalvo);
                    newFormEmpreendimentos.Owner = this;
                    newFormEmpreendimentos.Show();
                    Cursor = Cursors.Default;

                }
                /*if (!cmsRightClickMenu.Visible)
                    cmsRightClickMenu.Show(this, e.Location);
                else cmsRightClickMenu.Hide();*/
            }
            base.OnMouseDown(e);
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
            //
            LoginDaoComandos updateprocesso = new LoginDaoComandos();

            #region Check Datas


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

            if (String.IsNullOrEmpty(txtStatusCPF.Text))
            {
                 cpfsave = txtStatusCPF.Text;
                datecpf = null;
            }
            else
            {
                cpfsave = txtStatusCPF.Text;
                datecpf = dtpcpf.Value; // DateTime.Parse(dtpcpf.Text);
            }
            if (String.IsNullOrEmpty(txtciweb.Text))
            {
                ciwebsave = txtciweb.Text;
                dateciweb = null;
            }
            else
            {
                ciwebsave = txtciweb.Text;
                dateciweb = dtpciweb.Value; // DateTime.Parse(dtpciweb.Text);
            }
            if (String.IsNullOrEmpty(txtcadmut.Text ))
            {
                cadmutsave = txtcadmut.Text;
                datecadmut = null;
            }
            else
            {
                cadmutsave = txtcadmut.Text;
                datecadmut = dtpcadmut.Value; // DateTime.Parse(dtpcadmut.Text);
            }
            if (String.IsNullOrEmpty(txtir.Text))
            {
                irsave = txtir.Text;
                dateir = null;
            }
            else
            {
                irsave = txtir.Text;
                dateir = dtpir.Value; // DateTime.Parse(dtpir.Text);
            }
            if (String.IsNullOrEmpty(txtfgts.Text))
            {
                fgtssave = txtfgts.Text;
                datefgts = null;

            }
            else
            { 
                fgtssave = txtfgts.Text;
                datefgts = dtpfgtscli.Value;
            }
            if (String.IsNullOrEmpty(comboBox_analise.Text))
            {
                analisesave = comboBox_analise.Text;
                dateanalise = null;
                datevalidadeanalise = null;
                respaprov = null;
            }
            else
            {
                analisesave = comboBox_analise.Text;
                dateanalise = dtpanalise.Value;
                datevalidadeanalise = dtpvalidadeanalise.Value;
                respaprovsave = lblranalise.Text;
                respaprov = lblranalise.Text;
            }
            if (String.IsNullOrEmpty(comboBox_statuseng.Text))
            {
                engsave = comboBox_statuseng.Text;
                dateeng = null;
            }
            else
            {
                engsave = comboBox_statuseng.Text;
                //dateeng = DateTime.Parse(dtpeng.Text);
                dateeng = dtpeng.Value;

            }
            if (String.IsNullOrEmpty(comboBox_SIOPI.Text))
            {
                siopisave = comboBox_SIOPI.Text;
                datesiopi = null;
            }
            else
            {
                siopisave = comboBox_SIOPI.Text;
                datesiopi = dtpsiopi.Value;
            }
            if (String.IsNullOrEmpty(comboBox_SICTD.Text))
            {
                sictdsave = comboBox_SICTD.Text;
                datesictd = null;
            }
            else
            {
                sictdsave = comboBox_SICTD.Text;
                datesictd = dtpsictd.Value;

            }
            if (String.IsNullOrEmpty(comboBox_saque.Text))
            {
                saquefgtssave = comboBox_saque.Text;
                datesaquefgts = null;
            }
            else
            {
                saquefgtssave = comboBox_saque.Text;
                datesaquefgts = dtpfgts.Value;
            }
            if (String.IsNullOrEmpty(comboBox_PA.Text))
            {
                pasave = comboBox_PA.Text;
                datepa = null;

            }
            else
            {
                pasave = comboBox_PA.Text;
                datepa = dtppa.Value;
            }

            String Valorimov = valorimovel.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            String Valorfinan = valorfinanciado.Text.Replace("R$", "").Replace(",", "").Replace(".", "").Replace(" ", "");

            String comboconstrutora = idconstrutora;
            String combocorretores = idcorretor;
            String combocoempreendimentos = idempreendimentos;
            datecartorio = dtpcartorio.Value;
            statuscartorio = comboBox_statuscartorio.Text;
            lblstatus.Text = statusprocesso;

            #endregion

            updateprocesso.UpdateProcesso(idProcess, cpfsave, datecpf, ciwebsave, dateciweb, cadmutsave, datecadmut, irsave, dateir, fgtssave, datefgts, analisesave, dateanalise, respaprovsave, datevalidadeanalise, engsave, dateeng, siopisave, datesiopi, sictdsave, datesictd, saquefgtssave, datesaquefgts, pasave, datepa, idagencia, idprograma, Valorimov, Valorfinan, comboconstrutora, combocorretores, combocoempreendimentos, idCartorio, statuscartorio, datecartorio, statusprocesso, txtobservacao.Text, idVendedor);

            MessageBox.Show(updateprocesso.mensagem, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_grid_Historico_Cartorio();

            if (ProcessoSalvo != null)
                ProcessoSalvo.Invoke();

            //Close();


            DesabilitarEdicao();
        }
        private void UpdateHistoricoCartorio(string id, string de, string para, string user)
        {
            LoginDaoComandos updateprocesso = new LoginDaoComandos();
            updateprocesso.UpdateHProcesso(id, de, para, user);
            Load_grid_Historico_Cartorio();
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
            //textnomevendedor.ReadOnly = false;
            textcnpjcpf.ReadOnly = false;
            textagenciavendedor.ReadOnly = false;
            txtcontavendedor.ReadOnly = false;
            textemailvendedor.ReadOnly = false;
            texttelefonevendedor.ReadOnly = false;
            textcelularvendedor.ReadOnly = false;

            //var btnvendedor = new Button();
            Button btnvendedor = new Button();
            btnvendedor.Size = new Size(22, textnomevendedor.ClientSize.Height + 2);
            btnvendedor.Dock = DockStyle.Right;
            btnvendedor.Cursor = Cursors.Default;
            btnvendedor.Image = Properties.Resources.procurar16;
            btnvendedor.FlatStyle = FlatStyle.Flat;
            btnvendedor.FlatAppearance.BorderSize = 3;
            btnvendedor.AutoSize = false;
            btnvendedor.ForeColor = Color.White;
            //pctr.FlatAppearance.BorderSize = 0;
            btnvendedor.Click += btnvendedor_Click;
            //pctr.Click += new EventHandler(pctr_Click);
            textnomevendedor.Enabled = true;
            textnomevendedor.Controls.Add(btnvendedor);

            #endregion
            #region Imovel
            comboBox_analise.Enabled = true;
            dtpanalise.Enabled = true;
            dtpvalidadeanalise.Enabled = true;
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
            comboBox_construtora.Enabled = true;
            comboBox_corretor.Enabled = true;
            comboBox_empreendimentos.Enabled = true;
            #endregion
            #region Cartorio
            comboBox_nomecartorio.Enabled = true;
            btnenviar.Enabled = true;
            comboBox_statuscartorio.Enabled = true;
            dtpcartorio.Enabled = true;
            #endregion
            #region Arquivos
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
            //Load_Dados_Process();

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
            //textnomevendedor.ReadOnly = true;
            textcnpjcpf.ReadOnly = true;
            textagenciavendedor.ReadOnly = true;
            txtcontavendedor.ReadOnly = true;
            textemailvendedor.ReadOnly = true;
            texttelefonevendedor.ReadOnly = true;
            textcelularvendedor.ReadOnly = true;
            textnomevendedor.Controls.Clear();
            textnomevendedor.Enabled = false;

            #endregion
            #region Imovel
            comboBox_analise.Enabled = false;
            dtpanalise.Enabled = false;
            dtpvalidadeanalise.Enabled = false;
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
            comboBox_construtora.Enabled = false;
            comboBox_corretor.Enabled = false;
            comboBox_empreendimentos.Enabled = false;

            #endregion
            #region Cartorio
            comboBox_nomecartorio.Enabled = false;
            btnenviar.Enabled = false;
            comboBox_statuscartorio.Enabled = false;
            dtpcartorio.Enabled = false;
            #endregion
            #region Arquivos
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
        private async void btnvendedor_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //backgroundWorker.RunWorkerAsync();

            int chars = textnomevendedor.Text.Length;

            if (chars >= 3)
            {
                LoginDaoComandos gett = new LoginDaoComandos();

                //await Task.Run(() => gett.autoCompletar(ComboBoxClient, ComboBoxClient.Text));

                gett.autoCompletarVendedor(textnomevendedor, textnomevendedor.Text);

                int cont = textnomevendedor.Items.Count;

                if (cont == 1)
                {
                    bPopCombo = false;
                    Vendedor[] myArray = gett.GetVendedores(textnomevendedor.Text).ToArray();
                    foreach (Vendedor v in myArray)
                    {

                        idVendedor = v.Id_vendedor;
                        textnomevendedor.Text = v.Nome_vendedor;
                        if (string.IsNullOrEmpty(v.CNPJ_vendedor) || v.CNPJ_vendedor == "0")
                        {
                            textcnpjcpf.Text = v.CPF_vendedor;
                        }
                        else
                        {
                            textcnpjcpf.Text = v.CNPJ_vendedor;
                        }

                        textagenciavendedor.Text = v.Agencia_vendedor;
                        txtcontavendedor.Text = v.Conta_vendedor;
                        textemailvendedor.Text = v.Email_vendedor;
                        texttelefonevendedor.Text = v.Telefone_vendedor;
                        textcelularvendedor.Text = v.Celular_vendedor;
                        tabControl.Select();
                        tabControl.Focus();
                    }
                }
                else if (cont == 0)
                {
                    string message = "Não foram encontrados registro para:  " + textnomevendedor.Text + " Deseja Cadastrar o Vendedor?";
                    const string caption = "Cadastrar Vendedor";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.Yes)
                    {
                        //cadastrar = 1;
                        textnomevendedor.Select();
                        textnomevendedor.Focus();
                        //MessageBox.Show("Abriu");
                        Form_Cadastro_Vendedor frm_Cadastro_Vendedor = new Form_Cadastro_Vendedor();
                        frm_Cadastro_Vendedor.setTextNome(textnomevendedor.Text);
                        frm_Cadastro_Vendedor.VendedorSalvo += new Action(frm_dados_vendedor_VendedorSalvo);
                        frm_Cadastro_Vendedor.Show();
                    }
                    else
                    {
                        //cadastrar = 0;
                        //LimparCamposVendedor();
                        textnomevendedor.Select();
                        textnomevendedor.Focus();
                    }


                    //MessageBox.Show("Não foram encontrados registro para:  " + ComboBoxClient.Text + "Deseja Cadastrar o Cliente?");


                }
                else
                {
                    if (bPopCombo)
                    {

                    }
                    else
                    {
                        textnomevendedor.DroppedDown = true;
                    }


                }
            }
            else
            {
                MessageBox.Show("Favor digitar Almenos 3 Caracteres para persquisa");
                textnomevendedor.Select();
                textnomevendedor.Focus();
            }
            
            Cursor = Cursors.Default;
        }
        void frm_dados_vendedor_VendedorSalvo()
        {
            btnvendedor_Click(this, EventArgs.Empty);
        }
        private void txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
                        nomeresponsavel = nomeuserloged;
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

        }
        private void GetValueEdit()
        {
            #region Cliente
            nomeclienteDB = ComboBoxClient.Text;
            cpfclienteDB = txtcpf.Text;
            rgclienteDB = txtrg.Text;
            nascclienteDB = txtnasc.Text;
            emailclienteDB = txtemail.Text;
            telefoneclienteDB = txttelefone.Text;
            celularclienteDB = txtcelular.Text;
            rendaclienteDB = txtrenda.Text ;
            agenciaclienteDB = txtagenciacliente.Text;
            contaclienteDB = txtcontacliente.Text;
            StatusCPF = txtStatusCPF.Text;
            datacpf = dtpcpf.Text;
            ciweb = txtciweb.Text;
            dataciweb = dtpciweb.Text;
            cadmut = txtcadmut.Text;
            datacadmut = dtpcadmut.Text;
            ir = txtir.Text;
            datair = dtpir.Text;
            fgts = txtfgts.Text;
            datafgtscli = dtpfgtscli.Text;
            obs = txtobservacao.Text;
            #endregion
            #region Imovel
            combanalise = comboBox_analise.Text ;
            respaprov = lblranalise.Text;
            combdataanalise = dtpanalise.Value.ToString();
            combdatavalidadeanalise = dtpvalidadeanalise.Value.ToString();
            combstatuseng = comboBox_statuseng.Text;
            combdatastatuseng = dtpeng.Value.ToString();
            combsiopi = comboBox_SIOPI.Text;
            combdatasiopi = dtpsiopi.Value.ToString();
            combsictd = comboBox_SICTD.Text;
            combdatasictd = dtpsictd.Value.ToString();
            combsaque = comboBox_saque.Text;
            combdatasaque = dtpfgts.Value.ToString();
            combpa = comboBox_PA.Text;
            combdatapa = dtppa.Value.ToString();

            combag = comboBox_agencia.Text;
                combprograma = comboBox_programa.Text;
                vlimovel = valorimovel.Text;
                vlfinan = valorfinanciado.Text;
                combconstrutora = comboBox_construtora.Text;
                combcorretor = comboBox_corretor.Text;
                combempreendimento = comboBox_empreendimentos.Text;
            #endregion
            #region cartorio

            descricao_carftorio = lblnomecartorio.Text;
            statuscartorio = comboBox_statuscartorio.Text;
            h_datastatuscartorio = dtpcartorio.Value.ToString();
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
                comboBox_empreendimentos.SelectedValue = lastselectedempreendimentos;
                #endregion

                comboBox_empreendimentos.DroppedDown = true;
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }
        private void comboBox_construtora_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (comboBox_construtora.DataSource is null)
            {
                comboBox_construtora.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_construtora.DataSource = gettpross.GetDataConstrutora();
                comboBox_construtora.DisplayMember = "Descricao";
                comboBox_construtora.ValueMember = "Id";
                comboBox_construtora.SelectedValue = lastselectedconstru;
                #endregion

                comboBox_construtora.DroppedDown = true;
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
                comboBox_corretor.SelectedValue = lastselectedcorretor; 
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
        void frm_cadastro_agencia_AgenciaSalvo()
        {
            comboBox_agencia.IntegralHeight = false;
            LoginDaoComandos gettpross = new LoginDaoComandos();
            #region Popular combobox
            comboBox_agencia.DataSource = gettpross.GetDataAgencia();
            comboBox_agencia.DisplayMember = "Agencia";
            comboBox_agencia.ValueMember = "Id";
           /* if (newForm.idagencia == "7")
            {
                comboBox_agencia.SelectedValue = idagencia;
            }
            else
            {*/
                comboBox_agencia.SelectedValue = newForm.idagencia;
            // }

            idagencia = newForm.idagencia;
            #endregion
        }
        void frm_cadastro_construtora_ConstrutoraSalvo()
        {
            comboBox_construtora.IntegralHeight = false;
            LoginDaoComandos gettpross = new LoginDaoComandos();
            #region Popular combobox
            comboBox_construtora.DataSource = gettpross.GetDataConstrutora();
            comboBox_construtora.DisplayMember = "Descricao";
            comboBox_construtora.ValueMember = "Id";
            comboBox_construtora.SelectedValue = newFormConstrutora.idconstrutora;

            idconstrutora = newFormConstrutora.idconstrutora;

            #endregion

            //MessageBox.Show(newForm.idagencia);
        }
        void frm_cadastro_corretor_CorretorSalvo()
        {
            comboBox_corretor.IntegralHeight = false;
            LoginDaoComandos gettpross = new LoginDaoComandos();
            #region Popular combobox
            comboBox_corretor.DataSource = gettpross.GetDataCorretores();
            comboBox_corretor.DisplayMember = "Nome";
            comboBox_corretor.ValueMember = "Id";
            comboBox_corretor.SelectedValue = newFormCorretor.idCorretor;

            idcorretor = newFormCorretor.idCorretor;

            #endregion

            //MessageBox.Show(newForm.idagencia);
        }
        void frm_cadastro_empreendimentos_EmpreendimentoSalvo()
        {
            comboBox_empreendimentos.IntegralHeight = false;
            LoginDaoComandos gettpross = new LoginDaoComandos();
            #region Popular combobox
            comboBox_empreendimentos.DataSource = gettpross.GetDataEmpreendimentos();
            comboBox_empreendimentos.DisplayMember = "Descricao";
            comboBox_empreendimentos.ValueMember = "Id";
            comboBox_empreendimentos.SelectedValue = newFormEmpreendimentos.idempreendimento;

            idempreendimentos = newFormEmpreendimentos.idempreendimento;

            #endregion

            //MessageBox.Show(newForm.idagencia);
        }
        private void comboBox_construtora_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idconstrutora = comboBox_construtora.SelectedValue.ToString();
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
            if (lblnomecartorio.Text == "Não iniciado") //|| lblnomecartorio.Text != comboBox_nomecartorio.Text) //&& lblnomecartorio.Text != "Não inciado" && lblnomecartorio.Text != "")
            {

                idCartorio = comboBox_nomecartorio.SelectedValue.ToString();
                lblnomecartorio.Text = comboBox_nomecartorio.Text;
                int index = comboBox_statuscartorio.FindString("Entregue");
                comboBox_statuscartorio.SelectedIndex = index;

                String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                dtpcartorio.Value = DateTime.Now;
                dtpcartorio.Visible = true;
                lblstatuscart.Visible = true;
                lblacartorio.Visible = true;
                comboBox_statuscartorio.Visible = true;


                comboBox_nomecartorio.SelectedIndex = -1;
                comboBox_statuscartorio.Select();

            }
            else
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
                    lblacartorio.Visible = true;
                    comboBox_statuscartorio.Visible = true;

                    comboBox_nomecartorio.SelectedIndex = -1;
                    comboBox_statuscartorio.Select();
                }
                else
                {
                    comboBox_nomecartorio.SelectedIndex = -1;
                }



            }
            //idCartorio = comboBox_nomecartorio.SelectedValue.ToString();
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
            //string lastselected = comboBox_agencia.Text;//comboBox_agencia.Items.Add(process.AgenciaImovel_imovel);
            //comboBox_agencia.Text = process.AgenciaImovel_imovel;
            if (comboBox_agencia.DataSource is null)
            {
                //string lastselected = comboBox_agencia.SelectedValue.ToString();
                //string lastselected = (comboBox_agencia.SelectedItem as ComboboxItem).Value.ToString();

                comboBox_agencia.IntegralHeight = false;
                LoginDaoComandos gettpross = new LoginDaoComandos();
                #region Popular combobox
                comboBox_agencia.DataSource = gettpross.GetDataAgencia();
                comboBox_agencia.DisplayMember = "Agencia";
                comboBox_agencia.ValueMember = "Id";
                comboBox_agencia.SelectedValue = lastselectedag;
                //comboBox_agencia.Text = lastselected;
                #endregion

                comboBox_agencia.DroppedDown = true;
                
                //comboBox_agencia.Text = "";
                Cursor = Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
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
                comboBox_programa.SelectedValue = lastselectedprog;
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
                // ofd1.FileNames.ToString();
                listarquivo = new List<string>();
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                    
                    listarquivo.Add(arquivo);

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
                sucess = false;
                int total = 0;

                string tipoarquivo = comboBox_tipoArquivo.Text;
                string tipoprocess = comboBox_tipoProcesso.Text;
                arquivoselected = txtArquivo.Text;
                foreach (string c in listarquivo)
                {
                    total = total + 1;
                }
                if (total > 1)
                {
                    int count = 1;
                    sucess = false;
                    LoginDaoComandos getnewref = new LoginDaoComandos();
                    int referencia = getnewref.GetIDNewDocumento();
                    foreach (string i in listarquivo)
                    {
                        curFile = i;
                        if (File.Exists(curFile))
                        {
                            if (Directory.Exists(Local + @"\" + idProcess)) //Pasta
                            {
                                LoginDaoComandos getnewdoc = new LoginDaoComandos();
                                int ultimoID = getnewdoc.GetIDNewDocumento();
                                extension = Path.GetExtension(curFile);

                                #region Salva arquivo no Caminho do servidor
                                String counts = ultimoID.ToString().PadLeft(2, '0');
                                NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                                try
                                {
                                    if (File.Exists(NewFile))
                                    {
                                        RenameFile(NewFile, NewFile + ".bkp");
                                    }

                                    RenameFile(curFile, NewFile);

                                    if (!File.Exists(curFile))
                                    {
                                        Console.WriteLine("File successfully renamed.");
                                        sucess = true;
                                    }
                                }
                                catch (IOException f)
                                {
                                    Console.WriteLine("The renaming failed: {0}", e.ToString());
                                }
                                #endregion


                                //Salvo referencia
                                #region Salvar no Banco

                                LoginDaoComandos enviar = new LoginDaoComandos();
                                caminho = Local + @"\" + idProcess + @"\";
                                numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                                statusArquivo = "Local";
                                ImageData = 0;
                                
                                int ultimoIDs = enviar.CriarDocumento(idProcess, tipoprocess, tipoarquivo + " Pg." + count, ImageData, extension, caminho, referencia, statusArquivo);
                                if (ultimoIDs > 0)
                                {
                                    sucess = true;
                                }
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
                                comboBox_tipoProcesso.SelectedIndex = -1;
                                Cursor = Cursors.Default;
                                
                                #endregion 

                                count = count + 1;

                            }
                            else
                            {
                                sucess = false;
                                Directory.CreateDirectory(Local + @"\" + idProcess);

                                LoginDaoComandos getnewdoc = new LoginDaoComandos();
                                int ultimoID = getnewdoc.GetIDNewDocumento();
                                extension = Path.GetExtension(curFile);

                                //MessageBox.Show(" New Doc: " + ultimoID, "Alterar Responsável" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                #region Salva arquivo no Caminho do servidor
                                String counts = ultimoID.ToString().PadLeft(2, '0');
                                NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                                try
                                {
                                    if (File.Exists(NewFile))
                                    {
                                        RenameFile(NewFile, NewFile + ".bkp");
                                    }

                                    RenameFile(curFile, NewFile);

                                    if (!File.Exists(curFile))
                                    {
                                        Console.WriteLine("File successfully renamed.");
                                        sucess = true;
                                    }
                                }
                                catch (IOException f)
                                {
                                    Console.WriteLine("The renaming failed: {0}", e.ToString());
                                }
                                #endregion

                                //Salvo referencia
                                #region Salvar no Banco

                                LoginDaoComandos enviar = new LoginDaoComandos();
                                caminho = Local + @"\" + idProcess + @"\";

                                numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                                statusArquivo = "Local";
                                ImageData = 0;
                                extension = Path.GetExtension(curFile);
                   
                                int ultimoIDs = enviar.CriarDocumento(idProcess, tipoprocess, tipoarquivo, ImageData, extension, caminho, referencia, statusArquivo);
                                if (ultimoIDs > 0)
                                {
                                    sucess = true;
                                }

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
                                comboBox_tipoProcesso.SelectedIndex = -1;
                                Cursor = Cursors.Default;
                                //MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                #endregion

                            }

                           
                        }
                        else
                        {
                            MessageBox.Show("Arquivo Não encontrado! \n Verifique se o arquivo existe.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (sucess == true)
                    {
                        MessageBox.Show("Arquivos Anexados!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao anexar os Arquivos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    curFile = arquivoselected;

                    if (File.Exists(curFile))
                    {
                        sucess = false;
                        LoginDaoComandos getnewref = new LoginDaoComandos();
                        int referencia = getnewref.GetIDNewDocumento();

                        if (Directory.Exists(Local + @"\" + idProcess)) //Pasta
                        {
                            LoginDaoComandos getnewdoc = new LoginDaoComandos();
                            int ultimoID = getnewdoc.GetIDNewDocumento();
                            extension = Path.GetExtension(curFile);

                            //MessageBox.Show(" New Doc: " + ultimoID, "Alterar Responsável" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            #region Salva arquivo no Caminho do servidor
                            String counts = ultimoID.ToString().PadLeft(2, '0');
                            NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                            try
                            {
                                if (File.Exists(NewFile))
                                {
                                    RenameFile(NewFile, NewFile + ".bkp");
                                }

                                RenameFile(curFile, NewFile);

                                if (!File.Exists(curFile))
                                {
                                    Console.WriteLine("File successfully renamed.");
                                    sucess = true;
                                }
                            }
                            catch (IOException f)
                            {
                                Console.WriteLine("The renaming failed: {0}", e.ToString());
                            }
                            #endregion

                            //Salvo referencia
                            #region Salvar no Banco

                            LoginDaoComandos enviar = new LoginDaoComandos();
                            caminho = Local + @"\" + idProcess + @"\";

                            numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                            statusArquivo = "Local";
                            ImageData = 0;
                            //extension = Path.GetExtension(curFile);
                   
                            int ultimoIDs = enviar.CriarDocumento(idProcess, tipoprocess, tipoarquivo, ImageData, extension, caminho, referencia, statusArquivo);
                            if (ultimoIDs > 0)
                            {
                                sucess = true;
                            }

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
                            comboBox_tipoProcesso.SelectedIndex = -1;
                            Cursor = Cursors.Default;
                            //MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion


                        }
                        else
                        {
                            Directory.CreateDirectory(Local + @"\" + idProcess);

                            LoginDaoComandos getnewdoc = new LoginDaoComandos();
                            int ultimoID = getnewdoc.GetIDNewDocumento();
                            extension = Path.GetExtension(curFile);

                            //MessageBox.Show(" New Doc: " + ultimoID, "Alterar Responsável" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            #region Salva arquivo no Caminho do servidor
                            String counts = ultimoID.ToString().PadLeft(2, '0');
                            NewFile = Local + @"\" + idProcess + @"\" + idProcess + counts + extension;

                            try
                            {
                                if (File.Exists(NewFile))
                                {
                                    RenameFile(NewFile, NewFile + ".bkp");
                                }

                                RenameFile(curFile, NewFile);

                                if (!File.Exists(curFile))
                                {
                                    Console.WriteLine("File successfully renamed.");
                                    sucess = true;
                                }
                            }
                            catch (IOException f)
                            {
                                Console.WriteLine("The renaming failed: {0}", e.ToString());
                            }
                            #endregion

                            //Salvo referencia
                            #region Salvar no Banco

                            LoginDaoComandos enviar = new LoginDaoComandos();
                            caminho = Local + @"\" + idProcess + @"\";

                            numArquivo = idProcess + count.ToString().PadLeft(2, '0');
                            statusArquivo = "Local";
                            ImageData = 0;
                            //extension = Path.GetExtension(curFile);

                            int ultimoIDs = enviar.CriarDocumento(idProcess, tipoprocess, tipoarquivo, ImageData, extension, caminho, referencia, statusArquivo);
                            if (ultimoIDs > 0)
                            {
                                sucess = true;
                            }

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
                            comboBox_tipoProcesso.SelectedIndex = -1;
                            Cursor = Cursors.Default;
                            //MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            #endregion

                        }

                        if (sucess == true)
                        {
                            MessageBox.Show("Arquivo Anexado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao anexar o Arquivo!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Arquivos Não encontrados! \n Verifique se o arquivo existe.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                
            }
            Cursor = Cursors.Default;
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

            switch (comboBox_SIOPI.SelectedItem.ToString())
            {
                case "Não Consultado":
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
                case "Enviado":
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
                case "Não Enviado":
                    dtpsiopi.Value = DateTime.Now;
                    dtpsiopi.Visible = true;
                    lblasiopi.Visible = true;
                    break;
            }
        }
        private void comboBox_SICTD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox_SICTD.SelectedItem.ToString())
            {
                case "Não Consultado":
                    //String Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
                case "Enviado":
                    //String Data1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
                case "Não Enviado":
                    //String Data2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    dtpsictd.Value = DateTime.Now;
                    dtpsictd.Visible = true;
                    lblasictd.Visible = true;
                    break;
            }
        }
        private void comboBox_saque_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox_saque.SelectedItem.ToString())
            {
                case "Não Consultado":
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Total":
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Parcial":
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
                case "Não Usar":
                    dtpfgts.Value = DateTime.Now;
                    dtpfgts.Visible = true;
                    lblafgts.Visible = true;
                    break;
            }
        }
        private void comboBox_PA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox_PA.SelectedItem.ToString())
            {
                case "Não Consultado":
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
                    break;
                case "Conforme":
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
                    break;
                case "Inconforme":
                    dtppa.Value = DateTime.Now;
                    dtppa.Visible = true;
                    lblapa.Visible = true;
                    break;
            }
        }
        private void txtStatusCPF_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (txtStatusCPF.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
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
            switch (txtciweb.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
                case "Não Consultado":
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Ativo":
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Inativo":
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
                case "Nada Consta":
                    dtpciweb.Value = DateTime.Now;
                    dtpciweb.Visible = true;
                    lblaciweb.Visible = true;
                    break;
            }
        }
        private void txtir_SelectionChangeCommitted(object sender, EventArgs e)
        {
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
            }
        }
        private void txtfgts_SelectionChangeCommitted(object sender, EventArgs e)
        {
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

    }
}
