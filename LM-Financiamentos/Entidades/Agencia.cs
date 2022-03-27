namespace LMFinanciamentos.Entidades
{
    public class Agencia
    {

        public string Id_agencia { get; set; }
        public string Descri_agencia { get; set; }
        public string Num_Agencia { get; set; }
        public string End_Agencia { get; set; }
        public int Cont { get; internal set; }
        

        public string GetId()
        {
            return Id_agencia;
        }
    }
}
