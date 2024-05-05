namespace ex1
{
    public class proxy
    {
    }

    // Interface for the service
    public interface IDatabaseService
    {
        void WriteData(string data);
    }

    // Real service implementation
    public class DatabaseService : IDatabaseService
    {
        public void WriteData(string data)
        {
            // Complex logic to write data to the database
            Console.WriteLine($"Writing data: {data}");
        }
    }

    // Proxy class
    public class DatabaseProxy : IDatabaseService
    {
        private readonly IDatabaseService _realService;

        public DatabaseProxy(IDatabaseService realService)
        {
            _realService = realService;
        }

        public void WriteData(string data)
        {
            // Add pre-processing logic
            Console.WriteLine("Pre-processing data...");

            // Call the real service
            _realService.WriteData(data);

            // Add post-processing logic
            Console.WriteLine("Post-processing data...");
        }
    }

    public class Application
    {
        private readonly IDatabaseService _databaseService;

        public Application(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void ProcessData(string data)
        {
            _databaseService.WriteData(data);
        }
    }

}
