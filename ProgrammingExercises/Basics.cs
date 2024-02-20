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
        /// <summary>
        /// Sums up digits of given value
        /// </summary>
        /// <returns>Sum of the given value</returns>
        public static int SumOfDigits(int value)
        {
            int sum = 0;
            do
            {
                sum += value % 10;
                value /= 10;

            } while (value>0);
            return sum;
        }
        /// <summary>
        /// Reverses words in the sentence
        /// </summary>
        public static string ReverseSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            return String.Join(' ', words.Reverse());
        }
        /// <summary>
        /// Returns size of file in bytes
        /// </summary>
        /// <param name="filePath">Directory to selected file</param>
        public static long SizeOfFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }
        /// <summary>
        /// Converts value from hexadecimal do decimal
        /// </summary>
        /// <param name="hex">hexadecimal representation of value</param>
        /// <returns>Value in decimal</returns>
        public static int HexToDec(string hex) => int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

        /// <summary>
        /// Multiplies each element in array with coresponding element in other array
        /// </summary>
        /// <returns>Array with prodtucts of multiplication</returns>
        public static int[] MultiplyArrays(int[] collectionA, int[] collectionB)
        {
            int[] result = new int[collectionA.Length];
            if (collectionA.Count() == collectionB.Count())
            {
                for (int i = 0; i < collectionA.Count(); i++)
                {
                    result[i] = collectionA[i]* collectionB[i];
                }
            }
            return result;
        }
        /// <summary>
        /// If length is greater than 3, returns 4 last characters of string, else returns unaltered value
        /// </summary>
        public static string FourCopies(string value)
        {
            if (value.Length<4)
                return value;
            string sub = value[(value.Length - 4)..];
            return $"{sub} {sub} {sub} {sub}";
        }
        /// <summary>
        /// Checks whether given value is multiple of modulos
        /// </summary>
        /// <param name="value">value being checed whether it is multiplication of modulo</param>
        /// <returns>True if value is multiplication of any given value in modulos, else false</returns>
        public static bool IsMultipleOf(this int value, params int[] modulos)
        {
            foreach (int modulo in modulos)
            {
                if (value%modulo==0)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks whether one of the two values is smaller than 100 and other one is greater than 200
        /// </summary>
        /// <returns>True if one of the two values is smaller than 100 and other one is greater than 200</returns>
        public static bool OneLesserOneGreater(int firstVal, int secondVal)
            => (firstVal < 100 && secondVal > 200) || (secondVal < 100 && firstVal > 200);
        /// <summary>
        /// Checks whether value is withing range (inclusive)
        /// </summary>
        /// <returns>True when value is within inclusive range of min-max</returns>
        private static bool IsInRange(this int value, int min, int max) => (value >= min && value <= max);

        /// <summary>
        /// Finds min and max values in array of ints
        /// </summary>
        /// <returns>Tuple (min int,max int)</returns>
        public static (int, int) MinAndMax(params int[] values)
        {
            int min=int.MaxValue, max=int.MinValue;
            foreach (var item in values)
            {
                if (item > max)
                    max = item;
                if (item < min)
                    min = item;
            }
            return(min, max);
        }
        /// <summary>
        /// Counts how many times specific character appears in string
        /// </summary>
        /// <param name="searchedChar">Character to be searched in string</param>
        /// <returns>A number of occurances in text</returns>
        public static int CharOccurence(string text, char searchedChar)
        {
            int counter = 0;
            foreach (var item in text)
            {
                if (item==searchedChar)
                {
                    counter++;
                }
            }
            return counter;
        }
        /// <summary>
        /// If string length is smaller than 4 return whole string in uppercase, else returns first 4 characters in lowercase and rest normally
        /// </summary>
        /// <returns>whole string in uppercase if text length is <4, else returns first 4 characters in lowercase and rest normally</returns>
        public static string ToUpperOrLower(string text)
        {
            if (text.Length<4)
            {
                return text.ToUpper();
            }
            return text[0..4].ToLower() + text[4..];
        }
        /// <summary>
        /// Takes characters that are located only on odd indexes
        /// </summary>
        /// <returns>string with characters that were located on odd indexes in given text </returns>
        public static string OnlyOddChars(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = false;
            foreach (var item in text) 
            {
                if (flag)
                {
                    stringBuilder.Append(item);
                }
                flag = !flag;
            }
            return stringBuilder.ToString();

        }
        /// <summary>
        /// Counts how many times selectedValue occures in IEnumerable
        /// </summary>
        /// <returns>Returns count of the selectedValue occurances in given IEnumerable </returns>
        public static int ValOccurance(int selectedValue, IEnumerable<int> values)
        {
            int counter = 0;
            foreach (var item in values)
            {
                if (item==selectedValue)
                {
                    counter++;
                }
            }
            return counter;
        }
        /// <summary>
        /// Checks beggining and end of array to see if selected value appears
        /// </summary>
        /// <returns>True if appears on at least one of two positions, otherwise false</returns>
        public static bool StartsOrEndsWith(int searchedValue, int[] ints)
        {
            if (ints.Length>=1)
            {
                return ints[0] == searchedValue || ints[^1] == searchedValue;
            }
            return false;
        }
        /// <summary>
        /// Checks whether array starts and ends with the same value
        /// </summary>
        /// <param name="array"></param>
        /// <returns>True if </returns>
        public static bool EndEqualToStart(int[] array)
            => (array.Length > 1) ? array[0] == array[^1] : false;
        /// <summary>
        /// Checks whether starting or ending values are equal in both arrays
        /// </summary>
        /// <returns>True if starting OR ending values are equal in both arrays</returns>
        public static bool EqualEndsOrStarts(int[] firstArray, int[] secondArray)
            => (firstArray.Length > 1 && secondArray.Length > 1) ? firstArray[0] == secondArray[0] || firstArray[^1] == secondArray[^1] : false;
        /// <summary>
        /// Moves all elements in array by one index to the left
        /// </summary>
        /// <returns>New array with all values shifted to the left by one, first value will be last one</returns>
        public static int[] MoveToLeft(int[] array)
        {
            int[] result = new int[array.Length];
            int storage = array[0];
            array.CopyTo(result, 0);
            for (int i = 0; i < array.Length-1; i++)
            {
                result[i] = result[i + 1];
            }
            result[^1] = storage;
            return result;
        }
        /// <summary>
        /// Compares beggining and the end of array and returns greater value
        /// </summary>
        /// <returns>Greater alue between starting and ending array values</returns>
        public static int GreaterOnTheEnds(int[] array) => array.Length<2? int.MinValue : int.Max(array[0], array[^1]);
        /// <summary>
        /// Checks whether collection contains odd value
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>True when collection has odd value in it, else false</returns>
        public static bool ContainsOdd(IEnumerable<int> collection)
            => collection.FirstOrDefault(x => x % 2 != 0) != 0;
        /// <summary>
        /// Checks given year and returns proper century
        /// </summary>
        /// <returns>Proper century based on given year</returns>
        public static short WhichCentury(short year)
            =>(year % 100 != 0)? (short)((year / 100) + 1):(short)(year / 100);
        /// <summary>
        /// Looks for greates product in given array
        /// </summary>
        /// <param name="ints"></param>
        /// <returns>Greatest (multiplicand,multiplier) in given array </returns>
        public static (int, int) GetLargestProductComponents(int[] ints)
        {
            int multiplicand= int.MinValue,
                multiplier= int.MinValue,
                greatestProduct = int.MinValue;
            for (int i = 0; i < ints.Length-1; i++)
            {
                if (greatestProduct < ints[i] * ints[i + 1])
                {
                    greatestProduct = ints[i] * ints[i + 1];
                    multiplicand = ints[i];
                    multiplier = ints[i + 1];
                }
            }
            return (multiplicand, multiplier);
        }
        /// <summary>
        /// Checks whether given string is a palindrome
        /// </summary>
        /// <returns>True if given string is a palindrome, else false</returns>
        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            for (int i = 0, j = text.Length - 1;
                i < text.Length && j >= 0;
                i++, j--)
            {
                if (text[i] != text[j]) return false;
            }
            return true;
        }
        /// <summary>
        /// Sorts array and how many integeres are missing from full range
        /// </summary>
        /// <returns>Count of missing values</returns>
        public static int HowManyMissing(int[] ints)
        {
            int missing = 0;
            Array.Sort(ints);
            for (int i = 0; i < ints.Length-1; i++)
            {
                missing += ints[i+1] - ints[i] - 1;
            }
            return missing;
        }
        /// <summary>
        /// checks whether array contains only increasingly larger values
        /// </summary>
        /// <returns>True if contains only increasingly larger values, if length <=1 false, else false</returns>
        public static bool OnlyIncreasingValues(int[] ints)
        {
            if (ints.Length<=1) return false;

            for (int i = 0; i < ints.Length-1; i++)
            {
                if (ints[i] >= ints[i+1])   return false;
            }
            return true;
        }
        /// <summary>
        /// Gives filename and extension from given directory
        /// </summary>
        /// <param name="path"></param>
        /// <returns>filename and extension from given directory</returns>
        public static string FileNameInfo(string path)
            => path.Split('/').Last();
        /// <summary>
        /// Replaces selected characters to new ones
        /// </summary>
        /// <param name="text">text for transformation</param>
        /// <param name="chars">(oldChar, newChar)</param>
        /// <returns>Altered text</returns>
        public static string HashString(string text, params (char, char)[] chars)
        {
            foreach (var item in chars)
            {
                text = text.Replace(item.Item1, item.Item2);
            }
            return text;
        }
        public static bool AllLowerOrUpper(string text)
                => text == text.ToLower() || text == text.ToUpper(); 
        /// <summary>
        /// Removes first and last letter from given text
        /// </summary>
        /// <returns>String without first and last character, if string length <2 returns empty string</returns>
        public static string RemoveFirstAndLast(string text)
         =>(text.Length<2)? string.Empty: text.Remove(text.Length-1).Remove(0,1);

        /// <summary>
        /// Checks whether given string has two same consecutive characters 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>true when  given string has two same consecutive characters else false</returns>
        public static bool SameConsecutiveChars(string text)
        {
            if (text.Length<2 || text is null) return false;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == text[i + 1])
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Checks whether average of given collection is a whole number 
        /// </summary>
        /// <returns>True if Average is a whole number</returns>
        public static bool AverageIsWhole(IEnumerable<int> collection)
            => collection.Average(x => x)%1==0;
        /// <summary>
        /// Orders all characters in the string alphabetically (characters must be all lowercase or all uppercase)
        /// </summary>
        /// <returns>Alphabetically ordered string</returns>
        public static string OrderAlphabetically(string text)
            =>new string(text.Order().ToArray());

        /// <summary>
        /// Checks whether string length is even
        /// </summary>
        /// <returns>True if string length is even</returns>
        public static bool IsEvenLength(string text)
            => text.Length % 2 == 0;
        /// <summary>
        /// Calculates n-th odd number
        /// </summary>
        /// <returns> n-th odd number</returns>
        public static int NthOddNumber(int n) => (n * 2) - 1;

        /// <summary>
        /// Converts int value to ascii char
        /// </summary>
        /// <returns>character with ascii character coresponding to its id</returns>
        public static char IntToChar(int val) => (char)(val % 127);
        /// <summary>
        /// Calculates sum of squared values 
        /// </summary>
        /// <param name="ints"></param>
        /// <returns>sum of squared values</returns>
        public static int SumOfSquares(params int[] ints)
            => ints.Sum(x => x*x);
        /// <summary>
        /// Converts IEnumerable of objects to IEnumerable of strings with GetType information
        /// </summary>
        /// <returns>IEnumerable of strings with GetType information</returns>
        public static IEnumerable<string> ObjectsToString(IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                yield return item is null? "NULL" : $"{item} Type: {item.GetType()}";
            }
        }
        /// <summary>
        /// Removes characters that are not in english alphabet
        /// </summary>
        /// <returns>String only with letters from english alphabet</returns>
        public static string KeepOnlyLetters(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in text)
            {
                if ((item>='a' && item <='z')|| (item >= 'A' && item <= 'Z'))
                    stringBuilder.Append(item);
            }
            return stringBuilder.ToString();
        }
        
        /// <summary>
        /// checks whether given character is a letter 
        /// </summary>
        /// <returns>True when given character is uppercase or lowercase letter</returns>
        private static bool IsLetter(this char character) => (character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z');
       
        /// <summary>
        /// checks whether given character is a digit 
        /// </summary>
        /// <returns>True when given character is a digit</returns>
        private static bool IsDigit(this char character) => character >= '0' && character <= '9';

        /// <summary>
        /// Removes vowels from the text
        /// </summary>
        /// <returns>Text without the vowels</returns>
        public static string RemoveVowels(string text)
            =>new string(text.Where(x => !x.IsVowel()).ToArray());
        /// <summary>
        /// Checks whether given char is a vowel
        /// </summary>
        /// <returns>True if given char is a vowel, else false</returns>
        private static bool IsVowel(this char c)
           =>"AEIOUaeiou".IndexOf(c) != -1;
        /// <summary>
        /// Searches for lowercase letters in text and adds indexes to the collection
        /// </summary>
        /// <returns>Collection of indexes of lowercase letters</returns>
        public static IEnumerable<int> GetIndexesOfLowercase(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                    yield return i;
            }
        }
        /// <summary>
        ///  Finds the cumulative sum of an array of numbers.
        ///  For example, the cumulative sums of the sequence {x, y, z,...}, are x, x+y , x+y+z
        /// </summary>
        /// <returns>Collection of cumulative sums of the sequence type of float </returns>
        public static IEnumerable<float> CumulativeSum(this float[] values)
        {
            float sum;
            for (int i = 0; i < values.Count(); i++)
            {
                sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += values[j];
                }
                yield return sum;
            }
        }

        /// <summary>
        /// Counts digits and letters in given text
        /// </summary>
        /// <returns>int tuple (digit count, letter count)</returns>
        public static (int, int) DigitAndLetterCount(string text)
        {
            int digitCount = 0,
                letterCount = 0;
            foreach (var item in text)
            {
                if (item.IsLetter()) letterCount++;

                else if (item.IsDigit()) digitCount++;
            }
            return (digitCount, letterCount);
        }

        /// <summary>
        /// Calculates the sum of interior angles in polygon with edges equal to edgeCount
        /// </summary>
        /// <param name="edgeCount">Ammount of edges in polygon</param>
        /// <returns>Sum of the interior angles in polygon </returns>
        public static int SumOfInteriorAngles(int edgeCount) => (edgeCount - 2 ) * 180; 

        /// <summary>
        /// Converts given value to binary and counts ones and zeroes
        /// </summary>
        /// <returns>int tuple (zeroesCount, onesCouns)</returns>
        public static (int, int) DigitCountInBinary(int value)
        {
                int zeroes = 0,
                ones = 0;
            string binaryVal = Convert.ToString(value, 2);
            foreach (var item in binaryVal)
            {
                if (item=='1')
                    ones++;
                else
                    zeroes++;

            }
            return (zeroes, ones);
        }

        /// <summary>
        /// Searches through object array and selects only integer values
        /// </summary>
        /// <returns>Collection of integers from given object array</returns>
        public static IEnumerable<int> KeepOnlyInts(object[] values)
        {
            for (int i = 0; i < values.Length; i++) 
            {
                if (values[i] is int)
                    yield return (int)values[i];
            }
        }

        /// <summary>
        /// Searches for nearest prime number of given value
        /// </summary>
        /// <returns>returns nearest prime to given value</returns>
        public static int NearestPrime(int value)
        {
            int nearestLowestPrime = int.MinValue,
                nearestHigherPrime = value;

            for (int i = value; i > 1; i--)
            {
                if (i.IsPrime())
                {
                    nearestLowestPrime = i;
                    break;
                }
            }
            int iteration = 0;
            do
            {
                if (nearestHigherPrime.IsPrime())
                {
                    return nearestHigherPrime;
                }
                iteration++;
                nearestHigherPrime++;
            } while (iteration< value-nearestLowestPrime);
            return nearestLowestPrime;
        }
    }
}
