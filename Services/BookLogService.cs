using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team2Project.Models;

public class BookLogService{
    private readonly ApplicationDbContext _context;

    public BookLogService(ApplicationDbContext context){
        _context = context;
    }

    //Method to add an entry to the BookLog
    public async Task AddToBookLog(int accountId, Entries entry){
        //Adding data to the entry object before adding it to the list
        entry.CreatedAt = DateTime.Now;
        entry.UpdatedAt = DateTime.Now;
        entry.AccountId = accountId;

        _context.Entries.Add(entry);
        await _context.SaveChangesAsync();
    }

    //Method to get all the entries from a user
    public async Task<List<Entries>> GetEntryList(int accountId)
    {
        return await _context.Entries
            .Where(e => e.AccountId == accountId)
            .ToListAsync();
    }

    public async Task<List<Book>> LoadBooks() {
        return await _context.Books.ToListAsync();
    }
<<<<<<< HEAD

    public async Task LoadOnce() {
        await _context.Books.AddRangeAsync(SeedData.GetBooks());
        await _context.SaveChangesAsync();
    }
=======
>>>>>>> b8f95b0 (Co-authored-by: Yupanqui Prieto, Hernan Yupanqui <yup19001@byui.edu>)
}