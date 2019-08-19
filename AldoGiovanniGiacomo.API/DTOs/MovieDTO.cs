using System.Collections.Generic;

namespace AldoGiovanniGiacomo.API.DTOs
{
    /// <summary>
    /// Represents an Aldo, Giovanni e Giacomo movie
    /// </summary>
    public class MovieDTO
    {
        /// <summary>
        /// Id of the Movie resource
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title of the movie
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Release year of the movie
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Director of the movie
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Collection of quotes of the movie
        /// </summary>
        public ICollection<QuoteDTO> Quotes { get; set; } = new List<QuoteDTO>();
        /// <summary>
        /// Collection of dialogues of the movie
        /// </summary>
        public ICollection<DialogueDTO> Dialogues { get; set; } = new List<DialogueDTO>();
    }
}
