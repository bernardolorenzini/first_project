using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using first_project.Models;
using first_project.Validator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace first_project.Controllers
{
    public class LoginController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            user.Email = "sdffslknll";
            user.Password = "234234";


            UserValidator validator = new UserValidator();

            FluentValidation.Results.ValidationResult results = validator.Validate(user);


            if (!results.IsValid)
            {
                foreach(var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }
            
            return View("Index", user);
        }

        [HttpPost]

        public IActionResult Test(UserViewModel user)
        {
            
            user.Email = "email enviado";
            return View("Index", user);
        }
    }
}

