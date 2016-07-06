using System.Collections.Generic;
using System;

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

    public string Shoot (string player1, string player2)
    {
      if (player1 == player2)
      {
        Result="It's a draw";
      }
      else if (playWins[player1] == player2)
      {
        Result="Player 1 Wins";
      }
      else if (playWins[player2] == player1)
      {
        Result="Player 2 Wins";
      }
      return Result;
    }
  }
}
