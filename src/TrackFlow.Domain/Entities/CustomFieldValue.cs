using System;

namespace TrackFlow.Domain.Entities
{
    public class CustomFieldValue
    {
        public required Guid TicketId { get; set; }
        public required Guid FieldDefId { get; set; }
        public string? VText { get; set; }
        public decimal? VNumber { get; set; }
        public bool? VBool { get; set; }
        public DateTime? VDate { get; set; }
        public Guid? VOptionId { get; set; }
        public Ticket? Ticket { get; set; }
        public CustomFieldDefinition? FieldDefinition { get; set; }
        public CustomFieldOption? Option { get; set; }
    }
}

