namespace AldoGiovanniGiacomo.API.Models
{
    public class Quote
    {
        /// <summary>
        /// Id of the quote resource
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Fullname of the acor that said the quote
        /// </summary>
        public string Actor { get; set; }
        /// <summary>
        /// Text of the quote
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Title of the movie where the quote is taken from
        /// </summary>
        public string Movie { get; set; }
        /// <summary>
        /// Release year of the movie where the quote is taken from
        /// </summary>
        public int Year { get; set; }
    }
}
