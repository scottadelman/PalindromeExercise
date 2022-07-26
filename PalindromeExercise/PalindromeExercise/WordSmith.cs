using System;
using System.Collections.Generic;
using System.Text;
using PalindromeExercise;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string word)
        {
           return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}
