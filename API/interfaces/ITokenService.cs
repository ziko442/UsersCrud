using API.Entities;

namespace API.interfaces
{
    public interface ITokenService
    {
        string CreateTokent(AppUser user);
    }
}