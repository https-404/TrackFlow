using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public required string Key { get; set; } // UNIQUE(company_id, key)
        public required string Name { get; set; }
        public string? DescriptionMd { get; set; }
        public DateTime CreatedAt { get; set; }
        // Navigation
        public Company? Company { get; set; }
        public ICollection<Board> Boards { get; set; } = new List<Board>();
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public ICollection<Label> Labels { get; set; } = new List<Label>();
        public ICollection<CustomFieldDefinition> CustomFieldDefinitions { get; set; } = new List<CustomFieldDefinition>();
        public ProjectCounter? ProjectCounter { get; set; }
    }
}

