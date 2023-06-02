using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Sala
    {
        [Key] 
        public int sala_id { get; set; }

        public int numero_sala { get; set; } 

        public int quantidade_assentos { get; set; }    

        public int assentos_criados { get; set; }   
    }
}