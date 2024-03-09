using System;
using FluentValidation;
using first_project.Models;
using first_project.Controllers;

namespace first_project.Validator
{
	public class UserValidator : AbstractValidator<UserViewModel>
	{

		public UserValidator()
		{
			RuleFor(user => user.Email).NotNull().WithMessage("Email vazio");
			RuleFor(user => user.Email).EmailAddress().WithMessage("O e-mail esta inválido");
			RuleFor(user => user.Username).NotNull().WithMessage("Sem username");
            RuleFor(user => user.Password).NotNull().WithMessage("Sem senha");
			RuleFor(user => user.Password).Matches("2345").WithMessage("senha errada");

		}

	}
}

