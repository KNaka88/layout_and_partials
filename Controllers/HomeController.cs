using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
