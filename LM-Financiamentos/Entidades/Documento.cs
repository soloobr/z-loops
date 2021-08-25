namespace LMFinanciamentos.Entidades
{
    public class Documento
    {
        public string Id { get; set; }
        public string Id_Doc { get; set; }
        public string IdProcesso_Doc { get; set; }
        public string Tipo_Doc { get; set; }
        public string Descricao_Doc { get; set; }
        public string Data_Doc { get; set; }
        public string Status_Doc { get; set; }
        public int Cont { get; internal set; }

        public byte[] Arquivo_Doc { get; set; }

        public string GetId()
        {
            return Id_Doc;
        }
    }
}
