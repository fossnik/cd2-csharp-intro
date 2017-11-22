using System;
using System.Collections.Generic;

namespace CSharpFundamentals64
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "This is a really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}