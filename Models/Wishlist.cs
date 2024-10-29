namespace Team2Project.Models
{
  public class Wishlist
  {
    public int Id { get; set; }
    public Guid BookId { get; set; }
    public int AccountId { get; set; }

    public Account Account { get; set; }
    public Book Book { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Wishlist()
    {
      CreatedAt = DateTime.Now;
      UpdatedAt = DateTime.Now;

    }
  }
}