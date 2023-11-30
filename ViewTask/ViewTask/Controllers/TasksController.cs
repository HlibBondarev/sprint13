using Microsoft.AspNetCore.Mvc;

namespace ViewTask.Controllers
{
    public class TasksController : Controller
    {
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
        public IActionResult SuperMarkets()
        {
            return View();
        }
        //public IActionResult TimeToBuy()
        //{
        //    return View();
        //}
    }
}