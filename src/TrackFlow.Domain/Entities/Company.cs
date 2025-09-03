using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; } // UNIQUE
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        // Navigation
        public ICollection<Membership> Memberships { get; set; } = new List<Membership>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}

