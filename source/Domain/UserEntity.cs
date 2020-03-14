using Architecture.CrossCutting;
using DotNetCore.Domain;

namespace Architecture.Domain
{
    public class UserEntity : Entity<long>
    {
        public UserEntity
        (
            FullName fullName,
            Email email,
            AuthEntity auth
        )
        : base(default)
        {
            FullName = fullName;
            Email = email;
            Auth = auth;
            Activate();
        }

        public UserEntity(long id) : base(id) { }

        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        public Status Status { get; private set; }

        public AuthEntity Auth { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void ChangeFullName(string name, string surname)
        {
            FullName = new FullName(name, surname);
        }

        public void ChangeEmail(string address)
        {
            Email = new Email(address);
        }
    }
}
