using Microsoft.AspNetCore.Mvc;
using ViewTask.Services;
using ViewTask.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewTask.Controllers
{
	public class TasksController : Controller
	{
		readonly ITimeService _timeService;
		readonly List<Product> _products = new()
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
		readonly List<string> _supermarkets = new()
		{
			"WellMart","Silpo" , "ATB", "Furshet", "Metro"
		};

		public TasksController(ITimeService timeService, IEnumerable<Product> products, IEnumerable<string> supermarkets)
		{
			_timeService = timeService;
			if (products.Count() != 0)
			{
				_products = products.ToList();
			}
			if (supermarkets.Count() != 0)
			{
				_supermarkets = supermarkets.ToList();
			}
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


		[HttpGet]
		public IActionResult ShoppingCart()
		{
			return View(new ShoppingCartViewModel { SupermarketsList = _supermarkets, ShoppingList = ProductService.GetProducts(_products).Keys });
		}
		[HttpPost]
		public string ShoppingCart(string Fullname, string Address)
		{
			return string.Format($"Your poducts will be shipped at: {Address}. Bon Appetite, {Fullname}!");
		}


		public IActionResult ShoppingList()
		{
			var productModel = new ProductViewModel(ProductService.GetProducts(_products));
			return View(productModel);
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