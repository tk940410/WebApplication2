using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        private readonly HouseContext _houseContext; //���b����ŧi��Ʈw����

        public HomeController(HouseContext HouseContext) //�o��O�̿�`�J�ϥΧڭ̭�]�w�n����Ʈw���󪺼g�k
        {
            _houseContext = HouseContext;
        }
        //private readonly ILogger<HomeController> _logger;

        
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
