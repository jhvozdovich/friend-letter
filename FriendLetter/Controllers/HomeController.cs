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
    [Route("/form")]
    public ActionResult Form() { return View();}
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender,string location,string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }
  }
}