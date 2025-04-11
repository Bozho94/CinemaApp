using CinemaApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data
{
    public class CinemaAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public CinemaAppDbContext(DbContextOptions<CinemaAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUserMovie> ApplicationUserMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<CinemaMovie> CinemaMovies { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}
