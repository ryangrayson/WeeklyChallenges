using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            
            var odds = new List<int>();
            var evens = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odds.Add(numbers[i]);
                }
                else if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            return odds.Sum() * (-1) + evens.Sum();
        }




        //---------------------------------------------------------------------//




        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new string[] { str1, str2, str3, str4 };
            var shortestString = strings.OrderBy(x => x.Length).FirstOrDefault();
            return shortestString.Length;
        }



        //---------------------------------------------------------------------//



        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int [] array = new int[] { number1, number2, number3, number4 };
            return array.Min();
        }



        //---------------------------------------------------------------------//



        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();

        }


        //---------------------------------------------------------------------//


        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 || sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            return true;
        }


        //---------------------------------------------------------------------//



        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }



        //---------------------------------------------------------------------//



        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullz = new List<object>();
            var notNullz = new List<object>();

            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullz.Add(item);
                }
                else if (item != null)
                {
                    notNullz.Add(item);
                }
            }

            if (nullz.Count > notNullz.Count)
            {
                return true;
            }
            return false;
        }



        //---------------------------------------------------------------------//



        public double AverageEvens(int[] numbers)
        {
            var evens = new List<int>();

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            if (evens.Count == 0)
            {
                return 0;
            }
            return evens.Average();
        }



        //---------------------------------------------------------------------//



        public int Factorial(int number)
        {
            int res = 1;
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            while (number != 1)
            {
                res = res * number;
                number = number - 1;
            }
            return res;
        }



    }
}
