using Microsoft.EntityFrameworkCore;
using NoteProject.Models;

namespace NoteProject.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }
        public DbSet<Notes> Notes { get; set; }
        //public DbSet<Tag> Tag { get; set; }
        //public DbSet<Reminder> Reminder { get; set; }

    }
}