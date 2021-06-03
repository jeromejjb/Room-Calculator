using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "yes";


            while (userAnswer == "yes")
            {
                Console.WriteLine("Enter the length of the class room");
                string input = Console.ReadLine();
                double length = double.Parse(input);
                double area = length * length;

                Console.WriteLine(" Enter the width of the class room");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);
                double perimeter = 2 * (width + width);

                Console.WriteLine($"Area: {area}");

                Console.WriteLine($"Perimeter: {perimeter} ");

                Console.WriteLine($"Carpet Tiles: {area / 5}");
                Console.WriteLine($"Paint: {perimeter / 5}");
                Console.WriteLine($"Volume: {area * area * perimeter  }");


                Console.Write("would you like to do another calculation? ");
                userAnswer = Console.ReadLine();

                //making room for exceptions 
            }



        }
    }
}
