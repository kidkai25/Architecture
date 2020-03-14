namespace Architecture.Model
{
    public class UpdateUserModel
    {
        public long Id { get; set; }

        public FullNameModel FullName { get; set; }

        public string Email { get; set; }
    }
}
