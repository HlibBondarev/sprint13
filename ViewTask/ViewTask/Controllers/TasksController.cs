using Microsoft.AspNetCore.Mvc;
using ViewTask.Services;
using ViewTask.Models;

namespace ViewTask.Controllers
{
	public class TasksController : Controller
	{
		readonly ITimeService _timeService;
		readonly List<Product> _products = new()
		{
			new Product {Name="Bread",Price=10 },
			new Product {Name="Milk",Price=11 },
			new Product {Name="Chease",Price=140 },
			new Product {Name="Sausage",Price=110 },
			new Product {Name="Potato",Price=7 },
			new Product {Name="Banano",Price=23 },
			new Product {Name="Tomato",Price=25 },
			new Product {Name="Candy",Price=75 }
		};
		readonly List<SuperMarket> _supermarkets = new List<SuperMarket>()
			{
				new SuperMarket() {Name = "WellMart"},
				new SuperMarket() {Name = "Silpo" },
				new SuperMarket() {Name = "ATB" },
				new SuperMarket() {Name = "Furshet" },
				new SuperMarket() {Name = "Metro"}
			};

		public TasksController(ITimeService timeService, IEnumerable<Product> products, IEnumerable<SuperMarket> supermarkets)
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
			ViewData["Message"] = "Hello C# Marathon!";
			ViewData["Greetings"] = "Welcome to our project!";

			DateTime utcNow = DateTime.UtcNow;
			ViewData["Day"] = utcNow.DayOfWeek.ToString();

			TimeZoneInfo ukraineTimeZone = TimeZoneInfo.FindSystemTimeZoneById("FLE Standard Time");
			DateTime ukraineNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, ukraineTimeZone);

			ViewData["DayInUkraine"] = $"{ukraineNow.DayOfWeek}!";

			string date = _timeService.GetTime();
			string[] timeComponents = date.Split(':');
			int intHour = int.Parse(timeComponents[1]);

			if (intHour >= 5 && intHour < 12)
			{
				ViewData["Wishes"] = "Good Morning";
			}
			else if (intHour >= 12 && intHour < 18)
			{
				ViewData["Wishes"] = "Good Afternoon";
			}
			else if (intHour >= 18 && intHour <= 24)
			{
				ViewData["Wishes"] = "Good Evening";
			}
			else
			{
				ViewData["Wishes"] = "Good Night";
			}

			return View(timeComponents);
		}
		public IActionResult ProductInfo()
		{
			return View(_products);
		}

		[HttpGet]
		public IActionResult ShoppingCart()
		{
			return View(new ShoppingCartViewModel { SupermarketsList = _supermarkets, ShoppingList = ProductService.GetProducts(_products).Keys.ToList() });
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
			ViewBag.Markets = _supermarkets;
			return View();
		}
	}
}