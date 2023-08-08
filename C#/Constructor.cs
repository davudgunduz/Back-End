using Microsoft.VisualBasic;
using System.Reflection.Metadata;
namespace Constructors
{
    class Program
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product
            {
                Id = 1,
                Name = "Dell"
            };

            Product product2 = new Product(2, "Apple");  
            PersonManager personManager = new PersonManager(" ");
            personManager.Message();

            Teacher.Number = 10;
            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 10;
        CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public int count { get; set; }
        public void List()
        {
            Console.WriteLine("Listed {0} items !!!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added !!!");
        }

    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id , string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine(" Added !!! ");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
            Console.WriteLine("Added !!!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    { 
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine(" done ");
        }

        public  void DoSomething2()
        {
            Console.WriteLine("done 2 ");
        }
    }
}