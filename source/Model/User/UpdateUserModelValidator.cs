using DotNetCore.Validation;
using FluentValidation;

namespace Architecture.Model
{
    public sealed class UpdateUserModelValidator : Validator<UpdateUserModel>
    {
        public UpdateUserModelValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.FullName).SetValidator(new FullNameModelValidator());
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}
