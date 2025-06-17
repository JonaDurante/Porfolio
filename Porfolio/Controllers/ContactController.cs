using Microsoft.AspNetCore.Mvc;

namespace PorfolioWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
