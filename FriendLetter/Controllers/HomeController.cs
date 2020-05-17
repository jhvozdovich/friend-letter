using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Byebye pal!"; }
    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lauren";
      myLetterVariable.Sender = "Jessica";
      return View(myLetterVariable);}
  }
}