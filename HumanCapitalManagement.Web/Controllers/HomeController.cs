using Microsoft.AspNetCore.Mvc;

namespace HumanCapitalManagement.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
