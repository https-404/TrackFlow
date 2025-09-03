using System;
using System.Collections.Generic;

namespace TrackFlow.Domain.Entities
{
    public enum StorageProvider { S3, Gcs, Azure, Local }

    public class FileObject
    {
        public Guid Id { get; set; }
        public string Sha256Hex { get; set; } = string.Empty; // UNIQUE
        public long ByteSize { get; set; }
        public string ContentType { get; set; } = string.Empty;
        public StorageProvider StorageProvider { get; set; }
        public string StorageKey { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public int? WidthPx { get; set; }
        public int? HeightPx { get; set; }
        public int? DurationMs { get; set; }
        // Navigation
        public ICollection<FileVariant> Variants { get; set; } = new List<FileVariant>();
    }
}
