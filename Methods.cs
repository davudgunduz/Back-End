using System;

namespace Methods
{
    class Program
    {
        static void Main ()
        {
            // Add();

            int number1 = 173;
            int number2 = 23;

            int resultAdd = Add(20 , 30);
            Console.WriteLine(resultAdd);

            int resultMultiply = Multiply(3, 7);
            Console.WriteLine(resultMultiply);

            int resultSubtraction = Subtraction(20, 30);
            Console.WriteLine(resultSubtraction);

            float resultDivision = Division(20);
            Console.WriteLine(resultDivision);

            int resultAdd2 = Add2(ref number1 , 30);
            Console.WriteLine(resultAdd2);

            int resultMultiply2 = Multiply2(3,out number2);
            Console.WriteLine(resultMultiply2);

            int resultAddOverloading = Add(20, 30 , 40);
            Console.WriteLine(resultAddOverloading);

            int resultAddParams1 = Add3(20, 30, 40 , 50, 60);
            Console.WriteLine(resultAddParams1);


            int resultAddParams2 = Add3(20, 30, 40, 50, 60 ,70 , 80);
            Console.WriteLine(resultAddParams2);

            Console.ReadLine();
        }

        //static void Add()?
        //{
        //    // Console.WriteLine(" Added ! ");
        //    Console.WriteLine(" Added !!! ");
        //}

        static int Add(int number1 ,int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1 , int number2)
        {
            return number1 * number2;
        }

        static int Subtraction(int number1 , int number2)
        {

            return Math.Abs(number1 - number2);
        }

        static float Division(int number1 , int number2 = 2)
        {
            return number1 / number2;
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 17;
            return number1 + number2;
        }

        static int Multiply2(int number1, out int number2)
        {
            number2 = 20;
            return number1 * number2;
        }

        static int Add(int number1, int number2 , int number3)
        {
            return number1 + number2 + number3;
        }

        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}