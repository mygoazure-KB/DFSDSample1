using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
