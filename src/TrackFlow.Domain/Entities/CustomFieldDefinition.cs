using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public class CustomFieldDefinition
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; } // ENUM: text, number, bool, date, option
        public bool IsRequired { get; set; } = false;

        public Project Project { get; set; }
        public ICollection<CustomFieldOption> Options { get; set; }
        public ICollection<CustomFieldValue> Values { get; set; }
    }
}

