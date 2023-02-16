using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (char item in alphabet)
            {

                if (item == Char.ToLower(c))
                {
                    return true;
                }
            }
            return false;

            //OR
            // Return Char.IsLetter(c);

            //OR
            //if(Char.IsLetter(c))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //OR
            //int count = 0;
            //for (int i = 0; i < vals.Length; i++)    
            //{
            //    count++;
            //    if (count % 2 == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }

        }


        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Sum() % 2 == 0)
            {
                return numbers.Sum();
            }
            return 0;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers == null) 
            {
                return false;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (int n = 0; n < number; n++)
            {
                if (n % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
