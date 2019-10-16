using System;

namespace _2_faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            for(int i=(number-1); i>0; i--){
                number*=i;
                Console.WriteLine(number);
            }
            Console.WriteLine(input + "! = " + number);
        }
    }
}
