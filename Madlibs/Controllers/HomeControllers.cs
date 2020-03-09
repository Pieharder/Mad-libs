using Microsoft.AspNetCore.Mvc;
using Madlib.Models;
namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello darkness my old friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye darkness my old friend."; }

    // [Route("/")]
    // public ActionResult Letter()
    // {
    //   MadlibVariable myMadlibVariable = new MadlibVariable();
    //   myMadlibVariable.Verb = "James";
    //   myMadlibVariable.Adverb = "Jasmine";
    //   return View(myMadlibVariable);
    // }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult MadlibsForm()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult Madlib(string number, string adjectiveOne, string nounOne, string nounTwo, string adjectiveTwo, string adjectiveThree, string pluralNounOne, string pluralNounTwo, string nounThree, string verb)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Number = number;
      myMadlibVariable.AdjectiveOne = adjectiveOne;
      myMadlibVariable.NounOne = nounOne;
      myMadlibVariable.NounTwo = nounTwo;
      myMadlibVariable.AdjectiveTwo = adjectiveTwo;
      myMadlibVariable.AdjectiveThree = adjectiveThree;
      myMadlibVariable.PluralNounOne = pluralNounOne;
      myMadlibVariable.PluralNounTwo = pluralNounTwo;
      myMadlibVariable.NounThree = nounThree;
      myMadlibVariable.Verb = verb;

      return View(myMadlibVariable);
    }

  }
}