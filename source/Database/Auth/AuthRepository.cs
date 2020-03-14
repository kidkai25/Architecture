using Architecture.Domain;
using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class AuthRepository : Repository<AuthEntity>, IAuthRepository
    {
        public AuthRepository(Context context) : base(context) { }

        public Task<bool> AnyByLoginAsync(string login)
        {
            return Queryable.AnyAsync(x => x.Login == login);
        }

        public Task<AuthEntity> GetByLoginAsync(string login)
        {
            return Queryable.SingleOrDefaultAsync(x => x.Login == login);
        }
    }
}
