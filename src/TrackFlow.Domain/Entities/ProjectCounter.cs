using System;

namespace TrackFlow.Domain.Entities
{
    public class ProjectCounter
    {
        public Guid ProjectId { get; set; }
        public int NextTicketNumber { get; set; }

        public Project Project { get; set; }
    }
}

