using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Checklist
    {
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public required string Title { get; set; }
        public int Position { get; set; }
        public Ticket? Ticket { get; set; }
        public ICollection<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();
    }
}

