using System;

namespace Inheritance
{
    class Program 
    {
        static void Main()
        {
            Person[] person = new Person[3]
            {
                new Person
                {
                    FirstName = "Suleyman",
                    LastName = "Gunduz",
                    Id = 1 
                },
                new Customer
                {
                    FirstName = "Selim",
                    LastName = "Gunduz",
                    Id = 1,
                    City = "Hatay"
                },
                new Student
                {
                    FirstName = "Davut",
                    LastName = "Gunduz",
                    Id = 1 ,
                    Department = "Computer Science"
                }
            };

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Update();
           
            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }

            public virtual void Update()
            {
                Console.WriteLine("Updated by default");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by SqlServer");
            }

            public override void Delete()
            {
                Console.WriteLine("Deleted by SqlServer");
            }

            public override void Update()
            {
                Console.WriteLine("Update by SqlServer");
            }
        }

        class MySql : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by MySqlServer");
            }

            public override void Delete()
            {
                Console.WriteLine("Deleted by MySqlServer");
            }

            public override void Update()
            {
                Console.WriteLine("Update by MySqlServer");
            }
        }
       
    }
}