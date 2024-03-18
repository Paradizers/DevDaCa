using PokemonBattleSimulator;
using System;

public abstract class Pokemon
{
	public string Nickname;

	public Energytypes Strength { get; }
	public Energytypes Weakness { get; }
	// constructor
	public Pokemon(string nickname, Energytypes strength, Energytypes weakness)
	{
		Nickname = nickname;
		Strength = strength;
		Weakness = weakness;
	}

	// hier maak een  die functie aantal keer een string print
	public abstract void DoBattleCry(int times);
	
}
