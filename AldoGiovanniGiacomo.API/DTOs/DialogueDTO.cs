using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AldoGiovanniGiacomo.API.DTOs
{
    public class DialogueDTO
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public int MovieId { get; set; }
        public virtual MovieDTO Movie { get; set; }
    }
}
