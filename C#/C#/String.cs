using System;
namespace Strings
{
    class Program
    {
        static void Main()
        {
            string cityOne = "Ankara";

            foreach (var item in cityOne)
            {
                Console.WriteLine(item);
            }

            string cityTwo = "Istanbul";

            string result = cityOne + " " + cityTwo;
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", cityOne, cityTwo));

            Console.ReadLine();
        }
    }
}