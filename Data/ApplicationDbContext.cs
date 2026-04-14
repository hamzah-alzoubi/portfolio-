using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using portfoilo.Models;

namespace portfoilo.Data
{
    
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Skills> Skills { get; set; }

        public DbSet<Message> Messages { get; set; }

    }
    }
