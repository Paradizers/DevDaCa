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
    
    public Pokemon Throw(int i)
    {
        Pokeball pokeball = belt[i];
        pokeball.isOpen = true;
        Console.WriteLine(trainername + " Throws a " + pokeball.pokemon1.Nickname);
        return pokeball.pokemon1;
    }
    public bool ReturnPokemon(Pokemon pokemonToReturn)
    {
        bool isOpen = false;
        Console.WriteLine(trainername + " his " + pokemonToReturn.Nickname + " returns to its Pokeball.");
        return isOpen;
        
    }

}
