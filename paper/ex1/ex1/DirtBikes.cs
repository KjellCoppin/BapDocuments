namespace ex1
{
    using System;

    // Builder Interface
    public interface IMotorcycleBuilder
    {
        IMotorcycleBuilder SetEngine();
        IMotorcycleBuilder SetWheels();
        IMotorcycleBuilder SetHorn();
        Motorcycle Build();
    }

    // Concrete Builder for DirtBike
    public class DirtBikeBuilder : IMotorcycleBuilder
    {
        private Motorcycle _motorcycle = new Motorcycle();

        public IMotorcycleBuilder SetEngine()
        {
            _motorcycle.Engine = "single";
            return this;
        }
        public IMotorcycleBuilder SetWheels()
        {
            _motorcycle.Wheels = 2;
            return this;
        }
        public IMotorcycleBuilder SetHorn()
        {
            _motorcycle.Horn = "tuut";
            return this;
        }
        public Motorcycle Build()
        {
            return _motorcycle;
        }
    }

    // Concrete Builder for SportsBike
    public class SportsBikeBuilder : IMotorcycleBuilder
    {
        private Motorcycle _motorcycle = new Motorcycle();

        public IMotorcycleBuilder SetEngine()
        {
            _motorcycle.Engine = "inline-4";
            return this;
        }
        public IMotorcycleBuilder SetWheels()
        {
            _motorcycle.Wheels = 2;
            return this;
        }
        public IMotorcycleBuilder SetHorn()
        {
            _motorcycle.Horn = "bip";
            return this;
        }
        public Motorcycle Build()
        {
            return _motorcycle;
        }
    }


    // Motorcycle Class
    public class Motorcycle
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public string Horn { get; set; }   
    }

    // Usage
    class Program
    {
        static void Main(string[] args)
        {
            IMotorcycleBuilder dirtBikeBuilder = new DirtBikeBuilder();
            Motorcycle dirtbike = dirtBikeBuilder
                .SetEngine()
                .SetWheels()
                .SetHorn()
                .Build();

        }
    }

}
