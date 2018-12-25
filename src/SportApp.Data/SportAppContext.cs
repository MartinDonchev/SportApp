using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportApp.Areas.Identity.Data;
using SportApp.Data.Models;

namespace SportApp.Models
{
    public class SportAppContext : IdentityDbContext<SportAppUser>
    {
        public DbSet<Tournament> Tournaments { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<Stadium> Stadiums { get; set; }

        public SportAppContext(DbContextOptions<SportAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


            builder.Entity<Team>()
                       .HasMany(t => t.HomeMatches)
                       .WithOne(t => t.HomeTeam)
                       .HasForeignKey(m => m.HomeTeamId)
                       .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Team>()
                        .HasMany(t => t.AwayMatches)
                        .WithOne(t => t.AwayTeam)
                        .HasForeignKey(m => m.AwayTeamId)
                        .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
