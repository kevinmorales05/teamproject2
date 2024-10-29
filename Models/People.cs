namespace Team2Project.Models
{
  public class People
  {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDay { get; set; }

    public Account Account {get; set;}


     public People()
    {
    }
  }

  
}