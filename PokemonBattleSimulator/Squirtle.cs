namespace PokemonBattleSimulator;

internal class Squirtle : Pokemon
{
    public Squirtle(string nickname, Energytypes strength, Energytypes weakness) : base(nickname, strength, weakness)
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