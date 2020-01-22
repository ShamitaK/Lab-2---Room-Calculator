using System;

namespace Lab_2___Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLength, roomWidth;
            char userResponse = 'y';

            while (userResponse == 'y')
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Length: ");
                roomLength = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                roomWidth = double.Parse(Console.ReadLine());

                Console.Write("Enter Height: ");
                double roomHeight = double.Parse(Console.ReadLine());


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"\nEnter Length: {roomLength} \nEnter Width: {roomWidth} \nEnter Height: {roomHeight}\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                double roomArea = (roomLength * roomWidth);
                Console.WriteLine($"\nArea: {roomArea}");

                double roomPerimeter = (2 * (roomLength + roomWidth));
                Console.WriteLine($"Perimeter: {roomPerimeter}");

                double roomVolume = (roomLength * roomWidth * roomHeight);
                Console.WriteLine($"Volume: {roomVolume}"); ;


                userResponse = ' ';

                while ((userResponse != 'y') && (userResponse != 'n'))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nContinue? (y/n) ");
                    userResponse = char.Parse(Console.ReadLine());

                    Console.WriteLine("Welcome Back!\n");
                }

            }


            Console.WriteLine("Okie Dokie. Thank you for your time!");

            Console.ReadLine();


       

       
            
        }

    }
}
