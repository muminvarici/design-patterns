namespace SimpleApi.Models;

public class Post : EntityBase
{
    public string Title { get; set; }
    public int UserId { get; set; }
    public string Body { get; set; }
}