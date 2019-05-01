using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;
using System.Collections.Generic;

namespace Tamagotchis.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View(allTamagotchis);
    }

    // [HttpGet("/tamagotchis/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    [HttpPost("/tamagotchis")]
    public ActionResult Create()
    {
      Tamagotchi myTamagotchi = new Tamagotchi();
      return RedirectToAction("Index");
    }

    [HttpPost("/tamagotchis/delete")]
    public ActionResult DeleteAll()
    {
      Tamagotchi.ClearAll();
      return View();
    }

    // [HttpGet("/tamagotchis/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Tamagotchi tamagotchi = Tamagotchi.Find(id);
    //   return View(tamagotchi);
    // }

  }
}
