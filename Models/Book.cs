namespace Team2Project.Models
{
  public class Book
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public required string Editorial { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    
  }
  
}