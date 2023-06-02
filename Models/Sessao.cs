using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Sessao
    {
        [Key] 
        public int sessao_id { get; set; }

        public int sala_id { get; set; } 

        public int filme_id { get; set; }    

        public DateTime horario { get; set; }   
    }
}