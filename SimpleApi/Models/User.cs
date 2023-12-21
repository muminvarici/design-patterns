namespace SimpleApi.Models;

public record User
{
    public int Id { get; set; }
    public int UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}