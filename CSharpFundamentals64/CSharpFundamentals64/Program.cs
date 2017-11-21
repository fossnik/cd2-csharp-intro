using System;
using System.Collections.Generic;

namespace CSharpFundamentals64
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "This is a really really really really really long text.";
            var summary = SummerizeText(sentence);
            Console.WriteLine(summary);
        }

        static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}