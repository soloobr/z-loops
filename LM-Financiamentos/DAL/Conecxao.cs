using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace LMFinanciamentos.DAL
{
    class Conecxao
    {
        MySqlConnection con = new MySqlConnection();
        string servidor;

        public Conecxao(string server)
        {
            #region Checbox Foto
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var MyIni = new IniFile(basePath + @"\LM-Settings.ini");
            String usuario = Path.GetFileName(basePath);
            var DefaultVolume = MyIni.Read("StringConnection", usuario);

            //if (DefaultVolume.ToString() == "ONLINE")
            //{
            //    img_foto.Image = Properties.Resources.contacts_250;
            //}
            #endregion
            switch (DefaultVolume)
            {
                case "LOCAL":
                    con.ConnectionString = @"server=SERVIDOR;user id = u371409358_lm;Password=P@ssw0rd; database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
                    break;
                case "ONLINE":
                    con.ConnectionString = @"server=sql452.main-hosting.eu;user id=u371409358_lm;Password=P@ssw0rd;database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
                    break;
                default:
                    con.ConnectionString = @"server=SERVIDOR;user id = u371409358_lm;Password=P@ssw0rd; database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
                    break;


                    //         if (server == "LOCAL")
                    // {



            }
            //else if (server == "ONLINE")
            //{
            //    con.ConnectionString = @"server=sql452.main-hosting.eu;user id=u371409358_lm;Password=P@ssw0rd;database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
            //}
            //else
            //{
            //    con.ConnectionString = @"server=sql452.main-hosting.eu;user id=u371409358_lm;Password=P@ssw0rd;database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
            //}

            //con.ConnectionString = @"server=192.168.0.19;user id = u371409358_lm;Password=P@ssw0rd; database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
            // con.ConnectionString = @"server=SERVIDOR;user id = u371409358_lm;Password=P@ssw0rd; database=u371409358_lm;persistsecurityinfo=True;convert zero datetime=True";
        }

        //public void setServer(string server)
        //{

        //    servidor = server;

        //}

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
