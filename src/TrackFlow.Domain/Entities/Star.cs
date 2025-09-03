using System;

namespace TrackFlow.Domain.Entities
{
    public class Star
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string EntityType { get; set; } // ENUM: project, ticket
        public Guid EntityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public User? User { get; set; }
    }
}
