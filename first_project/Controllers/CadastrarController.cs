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

namespace YourNamespace.Controllers
{
    public class CadastrarController : Controller
    {
        // Action method to handle requests for Index.cshtml inside Cadastrar folder
        public IActionResult Index()
        {
            return View();
        }
    }
}