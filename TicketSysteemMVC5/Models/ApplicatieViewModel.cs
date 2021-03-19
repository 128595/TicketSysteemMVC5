using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{
    /// <summary>
    /// Een Applicatie die wordt beheerd
    /// </summary>
    public class ApplicatieViewModel
    {
        /// <summary>
        /// Id, primary key, Identity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// De naam van de Applicatie
        /// </summary>
        [StringLength(64)]
        [Required]
        public string Naam { get; set; }

        /// <summary>
        /// De gebruiker die de Applicatie beheert
        /// </summary>
        public string BeheerderId { get; set; }

        // #2: M.W.D. Buis (20-12-2019): de Technicus.
        /// <summary>
        /// De technicus(sen) die de Applicatie beheert
        /// </summary>
        public string Technicus { get; set; }

        // #2: M.W.D. Buis (20-12-2019): een lijst van Technicussen.
        /// <summary>
        /// Lijst met Medewerkers om Beheerder te kiezen
        /// </summary>
        public List<ApplicationUser> Medewerkers { get; set; }

        /// <summary>
        /// De technicus(sen) die de Applicatie beheert
        /// </summary>
        public List<ApplicationUser> Technicussen { get; set; }
    }
}