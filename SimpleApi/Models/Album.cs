namespace SimpleApi.Models;

public class Album : EntityBase
{
    public string Title { get; set; }
    public int UserId { get; set; }
}