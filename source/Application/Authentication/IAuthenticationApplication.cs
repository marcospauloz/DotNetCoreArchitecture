using DotNetCore.Objects;
using DotNetCoreArchitecture.Model.Models;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public interface IAuthenticationApplication
    {
        Task<IResult<string>> SignInAsync(SignInModel signInModel);

        Task SignOutAsync(SignOutModel signOutModel);
    }
}
