
using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Letter()
        {
            MadLibVariable myMadLibVariable = new MadLibVariable();
            myMadLibVariable.Noun = "Lina";
            myMadLibVariable.Verb = "Lina";
            myMadLibVariable.BodyPartNoun = "Lina";
            myMadLibVariable.ThingNoun = "Lina";
            myMadLibVariable.PluralNoun = "Lina";
            return View(myMadLibVariable);
        }


        [Route("/madLibs")]
        public ActionResult madLibs(string noun, string verb, string bodypartNoun, string thingNoun, string pluralNoun)
        {
            MadLibVariable myMadLibVariable = new MadLibVariable();
            myMadLibVariable.Noun = noun;
            myMadLibVariable.Verb = verb;
            myMadLibVariable.BodyPartNoun = bodypartNoun;
            myMadLibVariable.ThingNoun = thingNoun;
            myMadLibVariable.PluralNoun = pluralNoun;
            return View(myMadLibVariable);

        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

    }
}