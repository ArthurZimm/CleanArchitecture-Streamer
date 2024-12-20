using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
	public class UpdateStreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
	{
        public UpdateStreamerCommandValidator()
        {
            RuleFor(p => p.Id)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.NotNull();

			RuleFor(p => p.Name)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.NotNull()
				.MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

			RuleFor(p => p.Url)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.NotNull()
				.MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");
        }
    }
}