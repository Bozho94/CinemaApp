using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
    [Comment("Movie in the system")]
    public class Movie
    {
        
        [Comment("Movie indetifier")]
        public Guid Id { get; set; }

        
        [Required]
        [MaxLength(150)]
        [Comment("Movie title")]
        public string Title { get; set; } = null!;


        [Required]
        [MaxLength(30)]
        [Comment("Movie genre")]
        public string Genre { get; set; } = null!;

        [Required]
        [Comment("Movie release date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [MaxLength(150)]
        [Comment("Movie director")]
        public string Director { get; set; } = null!;

        [Required]
        [Comment("Movie duration")]
        public int Duration { get; set; }

        [Required]
        [MaxLength(1024)]
        [Comment("Movie description")]
        public string Description { get; set; } = null!;

        [MaxLength(256)]
        [Comment("Movie image url from the image store")]
        public string? ImageUrl { get; set; }

        [Comment("Shows if movie is deleted")]
        public bool IsDeleted { get; set; }

        // ICollection is used for higher abstraction
        // HashSet<T> is used since many users can add the movie to watchlist
        // and many tickets can be sold for single movie
        public ICollection<CinemaMovie> MovieCinemas { get; set; }
        = new HashSet<CinemaMovie>();

        public ICollection<ApplicationUserMovie> MovieApplicationUsers { get; set; }
        = new HashSet<ApplicationUserMovie>();

        public ICollection<Ticket> Tickets { get; set; }
        = new HashSet<Ticket>();


    } 
}