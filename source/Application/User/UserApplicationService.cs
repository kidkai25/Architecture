using Architecture.Database;
using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Mapping;
using DotNetCore.Objects;
using DotNetCore.Results;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public sealed class UserApplicationService : IUserApplicationService
    {
        private readonly IAuthApplicationService _authApplicationService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public UserApplicationService
        (
            IAuthApplicationService authApplicationService,
            IUnitOfWork unitOfWork,
            IUserRepository userRepository
        )
        {
            _authApplicationService = authApplicationService;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<IResult<long>> AddAsync(AddUserModel addUserModel)
        {
            var validation = await new AddUserModelValidator().ValidateAsync(addUserModel);

            if (validation.Failed)
            {
                return Result<long>.Fail(validation.Message);
            }

            var authEntityResult = await _authApplicationService.AddAsync(addUserModel.Auth);

            if (authEntityResult.Failed)
            {
                return Result<long>.Fail(authEntityResult.Message);
            }

            var userEntity = UserFactory.Create(addUserModel, authEntityResult.Data);

            await _userRepository.AddAsync(userEntity);

            await _unitOfWork.SaveChangesAsync();

            return Result<long>.Success(userEntity.Id);
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _userRepository.DeleteAsync(id);

            await _authApplicationService.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<UserModel> GetAsync(long id)
        {
            return _userRepository.GetByIdAsync(id);
        }

        public async Task InactivateAsync(long id)
        {
            var userEntity = new UserEntity(id);

            userEntity.Inactivate();

            await _userRepository.UpdateStatusAsync(userEntity);

            await _unitOfWork.SaveChangesAsync();
        }

        public Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters)
        {
            return _userRepository.Queryable.Project<UserEntity, UserModel>().ListAsync(parameters);
        }

        public async Task<IEnumerable<UserModel>> ListAsync()
        {
            return await _userRepository.Queryable.Project<UserEntity, UserModel>().ToListAsync();
        }

        public async Task<IResult> UpdateAsync(UpdateUserModel updateUserModel)
        {
            var validation = await new UpdateUserModelValidator().ValidateAsync(updateUserModel);

            if (validation.Failed)
            {
                return Result.Fail(validation.Message);
            }

            var userEntity = await _userRepository.GetAsync(updateUserModel.Id);

            if (userEntity == default)
            {
                return Result.Success();
            }

            userEntity.ChangeFullName(updateUserModel.FullName.Name, updateUserModel.FullName.Surname);

            userEntity.ChangeEmail(updateUserModel.Email);

            await _userRepository.UpdateAsync(userEntity.Id, userEntity);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
