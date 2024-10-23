namespace Team2Project.Models
{
  public class Wishlist
  {
    public int Id { get; set; }
    public int BookId { get; set; }
    public int AccountId { get; set; }

    public Account Account { get; set; }
    public Book Book { get; set; }

  }
}