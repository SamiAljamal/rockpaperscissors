using Xunit;
using System.Collections.Generic;
using RockPaperScissors;
namespace RockPaperScissors
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void Shoot_PlayIsSame_Draw()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.Equal("It's a draw", testRockPaperScissors.Shoot("rock", "rock"));
    }
    [Fact]
    public void Shoot_P1RockP2Scissors_P1Wins()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.Equal("Player 1 Wins", testRockPaperScissors.Shoot("rock", "scissors"));
    }
    [Fact]
    public void Shoot_P1PaperP2Scissors_P2Wins()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.Equal("Player 2 Wins", testRockPaperScissors.Shoot("paper", "scissors"));
    }
    [Fact]
    public void Shoot_P1ScissorsP2Paper_P1Wins()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.Equal("Player 1 Wins", testRockPaperScissors.Shoot("scissors", "paper"));
    }

  }
}
