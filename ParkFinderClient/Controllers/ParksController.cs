using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkFinderClient.Models;

namespace ParkFinderClient.Controllers
{
  public class ParksController : Controller
  {
    public IActionResult Index()
    {
      var allParks = Park.GetParks();
      return View(allParks);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Park park)
    {
      Park.Post(park);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }

    public IActionResult Edit(int id)
    {
      var park = Park.GetDetails(id);
      return View(park);
    }

    [HttpPost]
    public IActionResult Details(int id, Park park)
    {
      park.ParkId = id;
      Park.Put(park);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Park.Delete(id);
      return RedirectToAction("Index");
    }
  }
}