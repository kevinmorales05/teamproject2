  namespace Team2Project.Models
  {
  public class Book
    {
      public int Id { get; set; }
      public string? Name { get; set; }
      public string? Author { get; set; }
      public DateTime? PublicationDate { get; set; }
      public string? Editorial { get; set; }
      public string? ImagePath {get; set;}
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
      public DateTime? DeletedAt { get; set; }

      
    }
  }
  