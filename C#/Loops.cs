using System ;
namespace Loops
{
    class Program
    {
        static void Main()
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();

            string[] students = { "Davut", "Deniz", "Kaan", "Erdem" };

            ForEachLoop(students);

            bool primeNumberResult = IsPrimeNumber(6); 

            if(primeNumberResult == true)
            {
                Console.WriteLine("The number you entered is a prime number");
            }
            else
            {
                Console.WriteLine("The number you entered isnt a prime number");
            }

        }

        static void ForLoop()
        {
            for(int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);

                if(i == 100)
                {
                    Console.WriteLine("Finished !!!");
                }
            }
        }

        static void WhileLoop()
        {
            int number = 200;

            while(number >= 0)
            {
                Console.WriteLine(number);

                number -= 4;
                
            }
        }

        static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                number -= 1;

                Console.WriteLine(number);

            } while (number >= 1);
        }

        static void ForEachLoop(params string[] students)
        {
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for(int i =2; i <= number - 1; i++)
            {
                if(number%2 == 0)
                {
                    result = false;
                    i = number;
                }
                
            }
            return result;
        }
    }
}