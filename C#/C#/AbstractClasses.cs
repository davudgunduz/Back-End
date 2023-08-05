namespace AbstractClasses
{
    class Program
    {
        static void Main ()
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            sqlServer.Update();

            Oracle oracle = new Oracle();
            oracle.Add();
            oracle.Update();
            oracle.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default ");
        }

        public abstract void Delete();

        public abstract void Update();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer ");
        }

        public override void Update()
        {
            Console.WriteLine("Updated by SqlServer ");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle ");
        }

        public override void Update()
        {
            Console.WriteLine("Updated by Oracle ");
        }
    }

}