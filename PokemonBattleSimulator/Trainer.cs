using System;
using System.Collections.Generic;

public class Trainer
{   
    public List<Pokeball> belt;
    public string trainername;
    public Trainer(List<Pokeball> belt, string trainername)
    {
        this.belt = belt;
        this.trainername = trainername;
    }
    
    public bool Throw()
    {
       
        Pokeball pokeball = belt[0];
        bool isOpen = true;
        Console.WriteLine(trainername + " Throws a Charmander!");
        return isOpen;
    }
    public bool ReturnPokemon()
    {
        bool isOpen = false;
        Console.WriteLine(trainername + " his Charmander returns to its Pokeball.");
        return isOpen;
        
    }

}
