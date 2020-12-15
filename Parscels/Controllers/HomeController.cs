using Microsoft.AspNetCore.Mvc;

namespace Parscels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet ("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}