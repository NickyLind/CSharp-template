using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    // example of how to link photos to a page
    [Route("/photos")]
    public ActionResult Photos()
    {
      return View();
    }

  }
}
