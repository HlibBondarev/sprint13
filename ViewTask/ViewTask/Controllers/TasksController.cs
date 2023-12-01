﻿using Microsoft.AspNetCore.Mvc;
using ViewTask.Services;
using ViewTask.Models;
using System.Collections;

namespace ViewTask.Controllers
{
	public class TasksController : Controller
	{
        readonly ITimeService _timeService;
        public TasksController(ITimeService timeService, IEnumerable<Product> products)
        {
            _timeService = timeService;
            products = products.ToList();   
        }

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

		//public TasksController(IEnumerable<Product> products)
		//{
		//	this.products = (List<Product>)products;
		//}
        
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
            var productModel = new ProductViewModel(ProductService.GetProducts(products)); 
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