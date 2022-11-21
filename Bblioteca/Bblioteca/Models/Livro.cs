namespace Bblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Area { get; set; }
        public int Ano { get; set; }
        public string? Editora { get; set; }
    }
}
