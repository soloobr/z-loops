namespace LMFinanciamentos.Entidades
{
    public class Funcionario
    {

        // public string Id_func { get; set; }
        public string Id_Func { get; set; }
        public string Nome_Func { get; set; }
        public string Login_Func { get; set; }
        public string Senha_Func { get; set; }

        public string Email_Func { get; set; }
        public string Telefone_Func { get; set; }
        public string Celular_Func { get; set; }
        public string Endereco_Func { get; set; }
        public string CPF_Func { get; set; }
        public string CNPJ_Func { get; set; }
        public string RG_Func { get; set; }
        public string Cracha_Func { get; set; }
        public string Nascimento_Func { get; set; }
        public string Sexo_Func { get; set; }
        public string Status_Func { get; set; }
        public string Renda_Func { get; set; }
        public int Cont { get; internal set; }
        public string Agencia_Func { get; internal set; }
        public string Conta_Func { get; internal set; }






        public string Permision { get; set; }

        public byte[] Foto_Func { get; set; }

        public string GetId()
        {
            return Id_Func;
        }
    }
}
