namespace ReferenceAndValueType
{
    class Program
    {
        static void Main()
        {
            int number1 = 20;
            int number2 = 30;
            number2 = number1;
            number1 = 50;

            Console.WriteLine(number2);

            string[] cities = { "Ankara", "Izmir", "Istanbul" };
            string[] cities2 = { "Mersin", "Adana", "Hatay" };

            // cities = cities2;
            // cities[0] = "Canakkale";

            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }

    internal class DataTable
    {

    }
}