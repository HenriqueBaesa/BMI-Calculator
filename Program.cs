using System;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your height in meters? Ex.: 1.65");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your weight in Kg? Ex.: 70.3");
double weight = Convert.ToDouble(Console.ReadLine());

Person person = new Person(name, height, weight);

Console.WriteLine("{0}, your height is {1} and your weight is {2}", person.Name, person.Height, person.Weight);
Console.WriteLine("Your BMI is {0}", person.Bmi);
Console.WriteLine("You are in the {0} range", person.BmiRange());
Console.WriteLine("You need to loose {0} to get to normal range", person.WeightUntilNormal());
