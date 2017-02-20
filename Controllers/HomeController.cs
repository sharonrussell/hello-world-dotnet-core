using Microsoft.AspNetCore.Mvc;

namespace hello_world_web_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
