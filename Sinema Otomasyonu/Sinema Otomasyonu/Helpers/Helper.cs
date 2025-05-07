using Sinema_Otomasyonu.Enum;
using Sinema_Otomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/frtcs/Desktop/GorselProgramlamaDiliC#/Sinema Otomasyonu/Sinema Otomasyonu/Pictures/";

            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Apocalypse Now",
                    category = Category.Savaş,
                    minute = "3 saat 20 dakika",
                    price = 50,
                    picturePath =basePath +"Apocalypse-Now.jpg",
                },
                new Movie()
                {
                    movieName = "2001 a space odyseey",
                    category = Category.bilim_kurgu,
                    minute = "3 saat 30 dakika",
                    price = 70,
                    picturePath =basePath +"indir.jpeg",
                },
                 new Movie()
                {
                    movieName = "Cinema Paradiso",
                    category = Category.dram,
                    minute = "2 saat 30 dakika",
                    price = 50,
                    picturePath =basePath +"cinemaparadiso.jpg",
                },
                  new Movie()
                {
                    movieName = "Drive",
                    category = Category.suç,
                    minute = "2 saat 20 dakika",
                    price = 50,
                    picturePath =basePath +"Drive2011.jpg",
                },
                   new Movie()
                {
                    movieName = "Dune part-two",
                    category = Category.bilim_kurgu,
                    minute = "2 saat 45 dakika",
                    price = 50,
                    picturePath =basePath +"Dune-Part-Two-2023-movie-poster.jpg",
                },
                    new Movie()
                {
                    movieName = "The Fall",
                    category = Category.macera,
                    minute = "2 saat 15 dakika",
                    price = 50,
                    picturePath =basePath +"thefall.jpg",
                },
            };
        }
    }
}
