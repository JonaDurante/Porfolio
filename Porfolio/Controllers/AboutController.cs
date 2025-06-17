using Microsoft.AspNetCore.Mvc;

namespace PorfolioWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
