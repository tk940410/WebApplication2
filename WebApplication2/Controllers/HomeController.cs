using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        private readonly HouseContext _houseContext; //先在全域宣告資料庫物件

        public HomeController(HouseContext HouseContext) //這邊是依賴注入使用我們剛設定好的資料庫物件的寫法
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
