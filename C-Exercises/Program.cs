using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program 
{
    static void Main(string[] args) 
    {

        //Create C# console application. Create a class named "Employee" with properties such as name,
        //employee ID, and salary. Implement methods to calculate the yearly salary of an
        //employee based on their monthly salary.
       


        string filePath = @"C:\demo\test1.txt"; // // Read names from the file and store in an array

        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath).ToList();

        foreach (string line in lines) 
        {
            Console.WriteLine(line.ToUpper());
        }

        string outputPath = @"C:\demo\test2.txt";
        File.WriteAllLines(outputPath, lines);

        Console.ReadLine();
    }

   

}