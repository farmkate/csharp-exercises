using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sittign my her sister on the bank, an dof having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?";
            string lowerSentence = sentence.ToLower();
            string wordsToSearch;
            bool wordsFound;

            Console.WriteLine("Enter a phrase to search for in the given sentence:");
            wordsToSearch = Console.ReadLine();

            wordsFound = lowerSentence.Contains(wordsToSearch);

            Console.WriteLine("Is '" + wordsToSearch + "' found in our sample sentence? " + wordsFound);
            Console.ReadLine();
        }
    }
}
