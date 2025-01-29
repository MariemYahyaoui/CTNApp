using Microsoft.AspNetCore.Mvc;

namespace CTNApp.Controllers.Interface_Utilisateur
{
    public class InformationsPersonnelsController : Controller
    {
        public IActionResult Index()
        {
            // Pass any necessary data to the view here using ViewBag, ViewData, or a strongly typed model
            return View("~/Views/Interface_Utilisateur/InformationsPersonnels.cshtml");
        }
    }
}
