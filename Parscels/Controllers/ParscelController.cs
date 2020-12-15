using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parscels.Models;

namespace Parscels.Controllers
{
  public class ParscelsController : Controllers
  {

    [HttpGet("/parscelsList")]
    public ActionResult Index()
    {
      List<Parscel> allParscels = Parscel.GetAll();
      return View(allParscels);
    }
  
    [HttpGet("/parscels/new")]
    public ActionResult ParscelForm()
    {
      return View();
    }

    [HttpPost("/parscelsList")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parscel myParscel = new Parscel(length, width, height, weight);
      return RedirectToAction("Index");
    }

  }
}