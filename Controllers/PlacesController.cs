using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;
using System;
using City.Models;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string name, string lengthOfStay, string whoWith)
    {
      CityClass myCity = new CityClass(lengthOfStay, whoWith);
      Place myPlace = new Place(name, myCity);
      return View("Index", myPlace);
    }
  }
}
