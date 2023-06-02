using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Cliente
    {
        [Key] 
        public int cliente_id { get; set; }

        public string? nome_cliente { get; set; }
    }
}