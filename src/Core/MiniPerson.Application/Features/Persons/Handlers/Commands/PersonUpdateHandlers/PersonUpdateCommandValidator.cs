using FluentValidation;
using MiniPerson.Application.Common.Validation;
using MiniPerson.Application.Features.LeaveTypes.Requests.Commands;
using MiniPerson.Application.Features.Persons.Requests.Commands;
using MiniPerson.Infrastructure.DataBase.Context;

namespace MiniPerson.Application.Features.Persons.Handlers.Commands.PersonUpdateHandlers
{
    public class GetPersonByIdRequestValidator : AbstractValidator<UpdatePersonCommand>
    {
        private readonly PersonDbContext _dbContext;
        public GetPersonByIdRequestValidator(PersonDbContext dbContext)
        {
            _dbContext = dbContext;

            RuleFor(p => p.PersonDto.FirstName).NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");

            RuleFor(x => x.PersonDto.Id)
                .Must(BeExist).WithMessage("The person dose not exist.");
        }
        private bool BeExist(long id)
        {
            var person = _dbContext.Persons
                .FirstOrDefault(x => x.Id == id);

            return person != null;
        }
    }
}