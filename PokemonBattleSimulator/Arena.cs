using System;

public class Arena
{
    public static int roundsFought = 1;
    public static int battlesFought = 1;
    public static void ShowScoreboard()
    {
        Console.WriteLine("Scoreboard:");
        Console.WriteLine("Rounds Fought:" + roundsFought);
        Console.WriteLine("Battles Fought:" + battlesFought);
    }
}
