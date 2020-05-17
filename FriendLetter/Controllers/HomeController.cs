using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Byebye pal!"; }
    [Route("/")]
    public ActionResult Letter() {return View();}
  }
}