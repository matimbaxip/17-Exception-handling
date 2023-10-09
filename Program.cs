using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ReadLine();
            }

        }
    }   
}
