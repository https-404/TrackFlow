using System;

namespace TrackFlow.Domain.Entities
{
    public class TicketLabel
    {
        public required Guid TicketId { get; set; }
        public required Guid LabelId { get; set; }
        public Ticket? Ticket { get; set; }
        public Label? Label { get; set; }
    }
}

