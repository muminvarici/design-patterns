namespace SimpleApi.Models;

public class Todo : EntityBase
{
    public int UserId { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }
}