using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class CustomFieldDefinition
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public required string Name { get; set; }
        public required string DataType { get; set; } // ENUM: text, number, bool, date, option
        public bool IsRequired { get; set; } = false;
        public Project? Project { get; set; }
        public ICollection<CustomFieldOption> Options { get; set; } = new List<CustomFieldOption>();
        public ICollection<CustomFieldValue> Values { get; set; } = new List<CustomFieldValue>();
    }
}

