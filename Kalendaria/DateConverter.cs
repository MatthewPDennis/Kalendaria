using System;
using System.Globalization;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

/*
 * Use invariant cultures only
 * 
*/

namespace Kalendaria
{
    internal class DateConverter
    {
        public CultureInfo? CurrentCulture;

        #region Constructors

        /// <summary>
        /// Uses the user's current culture.
        /// </summary>
        public DateConverter()
        {
            this.CurrentCulture = CultureInfo.CurrentCulture;
        }

        /// <summary>
        /// Uses the user-selected culture.
        /// </summary>
        /// <param name="currentCulture">The culture that the user has selected</param>
        public DateConverter(CultureInfo currentCulture)
        {
            this.CurrentCulture = currentCulture;
        }

        #endregion

        /// <summary>
        /// Retrieves the number of days in the current month
        /// </summary>
        /// <returns>Number of days in the month</returns>
        public int DaysInMonth()
        {
            var now = new DateTime();
            int qty = -1;
            if (CurrentCulture != null)
                qty = CurrentCulture.Calendar.GetDaysInMonth(now.Year, now.Month);
            return qty;
        }

        /// <summary>
        /// Retrieves an array of names of days of the week for the selected culture. Length of array determines length of week.
        /// </summary>
        /// <returns>Array of names of days of the week. If array is length 0, no names were found.</returns>
        public string[] DaysInWeek()
        {
            string[] days = new string[0];
            if (CurrentCulture != null)
                days = CurrentCulture.DateTimeFormat.DayNames;
            return days;
        }
        

    }
}
