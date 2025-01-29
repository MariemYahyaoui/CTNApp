using Microsoft.AspNetCore.Mvc;

namespace CTNApp.Controllers.Authentification
{
    public class LoginController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View("~/Views/Authentification/Login.cshtml");
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            // Dummy authentication logic
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Invalid username or password.";
            return View("~/Views/Authentification/Login.cshtml");
        }
    
}
}
