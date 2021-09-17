using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Models;
using System;
using System.Collections.Generic;

namespace JapTask1BackendCorrection.Data.Seeders
{
    public class MediaSeed
    {
        public static List<Media> Medias { get; } = new()
        {
            new Media
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 2,
                Title = "The Godfather",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 3,
                Title = "The Godfather: Part II",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 4,
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 5,
                Title = "12 Angry Men",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 6,
                Title = "Schindler's List",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 7,
                Title = "The Lord of the Rings: The Return of the King",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 8,
                Title = "Pulp Fiction",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 9,
                Title = "The Good, the Bad and the Ugly",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 10,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 11,
                Title = "Fight Club",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 12,
                Title = "Forrest Gump",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 13,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },

            // series
            new Media
            {
                Id = 14,
                Title = "Planet Earth II",
                Description = "Wildlife documentary series with David Attenborough, beginning with a look at the remote islands which offer sanctuary to some of the planet's rarest creatures, to the beauty of cities, which are home to humans, and animals..",
                ImageUrl = "https://blackwells.co.uk/jacket/l/9781785943041.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2016, 11, 6)
            },
            new Media
            {
                Id = 15,
                Title = "Planet Earth",
                Description = "Emmy Award-winning, 11 episodes, five years in the making, the most expensive nature documentary series ever commissioned by the BBC, and the first to be filmed in high definition.",
                ImageUrl = "https://m.media-amazon.com/images/I/91X9p6+58KL._SY445_.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2010, 4, 5)
            },
            new Media
            {
                Id = 16,
                Title = "Breaking Bad",
                Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/ggFHVNu6YYI5L9pCfOacjizRGt.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2008, 1, 20)
            },
            new Media
            {
                Id = 17,
                Title = "Band of Brothers",
                Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.",
                ImageUrl = "https://i.dailymail.co.uk/i/pix/2017/02/13/01/3D24EF6B00000578-4215748-image-a-63_1486948627611.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2001, 9, 9)
            },
            new Media
            {
                Id = 18,
                Title = "Chernobyl",
                Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
                ImageUrl = "https://i.redd.it/bv5isr69yr531.png",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(1986, 4, 26)
            },
            new Media
            {
                Id = 19,
                Title = "The Wire",
                Description = "The Baltimore drug scene, as seen through the eyes of drug dealers and law enforcement.",
                ImageUrl = "https://tvshows.today/wp-content/uploads/the-wire-season-1-poster.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2008, 4, 9)
                
            },
            new Media
            {
                Id = 20,
                Title = "Blue Planet II",
                Description = "David Attenborough returns to the world's oceans in this sequel to the acclaimed documentary filming rare and unusual creatures of the deep, as well as documenting the problems our oceans face.",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0747/3829/products/mL1006_1024x1024.jpg?v=1571445246",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2017, 10, 29)
            },
            new Media
            {
                Id = 21,
                Title = "Our Planet",
                Description = "Documentary series focusing on the breadth of the diversity of habitats around the world, from the remote Arctic wilderness and mysterious deep oceans to the vast landscapes of Africa and diverse jungles of South America.",
                ImageUrl = "https://www.penguin.co.uk/content/dam/prh/books/111/1115210/9780593079768.jpg.transform/PRHDesktopWide_small/image.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2019, 4, 5)
            },
            new Media
            {
                Id = 22,
                Title = "Cosmos: A Spacetime Odyssey",
                Description = "An exploration of our discovery of the laws of nature and coordinates in space and time.",
                ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5945/5945188_sa.jpg;maxHeight=640;maxWidth=550",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2014, 4, 9)
            },
            new Media
            {
                Id = 23,
                Title = "Avatar: The Last Airbender",
                Description = "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/914eUC4XPML.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2005, 2, 21)
            },
            new Media
            {
                Id = 24,
                Title = "Cosmos",
                Description = "Astronomer Carl Sagan leads us on an engaging guided tour of the various elements and cosmological theories of the universe.",
                ImageUrl = "https://www.themoviedb.org/t/p/original/4WJ9kNejI8apl3f8hMNwo8V3hGT.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(1980, 12, 21)
            },
            new Media
            {
                Id = 25,
                Title = "Game of Thrones",
                Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(2011, 4, 17)
            },
            new Media
            {
                Id = 26,
                Title = "The Sopranos",
                Description = "New Jersey mob boss Tony Soprano deals with personal and professional issues in his home and business life that affect his mental state, leading him to seek professional psychiatric counseling.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGJjYzhjYTYtMDBjYy00OWU1LTg5OTYtNmYwOTZmZjE3ZDdhXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg",
                Type = MediaEnum.Show,
                ReleaseDate = new DateTime(1999, 1, 10)
            },
            //movies
            new Media
            {
                Id = 27,
                Title = "The Shawshank Redemption 2",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 28,
                Title = "The Godfather 2",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 29,
                Title = "The Godfather: Part II 2",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 30,
                Title = "The Dark Knight 2",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 31,
                Title = "12 Angry Men 2",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 32,
                Title = "Schindler's List 2",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 33,
                Title = "The Lord of the Rings: The Return of the King 2",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 34,
                Title = "Pulp Fiction 2",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 35,
                Title = "The Good, the Bad and the Ugly 2",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 36,
                Title = "The Lord of the Rings: The Fellowship of the Ring 2",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 37,
                Title = "Fight Club 2",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 38,
                Title = "Forrest Gump 2",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 39,
                Title = "Inception 2",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 40,
                Title = "The Shawshank Redemption 3",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 41,
                Title = "The Godfather 3",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 42,
                Title = "The Godfather: Part II 3",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 43,
                Title = "The Dark Knight 3",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 44,
                Title = "12 Angry Men 3",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 45,
                Title = "Schindler's List 3",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 46,
                Title = "The Lord of the Rings: The Return of the King 3",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 47,
                Title = "Pulp Fiction 3",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 48,
                Title = "The Good, the Bad and the Ugly 3",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 49,
                Title = "The Lord of the Rings: The Fellowship of the Ring 3",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 50,
                Title = "Fight Club 3",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 51,
                Title = "Forrest Gump 3",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 52,
                Title = "Inception 3",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 53,
                Title = "The Shawshank Redemption 4",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 54,
                Title = "The Godfather 4",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 55,
                Title = "The Godfather: Part II 4",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 56,
                Title = "The Dark Knight 4",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 57,
                Title = "12 Angry Men 4",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 58,
                Title = "Schindler's List 4",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 59,
                Title = "The Lord of the Rings: The Return of the King 4",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 60,
                Title = "Pulp Fiction 4",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 61,
                Title = "The Good, the Bad and the Ugly 4",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 62,
                Title = "The Lord of the Rings: The Fellowship of the Ring 4",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 63,
                Title = "Fight Club 4",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 64,
                Title = "Forrest Gump 4",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 65,
                Title = "Inception 4",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 66,
                Title = "Inception 4444",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            new Media
            {
                Id = 67,
                Title = "The Shawshank Redemption 5",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 68,
                Title = "The Godfather 5",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 69,
                Title = "The Godfather: Part II 5",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 70,
                Title = "The Dark Knight 5",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 71,
                Title = "12 Angry Men 5",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 72,
                Title = "Schindler's List 5",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 73,
                Title = "The Lord of the Rings: The Return of the King 5",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 74,
                Title = "Pulp Fiction 5",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 75,
                Title = "Pulp Fiction 51",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 76,
                Title = "Pulp Fiction 52",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 77,
                Title = "Pulp Fiction 53",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 78,
                Title = "The Good, the Bad and the Ugly 5",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 79,
                Title = "The Good, the Bad and the Ugly 51",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 80,
                Title = "The Lord of the Rings: The Fellowship of the Ring 5",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 81,
                Title = "Fight Club 5",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 82,
                Title = "Forrest Gump 5",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 83,
                Title = "Inception 5",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 84,
                Title = "The Shawshank Redemption 6",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 85,
                Title = "The Godfather 6",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 86,
                Title = "The Godfather: Part II 6",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 87,
                Title = "The Dark Knight 6",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            new Media
            {
                Id = 88,
                Title = "12 Angry Men 6",
                Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/12_Angry_Men_%281957_film_poster%29.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1957, 4, 1)
            },
            new Media
            {
                Id = 89,
                Title = "Schindler's List 6",
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/c617e634647543.56d846b10d56f.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 2, 4)
            },
            new Media
            {
                Id = 90,
                Title = "The Lord of the Rings: The Return of the King 6",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ImageUrl = "https://img.discogs.com/MsgjJVAxVCXb1w86ffIbaNRr2BY=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-728620-1512923411-4779.jpeg.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2003, 12, 1)
            },
            new Media
            {
                Id = 91,
                Title = "Pulp Fiction 6",
                Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                ImageUrl = "https://prod.miramax.digital/media/assets/Pulp-Fiction1.png",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 10, 14)
            },
            new Media
            {
                Id = 92,
                Title = "The Good, the Bad and the Ugly 6",
                Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/45/Good_the_bad_and_the_ugly_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1996, 12, 23)
            },
            new Media
            {
                Id = 93,
                Title = "The Lord of the Rings: The Fellowship of the Ring 6",
                Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                ImageUrl = "https://images.moviesanywhere.com/198e228b071c60f5ad57e5f62fe60029/ff22cad6-2218-414d-b853-3f95d76905c7.jpg?h=375&resize=fit&w=250",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2001, 12, 19)
            },
            new Media
            {
                Id = 94,
                Title = "Fight Club 6",
                Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                ImageUrl = "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1999, 11, 11)
            },
            new Media
            {
                Id = 95,
                Title = "Forrest Gump 6",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 96,
                Title = "Inception 6",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 97,
                Title = "The Shawshank Redemption 7",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 98,
                Title = "The Godfather 7",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 99,
                Title = "The Godfather: Part II 7",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 100,
                Title = "The Dark Knight 7",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            },
            //
            new Media
            {
                Id = 101,
                Title = "Forrest Gump 66",
                Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
                ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/37a5b434647543.56d846b10ca45.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 7, 6)
            },
            new Media
            {
                Id = 102,
                Title = "Inception 66",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                ImageUrl = "https://m.media-amazon.com/images/I/81p+xe8cbnL._SY445_.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2010, 7, 22)
            },
            //
            new Media
            {
                Id = 103,
                Title = "The Shawshank Redemption 76",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1994, 9, 22)
            },
            new Media
            {
                Id = 104,
                Title = "The Godfather 76",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1972, 3, 24)
            },
            new Media
            {
                Id = 105,
                Title = "The Godfather: Part II 76",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(1974, 12, 20)
            },
            new Media
            {
                Id = 106,
                Title = "The Dark Knight 76",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/sh/8/83/Dark_knight_rises_poster.jpg",
                Type = MediaEnum.Movie,
                ReleaseDate = new DateTime(2008, 7, 18)
            }
        };
    }
}
