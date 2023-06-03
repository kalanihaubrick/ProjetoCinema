using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Assento
    {
        [Key] 
        public int assento_id { get; set; }

        public char fileira { get; set; }    

        public int numero { get; set; } 

        public int sala_id { get; set; }

        public string? Status { get; set; }

        public string? assento { get; set; }
    }
}