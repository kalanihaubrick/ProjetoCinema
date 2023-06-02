using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Filme
    {
        [Key] 
        public int filme_id { get; set; }

        public string? nome_filme { get; set; }
    }
}