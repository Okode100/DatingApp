using API.DTOs;
using API.Entitiess;
using API.Interface;

namespace API.Extensions;

public static class AppUserExtensions
{
    public static UserDto ToDo(this AppUser user, ITokenService tokenService)
    {
      
        return new UserDto
        {
            Email = user.Email,
            Id = user.Id,
            DisplayName = user.DisplayName,
            Token = tokenService.CreateToken(user)
        };
    } 
}