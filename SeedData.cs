namespace Team2Project.Models;

public static class SeedData
{
    public static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Id = 1,
                Name = "Babel",
                Author = "R.F. Kuang",
                PublicationDate = new DateTime(2022, 8, 23),
                Editorial = "Harper Voyager",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 2,
                Name = "Crying in H Mart",
                Author = "Michelle Zauner",
                PublicationDate = new DateTime(2021, 4, 20),
                Editorial = "Knopf",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 3,
                Name = "Dark Matter",
                Author = "Blake Crouch",
                PublicationDate = new DateTime(2016, 7, 26),
                Editorial = "Crown",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 4,
                Name = "Fourth Wing",
                Author = "Rebecca Yarros",
                PublicationDate = new DateTime(2023, 5, 2),
                Editorial = "Entangled Publishing",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 5,
                Name = "Girl in Pieces",
                Author = "Kathleen Glasgow",
                PublicationDate = new DateTime(2016, 8, 30),
                Editorial = "Delacorte Press",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 6,
                Name = "Heart Bones",
                Author = "Colleen Hoover",
                PublicationDate = new DateTime(2020, 8, 19),
                Editorial = "Montlake Romance",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 7,
                Name = "The Midnight Library",
                Author = "Matt Haig",
                PublicationDate = new DateTime(2020, 9, 29),
                Editorial = "Canongate Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 8,
                Name = "The Song of Achilles",
                Author = "Madeline Miller",
                PublicationDate = new DateTime(2011, 9, 20),
                Editorial = "Ecco",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 9,
                Name = "Project Hail Mary",
                Author = "Andy Weir",
                PublicationDate = new DateTime(2021, 5, 4),
                Editorial = "Ballantine Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 10,
                Name = "The Invisible Life of Addie LaRue",
                Author = "V.E. Schwab",
                PublicationDate = new DateTime(2020, 10, 6),
                Editorial = "Tor Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 11,
                Name = "The Seven Husbands of Evelyn Hugo",
                Author = "Taylor Jenkins Reid",
                PublicationDate = new DateTime(2017, 6, 13),
                Editorial = "Atria Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 12,
                Name = "Dune",
                Author = "Frank Herbert",
                PublicationDate = new DateTime(1965, 8, 1),
                Editorial = "Chilton Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 13,
                Name = "Circe",
                Author = "Madeline Miller",
                PublicationDate = new DateTime(2018, 4, 10),
                Editorial = "Little, Brown and Company",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 14,
                Name = "The Night Circus",
                Author = "Erin Morgenstern",
                PublicationDate = new DateTime(2011, 9, 13),
                Editorial = "Doubleday",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 15,
                Name = "Atomic Habits",
                Author = "James Clear",
                PublicationDate = new DateTime(2018, 10, 16),
                Editorial = "Avery",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 16,
                Name = "The Silent Patient",
                Author = "Alex Michaelides",
                PublicationDate = new DateTime(2019, 2, 5),
                Editorial = "Celadon Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 17,
                Name = "Where the Crawdads Sing",
                Author = "Delia Owens",
                PublicationDate = new DateTime(2018, 8, 14),
                Editorial = "Putnam",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 18,
                Name = "The Alchemist",
                Author = "Paulo Coelho",
                PublicationDate = new DateTime(1988, 11, 1),
                Editorial = "HarperOne",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 19,
                Name = "The House in the Cerulean Sea",
                Author = "TJ Klune",
                PublicationDate = new DateTime(2020, 3, 17),
                Editorial = "Tor Books",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = 20,
                Name = "Educated",
                Author = "Tara Westover",
                PublicationDate = new DateTime(2018, 2, 20),
                Editorial = "Random House",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        };
    }
}
