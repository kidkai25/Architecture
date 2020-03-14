using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Results;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public interface IAuthApplicationService
    {
        Task<IResult<AuthEntity>> AddAsync(AuthModel authModel);

        Task DeleteAsync(long id);

        Task<IResult<TokenModel>> SignInAsync(SignInModel signInModel);
    }
}
