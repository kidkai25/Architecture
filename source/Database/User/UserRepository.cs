using Architecture.Domain;
using Architecture.Model;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public Task<UserModel> GetByIdAsync(long id)
        {
            return Queryable.Project<UserEntity, UserModel>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateStatusAsync(UserEntity userEntity)
        {
            return UpdatePartialAsync(userEntity.Id, new { userEntity.Status });
        }
    }
}
