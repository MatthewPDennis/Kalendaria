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
        //private Type CalType;

        public CultureInfo? CurrentCulture;

        //private Calendar? CurrCalendar;

        //private DateTimeFormatInfo? CurrDateFormat;

        #region Constructors

        /// <summary>
        /// Creates a default GregorianCalendar
        /// </summary>
        public DateConverter()
        {
            //CalType = typeof(GregorianCalendar);
            //CurrCalendar = (Calendar?)Activator.CreateInstance(CalType);
        }

        /// <summary>
        /// Creates a calendar based on user selection
        /// </summary>
        /// <param name="type">The Type of the calendar that the user has selected</param>
        public DateConverter(Type type)
        {
            //CalType = type;
            //CurrCalendar = (Calendar?)Activator.CreateInstance(CalType);
        }

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
            //var today = new DateTime();
            //return CurrCalendar!.GetDaysInMonth(today.Year, today.Month);
            return 0;
        }

        /// <summary>
        /// Retrieves the number of days in the current week
        /// </summary>
        /// <returns></returns>
        public int WeeksInMonth()
        {
            //var today = new DateTime();


            return 0;
        }


    }
}
