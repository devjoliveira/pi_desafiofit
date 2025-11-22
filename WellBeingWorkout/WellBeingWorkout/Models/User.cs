using System.ComponentModel.DataAnnotations.Schema;

public class User : DefaultEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    [NotMapped]
    public string ConfirmPassword { get; set; }
    public int TotalXpEarned { get; set; }
    public int Level { get; set; }

}

