using System;

namespace TrackFlow.Domain.Entities
{
    public class FileVariant
    {
        public Guid Id { get; set; }
        public Guid OriginalFileId { get; set; }
        public string Purpose { get; set; } // ENUM: thumbnail, preview, webp, av1, mp3, pdf-preview
        public int? WidthPx { get; set; }
        public int? HeightPx { get; set; }
        public long ByteSize { get; set; }
        public string ContentType { get; set; }
        public string StorageProvider { get; set; }
        public string StorageKey { get; set; }
        public DateTime CreatedAt { get; set; }

        public FileObject OriginalFile { get; set; }
    }
}

