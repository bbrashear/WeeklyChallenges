using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    total += num;
                }
                else
                {
                    total -= num;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> words = new List<string>() { str1, str2, str3, str4 };
            List<int> wordLength = new List<int>();
            foreach(var word in words)
            {
                wordLength.Add(word.Length);
            }
            return wordLength.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>() { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 < sideLength2 + sideLength3 && sideLength2 < sideLength1 + sideLength3 && sideLength3 < sideLength1 + sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            double number;
            if(!double.TryParse(input, out number))
            {
                return false;
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> nullObjects = new List<object>();
            List<object> notNullObjects = new List<object>();
            foreach(object o in objs)
            {
                if(o == null)
                {
                    nullObjects.Add(o);
                }
                else
                {
                    notNullObjects.Add(o);
                }
            }
            return nullObjects.Count > notNullObjects.Count;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            double sum = 0;
            List<int> evenInts = new List<int>();
            foreach(int i in numbers)
            {
                if(i % 2 == 0)
                {
                    evenInts.Add(i);
                }
            }
            foreach(int a in evenInts)
            {
                sum += a;
            }
            if(evenInts.Count == 0 || sum == 0)
            {
                return 0;
            }
            return sum / evenInts.Count;
        }

        public int Factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i = number - 1; i > 0; i-- )
            {
                number *= i;
            }
            return number;
        }
    }
}
