using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UsingNetFramework {
    class Program {

        static void Main(string[] args) {
            RandomNumbers();
            EnvironmentClass();
            Console.ReadKey();
        }

        static void RandomNumbers() {
            Random randomNumber = new Random();

            Console.WriteLine("randomNumber = {0}", randomNumber.Next());
            Console.WriteLine("randomNumber = {0}", randomNumber.Next());
            Console.WriteLine("randomNumber = {0}", randomNumber.Next());
            Console.WriteLine("randomNumber = {0}", randomNumber.Next(100));
            Console.WriteLine("randomNumber = {0}", randomNumber.Next(500, 750));

            Console.WriteLine("\n========== End RandomNumbers() ==========\n");
        }

        static void EnvironmentClass() {
            Console.WriteLine("Machine name: {0}", Environment.MachineName);
            Console.WriteLine("User name: {0}", Environment.UserName);
            Console.WriteLine("OS version: {0}", Environment.OSVersion);
            Console.WriteLine("Current directory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("CLR version: {0}", Environment.Version);
            Console.WriteLine();

            FileInfo someFile = new FileInfo(@"c:\test.txt");
            someFile.CopyTo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\test.txt");

            Console.WriteLine("Has text.txt been copied to the Desktop?");
            Console.WriteLine("\n========== End EnvironmentClass() ==========\n");
        }

        static void WriteAndReadXML() {
            
        }
    }
}
