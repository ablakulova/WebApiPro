using Microsoft.EntityFrameworkCore;
using WebApiPro.Application.Interfaces;
using WebApiPro.Domain;
using WebApiPro.Persistence.EntityTypeConfigurations;

namespace WebApiPro.Persistence
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
