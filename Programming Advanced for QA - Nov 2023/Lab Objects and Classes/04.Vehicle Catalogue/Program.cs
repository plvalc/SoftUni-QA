namespace _04.Vehicle_Catalogue
{
    public class Truck
    {
        public string Brand { get; set; }
        public string Model {  get; set; }
        public int Weight { get; set; }

    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set;}
        public List<Truck> Trucks { get; set;}
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalog = new Catalog();
            while(command != "end")
            {
                string[] currentCommand = command.Split("/");
                //"{type}/{brand}/{model}/{horse power / weight}"
                string type = currentCommand[0];
                string brand = currentCommand[1];
                string model = currentCommand[2];
                if (type == "Car")
                {
                    int horsePower = int.Parse(currentCommand[3]);

                    Car currentCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower,
                    };

                    catalog.Cars.Add(currentCar);
                }
                else if(type == "Truck")
                {
                    int weight = int.Parse(currentCommand[3]);

                    Truck currentTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight,
                    };

                    catalog.Trucks.Add(currentTruck);
                }


                command = Console.ReadLine();
            }

            catalog.Trucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();
            catalog.Cars = catalog.Cars.OrderBy(t => t.Brand).ToList();

            Console.WriteLine($"Cars:");
            foreach(Car car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine($"Trucks:");
            foreach (Truck truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }
}