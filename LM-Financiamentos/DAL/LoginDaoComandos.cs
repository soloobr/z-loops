using ComponentFactory.Krypton.Toolkit;
using LMFinanciamentos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMFinanciamentos.DAL
{


    class LoginDaoComandos

    {
        
        public bool tem = false;
        public string mensagem = "";
        private String slogin;
        public string sloginn
        {
            get { return slogin; }
            set { slogin = value; }

        }
        /*public string NomeFunc
        {
            get { return NomeFunc; }
            set { NomeFunc = value; }

        }*/

        //public int idFunc;
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd1 = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        Conecxao con = new Conecxao();
        Conecxao conn = new Conecxao();
        Conecxao con2 = new Conecxao();
        //SqlDataReader dr;
        MySqlDataReader dr, drfunc, drsenha, drclient, drclients, drprocess, drvebdedor, drprocessos;


        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "Select * From Login where Login =@login and Senha =@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                dr.Close();
            }
            catch (SqlException)
            {
                //throw;
                tem = false;
            }

            return tem;
        }
        public String CadastrarCliente(String nome, String email, String telefone, String celular, String cpf, String statuscpf, String stciweb, String stcadmut
                , String stir, String stfgts, String rg, String nascimento, String sexo, String status, String renda)
        {


            try
            {
                cmd.CommandText = "INSERT INTO Clientes (Nome, Email, Telefone, Celular, CPF, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Status, Renda) Values  (@nome, @email, @telefone, @celular, @cpf, @statuscpf, @stciweb, @stcadmut, @stir, @stfgts, @rg, @nascimento, @sexo, @status, @renda)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@statuscpf", statuscpf);
                cmd.Parameters.AddWithValue("@stciweb", stciweb);
                cmd.Parameters.AddWithValue("@stcadmut", stcadmut);
                cmd.Parameters.AddWithValue("@stir", stir);
                cmd.Parameters.AddWithValue("@stfgts", stfgts);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@renda", renda);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cliente Cadastrado Com Sucesso";
                }
                else
                {
                    mensagem = "Erro ao Cadastrar Cliente";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Cadastrar Cliente: " + err.Message);
            }

            return mensagem;
        }
        public Funcionario GetFunc(String login, String senha)
        {
            cmd.CommandText = "Select Funcionarios.Login as id, Funcionarios.Nome, Login.Login, Login.Senha, Permission, Foto From Login inner join Funcionarios on Login.id = Funcionarios.Login inner join Foto F on Login.id = F.IdFunc  where Login.Login = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            Funcionario func = new Funcionario();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    func.Id_func = drfunc["id"].ToString();
                    func.Nome_Func = drfunc["Nome"].ToString();
                    func.Login_Func = drfunc["Login"].ToString();
                    func.Senha_Func = drfunc["Senha"].ToString();
                    func.Permision = drfunc["Permission"].ToString();
                    Byte[] byteBLOBData = new Byte[0];
                    func.Foto_Func = (Byte[])(drfunc["Foto"]);
                }
                drfunc.Close();
            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter funcionário: " + err.Message);
            }

            return func;
        }
        public Cliente GetCliente(String nome)
        {
           //var list = new List<Cliente>();

            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, CPF, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Renda, Status FROM Clientes WHERE Nome LIKE @nomecliente";
            cmd.Parameters.AddWithValue("@nomecliente", "%"+nome+"%");
            Cliente client = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    client.Id_cliente = drclient["id"].ToString();
                    client.Nome_cliente = drclient["Nome"].ToString();
                    client.Email_cliente = drclient["Email"].ToString();
                    client.Telefone_cliente = drclient["Telefone"].ToString();
                    client.Celular_cliente = drclient["Celular"].ToString();
                    client.CPF_cliente = drclient["CPF"].ToString();
                    client.StatusCPF_cliente = drclient["StatusCPF"].ToString();
                    client.StatusCiweb_cliente = drclient["Ciweb"].ToString();
                    client.StatusCadmut_cliente = drclient["Cadmut"].ToString();
                    client.StatusIR_cliente = drclient["IR"].ToString();
                    client.StatusFGTS_cliente = drclient["FGTS"].ToString();
                    client.RG_cliente = drclient["RG"].ToString();
                    client.Nascimento_cliente = drclient["Nascimento"].ToString();
                    client.Sexo_cliente = drclient["Sexo"].ToString();
                    client.Status_cliente = drclient["Status"].ToString();
                    client.Renda_cliente = drclient["Renda"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    //list.Add(client);
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            return client;
            //return list;
        }
        public Processo GetProcesso(String idprocess)
        {
            //var list = new List<Cliente>();

            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , ValorImovel, ValorFinanciado, P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS,  " +
                "P.StatusAnalise as	StatusAnalise, P.StatusEng as StatusEng, P.SaqueFGTS as SaqueFGTS, P.SIOPI as SIOPI, P.SICTD as SICTD, P.StatusPA as StatusPA, P.StatusCartorio as StatusCartorio, " + 
                "Clientes.id as idCliente, Clientes.Nome as clinome, Clientes.Email as EmailCli,  Clientes.Telefone as Telefonecli , Clientes.Celular as celularcli, Clientes.CPF as cpfcli, Clientes.RG as rgcli, Conta.Agencia as agenciacli, Conta.Conta as contacli, Clientes.Nascimento as Nascimento, Clientes.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, V.Agencia as agenciavendedor, V.Conta as contavendedor,   " +
                "Corretora.Descricao as Corretora, Corretores.Nome as Corretor, P.idCorretora, P.idCorretor, Agencia.Agencia as AgenciaImovel, Programa.Descricao as Programa, Empreendimentos.Descricao as EmpDescricao,     " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataSaqueFGTS, P.DataSIOP, P.DataSICTD, P.DataPA, P.DataStatusCartorio, P.DataStatus   " +

                "FROM Processos P " +
                "inner join Clientes on Clientes.id = P.idCliente " +
                "inner join Vendedor V on V.id = P.idVendedor " +
                "inner join Funcionarios F on F.id = P.idresponsavel " +
                "Left join Conta on Conta.idcliente = Clientes.id and Conta.Tipo =@tipo  " +
                "Left join Agencia on P.idAgenciaImovel = Agencia.id " +
                "Left join Programa on P.idPrograma = Programa.id " +
                "Left join Empreendimentos on P.idEmpreendimento = Empreendimentos.id "+
                "Left join Corretora on P.idCorretora = Corretora.id " +
                "Left join Corretores on P.idCorretor = Corretores.id " +
                "WHERE P.id = @idprocesso";
            cmd.Parameters.AddWithValue("@idprocesso", idprocess);
            cmd.Parameters.AddWithValue("@tipo", "C");
            Processo process = new Processo();
            try
            {
                cmd.Connection = con.conectar();
                drprocess = cmd.ExecuteReader();
                while (drprocess.Read())
                {
                    #region Processo
                    process.Id_processo = drprocess["idpross"].ToString();
                    process.Id_responsavel = drprocess["idresponsavel"].ToString();
                    process.Nome_responsavel = drprocess["nomeresponsavel"].ToString();
                    process.Permission_responsavel = drprocess["permissionresponsavel"].ToString();
                    process.Obs_processo = drprocess["Observacao"].ToString();
                    process.Data_processo = drprocess["Data"].ToString();

                    process.StatusCPF_cliente = drprocess["StatusCPF"].ToString();
                    process.StatusCiweb_cliente = drprocess["StatusCiweb"].ToString();
                    process.StatusCadmut_cliente = drprocess["StatusCadmut"].ToString();
                    process.StatusIR_cliente = drprocess["StatusIR"].ToString();
                    process.StatusFGTS_cliente = drprocess["StatusFGTS"].ToString();
                    process.StatusAnalise_cliente = drprocess["StatusAnalise"].ToString();
                    process.StatusEng_cliente = drprocess["StatusEng"].ToString();
                    process.SaqueFGTS_cliente = drprocess["SaqueFGTS"].ToString();
                    process.SIOPI_cliente = drprocess["SIOPI"].ToString();
                    process.SICTD_cliente = drprocess["SICTD"].ToString();
                    process.StatusPA_cliente = drprocess["StatusPA"].ToString();


                    process.H_DataStatusCPF = drprocess["DataStatusCPF"].ToString();
                    process.H_DataStatusCiweb = drprocess["DataStatusCiweb"].ToString();
                    process.H_DataStatusCadmut = drprocess["DataStatusCadmut"].ToString();
                    process.H_DataStatusIR = drprocess["DataStatusIR"].ToString();
                    process.H_DataStatusFGTS = drprocess["DataStatusFGTS"].ToString();
                    process.H_DataStatusAnalise = drprocess["DataStatusAnalise"].ToString();
                    process.H_DataStatusEng = drprocess["DataStatusEng"].ToString();
                    process.H_DataSaqueFGTS = drprocess["DataSaqueFGTS"].ToString();
                    process.H_DataSIOP = drprocess["DataSIOP"].ToString();
                    process.H_DataSICTD = drprocess["DataSICTD"].ToString();
                    process.H_DataPA = drprocess["DataPA"].ToString();
                    process.H_DataStatusCartorio = drprocess["DataStatusCartorio"].ToString();
                    process.H_DataStatus = drprocess["DataStatus"].ToString();

                    #endregion

                    #region Cliente
                    process.Id_cliente = drprocess["idCliente"].ToString();
                    process.Nome_cliente = drprocess["clinome"].ToString();
                    process.Email_cliente = drprocess["EmailCli"].ToString();
                    process.Telefone_cliente = drprocess["Telefonecli"].ToString();
                    process.Celular_cliente = drprocess["celularcli"].ToString();
                    process.CPF_cliente = drprocess["cpfcli"].ToString();
                    process.RG_cliente = drprocess["rgcli"].ToString();
                    process.Nascimento_cliente = drprocess["Nascimento"].ToString();
                    process.Renda_cliente = drprocess["rendacli"].ToString();
                    process.Agencia_cliente = drprocess["agenciacli"].ToString();
                    process.Conta_cliente = drprocess["contacli"].ToString();
                    #endregion


                    #region Vendedor
                    process.Id_vendedor = drprocess["idVendedor"].ToString();
                    process.Nome_vendedor = drprocess["vendnome"].ToString();
                    process.Email_vendedor = drprocess["Emailvendedor"].ToString();
                    process.Telefone_vendedor = drprocess["Telefonevendedor"].ToString();
                    process.Celular_vendedor = drprocess["celularvendedor"].ToString();
                    process.CPF_vendedor = drprocess["cpfvendedor"].ToString();
                    process.CNPJ_vendedor = drprocess["cnpjvendedor"].ToString();
                    //process.Nascimento_vendedor = drprocess["Nascimento"].ToString();
                    //process.Renda_vendedor = drprocess["rendavendedor"].ToString();
                    process.Agencia_vendedor = drprocess["agenciavendedor"].ToString();
                    process.Conta_vendedor = drprocess["contavendedor"].ToString();
                    #endregion

                    #region imovel
                    process.Id_corretora = drprocess["idCorretora"].ToString();
                    process.Id_corretor = drprocess["idCorretor"].ToString();
                    process.AgenciaImovel_imovel = drprocess["AgenciaImovel"].ToString();
                    process.Programa_imovel = drprocess["Programa"].ToString();

                    process.Valor_imovel = drprocess["ValorImovel"].ToString();
                    process.ValorFinanciado_imovel = drprocess["ValorFinanciado"].ToString();

                    process.Nome_corretor = drprocess["Corretor"].ToString();
                    process.Descricao_corretora = drprocess["Corretora"].ToString();
                    process.EmpDescricao_imovel = drprocess["EmpDescricao"].ToString();
                    

                    #endregion

                }
                drprocess.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Processo: " + err.Message);
            }

            return process;
        }
        public List<Processo> GetProcessos(String tipo, String nome)
        {
            var listprocessos = new List<Processo>();

            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS, P.Status as Status, Corretora.Descricao as Corretora, Corretores.Nome as Corretor, " +
                "C.id as idCliente, C.Nome as clinome, C.Email as EmailCli,  C.Telefone as Telefonecli , C.Celular as celularcli, C.CPF as cpfcli, C.RG as rgcli, Conta.Agencia as agenciacli, Conta.Conta as contacli, C.Nascimento as Nascimento, C.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, V.Agencia as agenciavendedor, V.Conta as contavendedor,   " +
                "Corretora.id as idcorretora, Corretores.id as idCorretor,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataStatusCartorio, P.DataStatus " +

                "FROM Processos P " +
                "inner join Clientes C on C.id = P.idCliente " +
                "inner join Vendedor V on V.id = P.idVendedor " +
                "inner join Funcionarios F on F.id = P.idresponsavel " +
                "Left join Conta on C.id = Conta.idcliente and Conta.Tipo =@tipo " +
                "Left join Corretora on P.idCorretora = Corretora.id " +
                "Left join Corretores on P.idCorretor = Corretores.id " +
                //"Left join P_Status H on P.id = H.idprocesso " +
                "WHERE (C.Nome Like @consulta) or (P.id Like @consulta) "+
                " ORDER BY  P.id ASC "
                ;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@consulta", "%" + nome + "%");

            try
            {
                cmd.Connection = con.conectar();
                drprocessos = cmd.ExecuteReader();

                if (drprocessos.HasRows)
                {
                    while (drprocessos.Read())
                    {
                        Processo processos = new Processo();
                        #region Processo
                        processos.Id_processo = (drprocessos["idpross"].ToString()).PadLeft(4, '0');
                        //processos.Id_responsavel = drprocessos["idresponsavel"].ToString();
                        processos.Nome_responsavel = drprocessos["nomeresponsavel"].ToString();
                        //processos.Permission_responsavel = drprocessos["permissionresponsavel"].ToString();
                        processos.Data_processo = drprocessos["Data"].ToString();
                        //processos.Obs_processo = drprocessos["Observacao"].ToString();
                        //processos.StatusCPF_cliente = drprocessos["StatusCPF"].ToString();
                        //processos.StatusCiweb_cliente = drprocessos["StatusCiweb"].ToString();
                        //processos.StatusCadmut_cliente = drprocessos["StatusCadmut"].ToString();
                        //processos.StatusIR_cliente = drprocessos["StatusIR"].ToString();
                        //processos.StatusFGTS_cliente = drprocessos["StatusFGTS"].ToString();
                        processos.Status_processo = drprocessos["Status"].ToString();

                        //processos.H_DataStatusCPF = drprocessos["DataStatusCPF"].ToString();
                        //processos.H_DataStatusCiweb = drprocessos["DataStatusCiweb"].ToString();
                        //processos.H_DataStatusCadmut = drprocessos["DataStatusCadmut"].ToString();
                        //processos.H_DataStatusIR = drprocessos["DataStatusIR"].ToString();
                        //processos.H_DataStatusFGTS = drprocessos["DataStatusFGTS"].ToString();
                        //processos.H_DataStatusAnalise = drprocessos["DataStatusAnalise"].ToString();
                        //processos.H_DataStatusEng = drprocessos["DataStatusEng"].ToString();
                        //processos.H_DataStatusCartorio = drprocessos["DataStatusCartorio"].ToString();
                        //processos.H_DataStatus = drprocessos["DataStatus"].ToString();

                        #endregion

                        #region Cliente
                        processos.Id_cliente = drprocessos["idCliente"].ToString();
                        processos.Nome_cliente = drprocessos["clinome"].ToString();
                        //processos.Email_cliente = drprocessos["EmailCli"].ToString();
                        //processos.Telefone_cliente = drprocessos["Telefonecli"].ToString();
                        //processos.Celular_cliente = drprocessos["celularcli"].ToString();
                        //processos.CPF_cliente = drprocessos["cpfcli"].ToString();
                        //processos.RG_cliente = drprocessos["rgcli"].ToString();
                        //processos.Nascimento_cliente = drprocessos["Nascimento"].ToString();
                        //processos.Renda_cliente = drprocessos["rendacli"].ToString();
                        //processos.Agencia_cliente = drprocessos["agenciacli"].ToString();
                        //processos.Conta_cliente = drprocessos["contacli"].ToString();
                        #endregion


                        #region Vendedor
                        //processos.Id_vendedor = drprocessos["idVendedor"].ToString();
                        //processos.Nome_vendedor = drprocessos["vendnome"].ToString();
                        //processos.Email_vendedor = drprocessos["Emailvendedor"].ToString();
                        //processos.Telefone_vendedor = drprocessos["Telefonevendedor"].ToString();
                        //processos.Celular_vendedor = drprocessos["celularvendedor"].ToString();
                        //processos.CPF_vendedor = drprocessos["cpfvendedor"].ToString();
                        //processos.CNPJ_vendedor = drprocessos["cnpjvendedor"].ToString();
                        //processos.Nascimento_vendedor = drprocessos["Nascimento"].ToString();
                        //processos.Renda_vendedor = drprocessos["rendavendedor"].ToString();
                        //processos.Agencia_vendedor = drprocessos["agenciavendedor"].ToString();
                        //processos.Conta_vendedor = drprocessos["contavendedor"].ToString();
                        #endregion

                        #region imovel
                        processos.Id_corretora = drprocessos["idCorretora"].ToString();
                        processos.Id_corretor = drprocessos["idCorretor"].ToString();
                        processos.Descricao_corretora = drprocessos["Corretora"].ToString();
                        processos.Nome_corretor = drprocessos["Corretor"].ToString();


                        #endregion
                        listprocessos.Add(processos);
                    }
                }
                drprocessos.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter processosos: " + err.Message);
            }

            return listprocessos;
        }

        public List<Cliente> GetClientes(String nome)
        
        {
            var list = new List<Cliente>();

            cmd2.CommandText = "SELECT Clientes.id, Nome, Email, Telefone, Celular, CPF, RG, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Renda, Status, Agencia, Conta FROM Clientes Left join Conta on Conta.idcliente = Clientes.id and Conta.Tipo = @tipo WHERE Nome LIKE @nomeclientes";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeclientes", "%" + nome + "%");
            cmd2.Parameters.AddWithValue("@tipo", "C");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con2.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Cliente clients = new Cliente();
                    clients.Id_cliente = drclients["id"].ToString();
                    clients.Nome_cliente = drclients["Nome"].ToString();
                    clients.Email_cliente = drclients["Email"].ToString();
                    clients.Telefone_cliente = drclients["Telefone"].ToString();
                    clients.Celular_cliente = drclients["Celular"].ToString();
                    clients.CPF_cliente = drclients["CPF"].ToString();
                    clients.RG_cliente = drclients["RG"].ToString();
                    clients.StatusCPF_cliente = drclients["StatusCPF"].ToString();
                    clients.StatusCiweb_cliente = drclients["Ciweb"].ToString();
                    clients.StatusCadmut_cliente = drclients["Cadmut"].ToString();
                    clients.StatusIR_cliente = drclients["IR"].ToString();
                    clients.StatusFGTS_cliente = drclients["FGTS"].ToString();
                    clients.RG_cliente = drclients["RG"].ToString();
                    clients.Nascimento_cliente = drclients["Nascimento"].ToString();
                    clients.Sexo_cliente = drclients["Sexo"].ToString();
                    clients.Status_cliente = drclients["Status"].ToString();
                    clients.Renda_cliente = drclients["Renda"].ToString();
                    clients.Agencia_cliente = drclients["Agencia"].ToString();
                    clients.Conta_cliente = drclients["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    list.Add(clients);
                }
                drclients.Close();
                con2.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Vendedor> GetVendedor(String nome)

        {
            var list = new List<Vendedor>();

            cmd2.CommandText = "SELECT Vendedor.id as id, Nome, Email, Telefone, Celular, CPF, CNPJ, Conta.Agencia, Conta.Conta FROM Vendedor Left join Conta on Vendedor.id = Conta.idcliente WHERE Nome LIKE @nomeclientes and Conta.Tipo = @tipo";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeclientes", "%" + nome + "%");
            cmd2.Parameters.AddWithValue("@tipo", "V");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con2.conectar();
                drvebdedor = cmd2.ExecuteReader();
                while (drvebdedor.Read())
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.Id_vendedor = drvebdedor["id"].ToString();
                    vendedor.Nome_vendedor = drvebdedor["Nome"].ToString();
                    vendedor.Email_vendedor = drvebdedor["Email"].ToString();
                    vendedor.Telefone_vendedor = drvebdedor["Telefone"].ToString();
                    vendedor.Celular_vendedor = drvebdedor["Celular"].ToString();
                    vendedor.CPF_vendedor = drvebdedor["CPF"].ToString();
                    vendedor.CNPJ_vendedor = drvebdedor["CNPJ"].ToString();
                    //vendedor.StatusCPF_vendedor = drvebdedor["StatusCPF"].ToString();
                    //vendedor.StatusCiweb_vendedor = drvebdedor["Ciweb"].ToString();
                    //vendedor.StatusCadmut_vendedor = drvebdedor["Cadmut"].ToString();
                    //vendedor.StatusIR_vendedor = drvebdedor["IR"].ToString();
                    //vendedor.StatusFGTS_vendedor = drvebdedor["FGTS"].ToString();
                    //vendedor.RG_vendedor = drvebdedor["RG"].ToString();
                    //vendedor.Nascimento_vendedor = drvebdedor["Nascimento"].ToString();
                    //vendedor.Sexo_vendedor = drvebdedor["Sexo"].ToString();
                    //vendedor.Status_vendedor = drvebdedor["Status"].ToString();
                    //vendedor.Renda_vendedor = drvebdedor["Renda"].ToString();
                    vendedor.Agencia_vendedor = drvebdedor["Agencia"].ToString();
                    vendedor.Conta_vendedor = drvebdedor["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //vendedor.Foto_Func = (Byte[])(drvebdedor["Foto"]);
                    list.Add(vendedor);
                }
                drvebdedor.Close();
                con2.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            //return client;
            return list;
        }
        public String CriarProcesso(String idCliente, String idVendedor, String idresponsavel, String idCorretora, String idCorretor, String status)
        {

            try
            {

                cmd1.CommandText = "INSERT INTO Processos (idCliente, idVendedor, idresponsavel, idCorretora, idCorretor, Data, Status) VALUES " +
                "(@idCliente, @idVendedor, @idresponsavel, @idCorretora, @idCorretor, @Data, @Status) ";

                cmd1.Parameters.AddWithValue("@idCliente", idCliente);
                cmd1.Parameters.AddWithValue("@idVendedor", idVendedor);
                cmd1.Parameters.AddWithValue("@idresponsavel", idresponsavel);
                cmd1.Parameters.AddWithValue("@idCorretora", idCorretora);
                cmd1.Parameters.AddWithValue("@idCorretor", idCorretor);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                cmd1.Parameters.AddWithValue("@Status", status);


                cmd1.Connection = conn.conectar();
                //drupdatecli = cmd1.ExecuteReader();
                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Processo Adicionado Com Sucesso";
                }
                else
                {
                    mensagem = "Erro ao Adicionar Processo";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Adicionar o Processo: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateProcesso(String id, String scpf, String sciweb, String scadmut, String sir, String sfgts, DateTime datastatuscpf, DateTime datastatusciweb, DateTime datastatuscadmut, DateTime datastatusir, DateTime datastatusfgts, DateTime datastatusanalise, DateTime datastatuseng, DateTime datasiopi, DateTime datasictd, DateTime datasaquefgts, DateTime datapa, String valorimovel, String valorfinanciado, DateTime datastatuscartorio, DateTime datastatus, String status)
        {

            try
            {
                cmd1.CommandText = "UPDATE Processos " +
                    //"INNER JOIN  H_Status ON PID = H_Status.idprocesso " +
                "SET Status = @Status, StatusCPF = @cpf, StatusCiweb = @Ciweb, StatusCadmut = @Cadmut, StatusIR = @IR, StatusFGTS = @FGTS , " +
                "DataStatusCPF = @DataStatusCPF, DataStatusCiweb = @DataStatusCiweb, DataStatusCadmut = @DataStatusCadmut, DataStatusIR = @DataStatusIR, DataStatusFGTS = @DataStatusFGTS, " +
                "DataStatusAnalise = @DataStatusAnalise, DataStatusEng = @DataStatusEng, DataSaqueFGTS = @DataStatussaquefgts, DataSIOP = @DataStatussiopi, DataSICTD = @DataStatussictd, DataPA = @DataStatuspa, " +
                "ValorImovel = @valorimovel, ValorFinanciado = @valorfinanciado, " +
                "DataStatusCartorio = @DataStatusCartorio, DataStatus = @DataStatus WHERE id = @Id ";
                cmd1.Parameters.AddWithValue("@Id", id);
                cmd1.Parameters.AddWithValue("@cpf", scpf);
                cmd1.Parameters.AddWithValue("@Ciweb", sciweb);
                cmd1.Parameters.AddWithValue("@Cadmut", scadmut);
                cmd1.Parameters.AddWithValue("@IR", sir);
                cmd1.Parameters.AddWithValue("@FGTS", sfgts);
                cmd1.Parameters.AddWithValue("@DataStatusCPF", datastatuscpf);
                cmd1.Parameters.AddWithValue("@DataStatusCiweb", datastatusciweb);
                cmd1.Parameters.AddWithValue("@DataStatusCadmut", datastatuscadmut);
                cmd1.Parameters.AddWithValue("@DataStatusIR", datastatusir);
                cmd1.Parameters.AddWithValue("@DataStatusFGTS", datastatusfgts);
                cmd1.Parameters.AddWithValue("@DataStatusAnalise", datastatusanalise);
                cmd1.Parameters.AddWithValue("@DataStatusEng", datastatuseng);
                cmd1.Parameters.AddWithValue("@DataStatussiopi", datasiopi);
                cmd1.Parameters.AddWithValue("@DataStatussictd", datasictd);
                cmd1.Parameters.AddWithValue("@DataStatussaquefgts", datasaquefgts);
                cmd1.Parameters.AddWithValue("@DataStatuspa", datapa);

                cmd1.Parameters.AddWithValue("@valorimovel", valorimovel);
                cmd1.Parameters.AddWithValue("@valorfinanciado", valorfinanciado);


                cmd1.Parameters.AddWithValue("@DataStatusCartorio", datastatuscartorio);
                cmd1.Parameters.AddWithValue("@DataStatus", datastatus);
                cmd1.Parameters.AddWithValue("@Status", status);


                cmd1.Connection = conn.conectar();
                //drupdatecli = cmd1.ExecuteReader();
                int recordsAffected = cmd1.ExecuteNonQuery();

                if(recordsAffected > 0) {
                    mensagem = "Processo Alterado Com Sucesso";
                }
                else
                {
                    mensagem = "Erro ao Alterar Processo";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Alterar Processo: " + err.Message);
            }

            return mensagem;
        }
        
        public string AlterarSenha(String id, String login, String senha, String novasenha)
        {



            try
            {
                cmd1.CommandText = "UPDATE Login SET Senha = @novasenha WHERE id = @Id";
                cmd1.Parameters.AddWithValue("@Id", id);
                //cmd1.Parameters.AddWithValue("@login", login);
                // cmd1.Parameters.AddWithValue("@senha", senha);
                cmd1.Parameters.AddWithValue("@novasenha", novasenha);
                cmd1.Connection = conn.conectar();
                drsenha = cmd1.ExecuteReader();
                while (drsenha.Read())
                {
                    mensagem = "Senha Alterado Com Sucesso";
                }

                drsenha.Close();
                conn.desconectar();

            }
            catch (MySqlException err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Alterar senha: " + err.Message);
            }

            return mensagem;
        }
        //KryptonComboBox
        public void autoCompletar(ComboBox novoText, String nome)
        {
            cmd2.CommandText = "SELECT Nome FROM Clientes WHERE Nome LIKE @nomeclientes";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeclientes", "%" + nome + "%");

            

            try
            {
                cmd2.Connection = con.conectar();
                dr = cmd2.ExecuteReader();

                novoText.Items.Clear();

                while (dr.Read())
                {
                    //novoText.AutoCompleteCustomSource.Add(dr["Nome"].ToString());
                    novoText.Items.Add(dr["Nome"].ToString());
                }
                dr.Close();
                con.desconectar();
            }
            catch (MySqlException err)
            {
                  MessageBox.Show("Não foi possivel completar" + err.ToString());
            }

        }

        public void autoCompletarVendedor(ComboBox novoText, String nome)
        {
            cmd2.CommandText = "SELECT Nome FROM Vendedor WHERE Nome LIKE @nomeclientes";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeclientes", "%" + nome + "%");



            try
            {
                cmd2.Connection = con.conectar();
                dr = cmd2.ExecuteReader();

                novoText.Items.Clear();

                while (dr.Read())
                {
                    //novoText.AutoCompleteCustomSource.Add(dr["Nome"].ToString());
                    novoText.Items.Add(dr["Nome"].ToString());
                }
                dr.Close();
                con.desconectar();
            }
            catch (MySqlException err)
            {
                MessageBox.Show("Não foi possivel completar" + err.ToString());
            }

        }
    }
}
