namespace SimpleApi.Models;

public class User : EntityBase, ICloneable
{
    public string Username { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? Email { get; set; }

    // Implement the Clone method
    public object Clone()
    {
        // Perform a shallow copy (assuming properties are value types or immutable)
        return MemberwiseClone();
    }
}