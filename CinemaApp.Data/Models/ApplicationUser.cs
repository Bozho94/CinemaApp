﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        // ICollection<T> is used as a type to benefit from higher abstraction
        // HashSet<T> is chose as implementation type, since users can add many movies to watchlist and will benefit from the look-up times
        public ICollection<ApplicationUserMovie> Watchlist { get; set; }
        = new HashSet<ApplicationUserMovie>();

        public ICollection<Ticket> Tickets { get; set; }
        = new HashSet<Ticket>();
    }
}
