using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            return vals.Contains(false);

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            return Math.Abs(numbers.Sum()) % 2 == 1; 

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
            
        }

        public char GetFirstLetterOfString(string val)
        {

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {

            return nums.Last() - nums.First();
            
            //var lastNum = nums.Last();
            //var firstNum = nums.First();

            //return lastNum - firstNum;
        }

        public int[]  GetOddsBelow100()
        {

            var number = Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
            return number;

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
