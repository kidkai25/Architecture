using Architecture.CrossCutting;
using DotNetCore.Domain;
using System;

namespace Architecture.Domain
{
    public class AuthEntity : Entity<long>
    {
        public AuthEntity
        (
            string login,
            string password,
            Roles roles
        )
        : base(default)
        {
            Login = login;
            Password = password;
            Roles = roles;
            Salt = Guid.NewGuid().ToString();
        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public string Salt { get; private set; }

        public Roles Roles { get; private set; }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
