

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; } // Using ? to make the property nullable
    public string? Email { get; set; }
    public string? Password { get; set; }
}