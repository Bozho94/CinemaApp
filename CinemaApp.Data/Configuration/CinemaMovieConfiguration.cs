using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaAppCommon.Constants.EntityConstants.CinemaMovie;

namespace CinemaApp.Data.Configuration
{
    internal class CinemaMovieConfiguration : IEntityTypeConfiguration<CinemaMovie>
    {
        public void Configure(EntityTypeBuilder<CinemaMovie> entity)
        {
            //Define the primary key of the CinemaMovie entity
            entity
                .HasKey(cm => cm.Id);

            //Define constraints for MovieId column

            entity
                .Property(cm => cm.MovieId)
                .IsRequired();

            //Define constraints for CinemaId column
            entity
               .Property(cm => cm.CinemaId)
               .IsRequired();

            //Define constraints for AvailableTickets column
            entity
                .Property(cm => cm.AvailableTickets)
                .IsRequired();

            //Define constraints for IsDeleted column

            entity
                .Property(cm => cm.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            //Define constraints for Showtimes column

            entity
                .Property(cm => cm.Showtimes)
                .IsRequired(false)
                .IsUnicode(false)
                .HasMaxLength(ShowtimesMaxLength)
                .HasDefaultValue(ShowTimesDefaultFormat);

            //Define relation between the CinemaMovie and Movie entities
            entity
                .HasOne(cm => cm.Movie)
                .WithMany(m => m.MovieCinemas)
                .HasForeignKey(cm => cm.MovieId)
                .OnDelete(DeleteBehavior.NoAction);

            //Relation between the CinemaMovie and Cinema entities
            entity
                .HasOne(cm => cm.Cinema)
                .WithMany(c => c.CinemaMoives)
                .HasForeignKey(cm => cm.CinemaId)
                .OnDelete(DeleteBehavior.NoAction);

            entity
                .HasQueryFilter(c => c.IsDeleted == false);


            //Define uniqe index as a combination of the foreign keys to Cinema and Movie entities
            entity
                .HasIndex(cm => new { cm.CinemaId, cm.MovieId })
                .IsUnique();

        }
    }
}
