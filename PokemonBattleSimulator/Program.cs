namespace PokemonBattleSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pokemon pikachu = new Pokemon("Sparky", "Electric");
            //pikachu.setName("Sparky");
            //pikachu.setType("Electric");
            //Console.WriteLine(pikachu.GetName());
            //Console.WriteLine(pikachu.GetType());
            Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

            Console.WriteLine("Please enter the name of your Charmander: ");
            string name = Console.ReadLine();

            // bool isRunning
            Charmander charmander = new Charmander(name, "Fire", "Water");
            while (true) // isRunning = true
            {
                charmander.DoBattleCry(10);
                Console.WriteLine("Please enter the name of your Charmander: ");
                Console.WriteLine("Do you want to quit, type yes");
                charmander.Nickname = Console.ReadLine();
                if (charmander.Nickname == "yes")
                {
                    break;
                }

                // isRunning = false;
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
    class Charmander
    {
        public string Nickname;

        public string Strength { get; }
        public string Weakness { get; }

        public Charmander(string nickname, string strength, string weakness)
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
}
