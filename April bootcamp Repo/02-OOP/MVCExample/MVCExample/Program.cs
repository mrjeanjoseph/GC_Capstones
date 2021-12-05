using System;

namespace MVCExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonController pController = new PersonController();
            pController.DisplayPerson("Justin");
            pController.DisplayAll();
            Console.WriteLine();

            pController.AddPerson("Jeff", 25);
            pController.DisplayAll();
            Console.WriteLine();

            pController.EditPerson("Justin", "Bustin", 10000);
            pController.DisplayPerson("Bustin");
            Console.WriteLine();
            pController.DisplayAll();
            Console.WriteLine();


            pController.DeletePerson("Bustin");
            pController.DisplayAll();
            Console.WriteLine();

            pController.AddStudent("Sabrina", 17, 12);
            pController.DisplayPerson("Sabrina");
        }
    }
}
