namespace API.Entitiess;

public class AppUser
{
    public required string Id {get; set;}  = Guid.NewGuid().ToString();
    public required string DisplayName {get; set;}
    public required string Email { get; set; }
    public required byte[] PasswordHas { get; set; }
    public required byte[] PasswordSalt { get; set; }

}