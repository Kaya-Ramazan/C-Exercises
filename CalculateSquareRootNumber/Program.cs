using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquareRootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a console application that prompts the user for a number and calculates the square root of the number.
            // Use a try-catch block to catch exceptions that might occur
            // when the user enters invalid data (such as a negative number).
            // In the catch block, display a custom error message to the user and ask them to enter a new number...

            try
            {
                double number;

                Console.Write(" Enter a number : ");
                number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Your number´s square is : " + Math.Sqrt(number));
                Console.ReadLine();

            }
            
            catch(OverflowException) 
            {
                Console.WriteLine("You have exceeded the limits for Int32 !!! ");
            }
            catch(FormatException) 
            {
                Console.WriteLine(" You entered an invalid value. please try again : .");
            }
            catch (ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine(" Error !!!");
            }
            Console.ReadLine();
        }
    }
}
