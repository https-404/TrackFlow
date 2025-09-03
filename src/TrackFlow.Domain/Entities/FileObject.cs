using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public enum StorageProvider { S3, Gcs, Azure, Local }

    public class FileObject
    {
        public Guid Id { get; set; }
        public required string Sha256Hex { get; set; } // UNIQUE
        public long ByteSize { get; set; }
        public required string ContentType { get; set; }
        public StorageProvider StorageProvider { get; set; }
        public required string StorageKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? WidthPx { get; set; }
        public int? HeightPx { get; set; }
        public int? DurationMs { get; set; }
        // Navigation
        public ICollection<FileVariant> Variants { get; set; } = new List<FileVariant>();
    }
}
