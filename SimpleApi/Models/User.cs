namespace SimpleApi.Models;

public class User : ICloneable
{
    public int Id { get; set; }
    public int UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Implement the Clone method
    public object Clone()
    {
        // Perform a shallow copy (assuming properties are value types or immutable)
        return MemberwiseClone();
    }
}