using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class Board
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public required string Name { get; set; }
        // Navigation
        public Project? Project { get; set; }
        public ICollection<BoardColumn> Columns { get; set; } = new List<BoardColumn>();
    }
}

