using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Weight(Lb):");
            float bodyweight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Height(Feet):");
            float Feet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Height(Inches):");
            float Inches = Convert.ToInt32(Console.ReadLine());

            float height = (Feet * 12) + Inches;
            float Result = (bodyweight * 703) / (height * height);
            Console.WriteLine("Your BMI:" + Result);
            if (Result < 18.5)
            {
                Console.WriteLine("Your BMI is underweight");
            }
            else if (Result > 18.5 && Result < 24.9)
            {
                Console.WriteLine("Your BMI is Normalweight");
            }
            else if (Result > 25 && Result < 29.9)
            {
                Console.WriteLine("Your BMI is overweight");
            }
            else
            {
                Console.WriteLine("Your BMI is obesity");
            }


        }
    }
}
