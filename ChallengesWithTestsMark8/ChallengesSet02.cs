using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {


        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }


            
        public bool CountOfElementsIsEven(string[] vals)
        {
            int length = vals.Length;
            return length % 2 == 0;
        }



        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }


            
        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }


           
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
            if (numbers == null) 
            {
                return 0;
            }
            if (numbers.Count() == 0)
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
            return str1.Length;
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
            var sumEvens = numbers.Where(x => (x % 2) == 0).Sum();
            return sumEvens;
        }



        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            return true;
        }



        public long CountOfPositiveOddsBelowNumber(long number)
        {
            
            List<long> odds = new List<long>();

            for (long i = number - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.Count();
        }
                    
            

















































    }
}
            
               
            

           
            
            


        
            
            
                
            
            





            

