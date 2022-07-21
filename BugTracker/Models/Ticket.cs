﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated")]
        public DateTimeOffset? Updated { get; set; }

        [Display(Name = "Archived")]
        public bool Archived { get; set; }

        [Display(Name = "Project")]
        public int ProjectId { get; set; }

        [Display(Name = "Ticket Type")]
        public int TicketTypeId { get; set; }

        [Display(Name = "Ticket Priority")]
        public int TicketPriorityId { get; set; }

        [Display(Name = "Ticket Status")]
        public int TicketStatusId { get; set; }

        [Display(Name = "Ticket Owner")]
        public string OwnerUserId { get; set; }

        [Display(Name = "Ticket developer")]
        public string DeveloperUserId { get; set; }

        public virtual Project Project { get; set; }

        public virtual TicketType TicketType { get; set; }

        public virtual TicketPriority TicketPriority { get; set; }

        public virtual TicketStatus TicketStatus { get; set; }

        public virtual TrackerUser OwnerUser { get; set; }

        public virtual TrackerUser DeveloperUser { get; set; }

        public virtual ICollection<TicketComment> Comments { get; set; } = new HashSet<TicketComment>();

        public virtual ICollection<TicketAttachment> Attachments { get; set; } = new HashSet<TicketAttachment>();

        public virtual ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();

        public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new HashSet<TicketHistory>();
    }
}