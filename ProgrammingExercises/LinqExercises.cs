using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    internal static class LinqExercises
    {
        /// <summary>
        /// Selects only even values in given collection
        /// </summary>
        /// <returns>even values from given collection</returns>
        public static IEnumerable<int> OnlyEven(IEnumerable<int> collection)
        {
            var onlyEven = from item in collection
                           where item%2==0
                           select item;
            return onlyEven;
        }

        /// <summary>
        /// Finds values that fit in inclusive range min-max
        /// </summary>
        /// <param name="min">inclusive lower boundary</param>
        /// <param name="max">inclusive upper boundary</param>
        /// <returns>values that fit in inclusive range min-max</returns>
        public static IEnumerable<int> FromSelectedRange(this IEnumerable<int> collection, int min, int max)
        {
            var selectedRange = from item in collection
                                where item<=min && item>=max
                                select item;
            return selectedRange;
        }

        /// <summary>
        /// Calculates square of each value in collection
        /// </summary>
        /// <returns>Tuple (value from collection, squared value)</returns>
        public static IEnumerable<(int, int)> ValAndItsSquare(IEnumerable<int> collection)
        {
            var valuesAnditsSquares = from item in collection
                                      let pow = item*item
                                      select (item, pow);
            return valuesAnditsSquares;
        }

        /// <summary>
        /// Counts how many times each unique value appears in given collection
        /// </summary>
        /// <returns>Tuple (value, how many times it appeared in collection)</returns>
        public static IEnumerable<(int,int)> AppearanceFrequency(IEnumerable<int> collection)
        {
            var values = from item in collection
                         group item by item into count
                         select (count.Key, count.Count());
            return values;
        }

        /// <summary>
        /// Counts how many times each unique character appears in given collection
        /// </summary>
        /// <returns>Tuple (character, how many times it appeared in collection)</returns>
        public static IEnumerable<(char, int)> CharFrequency(string text)
        {
            var charCount = from character in text
                            group character by character into charAndCount
                            select (charAndCount.Key, charAndCount.Count());
            return charCount;
        }

        /// <summary>
        /// Finds words that start and end with given characters
        /// </summary>
        /// <param name="firstChar">Character that must be on first position of the word</param>
        /// <param name="lastChar">Character that must be on last position of the word</param>
        /// <returns>Collection of words that meet requirements of first and last characters</returns>
        public static IEnumerable<string> FindByFirstAndLastChar(this IEnumerable<string> collection, char firstChar, char lastChar)
        {
            var findWords = from word in collection
                            where word.StartsWith(firstChar) && word.EndsWith(lastChar)
                            select word;
            return findWords;
        }

        /// <summary>
        /// Selects values that are greater than given value
        /// </summary>
        /// <param name="value">Value that will be compared to collection values, they must be greater in order to add them to returning collection</param>
        /// <returns>Collection of values that are greater than given value</returns>
        public static IEnumerable<int> GreaterThan(this IEnumerable<int> collection, int value)
        {
            var greaterThan = from item in collection
                              where item > value
                              select item;
            return greaterThan;
        }

        /// <summary>
        /// Reorders items in collection descendingly and selects first x values
        /// </summary>
        /// <returns>first X items from collection in descending order</returns>
        public static IEnumerable<int> FirstNRecords(this IEnumerable<int> collection, int count)
        {
            if (count>collection.Count())
            {
                throw new Exception("Count greater than count of collection");
            }
            var firstnValues = from item in collection
                               orderby item descending
                               select item;
            return firstnValues.Take(count);
        }
        public static IEnumerable<string> FindWordsInUpper(this string sentence)
        {
            string[] words = sentence.Split(' ');
            var onlyInUpper = from item in words
                              where item.All(x => char.IsUpper(x))
                              select item;
            return onlyInUpper;
        }
    }
}
