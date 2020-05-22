using Microsoft.AspNetCore.Mvc;

namespace VendorsPage.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}