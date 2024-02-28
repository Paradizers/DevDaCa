using System;

public class Pokeball
{
    public int Catchrate;
    public string color;
    public bool isOpen;
    public Pokemon pokemon1;

    public Pokeball(int catchrate, string color, Pokemon pokemon1)
    {
        this.Catchrate = catchrate;
        this.color = color;
        this.pokemon1 = pokemon1;
    }
    
/*
    public void SetPokemon(string pokemon1)
    {
        this.pokemon1 = pokemon1;
    }*/
}

