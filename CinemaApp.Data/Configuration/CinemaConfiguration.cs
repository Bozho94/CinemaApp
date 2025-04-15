using CinemaApp.Data.Models;
using CinemaAppCommon.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CinemaAppCommon.Constants.EntityConstants.Cinema;




namespace CinemaApp.Data.Configuration
{
    internal class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> entity)
        {
            // Define the primary key of the cinema entity
            entity
                .HasKey(c => c.Id);

            // Define constraints for the Name column
            entity
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            // Define constraints for the Location column
            entity
                .Property(c => c.Location)
                .IsRequired()
                .HasMaxLength(LocationMaxLength);

            // Define constraints for the IsDeleted column
            entity
                .Property(c => c.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            // Ensure that only existing records are used in the business logic
            entity
                .HasQueryFilter(c => c.IsDeleted == false);
        }
    }
}
