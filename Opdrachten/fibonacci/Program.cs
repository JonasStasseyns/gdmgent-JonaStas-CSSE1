using System;

namespace _3_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long would you like the row?");
            String input = Console.ReadLine();
            Console.WriteLine("-");
            int n = Convert.ToInt32(input);
            int tmpone = 0;
            int tmptwo = 1;
            int current;
            Console.WriteLine(0);
            Console.WriteLine(1);
            for (int i = 0; i < n; i++)
            {
                current = tmpone + tmptwo;
                tmpone = tmptwo;
                tmptwo = current;

                Console.WriteLine(current);
            }
        }
    }
}
