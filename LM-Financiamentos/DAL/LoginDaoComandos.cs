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
        MySqlDataReader dr, drfunc, drsenha;


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
