namespace SimpleApi.Models;

public class Comment : EntityBase
{
    public int PostId { get; set; }
    public string Body { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool Completed { get; set; }
}