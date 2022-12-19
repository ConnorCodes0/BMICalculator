using System;

namespace BMICalculator {

    internal class Program { 
    static void Main(string[] args)
    {
            int height = heightInInches();
            int weight = weightInPounds();
            //output the bmi
            double BMI = outputBMI(height, weight);
            Console.WriteLine($"Your BMI is {BMI}");
    }

    //calculate height
    static int heightInInches()
        {
            int feet;
            int inches;

            Console.WriteLine("What is your height in feet?");
            feet = int.Parse(Console.ReadLine());
            
            //check for valid height
            while (!(feet > 2 && feet <= 7))
            {
                Console.WriteLine("Enter a valid height!");
                feet = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("What is your height in inches?");
            inches = int.Parse(Console.ReadLine());

            //check for valid height
            while (!(inches > 0 && inches <= 11))
            {
                Console.WriteLine("Enter a valid height!");
                inches = int.Parse(Console.ReadLine());
            }

            int height = feet * 12 + inches;
       
            return height;
        }

        //calculate weight
        static int weightInPounds()
        {
            int stones;
            int pounds;

            Console.WriteLine("What is your weight in stones?");
            stones = int.Parse(Console.ReadLine());

            //check for valid weight
            while (!(stones > 3 && stones <= 30))
            {
                Console.WriteLine("Enter a valid weight!");
                stones = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("What is your weight in pounds?");
            pounds = int.Parse(Console.ReadLine());

            //check for valid weight
            while (!(pounds > 0 && pounds <= 13))
            {
                Console.WriteLine("Enter a valid weight!");
                pounds = int.Parse(Console.ReadLine());
            }

            int weight = stones * 14 + pounds;

            return weight;
        }

        //calculate BMI
        static double outputBMI(int height, int weight) {
            double BMI = (weight * 703) / Math.Pow(height, 2);
            //round bmi to 2 decimal place
            BMI = Math.Round(BMI, 2);

            return BMI;
        }
    }
}