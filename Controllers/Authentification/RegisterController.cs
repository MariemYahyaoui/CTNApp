using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CTNApp.Controllers.Authentification
{
    public class RegisterController : Controller
    {
        // GET: /Authentification/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Views/Authentification/Register.cshtml");
        }

    }
}
