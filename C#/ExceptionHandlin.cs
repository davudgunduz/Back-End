using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling;

internal class Program
{
    private static void Main(string[] args)
    {
        ExceptionIntro();
        try
        {
            Find();
        }
        catch (RecordNotFoundException exception)
        {
            Console.WriteLine(exception);
        }

        Console.ReadLine();

        void ExceptionIntro()
        {
            try
            {
                string[] students = new string[] { "Mehmet", "Davut", "Ali" };
                students[3] = "Turhan";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                //Console.WriteLine(exception.InnerException);
            }
        }

        void Find()
        {
            List<string> students = new List<string>() { "Davut", "Mecit", "Selim" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException
                {
                     Message = "Record not found"
                };
            }
            else
            {
                Console.WriteLine("Record found!");
            }

        }
    }
}

namespace ExceptionHandling
{
    public class RecordNotFoundException : Exception
    {
        public static void RecordNotFoundException() : base(message)
        {

        }
    }

}