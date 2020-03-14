using DotNetCore.Validation;
using FluentValidation;

namespace Architecture.Model
{
    public sealed class AddUserModelValidator : Validator<AddUserModel>
    {
        public AddUserModelValidator()
        {
            RuleFor(x => x.FullName).SetValidator(new FullNameModelValidator());
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Auth).SetValidator(new AuthModelValidator());
        }
    }
}
