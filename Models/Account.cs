namespace Team2Project.Models
{
  public class Account
  {
    public int AccountId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string? ProfilePicture {get; set;}
    public int PersonId {get; set;}
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public People People {get;set;}
    public List<Wishlist> Wishlist {get; set;}
    public List<Entries> Entries {get; set;}


    public Account()
    {
      CreatedAt = DateTime.Now;
      UpdatedAt = DateTime.Now;
    }
  }
}