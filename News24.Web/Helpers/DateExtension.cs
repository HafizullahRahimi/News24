using System.Globalization;

namespace News24.Web.Helpers;

public static class DateExtension
{
    public static string ToShamsi(this DateTime dateTime)
    {
        PersianCalendar pc = new PersianCalendar();
        return pc.GetYear(dateTime) + "/" + pc.GetMonth(dateTime).ToString("00") + "/" + pc.GetDayOfMonth(dateTime).ToString("00");
    }    
    public static string ToShamsiWithTime(this DateTime dateTime)
    {
        return dateTime.ToString("HH:mm:ss yyyy/MM/dd ", new CultureInfo("fa-IR"));
    }
}
