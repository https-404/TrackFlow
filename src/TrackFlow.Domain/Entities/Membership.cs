using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Membership
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string? Title { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? DeactivatedAt { get; set; }
        // Navigation
        public Company? Company { get; set; }
        public User? User { get; set; }
        public ICollection<Ticket> ReportedTickets { get; set; } = new List<Ticket>();
        public ICollection<Ticket> AssignedTickets { get; set; } = new List<Ticket>();
    }
}

