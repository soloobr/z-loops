namespace LMFinanciamentos.Entidades
{
    public class Cliente
    {

        public string Id_cliente { get; set; }
        public string Nome_cliente { get; set; }
        public string Email_cliente { get; set; }
        public string Telefone_cliente { get; set; }
        public string Celular_cliente { get; set; }
        public string CPF_cliente { get; set; }
        public string CNPJ_cliente { get; set; }
        public string StatusCPF_cliente { get; set; }
        public string StatusCiweb_cliente { get; set; }
        public string StatusCadmut_cliente { get; set; }
        public string StatusIR_cliente { get; set; }
        public string StatusFGTS_cliente { get; set; }
        public string RG_cliente { get; set; }
        public string Nascimento_cliente { get; set; }
        public string Sexo_cliente { get; set; }
        public string Status_cliente { get; set; }
        public string Renda_cliente { get; set; }
        public int Cont { get; internal set; }
        public string Agencia_cliente { get; internal set; }
        public string Conta_cliente { get; internal set; }

        public byte[] Foto_cliente { get; set; }
        



        //public string Permision { get; set; }

        //public byte[] Foto_cliente { get; set; }

        public string GetId()
        {
            return Id_cliente;
        }
    }
}
