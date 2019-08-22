using Microsoft.AspNetCore.Mvc;

namespace TDS.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
