using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
  {
    public class ItemsController : Controller
      {
        [HttpGet("/items")]
        public ActionResult Index()
        {
          List<Item> allItems = Item.GetAll();
          return View(allItems);
        }
        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
          return View();
        }
        [HttpPost("/items")]
        public ActionResult Create()
        {
          Item newItem = new Item (Resquest.Form["new-item"]);
          newItem.Save();
          List<Item> allItems = Item.GetAll();
          return View("Index", allItems);
        }
        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
          Item.ClearAll();
          return View();
        }
      }
  }
  // using Microsoft.AspNetCore.Mvc;
  // using ToDoList.Models;

  // namespace ToDoList.Controllers
  // {
  //     public class ItemsController : Controller
  //     {
  //
  //         [HttpGet("/items")]
  //         public ActionResult Index()
  //         {
  //             Item newItem = new Item(Request.Query["new-item"]);
  //             return View(newItem);
  //         }
  //
  //         [HttpGet("/items/new")]
  //         public ActionResult CreateForm()
  //         {
  //             return View();
  //         }
  //     }
  // }
