using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Objective: Calculate the perimeter and area of the classroom based on user's input
            Console.WriteLine("Welcome to the Room Calculator!" +
                "\nPlease enter your answer in feet!\n");
            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                GetUserInput("\nEnter Length: ");
                double length = double.Parse(Console.ReadLine());

                GetUserInput("Enter Width ");
                double width = double.Parse(Console.ReadLine());

                //The height is also calculated to get the volume but is asked in the GetVolume Method only if they would like to proceed.
                //The reason why I did this is because I didn't want the user to input information if they didn't want to.
                GetVolume(length, width);

                //Calculations in GetArea Method
                GetArea(length, width);

                //Calculations in GetPerimeter Method
                GetPerimeter(length, width);

            } while (Continue());

        }

        static string GetUserInput(string userResponse)
        {
            //created a seperate method to get any input. 
            Console.WriteLine(userResponse);
            return userResponse;
        }

        static void GetArea(double length, double width)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //area = length * width
            double area = length * width;
            Console.WriteLine($"Area: {area} feet squared");
        }

        static void GetPerimeter(double length, double width)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //perimeter = 2 * (length + width)
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Perimeter: {perimeter} feet squared\n");
            Console.ReadLine();

        }

        static void GetVolume(double width, double length)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //the user only inputs the height if they want to continue.
            GetUserInput("\nWould you also like to get the volume of your room? Enter y/n: ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "yes" || userResponse == "y")
            {
                GetUserInput("Enter Height: ");
                double height = double.Parse(Console.ReadLine().ToLower());
                double volume = length * width * height;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nVolume: {volume} feet cubed");
            }
            else if (userResponse == "no" || userResponse == "n")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error! Please enter either 'y' or 'n': ");
            }


        }
        static bool Continue()
        {
            Console.ForegroundColor = ConsoleColor.White;
            GetUserInput("Would you like to continue? Please enter y/n: ");
            string userContinue = Console.ReadLine().ToLower();

            if (userContinue == "yes" || userContinue == "y")
            {
                Console.WriteLine("Awesomesauce! \n");
                return true;
            }
            else if (userContinue == "no" || userContinue == "n")
            {
                Console.WriteLine("Thanks for your input, have a nice day!");
                return false;
            }
            else
            {
                Console.WriteLine("Error! Please answer with a either y/n: ");
                Continue();
            }

            return true;
        }

    }

}

