using Microsoft.EntityFrameworkCore;

namespace QueryData
{
    public partial class ArtistsContext : DbContext
    {
        public ArtistsContext() { }

        public ArtistsContext(DbContextOptions<ArtistsContext> options) : base(options) { }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlite("data source=output/Artists.db")
                    .LogTo(
                        Console.WriteLine,
                        new[] { DbLoggerCategory.Database.Command.Name },
                        Microsoft.Extensions.Logging.LogLevel.Information
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(
                entity =>
                {
                    entity
                        .HasOne(d => d.Employee)
                        .WithMany(p => p.Albums)
                        .HasForeignKey(d => d.EmployeeId)
                        .OnDelete(DeleteBehavior.ClientSetNull);

                    entity
                        .HasMany(d => d.Tags)
                        .WithMany(p => p.Albums)
                        .UsingEntity<Dictionary<string, object>>(
                            "AlbumTag",
                            l => l.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
                            r => r.HasOne<Album>().WithMany().HasForeignKey("AlbumId"),
                            j =>
                            {
                                j.HasKey("AlbumId", "TagId");

                                j.ToTable("AlbumTags");
                            }
                        );
                }
            );

            modelBuilder.Entity<Studio>(
                entity =>
                {
                    entity
                        .HasOne(d => d.Employee)
                        .WithOne(p => p.Studio)
                        .HasForeignKey<Studio>(d => d.EmployeeId)
                        .OnDelete(DeleteBehavior.ClientSetNull);
                }
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
