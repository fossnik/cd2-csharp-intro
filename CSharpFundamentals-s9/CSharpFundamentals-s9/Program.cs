using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentals_s9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var path = "/home/seth/careerDevs-i/RiderProjects/CSharpFundamentals/HelloWorld/HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension     \t" + Path.GetExtension(path));
            Console.WriteLine("File Name     \t" + Path.GetFileName(path));
            Console.WriteLine("Sans Extension\t" + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name\t" + Path.GetDirectoryName(path));
        }
    }
}