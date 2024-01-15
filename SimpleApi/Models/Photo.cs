namespace SimpleApi.Models;

public class Photo : EntityBase
{
    public int AlbumId { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string ThumbnailUrl { get; set; }
}