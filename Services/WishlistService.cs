using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team2Project.Models;

public class WishlistService
{
    private readonly ApplicationDbContext _context;

    public WishlistService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Method to add a book to a user's wishlist
    public async Task AddToWishlist(int accountId, int bookId)
    {
        var wishlistEntry = new Wishlist 
        { 
            AccountId = accountId, 
            BookId = bookId, 
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        
        _context.Wishlists.Add(wishlistEntry);
        await _context.SaveChangesAsync();
    }

    // Method to get all books in a user's wishlist
    public List<Book> GetWishlistBooks(int accountId)
    {
        return _context.Wishlists
                    .Where(w => w.AccountId == accountId)
                    .Include(w => w.Book) // Eager load Book details
                    .Select(w => w.Book)
                    .ToList();
    }
}
