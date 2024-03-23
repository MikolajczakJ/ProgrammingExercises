using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    internal static class Algorithms
    {
        /// <summary>
        /// Removes all values that end with toRemove
        /// </summary>
        /// <returns>Collection of values without values that end with toRemove</returns>
        public static IEnumerable<int> RemoveEndingWith(this IEnumerable<int> collection, int toRemove)
            => collection.Where(x => x%10 !=toRemove);

        /// <summary>
        /// Takes only values that are greater than given value
        /// </summary>
        /// <returns>Collection of integers that are greater than given value</returns>
        public static IEnumerable<int> OnlyGreaterThan(this IEnumerable<int> collection, int value)
            => collection.Where(x => x>value);

        public static IEnumerable<string> RemoveAndJoin(this IEnumerable<string> collection, string toRemove)
            => collection.Select(x => x.Replace(toRemove, string.Empty));
    }
}
