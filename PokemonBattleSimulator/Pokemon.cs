﻿using System;

public abstract class Pokemon
{
	public string Nickname;

	public string Strength { get; }
	public string Weakness { get; }
	// constructor
	public Pokemon(string nickname, string strength, string weakness)
	{
		Nickname = nickname;
		Strength = strength;
		Weakness = weakness;
	}

	// hier maak een  die functie aantal keer een string print
	public void DoBattleCry(int times)
	{
		for (int i = 0; i < times; i++)
		{
			Console.WriteLine($"{Nickname} says: {Nickname}!");
		}
	}
}
