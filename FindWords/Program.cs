using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int wordLength = 5;
            List<string> wordList = new List<string>(){"boats","flower",  "dog", "cat", "house", "truck", "earth"};

            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Length == wordLength)
                {
                    Console.WriteLine(wordList[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
