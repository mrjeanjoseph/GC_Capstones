using System;

namespace Mock_Assessment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town();

            Console.WriteLine(town.Harvest());
            Console.WriteLine(town.CalcFoodConsumption());
            Console.WriteLine(town.SurviveTheWinter());
        }
    }
}
