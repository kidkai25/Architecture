using Architecture.Model;
using DotNetCore.Objects;
using DotNetCore.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public interface IUserApplicationService
    {
        Task<IResult<long>> AddAsync(AddUserModel addUserModel);

        Task<IResult> DeleteAsync(long id);

        Task<UserModel> GetAsync(long id);

        Task InactivateAsync(long id);

        Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<IResult> UpdateAsync(UpdateUserModel updateUserModel);
    }
}
