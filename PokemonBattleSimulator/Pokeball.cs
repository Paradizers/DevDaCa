using System;

public class Pokeball
{
    public int Catchrate;
    public string color;
    public bool isOpen;
    public Charmander pokemon1;

    public Pokeball(int catchrate, string color, Charmander pokemon1)
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

