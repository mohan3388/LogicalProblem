using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class Leapyear
    {
        public void Year()
        {
            Console.WriteLine("Enter number:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        }
    }
}
