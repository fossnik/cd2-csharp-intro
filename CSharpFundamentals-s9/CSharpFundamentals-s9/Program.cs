using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentals_s9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myDirectory = "/tmp/folder1";
            
            // string literal is in this instance superflous
            Directory.CreateDirectory(myDirectory);

            var directories = Directory.GetDirectories(@"/home/seth/careerDevs-i/RiderProjects/CSharpFundamentals/",
                "*.*",
                SearchOption.AllDirectories);
            
            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }

            if (!Directory.Exists(myDirectory))
            {
                Console.WriteLine("{0} is not found (invalid directory)", myDirectory);
            }
            else
            {
                Console.WriteLine("{0} detected!", myDirectory);
            }
        }
    }
}