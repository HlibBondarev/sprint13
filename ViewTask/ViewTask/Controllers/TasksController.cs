using Microsoft.AspNetCore.Mvc;
using ViewTask.Services;
using System.Xml.Linq;
using ViewTask.Models;

namespace ViewTask.Controllers
{
	public class TasksController : Controller
	{
		readonly List<Product> products = new()
		{
			new Product {Name="Bread",Price=10 },
			new Product {Name="Milk",Price=10 },
			new Product {Name="Chease",Price=10 },
			new Product {Name="Sausage",Price=10 },
			new Product {Name="Potato",Price=10 },
			new Product {Name="Banano",Price=10 },
			new Product {Name="Tomato",Price=10 },
			new Product {Name="Candy",Price=10 }
		};

		public TasksController(IEnumerable<Product> products)
		{
			this.products = (List<Product>)products;

		}
        public TasksController()
        {
        }

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