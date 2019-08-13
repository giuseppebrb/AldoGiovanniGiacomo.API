using System.Collections.Generic;

namespace AldoGiovanniGiacomo.API.Models
{
    public class Dialogue
    {
        /// <summary>
        /// Text of the dialogue
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Title of the movie where the dialogue is taken from
        /// </summary>
        public string Movie { get; set; }
        /// <summary>
        /// Release year of the movie where the quote is taken from
        /// </summary>
        public int Year { get; set; }
    }
}
