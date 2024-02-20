using System;
using System.Collections.Generic;

public class Trainer
{
	void CreateTrainer()
	{
        Console.WriteLine("What is Trainer1 his name?");
        string Trainer1 = Console.ReadLine();

        Console.WriteLine("What is Trainer2 his name?");
        string Trainer2 = Console.ReadLine();


        try
        {

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
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
