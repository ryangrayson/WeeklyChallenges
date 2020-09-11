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
            return numbers.Sum();
        }
            
            
             


        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
        







           





          
            





    }
}
            
               
            

           
            
            


        
            
            
                
            
            





            

