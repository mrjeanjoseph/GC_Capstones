using System;
using System.Collections.Generic;
using System.Text;

namespace Used_Car_Lot
{
    class CarLot
    {
        private List<Car> _cars = new List<Car>
        {
            new Car("Nikolai", "Model S", 2017, 54999.90M),
            new Car("Fourd", "Escapade", 2017, 31999.90M),
            new Car("Chewie", "Vette", 2017, 44989.95M),
            new UsedCar("Hyonda", "Prior", 2015, 14795.50M,35987.6),
            new UsedCar("GC", "Chirpus", 2013, 8500.00M, 12345.0),
            new UsedCar("GC", "Witherell", 2016, 14450.00M, 3500.3)
        };
        //property
        public List<Car> Cars
        {
            get { return this._cars; }
            set { this._cars = value; }
        }

        //constructor
        public CarLot()
        {

        }
        //methods
        //displays all cars and all menu options
        public void ListCars()
        {
            int counter = 1;
            foreach(Car car in this._cars)
            {
                Console.WriteLine($"{counter}. {car.ToString()}");
                counter++;
            }
            Console.WriteLine($"{counter}. Add a car");
            counter++;
            Console.WriteLine($"{counter}. Quit");
        }

        public void AddCar(Car newCar)
        {
            this._cars.Add(newCar);
            Console.WriteLine("Thank you for the new vehicle. It will be displayed asap");
        }

        public void RemoveCar(int carNum)
        { 
            carNum--;//this will set it to the index
            Console.WriteLine(this._cars[carNum].ToString());
            Console.WriteLine("Is this the car you want to buy? y/n");
            string choice = "";
            while(true)
            {
                choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    this._cars.RemoveAt(carNum);
                    Console.WriteLine("Thank you for purchasing a car. You will be billed shortly.");
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Ok, we will put it back.");
                    break;
                }
                else
                {
                    Console.WriteLine("That was not an option");
                }
            }
        }
    }
}
