using Nancy;
using System.Collections.Generic;
using System;
using RockPaperScissors;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["index.cshtml","  "];
      };
      Post["/RPS/created"] =_=> {
        RockPaperScissors newGame = new RockPaperScissors();
        List<string> results = newGame.Shoot(Request.Form["player1"]);
        return View["index.cshtml",results];
      };
    }
  }
}
