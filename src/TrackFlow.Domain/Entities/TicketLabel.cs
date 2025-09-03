using System;

namespace TrackFlow.Domain.Entities
{
    public class TicketLabel
    {
        public Guid TicketId { get; set; }
        public Guid LabelId { get; set; }

        public Ticket Ticket { get; set; }
        public Label Label { get; set; }
    }
}

