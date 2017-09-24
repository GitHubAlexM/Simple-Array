using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForEachWithEnum
{
    class Program
    {
        enum Day//new enum class Day that contains the days of a week
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESSDAY, THURSDAY, FRIDAY, SATURDAY
        }
        static void Main(string[] args)
        {
            foreach (string day in Enum.GetNames(typeof(Day)))
                Console.WriteLine(day);
            //gets and displays each string in the enumeration using GetNames()
        }
    }
}
