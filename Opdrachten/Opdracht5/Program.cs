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
                int substraction = num1 - num2;
                Console.WriteLine(' ');
                Console.WriteLine("VERSCHIL: " + num1 + " - " + num2 + " = " + substraction);
                Console.WriteLine(' ');
            }
            void multiplyNumbers(int num1, int num2){
                int multiplied = num1 * num2;
                Console.WriteLine(' ');
                Console.WriteLine("PRODUCT: " + num1 + " x " + num2 + " = " + multiplied);
                Console.WriteLine(' ');
            }
            void divideNumbers(int num1, int num2){
                int quotient = num1 / num2;
                Console.WriteLine(' ');
                Console.WriteLine("QUOTIENT: " + num1 + " / " + num2 + " = " + quotient);
                Console.WriteLine(' ');
            }

            addNumbers(4, 5);
            subtractNumbers(10, 6);
            multiplyNumbers(3, 6);
            divideNumbers(20, 4);
        }

        
    }
}
