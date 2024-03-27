namespace PokemonBattleSimulator;

public class Battle{
    public int trainer1_score = 0;
    public int trainer2_score = 0;
    public void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        while (true)
        {
            
            Arena.battlesFought++;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Round " + (Arena.roundsFought + 1));

                Pokemon thrownPokemon = trainer1.Throw(i);
                trainer1.belt[i].pokemon1.DoBattleCry(1);

                Pokemon thrownPokemon2 = trainer2.Throw(i);
                trainer2.belt[i].pokemon1.DoBattleCry(1);

                if (trainer1.belt[i].pokemon1.Strength == trainer2.belt[i].pokemon1.Strength)
                {

                    Console.WriteLine("Draw");
                    if (trainer1_score > trainer2_score)
                    {
                        Console.WriteLine(trainer2.trainername + " loses a Pokemon because of more points");
                    }
                    else if (trainer2_score > trainer1_score)
                    {
                        Console.WriteLine(trainer1.trainername + " loses a Pokemon because of more points");
                    }
                    else
                    {
                        Console.WriteLine("Both trainers lose a Pokemon");
                    }
                }
                else if (trainer1.belt[i].pokemon1.Strength == trainer2.belt[i].pokemon1.Weakness)
                {
                    Console.WriteLine(trainer1.trainername + " wins this round!");
                    Console.WriteLine(trainer2.trainername + " loses a Pokemon");
                    trainer1_score += 1;
                    trainer2_score = 0;
                }
                else
                {
                    Console.WriteLine(trainer2.trainername + " wins this round!");
                    Console.WriteLine(trainer1.trainername + " loses a Pokemon");
                    trainer2_score += 1;
                    trainer1_score = 0;
                }
                trainer1.ReturnPokemon(thrownPokemon);
                trainer2.ReturnPokemon(thrownPokemon2);
                Arena.roundsFought++;
            }

            Arena.ShowScoreboard(this);

            Console.WriteLine("Do you want to quit? Type 'yes' to quit.");
            string continuebattle = Console.ReadLine();
            if (continuebattle == "yes")
            {
                break;
            }
        }
    }
}