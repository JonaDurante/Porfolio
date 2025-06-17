using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using PorfolioWeb.Dto;
using System.Diagnostics;

namespace PorfolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly Serilog.ILogger _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(Serilog.ILogger logger, IStringLocalizer<HomeController> localizer)
        {

            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            try
            {
                var experiences = new List<ExperienceDto>
                {
                    new ExperienceDto {
                        Title = _localizer["FullStackDeveloper"],
                        Company = "Heinleing Grouppe",
                        Period = "Jan 2024 - Present",
                        Responsibilities = new List<ResponsibilitiesDto>() {
                            new ResponsibilitiesDto
                            {
                                Description = _localizer["DevelopingWebApplications"],
                                Category = "Category"
                            },
                        },

                        Technologies = new List<TechnologiesDto>()
                        {
                            new TechnologiesDto
                            {
                                Category = "Category",
                                Framework = new List<string> {".NET 8", "Bootstrap", "SQL Server" }
                            },
                        }
                    },
                };
                return View(experiences);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en {accion} de {controller}", ControllerContext.RouteData.Values["action"]?.ToString(), ControllerContext.RouteData.Values["controller"]?.ToString());
                return Error();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorDto { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
