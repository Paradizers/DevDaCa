namespace PokemonBattleSimulator;

internal class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname, string strength, string weakness) : base(nickname, strength, weakness)
    {
    }
    public override void DoBattleCry(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine("Bulbasaur!");
        }
    }
}