using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public enum TicketType { Task, Bug, Story, Epic }
    public enum TicketPriority { Low, Medium, High, Critical }

    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid BoardColumnId { get; set; }
        public int Number { get; set; } // UNIQUE(project_id, number)
        public required string Title { get; set; }
        public string? DescriptionMd { get; set; }
        public TicketType Type { get; set; }
        public TicketPriority Priority { get; set; }
        public Guid ReporterMembershipId { get; set; }
        public Guid? AssigneeMembershipId { get; set; }
        public Guid? ParentTicketId { get; set; }
        public decimal? EstimatePoints { get; set; }
        public DateTime? DueAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        // Navigation
        public Project? Project { get; set; }
        public BoardColumn? BoardColumn { get; set; }
        public Membership? ReporterMembership { get; set; }
        public Membership? AssigneeMembership { get; set; }
        public Ticket? ParentTicket { get; set; }
        public ICollection<Ticket> SubTickets { get; set; } = new List<Ticket>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Checklist> Checklists { get; set; } = new List<Checklist>();
        public ICollection<TicketLabel> TicketLabels { get; set; } = new List<TicketLabel>();
        public ICollection<CustomFieldValue> CustomFieldValues { get; set; } = new List<CustomFieldValue>();
        public ICollection<TicketEvent> TicketEvents { get; set; } = new List<TicketEvent>();
    }
}

