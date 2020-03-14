using DotNetCore.Validation;
using FluentValidation;

namespace Architecture.Model
{
    public sealed class FullNameModelValidator : Validator<FullNameModel>
    {
        public FullNameModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Surname).NotEmpty();
        }
    }
}
