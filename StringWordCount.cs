using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StringWordCount
    {

        public void countWords()
        {
            string sentence = "She sells sea shells on the sea shore";
            Console.WriteLine(sentence);

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            int wordCount = words.Length;

            Console.WriteLine("count of words: " + wordCount);

        }
    }
}