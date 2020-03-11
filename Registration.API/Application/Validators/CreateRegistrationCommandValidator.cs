using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using iPAS.Services.Registration.API.Application.Commands;
using static iPAS.Services.Registration.API.Application.Commands.CreateRegistrationCommand;

namespace iPAS.Services.Registration.API.Application.Validations
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateRegistrationCommand>
    {
        public CreateOrderCommandValidator(ILogger<CreateOrderCommandValidator> logger)
        {
            RuleFor(command => command.LastName).NotEmpty();

            logger.LogTrace("----- INSTANCE CREATED - {ClassName}", GetType().Name);
        }

        private bool BeValidBirthDate(DateTime dateTime)
        {
            return dateTime >= DateTime.UtcNow;
        }

    }
}