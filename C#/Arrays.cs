using System ;
namespace Arrays
{
    class Program
    {
        static void Main()
        {
            string[] students = new string[3];
            students[0] = "Ali";
            students[1] = "Veli";
            students[2] = "Salih";

            string[] brothers = { "Davut", "Mecit", "Selim" };

            Series(students);

            string[,] regions =
            {
                {"Istanbu","Bursa","Edirne" },
                {"Izmir","Mugla","Aydin" },
                {"Hatay","Mersin","Adana" },
                {"Diyarbakir","Bitlis","Van" },
                {"Ankara","Nigde","Konya" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.ReadLine();
        }

        static void Series (params string[] students)
        {
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}