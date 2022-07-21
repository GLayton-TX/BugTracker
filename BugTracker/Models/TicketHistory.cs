using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }

        [Display(Name ="Ticket")]
        public int TicketId { get; set; }

        [Display(Name ="Updated Item")]
        public string Property { get; set; }

        [Display(Name = "Previous")]
        public string OldValue { get; set; }

        [Display(Name = "Current")]
        public string NewValue { get; set; }

        [Display(Name = "Date Modified")]
        public DateTimeOffset Updated { get; set; }

        [Display(Name = "Description of Change")]
        public string Description { get; set; }

        [Display(Name = "Team Member")]
        public string TeamMember { get; set; }

        public virtual Ticket Ticket { get; set; }
        
        public virtual TrackerUser TrackerUser { get; set; }
    }
}
