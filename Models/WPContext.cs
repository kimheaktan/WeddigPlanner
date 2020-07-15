using Microsoft.EntityFrameworkCore; 
namespace WeddingPlanner.Models
{
    public class WPContext : DbContext
    {
        public WPContext(DbContextOptions options) : base(options) { } 

         // tables in db    
        public DbSet<User> Users { get; set; }
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<RSVP> RSVPs { get; set; } 
    }
}