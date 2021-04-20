using System;
using System.Collections.Generic;

namespace VehiclesInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> garage = new List<Vehicle>
            {
                new Bike("Kids bike", 2, 15, true),
                new Car("Ford",4,90,4,4,6),
                new Truck("Cybertruck",4,140,2,2,6,500),
                new Skateboard("Golden Board", 4, 5, "Real Gold")
            };

            Console.WriteLine($"Welcome to my fancy Garage. I have {garage.Count} vehicles.");
            Console.WriteLine("These are the names of the vehicles.");

            foreach(Vehicle vehicle in garage)
            {
                Console.WriteLine(vehicle.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Lets go and drive in each of my vehicles. (enter to continue)");
            Console.ReadLine();
            Console.Clear();

            foreach(Vehicle vehicle in garage)
            {
                Console.WriteLine($"You walk up to {vehicle.Name}");

                vehicle.Drive();
                vehicle.Stop();
                Console.WriteLine();
                Console.WriteLine("Lets get in my next vehicle. (enter to continue)");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Those were all of my vehicles. I hope you enjoyed them.");

        }
        static void testCars()
        {
            Vehicle vehicle = new Vehicle("Basic", 4, 20);//Parent
            vehicle.Drive();
            vehicle.Stop();
            string result = vehicle.ToString();
            Console.WriteLine(result);

            Console.WriteLine();

            //Child of vehicle
            //car
            Car car = new Car("Ford", 4, 80, 4, 4, 6);
            car.Drive();
            car.Stop();
            string carResult = car.ToString();
            Console.WriteLine(carResult);

            Console.WriteLine();

            //bike
            Bike bike = new Bike("Kids Bike", 2, 15, true);
            bike.Drive();
            bike.Stop();
            string bikeResult = bike.ToString();
            Console.WriteLine(bikeResult);

            Console.WriteLine();

            //truck
            Truck truck = new Truck("Cybertruck", 4, 140, 2, 2, 6, 500);
            truck.CarrySupplies(538);
            truck.Drive();
            truck.Stop();
            string truckResult = truck.ToString();
            Console.WriteLine(truckResult);
        }
    }
}
