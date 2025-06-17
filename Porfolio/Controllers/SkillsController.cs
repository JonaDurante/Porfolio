using Microsoft.AspNetCore.Mvc;

namespace PorfolioWeb.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
