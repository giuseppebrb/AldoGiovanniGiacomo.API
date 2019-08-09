using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.DTOs
{
    /// <summary>
    /// ACTOR DTO
    /// </summary>
    public class ActorDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Nickname { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required]
        [MaxLength(50)]
        public string BirthPlace { get; set; }

        public virtual ICollection<QuoteDTO> Quotes { get; set; } = new List<QuoteDTO>();
    }
}
