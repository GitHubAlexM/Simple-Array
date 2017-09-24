using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachStatementsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare double array with 5 elements
            double[] payRate = { 6.00, 7.35, 8.12, 12.45, 22.22 };
            //foreach statement
            foreach (double money in payRate)
                Console.WriteLine("{0}",money.ToString("C"));
            //output each element "money" in array "payRate" on a new line
        }
    }
}
