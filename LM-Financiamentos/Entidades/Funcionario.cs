namespace LMFinanciamentos.Entidades
{
    public class Funcionario
    {

        // public string Id_func { get; set; }
        public string Id_func { get; set; }
        public string Nome_Func { get; set; }
        public string Login_Func { get; set; }
        public string Senha_Func { get; set; }


        public string Permision { get; set; }

        public byte[] Foto_Func { get; set; }

        public string GetId()
        {
            return Id_func;
        }
    }
}
