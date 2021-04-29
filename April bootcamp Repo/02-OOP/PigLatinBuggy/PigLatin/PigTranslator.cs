using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigLatin
{
    class PigTranslator
    {
        public PigTranslator()
        {

        }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }

        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //vowels.ToString does not == a single char
            return vowels.Contains(c);
        }

        public string ToPigLatin(string word)
        {
            word = word.ToLower();
            string[] words = word.Split(" ");
            string result = "";

            //had to create loop for sentences
            foreach (string singleWord in words)
            {
                char[] specialChars = { '@', '.', '-', '$', '^', '&' };
                bool containsSpecial = false;

                foreach (char w in singleWord)
                {
                    if (specialChars.Contains(w))//used contains to lower the amount of loops
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        containsSpecial = true;
                        break;
                    }
                }

                if (containsSpecial == true)//if a special character is found, we loop to next word
                {
                    result += singleWord + " ";
                    continue;
                }


                bool noVowels = true;
                foreach (char letter in singleWord)
                {
                    if (IsVowel(letter))
                    {
                        noVowels = false;
                    }
                }

                if (noVowels)
                {
                    result += singleWord + " ";
                    continue;
                }

                char firstLetter = singleWord[0];
                string output = "placeholder";
                if (IsVowel(firstLetter) == true)
                {
                    //had ay instead of way
                    output = singleWord + "way";
                }
                else
                {
                    int vowelIndex = -1;
                    //Handle going through all the consonants
                    for (int i = 0; i <= singleWord.Length; i++)
                    {
                        if (IsVowel(singleWord[i]) == true)
                        {
                            vowelIndex = i;
                            break;
                        }
                    }

                    //removed the + and - from the indexes
                    string sub = singleWord.Substring(vowelIndex);
                    string postFix = singleWord.Substring(0, vowelIndex);
                    output = sub + postFix + "ay";
                }

                result += output + " ";
                continue;
            }

            return result;
        }
    }
}
