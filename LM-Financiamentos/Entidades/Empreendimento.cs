namespace LMFinanciamentos.Entidades
{
    public class Empreendimento
    {

        public string Id_empreendimentos { get; set; }
        public string Descri_empreendimentos { get; set; }
        public string End_empreendimentos { get; set; }
        public int Cont { get; internal set; }
        

        public string GetId()
        {
            return Id_empreendimentos;
        }
    }
}
