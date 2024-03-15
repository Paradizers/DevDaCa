namespace PokemonBattleSimulator;

public class Battle{
    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        while (true)
        {
            int counter = 1;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Round " + counter);
                Pokemon thrownPokemon = trainer1.Throw(i);
                trainer1.belt[i].pokemon1.DoBattleCry(1);

                Pokemon thrownPokemon2 = trainer2.Throw(i);
                trainer2.belt[i].pokemon1.DoBattleCry(1);

                trainer1.ReturnPokemon(thrownPokemon);
                trainer2.ReturnPokemon(thrownPokemon2);
                counter++;
            }

            Console.WriteLine("Do you want to quit? Type 'yes' to quit.");
            string continuebattle = Console.ReadLine();
            if (continuebattle == "yes")
            {
                break;
            }
        }
    }
}