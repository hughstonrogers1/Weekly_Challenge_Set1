﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
            // done
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //return vals***
            int count = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                count++;
            }
            if (count % 2 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsNumberEven(int number)
        {
            //return number % 2 == 0;
            if (number % 2 == 0)
            {
                return true;                   
            }
            else
            {
                return false;
            }
            // done
        }

        public bool IsNumberOdd(int num)
        {
            // return num % 2 != 0;
            if (num % 2  == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            // done
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //IEnumerable just a collection
            //
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Max() + numbers.Min();
            }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            // done
        }

        public int Sum(int[] numbers)
        {
            //return number == null ? 0 : 
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }

            
        }

        public int SumEvens(int[] numbers)
        {
            

            int sumeven = 0;
            if (numbers == null)
                return 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sumeven += numbers[i];
            }
            return sumeven;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
                return false;
            if (numbers.Sum() % 2 != 0)
                return true;
            else
                return false;
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            

            if (number <= 0)
                return 0; 
            else
               return number / 2; 
            
        }
    }
}
