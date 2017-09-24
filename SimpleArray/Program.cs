using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an array of 5 integers
            int[] myScores = {100, 76, 88, 100, 90};

            //increasing each array element by 3 with for loops
            for (int sub = 0; sub < 5; ++sub)
                myScores[sub] += 3;
            //output number of integers and the newly added elements
            Console.WriteLine("{0}",myScores.Length);
            for (int x = 0; x < myScores.Length; ++x)
                Console.WriteLine(myScores[x]);
        }
    }
}
