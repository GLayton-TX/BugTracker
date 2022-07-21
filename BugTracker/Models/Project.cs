using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTimeOffset EndDate { get; set; }

        [Display(Name = "Priority")]
        public int? ProjectProrityId { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        public byte[] FileData { get; set; }

        [Display(Name = "File Exstension")]
        public string FileContentType { get; set; }

        [Display(Name = "Archived")]
        public bool Archived { get; set; }

        public virtual Company Company { get; set; }

        public virtual ProjectPriority ProjectPriority { get; set; }

        public virtual ICollection<TrackerUser> Members { get; set; } = new HashSet<TrackerUser>();

        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}