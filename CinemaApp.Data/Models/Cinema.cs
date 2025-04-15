using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Kerberos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Models
{
    [Comment("Cinemas in the system")]
    public class Cinema
    {
        
        [Comment("Cinema identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(256)]
        [Comment("Cinema name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(256)]
        [Comment("Cinema location")]
        public string Location { get; set; } = null!;

        [Comment("Shows if cinema is deleted")]
        public bool IsDeleted { get; set; }

        // ICollection<T> is used for higher abstraction
        public ICollection<CinemaMovie> CinemaMoives { get; set; } =
            new List<CinemaMovie>();

        public ICollection<Ticket> Tickets { get; set; }
            = new HashSet<Ticket>();


    }
}
