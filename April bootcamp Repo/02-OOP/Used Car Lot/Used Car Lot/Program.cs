using System;

namespace Used_Car_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");

            while(true)
            {
                carLot.ListCars();
                Console.WriteLine();
                Console.WriteLine("Which car would you like?");
                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("That was not a number.");
                    continue;
                }
                //buy a car
                if(choice>=1 && choice <=carLot.Cars.Count)
                {
                    carLot.RemoveCar(choice);
                    Console.ReadLine();
                    Console.Clear();
                }
                //add a car
                else if (choice == carLot.Cars.Count + 1)
                {
                    Car car = CreateCar();
                    carLot.AddCar(car);
                    Console.ReadLine();
                    Console.Clear();
                }
                //quit
                else if (choice == carLot.Cars.Count +2)
                {
                    Console.Clear();
                    Console.WriteLine("Have a nice day!");
                    break;
                }
            }
        }

        static Car CreateCar()
        {
            string make = "";
            while (true)
            {
                Console.WriteLine("Please enter a make.");
                make = Console.ReadLine();
                if(make == "")
                {
                    Console.WriteLine("Cannot be empty");
                }
                else
                {
                    break;
                }
            }

            string model = "";
            while (true)
            {
                Console.WriteLine("Please enter a model");
                model = Console.ReadLine();
                if (model == "")
                {
                    Console.WriteLine("Cannot be empty");
                }
                else
                {
                    break;
                }
            }


            int year = 0;
            while(true)
            {
                Console.WriteLine("Please enter a year");
                try
                {
                    year = int.Parse(Console.ReadLine());
                    if (year<= 0)
                    {
                        Console.WriteLine("That is too old");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That was not a number");
                }
            }

            decimal price = 0M;
            while (true)
            {
                Console.WriteLine("Please enter a price");
                try
                {
                    price = decimal.Parse(Console.ReadLine());
                    if (price <= 0)
                    {
                        Console.WriteLine("That is too cheap.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That was not a number");
                }
            }

            //new or used
            Console.WriteLine("Is this new or used? new/used");
            bool isUsed = false;
            while(true)
            {
                string usedInput = Console.ReadLine().Trim().ToLower();
                if (usedInput =="new")
                {
                    isUsed = false;
                    break;
                }
                else if (usedInput == "used")
                {
                    isUsed = true;
                    break;
                }
                else
                {
                    Console.WriteLine("That was not an option.");
                }
            }


            //Create cars
            if(isUsed == false)//new cars
            {
                Car car = new Car(make, model, year, price);
                return car;
            }
            else //used
            {
                double mileage = 0;
                while (true)
                {
                    Console.WriteLine("Please enter a mileage");
                    try
                    {
                        mileage = double.Parse(Console.ReadLine());
                        if (mileage <= 0)
                        {
                            Console.WriteLine("That is too low.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("That was not a number");
                    }
                }

                UsedCar usedCar = new UsedCar(make, model, year, price, mileage);
                return usedCar;
            }
        }
    }
}
