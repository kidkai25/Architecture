using Architecture.Domain;
using Architecture.Model;

namespace Architecture.Application
{
    public static class UserFactory
    {
        public static UserEntity Create(AddUserModel addUserModel, AuthEntity authEntity)
        {
            return new UserEntity
            (
                new FullName(addUserModel.FullName.Name, addUserModel.FullName.Surname),
                new Email(addUserModel.Email),
                authEntity
            );
        }
    }
}
