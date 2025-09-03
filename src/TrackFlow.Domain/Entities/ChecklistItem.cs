using System;

namespace TrackFlow.Domain.Entities
{
    public class ChecklistItem
    {
        public Guid Id { get; set; }
        public Guid ChecklistId { get; set; }
        public required string Title { get; set; }
        public bool IsDone { get; set; } = false;
        public int Position { get; set; }
        public Checklist? Checklist { get; set; }
    }
}

