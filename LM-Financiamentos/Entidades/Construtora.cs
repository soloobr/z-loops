namespace LMFinanciamentos.Entidades
{
    public class Construtora
    {

        public string Id_construtora { get; set; }
        public string Descri_construtora { get; set; }
        public string End_construtora { get; set; }
        public string CNPJ_construtora { get; set; }
        public int Cont { get; internal set; }
        

        public string GetId()
        {
            return Id_construtora;
        }
    }
}
