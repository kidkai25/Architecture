using Architecture.Domain;
using DotNetCore.Repositories;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IAuthRepository : IRepository<AuthEntity>
    {
        Task<bool> AnyByLoginAsync(string login);

        Task<AuthEntity> GetByLoginAsync(string login);
    }
}
