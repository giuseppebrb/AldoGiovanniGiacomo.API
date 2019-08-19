using System;
using System.Collections.Generic;

namespace AldoGiovanniGiacomo.API.Models
{
    /// <summary>
    /// Represents an actor
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// Id of the actor resource
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the actor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of the actor
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Nickname of the actor
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// DOB of the actor
        /// </summary>
        public DateTime Birth { get; set; }
        /// <summary>
        /// Born city of the actor
        /// </summary>
        public string BirthPlace { get; set; }

        /// <summary>
        /// Collection of quotes said by the actor
        /// </summary>
        public ICollection<Quote> Quotes { get; set; }
    }
}
