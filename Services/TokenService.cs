using API.Entitiess;
using API.Interface;

namespace API.Services;

public class TokenService : ITokenService
{
    public string  CreateToken(AppUser user)
    {
        
        var  tokenKey = config["Token"]?? throw new exception ("Cannot get the token");
        if(tokenkey.Length < 64 )
            throw new exception("Your token need to be  >= 64 character");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

        var claims = new List<Claim>
        {
            new(ClaimType.Email, user.Emails),
            new(ClaimType.NameIdentifier, user.Id)
        };
        var creds = new SigningCredential(key, SecurityAlgorithms.HmacSha512Signature);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = creds
        };
        var tokenHandler = new JWtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.writeToken(token);

    }
}