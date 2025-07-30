using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class LessonController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
