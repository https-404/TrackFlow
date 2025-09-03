using System;

namespace TrackFlow.Domain.Entities
{
    public class ProjectCounter
    {
        public required Guid ProjectId { get; set; }
        public required int NextTicketNumber { get; set; }
        public Project? Project { get; set; }
    }
}

