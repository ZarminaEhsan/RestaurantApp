using Microsoft.AspNetCore.Mvc;
using QuickBite.Models;
using QuickBite.ViewModels;


namespace QuickBite.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = GetItems();
        var itemListViewModel = new ItemListViewModel(items, "Table");
        return View(itemListViewModel);
    }

    public IActionResult Grid()
    {
        var items = GetItems();
        var itemListViewModel = new ItemListViewModel(items, "Grid");
        return View(itemListViewModel);
    }

    public List<Item> GetItems()
    {
        var items = new List<Item>();

        var item1 = new Item
        {
            ItemId = 1,
            Name = "Pizza",
            Price = 60,
            Description = "Delicious Italian dish with a thin crust topped with tomato sauce, cheese, and various toppings.",
            ImageUrl = "/images/vecteezy_pizza-hawaiian-cheese.jpg"
        };


        //another way to do the same as above, but this is preferable
        var item2 = new Item
        {
            ItemId = 2,
            Name = "Fried Chicken Leg",
            Price = 160,
            Description = "Delicious .....",
            ImageUrl = "/images/vecteezy_fried-chicken-leg.jpg"
        };

        var item3 = new Item
        {
            ItemId = 3,
            Name = "Ribs",
            Price = 260,
            Description = "Delicious .....",
            ImageUrl = "/images/ribs.jpg"
        };

        var item4 = new Item
        {
            ItemId = 4,
            Name = "Fries",
            Price = 80,
            Description = "Delicious .....",
            ImageUrl = "/images/fries.jpg"
        };

        var item5 = new Item
        {
            ItemId = 5,
            Name = "Fish and Chips",
            Price = 180,
            Description = "Delicious .....",
            ImageUrl = "/images/fish and chips.jpg"
        };

        var item6 = new Item
        {
            ItemId = 6,
            Name = "Tacos",
            Price = 180,
            Description = "Delicious .....",
            ImageUrl = "/images/vecteezy_ai-generated-tacos.jpg"
        };

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);
        items.Add(item4);
        items.Add(item5);
        items.Add(item6);

        ViewBag.CurrentViewName = "List of Shop Items";
        return items;
    }
}


/*
public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Table";
        return View(items);
    }

    public IActionResult Grid()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Grid";
        return View(items);
    }
    public List<Item> GetItems()
    {
        var items = new List<Item>();

        var item1 = new Item
        {
            ItemId = 1,
            Name = "Pizza",
            Price = 60,
            Description = "Delicious Italian dish with a thin crust topped with tomato sauce, cheese, and various toppings.",
            ImageUrl = "/images/vecteezy_pizza-hawaiian-cheese.jpg"
        };
        

        //another way to do the same as above, but this is preferable
        var item2 = new Item
        {
            ItemId = 2,
            Name = "Fried Chicken Leg",
            Price = 160,
            Description = "Delicious .....",
            ImageUrl = "/images/vecteezy_fried-chicken-leg.jpg"
        };

        var item3 = new Item
        {
            ItemId = 3,
            Name = "Ribs",
            Price = 260,
            Description = "Delicious .....",
            ImageUrl = "/images/ribs.jpg"
        };

        var item4 = new Item
        {
            ItemId = 4,
            Name = "Fries",
            Price = 80,
            Description = "Delicious .....",
            ImageUrl = "/images/fries.jpg"
        };

        var item5 = new Item
        {
            ItemId = 5,
            Name = "Fish and Chips",
            Price = 180,
            Description = "Delicious .....",
            ImageUrl = "/images/fish and chips.jpg"
        };

        var item6 = new Item
        {
            ItemId = 6,
            Name = "Tacos",
            Price = 180,
            Description = "Delicious .....",
            ImageUrl = "/images/vecteezy_ai-generated-tacos.jpg"
        };

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);
        items.Add(item4);
        items.Add(item5);
        items.Add(item6);


        ViewBag.CurrentViewName = "List of Shop Items";
        return items;
    }
}

*/