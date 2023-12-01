using Microsoft.AspNetCore.Mvc;
using ViewTask.Services;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
        readonly ITimeService _timeService;
        
        public TasksController(ITimeService timeService)
        {
            _timeService = timeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            return View();
        }
        public IActionResult ProductInfo()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult ShoppingList()
        {

            return View();
        }
        public IActionResult ShopTime()
        {
            var currentTime = _timeService.GetTimeForTomorrow().ToString("HH:mm:ss");
            return Json(currentTime);
        }
        public IActionResult SuperMarkets()
        {
            return View();
        }   
    }
}