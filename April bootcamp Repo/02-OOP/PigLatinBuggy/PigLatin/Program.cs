using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            PigTranslator translator = new PigTranslator();
            string userInput = translator.GetInput("Please input a word or sentence to translate to pig Latin");
            string translation = translator.ToPigLatin(userInput);
            Console.WriteLine(translation);
        }
    }
}
