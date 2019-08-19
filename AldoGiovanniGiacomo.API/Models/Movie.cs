using System.Collections.Generic;

namespace AldoGiovanniGiacomo.API.Models
{
    /// <summary>
    /// Represents an Aldo, Giovanni e Giacomo movie
    /// </summary>
    public class Movie
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
        public ICollection<Quote> Quotes { get; set; } = new List<Quote>();
        /// <summary>
        /// Collection of dialogues of the movie
        /// </summary>
        public ICollection<Dialogue> Dialogues { get; set; } = new List<Dialogue>();
    }
}
