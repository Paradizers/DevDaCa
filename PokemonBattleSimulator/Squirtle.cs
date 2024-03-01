namespace PokemonBattleSimulator;

internal class Squirtle : Pokemon
{
    public Squirtle(string nickname, string strength, string weakness) : base(nickname, strength, weakness)
    {
    }
    public override void DoBattleCry(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine("Squirtle!");
        }
    }
}