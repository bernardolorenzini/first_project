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
			RuleFor(user => user.Email).NotNull();
			RuleFor(user => user.Username).NotNull();
            RuleFor(user => user.Password).NotNull();

		}

	}
}

