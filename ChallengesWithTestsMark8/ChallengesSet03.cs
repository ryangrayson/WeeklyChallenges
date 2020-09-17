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

            // var cont = vals.Where(x => x.Equals(false));
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
            password.Where(char.IsUpper).Where(char.IsLower).Where(char.IsDigit);
            //for (var i = 0; i < password.Length; i++)
            //{
            //    if ()
            //    {

            //    }
            //}

            //password
            throw new NotImplementedException();

        }

        public char GetFirstLetterOfString(string val)
        {
           var vals = val.ToArray();
           return vals[0];
        }
                   

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }




        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
