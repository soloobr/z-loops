namespace LMFinanciamentos.Entidades
{
    public class Corretor
    {

        // public string Id_func { get; set; }
        public string Id_corretor { get; set; }
        public string Nome_corretor { get; set; }
        //public string Login_corretor { get; set; }
        //public string Senha_corretor { get; set; }

        public string Email_corretor { get; set; }
        public string Telefone_corretor { get; set; }
        public string Celular_corretor { get; set; }
        //public string Contato_corretor { get; set; }
        public string Endereco_corretor { get; set; }
        public string CPF_corretor { get; set; }
        //public string CNPJ_corretor { get; set; }
        public string RG_corretor { get; set; }
        //public string Cracha_corretor { get; set; }
        public string Nascimento_corretor { get; set; }
        public string Sexo_corretor { get; set; }
        public string Status_corretor { get; set; }
        //public string Permission_corretor { get; set; }
        //public string Renda_corretor { get; set; }
        public int Cont { get; internal set; }
        //public string Agencia_corretor { get; internal set; }
        //public string Conta_corretor { get; internal set; }






        public string Permision { get; set; }

        public byte[] Foto_corretor { get; set; }

        public string GetId()
        {
            return Id_corretor;
        }
    }
}
