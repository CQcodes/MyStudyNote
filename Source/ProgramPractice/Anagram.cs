using System;
using System.Collections.Generic;

namespace ProgramPractice
{
    public class Anagram
    {
        private int SumAsciiValues(string word)
        {
            int asciiSum = 0;
            foreach(char c in word.ToCharArray())
            {
                asciiSum += c;
            }
            return asciiSum;
        }

        public void FindAnagrams(string[] words)
        {
            Dictionary<int,List<string>> wordValues = new Dictionary<int, List<string>>();
            foreach(string word in words)
            {
                int asciiValue = SumAsciiValues(word);
                if (wordValues.ContainsKey(asciiValue))
                {
                    List<string> anagrams = wordValues[asciiValue];
                    anagrams.Add(word);
                    wordValues[asciiValue] = anagrams;
                }
                else
                {
                    wordValues.Add(asciiValue, new List<string>() { word });
                }
            }

            foreach(KeyValuePair<int,List<string>> pair in wordValues )
            {
                string longString = string.Empty;
                foreach (string word in pair.Value)
                {                    
                    longString = longString + word + ",";
                }
                Console.WriteLine(longString.TrimEnd(new char[] { ','}));
                Console.WriteLine("\n");
            }
        }

        public void Execute()
        {
            string[] words = { "sink", "skin", "top", "pot", "sit" };
            Anagram anagram = new Anagram();
            anagram.FindAnagrams(words);
            Console.ReadLine();
        }
    }
}
