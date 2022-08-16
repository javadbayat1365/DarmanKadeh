using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public static class DateConvert
    {
        public static string ToShamsiDateTime(this DateTime value)
        {
            if (value == null || value == DateTime.MinValue)
                return "";
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value).ToString() + "/" + pc.GetMonth(value) + "/" + pc.GetDayOfMonth(value) + " " + pc.GetHour(value).ToString() + ":" + pc.GetMinute(value).ToString();
        }
    }
}
