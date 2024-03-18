using ListRandomizer;

namespace PokemonBattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

            void CreateTrainer()
            {
                Console.WriteLine("What is Trainer1's name?");
                string Trainer1 = Console.ReadLine();

                Console.WriteLine("What is Trainer2's name?");
                string Trainer2 = Console.ReadLine();

                List<Pokeball> beltTrainer1 = new List<Pokeball>();
                for (int i = 0; i < 2; i++)
                {
                    Charmander ch = new Charmander("Charmander", "Fire","Water");
                    Pokeball pokeball = new Pokeball(80, ch);
                    beltTrainer1.Add(pokeball);

                    Squirtle sq = new Squirtle("Squirtle", "Water", "Leaf");
                    Pokeball pokeball2 = new Pokeball(80, sq);
                    beltTrainer1.Add(pokeball2);

                    Bulbasaur br = new Bulbasaur("Bulbasaur", "Grass", "Fire");
                    Pokeball pokeball3 = new Pokeball(80, br);
                    beltTrainer1.Add(pokeball3);

                }

                List<Pokeball> beltTrainer2 = new List<Pokeball>();
                for (int i = 0; i < 2; i++)
                {
                    Charmander ch = new Charmander("Charmander", "Fire", "Water");
                    Pokeball pokeball = new Pokeball(80, ch);
                    beltTrainer2.Add(pokeball);

                    Squirtle sq = new Squirtle("Squirtle", "Water", "Leaf");
                    Pokeball pokeball2 = new Pokeball(80, sq);
                    beltTrainer2.Add(pokeball2);

                    Bulbasaur br = new Bulbasaur("Bulbasaur", "Grass", "Fire");
                    Pokeball pokeball3 = new Pokeball(80, br);
                    beltTrainer2.Add(pokeball3);

                }

                Trainer trainer1 = new Trainer(beltTrainer1, Trainer1);
                Trainer trainer2 = new Trainer(beltTrainer2, Trainer2);

                trainer1.belt.Shuffle();
                trainer2.belt.Shuffle();
                while (true)
                {
                    int counter = 1;
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("Round " + counter);
                        Pokemon thrownPokemon = trainer1.Throw(i);
                        trainer1.belt[i].pokemon1.DoBattleCry(1);

                        Pokemon thrownPokemon2 = trainer2.Throw(i);
                        trainer2.belt[i].pokemon1.DoBattleCry(1);

                        trainer1.ReturnPokemon(thrownPokemon);
                        trainer2.ReturnPokemon(thrownPokemon2);
                        counter++;
                    }

                    Console.WriteLine("Do you want to quit? Type 'yes' to quit.");
                    string continuebattle = Console.ReadLine();
                    if (continuebattle == "yes")
                    {
                        break;
                    }
                }
            }
        CreateTrainer();
        
        }
    }
}

/*class Pokemon
    {
        public string name;
        public string type;

        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public string GetName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string GetType()
        {
            return type;
        }
        public string setType(string type)
        {
            return type;
        }
    }*/
