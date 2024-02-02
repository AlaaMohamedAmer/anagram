using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution s1 = new solution();

            Console.WriteLine(s1.IsAnagram("anagram", "nagaram"));
            Console.WriteLine(s1.IsAnagram("rat", "car"));
            Console.ReadKey();
        }
    }
    public class solution
    {
        public bool IsAnagram (string word1 , string word2 )
        {
            char[] arr = word1.ToCharArray();
            Array.Sort(arr);
            string result1 = new string(arr);

            char[] arr2 = word2.ToCharArray();
            Array.Sort(arr2);
            string result2 = new string(arr2);

            if (result1 == result2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
