namespace PokemonBattleSimulator;
using System;

public class Charmander : Pokemon 
{
    public Charmander(string nickname, Energytypes strength, Energytypes weakness) : base(nickname, strength, weakness)
    {
    }

    public override void DoBattleCry(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine("Charmander!");
        }
    }
}
