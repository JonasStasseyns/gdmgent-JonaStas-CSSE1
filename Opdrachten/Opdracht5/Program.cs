using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            void addNumbers(int getal1, int getal2){
                int sum = getal1 + getal2;
                Console.WriteLine(' ');
                Console.WriteLine("SOM: " + getal1 + " + " + getal2 + " = " + sum);
                Console.WriteLine(' ');
            }
            void subtractNumbers(int getal1, int getal2){
                int substraction = getal1 - getal2;
                Console.WriteLine(' ');
                Console.WriteLine("VERSCHIL: " + getal1 + " - " + getal2 + " = " + substraction);
                Console.WriteLine(' ');
            }
            void multiplyNumbers(int getal1, int getal2){
                int multiplied = getal1 * getal2;
                Console.WriteLine(' ');
                Console.WriteLine("PRODUCT: " + getal1 + " x " + getal2 + " = " + multiplied);
                Console.WriteLine(' ');
            }
            void divideNumbers(int getal1, int getal2){
                int quotient = getal1 / getal2;
                Console.WriteLine(' ');
                Console.WriteLine("QUOTIENT: " + getal1 + " / " + getal2 + " = " + quotient);
                Console.WriteLine(' ');
            }
            void modulusNumbers(int getal1, int getal2){
                int rest = getal1 % getal2;
                Console.WriteLine(' ');
                Console.WriteLine("MODULO: " + getal1 + " % " + getal2 + " = " + rest);
                Console.WriteLine(' ');
            }
            void increaseNum(int getal){
                int verhoogd = getal+1;
                Console.WriteLine(' ');
                Console.WriteLine("VERHOOGD: " + getal + " + 1 = " + verhoogd);
                Console.WriteLine(' ');
            }
            void decreaseNum(int getal){
                int verlaagd = getal-1;
                Console.WriteLine(' ');
                Console.WriteLine("VERLAAGD: " + getal + " - 1 = " + verlaagd);
                Console.WriteLine(' ');
            }
            void randomNumber(){
                Random random = new Random();
                int randInt = random.Next();
                Console.WriteLine(' ');
                Console.WriteLine("WILLEKEURIG: " + randInt);
                Console.WriteLine(' ');
            }
            void randomNumberRange(int min, int max){
                Random random = new Random();
                int randInt = random.Next(min, max);
                Console.WriteLine(' ');
                Console.WriteLine("WILLEKEURIG BEREIK: " + randInt);
                Console.WriteLine(' ');
            }

            addNumbers(5, 6);
            subtractNumbers(8, 5);
            multiplyNumbers(5, 3);
            divideNumbers(8, 4);
            modulusNumbers(5, 3);
            increaseNum(7);
            decreaseNum(8);
            randomNumber();
            randomNumberRange(0, 80);
        }

        
    }
}
