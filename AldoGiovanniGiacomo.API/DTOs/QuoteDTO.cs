using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.DTOs
{
    public class QuoteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public int ActorId { get; set; }
        public virtual ActorDTO Actor { get; set; }

        [Required]
        public int MovieId { get; set; }
        public virtual MovieDTO Movie { get; set; }
    }
}
