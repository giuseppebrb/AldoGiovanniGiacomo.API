using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(100)]
        public string Director { get; set; }

        public virtual ICollection<QuoteDTO> Quotes { get; set; } = new List<QuoteDTO>();
    }
}
