using System;

namespace First
{
    class Program1
    {
        public static String Win_Lose(int warrior,int arrow)
        {
            int ans = arrow / 3;
            if (ans > warrior)
            {
                Console.WriteLine("Wins");
            }
            else
            {
                Console.WriteLine("Loses");
            }

            return null;
        }
        
        public static void Main()
        {
            Random random = new Random();
            Console.Write("Total number of Warriors: ");
            int war= random.Next(1000);
            Console.WriteLine(war);
            Console.Write("Total number of Arrows: ");
            int ar= random.Next(1000);
            Console.WriteLine(ar);
            Console.WriteLine("Does the player WIN or LOSE?");
            Win_Lose(war, ar);
        }
    }
}
 