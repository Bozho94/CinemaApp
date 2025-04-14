using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace CinemaApp.Data.Models
{
    [Comment("Movies in a cinema with available tickets and scedule")]
    public class CinemaMovie
    {
        [Key]
        public Guid Id { get; set; }


        [Comment("Foreign key to the movie")]
        public Guid MovieId { get; set; }

        public Movie Movie { get; set; } = null!;

        public Guid CinemaId { get; set; }

        public Cinema Cinema { get; set; } = null!;

        [Comment("Amount of available tickets for this movie in this cinema")]
        public int AvailableTickets { get; set; }

        [Comment("Shows if movie in a cinema is deleted")]
        public bool IsDeleted { get; set; }

        [Unicode(false)]
        [MaxLength(5)]
        [Comment("Showtimes for the movie in the cinema")]
        public string Showtimes { get; set; } = "00000";


        // ICollection is used as a type to benefit from higher abstraction
        //We dont expect high amount of tickets so we use List<T>
        public ICollection<Ticket> Tickets { get; set; }
        = new List<Ticket>();
    }
}