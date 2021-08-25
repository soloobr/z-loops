namespace LMFinanciamentos.Entidades
{
    public class Combobox_Agencia
    {
        private string v1;
        private string v2;

        public Combobox_Agencia(string v1, string v2)
        {
            this.Id_agencia = v1;
            this.Agencia_agencia = v2;
        }

        public string Id_agencia { get; set; }
        public string Decricao_agencia { get; set; }
        public string Endereco_agencia { get; set; }
        public string Agencia_agencia { get; set; }


    }
}
