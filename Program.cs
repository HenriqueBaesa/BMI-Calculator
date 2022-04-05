using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your height in meters? Ex.: 1.65");
            float height = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("What is your weight in Kg? Ex.: 70.3");
            float weight = Convert.ToSingle(Console.ReadLine());

            double  bmi = Math.Round( weight / (height * height) );

            Console.WriteLine("{0}, your height is {1} and your weight is {2}", name, height, weight);
            Console.WriteLine("Your BMI is {0}", bmi);

            if (bmi < 16)
            {
                Console.WriteLine("You are Underweight (Severe thinness)");
            }
            else if (bmi < 16.9)
            {
                Console.WriteLine("You are Underweight (Moderate thinness)");
            }
            else if (bmi < 18.4)
            {
                Console.WriteLine("You are Underweight (Mild thinness)");
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine("You are in the Normal range");
                return;
            }
            else if (bmi < 29.9)
            {
                Console.WriteLine("You are Overweight (Pre-obese)");
            }
            else if (bmi < 34.9)
            {
                Console.WriteLine("You are Obese (Class I)");
            }
            else if (bmi < 39.9)
            {
                Console.WriteLine("You are Obese (Class II)");
            }
            else
            {
                Console.WriteLine("You are Obese (Class III)");
            }

            if (bmi < 18.4)
            {
                Console.WriteLine("You need to gain at least {0}kg to be in the Normal Range",
                (18.4 * Math.Pow(height, 2) - weight));
            }
            else if (bmi > 24.9)
            {
                Console.WriteLine("You need to loose at least {0}kg to be in the Normal Range",
                weight - (24.9 * Math.Pow(height, 2)));
            }
        }
    }
}