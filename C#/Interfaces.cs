namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            PersonManager personManager = new PersonManager();

            Customer customer = new Customer();

            customer.FirstName = "Davut";
            customer.LastName = "Gunduz";
            customer.Id = 1;
            customer.PhoneNumber = 5061750951;
            customer.Address = "Hatay/Antakya";

            personManager.AddCustomer(customer);

            Student student = new();

            student.FirstName = "Davut";
            student.LastName = "Gunduz";
            student.Id = 1;
            student.PhoneNumber = 5061750951;
            student.Departmant = "Computer science";

            CustomerManager customerManager = new CustomerManager();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            SqlServerCustomerDal sqlCustomerDal = new SqlServerCustomerDal();

            customerManager.Add(oracleCustomerDal);

            customerManager.Delete(sqlCustomerDal);

            ICustomerDal[]  customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Update();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; set; }
        long PhoneNumber { get; set; }
    }

    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added !!! ");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted !!! ");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Updated !!! ");
        }
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added !!! ");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted !!! ");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated !!! ");
        }
    }

    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Server Added !!! ");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Server Deleted !!! ");
        }

        public void Update()
        {
            Console.WriteLine("MySql Server Updated !!! ");
        }
    }

    interface IWorker
    {
        void Eat();
        void GetSalary();
        void Work();
    }

    class Workers : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Managers : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class CustomerManager 
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete(); 
        }

        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }

    class Customer : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Departmant { get; set; }
    }

    class Manager : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void AddCustomer (Customer customer)
        {
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.PhoneNumber);
            Console.WriteLine(customer.Address);
        }

        public void AddStudent (Student student)
        {
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.PhoneNumber);
            Console.WriteLine(student.Departmant);
        }

        public void UpdateCustomer(IPerson person)
        {
            person.FirstName = "Mecit";
            person.LastName = "Gunduz";
            person.Id = 1;
            person.PhoneNumber = 5079675636;
        }

        public void UpdateStudent(IPerson person)
        {
            person.FirstName = "Mecit";
            person.LastName = "Gunduz";
            person.Id = 1;
            person.PhoneNumber = 5079675636;
        }

        public void DeleteCustomer(IPerson person)
        {
            person.FirstName = " ";
            person.LastName = " ";
            person.Id = 0;
            person.PhoneNumber = 0;
        }

        public void DeleteStudent(IPerson person)
        {
            person.FirstName = " ";
            person.LastName = " ";
            person.Id = 0;
            person.PhoneNumber = 0;
        }
    }
}