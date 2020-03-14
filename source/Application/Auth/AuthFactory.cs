using Architecture.Domain;
using Architecture.Model;

namespace Architecture.Application
{
    public static class AuthFactory
    {
        public static AuthEntity Create(AuthModel authModel)
        {
            return new AuthEntity(authModel.Login, authModel.Password, authModel.Roles);
        }
    }
}
