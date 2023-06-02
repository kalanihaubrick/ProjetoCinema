using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Reserva
    {
        [Key] 
        public int reserva_id { get; set; }

        public int sessao_id { get; set; } 

        public int cliente_id { get; set; }    

        public int assento_id { get; set; }   
    }
}