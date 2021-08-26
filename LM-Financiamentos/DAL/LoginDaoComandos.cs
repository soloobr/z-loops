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


        MySqlDataReader dr, drfunc, drsenha, drclient, drclients, drprocess, drvendedor, drprocessos, drdocumentos, drvendedores, drconjuge;

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
                tem = false;
            }

            return tem;
        }

        public Processo GetProcesso(String idprocess)
        {
            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , ValorImovel, ValorFinanciado, P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS,  " +
                "P.StatusAnalise as	StatusAnalise, P.StatusEng as StatusEng, P.SaqueFGTS as SaqueFGTS, P.SIOPI as SIOPI, P.SICTD as SICTD, P.StatusPA as StatusPA, P.StatusCartorio as StatusCartorio, " +
                "Clientes.id as idCliente, Clientes.Nome as clinome, Clientes.Email as EmailCli,  Clientes.Telefone as Telefonecli , Clientes.Celular as celularcli, Clientes.CPF as cpfcli, Clientes.RG as rgcli, Conta.Agencia as agenciacli, Conta.Conta as contacli, Clientes.Nascimento as Nascimento, Clientes.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, CV.Agencia as agenciavendedor, CV.Conta as contavendedor,   " +
                "Corretora.Descricao as Corretora, Corretores.Nome as Corretor, P.idCorretora, P.idCorretor, Agencia.id as idAgenciaImovel, CONCAT(Agencia.Agencia,' - ',Agencia.Descricao) as AgenciaImovel, Programa.id as idPrograma, Programa.Descricao as DescriPrograma, Agencia.Agencia as AgenciaImovel, Programa.Descricao as Programa, Empreendimentos.Descricao as EmpDescricao, Empreendimentos.id as Empreid, P.idCartorio as idCartorio, Cartorio.Descricao as sCartorio, Cartorio.Endereco as endCartorio, P.StatusCartorio as StatusCartorio,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataSaqueFGTS, P.DataSIOP, P.DataSICTD, P.DataPA, P.DataStatusCartorio, P.DataStatus   " +

                "FROM Processos P " +
                "inner join Clientes on Clientes.id = P.idCliente " +
                "inner join Vendedor V on V.id = P.idVendedor " +
                "inner join Funcionarios F on F.id = P.idresponsavel " +
                "Left join Conta on Conta.idcliente = Clientes.id and Conta.Tipo =@tipo  " +
                "Left join Conta CV on CV.idcliente = V.id and CV.Tipo =@tipov  " +
                "Left join Agencia on P.idAgenciaImovel = Agencia.id " +
                "Left join Programa on P.idPrograma = Programa.id " +
                "Left join Empreendimentos on P.idEmpreendimento = Empreendimentos.id " +
                "Left join Corretora on P.idCorretora = Corretora.id " +
                "Left join Corretores on P.idCorretor = Corretores.id " +
                "Left join Cartorio on P.idCartorio = Cartorio.id " +
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
                    process.Nome_corretor = drprocess["Corretor"].ToString();
                    process.Descricao_corretora = drprocess["Corretora"].ToString();


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

        public String UpdateCliente(String id, String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String observacao)
        {


            try
            {
                cmd.CommandText = "UPDATE Clientes " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, RG = @rg, Nascimento = @nascimento, Sexo = @sexo, Status = @status, Renda = @renda, Observacao = @observacao " +
                "WHERE Clientes.id = @id ";

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
                cmd.CommandText = "UPDATE Funcionarios " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, Endereco = @endereco, Nascimento = @nascimento, Sexo = @sexo, CPF = @cpf, RG = @rg, Cracha = @cracha, Login = @login, Permission = @permission, Status = @status " +
                "WHERE Funcionarios.id = @id ";

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
                cmd.CommandText = "UPDATE Vendedor " +
                "SET Nome = @nome, Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, CNPJ =@cnpj,  Status = @status " +
                "WHERE Vendedor.id = @id ";

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
        public String InsertConta(String id, String agencia, String conta, String tipo,String idconjuge, String sequencia)
        {


            try
            {
                cmd.CommandText = "INSERT INTO Conta (idcliente, Agencia, Conta, Tipo, idconjuge, Sequencia) VALUES (@id, @agencia, @conta, @tipo, @idconjuge, @sequencia)";

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
                cmd.CommandText = "UPDATE Conta " +
                "SET Agencia = @agencia, Conta = @conta " +
                "WHERE Conta.idcliente = @id AND Tipo = @tipo";

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
                cmd.CommandText = "UPDATE Conta " +
                "SET Agencia = @agencia, Conta = @conta " +
                "WHERE Conta.idconjuge = @id AND Tipo = @tipo";

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
                cmd.CommandText = "INSERT INTO Foto(idVendedor, Foto, Descricao) VALUES (@id,@foto,@descricao)";

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
                    mensagem = "Erro ao Inserir Foto do Vendedor";
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
                cmd.CommandText = "INSERT INTO Foto(idCliente, Foto, Descricao) VALUES (@id,@foto,@descricao)";

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
                cmd.CommandText = "INSERT INTO Foto(idFunc, Foto, Descricao) VALUES (@id,@foto,@descricao)";

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
                cmd.CommandText = "DELETE FROM Foto WHERE idCliente = @id; ";

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
                cmd.CommandText = "DELETE FROM Foto WHERE idVendedor = @id; ";

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
                cmd.CommandText = "DELETE FROM Foto WHERE idFunc = @id; ";

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
                cmd.CommandText = "UPDATE Foto " +
                "SET Foto = @foto " +
                "WHERE Foto.idCliente = @id ";

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
                cmd.CommandText = "UPDATE Foto " +
                "SET Foto = @foto " +
                "WHERE Foto.idVendedor = @id ";

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
                cmd.CommandText = "UPDATE Foto " +
                "SET Foto = @foto " +
                "WHERE Foto.idFunc = @id ";

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
        public int CadastrarCliente(String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String observacao, bool conjuge)
        {


            try
            {
                cmd.CommandText = "INSERT INTO Clientes (Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Status, Renda, Observacao, Conjuge) Values  (@nome, @email, @telefone, @celular, @cpf, @rg, @nascimento, @sexo, @status, @renda, @observacao, @conjuge)";

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
        public int CadastrarConjuge(String nome, String email, String telefone, String celular, String cpf, String rg, DateTime nascimento, String sexo, String status, String renda, String observacao, String idcliente, String sequencia,bool conjuge)
        {


            try
            {
                cmd.CommandText = "INSERT INTO Conjuge (Nome, Email, Telefone, Celular, CPF, RG, Nascimento, Sexo, Status, Renda, Observacao, idCliente, Sequencia, Conjuge) Values  (@nome, @email, @telefone, @celular, @cpf, @rg, @nascimento, @sexo, @status, @renda, @observacao, @idcliente, @sequencia, @conjuge)";

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
                cmd.CommandText = "UPDATE Conjuge " +
               "SET Nome =@nome , Email = @email, Telefone = @telefone, Celular = @celular, CPF = @cpf, RG = @rg, Nascimento = @nascimento, Sexo = @sexo, Status = @status, Renda = @renda, Observacao = @observacao, idCliente = @idcliente, Sequencia = @sequencia, Conjuge = @conjuge " +
               "WHERE Conjuge.id = @id ";

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
                cmd.CommandText = "INSERT INTO Funcionarios (Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Permission, Status) Values  " +
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
                cmd.CommandText = "INSERT INTO Vendedor (Nome, Email, Telefone, Celular, CPF, CNPJ,   Status ) Values  (@nome, @email, @telefone, @celular, @cpf, @cnpj, @status)";

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
        public Funcionario GetFunc(String login, String senha)
        {
            cmd.CommandText = "Select F.Login as id, F.Nome, L.Login, L.Senha, Permission, Foto from Login L left join Funcionarios F on F.id = L.id left join Foto on Foto.idFunc = F.id where L.Login = @login and Senha = @senha";
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
            cmd.CommandText = "Select Clientes.id, F.Descricao, F.Foto From Clientes left join Foto F on Clientes.id = F.IdCliente  where Clientes.id = @id";
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
            cmd.CommandText = "Select Vendedor.id, F.Descricao, F.Foto From Vendedor left join Foto F on Vendedor.id = F.IdVendedor  where Vendedor.id = @id";
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
            cmd.CommandText = "Select Funcionarios.id, F.Descricao, F.Foto From Funcionarios left join Foto F on Funcionarios.id = F.IdFunc  where Funcionarios.id = @id";
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

            cmd.CommandText = "SELECT Clientes.id, Nome, Email, Telefone, Celular, CPF, C.Agencia, C.Conta, RG, Nascimento, Sexo, Renda, Status, Clientes.Observacao, Clientes.Conjuge FROM Clientes " +
                "Left join Conta C on C.idcliente = @id and C.Tipo = @tipo " +
                "WHERE Clientes.id = @id  ";
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

            cmd.CommandText = "SELECT Conjuge.id, Nome, Email, Telefone, Celular, CPF, C.Agencia, C.Conta, RG, Nascimento, Sexo, Renda, Status, Conjuge.Observacao, Conjuge.Conjuge FROM Conjuge " +
                "Left join Conta C on C.idcliente = @id and C.Tipo = @tipo and C.Sequencia = @idconjuge  " +
                "WHERE Conjuge.idCliente = @id AND Conjuge.Sequencia = @idconjuge  ";
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
        public Funcionario GetFuncionario(String sid)
        {
            //var list = new List<Cliente>();

            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Login, Permission, Status FROM Funcionarios WHERE id = @id";

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
            cmd.CommandText = "Select id, ServerNome, ServerFilesPath From Configuracoes";
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
                cmd1.CommandText = "UPDATE Configuracoes " +
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

        public List<Processo> GetProcessos(String tipo, String tipov, String nome)
        {
            var listprocessos = new List<Processo>();

            cmd.CommandText = "SELECT P.id as idpross, P.idresponsavel as idresponsavel, P.Data as Data, P.Observacao as Observacao , P.StatusCPF as StatusCPF, P.StatusCiweb as StatusCiweb, P.StatusCadmut as StatusCadmut, P.StatusIR as StatusIR, P.StatusFGTS as StatusFGTS, P.Status as Status, Corretora.Descricao as Corretora, Corretores.Nome as Corretor, " +
                "C.id as idCliente, C.Nome as clinome, C.Email as EmailCli,  C.Telefone as Telefonecli , C.Celular as celularcli, C.CPF as cpfcli, C.RG as rgcli, Conta.Agencia as agenciacli, Conta.Conta as contacli, C.Nascimento as Nascimento, C.Renda as rendacli, " +
                "V.id as idVendedor, V.Nome as vendnome, V.Email as Emailvendedor, V.Telefone as Telefonevendedor, V.Celular as celularvendedor, V.CPF as cpfvendedor, V.CNPJ as cnpjvendedor, CV.Agencia as agenciavendedor, CV.Conta as contavendedor,   " +
                "Corretora.id as idcorretora, Corretores.id as idCorretor,  " +
                "F.Nome as nomeresponsavel, F.Permission as permissionresponsavel,  " +
                "P.DataStatusCPF, P.DataStatusCiweb, P.DataStatusCadmut, P.DataStatusIR, P.DataStatusFGTS, P.DataStatusAnalise, P.DataStatusEng, P.DataStatusCartorio, P.DataStatus " +

                "FROM Processos P " +
                "Left join Clientes C on C.id = P.idCliente " +
                "Left join Vendedor V on V.id = P.idVendedor " +
                "Left join Funcionarios F on F.id = P.idresponsavel " +
                "Left join Conta on C.id = Conta.idcliente and Conta.Tipo =@tipo " +
                "Left join Conta CV on V.id = Conta.idcliente and Conta.Tipo =@tipov " +
                "Left join Corretora on P.idCorretora = Corretora.id " +
                "Left join Corretores on P.idCorretor = Corretores.id " +
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

            cmd2.CommandText = "SELECT Clientes.id, Nome, Email, Telefone, Celular, CPF, RG, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Renda, Status, Agencia, Conta FROM Clientes Left join Conta on Conta.idcliente = Clientes.id and Conta.Tipo = @tipo WHERE Nome LIKE @nomeclientes Order by Clientes.id";
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
        public List<Vendedor> GetVendedores(String nome)

        {
            var list = new List<Vendedor>();

            cmd2.CommandText = "SELECT Vendedor.id, Nome,  CPF, CNPJ, Telefone, Celular, Email, Conta.Agencia, Conta.Conta, Vendedor.Status  FROM Vendedor " +
                "Left join Conta on Conta.idcliente = Vendedor.id and Conta.Tipo = @tipo WHERE Nome LIKE @nomevendedor";
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
                    vendedores.CPF_vendedor = Convert.ToUInt64(drvendedores["CPF"].ToString()).ToString(@"000\.000\.000\-00");
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

            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, Endereco, Nascimento, Sexo, CPF, RG, Cracha, Login, Permission, Status FROM Funcionarios WHERE Nome Like @nome Order by id ";
            //cmd.CommandText = "SELECT * FROM Funcionarios";
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
                    func.Endereco_Funcionario = drfunc["Endereco"].ToString();
                    func.Nascimento_Funcionario = drfunc["Nascimento"].ToString();
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

            cmd2.CommandText = "SELECT Vendedor.id, Nome, Email, Telefone, Celular, CPF, CNPJ, Agencia, Conta, Renda, Status FROM Vendedor Left join Conta ON idcliente = @id AND Tipo = @tipo WHERE Vendedor.id = @id ";
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
                    vendedor.CPF_vendedor = drvendedor["CPF"].ToString();
                    vendedor.CNPJ_vendedor = drvendedor["CNPJ"].ToString();
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

            cmd.CommandText = "select * From Documentos where idProcesso = @idProcess";
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
        public String CriarProcesso(String idCliente, String idVendedor, String idresponsavel, String idCorretora, String idCorretor, String idempreendimentos, String idagenciaimovel, String idprograma, String ValorImovel, String ValorFinanciado, String status)
        {

            try
            {

                cmd1.CommandText = "INSERT INTO Processos (idCliente, idVendedor, idresponsavel, idCorretora, idCorretor, idEmpreendimento, idAgenciaImovel, idPrograma, ValorImovel, ValorFinanciado, Data, Status) VALUES " +
                "(@idCliente, @idVendedor, @idresponsavel, @idCorretora, @idCorretor, @idempreendimentos, @idagenciaimovel,@idprograma, @ValorImovel, @ValorFinanciado, @Data, @Status) ";

                cmd1.Parameters.AddWithValue("@idCliente", idCliente);
                cmd1.Parameters.AddWithValue("@idVendedor", idVendedor);
                cmd1.Parameters.AddWithValue("@idresponsavel", idresponsavel);
                cmd1.Parameters.AddWithValue("@idCorretora", idCorretora);
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

        public String UpdateProcesso(String id, String StatusCPF, DateTime datastatuscpf, String Statusciweb, DateTime datastatusciweb, String Stauscadmut, DateTime datastatuscadmut, String Statusir, DateTime datastatusir, String Statusfgts, DateTime datastatusfgts, String StatusAnalise, DateTime datastatusanalise, String StatusEng, DateTime datastatuseng, String StatusSiopi, DateTime datasiopi, String StatusSictd, DateTime datasictd, String StatusSaquefgts, DateTime datasaquefgts, String StatusPA, DateTime datapa, String sidAgenciaImovel, String sidPrograma, String valorimovel, String valorfinanciado, String sidCorretora, String sidCorretores, String sidEmpreendimentos, String sidcartorio, String StatusCartorio, DateTime datastatuscartorio, String status)
        {
            try
            {
                cmd1.CommandText = "UPDATE Processos " +
                "SET StatusCPF = @StatusCPF, DataStatusCPF = @datastatuscpf, StatusCiweb = @Statusciweb, DataStatusCiweb = @datastatusciweb, StatusCadmut = @Stauscadmut, DataStatusCadmut = @datastatuscadmut, StatusIR = @Statusir, DataStatusIR = @datastatusir, StatusFGTS = @Statusfgts, DataStatusFGTS = @datastatusfgts, " +
                "StatusAnalise = @StatusAnalise, DataStatusAnalise = @datastatusanalise, StatusEng = @StatusEng, DataStatusEng = @datastatuseng, SIOPI = @StatusSiopi, DataSIOP = @datasiopi, SICTD = @StatusSictd, DataSICTD = @datasictd, SaqueFGTS = @StatusSaquefgts, DataSaqueFGTS = @datasaquefgts, StatusPA = @StatusPA, DataPA = @datapa, " +
                "idAgenciaImovel = @sidAgenciaImovel, idPrograma = @sidPrograma, ValorImovel = @valorimovel, ValorFinanciado = @valorfinanciado, idCorretora = @sidCorretora, idCorretor = @sidCorretores, idEmpreendimento = @sidEmpreendimentos, " +
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
                cmd1.Parameters.AddWithValue("@sidCorretora", sidCorretora);
                cmd1.Parameters.AddWithValue("@sidCorretores", sidCorretores);
                cmd1.Parameters.AddWithValue("@sidEmpreendimentos", sidEmpreendimentos);
                cmd1.Parameters.AddWithValue("@sidcartorio", sidcartorio);
                cmd1.Parameters.AddWithValue("@StatusCartorio", StatusCartorio);
                cmd1.Parameters.AddWithValue("@datastatuscartorio", datastatuscartorio);
                cmd1.Parameters.AddWithValue("@status", status);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));





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
        public String DeleteDocumento(String iddoc)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM Documentos " +
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
                cmd1.CommandText = "DELETE FROM Clientes " +
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
        public String DeleteVendedor(String idvend)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM Vendedor " +
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
        public String DeleteFuncionario(String idfunc)
        {
            try
            {
                cmd1.CommandText = "DELETE FROM Funcionarios " +
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
                cmd1.CommandText = "UPDATE Funcionarios SET Login = @id WHERE id = @idfunc";

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
            cmd.CommandText = "select id, idProcesso, Tipo, Descricao, Data, Extensao, Status From Documentos where idProcesso = @idProcess ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idProcess", idproces);
            cmd.Connection = con.conectar();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public int CriarDocumento(string idProcesso, string Tipo, string Descricao, byte Arquivo, String exxtension, string caminho, string Status)
        {
            //string idDoc, string idProcesso, string Tipo, string Descricao, byte Arquivo, string Status
            try
            {

                cmd1.CommandText = "INSERT INTO Documentos (idProcesso, Tipo, Descricao, Data, Arquivo, Extensao, Patch, Status) VALUES" +
                    " ( @idProcesso, @Tipo, @Descricao, @Data, @Arquivo, @exxtension, @patch, @Status )";

                //cmd1.Parameters.AddWithValue("@id", id);
                //cmd1.Parameters.AddWithValue("@idDoc", idDoc);
                cmd1.Parameters.AddWithValue("@idProcesso", idProcesso);
                cmd1.Parameters.AddWithValue("@Tipo", Tipo);
                cmd1.Parameters.AddWithValue("@Descricao", Descricao);
                cmd1.Parameters.AddWithValue("@Data", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                cmd1.Parameters.AddWithValue("@Arquivo", Arquivo);
                cmd1.Parameters.AddWithValue("@exxtension", exxtension);
                cmd1.Parameters.AddWithValue("@patch", caminho);
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
        public String UpdateDocumento(String id, String sidAgenciaImovel, String sidPrograma, String sidCorretora, String sidCorretores, String sidEmpreendimentos, String scpf, String sciweb, String scadmut, String sir, String sfgts, DateTime datastatuscpf, DateTime datastatusciweb, DateTime datastatuscadmut, DateTime datastatusir, DateTime datastatusfgts, DateTime datastatusanalise, DateTime datastatuseng, DateTime datasiopi, DateTime datasictd, DateTime datasaquefgts, DateTime datapa, String valorimovel, String valorfinanciado, String sidcartorio, String scartorio, DateTime datastatuscartorio, String status)
        {
            try
            {
                cmd1.CommandText = "UPDATE Documentos SET " +
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
                cmd1.Parameters.AddWithValue("@idCorretora", sidCorretora);
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
            cmd.CommandText = "SELECT id, Descricao, Endereco, CONCAT(Agencia,' - ', Descricao) As Agencia FROM Agencia ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataTipoProc()
        {
            cmd.CommandText = "SELECT id, Descricao FROM Tipoproc ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataTipoDoc(String idtipoproc)
        {
            cmd.CommandText = "SELECT id, Descricao FROM TipoDoc WHERE Tipodoc = @idtipoproc";
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
            cmd.CommandText = "SELECT id, Descricao FROM Programa ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataCorretora()
        {
            cmd.CommandText = "SELECT id, Descricao FROM Corretora ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public DataTable GetDataCorretores()
        {
            cmd.CommandText = "SELECT id, Nome FROM Corretores ";

            cmd.Connection = con.conectar();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataEmpreendimentos()
        {
            cmd.CommandText = "SELECT id, Descricao FROM Empreendimentos ";

            cmd.Connection = con.conectar();
            //drprocessos = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }

        public DataTable GetDataCartorio()
        {
            cmd.CommandText = "SELECT id, Descricao FROM Cartorio ";

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public DataTable GetDataVendedor(String nome)
        {
            cmd.CommandText = "SELECT id, Nome, CPF, CNPJ, Agencia, Conta, Email, Telefone, Celular  FROM Vendedor Where (Nome Like @nomevendedor)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nomevendedor", "%" + nome + "%");

            cmd.Connection = con.conectar();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.desconectar();

            return dt;
        }
        public List<Combobox_Agencia> ComboboxAgencia()
        //public List<string[]> GetListaString()
        {
            var listcombobox = new List<Combobox_Agencia>();
            //var lista = new List<string[]>();

            cmd.CommandText = "SELECT id, Descricao, Endereco, Agencia FROM Agencia ";

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
            cmd2.CommandText = "SELECT Nome FROM Vendedor WHERE Nome LIKE @nomevendedor";
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
    }
}
