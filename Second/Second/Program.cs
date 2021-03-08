using System;

namespace Second
{
    class Program2
    {
        public static int Base = 35;
        public static int PerKm = 7;
        public static int PerMin = 1;
        
        
        public static int Fare(int dist, int tim)
        {
            int final = Base + dist * PerKm + tim * PerMin;
            final += final * 7 / 100;
            if (final * 25 / 100 < 50)
            {
                final -= final * 25 / 100;
            }
            else
            {
                final = final - 50;
            }
            return final;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the Distance:");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time Required:");
            int time = Convert.ToInt32(Console.ReadLine());
            int fin_fare = Fare(distance,time);
            Console.WriteLine("Final Fare:");
            Console.Write(fin_fare);
            
        }
    }
}