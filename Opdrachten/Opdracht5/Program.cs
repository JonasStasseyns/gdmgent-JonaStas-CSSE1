using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            void addNumbers(int num1, int num2){
                int sum = num1 + num2;
                Console.WriteLine(' ');
                Console.WriteLine("SOM: " + num1 + " + " + num2 + " = " + sum);
                Console.WriteLine(' ');
            }

            void subtractNumbers(int num1, int num2){
                int sum = num1 - num2;
                Console.WriteLine(' ');
                Console.WriteLine("VERSCHIL: " + num1 + " - " + num2 + " = " + sum);
                Console.WriteLine(' ');
            }

            addNumbers(4, 5);
            subtractNumbers(10, 6);
        }

        
    }
}
