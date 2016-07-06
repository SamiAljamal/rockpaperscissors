using System.Collections.Generic;
using System;
using RockPaperScissors;
using System.IO;


namespace RockPaperScissors
{
  public class RockPaperScissors
  {
    public string Result;
    public string Win;
    public Dictionary<string, string> playWins = new Dictionary<string, string>()
    {
      { "paper", "rock"},
      { "rock", "scissors"},
      { "scissors", "paper"}
    };
    public static List<string>AiChoice = new List<string>{"rock","paper","scissors"};

    public List<string> Shoot(string player1)
    {
      List<string> playResult = new List<string>{};
      Random r = new Random();
      int index = r.Next(AiChoice.Count);
      string player2 = AiChoice[index];
      if (player1 == player2)
      {
        Result="It's a draw! Computer chose " + player2;
        playResult.Add(Result);
        Win="";
        playResult.Add(Win);
      }
      else if (playWins[player1] == player2)
      {
        Result="You win! Computer chose " + player2;
        playResult.Add(Result);
        Win=player1;
        playResult.Add(Win);
      }
      else if (playWins[player2] == player1)
      {
        Result="Computer Wins! Computer chose " + player2;
        playResult.Add(Result);
        Win=player2;
        playResult.Add(Win);
      }
      return playResult;
    }
  }
}
