using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.Models
{
    public class Dialogue
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
