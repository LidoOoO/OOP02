using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class HireDate : IComparable<HireDate>
    {
        private int Day;
        private int Month;
        private int Year;

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }


        public int CompareTo(HireDate other)
        {
            if (other == null)
                return 1;

            int result = Year.CompareTo(other.Year);
            if (result != 0) return result;

            result = Month.CompareTo(other.Month);
            if (result != 0) return result;

            return Day.CompareTo(other.Day);
        }

        public override string ToString()
        {
            return $"{Day} / {Month} / {Year}";
        }
    }
}
