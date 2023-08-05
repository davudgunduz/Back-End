using System;
namespace Classes
{
    class Program
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();

            ProductManager productManager = new ProductManager();

            productManager.Add();
            productManager.Update();
            productManager.Update();

            Customer customer = new Customer();

            customer.FirstName = "Davut";
            customer.LastName = "Gunduz";
            customer.Id = 1;
            customer.PhoneNumber = 5061750951;
            customer.City = "Hatay";

            Customer customer2 = new Customer
            {
                FirstName = "Mecit", LastName = "Gunduz" , Id = 2, PhoneNumber = 5313050877, City = "Adana"
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.PhoneNumber);
            Console.WriteLine(customer.City);


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added !!!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated !!!");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted !!!");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added !!!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated !!!");
        }

        public void Delete()
        {
            Console.WriteLine("Product Deleted !!!");
        }
    }

    class Customer
    {
        // Field
        // private string _firstName;

        //public string FirstName
        //{
        //    get
        //    {
        //        return "Mr."+_firstName;
        //    }
        //    set
        //    {
        //        _firstName = value;
        //    }
        //}

        public string FirstName { get; set; }

        // Property
        public int Id { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }

    }
}