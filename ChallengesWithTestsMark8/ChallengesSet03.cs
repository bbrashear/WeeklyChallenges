using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;
            foreach(bool val in vals)
            {
                if(val == false)
                {
                    return containsFalse = true;
                }
            }
            return containsFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            var oddNums = new List<int>();
            if(numbers == null)
            {
                return false;
            }
            for(int i = 0; i < numbers.Count(); i++)
            {
                if(numbers.ElementAt(i) % 2 != 0)
                {
                    oddNums.Add(numbers.ElementAt(i));
                }
            }
            foreach(var oddNum in oddNums)
            {
                sum += oddNum;
            }

            return sum % 2 != 0 ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool passContains = false;
            if(password.Any(char.IsUpper) &&
                password.Any(char.IsLower) &&
                password.Any(char.IsNumber))
            {
                passContains = true;
            }
            return passContains;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor != 0 ? dividend / divisor : 0;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
