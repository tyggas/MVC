    using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
