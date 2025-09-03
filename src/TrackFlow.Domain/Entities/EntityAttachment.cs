using System;

namespace TrackFlow.Domain.Entities
{
    public class EntityAttachment
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid FileId { get; set; }
        public string EntityType { get; set; } // ENUM: project, ticket, comment, user, company
        public Guid EntityId { get; set; }
        public Guid UploadedByMembershipId { get; set; }
        public string Title { get; set; }
        public string NoteMd { get; set; }
        public DateTime CreatedAt { get; set; }

        public Company Company { get; set; }
        public FileObject File { get; set; }
        public Membership UploadedByMembership { get; set; }
    }
}

