using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class DateTimeMethod
    {
        public void showDateTimeMethod() { 

            DateTime dt =  DateTime.Now;
            string d1=dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dt);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);

            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);

             Console.WriteLine("Short time=> " + dt.ToShortTimeString());
            Console.WriteLine("Long time=>" + dt.ToLongTimeString());
            Console.WriteLine("Short date=>" + dt.ToShortDateString());
            Console.WriteLine("Long date => " + dt.ToLongDateString());

            Console.WriteLine("day of the week=> " + dt.DayOfWeek.ToString());
            Console.WriteLine("Day of the year=> " + dt.DayOfYear.ToString());

        }

    }
}
