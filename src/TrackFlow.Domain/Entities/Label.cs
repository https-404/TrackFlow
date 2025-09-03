using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Label
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public required string Name { get; set; }
        public required string Color { get; set; }
        public int Position { get; set; } = 0;
        public Project? Project { get; set; }
        public ICollection<TicketLabel> TicketLabels { get; set; } = new List<TicketLabel>();
    }
}
