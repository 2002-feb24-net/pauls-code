using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcProjectStarter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSongContext(serviceProvider.
                GetRequiredService<DbContextOptions<MvcSongContext>>()))
            {
                if (context.Song.Any())
                {
                    return;
                }

                context.Song.AddRange(
                    new Song
                    {
                        title = "Don't Stop Believin'",
                        artist = "Journey",
                        album = "Escape",
                        genre = "Classic Rock",
                        releaseDate = DateTime.Parse("1981-10-31")
                    },
                    new Song
                    {
                        title = "Thriller",
                        artist = "Michael Jackson",
                        album = "Thriller",
                        genre = "80's Pop",
                        releaseDate = DateTime.Parse("1982-11-30")
                    },

                    new Song
                    {
                        title = "Eye of the Tiger",
                        artist = "Survivor",
                        album = "Eye of the Tiger",
                        genre = "Classic Rock",
                        releaseDate = DateTime.Parse("1982-3-13")
                    }

                    );
                    context.SaveChanges();

            }

        }
    }
}
