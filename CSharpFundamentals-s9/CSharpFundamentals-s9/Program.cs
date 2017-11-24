using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentals_s9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string literal is in this instance superflous
            Directory.CreateDirectory(@"/tmp/folder1");

            var files = Directory.GetFiles(@"/home/seth/careerDevs-i/RiderProjects/CSharpFundamentals/");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}