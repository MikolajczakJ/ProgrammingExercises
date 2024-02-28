using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingExercises
{
    internal static class DateAndTimeExc
    {
        /// <summary>
        /// converts date to dddd - dd.MM.yyyyr. format
        /// </summary>
        /// <returns>date in "dddd - dd.MM.yyyyr." format</returns>
        public static string FormatedDate(DateTime date) => date.ToString("dddd - dd.MM.yyyyr.");

        /// <summary>
        /// Generates day of the week for given date
        /// </summary>
        /// <returns>day of the week for given date</returns>
        public static string DayOfTheWeek(this DateTime date) => date.ToString("dddd");
        /// <summary>
        /// calculates ammount of days between two given dates
        /// </summary>
        /// <returns>Ammount of days between two given dates</returns>
        public static double HowManyDays(DateTime startingDate, DateTime endingDate)
            => (endingDate - startingDate).TotalDays;

        /// <summary>
        /// Generates day of the week for a day in x days
        /// </summary>
        /// <returns>day of the week for a day in x days</returns>
        public static string DayNameInXDays(int daysToAdd) => DateTime.Today.AddDays(daysToAdd).DayOfTheWeek();

        /// <summary>
        /// Checks whether first date is greater than second date
        /// </summary>
        /// <returns>True if first date is greater than second one else false</returns>
        public static bool IsGreaterThan(this DateTime firstDate, DateTime secondDate) => firstDate> secondDate;

        /// <summary>
        /// Calculates how many days are in given month
        /// </summary>
        /// <returns>Int value representing count of days in given month</returns>
        public static int HowManyDaysInMonth(DateTime month)
            => DateTime.DaysInMonth(month.Year, month.Month);

        /// <summary>
        /// Checks whether given date is in inclusive range of two other dates
        /// </summary>
        /// <returns>true when checkingDate >= startingDate && checkingDate <= endingDate</returns>
        public static bool IsInRange(this DateTime checkingDate, DateTime startingDate, DateTime endingDate)
            => checkingDate >= startingDate && checkingDate <= endingDate;

        /// <summary>
        /// Searches for leap years in given range 
        /// </summary>
        /// <returns>Collection of leap years in given range</returns>
        public static IEnumerable<int> ListLeapyears(DateTime startingDate, DateTime endingDate)
        {
            for (int i = startingDate.Year; i <= endingDate.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                    yield return i;

            }
        }

        /// <summary>
        /// Conuts how many days there are between two given values
        /// </summary>
        /// <returns>Number of days between two given dates, rounds value by Math.Floor</returns>
        public static double CountDays(DateTime start, DateTime finish)
            =>Math.Floor(finish.Subtract(start).TotalDays);


        /// <summary>
        /// Generates day of the week of the first day in year from given date
        /// </summary>
        /// <returns>day of the week of the first day in year from given date</returns>
        public static string LastDayofYear(DateTime date) => new DateTime(date.Year+1, 1, 1).AddDays(-1).ToString("dddd");

        /// <summary>
        /// Generates day of the week of the last day in year from given date
        /// </summary>
        /// <returns>day of the week of the last day in year from given date</returns>
        public static string FirstDayofYear(DateTime date) => new DateTime(date.Year-1, 12, 31).AddDays(1).ToString("dddd");

        /// <summary>
        /// Creates collection of all months
        /// </summary>
        /// <returns>collection of all months</returns>
        public static IEnumerable<string> GiveAllMonths()
        {
            DateTime date = new DateTime(1000, 1, 1);
            for (int i = 0; i < 12; i++)
            {
                yield return date.ToString("MMMM");
                date = date.AddMonths(1);
            }
        }
        

    }
}
