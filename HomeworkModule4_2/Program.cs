using System;

namespace HomeworkModule4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userRequestedExit = false;
            while (userRequestedExit == false)
            {
                Console.WriteLine("Please choose one option.");
                Console.WriteLine("Options: \n1.Calculate circle area \n2.Calculate square area \n3.Exit");
                Console.WriteLine("Enter an option number:");
                string optionNumber = Console.ReadLine();

                switch (optionNumber)
                {
                    case "1":
                        CalcCircle();
                        break;
                    case "2":
                        CalcSquare();
                        break;
                    case "3":
                        userRequestedExit = true;
                        break;
                    default:
                        InvalidInput();
                        break;
                }
            }
            
        static void CalcCircle()
            {
                Console.WriteLine("Enter a radius:");
                string inputRadius = Console.ReadLine();
                try
                {
                    double radius = Convert.ToDouble(inputRadius);

                    if (radius == 0)
                    {
                        Console.WriteLine("Can't calculate a circle area.");
                        Console.ReadLine();
                    }
                    else
                    {
                        double circleArea = Math.PI * radius * radius;
                        Console.WriteLine($"Calculated circle area: {circleArea}");
                        Console.ReadLine();
                    }
                    
                }
                catch
                {
                    InvalidInput();
                }
        }

        static void CalcSquare()
            {
                Console.WriteLine("Enter a side:");
                string inputSide = Console.ReadLine();
                try
                {
                    double side = Convert.ToDouble(inputSide);

                    if (side == 0)
                    {
                        Console.WriteLine("Can't calculate a square area.");
                        Console.ReadLine();
                    }
                    else
                    {
                        double squareArea = side * side;
                        Console.WriteLine($"Calculated square area: {squareArea}");
                        Console.ReadLine();
                    }

                }
                catch
                {
                    InvalidInput();
                }                               
            }

        static void InvalidInput()
            {
                Console.WriteLine("Invalid input.Try again.");
                Console.ReadLine();
            }        
        }
    }
}
