using System;

public class Trainer
{
	void TrainerFight()
	{
        Console.WriteLine("What is Trainer1 his name?");
        string Trainer1 = Console.ReadLine();

        Console.WriteLine("What is Trainer2 his name?");
        string Trainer2 = Console.ReadLine();

        string[] PokemonNames = { "Pikachu", "Sableye", "Bulbasaur", "Squirtle","Meowth", "Bobbafett", "Charizard", "Greninja", "Lucario", "Talonflame", "Froki", "Garchomp" };
        for  (int i = 0; i < PokemonNames.Length; i++)
        {
            Console.WriteLine(PokemonNames[i]);
        }
        List<Pokeball> beltTrainer1 = new List<Pokeball>();
        for (int i = 0; i < 6; i++)
        {   
            Charmander pokemon1 = new Charmander("Charmander", "Fire", "Water");
            Pokeball pokeball = new Pokeball(80, "rood", pokemon1);
            beltTrainer1.Add(pokeball);
        }

        List<Pokeball> beltTrainer2 = new List<Pokeball>();
        for (int i = 0; i < 6; i++)
        {
            Charmander pokemon1 = new Charmander("Charmander", "Fire", "Water");
            Pokeball pokeball = new Pokeball(80, "rood", pokemon1);
            beltTrainer2.Add(pokeball);
        }
    }
}
