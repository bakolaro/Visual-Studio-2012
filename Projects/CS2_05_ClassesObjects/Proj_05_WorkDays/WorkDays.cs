using System;
using System.Globalization;
using System.Threading;

class WorkDays
{
    /* Write a method that calculates the number of workdays between
     * today and given date, passed as parameter. Consider that workdays
     * are all days from Monday to Friday except a fixed list of public
     * holidays specified preliminary as array.
     */
    static void Main()
    {
        Console.WriteLine("Input data in format "
            + Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern);
        Console.WriteLine("Date: ");
        DateTime d = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Work days from today = " + WorkDaysFromToday(d, Holidays, WorkWeekends));
    }
    public static int WorkDaysFromToday(DateTime date, DateTime[] holidays, DateTime[] workdays)
    {
        DateTime fromDate = DateTime.Today;
        DateTime toDate = date.Date;
        if (toDate < fromDate)
        {
            DateTime swap = fromDate;
            fromDate = toDate;
            toDate = swap;
        }

        int count = 0;
        DateTime d = fromDate;
        int n = (toDate - fromDate).Days;
        for (int i = 0; i < n + 1; i++)
        {
            if (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
            {
                count++;
            }
            d = d.AddDays(1.0);
        }
        for (int i = 0; i < workdays.Length; i++)
        {
            if (workdays[i] >= fromDate && workdays[i] <= toDate &&
                workdays[i].DayOfWeek == DayOfWeek.Saturday &&
                workdays[i].DayOfWeek == DayOfWeek.Sunday)
            {
                count++;
            }
        }
        for (int i = 0; i < holidays.Length; i++)
        {
            if (holidays[i] >= fromDate && holidays[i] <= toDate &&
                holidays[i].DayOfWeek != DayOfWeek.Saturday &&
                holidays[i].DayOfWeek != DayOfWeek.Sunday)
            {
                count--;
            }
        }
        return count;
    }
    /* 1 януари 2013 – Нова година
    * 3 март 2013 – Ден на Освобождението на България от османско иго – национален празник
    * 1 май 2013 – Ден на труда
    * 5 май 2013 – Великден (5 май), заедно с понеделника след него и Разпети Петък (2 май)
    * 6 май 2013  – Гергьовден, Ден на храбростта и Българската армия
    * (7 май - неработен за сметка на 15 май)
    * 24 май 2013  – Ден на българската просвета и култура и на славянската писменост
    * 6 септември 2013  – Ден на Съединението
    * 22 септември 2013  – Ден на Независимостта на България
    * 1 ноември 2013  – Ден на народните будители – неприсъствен за всички учебни заведения
    * 24 декември 2013  – Бъдни вечер
    * 25 и 26 декември 2013  – Рождество Христово
    * 31 декември 2013 е неработен за сметка на 11 декември
    */
    public static DateTime[] Holidays = {
        new DateTime(2013, 1, 1), 
        new DateTime(2013, 3, 3), 
        new DateTime(2013, 5, 1), 
        new DateTime(2013, 5, 2), 
        new DateTime(2013, 5, 5), 
        new DateTime(2013, 5, 6),
        new DateTime(2013, 5, 7),
        new DateTime(2013, 5, 24),
        new DateTime(2013, 9, 6), 
        new DateTime(2013, 9, 22), 
        new DateTime(2013, 12, 24), 
        new DateTime(2013, 12, 25), 
        new DateTime(2013, 12, 26), 
        new DateTime(2013, 12, 31)
                                        };
    public static DateTime[] WorkWeekends = {
        new DateTime(2013, 5, 15),
        new DateTime(2013, 12, 11)
                                            };
}