using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class BoardColumn
    {
        public Guid Id { get; set; }
        public Guid BoardId { get; set; }
        public required string Name { get; set; }
        public int Position { get; set; }
        public int? WipLimit { get; set; }
        // Navigation
        public Board? Board { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
