using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();



        }



        //------------------------------------------------------------------------------//




        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }



        //-----------------------------------------------------------------------//
              



        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var newString = string.Join(" ", words);
            return newString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
