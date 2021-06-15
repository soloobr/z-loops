using MySql.Data.MySqlClient;


namespace LMFinanciamentos.DAL
{
    class Conecxao
    {
        MySqlConnection con = new MySqlConnection();

        public Conecxao()
        {
            con.ConnectionString = @"server=sql452.main-hosting.eu;user id=u371409358_lm;Password=P@ssw0rd;database=u371409358_lm;persistsecurityinfo=True";
        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
