using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.Models
{
    public class Quote
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }

        [Required]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
