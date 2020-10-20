using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double lengthSquare = double.Parse(Console.ReadLine());
                double areaSquare = lengthSquare * lengthSquare;

                Console.WriteLine($"{areaSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double lengthA = double.Parse(Console.ReadLine());
                double lengthB = double.Parse(Console.ReadLine());
                double areaRectangle = lengthA * lengthB;

                Console.WriteLine($"{areaRectangle:f3}");
            }
            else if (figure == "circle")
            {
                double Radius = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * (Math.Pow(Radius, 2)); 

                Console.WriteLine($"{areaCircle:f3}");
            }
            else if (figure == "triangle")
            {
               
                double lengthSide = double.Parse(Console.ReadLine());
                double Height = double.Parse(Console.ReadLine());
                double areatriangle = 0.5 * lengthSide * Height;

                Console.WriteLine($"{areatriangle:f3}");
            }
        }
    }
}
