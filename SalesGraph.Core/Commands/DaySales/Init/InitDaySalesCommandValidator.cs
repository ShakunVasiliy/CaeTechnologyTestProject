using Common;
using FluentValidation;

namespace SalesGraph.Core.Commands.DaySales.Init
{
    public class InitDaySalesCommandValidator : AbstractValidator<InitDaySalesCommand>
    {
        public InitDaySalesCommandValidator() 
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.StartDate).NotEmpty()
                .Must(x => CommonConsts.MinDate <= x && x < CommonConsts.MaxDate).WithMessage($"{nameof(InitDaySalesCommand.StartDate)} must be between {CommonConsts.MinDate} and {CommonConsts.MaxDate}.");
            RuleFor(x => x.EndDate).NotEmpty()
                .Must(x => CommonConsts.MinDate <= x && x < CommonConsts.MaxDate).WithMessage($"{nameof(InitDaySalesCommand.EndDate)} must be between {CommonConsts.MinDate} and {CommonConsts.MaxDate}.");
            RuleFor(x => x.StartDate <= x.EndDate).Equal(true).WithMessage($"{nameof(InitDaySalesCommand.StartDate)} must be less or equal than {nameof(InitDaySalesCommand.EndDate)}.");
        }
    }
}
