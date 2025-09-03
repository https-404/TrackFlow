using Microsoft.EntityFrameworkCore;
using TrackFlow.Domain.Entities;

namespace TrackFlow.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardColumn> BoardColumns { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<ChecklistItem> ChecklistItems { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<TicketLabel> TicketLabels { get; set; }
        public DbSet<CustomFieldDefinition> CustomFieldDefinitions { get; set; }
        public DbSet<CustomFieldOption> CustomFieldOptions { get; set; }
        public DbSet<CustomFieldValue> CustomFieldValues { get; set; }
        public DbSet<TicketEvent> TicketEvents { get; set; }
        public DbSet<FileObject> FileObjects { get; set; }
        public DbSet<FileVariant> FileVariants { get; set; }
        public DbSet<EntityAttachment> EntityAttachments { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<ProjectCounter> ProjectCounters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Composite keys
            modelBuilder.Entity<TicketLabel>().HasKey(tl => new { tl.TicketId, tl.LabelId });
            modelBuilder.Entity<CustomFieldValue>().HasKey(cf => new { cf.TicketId, cf.FieldDefId });
            modelBuilder.Entity<ProjectCounter>().HasKey(pc => pc.ProjectId);

            // Unique constraints and relationships can be further configured here as needed
            // Example: modelBuilder.Entity<Company>().HasIndex(c => c.Slug).IsUnique();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}