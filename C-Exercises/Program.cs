using System;
using System.IO;


class Program 
{
    static void Main(string[] args) 
    {
        string readFilePath = @"C:\Users\s2200072\Downloads\ornek.txt";
        string writeFilePath = @"C:\Users\s2200072\Downloads\ornek2.txt";
        string[] dataArray = File.ReadAllLines(readFilePath);

        Console.WriteLine("Read of the Data : ");
        using(StreamWriter writer = new StreamWriter(writeFilePath))
        {
            foreach (string data in dataArray) 
            {
                string upperCaseData = data.ToUpper();
                Console.WriteLine(upperCaseData);
                writer.WriteLine(upperCaseData);

            
            }
        }

        Console.WriteLine("The program has ended. Press any key to exit.");
        Console.ReadLine();
    }

   

}