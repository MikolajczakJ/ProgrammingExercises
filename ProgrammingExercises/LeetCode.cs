using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    internal static class LeetCode
    {
        public static int RomanToInt(string romanVal)
        {
            int number = 0;
            Dictionary<char, int> RomanMap = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };
            for (int i = 0; i < romanVal.Length; i++)
            {
                if (i+1<romanVal.Length && RomanMap[romanVal[i]] < RomanMap[romanVal[i+1]])
                {
                    number -= RomanMap[romanVal[i]];
                }
                else
                {
                    number += RomanMap[romanVal[i]];
                }
            }
            return number;
        }
        public static string LongestPrefix(string[] words)
        {
            int shortest = words.Min(x => x.Length);
            bool breakFlag = false;
            while (shortest > 0)
            {
                for (int i = 0; i < words.Length-1; i++)
                {
                    if (words[i][..shortest] != words[i+1][..shortest])
                    {
                        breakFlag = true;
                        break;
                    }
                }
                if (breakFlag)
                {
                    shortest--;
                    breakFlag = false;
                }
                else return words[0][..shortest];
            }
            return string.Empty;
        }
        public static bool AreValidPharenteses(string s)
        {
            Stack<char> pharenteses = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '[' || c== '{')
                {
                    pharenteses.Push((char)(c + 2)); // dodaje do stacku ] lub }
                }
                else if (c == '(')
                {
                    pharenteses.Push((char)(c + 1)); // dodaje do stacku )
                }
                else
                {
                    if (pharenteses.Count==0||pharenteses.Pop()!= c )
                    {
                        return false;
                    }
                }
            }
            return pharenteses.Count==0;
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            if (nums.Length == 0)
            {
                return 0;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }
            return j + 1;
        }
    }
}
