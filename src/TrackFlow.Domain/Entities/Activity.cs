using System;

namespace TrackFlow.Domain.Entities
{
    public class Activity
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ActorMembershipId { get; set; }
        public string Verb { get; set; } // ENUM: created, updated, commented, moved, attached, closed, reopened
        public string ObjectType { get; set; } // ENUM: project, ticket, comment, file
        public Guid ObjectId { get; set; }
        public string MetaJson { get; set; }
        public DateTime CreatedAt { get; set; }

        public Company Company { get; set; }
        public Membership ActorMembership { get; set; }
    }
}

