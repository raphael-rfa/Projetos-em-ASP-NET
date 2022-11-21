using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestãoDeSalaDeAula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double Media
        {
            get { return (Nota1 + Nota2 + Nota3 + Nota4) / 4; }
        }
    }
}
