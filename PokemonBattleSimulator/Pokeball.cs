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

    public Pokeball()
    {
        isOpen = false;
        string pokemon1 = "";
    }
    public void Throw()
    {
        if (!isOpen)
        {
            isOpen = true;
            Console.WriteLine( pokemon1 + "appears and does its battle cry!");
        }
    }

    public void ReturnPokemon()
    {
        if (isOpen)
        {
            isOpen = false;
            Console.WriteLine( pokemon1 + "returns to its Pokeball.");
        }
    }
/*
    public void SetPokemon(string pokemon1)
    {
        this.pokemon1 = pokemon1;
    }*/
}

