namespace AldoGiovanniGiacomo.API.DTOs
{
    public class DialogueDTO
    {
        /// <summary>
        /// Id of the dialogue resource
        /// </summary>
        public int Id { get; set; }
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
