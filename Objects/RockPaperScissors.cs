using System.Collections.Generic;
using System;
using RockPaperScissors;
using System.IO;


namespace RockPaperScissors
{
  public class RockPaperScissors
  {
    public string Result;
    public Dictionary<string, string> playWins = new Dictionary<string, string>()
    {
      { "paper", "rock"},
      { "rock", "scissors"},
      { "scissors", "paper"}
    };
    public static List<string>AiChoice = new List<string>{"rock","paper","scissors"};


    public string Shoot (string player1)
    {
       Random r = new Random();
      int index = r.Next(AiChoice.Count);
      string player2 = AiChoice[index];
      if (player1 == player2)
      {
        Result="It's a draw! Computer chose " + player2;
      }
      else if (playWins[player1] == player2)
      {
        Result="You win! Computer chose " + player2;
      }
      else if (playWins[player2] == player1)
      {
        Result="Computer Wins! Computer chose " + player2;
      }
      return Result;
    }
  }
}
