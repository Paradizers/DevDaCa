using System;

public sealed class Pokeball
{
    public int Catchrate;
    public bool isOpen;
    public Pokemon pokemon1; 

    public Pokeball(int catchrate, Pokemon pokemon1)
    {
        this.Catchrate = catchrate;
        this.pokemon1 = pokemon1;
    }
    
/*
    public void SetPokemon(string pokemon1)
    {
        this.pokemon1 = pokemon1;
    }*/
}

