using FreeControls;
using System;
using System.Globalization;

namespace Accounting.Utility
{
    public static class Tools
    {
        public static string ToDatePersian(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            return pc.GetYear(date).ToString("0000")
                + "/" + pc.GetMonth(date).ToString("00")
                + "/" + pc.GetDayOfMonth(date).ToString("00");
        }

        public static string ToDatePersian(this PersianDateTimePicker date)
        {
            return string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(date.Value.Year.ToString() + "/" + date.Value.Month.ToString() + "/" + date.Value.Day.ToString()));
        }

        public static string ToTimePersian(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();

            return pc.GetHour(date).ToString("00")
                + ":" + pc.GetMinute(date).ToString("00")
                + ":" + pc.GetSecond(date).ToString("00");
        }

        public static string ToMoney(this double myMoney)
        {
            return myMoney.ToString("#,0", CultureInfo.CreateSpecificCulture("fa-ir"));
        }
    }
}