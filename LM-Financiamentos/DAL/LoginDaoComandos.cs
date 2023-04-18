using LMFinanciamentos.Entidades;
using LMFinanciamentos.Modelo;
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
        private const string V = "MM/dd/yyyy";
        public bool tem = false;
        public string mensagem = "";
        private String slogin;
        private String idcliente, newempre;

        private static string _server;

        public string server
        {
            get => _server;
            set => _server = value;
        }
        public string sloginn
        {
            get { return slogin; }
            set { slogin = value; }

        }

        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd1 = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        Conecxao con = new Conecxao(_server);


        MySqlDataReader dr, drfunc, drsenha, drclient, drclients, drprocess, drvendedor, drprocessos, drdocumentos, drvendedores, drconjuge, drempreendimentos, drconstrutora, drcorretor;

        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "Select * From login where Login =@login and Senha =@senha";
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
                tem = false;
            }

            return tem;
        }

        public Processo GetProcesso(String idprocess)
        {
            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , ValorImovel, ValorFinanciado, P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS,  " +
                "P.StatusAnalise as	StatusAnalise, P.RespAprovacao as RespAprovacao, P.StatusEng as StatusEng, P.SaqueFGTS as SaqueFGTS, P.SIOPI as SIOPI, P.SICTD as SICTD, P.StatusPA as StatusPA, P.StatusCartorio as StatusCartorio, " +
                "clientes.id as idCliente, clientes.Nome as clinome, clientes.Email as EmailCli,  clientes.Telefone as Telefonecli , clientes.Celular as celularcli, clientes.CPF as cpfcli, clientes.RG as rgcli, conta.Agencia as agenciacli, conta.Conta as contacli, clientes.Nascimento as Nascimento, clientes.Renda as rendacli, clientes.RendaBruta as rendabruta, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, CV.Agencia as agenciavendedor, CV.Conta as contavendedor,   " +
                "construtora.Descricao as Construtora, corretores.Nome as Corretor, P.idConstrutora, P.idCorretor, agencia.id as idAgenciaImovel, CONCAT(agencia.Agencia,' - ',agencia.Descricao) as AgenciaImovel, programa.id as idPrograma, programa.Descricao as DescriPrograma, agencia.Agencia as AgenciaImovel, programa.Descricao as Programa, empreendimentos.Descricao as EmpDescricao, empreendimentos.id as Empreid, P.idCartorio as idCartorio, cartorio.Descricao as sCartorio, cartorio.Endereco as endCartorio, P.StatusCartorio as StatusCartorio,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataValidadeStatusAnalise, P.DataStatusEng, P.DataSaqueFGTS, P.DataSIOP, P.DataSICTD, P.DataPA, P.DataStatusCartorio, P.DataStatus   " +

                "FROM processos P " +
                "inner join clientes on clientes.id = P.idCliente " +
                "inner join vendedor V on V.id = P.idVendedor " +
                "inner join funcionarios F on F.id = P.idresponsavel " +
                "Left join conta on conta.idcliente = clientes.id and conta.Tipo =@tipo  " +
                "Left join conta CV on CV.idcliente = V.id and CV.Tipo =@tipov  " +
                "Left join agencia on P.idAgenciaImovel = agencia.id " +
                "Left join programa on P.idPrograma = programa.id " +
                "Left join empreendimentos on P.idEmpreendimento = empreendimentos.id " +
                "Left join construtora on P.idConstrutora = construtora.id " +
                "Left join corretores on P.idCorretor = corretores.id " +
                "Left join cartorio on P.idCartorio = cartorio.id " +
                "WHERE P.id = @idprocesso";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idprocesso", idprocess);
            cmd.Parameters.AddWithValue("@tipo", "C");
            cmd.Parameters.AddWithValue("@tipov", "V");
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
                    process.RespAprovacao_cliente = drprocess["RespAprovacao"].ToString();
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
                    process.H_DataValidadeStatusAnalise = drprocess["DataValidadeStatusAnalise"].ToString();
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
                    //process.CPF_cliente = drprocess["cpfcli"].ToString();
                    process.CPF_cliente = FormatCnpjCpf.FormatCPF(drprocess["cpfcli"].ToString());
                    //process.RG_cliente = drprocess["rgcli"].ToString();
                    process.RG_cliente = FormatCnpjCpf.FormatRG(drprocess["rgcli"].ToString());
                    process.Nascimento_cliente =  Convert.ToDateTime(drprocess["Nascimento"]).ToString("dd/MM/yyyy");
                    //process.Nascimento_cliente = drprocess["Nascimento"].ToString();
                    process.Renda_cliente = drprocess["rendacli"].ToString();
                    process.RendaBruta_cliente = drprocess["rendabruta"].ToString();
                    process.Agencia_cliente = drprocess["agenciacli"].ToString();
                    process.Conta_cliente = drprocess["contacli"].ToString();
                    #endregion


                    #region Vendedor
                    process.Id_vendedor = drprocess["idVendedor"].ToString();
                    process.Nome_vendedor = drprocess["vendnome"].ToString();
                    process.Email_vendedor = drprocess["Emailvendedor"].ToString();
                    process.Telefone_vendedor = drprocess["Telefonevendedor"].ToString();
                    process.Celular_vendedor = drprocess["celularvendedor"].ToString();
                    //process.CPF_vendedor = drprocess["cpfvendedor"].ToString();
                    process.CPF_vendedor = FormatCnpjCpf.FormatCPF(drprocess["cpfvendedor"].ToString());
                    //process.CNPJ_vendedor = drprocess["cnpjvendedor"].ToString();
                    process.CNPJ_vendedor = FormatCnpjCpf.FormatCNPJ(drprocess["cnpjvendedor"].ToString());
                    //process.Nascimento_vendedor = drprocess["Nascimento"].ToString();
                    //process.Renda_vendedor = drprocess["rendavendedor"].ToString();
                    process.Agencia_vendedor = drprocess["agenciavendedor"].ToString();
                    process.Conta_vendedor = drprocess["contavendedor"].ToString();
                    #endregion

                    #region imovel
                    process.Id_construtora = drprocess["idConstrutora"].ToString();
                    process.Id_corretor = drprocess["idCorretor"].ToString();
                    process.Nome_corretor = drprocess["Corretor"].ToString();
                    process.Descricao_construtora = drprocess["Construtora"].ToString();


                    process.Id_AgenciaImovel = drprocess["idAgenciaImovel"].ToString();
                    process.Id_Programa = drprocess["idPrograma"].ToString();

                    process.AgenciaImovel_imovel = drprocess["AgenciaImovel"].ToString();
                    process.Programa_imovel = drprocess["DescriPrograma"].ToString();

                    process.Valor_imovel = drprocess["ValorImovel"].ToString();
                    process.ValorFinanciado_imovel = drprocess["ValorFinanciado"].ToString();


                    process.id_Empreendimentos_imovel = drprocess["Empreid"].ToString();
                    process.EmpDescricao_imovel = drprocess["EmpDescricao"].ToString();


                    #endregion

                    #region Cartorio  
                    process.id_Carftorio = drprocess["idCartorio"].ToString();
                    process.Descricao_Carftorio = drprocess["sCartorio"].ToString();
                    process.end_Cartorio = drprocess["endCartorio"].ToString();
                    process.StatusCartorio = drprocess["StatusCartorio"].ToString();

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

        public String UpdateCliente(String id, String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String rendabruta, String observacao)
        {


            try
            {
                cmd.CommandText = "UPDATE clientes " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, RG = @rg, Nascimento = @nascimento, Sexo = @sexo, Status = @status, Renda = @renda, RendaBruta = @rendabruta, Observacao = @observacao " +
                "WHERE clientes.id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@renda", renda);
                cmd.Parameters.AddWithValue("@rendabruta", rendabruta);
                cmd.Parameters.AddWithValue("@observacao", observacao);



                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cliente Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Cliente";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar Cliente: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateFuncionario(String id, String nome, String email, String telefone, String celular, String endereco, DateTime nascimento, String sexo, String cpf, String rg, String cracha, String login, String permission, String status)
        {


            try
            {
                cmd.CommandText = "UPDATE funcionarios " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, Endereco = @endereco, Nascimento = @nascimento, Sexo = @sexo, CPF = @cpf, RG = @rg, Cracha = @cracha, Login = @login, Permission = @permission, Status = @status " +
                "WHERE funcionarios.id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cracha", cracha);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@permission", permission);
                cmd.Parameters.AddWithValue("@status", status);



                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Funcionário Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Funcionário";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar Funcionário: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateVendedor(String id, String nome, String cpf, String cnpj, String email, String telefone, String celular, String status)
        {


            try
            {
                cmd.CommandText = "UPDATE vendedor " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, CNPJ =@cnpj,  Status = @status " +
                "WHERE vendedor.id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                //cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                //cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@status", status);
                //cmd.Parameters.AddWithValue("@conta", conta);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Vendedor Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Vendedor";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar Vendedor: " + err.Message);
            }

            return mensagem;

        }
        public String InsertConta(String id, String agencia, String conta, String tipo, String idconjuge, String sequencia)
        {


            try
            {
                cmd.CommandText = "INSERT INTO conta (idcliente, Agencia, Conta, Tipo, idconjuge, Sequencia) VALUES (@id, @agencia, @conta, @tipo, @idconjuge, @sequencia)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@conta", conta);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@idconjuge", idconjuge);
                cmd.Parameters.AddWithValue("@sequencia", sequencia);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Inserir Conta!";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Inserir a Conta!: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateConta(String id, String agencia, String conta, String tipo)
        {


            try
            {
                cmd.CommandText = "UPDATE conta " +
                "SET Agencia = @agencia, Conta = @conta " +
                "WHERE conta.idcliente = @id AND Tipo = @tipo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@conta", conta);
                cmd.Parameters.AddWithValue("@tipo", tipo);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar a Conta Vendedor!: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateContaConjuge(String id, String agencia, String conta, String tipo)
        {


            try
            {
                cmd.CommandText = "UPDATE conta " +
                "SET Agencia = @agencia, Conta = @conta " +
                "WHERE conta.idconjuge = @id AND Tipo = @tipo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@conta", conta);
                cmd.Parameters.AddWithValue("@tipo", tipo);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar a Conta Vendedor!: " + err.Message);
            }

            return mensagem;
        }
        public String InsertFotoVendedor(String id, Byte[] foto, String descricao)
        {


            try
            {
                cmd.CommandText = "INSERT INTO foto(idVendedor, Foto, Descricao) VALUES (@id,@foto,@descricao)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@descricao", descricao);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Inserir foto do Vendedor";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Inserir a Foto do Vendedor!: " + err.Message);
            }

            return mensagem;
        }
        public String InsertFotoCliente(String id, Byte[] foto, String descricao)
        {


            try
            {
                cmd.CommandText = "INSERT INTO foto(idCliente, Foto, Descricao) VALUES (@id,@foto,@descricao)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@descricao", descricao);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Inserir Foto do Cliente";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Inserir a Foto do Cliente!: " + err.Message);
            }

            return mensagem;
        }
        public String InsertFotoFuncionario(String id, Byte[] foto, String descricao)
        {


            try
            {
                cmd.CommandText = "INSERT INTO foto(idFunc, Foto, Descricao) VALUES (@id,@foto,@descricao)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@descricao", descricao);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Inserir Foto do Funcionário";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Inserir a Foto do Funcionário!: " + err.Message);
            }

            return mensagem;
        }
        public String DeleteFotoCliente(String id)
        {


            try
            {
                cmd.CommandText = "DELETE FROM foto WHERE idCliente = @id; ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Excluido";
                }
                else
                {
                    mensagem = "Erro ao Excluir Foto do Cliente";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Excluir a Foto do Cliente!: " + err.Message);
            }

            return mensagem;
        }
        public String DeleteFotoVendedor(String id)
        {


            try
            {
                cmd.CommandText = "DELETE FROM foto WHERE idVendedor = @id; ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Excluido";
                }
                else
                {
                    mensagem = "Erro ao Excluir Foto do Vendedor";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Excluir a Foto do Vendedor!: " + err.Message);
            }

            return mensagem;
        }
        public String DeleteFotoFuncionario(String id)
        {


            try
            {
                cmd.CommandText = "DELETE FROM foto WHERE idFunc = @id; ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Excluido";
                }
                else
                {
                    mensagem = "Erro ao Excluir Foto do Funcionario";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Excluir a Foto do Funcionário!: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateFotoCliente(String id, Byte[] foto)
        {


            try
            {
                cmd.CommandText = "UPDATE foto " +
                "SET Foto = @foto " +
                "WHERE foto.idCliente = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Foto do Cliente";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar a Foto Cliente!: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateFotoVendedor(String id, Byte[] foto)
        {


            try
            {
                cmd.CommandText = "UPDATE foto " +
                "SET Foto = @foto " +
                "WHERE foto.idVendedor = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Foto do Vendedor";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar a Foto Vendedor!: " + err.Message);
            }

            return mensagem;
        }
        public String UpdateFotoFuncionario(String id, Byte[] foto)
        {


            try
            {
                cmd.CommandText = "UPDATE foto " +
                "SET Foto = @foto " +
                "WHERE foto.idFunc = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@foto", foto);

                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "OK";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Foto do Funcionario";
                }

                con.desconectar();
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Atualizar a Foto Funcionario!: " + err.Message);
            }

            return mensagem;
        }
        public int CadastrarCliente(String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String rendabruta, String observacao, bool conjuge)
        {


            try
            {
                cmd.CommandText = "INSERT INTO clientes (Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Status, Renda, RendaBruta, Observacao, Conjuge) Values  (@nome, @email, @telefone, @celular, @cpf, @rg, @nascimento, @sexo, @status, @renda, @rendabruta, @observacao, @conjuge)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                //cmd.Parameters.AddWithValue("@statuscpf", statuscpf);
                //cmd.Parameters.AddWithValue("@stciweb", stciweb);
                //cmd.Parameters.AddWithValue("@stcadmut", stcadmut);
                //cmd.Parameters.AddWithValue("@stir", stir);
                //cmd.Parameters.AddWithValue("@stfgts", stfgts);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@renda", renda);
                cmd.Parameters.AddWithValue("@rendabruta", rendabruta);
                cmd.Parameters.AddWithValue("@observacao", observacao);
                cmd.Parameters.AddWithValue("@conjuge", conjuge);




                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

                //if (recordsAffected > 0)
                //{
                //    mensagem = "Documento Adicionado Com Sucesso";
                //}
                //else
                //{
                //    mensagem = "Erro ao Adicionar Documento";
                //}


            }
            //catch (MySqlException error)
            //{
            //    mensagem = ("Erro ao conectar: " + error.Message);
            //}
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                //mensagem = ("Erro ao Adicionar o Documento: " + err.Message);
                throw err;
            }
            finally
            {
                con.desconectar();
            }

            //return mensagem;
        }
        public int CadastrarAgencia(String descricao, String agencia, String end)
        {


            try
            {
                cmd.CommandText = "INSERT INTO agencia (Descricao, Agencia, Endereco) Values  (@descri, @agencia, @endereco)";

                cmd.Parameters.AddWithValue("@descri", descricao);
                cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@endereco", end);
 

                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

            }

            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }
        public int CadastrarEmpreendimento(String descricao, String end)
        {


            try
            {
                cmd.CommandText = "INSERT INTO empreendimentos (Descricao,  Endereco) Values  (@descri, @endereco)";

                cmd.Parameters.AddWithValue("@descri", descricao);
                cmd.Parameters.AddWithValue("@endereco", end);


                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

            }

            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }
        public string UpdateEmpreendimento(String id, String descricao, String end)
        {


            try
            {
                cmd.CommandText = "UPDATE empreendimentos SET  Descricao = @descri, Endereco = @endereco WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descri", descricao);
                //cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@endereco", end);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Empreendimento Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar o Empreendimento: " + err.Message);
            }

            return mensagem;

        }
        public string UpdateAgencia(String id, String descricao, String agencia, String end)
        {


            try
            {
                cmd.CommandText = "UPDATE agencia SET  Descricao = @descri, Endereco = @endereco, Agencia = @agencia WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descri", descricao);
                cmd.Parameters.AddWithValue("@agencia", agencia);
                cmd.Parameters.AddWithValue("@endereco", end);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Agência Atualizada com Sucesso!";
                }
                else
                {
                    mensagem = "Erro";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar a Agência: " + err.Message);
            }

            return mensagem;

        }

        public int CadastrarConjuge(String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String observacao, String idcliente, String sequencia, bool conjuge)
        {


            try
            {
                cmd.CommandText = "INSERT INTO conjuge (Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Status, Renda, Observacao, idCliente, Sequencia, Conjuge) Values  (@nome, @email, @telefone, @celular, @cpf, @rg, @nascimento, @sexo, @status, @renda, @observacao, @idcliente, @sequencia, @conjuge)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@renda", renda);
                cmd.Parameters.AddWithValue("@observacao", observacao);
                cmd.Parameters.AddWithValue("@idcliente", idcliente);
                cmd.Parameters.AddWithValue("@sequencia", sequencia);
                cmd.Parameters.AddWithValue("@conjuge", conjuge);


                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

                //if (recordsAffected > 0)
                //{
                //    mensagem = "Documento Adicionado Com Sucesso";
                //}
                //else
                //{
                //    mensagem = "Erro ao Adicionar Documento";
                //}


            }
            //catch (MySqlException error)
            //{
            //    mensagem = ("Erro ao conectar: " + error.Message);
            //}
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                //mensagem = ("Erro ao Adicionar o Documento: " + err.Message);
                throw err;
            }
            finally
            {
                con.desconectar();
            }

            //return mensagem;

        }
        public string UpdateConjuge(String idconjuge, String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String observacao, String idcliente, String sequencia, bool conjuge)
        {


            try
            {
                cmd.CommandText = "UPDATE conjuge " +
               "SET Nome = @nome , Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, RG = @rg, Nascimento = @nascimento, Sexo = @sexo, Status = @status, Renda = @renda, Observacao = @observacao, idCliente = @idcliente, Sequencia = @sequencia, Conjuge = @conjuge " +
               "WHERE conjuge.id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idconjuge);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@renda", renda);
                cmd.Parameters.AddWithValue("@observacao", observacao);
                cmd.Parameters.AddWithValue("@idcliente", idcliente);
                cmd.Parameters.AddWithValue("@sequencia", sequencia);
                cmd.Parameters.AddWithValue("@conjuge", conjuge);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Conjuge Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Conjuge";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar Conjuge: " + err.Message);
            }

            return mensagem;

        }
        public int CadastrarFuncionario(String nome, String email, String telefone, String celular, String endereco, DateTime nascimento, String sexo, String cpf, String rg, String cracha, String permission, String status)
        {
            try
            {
                cmd.CommandText = "INSERT INTO funcionarios (Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Permission, Status) Values  " +
                    "(@nome, @email, @telefone, @celular, @endereco, @nascimento, @sexo, @cpf, @rg, @cracha, @permission, @status)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@nascimento", nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cracha", cracha);
                //cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@permission", permission);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);


            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }
        }
        public int CadastrarVendedor(String nome, String email, String telefone, String celular, String cpf, String cnpj, String status)
        {


            try
            {
                cmd.CommandText = "INSERT INTO vendedor (Nome, Email, Telefone, Celular, CPF, CNPJ,   Status ) Values  (@nome, @email, @telefone, @celular, @cpf, @cnpj, @status)";

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                //cmd.Parameters.AddWithValue("@statuscpf", statuscpf);
                //cmd.Parameters.AddWithValue("@stciweb", stciweb);
                //cmd.Parameters.AddWithValue("@stcadmut", stcadmut);
                //cmd.Parameters.AddWithValue("@stir", stir);
                //cmd.Parameters.AddWithValue("@stfgts", stfgts);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                //cmd.Parameters.AddWithValue("@nascimento", nascimento);
                //cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);
                //cmd.Parameters.AddWithValue("@renda", renda);

                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

                //if (recordsAffected > 0)
                //{
                //    mensagem = "Documento Adicionado Com Sucesso";
                //}
                //else
                //{
                //    mensagem = "Erro ao Adicionar Documento";
                //}


            }
            //catch (MySqlException error)
            //{
            //    mensagem = ("Erro ao conectar: " + error.Message);
            //}
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                //mensagem = ("Erro ao Adicionar o Documento: " + err.Message);
                throw err;
            }
            finally
            {
                con.desconectar();
            }

            //return mensagem;
        }
        public int CadastrarLogin(String login, String senha)
        {


            try
            {
                cmd.CommandText = "INSERT INTO Login (Login, Senha) Values  (@login, @senha)";

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);


            }

            catch (MySqlException err)
            {
                if (err.Number == 1062) // Cannot insert duplicate key row in object error
                    return 99999;
                else
                {
                    // Handle duplicate key error
                    throw; //
                }
            }
            finally
            {
                con.desconectar();
            }
        }
        public int GetidCliente(String idconjuge)
        {


            try
            {
                cmd.CommandText = "SELECT idCliente FROM conjuge WHERE id = @idconjuge  ";

                cmd.Parameters.AddWithValue("@idconjuge", idconjuge);


                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();
                drclient = cmd.ExecuteReader();

                
                while (drclient.Read())
                {
                    idcliente = drclient["idCliente"].ToString();
                }
                


                return Convert.ToInt32(idcliente);
                drclient.Close();

            }

            catch (MySqlException err)
            {
                if (err.Number == 1062) // Cannot insert duplicate key row in object error
                    return 99999;
                else
                {
                    // Handle duplicate key error
                    throw; //
                }
            }
            finally
            {
                con.desconectar();
            }
        }
        public Cliente GetCPFCliente(String cpf)
        {

            cmd.CommandText = "SELECT clientes.id, Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Renda, Status, clientes.Observacao, clientes.Conjuge FROM clientes " +
                
                "WHERE clientes.CPF = @cpf  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@tipo", "C");
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
                    client.CPF_cliente = FormatCnpjCpf.FormatCPF(drclient["CPF"].ToString());
                    //client.Agencia_cliente = drclient["Agencia"].ToString();
                    //client.Conta_cliente = drclient["Conta"].ToString();
                    //client.StatusCadmut_cliente = drclient["Cadmut"].ToString();
                    //client.StatusIR_cliente = drclient["IR"].ToString();
                    //client.StatusFGTS_cliente = drclient["FGTS"].ToString();
                    client.RG_cliente = FormatCnpjCpf.FormatRG(drclient["RG"].ToString());
                    //client.RG_cliente = drclient["RG"].ToString();
                    client.Nascimento_cliente = drclient["Nascimento"].ToString();
                    client.Sexo_cliente = drclient["Sexo"].ToString();
                    client.Status_cliente = drclient["Status"].ToString();
                    client.Renda_cliente = drclient["Renda"].ToString();
                    client.OBS_cliente = drclient["Observacao"].ToString();
                    client.Conjuge_cliente = bool.Parse(drclient["Conjuge"].ToString());


                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    //list.Add(client);
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter CPF: " + err.Message);
            }

            return client;
        }
        public Agencia GetNumAgencia(String ag)
        {

            cmd.CommandText = "SELECT * FROM agencia " +

                "WHERE agencia.Agencia = @ag  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ag", ag);
            Agencia agencia = new Agencia();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    agencia.Id_agencia = drclient["id"].ToString();
                    agencia.Descri_agencia = drclient["Descricao"].ToString();
                    agencia.Num_Agencia = drclient["Agencia"].ToString();
                    agencia.End_Agencia = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return agencia;
        }
        public List<Empreendimento> GetEmpreendimentosM(String empre)

        {
            var list = new List<Empreendimento>();

            cmd.CommandText = "SELECT * FROM empreendimentos WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            //Cliente clients = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclients = cmd.ExecuteReader();
                while (drclients.Read())
                {
                    Empreendimento emprrendimento = new Empreendimento();
                    emprrendimento.Id_empreendimentos = drclients["id"].ToString();
                    emprrendimento.Descri_empreendimentos = drclients["Descricao"].ToString();
                    emprrendimento.End_empreendimentos = drclients["Endereco"].ToString();
                    list.Add(emprrendimento);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Empreendimentos: " + err.Message);
            }
            return list;
        }
        public Empreendimento GetNumEmpreendimento(String empre)
        {

            cmd.CommandText = "SELECT * FROM empreendimentos " +

                "WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            Empreendimento empreendimento = new Empreendimento();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    empreendimento.Id_empreendimentos = drclient["id"].ToString();
                    empreendimento.Descri_empreendimentos = drclient["Descricao"].ToString();
                    //empreendimento.Num_Agencia = drclient["Agencia"].ToString();
                    empreendimento.End_empreendimentos = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return empreendimento;
        }
        public Empreendimento GetEmpreendimento(String id)
        {

            cmd.CommandText = "SELECT * FROM empreendimentos " +

                "WHERE id = @ag  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ag", id);
            Empreendimento empreendimento = new Empreendimento();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    empreendimento.Id_empreendimentos = drclient["id"].ToString();
                    empreendimento.Descri_empreendimentos = drclient["Descricao"].ToString();
                    //ampreendimento.Num_Empreendimentos = drclient["Empreendimento"].ToString();
                    empreendimento.End_empreendimentos = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Empreendimento: " + err.Message);
            }

            return empreendimento;
        }
        public Agencia GetAgencia(String ag)
        {

            cmd.CommandText = "SELECT * FROM agencia " +

                "WHERE agencia.id = @ag  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ag", ag);
            Agencia agencia = new Agencia();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    agencia.Id_agencia = drclient["id"].ToString();
                    agencia.Descri_agencia = drclient["Descricao"].ToString();
                    agencia.Num_Agencia = drclient["Agencia"].ToString();
                    agencia.End_Agencia = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return agencia;
        }


        public Cliente GetCPFClienteEdit(String cpf, String id)
        {

            cmd.CommandText = "SELECT clientes.id, Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Renda, Status, clientes.Observacao, clientes.Conjuge FROM clientes " +

                "WHERE clientes.CPF = @cpf  AND clientes.id != @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", "C");
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
                    client.CPF_cliente = FormatCnpjCpf.FormatCPF(drclient["CPF"].ToString());
                    //client.Agencia_cliente = drclient["Agencia"].ToString();
                    //client.Conta_cliente = drclient["Conta"].ToString();
                    //client.StatusCadmut_cliente = drclient["Cadmut"].ToString();
                    //client.StatusIR_cliente = drclient["IR"].ToString();
                    //client.StatusFGTS_cliente = drclient["FGTS"].ToString();
                    client.RG_cliente = FormatCnpjCpf.FormatRG(drclient["RG"].ToString());
                    //client.RG_cliente = drclient["RG"].ToString();
                    client.Nascimento_cliente = drclient["Nascimento"].ToString();
                    client.Sexo_cliente = drclient["Sexo"].ToString();
                    client.Status_cliente = drclient["Status"].ToString();
                    client.Renda_cliente = drclient["Renda"].ToString();
                    client.OBS_cliente = drclient["Observacao"].ToString();
                    client.Conjuge_cliente = bool.Parse(drclient["Conjuge"].ToString());


                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    //list.Add(client);
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter CPF: " + err.Message);
            }

            return client;
        }
        public Funcionario GetFunc(String login, String senha)
        {
            cmd.CommandText = "Select F.Login as id, F.Nome, L.Login, L.Senha, Permission, Foto from login L left join funcionarios F on F.id = L.id left join foto on foto.idFunc = F.id where L.Login = @login and Senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            Funcionario func = new Funcionario();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    func.Id_Funcionario = drfunc["id"].ToString();
                    func.Nome_Funcionario = drfunc["Nome"].ToString();
                    func.Login_Funcionario = drfunc["Login"].ToString();
                    func.Senha_Funcionario = drfunc["Senha"].ToString();
                    func.Permission_Funcionario = drfunc["Permission"].ToString();

                    if (System.DBNull.Value == drfunc["Foto"])
                    {

                    }
                    else
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        func.Foto_Funcionario = (Byte[])(drfunc["Foto"]);
                    }

                }
                drfunc.Close();
                con.desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter funcionário: " + err.Message);
            }

            return func;
        }
        public Cliente GetFotoCliente(String id)
        {
            cmd.CommandText = "Select clientes.id, F.Descricao, F.Foto From clientes left join foto F on clientes.id = F.IdCliente  where clientes.id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);

            Cliente cli = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    cli.Id_cliente = drfunc["id"].ToString();
                    //cli.descr = drfunc["Descricao"].ToString();
                    if (System.DBNull.Value == drfunc["Foto"])
                    {

                    }
                    else
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        cli.Foto_cliente = (Byte[])(drfunc["Foto"]);
                    }


                }
                drfunc.Close();
                con.desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Foto do cliente: " + err.Message);
            }

            return cli;
        }
        public Vendedor GetFotoVendedor(String id)
        {
            cmd.CommandText = "Select vendedor.id, F.Descricao, F.Foto From vendedor left join foto F on vendedor.id = F.IdVendedor  where vendedor.id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);

            Vendedor vend = new Vendedor();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    vend.Id_vendedor = drfunc["id"].ToString();
                    //cli.descr = drfunc["Descricao"].ToString();
                    if (System.DBNull.Value == drfunc["Foto"])
                    {

                    }
                    else
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        vend.Foto_vendedor = (Byte[])(drfunc["Foto"]);
                    }


                }
                drfunc.Close();
                con.desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Foto do Vendedor: " + err.Message);
            }

            return vend;
        }
        public Funcionario GetFotoFuncionario(String id)
        {
            cmd.CommandText = "Select funcionarios.id, F.Descricao, F.Foto From funcionarios left join foto F on funcionarios.id = F.IdFunc  where funcionarios.id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);

            Funcionario vend = new Funcionario();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    vend.Id_Funcionario = drfunc["id"].ToString();
                    //cli.descr = drfunc["Descricao"].ToString();
                    if (System.DBNull.Value == drfunc["Foto"])
                    {

                    }
                    else
                    {
                        Byte[] byteBLOBData = new Byte[0];
                        vend.Foto_Funcionario = (Byte[])(drfunc["Foto"]);
                    }


                }
                drfunc.Close();
                con.desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Foto do Funcionario: " + err.Message);
            }

            return vend;
        }
        public Cliente GetCliente(String id)
        {
            //var list = new List<Cliente>();

            cmd.CommandText = "SELECT clientes.id, Nome, Email, Telefone, Celular, CPF, C.Agencia, C.Conta, RG, Nascimento, Sexo, Renda, Status, clientes.Observacao, clientes.Conjuge FROM clientes " +
                "Left join conta C on C.idcliente = @id and C.Tipo = @tipo " +
                "WHERE clientes.id = @id  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", "C");
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
                    client.CPF_cliente = FormatCnpjCpf.FormatCPF(drclient["CPF"].ToString());
                    client.Agencia_cliente = drclient["Agencia"].ToString();
                    client.Conta_cliente = drclient["Conta"].ToString();
                    //client.StatusCadmut_cliente = drclient["Cadmut"].ToString();
                    //client.StatusIR_cliente = drclient["IR"].ToString();
                    //client.StatusFGTS_cliente = drclient["FGTS"].ToString();
                    client.RG_cliente = FormatCnpjCpf.FormatRG(drclient["RG"].ToString());
                    //client.RG_cliente = drclient["RG"].ToString();
                    client.Nascimento_cliente = drclient["Nascimento"].ToString();
                    client.Sexo_cliente = drclient["Sexo"].ToString();
                    client.Status_cliente = drclient["Status"].ToString();
                    client.Renda_cliente = drclient["Renda"].ToString();
                    client.OBS_cliente = drclient["Observacao"].ToString();
                    client.Conjuge_cliente = bool.Parse(drclient["Conjuge"].ToString());


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
        public Conjuge GetConjuge(String id, String idconjuge)
        {
            //var list = new List<Cliente>();

            cmd.CommandText = "SELECT conjuge.id, Nome, Email, Telefone, Celular, CPF, C.Agencia, C.Conta, RG, Nascimento, Sexo, Renda, Status, conjuge.Observacao, conjuge.Conjuge FROM conjuge " +
                "Left join conta C on C.idcliente = @id and C.Tipo = @tipo and C.idconjuge = @idconjuge  " +
                "WHERE conjuge.idCliente = @id AND conjuge.id = @idconjuge  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tipo", "CJ");
            cmd.Parameters.AddWithValue("@idconjuge", idconjuge);

            Conjuge conjuge = new Conjuge();
            try
            {
                cmd.Connection = con.conectar();
                drconjuge = cmd.ExecuteReader();
                while (drconjuge.Read())
                {
                    //conjuge client = new conjuge();
                    conjuge.Id_conjuge = drconjuge["id"].ToString();
                    conjuge.Nome_conjuge = drconjuge["Nome"].ToString();
                    conjuge.Email_conjuge = drconjuge["Email"].ToString();
                    conjuge.Telefone_conjuge = drconjuge["Telefone"].ToString();
                    conjuge.Celular_conjuge = drconjuge["Celular"].ToString();
                    conjuge.CPF_conjuge = FormatCnpjCpf.FormatCPF(drconjuge["CPF"].ToString());
                    conjuge.Agencia_conjuge = drconjuge["Agencia"].ToString();
                    conjuge.Conta_conjuge = drconjuge["Conta"].ToString();
                    //conjuge.StatusCadmut_conjuge = drconjuge["Cadmut"].ToString();
                    //conjuge.StatusIR_conjuge = drconjuge["IR"].ToString();
                    //conjuge.StatusFGTS_conjuge = drconjuge["FGTS"].ToString();
                    conjuge.RG_conjuge = FormatCnpjCpf.FormatRG(drconjuge["RG"].ToString());
                    //conjuge.RG_conjuge = drconjuge["RG"].ToString();
                    conjuge.Nascimento_conjuge = drconjuge["Nascimento"].ToString();
                    conjuge.Sexo_conjuge = drconjuge["Sexo"].ToString();
                    conjuge.Status_conjuge = drconjuge["Status"].ToString();
                    conjuge.Renda_conjuge = drconjuge["Renda"].ToString();
                    conjuge.OBS_conjuge = drconjuge["Observacao"].ToString();
                    conjuge.Conjuge_conjuge = bool.Parse(drconjuge["Conjuge"].ToString());


                    //Byte[] byteBLOBData = new Byte[0];
                    //conjuge.Foto_Func = (Byte[])(drconjuge["Foto"]);
                    //list.Add(client);
                }
                drconjuge.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Conjuge: " + err.Message);
            }

            return conjuge;
        }
        public string UpdateCJCliente(String idcli, bool conjuge)
        {


            try
            {
                cmd.CommandText = "UPDATE clientes " +
               "SET  conjuge = @conjuge " +
               "WHERE id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idcli);
                cmd.Parameters.AddWithValue("@conjuge", conjuge);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cliente Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Cliente";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar Cliente: " + err.Message);
            }

            return mensagem;

        }

        public string UpdateRendaBrutaCliente(String idcli, String renda)
        {


            try
            {
                cmd.CommandText = "UPDATE clientes " +
               "SET  RendaBruta = @renda " +
               "WHERE id = @id ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idcli);
                cmd.Parameters.AddWithValue("@renda", renda);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cliente Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro ao Atualizar Cliente";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar Cliente: " + err.Message);
            }

            return mensagem;

        }
        public Funcionario GetFuncionario(String sid)
        {
            //var list = new List<Cliente>();

            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Login, Permission, Status FROM funcionarios WHERE id = @id";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", sid);
            Funcionario func = new Funcionario();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    //Cliente func = new Cliente();
                    func.Id_Funcionario = drfunc["id"].ToString();
                    func.Nome_Funcionario = drfunc["Nome"].ToString();
                    func.Email_Funcionario = drfunc["Email"].ToString();
                    func.Telefone_Funcionario = drfunc["Telefone"].ToString();
                    func.Celular_Funcionario = drfunc["Celular"].ToString();
                    func.Endereco_Funcionario = drfunc["Endereco"].ToString();
                    func.Nascimento_Funcionario = drfunc["Nascimento"].ToString();
                    func.Sexo_Funcionario = drfunc["Sexo"].ToString();
                    func.CPF_Funcionario = FormatCnpjCpf.FormatCPF(drfunc["CPF"].ToString());
                    func.RG_Funcionario = FormatCnpjCpf.FormatRG(drfunc["RG"].ToString());
                    func.Cracha_Funcionario = drfunc["Cracha"].ToString();
                    func.Login_Funcionario = drfunc["Login"].ToString();
                    func.Permision = drfunc["Permission"].ToString();
                    func.Status_Funcionario = drfunc["Status"].ToString();
                    //func.RG_Func = drfunc["RG"].ToString();
                    //func.Renda_func = drfunc["Renda"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //func.Foto_Func = (Byte[])(drfunc["Foto"]);
                    //list.Add(func);
                }
                drfunc.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Funcionário: " + err.Message);
            }

            return func;
        }
        public Servidor GetServer()
        {
            cmd.CommandText = "Select id, ServerNome, ServerFilesPath From configuracoes";
            //cmd.Parameters.AddWithValue("@idprocesso", idprocess);
            //cmd.Parameters.AddWithValue("@tipo", "C");
            Servidor server = new Servidor();
            try
            {
                cmd.Connection = con.conectar();
                drprocess = cmd.ExecuteReader();
                while (drprocess.Read())
                {


                    #region Servidor  

                    server.id_Server = drprocess["id"].ToString();
                    server.Nome_Server = drprocess["ServerNome"].ToString();
                    server.ServerFilesPath_Server = drprocess["ServerFilesPath"].ToString();

                    #endregion

                }
                drprocess.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Configurações: " + err.Message);
            }

            return server;
        }

        public String SaveServer(String id, String ServerNome, String ServerFilesPath)
        {
            try
            {
                cmd1.CommandText = "UPDATE configuracoes " +
                "SET ServerNome = @ServerNome, ServerFilesPath = @ServerFilesPath " +
                "WHERE id = @Id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@Id", id);
                cmd1.Parameters.AddWithValue("@ServerNome", ServerNome);
                cmd1.Parameters.AddWithValue("@ServerFilesPath", ServerFilesPath);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Servidor Alterado Com Sucesso";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Alterar Servidor";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Alterar Servidor: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public List<Agencia> GetAgencias(String consulta)

        {
            var list = new List<Agencia>();

            cmd2.CommandText = "SELECT * FROM agencia WHERE id not LIKE 7 AND (Agencia like @consulta or Descricao like @consulta)";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@consulta", "%" + consulta + "%");
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Agencia agencias = new Agencia();
                    agencias.Id_agencia = drclients["id"].ToString();
                    agencias.Descri_agencia = drclients["Descricao"].ToString();
                    agencias.Num_Agencia = drclients["Agencia"].ToString();
                    agencias.End_Agencia = drclients["Endereco"].ToString();

                    list.Add(agencias);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agências: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Empreendimento> GetEmpreendimentos(String empr)

        {
            var list = new List<Empreendimento>();

            cmd2.CommandText = "SELECT * FROM empreendimentos WHERE Descricao like @var";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@var", "%" + empr + "%");
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Empreendimento empre = new Empreendimento();
                    empre.Id_empreendimentos = drclients["id"].ToString();
                    empre.Descri_empreendimentos = drclients["Descricao"].ToString();
                    empre.End_empreendimentos = drclients["Endereco"].ToString();

                    list.Add(empre);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Empreendimento: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Processo> GetProcessos(String tipo, String tipov, String nome)
        {
            var listprocessos = new List<Processo>();

            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS, P.Status as Status, construtora.Descricao as Construtora, corretores.Nome as Corretor, " +
                "C.id as idCliente, C.Nome as clinome, C.Email as EmailCli,  C.Telefone as Telefonecli , C.Celular as celularcli, C.CPF as cpfcli, C.RG as rgcli, conta.Agencia as agenciacli, conta.Conta as contacli, C.Nascimento as Nascimento, C.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, CV.Agencia as agenciavendedor, CV.Conta as contavendedor,   " +
                "construtora.id as idconstrutora, corretores.id as idCorretor,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataStatusCartorio, P.DataStatus " +

                "FROM processos P " +
                "Left join clientes C on C.id = P.idCliente " +
                "Left join vendedor V on V.id = P.idVendedor " +
                "Left join funcionarios F on F.id = P.idresponsavel " +
                "Left join conta on C.id = conta.idcliente and conta.Tipo =@tipo " +
                "Left join conta CV on V.id = conta.idcliente and conta.Tipo =@tipov " +
                "Left join construtora on P.idConstrutora = construtora.id " +
                "Left join corretores on P.idCorretor = corretores.id " +
                //"Left join P_Status H on P.id = H.idprocesso " +
                "WHERE (C.Nome Like @consulta) or (P.id Like @consulta) " +
                " ORDER BY  P.id ASC "
                ;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@tipov", tipov);
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
                        processos.Data_processo = Convert.ToDateTime(drprocessos["Data"]).ToString("dd/MM/yyyy");
                        //processos.Data_processo = drprocessos["Data"].ToString();
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
                        processos.Agencia_vendedor = drprocessos["agenciavendedor"].ToString();
                        processos.Conta_vendedor = drprocessos["contavendedor"].ToString();
                        #endregion

                        #region imovel
                        processos.Id_construtora = drprocessos["idConstrutora"].ToString();
                        processos.Id_corretor = drprocessos["idCorretor"].ToString();
                        processos.Descricao_construtora = drprocessos["Construtora"].ToString();
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
        public List<Processo> GetProcessosForResp(String tipo, String tipov, String nome,String resp)
        {
            var listprocessos = new List<Processo>();

            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS, P.Status as Status, construtora.Descricao as Construtora, corretores.Nome as Corretor, " +
                "C.id as idCliente, C.Nome as clinome, C.Email as EmailCli,  C.Telefone as Telefonecli , C.Celular as celularcli, C.CPF as cpfcli, C.RG as rgcli, conta.Agencia as agenciacli, conta.Conta as contacli, C.Nascimento as Nascimento, C.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, CV.Agencia as agenciavendedor, CV.Conta as contavendedor,   " +
                "construtora.id as idconstrutora, construtora.Descricao as Descricao, corretores.id as idCorretor,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataStatusCartorio, P.DataStatus " +

                "FROM processos P " +
                "Left join clientes C on C.id = P.idCliente " +
                "Left join vendedor V on V.id = P.idVendedor " +
                "Left join funcionarios F on F.id = P.idresponsavel " +
                "Left join conta on C.id = conta.idcliente and conta.Tipo =@tipo " +
                "Left join conta CV on V.id = conta.idcliente and conta.Tipo =@tipov " +
                "Left join construtora on P.idConstrutora = construtora.id " +
                "Left join corretores on P.idCorretor = corretores.id " +
                //"Left join P_Status H on P.id = H.idprocesso " +
                "WHERE P.idresponsavel = @resp " +
                //"(C.Nome Like @consulta) or (P.id Like @consulta) " +
                " AND P.Status != @status " +
                " ORDER BY  P.Data ASC ";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@tipov", tipov);
            cmd.Parameters.AddWithValue("@resp", resp);
            cmd.Parameters.AddWithValue("@consulta", "%" + nome + "%");
            cmd.Parameters.AddWithValue("@status", "Concluído");

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
                        processos.Data_processo = Convert.ToDateTime(drprocessos["Data"]).ToString("dd/MM/yyyy");
                        //processos.Data_processo = drprocessos["Data"].ToString();
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
                        processos.Agencia_vendedor = drprocessos["agenciavendedor"].ToString();
                        processos.Conta_vendedor = drprocessos["contavendedor"].ToString();
                        #endregion

                        #region imovel
                        processos.Id_construtora = drprocessos["idConstrutora"].ToString();
                        processos.Id_corretor = drprocessos["idCorretor"].ToString();
                        processos.Descricao_construtora = drprocessos["Descricao"].ToString();
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

            cmd2.CommandText = "SELECT clientes.id, Nome, Email, Telefone, Celular, CPF, RG, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Renda, Status, Agencia, Conta FROM clientes Left join conta on conta.idcliente = clientes.id and conta.Tipo = @tipo WHERE Nome LIKE @nomeclientes or CPF LIKE @nomeclientes Order by clientes.id";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeclientes", "%" + nome + "%");
            cmd2.Parameters.AddWithValue("@tipo", "C");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Cliente clients = new Cliente();
                    clients.Id_cliente = drclients["id"].ToString();
                    clients.Nome_cliente = drclients["Nome"].ToString();
                    clients.Email_cliente = drclients["Email"].ToString();
                    clients.Telefone_cliente = drclients["Telefone"].ToString();
                    clients.Celular_cliente = drclients["Celular"].ToString();
                    clients.CPF_cliente = Convert.ToUInt64(drclients["CPF"].ToString()).ToString(@"000\.000\.000\-00");
                    //clients.CPF_cliente = drclients["CPF"].ToString().ToString();
                    clients.RG_cliente = drclients["RG"].ToString();
                    clients.StatusCPF_cliente = drclients["StatusCPF"].ToString();

                    clients.StatusCiweb_cliente = drclients["Ciweb"].ToString();
                    clients.StatusCadmut_cliente = drclients["Cadmut"].ToString();
                    clients.StatusIR_cliente = drclients["IR"].ToString();
                    clients.StatusFGTS_cliente = drclients["FGTS"].ToString();
                    clients.RG_cliente = drclients["RG"].ToString();
                    clients.Nascimento_cliente = Convert.ToDateTime(drclients["Nascimento"]).ToString("dd/MM/yyyy");
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
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Conjuge> GetConjuges(String nome)

        {
            var list = new List<Conjuge>();

            cmd2.CommandText = "SELECT conjuge.id, Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Renda, Status, Agencia, Conta FROM conjuge Left join conta on conta.idcliente = conjuge.id and conta.Tipo = @tipo WHERE Nome LIKE @nomeconjuge or CPF LIKE @nomeconjuge Order by conjuge.id";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomeconjuge", "%" + nome + "%");
            cmd2.Parameters.AddWithValue("@tipo", "C");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Conjuge clients = new Conjuge();
                    clients.Id_conjuge = drclients["id"].ToString();
                    clients.Nome_conjuge = drclients["Nome"].ToString();
                    clients.Email_conjuge = drclients["Email"].ToString();
                    clients.Telefone_conjuge = drclients["Telefone"].ToString();
                    clients.Celular_conjuge = drclients["Celular"].ToString();
                    clients.CPF_conjuge = Convert.ToUInt64(drclients["CPF"].ToString()).ToString(@"000\.000\.000\-00");
                    //clients.CPF_conjuge = drclients["CPF"].ToString().ToString();
                    clients.RG_conjuge = drclients["RG"].ToString();
                    //clients.StatusCPF_conjuge = drclients["StatusCPF"].ToString();

                    //clients.StatusCiweb_conjuge = drclients["Ciweb"].ToString();
                    //clients.StatusCadmut_conjuge = drclients["Cadmut"].ToString();
                    //clients.StatusIR_conjuge = drclients["IR"].ToString();
                    //clients.StatusFGTS_conjuge = drclients["FGTS"].ToString();
                    //clients.RG_conjuge = drclients["RG"].ToString();
                    clients.Nascimento_conjuge = Convert.ToDateTime(drclients["Nascimento"]).ToString("dd/MM/yyyy");
                    clients.Sexo_conjuge = drclients["Sexo"].ToString();
                    clients.Status_conjuge = drclients["Status"].ToString();
                    clients.Renda_conjuge = drclients["Renda"].ToString();
                    clients.Agencia_conjuge = drclients["Agencia"].ToString();
                    clients.Conta_conjuge = drclients["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    list.Add(clients);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Conjuge> GetidConjuges(String idcliente)

        {
            var list = new List<Conjuge>();

            cmd2.CommandText = "SELECT conjuge.id, conjuge.Conjuge FROM conjuge Where idCliente = @idcliente ";

            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@idcliente", idcliente);
            cmd2.Parameters.AddWithValue("@tipo", "C");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Conjuge conjuge = new Conjuge();
                    conjuge.Id_conjuge = drclients["id"].ToString();
                    conjuge.Conjuge_conjuge = bool.Parse(drclients["Conjuge"].ToString());

                    //clients.Nome_cliente = drclients["Nome"].ToString();
                    //clients.Email_cliente = drclients["Email"].ToString();
                    //clients.Telefone_cliente = drclients["Telefone"].ToString();
                    //clients.Celular_cliente = drclients["Celular"].ToString();
                    //clients.CPF_cliente = Convert.ToUInt64(drclients["CPF"].ToString()).ToString(@"000\.000\.000\-00");
                    ////clients.CPF_cliente = drclients["CPF"].ToString().ToString();
                    //clients.RG_cliente = drclients["RG"].ToString();
                    //clients.StatusCPF_cliente = drclients["StatusCPF"].ToString();

                    //clients.StatusCiweb_cliente = drclients["Ciweb"].ToString();
                    //clients.StatusCadmut_cliente = drclients["Cadmut"].ToString();
                    //clients.StatusIR_cliente = drclients["IR"].ToString();
                    //clients.StatusFGTS_cliente = drclients["FGTS"].ToString();
                    //clients.RG_cliente = drclients["RG"].ToString();
                    //clients.Nascimento_cliente = Convert.ToDateTime(drclients["Nascimento"]).ToString("dd/MM/yyyy");
                    //clients.Sexo_cliente = drclients["Sexo"].ToString();
                    //clients.Status_cliente = drclients["Status"].ToString();
                    //clients.Renda_cliente = drclients["Renda"].ToString();
                    //clients.Agencia_cliente = drclients["Agencia"].ToString();
                    //clients.Conta_cliente = drclients["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    list.Add(conjuge);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Vendedor> GetVendedores(String nome)

        {
            var list = new List<Vendedor>();

            cmd2.CommandText = "SELECT vendedor.id, Nome,  CPF, CNPJ, Telefone, Celular, Email, conta.Agencia, conta.Conta, vendedor.Status  FROM vendedor " +
                "Left join conta on conta.idcliente = vendedor.id and conta.Tipo = @tipo WHERE Nome LIKE @nomevendedor";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomevendedor", "%" + nome + "%");
            cmd2.Parameters.AddWithValue("@tipo", "V");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con.conectar();
                drvendedores = cmd2.ExecuteReader();
                while (drvendedores.Read())
                {
                    Vendedor vendedores = new Vendedor();
                    vendedores.Id_vendedor = drvendedores["id"].ToString();
                    vendedores.Nome_vendedor = drvendedores["Nome"].ToString();
                    vendedores.Email_vendedor = drvendedores["Email"].ToString();
                    vendedores.Telefone_vendedor = drvendedores["Telefone"].ToString();
                    vendedores.Celular_vendedor = drvendedores["Celular"].ToString();
                    //vendedores.CPF_vendedor = Convert.ToUInt64(drvendedores["CPF"].ToString()).ToString(@"000\.000\.000\-00");
                    if (string.IsNullOrEmpty(drvendedores["CNPJ"].ToString()) || drvendedores["CNPJ"].ToString() == "0" || drvendedores["CNPJ"].ToString() == "00000000000000")
                    {
                        vendedores.CPF_vendedor = FormatCnpjCpf.FormatCPF(drvendedores["CPF"].ToString());
                    }
                    else
                    {
                        vendedores.CPF_vendedor = FormatCnpjCpf.FormatCNPJ(drvendedores["CNPJ"].ToString());
                        
                    }

                    
                    //process.CNPJ_vendedor = drprocess["cnpjvendedor"].ToString();
                    

                    //vendedores.CPF_cliente = drvendedores["CPF"].ToString().ToString();
                    //vendedores.StatusCPF_vendedor = drvendedores["StatusCPF"].ToString();

                    //vendedores.StatusCiweb_vendedor = drvendedores["Ciweb"].ToString();
                    //vendedores.StatusCadmut_vendedor = drvendedores["Cadmut"].ToString();
                    //vendedores.StatusIR_vendedor = drvendedores["IR"].ToString();
                    //vendedores.StatusFGTS_vendedor = drvendedores["FGTS"].ToString();
                    //vendedores.RG_vendedor = drvendedores["RG"].ToString();
                    //vendedores.Nascimento_vendedor = Convert.ToDateTime(drvendedores["Nascimento"]).ToString("dd/MM/yyyy");
                    //vendedores.Sexo_vendedor = drvendedores["Sexo"].ToString();
                    vendedores.Status_vendedor = drvendedores["Status"].ToString();
                    //vendedores.Renda_vendedor = drvendedores["Renda"].ToString();
                    vendedores.Agencia_vendedor = drvendedores["Agencia"].ToString();
                    vendedores.Conta_vendedor = drvendedores["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    list.Add(vendedores);
                }
                drvendedores.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Vendedor: " + err.Message);
            }
            return list;
        }
        public List<Vendedor> GetVendedoresForid(String id)

        {
            var list = new List<Vendedor>();

            cmd2.CommandText = "SELECT vendedor.id, Nome,  CPF, CNPJ, Telefone, Celular, Email, conta.Agencia, conta.Conta, vendedor.Status  FROM vendedor " +
                "Left join conta on conta.idcliente = vendedor.id and conta.Tipo = @tipo WHERE vendedor.id = @id";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Parameters.AddWithValue("@tipo", "V");
            //Cliente clients = new Cliente();
            try
            {
                cmd2.Connection = con.conectar();
                drvendedores = cmd2.ExecuteReader();
                while (drvendedores.Read())
                {
                    Vendedor vendedores = new Vendedor();
                    vendedores.Id_vendedor = drvendedores["id"].ToString();
                    vendedores.Nome_vendedor = drvendedores["Nome"].ToString();
                    vendedores.Email_vendedor = drvendedores["Email"].ToString();
                    vendedores.Telefone_vendedor = drvendedores["Telefone"].ToString();
                    vendedores.Celular_vendedor = drvendedores["Celular"].ToString();
                    //vendedores.CPF_vendedor = Convert.ToUInt64(drvendedores["CPF"].ToString()).ToString(@"000\.000\.000\-00");
                    if (string.IsNullOrEmpty(drvendedores["CNPJ"].ToString()) || drvendedores["CNPJ"].ToString() == "0" || drvendedores["CNPJ"].ToString() == "00000000000000")
                    {
                        vendedores.CPF_vendedor = FormatCnpjCpf.FormatCPF(drvendedores["CPF"].ToString());
                    }
                    else
                    {
                        vendedores.CPF_vendedor = FormatCnpjCpf.FormatCNPJ(drvendedores["CNPJ"].ToString());

                    }


                    //process.CNPJ_vendedor = drprocess["cnpjvendedor"].ToString();


                    //vendedores.CPF_cliente = drvendedores["CPF"].ToString().ToString();
                    //vendedores.StatusCPF_vendedor = drvendedores["StatusCPF"].ToString();

                    //vendedores.StatusCiweb_vendedor = drvendedores["Ciweb"].ToString();
                    //vendedores.StatusCadmut_vendedor = drvendedores["Cadmut"].ToString();
                    //vendedores.StatusIR_vendedor = drvendedores["IR"].ToString();
                    //vendedores.StatusFGTS_vendedor = drvendedores["FGTS"].ToString();
                    //vendedores.RG_vendedor = drvendedores["RG"].ToString();
                    //vendedores.Nascimento_vendedor = Convert.ToDateTime(drvendedores["Nascimento"]).ToString("dd/MM/yyyy");
                    //vendedores.Sexo_vendedor = drvendedores["Sexo"].ToString();
                    vendedores.Status_vendedor = drvendedores["Status"].ToString();
                    //vendedores.Renda_vendedor = drvendedores["Renda"].ToString();
                    vendedores.Agencia_vendedor = drvendedores["Agencia"].ToString();
                    vendedores.Conta_vendedor = drvendedores["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //client.Foto_Func = (Byte[])(drclient["Foto"]);
                    list.Add(vendedores);
                }
                drvendedores.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Vendedor: " + err.Message);
            }
            return list;
        }
        public List<Funcionario> GetFuncionarios(String nome)

        {
            var list = new List<Funcionario>();

            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Login, Permission, Status FROM funcionarios WHERE Nome Like @nome Order by id ";
            //cmd.CommandText = "SELECT * FROM funcionarios";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            //Funcionario func = new Funcionario();
            try
            {
                cmd.Connection = con.conectar();
                drfunc = cmd.ExecuteReader();
                while (drfunc.Read())
                {
                    Funcionario func = new Funcionario();
                    func.Id_Funcionario = drfunc["id"].ToString();
                    func.Nome_Funcionario = drfunc["Nome"].ToString();
                    func.Email_Funcionario = drfunc["Email"].ToString();
                    func.Telefone_Funcionario = drfunc["Telefone"].ToString();
                    func.Celular_Funcionario = drfunc["Celular"].ToString();
                    if (string.IsNullOrEmpty(drfunc["Celular"].ToString()) || drfunc["Celular"].ToString() == "0")
                    {
                        func.Contato_Funcionario = drfunc["Telefone"].ToString();
                    }
                    else
                    {
                        func.Contato_Funcionario = drfunc["Celular"].ToString();
                    }
                    func.Endereco_Funcionario = drfunc["Endereco"].ToString();
                    func.Nascimento_Funcionario = Convert.ToDateTime(drfunc["Nascimento"]).ToString("dd/MM/yyyy");
                    func.Sexo_Funcionario = drfunc["Sexo"].ToString();
                    func.CPF_Funcionario = FormatCnpjCpf.FormatCPF(drfunc["CPF"].ToString());
                    func.RG_Funcionario = FormatCnpjCpf.FormatRG(drfunc["RG"].ToString());
                    func.Cracha_Funcionario = drfunc["Cracha"].ToString();
                    func.Login_Funcionario = drfunc["Login"].ToString();
                    func.Permission_Funcionario = drfunc["Permission"].ToString();
                    func.Status_Funcionario = drfunc["Status"].ToString();
                    //func.RG_Func = drfunc["RG"].ToString();
                    //func.Renda_func = drfunc["Renda"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //func.Foto_Func = (Byte[])(drfunc["Foto"]);
                    list.Add(func);
                }
                drfunc.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Funcionário: " + err.Message);
            }

            return list;
        }
        public Vendedor GetVendedor(String id)

        {
            // var list = new List<Vendedor>();

            cmd2.CommandText = "SELECT vendedor.id, Nome, Email, Telefone, Celular, CPF, CNPJ, Agencia, Conta, Renda, Status FROM vendedor Left join conta ON idcliente = @id AND Tipo = @tipo WHERE vendedor.id = @id ";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Parameters.AddWithValue("@tipo", "V");
            Vendedor vendedor = new Vendedor();
            try
            {
                cmd2.Connection = con.conectar();
                drvendedor = cmd2.ExecuteReader();
                while (drvendedor.Read())
                {
                    //Vendedor vendedor = new Vendedor();
                    vendedor.Id_vendedor = drvendedor["id"].ToString();
                    vendedor.Nome_vendedor = drvendedor["Nome"].ToString();
                    vendedor.Email_vendedor = drvendedor["Email"].ToString();
                    vendedor.Telefone_vendedor = drvendedor["Telefone"].ToString();
                    vendedor.Celular_vendedor = drvendedor["Celular"].ToString();
                    //vendedor.CPF_vendedor = drvendedor["CPF"].ToString();
                    vendedor.CPF_vendedor = FormatCnpjCpf.FormatCPF(drvendedor["CPF"].ToString());
                    //vendedor.CNPJ_vendedor = drvendedor["CNPJ"].ToString();
                    vendedor.CNPJ_vendedor = FormatCnpjCpf.FormatCNPJ(drvendedor["CNPJ"].ToString());
                    //vendedor.RG_vendedor = drvendedor["RG"].ToString();
                    //vendedor.Nascimento_vendedor = drvendedor["Nascimento"].ToString();
                    //vendedor.Sexo_vendedor = drvendedor["Sexo"].ToString();
                    vendedor.Status_vendedor = drvendedor["Status"].ToString();
                    vendedor.Renda_vendedor = drvendedor["Renda"].ToString();
                    vendedor.Agencia_vendedor = drvendedor["Agencia"].ToString();
                    vendedor.Conta_vendedor = drvendedor["Conta"].ToString();
                    //Byte[] byteBLOBData = new Byte[0];
                    //vendedor.Foto_Func = (Byte[])(drvendedor["Foto"]);
                    //list.Add(vendedor);
                }
                drvendedor.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Vendedor: " + err.Message);
            }

            return vendedor;
            //return list;
        }

        public List<Documento> GetDocumentos(String iddoc)
        {
            var listdoc = new List<Documento>();

            cmd.CommandText = "select * From documentos where idProcesso = @idProcess";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idProcess", iddoc);
            //cmd.Parameters.AddWithValue("@consulta", "%" + nome + "%");

            try
            {
                cmd.Connection = con.conectar();
                drdocumentos = cmd.ExecuteReader();

                if (drdocumentos.HasRows)
                {
                    while (drdocumentos.Read())
                    {
                        Documento documentos = new Documento();
                        #region Documentos
                        documentos.Id = drdocumentos["id"].ToString();
                        documentos.Id_Doc = drdocumentos["idDoc"].ToString();
                        documentos.IdProcesso_Doc = drdocumentos["idDoc"].ToString();
                        documentos.Tipo_Doc = drdocumentos["Tipo"].ToString();
                        documentos.Descricao_Doc = drdocumentos["Descricao"].ToString();
                        documentos.Data_Doc = drdocumentos["Data"].ToString();
                        documentos.Status_Doc = drdocumentos["Status"].ToString();
                        Byte[] byteBLOBData = new Byte[0];
                        documentos.Arquivo_Doc = (Byte[])(drdocumentos["Arquivo"]);
                        #endregion
                        listdoc.Add(documentos);
                    }
                }
                drdocumentos.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter documentos: " + err.Message);
            }
            return listdoc;
        }
        public String CriarProcesso(String idCliente, String idVendedor, String idresponsavel, String idConstrutora, String idCorretor, String idempreendimentos, String idagenciaimovel, String idprograma, String ValorImovel, String ValorFinanciado, String status)
        {

            try
            {

                cmd1.CommandText = "INSERT INTO processos (idCliente, idVendedor, idresponsavel, idConstrutora, idCorretor, idEmpreendimento, idAgenciaImovel, idPrograma, ValorImovel, ValorFinanciado, Data, Status) VALUES " +
                "(@idCliente, @idVendedor, @idresponsavel, @idConstrutora, @idCorretor, @idempreendimentos, @idagenciaimovel,@idprograma, @ValorImovel, @ValorFinanciado, @Data, @Status) ";

                cmd1.Parameters.AddWithValue("@idCliente", idCliente);
                cmd1.Parameters.AddWithValue("@idVendedor", idVendedor);
                cmd1.Parameters.AddWithValue("@idresponsavel", idresponsavel);
                cmd1.Parameters.AddWithValue("@idConstrutora", idConstrutora);
                cmd1.Parameters.AddWithValue("@idCorretor", idCorretor);
                cmd1.Parameters.AddWithValue("@idempreendimentos", idempreendimentos);
                cmd1.Parameters.AddWithValue("@idagenciaimovel", idagenciaimovel);
                cmd1.Parameters.AddWithValue("@idprograma", idprograma);
                cmd1.Parameters.AddWithValue("@ValorImovel", ValorImovel);
                cmd1.Parameters.AddWithValue("@ValorFinanciado", ValorFinanciado);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                cmd1.Parameters.AddWithValue("@Status", status);


                cmd1.Connection = con.conectar();
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

        public String UpdateProcesso(String id, String StatusCPF, DateTime? datastatuscpf, String Statusciweb, DateTime? datastatusciweb, String Stauscadmut, DateTime? datastatuscadmut, String Statusir, DateTime? datastatusir, String Statusfgts, DateTime? datastatusfgts, String StatusAnalise, DateTime? datastatusanalise,String respaprov, DateTime? datavalidadestatusanalise, String StatusEng, DateTime? datastatuseng, String StatusSiopi, DateTime? datasiopi, String StatusSictd, DateTime? datasictd, String StatusSaquefgts, DateTime? datasaquefgts, String StatusPA, DateTime? datapa, String sidAgenciaImovel, String sidPrograma, String valorimovel, String valorfinanciado, String sidConstrutora, String sidCorretores, String sidEmpreendimentos, String sidcartorio, String StatusCartorio, DateTime? datastatuscartorio, String status, String obs,String idvendedor)
        {
            try
            {
                cmd1.CommandText = "UPDATE processos " +
                "SET StatusCPF = @StatusCPF, DataStatusCPF = @datastatuscpf, StatusCiweb = @Statusciweb, DataStatusCiweb = @datastatusciweb, StatusCadmut = @Stauscadmut, DataStatusCadmut = @datastatuscadmut, StatusIR = @Statusir, DataStatusIR = @datastatusir, StatusFGTS = @Statusfgts, DataStatusFGTS = @datastatusfgts, Observacao = @obs, idVendedor = @idvendedor, " +
                "StatusAnalise = @StatusAnalise, DataStatusAnalise = @datastatusanalise, RespAprovacao = @respaprovacao, DataValidadeStatusAnalise = @datavalidadestatusanalise, StatusEng = @StatusEng, DataStatusEng = @datastatuseng, SIOPI = @StatusSiopi, DataSIOP = @datasiopi, SICTD = @StatusSictd, DataSICTD = @datasictd, SaqueFGTS = @StatusSaquefgts, DataSaqueFGTS = @datasaquefgts, StatusPA = @StatusPA, DataPA = @datapa, " +
                "idAgenciaImovel = @sidAgenciaImovel, idPrograma = @sidPrograma, ValorImovel = @valorimovel, ValorFinanciado = @valorfinanciado, idConstrutora = @sidConstrutora, idCorretor = @sidCorretores, idEmpreendimento = @sidEmpreendimentos, " +
                "idCartorio = @sidcartorio, StatusCartorio = @StatusCartorio, DataStatusCartorio = @datastatuscartorio, " +
                "Status = @status, DataStatus = @Data " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@StatusCPF", StatusCPF);
                cmd1.Parameters.AddWithValue("@datastatuscpf", datastatuscpf);
                cmd1.Parameters.AddWithValue("@Statusciweb", Statusciweb);
                cmd1.Parameters.AddWithValue("@datastatusciweb", datastatusciweb);
                cmd1.Parameters.AddWithValue("@Stauscadmut", Stauscadmut);
                cmd1.Parameters.AddWithValue("@datastatuscadmut", datastatuscadmut);
                cmd1.Parameters.AddWithValue("@Statusir", Statusir);
                cmd1.Parameters.AddWithValue("@datastatusir", datastatusir);
                cmd1.Parameters.AddWithValue("@Statusfgts", Statusfgts);
                cmd1.Parameters.AddWithValue("@datastatusfgts", datastatusfgts);
                cmd1.Parameters.AddWithValue("@StatusAnalise", StatusAnalise);
                cmd1.Parameters.AddWithValue("@datastatusanalise", datastatusanalise);
                cmd1.Parameters.AddWithValue("@respaprovacao", respaprov);
                cmd1.Parameters.AddWithValue("@datavalidadestatusanalise", datavalidadestatusanalise);
                cmd1.Parameters.AddWithValue("@StatusEng", StatusEng);
                cmd1.Parameters.AddWithValue("@datastatuseng", datastatuseng);
                cmd1.Parameters.AddWithValue("@StatusSiopi", StatusSiopi);
                cmd1.Parameters.AddWithValue("@datasiopi", datasiopi);
                cmd1.Parameters.AddWithValue("@StatusSictd", StatusSictd);
                cmd1.Parameters.AddWithValue("@datasictd", datasictd);
                cmd1.Parameters.AddWithValue("@StatusSaquefgts", StatusSaquefgts);
                cmd1.Parameters.AddWithValue("@datasaquefgts", datasaquefgts);
                cmd1.Parameters.AddWithValue("@StatusPA", StatusPA);
                cmd1.Parameters.AddWithValue("@datapa", datapa);
                cmd1.Parameters.AddWithValue("@sidAgenciaImovel", sidAgenciaImovel);
                cmd1.Parameters.AddWithValue("@sidPrograma", sidPrograma);
                cmd1.Parameters.AddWithValue("@valorimovel", valorimovel);
                cmd1.Parameters.AddWithValue("@valorfinanciado", valorfinanciado);
                cmd1.Parameters.AddWithValue("@sidConstrutora", sidConstrutora);
                cmd1.Parameters.AddWithValue("@sidCorretores", sidCorretores);
                cmd1.Parameters.AddWithValue("@sidEmpreendimentos", sidEmpreendimentos);
                cmd1.Parameters.AddWithValue("@sidcartorio", sidcartorio);
                cmd1.Parameters.AddWithValue("@StatusCartorio", StatusCartorio);
                cmd1.Parameters.AddWithValue("@datastatuscartorio", datastatuscartorio);
                cmd1.Parameters.AddWithValue("@status", status);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                cmd1.Parameters.AddWithValue("@obs", obs);
                cmd1.Parameters.AddWithValue("@idvendedor", idvendedor);





                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Processo Alterado Com Sucesso";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Alterar Processo";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Alterar Processo: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public int UpdateHProcesso(String id, String de, String para, String user)
        {
            try
            {

                cmd1.CommandText = "INSERT INTO h_cartorio (idprocesso, de, para, responsavel, data) VALUES" +
                    " ( @idProcesso, @de, @para, @user, @data)";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idProcesso", id);
                cmd1.Parameters.AddWithValue("@de", de);
                cmd1.Parameters.AddWithValue("@para", para);
                cmd1.Parameters.AddWithValue("@user", user);
                cmd1.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));



                cmd1.Connection = con.conectar();

                cmd1.ExecuteNonQuery();

                if (cmd1.LastInsertedId != 0)
                    cmd1.Parameters.Add(new MySqlParameter("ultimoId", cmd1.LastInsertedId));

                return Convert.ToInt32(cmd1.Parameters["@ultimoId"].Value);

            }

            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }
        public String UpdateRespProcesso(String id,  String idresp)
        {
            try
            {
                cmd1.CommandText = "UPDATE processos " +
                "SET idresponsavel = @idresp " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@idresp", idresp);
                
                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Responsável Alterado com Sucesso";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Alterar Responsável";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Alterar Processo: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteDocumento(String iddoc)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM documentos " +
                "WHERE id = @IdDoc ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@IdDoc", iddoc);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Documento Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Docuumento";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Documento: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteCliente(String idcli)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM clientes " +
                "WHERE id = @idcli ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idcli", idcli);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cliente Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Cliente";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Cliente: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteConjuge(String idconjuge)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM conjuge " +
                "WHERE id = @idconjuge ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idconjuge", idconjuge);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Cônjuge Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Cônjuge";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Cônjuge: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteVendedor(String idvend)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM vendedor " +
                "WHERE id = @idvendedor ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idvendedor", idvend);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Vendedor Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Vendedor";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Vendedor: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteAgencia(String ag)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM agencia " +
                "WHERE Agencia = @ag ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@ag", ag);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Agência Excluída com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Agência!";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Agência: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteAgenciaID(String id)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM agencia " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Agencia Excluída com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Agencia";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Agencia: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteEmpreendimentoID(String id)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM empreendimentos " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Empreendimento Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Empreendimento";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Empreendimento: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public String DeleteFuncionario(String idfunc)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM funcionarios " +
                "WHERE id = @idfunc ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idfunc", idfunc);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Funcionário Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Funcionário";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Funcionário: " + err.Message);
                con.desconectar();
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
                cmd1.Connection = con.conectar();
                drsenha = cmd1.ExecuteReader();
                while (drsenha.Read())
                {
                    mensagem = "Senha Alterado Com Sucesso";
                }

                drsenha.Close();
                con.desconectar();

            }
            catch (MySqlException err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Alterar senha: " + err.Message);
            }

            return mensagem;
        }
        public string UpdateLoginNewUser(String id, String idfunc)
        {
            try
            {
                cmd1.CommandText = "UPDATE funcionarios SET Login = @id WHERE id = @idfunc";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@idfunc", idfunc);


                cmd1.Connection = con.conectar();
                drsenha = cmd1.ExecuteReader();
                //while (drsenha.Read())
                //{
                mensagem = "OK";
                //}

                drsenha.Close();
                con.desconectar();

            }
            catch (MySqlException err)
            {
                mensagem = ("Erro ao lincar Login ao Funcionário: " + err.Message);
            }

            return mensagem;
        }
        public string UpdateLogin(String id, String novasenha)
        {
            try
            {
                cmd1.CommandText = "UPDATE Login SET Senha = @novasenha WHERE id = @idfunc";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@idfunc", id);
                cmd1.Parameters.AddWithValue("@novasenha", novasenha);


                cmd1.Connection = con.conectar();
                drsenha = cmd1.ExecuteReader();
                //while (drsenha.Read())
                //{
                mensagem = "Senha Alterada com Sucesso!";
                //}

                drsenha.Close();
                con.desconectar();

            }
            catch (MySqlException err)
            {
                mensagem = ("Erro ao lincar Login ao Funcionário: " + err.Message);
            }

            return mensagem;
        }
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

        public DataTable GetDataDocumentos(String idproces)
        {
            cmd.CommandText = "select id, idProcesso, Tipo, Descricao, Data, Extensao, Referencia, Status From documentos where idProcesso = @idProcess ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idProcess", idproces);
            cmd.Connection = con.conectar();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public int GetIDNewDocumento()
        {
            try
            {

                //cmd.CommandText = "SELECT MAX(id)+1 AS id FROM empreendimentos ";
                cmd.CommandText = "SHOW TABLE STATUS LIKE '%documentos%' ";


                cmd.Parameters.Clear();

                cmd.Connection = con.conectar();

                drempreendimentos = cmd.ExecuteReader();

                if (drempreendimentos.HasRows)
                {
                    while (drempreendimentos.Read())
                    {
                        newempre = drempreendimentos["Auto_increment"].ToString();
                    }
                }

                return Convert.ToInt32(newempre);

            }

            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }

        public int CriarDocumento(string idProcesso, string Tipo, string Descricao, byte Arquivo, String exxtension, string caminho, int referencia,string Status)
        {
            //string idDoc, string idProcesso, string Tipo, string Descricao, byte Arquivo, string Status
            try
            {

                cmd1.CommandText = "INSERT INTO documentos (idProcesso, Tipo, Descricao, Data, Arquivo, Extensao, Patch, Referencia, Status) VALUES" +
                    " ( @idProcesso, @Tipo, @Descricao, @Data, @Arquivo, @exxtension, @patch, @ref, @Status )";

                //cmd1.Parameters.AddWithValue("@id", id);
                //cmd1.Parameters.AddWithValue("@idDoc", idDoc);
                cmd1.Parameters.AddWithValue("@idProcesso", idProcesso);
                cmd1.Parameters.AddWithValue("@Tipo", Tipo);
                cmd1.Parameters.AddWithValue("@Descricao", Descricao);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                cmd1.Parameters.AddWithValue("@Arquivo", Arquivo);
                cmd1.Parameters.AddWithValue("@exxtension", exxtension);
                cmd1.Parameters.AddWithValue("@patch", caminho);
                cmd1.Parameters.AddWithValue("@ref", referencia);
                cmd1.Parameters.AddWithValue("@Status", Status);



                cmd1.Connection = con.conectar();

                //int recordsAffected = cmd1.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                if (cmd1.LastInsertedId != 0)
                    cmd1.Parameters.Add(new MySqlParameter("ultimoId", cmd1.LastInsertedId));

                return Convert.ToInt32(cmd1.Parameters["@ultimoId"].Value);

                //if (recordsAffected > 0)
                //{
                //    mensagem = "Documento Adicionado Com Sucesso";
                //}
                //else
                //{
                //    mensagem = "Erro ao Adicionar Documento";
                //}


            }
            //catch (MySqlException error)
            //{
            //    mensagem = ("Erro ao conectar: " + error.Message);
            //}
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                //mensagem = ("Erro ao Adicionar o Documento: " + err.Message);
                throw err;
            }
            finally
            {
                con.desconectar();
            }

            //return mensagem;
        }
        public String UpdateDocumento(String id, String sidAgenciaImovel, String sidPrograma, String sidConstrutora, String sidCorretores, String sidEmpreendimentos, String scpf, String sciweb, String scadmut, String sir, String sfgts, DateTime datastatuscpf, DateTime datastatusciweb, DateTime datastatuscadmut, DateTime datastatusir, DateTime datastatusfgts, DateTime datastatusanalise, DateTime datastatuseng, DateTime datasiopi, DateTime datasictd, DateTime datasaquefgts, DateTime datapa, String valorimovel, String valorfinanciado, String sidcartorio, String scartorio, DateTime datastatuscartorio, String status)
        {
            try
            {
                cmd1.CommandText = "UPDATE documentos SET " +
                    "idDoc = @idDoc,idProcesso = @idProcesso,Tipo = @Tipo,Descricao = @Descricao,Data = @Data,Arquivo = @Arquivo,Status = @Status " +
                    "WHERE id = @idProcesso ";
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@Id", id);
                cmd1.Parameters.AddWithValue("@cpf", scpf);
                cmd1.Parameters.AddWithValue("@Ciweb", sciweb);
                cmd1.Parameters.AddWithValue("@Cadmut", scadmut);
                cmd1.Parameters.AddWithValue("@IR", sir);
                cmd1.Parameters.AddWithValue("@FGTS", sfgts);
                cmd1.Parameters.AddWithValue("@idAgenciaImovel", sidAgenciaImovel);
                cmd1.Parameters.AddWithValue("@idPrograma", sidPrograma);
                cmd1.Parameters.AddWithValue("@idConstrutora", sidConstrutora);
                cmd1.Parameters.AddWithValue("@idCorretor", sidCorretores);
                cmd1.Parameters.AddWithValue("@idEmpreendimentos", sidEmpreendimentos);
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
                cmd1.Parameters.AddWithValue("@idCartorio", sidcartorio);
                cmd1.Parameters.AddWithValue("@Cartorio", scartorio);
                cmd1.Parameters.AddWithValue("@DataStatusCartorio", datastatuscartorio);
                //cmd1.Parameters.AddWithValue("@DataStatus", datastatus);
                cmd1.Parameters.AddWithValue("@Status", status);


                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Processo Alterado Com Sucesso";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Alterar Processo";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Alterar Processo: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public DataTable GetDataAgencia()
        {
            cmd.CommandText = "SELECT id, Descricao, Endereco, CONCAT(Agencia,' - ', Descricao) As Agencia FROM agencia ORDER BY Agencia ASC ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataTipoProc()
        {
            cmd.CommandText = "SELECT id, Descricao FROM tipoproc ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataRespProc()
        {
            cmd.CommandText = "SELECT 	id, Nome FROM funcionarios ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataTipoDoc(String idtipoproc)
        {
            cmd.CommandText = "SELECT id, Descricao FROM tipodoc WHERE Tipodoc = @idtipoproc ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idtipoproc", idtipoproc);

            cmd.Connection = con.conectar();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public DataTable GetDataPrograma()
        {
            cmd.CommandText = "SELECT id, Descricao FROM programa  Order by Descricao ASC ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataidfuncproc()
        {
            cmd.CommandText = "SELECT L.id, L.Login FROM funcionarios  " +
                " inner join login L on L.id = funcionarios.id " +
                "Order by L.Login ASC ";
                

                ;

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            DataRow row = dt.NewRow();
            row["id"] = "0";
            row["Login"] = "Todos";
            dt.Rows.Add(row);
            con.desconectar();

            return dt;
        }
        public DataTable GetDataConstrutora()
        {
            cmd.CommandText = "SELECT id, Descricao FROM construtora Order by Descricao ASC ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public DataTable GetDataCorretores()
        {
            cmd.CommandText = "SELECT id, Nome FROM corretores Order by Nome ASC ";

            cmd.Connection = con.conectar();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataEmpreendimentos()
        {
            cmd.CommandText = "SELECT id, Descricao FROM empreendimentos Order by Descricao ASC ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public DataTable GetDataCartorio()
        {
            cmd.CommandText = "SELECT id, Descricao FROM cartorio ";

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetHistoricoCartorio(string id)
        {
            cmd.CommandText = "SELECT *  FROM h_cartorio where idprocesso = @Id  ";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetProcessoCliente(string idcli)
        {
            cmd.CommandText = "SELECT id FROM processos Where idCliente = @idcliente ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idcliente", idcli);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetProcessoVendedor(string idvendedor)
        {
            cmd.CommandText = "SELECT id FROM processos Where idVendedor = @idvendedor ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idvendedor", idvendedor);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetProcessoAgencia(string idagencia)
        {
            cmd.CommandText = "SELECT id FROM processos Where idAgenciaImovel = @idagencia ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idagencia", idagencia);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetProcessoEmpreendimento(string idempreendimento)
        {
            cmd.CommandText = "SELECT id FROM processos Where idEmpreendimento = @idEmpreendimento ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idEmpreendimento", idempreendimento);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataVendedor(String nome)
        {
            cmd.CommandText = "SELECT id, Nome, CPF, CNPJ, Agencia, Conta, Email, Telefone, Celular  FROM vendedor Where (Nome Like @nomevendedor)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nomevendedor", "%" + nome + "%");

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetAgenciatb(string ag)
        {
            cmd.CommandText = "SELECT Agencia FROM agencia Where Agencia = @ag ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ag", ag);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public int CountEmpreendimentos()
        {
            try
            {

                //cmd.CommandText = "SELECT MAX(id)+1 AS id FROM empreendimentos ";
                cmd.CommandText = "SHOW TABLE STATUS LIKE '%empreendimentos%' ";


                cmd.Parameters.Clear();

                cmd.Connection = con.conectar();

                drempreendimentos = cmd.ExecuteReader();

                if (drempreendimentos.HasRows)
                {
                    while (drempreendimentos.Read())
                    {
                        newempre = drempreendimentos["Auto_increment"].ToString();
                    }
                }

                return Convert.ToInt32(newempre);

            }

            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                con.desconectar();
            }
        }

        public List<Combobox_Agencia> ComboboxAgencia()
        //public List<string[]> GetListaString()
        {
            var listcombobox = new List<Combobox_Agencia>();
            //var lista = new List<string[]>();

            cmd.CommandText = "SELECT id, Descricao, Endereco, Agencia FROM agencia ";

            try
            {
                cmd.Connection = con.conectar();
                drprocessos = cmd.ExecuteReader();

                if (drprocessos.HasRows)
                {
                    while (drprocessos.Read())
                    {
                        //Combobox_Agencia items = new Combobox_Agencia();
                        //items.Id_agencia = (drprocessos["id"].ToString()).PadLeft(4, '0');
                        //items.Decricao_agencia = drprocessos["Descricao"].ToString();
                        //items.Endereco_agencia = drprocessos["Endereco"].ToString();
                        //items.Agencia_agencia = drprocessos["Agencia"].ToString();

                        // listcombobox.Add(items);

                        // lista.Add(new string[] { (drprocessos["id"].ToString()).PadLeft(4, '0'), drprocessos["Descricao"].ToString(), drprocessos["Endereco"].ToString(), drprocessos["Agencia"].ToString() });
                    }
                }
                drprocessos.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter itens Combobox Agencia: " + err.Message);
            }

            return listcombobox;
            //return lista;
        }


        public void autoCompletarVendedor(ComboBox novoText, String nome)
        {
            cmd2.CommandText = "SELECT Nome FROM vendedor WHERE Nome LIKE @nomevendedor";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@nomevendedor", "%" + nome + "%");



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
        #region Construtora
        public int CountConstrutora()
        {
            try
            {

                //cmd.CommandText = "SELECT MAX(id)+1 AS id FROM construtora ";
                cmd.CommandText = "SHOW TABLE STATUS LIKE '%construtora%' ";


                cmd.Parameters.Clear();

                cmd.Connection = con.conectar();

                drconstrutora = cmd.ExecuteReader();

                if (drconstrutora.HasRows)
                {
                    while (drconstrutora.Read())
                    {
                        newempre = drconstrutora["Auto_increment"].ToString();
                    }
                }

                return Convert.ToInt32(newempre);

            }

            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                con.desconectar();
            }
        }
        public DataTable GetProcessoConstrutora(string idconstrutora)
        {
            cmd.CommandText = "SELECT id FROM processos Where idConstrutora = @idConstrutora ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idConstrutora", idconstrutora);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public String DeleteConstrutoraID(String id)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM construtora " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Construtora Excluída com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir a Construtora";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir a Construtora: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public List<Construtora> GetConstrutora(String var)

        {
            var list = new List<Construtora>();

            cmd2.CommandText = "SELECT * FROM construtora WHERE (Descricao like @var or CNPJ like @var) ";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@var", "%" + var + "%");
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Construtora empre = new Construtora();
                    empre.Id_construtora = drclients["id"].ToString();
                    empre.Descri_construtora = drclients["Descricao"].ToString();
                    
                    empre.End_construtora = drclients["Endereco"].ToString();
                    //if (string.IsNullOrEmpty(drvendedores["CNPJ"].ToString()) || drvendedores["CNPJ"].ToString() == "0" || drvendedores["CNPJ"].ToString() == "00000000000000")
                    //{
                        empre.CNPJ_construtora = FormatCnpjCpf.FormatCNPJ(drclients["CNPJ"].ToString());
                    //}

                    list.Add(empre);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Construtora: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Construtora> GetConstrutoraM(String empre)

        {
            var list = new List<Construtora>();

            cmd.CommandText = "SELECT * FROM construtora WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            //Cliente clients = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclients = cmd.ExecuteReader();
                while (drclients.Read())
                {
                    Construtora emprrendimento = new Construtora();
                    emprrendimento.Id_construtora = drclients["id"].ToString();
                    emprrendimento.Descri_construtora = drclients["Descricao"].ToString();
                    emprrendimento.End_construtora = drclients["Endereco"].ToString();
                    list.Add(emprrendimento);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Construtora: " + err.Message);
            }
            return list;
        }
        public List<Processo> GetValidadeAnalise()

        {
            var list = new List<Processo>();

            cmd.CommandText = "SELECT * FROM processos WHERE CURDATE() > DATE_SUB(DataValidadeStatusAnalise,INTERVAL 11 DAY) " +
                " AND (StatusAnalise = @Aprovado OR StatusAnalise = @Bloqueado ) AND Status not like '%Concluído%'  "; 
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Aprovado", "Aprovado");
            cmd.Parameters.AddWithValue("@Reprovado", "Reprovado");
            cmd.Parameters.AddWithValue("@Desistiu", "Desistiu");
            cmd.Parameters.AddWithValue("@nao", "Não Consultado");
            cmd.Parameters.AddWithValue("@Bloqueado", "Bloqueado em ourto CCA");

            //Cliente clients = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclients = cmd.ExecuteReader();
                while (drclients.Read())
                {
                    Processo emprrendimento = new Processo();
                    emprrendimento.Id_processo = drclients["id"].ToString();
                    emprrendimento.H_DataStatusAnalise = drclients["DataStatusAnalise"].ToString();
                    emprrendimento.H_DataValidadeStatusAnalise = drclients["DataValidadeStatusAnalise"].ToString();
                    emprrendimento.Nome_responsavel = drclients["RespAprovacao"].ToString();
                    string vencimento = Convert.ToDateTime($"{emprrendimento.H_DataValidadeStatusAnalise}").ToString("dd/MM/yyyy");
                    TimeSpan date = Convert.ToDateTime($"{emprrendimento.H_DataValidadeStatusAnalise}") - DateTime.Now;

                    int totalDias = date.Days;
                    if (totalDias > 1)
                    {
                        emprrendimento.H_DiferencaDayStatus = "Faltam " + totalDias.ToString() + "  Dias";
                    }
                    else if (totalDias == 0)
                    {
                        emprrendimento.H_DiferencaDayStatus = "Vence Hoje";
                    }
                    else if (totalDias == 1)
                    {
                        emprrendimento.H_DiferencaDayStatus = "Falta " + totalDias.ToString() + " Dia";
                    }
                    else if (totalDias < 0)
                    {
                        emprrendimento.H_DiferencaDayStatus = "Analise Vencida";
                    }
                    //emprrendimento.H_DiferencaDayStatus = "10";


                    list.Add(emprrendimento);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Processos: " + err.Message);
            }
            return list;
        }
        public Construtora GetNumConstrutora(String empre)
        {

            cmd.CommandText = "SELECT * FROM construtora " +

                "WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            Construtora empreendimento = new Construtora();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    empreendimento.Id_construtora = drclient["id"].ToString();
                    empreendimento.Descri_construtora = drclient["Descricao"].ToString();
                    //empreendimento.Num_Agencia = drclient["Agencia"].ToString();
                    empreendimento.End_construtora = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return empreendimento;
        }
        /*
        public Processo GetNumProcessoValidation(String empre)
        {

            cmd.CommandText = "SELECT * FROM processos " +

                "WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            Construtora empreendimento = new Construtora();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    empreendimento.Id_construtora = drclient["id"].ToString();
                    empreendimento.Descri_construtora = drclient["Descricao"].ToString();
                    //empreendimento.Num_Agencia = drclient["Agencia"].ToString();
                    empreendimento.End_construtora = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return empreendimento;
        }*/
        public Construtora GetConstrutoraC(String id)
        {

            cmd.CommandText = "SELECT * FROM construtora " +

                "WHERE id = @id  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            Construtora construtora = new Construtora();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    construtora.Id_construtora = drclient["id"].ToString();
                    construtora.Descri_construtora = drclient["Descricao"].ToString();
                    construtora.CNPJ_construtora = drclient["CNPJ"].ToString();
                    construtora.End_construtora = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Construtora: " + err.Message);
            }

            return construtora;
        }
        public int CadastrarConstrutora(String descricao, String cnpj, String end)
        {


            try
            {
                cmd.CommandText = "INSERT INTO construtora (Descricao, CNPJ,  Endereco) Values  (@descri, @cnpj, @endereco)";

                cmd.Parameters.AddWithValue("@descri", descricao);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@endereco", end);


                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

            }

            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }
        public string UpdateConstrutora(String id, String descricao,String cnpj, String end)
        {
            try
            {
                cmd.CommandText = "UPDATE construtora SET Descricao=@descri, CNPJ=@cnpj, Endereco=@endereco WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descri", descricao);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@endereco", end);


                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Construtora Atualizada com Sucesso!";
                }
                else
                {
                    mensagem = "Erro";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar o Construtora: " + err.Message);
            }

            return mensagem;

        }
        #endregion
        #region Corretor
        public int CountCorretor()
        {
            try
            {

                //cmd.CommandText = "SELECT MAX(id)+1 AS id FROM corretores ";
                cmd.CommandText = "SHOW TABLE STATUS LIKE '%corretor%' ";


                cmd.Parameters.Clear();

                cmd.Connection = con.conectar();

                drcorretor = cmd.ExecuteReader();

                if (drcorretor.HasRows)
                {
                    while (drcorretor.Read())
                    {
                        newempre = drcorretor["Auto_increment"].ToString();
                    }
                }

                return Convert.ToInt32(newempre);

            }

            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                con.desconectar();
            }
        }
        public DataTable GetProcessoCorretor(string idcorretor)
        {
            cmd.CommandText = "SELECT id FROM processos Where idCorretor = @idCorretor ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idCorretor", idcorretor);

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public String DeleteCorretorID(String id)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM corretores " +
                "WHERE id = @id ";

                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@id", id);

                cmd1.Connection = con.conectar();

                int recordsAffected = cmd1.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Corretor Excluído com sucesso!";
                    con.desconectar();
                }
                else
                {
                    mensagem = "Erro ao Excluir Corretor";
                    con.desconectar();
                }
            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
                con.desconectar();
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Excluir Corretor: " + err.Message);
                con.desconectar();
            }

            return mensagem;
        }
        public List<Corretor> GetCorretor(String var)

        {
            var list = new List<Corretor>();

            cmd2.CommandText = "SELECT * FROM corretores WHERE (Nome like @var or CPF like @var) ";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@var", "%" + var + "%");
            try
            {
                cmd2.Connection = con.conectar();
                drclients = cmd2.ExecuteReader();
                while (drclients.Read())
                {
                    Corretor empre = new Corretor();
                    empre.Id_corretor = drclients["id"].ToString();
                    empre.Nome_corretor = drclients["Nome"].ToString();
                    empre.CPF_corretor = FormatCnpjCpf.FormatCPF(drclients["CPF"].ToString());
                    //empre.CPF_corretor = drclients["CPF"].ToString();
                    empre.RG_corretor = drclients["Identificacao"].ToString();
                    empre.Nascimento_corretor = drclients["Nascimento"].ToString();
                    empre.Email_corretor = drclients["Email"].ToString();
                    empre.Telefone_corretor = drclients["Telefone"].ToString();
                    empre.Celular_corretor = drclients["Celular"].ToString();
                    empre.Endereco_corretor = drclients["Endereco"].ToString();
                    empre.Sexo_corretor = drclients["Sexo"].ToString();
                    empre.Status_corretor = drclients["Status"].ToString();

                    list.Add(empre);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Corretor: " + err.Message);
            }

            //return client;
            return list;
        }
        public List<Corretor> GetCorretorM(String empre)

        {
            var list = new List<Corretor>();

            cmd.CommandText = "SELECT * FROM corretores WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            //Cliente clients = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclients = cmd.ExecuteReader();
                while (drclients.Read())
                {
                    Corretor emprrendimento = new Corretor();
                    emprrendimento.Id_corretor = drclients["id"].ToString();
                    emprrendimento.Nome_corretor = drclients["Descricao"].ToString();
                    emprrendimento.Endereco_corretor = drclients["Endereco"].ToString();
                    list.Add(emprrendimento);
                }
                drclients.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Corretor: " + err.Message);
            }
            return list;
        }
        public Corretor GetNumCorretor(String empre)
        {

            cmd.CommandText = "SELECT * FROM corretores " +

                "WHERE Descricao Like @empre  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empre", "%" + empre + "%");
            Corretor empreendimento = new Corretor();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    //Cliente client = new Cliente();
                    empreendimento.Id_corretor = drclient["id"].ToString();
                    empreendimento.Nome_corretor = drclient["Descricao"].ToString();
                    //empreendimento.Num_Agencia = drclient["Agencia"].ToString();
                    empreendimento.Endereco_corretor = drclient["Endereco"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Agência: " + err.Message);
            }

            return empreendimento;
        }
        public Corretor GetCorretorC(String id)
        {

            cmd.CommandText = "SELECT * FROM corretores " +

                "WHERE id = @id  ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            Corretor empreendimento = new Corretor();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
                    empreendimento.Id_corretor = drclient["id"].ToString();
                    empreendimento.Nome_corretor = drclient["Nome"].ToString();
                    empreendimento.CPF_corretor = drclient["CPF"].ToString();
                    empreendimento.RG_corretor = drclient["Identificacao"].ToString();
                    empreendimento.Nascimento_corretor = drclient["Nascimento"].ToString();
                    empreendimento.Email_corretor = drclient["Email"].ToString();
                    empreendimento.Telefone_corretor = drclient["Telefone"].ToString();
                    empreendimento.Celular_corretor = drclient["Celular"].ToString();
                    empreendimento.Endereco_corretor = drclient["Endereco"].ToString();
                    empreendimento.Sexo_corretor = drclient["Sexo"].ToString();
                    empreendimento.Status_corretor = drclient["Status"].ToString();
                }
                drclient.Close();
                con.desconectar();

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Corretor: " + err.Message);
            }

            return empreendimento;
        }
        public int CadastrarCorretor(String nome, String cpf, String email, DateTime nasc, String telefone, String celular, String end, String rg, String sexo, String status)
        {


            try
            {
                cmd.CommandText = "INSERT INTO corretores (Nome, CPF, Email, Nascimento, Telefone, Celular, Endereco, Identificacao, Sexo, Status) Values  (@nome, @cpf, @email, @nasc, @telefone, @celular, @end, @rg, @sexo, @status )";
                
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nasc", nasc);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);


                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery();

                if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));

                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);

            }

            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                con.desconectar();
            }

        }
        public string UpdateCorretor(String id, String nome, String cpf, String email, DateTime nasc, String telefone, String celular, String end, String rg, String sexo, String status)
        {


            try
            {
                cmd.CommandText = "UPDATE corretores SET  Nome = @nome, Email = @email,  Telefone = @telefone, Celular = @celular, Endereco = @end, Nascimento = @nasc, Sexo = @sexo, CPF = @cpf, Identificacao = @rg, Status = @status WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nasc", nasc);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@status", status);



                cmd.Connection = con.conectar();

                int recordsAffected = cmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    mensagem = "Corretor Atualizado com Sucesso!";
                }
                else
                {
                    mensagem = "Erro";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                mensagem = ("Erro ao Atualizar o Corretor: " + err.Message);
            }

            return mensagem;

        }
        #endregion
    }
}
