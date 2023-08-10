using Microsoft.AspNetCore.Identity;

namespace ProjectMomoDoanation.Core.Interface
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
