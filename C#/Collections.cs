using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main()
        {
            ArryList();
            Listt();
            Dictionry();

            Console.ReadLine();
        }

        private static void Listt()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("Adiyaman");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Davut", LastName = "Gunduz", PhoneNumber = 5000000000 });
            //customers.Add(new Customer { Id = 2, FirstName = "Mecit", LastName = "Gunduz", PhoneNumber = 5000000000 });
            //customers.Add(new Customer { Id = 3, FirstName = "Selim Sabahattin", LastName = "Gunduz", PhoneNumber = 5000000000 });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Davut", LastName = "Gunduz", PhoneNumber = 5000000000 },
                new Customer { Id = 2, FirstName = "Mecit", LastName = "Gunduz", PhoneNumber = 5000000000 },
                new Customer { Id = 3, FirstName = "Selim", LastName = "Gunduz", PhoneNumber = 5000000000 },
                new Customer { Id = 4, FirstName = "Husam", LastName = "Gunduzoglu", PhoneNumber = 5000000000 },
                new Customer { Id = 5, FirstName = "Turhan", LastName = "Gunduzoglu", PhoneNumber = 5000000000 },
                new Customer { Id = 6, FirstName = "Sahut", LastName = "Gunduzoglu", PhoneNumber = 5000000000 }
            };


            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer.Id);
            //    Console.WriteLine(customer.FirstName);
            //    Console.WriteLine(customer.LastName);
            //    Console.WriteLine(customer.PhoneNumber);
            //    Console.WriteLine();
            //}

            ListMethods(customers);

            //customers.Clear();
            //Console.WriteLine(count);

        }

        private static void ListMethods(List<Customer> customers)
        {
            var count = customers.Count;
            Console.WriteLine(count);

            var customer = new Customer
            {
                Id = 7,
                FirstName = "Engin",
                LastName = "Demirog",
                PhoneNumber = 5000000000
            };

            customers.Add(customer);

            List<Customer> customers2 = new List<Customer>
            {
                new Customer { Id = 8, FirstName = "Abdullah", LastName = "Gunduz", PhoneNumber = 5000000000 },
                new Customer { Id = 9, FirstName = "Turhan", LastName = "Gunduz", PhoneNumber = 5000000000 },
                new Customer { Id = 10, FirstName = "Mehmet", LastName = "Gunduz", PhoneNumber = 5000000000 }
            };

            customers.AddRange(customers2);
            customers.AddRange(new Customer[]
            {
                new Customer(),
                new Customer()
            });

            Console.WriteLine(customers.Contains(customer));

            //var index = customers.IndexOf(customer);
            //Console.WriteLine(index);

            customers.Add(customer);

            var index = customers.IndexOf(customer);
            Console.WriteLine(index);

            var lastIndex = customers.LastIndexOf(customer);
            Console.WriteLine(lastIndex);

            customers.Insert(0, customer);

            customers.Remove(customer);

            // c=>c.FirstName == "Davut" 
            customers.RemoveAll(c=> c.FirstName == "Davut");


            foreach (var customer1 in customers)
            {
                Console.WriteLine(customer1.Id);
                Console.WriteLine(customer1.FirstName);
                Console.WriteLine(customer1.LastName);
                Console.WriteLine(customer1.PhoneNumber);
                Console.WriteLine();
            }
        }

        private static void ArryList()
        {
            ArrayList cities = new()
            {
                "Ankara",
                "Adana",
                "Adiyaman",
                1,
                true,
                'a',
                3.34
            };

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

        }

        private static void Dictionry()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("Book", "Kitap");
            keyValuePairs.Add("Computer", "Bilgisayar");
            keyValuePairs.Add("Phone", "Telefon");
            keyValuePairs.Add("Pencil", "Kalem");
            keyValuePairs.Add("Mouse", "Fare");
            keyValuePairs.Add("Keyboard", "Klavye");
            keyValuePairs.Add("Table", "Tablo");

            // Console.WriteLine(keyValuePairs["Table"]);

            foreach(var item in keyValuePairs)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }

        } 
    }

    internal class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
    }
}