namespace Architecture.Model
{
    public class AddUserModel
    {
        public FullNameModel FullName { get; set; }

        public string Email { get; set; }

        public AuthModel Auth { get; set; }
    }
}
