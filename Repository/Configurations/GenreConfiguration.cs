using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            //=================Seeding Genres====================
            builder.HasData(
             new Genre() { GenreId = 1, Kind = "Drama" },
             new Genre() { GenreId = 2, Kind = "Comedy" },
             new Genre() { GenreId = 3, Kind = "Action" },
             new Genre() { GenreId = 4, Kind = "Adventure" },
             new Genre() { GenreId = 5, Kind = "Crime" },
             new Genre() { GenreId = 6, Kind = "Biography" },
             new Genre() { GenreId = 7, Kind = "Horror" },
             new Genre() { GenreId = 8, Kind = "Mystery" }
               );
        }
    }
}
