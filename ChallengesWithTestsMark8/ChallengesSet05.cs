using System;
using System.Collections.Generic;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
             List<int> first = new List<int>();
            int maxLoop = startNumber * n;
            int[] numDivisibleByN = new int[0];

            for (int i = 0; i < maxLoop; i++)
            {
                if (i > startNumber && 1 % n == 0)
                {
                    first.Add(i);
                }
            }
            first.ToArray();
            return first[0];
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i -1] % 2 == 0)
                {
                    sum += numbers[i];
                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            int badwords = 0;
            int goodwords = 0;
            List<string> wordlist = new List<string> ();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  " )
                {
                    badwords += 1;
                }
                else 
                {
                    wordlist.Add(words[i].Trim());
                    goodwords += 1;
                }
            }
            if (goodwords == 0)
            {
                return "";

            }
            else 
            {
                return String.Join(" ", wordlist) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double> ();

            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i+1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
