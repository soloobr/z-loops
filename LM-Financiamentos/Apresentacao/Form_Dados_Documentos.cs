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

namespace LMFinanciamentos.Apresentacao
{
    public partial class Form_Dados_Documentos : Form
    {

        bool Next;


        string  idProcess, datacpf, dataciweb, datacadmut, datair, datafgts, dataanalise, dataeng, datacartorio, datastatus, statusprocesso;

        //private int cadastrar = 0;
        //private int newProgressValue;

        public Form_Dados_Documentos()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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

            #region Processos
            lblnumeroprocesso.Text = idProcess;
            lblfuncresponsavel.Text = process.Nome_responsavel;
            ComboBoxClient.Text = process.Nome_cliente;

            var parsedDate = DateTime.Parse(process.Data_processo);

            string asString = parsedDate.ToString("dd/MMMM/yyyy");
            lbldata.Text = asString;

            //txtStatusCPF.Text = process.StatusCPF_cliente;
            //txtciweb.Text = c.StatusCiweb_cliente;
            //txtcadmut.Text = c.StatusCadmut_cliente;
            //txtir.Text = c.StatusIR_cliente;
            //txtfgts.Text = c.StatusFGTS_cliente;
            #endregion

            #region Cliente
            txtcpf.Text = process.CPF_cliente;
            txtrg.Text = process.RG_cliente;
            txtnasc.Text = process.Nascimento_cliente;
            txtemail.Text = process.Email_cliente;
            txttelefone.Text = process.Telefone_cliente;
            txtcelular.Text = process.Celular_cliente;
            txtrenda.Text = process.Renda_cliente;
            txtagencia.Text = process.Agencia_cliente;
            txtcontacliente.Text = process.Conta_cliente;
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

            #region Status
            txtStatusCPF.Text = process.StatusCPF_cliente;
            txtciweb.Text = process.StatusCiweb_cliente;
            txtcadmut.Text = process.StatusCadmut_cliente;
            txtir.Text = process.StatusIR_cliente;
            txtfgts.Text = process.StatusFGTS_cliente;

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
            if (lbldatacartorio.Text != "__/ ___/ ____")
            {
                datacartorio = lbldatacartorio.Text;
            }
            else
            {
                datacartorio = "01/01/0001 00:00:00";
            }
            //if (lbldatastatus.Text != "Data")
            //{
            //    datastatus = lbldatastatus.Text;
            //}
            //else
            //{
                datastatus = "01/01/0001 00:00:00";
            //}

            

            DateTime datecpf = DateTime.Parse(datacpf);
            DateTime dateciweb = DateTime.Parse(dataciweb);
            DateTime datecadmut = DateTime.Parse(datacadmut);
            DateTime dateir = DateTime.Parse(datair);
            DateTime datefgts = DateTime.Parse(datafgts);
            DateTime dateanalise = DateTime.Parse(dataanalise);
            DateTime dateeng = DateTime.Parse(dataeng);
            DateTime datecartorio = DateTime.Parse(datacartorio);
            DateTime datestatus = DateTime.Parse(datastatus);

            lblstatus.Text = statusprocesso;

            updateprocesso.UpdateProcesso(idProcess, txtStatusCPF.Text, txtciweb.Text, txtcadmut.Text, txtir.Text, txtfgts.Text, datecpf, dateciweb, datecadmut, dateir, datefgts, dateanalise, dateeng, datecartorio, datestatus, statusprocesso);
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
