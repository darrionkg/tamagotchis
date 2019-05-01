using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchis.Controllers;
using Tamagotchis.Models;

namespace Tamagotchis.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Tamagotchi> testList = new List<Tamagotchi>();
      return View(testList);
    }

  }
}
