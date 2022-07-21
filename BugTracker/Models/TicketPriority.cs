using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketPriority
    {
        public int Id { get; set; }

        [Display(Name="Prority Name")]
        public string Name { get; set; }
    }
}
