using Microsoft.AspNetCore.Mvc;

namespace PierresWholesale.Controllers
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