using System;

namespace Conditionals
{
    class Program
    {
        static void Main()
        {
            int numberOne = 10;
            if (numberOne == 10)
            {
                Console.WriteLine("NumberOne is 10 ");
            }
            else
            {
                Console.WriteLine("NumberOne is not 10");
            }

            Console.WriteLine( numberOne == 15 ? "NumberOne is 10" : "NumberOne is not 10 ");

            int numberTwo = 11;

            if (numberTwo == 10)
            {
                Console.WriteLine("NumberTwo is 10 ");
            }
            else if(numberTwo == 20)
            {
                Console.WriteLine("NumberTwo is 20 ");
            }
            else
            {
                Console.WriteLine("NumberTwo is not 10 or 20 ");
            }

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            int numberThree = 17;

            if(numberThree >= 0 && numberThree <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (numberThree >= 100 && numberThree < 200)
            {
                Console.WriteLine("Number is between 100-200");
            }
            else
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                if(numberTwo > numberThree)
                {
                    Console.WriteLine(numberOne + " > " + numberTwo + " > " + numberThree);
                }
                else
                {
                    Console.WriteLine(numberOne + " > " + numberThree + " > " + numberTwo);
                }
            }
            else if(numberTwo > numberOne && numberTwo > numberThree)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine(numberTwo + " > " + numberOne + " > " + numberThree);
                }
                else
                {
                    Console.WriteLine(numberTwo + " > " + numberThree + " > " + numberOne);
                }
            } else if (numberThree > numberOne && numberThree > numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    Console.WriteLine(numberThree + " > " + numberOne + " > " + numberTwo);
                }
                else
                {
                    Console.WriteLine(numberThree + " > " + numberTwo + " > " + numberOne);
                }
            }

                Console.ReadLine();
        }
    }
}