using LMFinanciamentos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

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
        Conecxao con = new Conecxao();
        Conecxao conn = new Conecxao();
        //SqlDataReader dr;
        MySqlDataReader dr, drfunc, drsenha, drclient;


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
            }
            catch (SqlException)
            {
                //throw;
                tem = false;
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
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

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter funcionário: " + err.Message);
            }

            return func;
        }
        public Cliente GetCliente(String nome)
        {
            cmd.CommandText = "SELECT id, Nome, Email, Telefone, Celular, CPF, StatusCPF, Ciweb, Cadmut, IR, FGTS, RG, Nascimento, Sexo, Renda, Status FROM Clientes WHERE(Nome Like @nomecliente)";
            cmd.Parameters.AddWithValue("@nomecliente", nome);
            Cliente client = new Cliente();
            try
            {
                cmd.Connection = con.conectar();
                drclient = cmd.ExecuteReader();
                while (drclient.Read())
                {
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
                }

            }
            catch (SqlException err)
            {
                throw new Exception("Erro ao obter Cliente: " + err.Message);
            }

            return client;
        }
        public String UpdateClienteProcesso(String id, String scpf, String sciweb, String scadmut, String sir, String sfgts)
        {

            try
            {
                cmd1.CommandText = "UPDATE Clientes SET StatusCPF = @cpf, Ciweb = @Ciweb, Cadmut = @Cadmut, IR = @IR, FGTS = @FGTS WHERE id = @Id";
                cmd1.Parameters.AddWithValue("@Id", id);
                cmd1.Parameters.AddWithValue("@cpf", scpf);
                cmd1.Parameters.AddWithValue("@Ciweb", sciweb);
                cmd1.Parameters.AddWithValue("@Cadmut", scadmut);
                cmd1.Parameters.AddWithValue("@IR", sir);
                cmd1.Parameters.AddWithValue("@FGTS", sfgts);
                cmd1.Connection = conn.conectar();
                //drupdatecli = cmd1.ExecuteReader();
                int recordsAffected = cmd1.ExecuteNonQuery();

                if(recordsAffected > 0) {
                    mensagem = "Cliente Alterado Com Sucesso";
                }
                else
                {
                    mensagem = "Erro ao Alterar Cliente";
                }


            }
            catch (MySqlException error)
            {
                mensagem = ("Erro ao conectar: " + error.Message);
            }
            catch (Exception err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Alterar Cliente: " + err.Message);
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


            }
            catch (MySqlException err)
            {
                //throw new Exception("Erro ao Alterar senha: " + err.Message);
                mensagem = ("Erro ao Alterar senha: " + err.Message);
            }

            return mensagem;
        }

    }
}
