using System.Security.Cryptography.X509Certificates;
using Team2Project.Models;

namespace Team2Project.Services;

public class BookService
{
    private static List<Book> books;
    static int nextId = 3;

    private static List<Book> GetBooks()
    {
        return books;
    }

    static BookService()
    {
        books = new List<Book>{
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
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Dark Matter",
                Author = "Blake Crouch",
                PublicationDate = new DateTime(2016, 7, 26),
                Editorial = "Crown",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Fourth Wing",
                Author = "Rebecca Yarros",
                PublicationDate = new DateTime(2023, 5, 2),
                Editorial = "Entangled Publishing",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
        };

    }
     public static List<Book> GetAll()
    {
        return books;
    }

    public static Book? Get( Guid id) => books.FirstOrDefault(p => p.Id == id);

    public static void Add(Book Book)
    {
        Book.Id = Guid.NewGuid();
        books.Add(Book);
    }

    public static void Delete(Guid id)
    {
        var Book = Get(id);
        if(Book is null)
            return;

        books.Remove(Book);
    }

    public static void Update(Book Book)
    {
        var index = books.FindIndex(p => p.Id == Book.Id);
        if(index == -1)
            return;

        books[index] = Book;
    }

   

    }




