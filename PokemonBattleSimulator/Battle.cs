namespace PokemonBattleSimulator;

public class Battle{
    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        while (true)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Round " + Arena.roundsFought);

                Pokemon thrownPokemon = trainer1.Throw(i);
                trainer1.belt[i].pokemon1.DoBattleCry(1);

                Pokemon thrownPokemon2 = trainer2.Throw(i);
                trainer2.belt[i].pokemon1.DoBattleCry(1);

                if (trainer1.belt[i].pokemon1.Strength == trainer2.belt[i].pokemon1.Strength)
                {
                    Console.WriteLine("Draw");
                }
                else if (trainer1.belt[i].pokemon1.Strength == trainer2.belt[i].pokemon1.Weakness)
                {
                    Console.WriteLine(trainer1.trainername + " wins this round!");
                }
                else
                {
                    Console.WriteLine(trainer2.trainername + " wins this round!");
                }

                trainer1.ReturnPokemon(thrownPokemon);
                trainer2.ReturnPokemon(thrownPokemon2);
                Arena.roundsFought++;
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