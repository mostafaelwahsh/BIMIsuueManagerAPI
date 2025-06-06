﻿using Application.DTOs.Projects;

namespace Application.Validators.Projects
{
    public class CreateProjectDtoValidator : AbstractValidator<CreateProjectDto>
    {
        public CreateProjectDtoValidator()
        {
            RuleFor(x => x.ProjectName)
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.CompanyId)
                .GreaterThan(0)
                .WithMessage("CompanyId is required");
        }
    }
}
