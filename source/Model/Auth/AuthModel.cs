using Architecture.CrossCutting;

namespace Architecture.Model
{
    public class AuthModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public Roles Roles { get; set; }
    }
}
