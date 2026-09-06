namespace API.Entitiess;

public class AppUser
{
    public required string id {get; set;}  = Guid.NewGuid().ToString();
    public required string DisplayName {get; set;}
    public required string Email { get; set ; }
}