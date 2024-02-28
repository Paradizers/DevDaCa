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
                for (int i = 0; i < 6; i++)
                {
                    Charmander pokemon1 = new Charmander("Charmander", "Fire", "Water");
                    Pokeball pokeball = new Pokeball(80, "rood", pokemon1);
                    beltTrainer1.Add(pokeball);

                    Squirtle sq = new Squirtle();
                    Pokeball pokeball = new Pokeball(80, "blue", sq);

                }

                List<Pokeball> beltTrainer2 = new List<Pokeball>();
                for (int i = 0; i < 6; i++)
                {
                    Charmander pokemon1 = new Charmander("Charmander", "Fire", "Water");
                    Pokeball pokeball = new Pokeball(80, "rood", pokemon1);

                    beltTrainer2.Add(pokeball);
                }

                Trainer trainer1 = new Trainer(beltTrainer1, Trainer1);
                Trainer trainer2 = new Trainer(beltTrainer2, Trainer2);

                while (true)
                {
                    int counter = 1;
                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("Round " + counter);
                        trainer1.Throw();
                        trainer1.belt[i].pokemon1.DoBattleCry(1);

                        trainer2.Throw();
                        trainer2.belt[i].pokemon1.DoBattleCry(1);

                        trainer1.ReturnPokemon();
                        trainer2.ReturnPokemon();
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
