﻿using Microsoft.AspNetCore.Mvc;
using QuickBite.Models;

namespace QuickBite.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<Item>();
            
            var item1 = new Item();
            item1.ItemId = 1;
            item1.Name = "Pizza";
            item1.Price = 60;

            //another way to do same as above, but this is preferable
            var item2 = new Item();
            {
                ItemId = 2,
                Name = "Fried Chicken Leg",
                Price = 60;
            };

            items.Add(item1);
            items.Add(item2);

            ViewBag.CurrentViewName = "List of Shop Items";
            return View(items);
        }
    }
}
