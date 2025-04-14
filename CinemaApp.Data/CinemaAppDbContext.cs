using CinemaApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data
{
    public class CinemaAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        //This constructor is introduced for debugging purposes
        public CinemaAppDbContext()
        {
            
        }

        public CinemaAppDbContext(DbContextOptions<CinemaAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUserMovie> ApplicationUserMovies { get; set; } = null!;
        public DbSet<Cinema> Cinemas { get; set; } = null!;

        public DbSet<CinemaMovie> CinemaMovies { get; set; } = null!;

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Ticket> Tickets { get; set; } = null!;

    }
}
