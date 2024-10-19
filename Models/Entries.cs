namespace Team2Project.Models
{
  public class Entries
  {
    public int BookId { get; set; }
    public double ProgressPercentage { get; set; }
    public int AccountId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
  }
}