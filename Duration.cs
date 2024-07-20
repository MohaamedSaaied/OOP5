using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // Constructor with hours, minutes, and seconds
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int x)
        {
            Hours = x / 3600;
            Minutes = (x % 3600) / 60;
            Seconds = x % 60;
        }
        public void ToString()
        {
            Console.WriteLine($"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}");
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration d)
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public static Duration operator ++(Duration d1)
        {
            d1.Minutes+=1;
            return d1;
        }
        public static Duration operator --(Duration d1)
        {
            if (d1.Minutes > 0) d1.Minutes -= 1;
            else
            {
                if (d1.Hours > 0)
                {
                    d1.Hours -= 1;
                    d1.Minutes += 59;

                }     
            }
            return d1;
        }
        public static Duration operator +(Duration d1,Duration d2)
        {
            Duration d = new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
            return d1;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            Duration d = new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
            return d1;
        }
        public static Duration operator +(Duration d1, int x)
        {
            d1.Hours += x / 3600;
            d1.Minutes += ((x % 3600) / 60);
            d1.Seconds += x % 60;
            return d1;
        }
        public static Duration operator +(int x,Duration d1 )
        {
            d1.Hours += x / 3600;
            d1.Minutes += ((x % 3600) / 60);
            d1.Seconds += x % 60;
            return d1;
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes > d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    if (d1.Seconds > d2.Seconds)
                        return true;
            }

            return false; 
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes < d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    if (d1.Seconds < d2.Seconds)
                        return true;
            }

            return false; 
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes < d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    if (d1.Seconds <= d2.Seconds) return true;
            }

            return false; // Default case
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours)
            {
                if (d1.Minutes > d2.Minutes)
                    return true;
                else if (d1.Minutes == d2.Minutes)
                    if( d1.Seconds >= d2.Seconds) return true;
            }

            return false; // Default case
        }

    }
}
