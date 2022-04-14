namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public int? EventoId { get; set; } //Forma de encontrar o evento a qual ela pertence
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; } //Forma de encontrar o palestrante a qual ela pertence
        public Palestrante Palestrante { get; set; }
    }
}