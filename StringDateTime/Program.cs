using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2020, 10, 6);
            Console.WriteLine(dt.ToString("D", CultureInfo.CreateSpecificCulture("vi-VN")));

            string dt1 = "15062020 05:30:20";
            DateTime dt2;
            DateTime.TryParseExact(dt1, "ddMMyyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt2);
            Console.WriteLine(dt2);


            TimeSpan ts1 = new TimeSpan(1, 10, 20, 3);
            Console.WriteLine("Ngay: " + ts1.Days + " gio: " + ts1.Hours + " phut: " + ts1.Minutes + " giay: " + ts1.Seconds);

            TimeSpan ts2 = new TimeSpan(48, 12, 30);
            if(ts1.CompareTo(ts2) == -1)
            {
                Console.WriteLine("ts1 < ts2");
            }
            if (ts1.CompareTo(ts2) == 0)
            {
                Console.WriteLine("ts1 = ts2");
            }
            if (ts1.CompareTo(ts2) == 1)
            {
                Console.WriteLine("ts1 > ts2");
            }

            // Subtract() method trả về 1 TimeSpan, ts2 - ts1
            Console.WriteLine(ts2.Subtract(ts1));
            Console.ReadKey();
        }
    }
}
