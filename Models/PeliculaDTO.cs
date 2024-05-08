namespace backendnet.Models
{
    public class PeliculaDTO
    {
        public int? PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public int Anio { get; set; }
        public string Poster { get; set; }
        public int[] Categorias { get; set; }
    }
}