using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {//need a foreach loop to go through every item in the array
            foreach (var val in vals) 
            { 
                if (val == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sumOfOdds = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sumOfOdds += num;
                }
            }

            return sumOfOdds % 2 != 0;
           
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        { 
            var containsUpper = false;
            var containsLower = false;
            var containsNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    containsUpper = true;
                }

                if (char.IsLower(c))
                {
                    containsLower = true;
                }

                if (char.IsDigit(c))
                {
                    containsNumber = true;
                }
            }

            return containsUpper && containsLower && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {//name of the string at index [0] returns that index which is the first letter
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {//new to c# ^ the arrow head allows you go backwards in the array and youll put the the number of how many indexes from the last you want to
         // list ex. ^1 places the last index
            return val[^1];
        // or 
        // return val[val.length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("cannot divide by zero");
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0]; //  nums[^1] returns the last interger in the array
        }

        public int[] GetOddsBelow100(int[] numbers )
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
                
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
             
        }
    }
}
