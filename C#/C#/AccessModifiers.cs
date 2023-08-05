namespace AccessModifiers
{
    class Program
    {
        static void Main()
        {



            Console.ReadLine();
        }
    }

    public class Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        protected void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    internal class SqlServer : Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        protected void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}