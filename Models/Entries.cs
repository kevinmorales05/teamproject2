namespace Team2Project.Models
{
  public class Entries
  {
    public int Id {get; set;}
    public int BookId { get; set; }
    public double? ProgressPercentage { get; set; }
    public int AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public Account Account { get; set; }
    public Book Book { get; set; }
  }
}