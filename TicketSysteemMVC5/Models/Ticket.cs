using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{
    public enum TicketStatus
    {
        Nieuw,
        Bezet,
        Afgerond,
        Doorgevoerd,
        Retour,
        Incompleet,
        Test,
        Beheer,
    }

    /// <summary>
    /// Ticket voor Applicatiebeheer
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Id, primary key, Identity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// De Klant die de Ticket inlegt.
        /// <para>Wordt automatisch toegevoegd aan de hand van login</para>
        /// </summary>
        [Required]
        public ApplicationUser Klant { get; set; }

        /// <summary>
        /// De betreffende Applicatie
        /// </summary>
        [Required]
        public Applicatie Applicatie { get; set; }

        /// <summary>
        /// De datum waarop de ticket is gemaakt.
        /// <para>Wordt Automatisch toegevoegd</para>
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Datum { get; set; }

        /// <summary>
        /// Het onderwerp van de Ticket
        /// </summary>
        [StringLength(128)]
        [Required]
        public string Onderwerp { get; set;  }

        /// <summary>
        /// De omschrijving van de Ticket
        /// </summary>
        [StringLength(512)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Status van de Ticket
        /// <para>Standaardwaarde is "Nieuw</para>
        /// </summary>
        public TicketStatus Status { get; set; } = TicketStatus.Nieuw;

        /// <summary>
        /// #2: M.W.D. Buis (04-12-2019): model eigenschap toegevoegd voor het opslaan van meerdere technicus.
        /// </summary>
        public List<ApplicationUser> Technicussen { get; set; }
    }
}