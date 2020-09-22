using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                foreach (var item in vals)
                {
                    if (item == false)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

           

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sumOdds = numbers.Where(x => (x % 2) != 0).Sum();
            if (sumOdds % 2 == 0)
            {
                return false;
            }
            return true;
        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }





        public char GetFirstLetterOfString(string val)
        {
           var vals = val.ToArray();
           return vals[0];
        }


        public char GetLastLetterOfString(string val)
        {
            char vals = val.Last();
            return vals;
        }
            
            
           


        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }



        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }



        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
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
