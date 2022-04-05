using System;

public class Person
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Bmi { get =>  Math.Round( Weight / (Height * Height), 2);}

    public Person(string name, double height, double weight)
    {
        Name = name;
        Height = height;
        Weight = weight;
    }

    public string BmiRange ()
    {
        if (Bmi < 16)
        {
            return "Underweight (Severe thinness)";
        }
        else if (Bmi < 16.9)
        {
            return "Underweight (Moderate thinness)";
        }
        else if (Bmi < 18.4)
        {
            return "You are Underweight (Mild thinness)";
        }
        else if (Bmi < 24.9)
        {
            return "Normal";
        }
        else if (Bmi < 29.9)
        {
            return "Overweight (Pre-obese)";
        }
        else if (Bmi < 34.9)
        {
            return "Obese (Class I)";
        }
        else if (Bmi < 39.9)
        {
            return "Obese (Class II)";
        }
        else
        {
            return "Obese (Class III)";
        } 
    }

    public double WeightUntilNormal()
    {
        if (Bmi < 18.4)
        {
            return (18.4 * Math.Pow(Height, 2) - Weight);
        }
        else if (Bmi > 24.9)
        {
            return Weight - (24.9 * Math.Pow(Height, 2));
        }

        return 0;
    }
}