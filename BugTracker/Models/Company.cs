using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "Company Name")]
        public string Name { get; set; }

        [Display(Name = "Company Description")]
        public string Description { get; set; }

        public virtual ICollection<TrackerUser> MyProperty { get; set; } = new HashSet<TrackerUser>();
        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}