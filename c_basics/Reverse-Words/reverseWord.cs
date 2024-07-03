using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics.Reverse_Words
{
    public class ReverseWord
    {
        public static string ReverseWords(string words)
        {

            string[] splitWord = words.Split(' ');
            string reversedString  = "";

            for (int i = splitWord.Length - 1; i >=0; i--)
            {
                reversedString = reversedString + splitWord[i] + " ";
            }

            return reversedString;
        }
    }
}
