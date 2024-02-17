using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    internal static class Basics
    {
        /// <returns>Returns product of the given factors</returns>
        public static int ProductOfXNumbers(params int[] factors)
        {
            int product=1;
            foreach (var factor in factors)
            {
                product *= factor;
            }
            return product;
        }
        /// <summary>
        /// Prints out result of addition, subtraction, multiplication and division
        /// </summary>
        public static void ResultOfTwoDigitEquations(int firstValue, int secondValue)
        {
            Console.WriteLine($"{firstValue}+{secondValue}={firstValue+secondValue}");
            Console.WriteLine($"{firstValue}-{secondValue}={firstValue-secondValue}");
            Console.WriteLine($"{firstValue}*{secondValue}={firstValue*secondValue}");
            Console.WriteLine($"{firstValue}/{secondValue}={((float)firstValue/secondValue)}");
        }
        /// <summary>
        /// Prints out mutiplication row of given value
        /// </summary>
        public static void MultiplicationTableOfValue(int value)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{value}*{i}={value*i}");
            }
        }
        /// <param name="values">Values that account to calculation of average</param>
        /// <returns>Average of given ints</returns>
        public static double Average(params int[] values)
        {
            int sum=0;
            double result;
            //Solution 1
            //sum= values.Sum(x => x);
            //result = sum/values.Length;
            //Solution
            //result = values.Average(x => x);
            //Solution 3
            foreach (var value in values) 
            {
                sum += value;
            }
            result = (double)sum/values.Length;
            return result;
        }
        /// <summary>
        ///  takes three numbers (x,y,z) as input and outputs (x+y)*z and x*y + y*z.
        /// </summary>
        /// <returns>((x+y)*z, x*y + y*z.)</returns>
        public static (int, int)ResultOfTwoFunctions(int x, int y, int z)
        {
            int firstResult = (x + y) * z;
            int secondResult = (x * y)+ (y * z);

            return (firstResult, secondResult);
        }
        /// <summary>
        /// Prints given celsius temperature converted to Fahrenheit and Kelvin
        /// </summary>
        /// <param name="celsTemp">Temperature represented in celsius</param>
        public static void CelsiusToKelAndFah(int celsTemp)
        {
            Console.WriteLine($"Fahrenheit: {((float)celsTemp *9/5)+32} ");
            Console.WriteLine($"Kelvin: {(float)celsTemp +273.15} ");
        }
        /// <summary>
        /// replacest first and last characters if string has at leats 2 characters
        /// </summary>
        /// <returns>If length <2 returns unalteret text else returns text with switched first and last characters</returns>
        public static string SwitchFirstAndLastChar(string text)
        {
            if (text.Length >= 2)
                return text[^1] + text[1..^1] + text[0];
            else
                return text;
        }
        /// <summary>
        /// Chcecks if one value is positive and another one is negative
        /// </summary>
        /// <returns>True if one is positive and other one is negative</returns>
        public static bool OnePositiveOneNegative(int firstVal, int secondVal) => (firstVal >=0 && secondVal <0) || (secondVal >= 0 && firstVal < 0);
        /// <summary>
        /// Checks if given values are the same, if they are returns triple of the sum, if not returns just the sum of two values
        /// </summary>
        public static int SumOrTriple(int firstVal, int secondVal)
            =>(firstVal==secondVal) ? 3 * (firstVal + secondVal) : (firstVal + secondVal);
        /// <summary>
        /// Checks if first value is greater than second value, if it is, returns double of difference, else returns absolute value of difference
        /// </summary>
        /// <param name="firstVal">Minuend</param>
        /// <param name="secondVal">Subtrahend</param>
        public static  int AbsOfDifOrDouble(int firstVal, int secondVal) => firstVal> secondVal? (firstVal-secondVal)*2 : Math.Abs(firstVal-secondVal);
        /// <summary>
        /// Checks if given addends or sum equals to given value
        /// </summary>
        /// <param name="firstAddend">First addend</param>
        /// <param name="secondAddend">Second addend</param>
        /// <param name="checkValue">Value that will be compared to addends or sum</param>
        /// <returns>True if any of the addends or sum equals to the checkValue else false</returns>
        public static bool AddendOrSumEqVal(int firstAddend, int secondAddend, int checkValue)
            => firstAddend == checkValue || secondAddend == checkValue || firstAddend + secondAddend == checkValue;
        /// <summary>
        /// Checks whether given value is in range of 20 of checking point 
        /// </summary>
        /// <returns>True if given value is within range of points</returns>
        public static bool ValWithingRange(int givenVal, params int[] checkingPoints)
        {
            const int range = 20;
            foreach (int point in checkingPoints)
            {
                if (givenVal>= point-range && givenVal <=point+range)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Searches for longest word in sentence and returns it
        /// </summary>
        /// <returns>Longest word in sentence, first word by default </returns>
        public static string LongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            int longest = -1, longestId = 0;
            for (int i = 0; i < words.Length; i++)
            {
                longest = words[i].Length> longest ? words[i].Length : longest;
                longestId = i;
            }
            return words[longestId];
        }
        /// <summary>
        /// Prints odd numbers in range from start to end, inclusive
        /// </summary>
        public static void PrintOddNumbersInRange(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i%2!=0)
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Checks whether given value is a prime number, if it is return true
        /// </summary>
        private static bool IsPrime(this int value)
        {
            if(value <= 1) 
                return false;
            else if(value ==2) 
                return true;
            for (int i = 2; i <= Math.Sqrt(value); i++)
            {
                if (value%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Gets sum of the first X prime numbers
        /// </summary>
        /// <param name="count">Count of prime numbers to be added</param>
        /// <returns>Sum of the primes, if there is no primes returns zero</returns>
        public static int SumOfXPrimes(int count)
        {
            int sum = 0, i =0, primeCount=0;
            do
            {
                if (i.IsPrime())
                {
                    sum += i;
                    primeCount++;
                }
                    i++;
            } while (primeCount < count);
            return sum;
        }
        //Zad26^
    }
}
