public class User : DefaultEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int TotalXpEarned { get; set; }
    public int Level { get; set; }

}

