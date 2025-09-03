using System;

namespace TrackFlow.Domain.Entities
{
    public class CustomFieldOption
    {
        public Guid Id { get; set; }
        public Guid FieldDefId { get; set; }
        public required string Value { get; set; }
        public required string Label { get; set; }
        public int Position { get; set; } = 0;
        public CustomFieldDefinition? FieldDefinition { get; set; }
    }
}

