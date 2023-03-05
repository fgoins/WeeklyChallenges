using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            //or
        //    int total = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 2 == 0)
        //        {
        //            total += numbers[i];
        //        }
        //        else 
        //        {
        //             total -= numbers[i];
        //        }
        //        return total;

        //    }
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string> {str1,str2, str3, str4 };
            return stringList.Min(x => x.Length); 
            //method returns shortest string from the collection.
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] {number1, number2, number3, number4};
            return array.Min();
            //does not need to pass in because they are int whole numbers 
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
            //uhhhhh....
        }

        public bool IsStringANumber(string input)
        {
            double n;
            bool isNumber = double.TryParse(input, out n);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            catch (ArgumentNullException)
            {

                return 0;
            }
            catch (InvalidOperationException) 
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 1 || number == 0)
            {
                return 1;
            }
            if(number >= 2) 
            {
                var fact = number * Factorial(number - 1);
                return fact;
            }
            return 0;
        }
    }
}
