namespace Team2Project.Models;

public static class SeedData
{
    public static List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Babel",
                Author = "R.F. Kuang",
                PublicationDate = new DateTime(2022, 8, 23),
                Editorial = "Harper Voyager",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Crying in H Mart",
                Author = "Michelle Zauner",
                PublicationDate = new DateTime(2021, 4, 20),
                Editorial = "Knopf",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
        };
    }


   
}

