using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Solving
{
    public class FindWordFrequency
    {
        public void Find(string text, string[] excludeWords)
        {
            if (String.IsNullOrEmpty(text)) return;
            
            var words = text.Split(' ');

            Dictionary<string, int> wordFrequeny = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (excludeWords != null && excludeWords.Length > 0 && excludeWords.Contains(word) || word.Trim().Length == 0)
                {
                    continue;
                }
                var key = word.Trim().ToLower(); // select word as a key

                if (!wordFrequeny.ContainsKey(key))
                {
                    wordFrequeny.Add(key, 1); // add in dictionary if it is not exist.
                }
                else
                {
                    wordFrequeny[key] = wordFrequeny[key] + 1; // key is absent , increase value 1
                }
            }
            foreach (var item in wordFrequeny)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
