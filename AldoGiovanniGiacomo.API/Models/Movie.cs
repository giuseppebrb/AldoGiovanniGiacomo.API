using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.Models
{
    public class Movie
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

        public virtual ICollection<Quote> Quotes { get; set; } = new List<Quote>();
        public virtual ICollection<Dialogue> Dialogues { get; set; } = new List<Dialogue>();
    }
}
