using System;
namespace PokemonBattleSimulator;

public class Arena
{
    public static int roundsFought = 0;
    public static int battlesFought = 0;
    public static void ShowScoreboard(Battle battle)
    {
        Console.WriteLine("Scoreboard:");
        Console.WriteLine("Trainer1 score:" + battle.trainer1_score);
        Console.WriteLine("Trainer2 score:" + battle.trainer2_score);
        Console.WriteLine("Rounds Fought:" + roundsFought);
        Console.WriteLine("Battles Fought:" + battlesFought);
    }
}
