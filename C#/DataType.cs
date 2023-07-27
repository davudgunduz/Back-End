using System;
namespace TypesAndVariables 
{
    class Program
    {
        static void Main()
        {
            int number1 = 10;
            int numberMaxInteger = int.MaxValue;
            int numberMinInteger = int.MinValue;

            Console.WriteLine("Number one is " + number1);
            Console.WriteLine("numberMaxInteger is " + numberMaxInteger);
            Console.WriteLine("numberMinInteger is " + numberMinInteger);

            long numberLong = 234354657534;
            long numberMaxLong = long.MaxValue;
            long numberMinLong = long.MinValue;

            Console.WriteLine("numberLong is " + numberLong);
            Console.WriteLine("numberMaxLong is " + numberMaxLong);
            Console.WriteLine("numberMinLong is " + numberMinLong);

            short numberShort = 32766;
            short numberMaxShort = short.MaxValue;
            short numberMinShort = short.MinValue;

            Console.WriteLine("numberShort is " + numberShort);
            Console.WriteLine("numberMaxShort is " + numberMaxShort);
            Console.WriteLine("numberMinShort is " + numberMinShort);

            byte numberByte = 254;
            byte numberMaxByte = byte.MaxValue;
            byte numberMinByte = byte.MinValue;

            Console.WriteLine("numberByte is " + numberByte);
            Console.WriteLine("numberMaxByte is " + numberMaxByte);
            Console.WriteLine("numberMinByte is " + numberMinByte);

            bool condition = true;
            bool conditionF = false;

            Console.WriteLine("condition is " + condition);
            Console.WriteLine("conditionF is " + conditionF);

            char character = 'A';

            Console.WriteLine(character);
            Console.WriteLine("The character's ascii code is  " + (int)character);

            double numberDouble = 23.4353;
            double numberMaxDouble = double.MaxValue;
            double numberMinDouble = double.MinValue;

            Console.WriteLine("numberDouble is " + numberDouble);
            Console.WriteLine("numberMaxDouble is " + numberMaxDouble);
            Console.WriteLine("numberMinDouble is " + numberMinDouble);

            decimal numberDecimal = 34.54676879993m;
            decimal numberMaxDecimal = decimal.MaxValue;
            decimal numberMinDecimal = decimal.MinValue;

            Console.WriteLine("numberDecimal is " + numberDecimal);
            Console.WriteLine("numberMaxDecimal is " + numberMaxDecimal);
            Console.WriteLine("numberMinDecimal is " + numberMinDecimal);

            Console.WriteLine(Days.Friday);

            var Variable = 7;
            Variable = 'A';

            Console.WriteLine(Variable);

        }
    }
     enum Days
    {
        Monday = 1 , Tuesday , Wednesday , Thursday , Friday , Saturday , Sunday
    }
}

