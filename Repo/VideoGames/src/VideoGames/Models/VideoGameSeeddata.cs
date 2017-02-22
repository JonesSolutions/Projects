using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGames.Data;

namespace VideoGames.Models
{
    public class VideoGameSeeddata
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if(!context.Rating.Any())
                {
                    context.Rating.AddRange(
                        new Rating {Description="eC"},
                        new Rating { Description = "E" },
                        new Rating { Description = "10+e" },
                        new Rating { Description = "T" },
                        new Rating { Description = "M" },
                        new Rating { Description = "Ao" },
                        new Rating { Description = "RP" }
                        );
                    context.SaveChanges();
                }
                if(context.VideoGame.Any())
                {
                    return;
                }

                context.VideoGame.AddRange(
                   new VideoGame
                   {
                       Title="Call of Duty",
                       Genre="FPS",
                       Platform="Multi",
                       Price=20M,
                       Publisher="Infinity Ward",
                       RatingId=1,
                       ReleaseDate=DateTime.Parse("01/01/2003"),
                   },
                    new VideoGame
                    {
                        Title = "Call of Duty 2",
                        Genre = "FPS",
                        Platform = "Multi",
                        Price = 20M,
                        Publisher = "Infinity Ward",
                        RatingId = 2,
                        ReleaseDate = DateTime.Parse("01/01/2004"),
                    },
                     new VideoGame
                     {
                         Title = "Call of Duty 3",
                         Genre = "FPS",
                         Platform = "Multi",
                         Price = 20M,
                         Publisher = "Infinity Ward",
                         RatingId = 3,
                         ReleaseDate = DateTime.Parse("01/01/2005"),
                     }
                    );
                context.SaveChanges();
            }
             }
    }
}
