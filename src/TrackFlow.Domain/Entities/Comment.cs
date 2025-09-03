using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Guid AuthorMembershipId { get; set; }
        public required string BodyMd { get; set; }
        public bool IsInternal { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? EditedAt { get; set; }
        public Ticket? Ticket { get; set; }
        public Membership? AuthorMembership { get; set; }
    }
}

