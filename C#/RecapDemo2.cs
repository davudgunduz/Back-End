namespace RecapDemo
{
    class Program
    {
       static void Main()
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            //customerManager.logger = new DatabaseLogger();
            FileLogger fileLogger = new FileLogger();
            SmsLogger smsLogger = new SmsLogger();
            //customerManager.logger = fileLogger;
            customerManager.logger = smsLogger;
            
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add()
        {
            
            logger.Log();
            Console.WriteLine("Customer Added !!! ");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database !!! ");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File !!! ");
        }
    }


    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS !!! ");
        }
    }

    interface ILogger
    {
        void Log();
    }
}