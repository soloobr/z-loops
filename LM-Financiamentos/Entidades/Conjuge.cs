namespace LMFinanciamentos.Entidades
{
    public class Conjuge
    {

        public string Id_conjuge { get; set; }
        public string Nome_conjuge { get; set; }
        public string Email_conjuge { get; set; }
        public string Telefone_conjuge { get; set; }
        public string Celular_conjuge { get; set; }
        public string CPF_conjuge { get; set; }
        public string CNPJ_conjuge { get; set; }
        public string StatusCPF_conjuge { get; set; }
        public string StatusCiweb_conjuge { get; set; }
        public string StatusCadmut_conjuge { get; set; }
        public string StatusIR_conjuge { get; set; }
        public string StatusFGTS_conjuge { get; set; }
        public string RG_conjuge { get; set; }
        public string Nascimento_conjuge { get; set; }
        public string Sexo_conjuge { get; set; }
        public string Status_conjuge { get; set; }
        public string Renda_conjuge { get; set; }
        public int Cont { get; internal set; }
        public string Agencia_conjuge { get; internal set; }
        public string Conta_conjuge { get; internal set; }
        public string OBS_conjuge { get; internal set; }
        public bool Conjuge_conjuge { get; internal set; }

        public byte[] Foto_conjuge { get; set; }




        //public string Permision { get; set; }

        //public byte[] Foto_conjuge { get; set; }

        public string GetId()
        {
            return Id_conjuge;
        }
    }
}
