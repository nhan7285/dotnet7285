using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebugSample
{
    class DebugSample
    {
        static void Main(string[] args)
        {
            int agevalue;

            try
            {
                // Ask for the user's age:
                Console.Write("Enter your age:");
                agevalue = Convert.ToInt32(Console.ReadLine());

                //Display the conert statement based on the results
                if (agevalue >= 13 && agevalue < 20)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are a real person.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
