using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFrequencyValue
{
    internal class Program
    {
        static void Main()
        {

            // 3.Enhance the 2.application to read data from  the file and store it in a Dictionary with the 
            // names as keys and their frequency as values.Print the contents of  the dictionary to the console.

            // Define file path

            string filPath = @"C:\demo1\names.txt";

            // Next, we create a dictionary. This dictionary will keep each word as
            // key and the number of that word as value.

            Dictionary<string, int> frequentlyDictionary = new Dictionary<string, int>();

            // Next, we read the data in the file and put the words into an array.
            // Words are separated by space character.

            string[]nams = File.ReadAllText(filPath).Split(' ');

            // Next, we look up each word in the dictionary.
            // If there is a word in the dictionary,
            // we increase its number by one.
            // If it is not in the dictionary, we add it as a new key-value pair.


            foreach (string name in nams) 
            {
                if (frequentlyDictionary.ContainsKey(name)) 
                {
                    frequentlyDictionary[name] ++;
                }
                else 
                {
                    frequentlyDictionary.Add(name, 1);
                }


            }
            foreach(var item in frequentlyDictionary) 
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
                
            }
            Console.ReadLine();




        }
    }
}
