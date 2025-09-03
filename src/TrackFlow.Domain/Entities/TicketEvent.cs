using System;

namespace TrackFlow.Domain.Entities
{
    public class TicketEvent
    {
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Guid ActorMembershipId { get; set; }
        public string Field { get; set; }
        public string FromValue { get; set; }
        public string ToValue { get; set; }
        public DateTime CreatedAt { get; set; }

        public Ticket Ticket { get; set; }
        public Membership ActorMembership { get; set; }
    }
}
