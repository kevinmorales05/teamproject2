using Microsoft.EntityFrameworkCore;

namespace Team2Project.Models
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
    public DbSet<People> People { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<Entries> Entries { get; set; }
    public DbSet<Account> Accounts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // Define primary keys
      modelBuilder.Entity<Book>().HasKey(b => b.Id);
      modelBuilder.Entity<People>().HasKey(p => p.Id);
      modelBuilder.Entity<Wishlist>().HasKey(w => w.Id);
      modelBuilder.Entity<Entries>().HasKey(e => e.Id);
      modelBuilder.Entity<Account>().HasKey(a => a.AccountId);


      // Define relationships and foreign keys
      modelBuilder.Entity<Wishlist>()
          .HasOne(w => w.Account)
          .WithMany()
          .HasForeignKey(w => w.AccountId)
          .OnDelete(DeleteBehavior.Cascade);

      modelBuilder.Entity<Wishlist>()
        .HasOne(w => w.Book)
        .WithMany()
        .HasForeignKey(w => w.BookId)
        .OnDelete(DeleteBehavior.Cascade);;

      modelBuilder.Entity<Entries>()
          .HasOne(e => e.Account)
          .WithMany()
          .HasForeignKey(e => e.AccountId);

      modelBuilder.Entity<Entries>()
          .HasOne(e => e.Book)
          .WithMany()
          .HasForeignKey(e => e.BookId);

      modelBuilder.Entity<Account>()
        .HasOne(a => a.People)
        .WithOne(p => p.Account)
        .HasForeignKey<Account>(a => a.PersonId);
    }

  }


}
