namespace LMFinanciamentos.Entidades
{
    public class Funcionario
    {

        // public string Id_func { get; set; }
        public string Id_Funcionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public string Login_Funcionario { get; set; }
        public string Senha_Funcionario { get; set; }

        public string Email_Funcionario { get; set; }
        public string Telefone_Funcionario { get; set; }
        public string Celular_Funcionario { get; set; }
        public string Contato_Funcionario { get; set; }
        public string Endereco_Funcionario { get; set; }
        public string CPF_Funcionario { get; set; }
        public string CNPJ_Funcionario { get; set; }
        public string RG_Funcionario { get; set; }
        public string Cracha_Funcionario { get; set; }
        public string Nascimento_Funcionario { get; set; }
        public string Sexo_Funcionario { get; set; }
        public string Status_Funcionario { get; set; }
        public string Permission_Funcionario { get; set; }
        public string Renda_Funcionario { get; set; }
        public int Cont { get; internal set; }
        public string Agencia_Funcionario { get; internal set; }
        public string Conta_Funcionario { get; internal set; }






        public string Permision { get; set; }

        public byte[] Foto_Funcionario { get; set; }

        public string GetId()
        {
            return Id_Funcionario;
        }
    }
}
