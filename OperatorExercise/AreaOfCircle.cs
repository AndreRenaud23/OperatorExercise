using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class AreaOfCircle
    {
        public static void Area()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("What is the radius of your circle");
            Console.WriteLine("----------------------------------------------");
            decimal radius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the type of measurement: ");
            Console.WriteLine("----------------------------------------------");
            var measurementType = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            decimal areaOfCircle = (radius * radius) * 22 / 7;
            decimal perimeterOfCircle = (radius + radius) * 22 / 7;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"The area of the circle is: {areaOfCircle} {measurementType}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"The perimeter of the circle is: {perimeterOfCircle} {measurementType}");
            Console.WriteLine("----------------------------------------------");






        }



    }
}
