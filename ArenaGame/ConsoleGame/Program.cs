using ArenaGame;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles: ");
            int rounds = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < rounds; i++)
            {
                Hero one, two;
                do
                {
                    one = MyHeroes();
                    two = MyHeroes();
                }
                while (one.Name == two.Name);

                Console.WriteLine($"Arena fight between: {one.Name} and {two.Name}");
                Arena arena = new Arena(one, two);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
            }

        }

        static Hero MyHeroes()
        {
            int heroesOnTheList = Random.Shared.Next(4);
            switch (heroesOnTheList)
            {
                case 0: return new Knight("Sir Lancelot");
                case 1: return new Rogue("Robin Hood");
                case 2: return new Headhunter("Crazy Jackson");
                case 3: return new Nymph("GalaThea");
                default: return new Knight("Sir Lancelot"); 
            }
        }
    }
}



