namespace LMFinanciamentos.Entidades
{
    public class Vendedor
    {
        public string Id_vendedor { get; set; }
        public string Nome_vendedor { get; set; }
        public string Email_vendedor { get; set; }
        public string Telefone_vendedor { get; set; }
        public string Celular_vendedor { get; set; }
        public string CPF_vendedor { get; set; }
        public string CNPJ_vendedor { get; set; }
        public string StatusCPF_vendedor { get; set; }
        public string StatusCiweb_vendedor { get; set; }
        public string StatusCadmut_vendedor { get; set; }
        public string StatusIR_vendedor { get; set; }
        public string StatusFGTS_vendedor { get; set; }
        public string RG_vendedor { get; set; }
        public string Nascimento_vendedor { get; set; }
        public string Sexo_vendedor { get; set; }
        public string Status_vendedor { get; set; }
        public string Renda_vendedor { get; set; }
        public int Cont { get; internal set; }
        public string Agencia_vendedor { get; internal set; }
        public string Conta_vendedor { get; internal set; }



        //public string Permision { get; set; }

        public byte[] Foto_vendedor { get; set; }

        public string GetId()
        {
            return Id_vendedor;
        }
    }
}
