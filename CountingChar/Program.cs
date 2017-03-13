using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingChar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, Int32> charDict = new Dictionary<char, Int32>();
            char[] charCount = sentence.ToLower().ToCharArray();

            foreach (char c in charCount)
            {
                //if (char.isal() )
                if (!charDict.ContainsKey(c))
                {
                    charDict.Add(c, 1);
                }
                else
                {
                     charDict[c]++;
                }
            }

            //foreach(var kv in charCount.OrderBy(c => charCount.Key)))
              //  { Console.WriteLine(kv.Key + " : " + kv.Value.ToString()}

            foreach (KeyValuePair<char, int> indChar in charDict)
            {
                Console.WriteLine(indChar.Key + ": " + indChar.Value);
            }
            Console.ReadLine();
        }
    }
}
