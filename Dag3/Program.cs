using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(theBiggestNumber(new int[] { 12, 23, 193, 1312 }));
            Console.WriteLine(two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));
            Console.ReadLine();
        }

        //Two 7s next to each other
        static int two7sNextToEachOther(int[] numberOfTimes)
        {
            int int2 = 0;
            for (int i = 0; i < numberOfTimes.Length - 1; i++)
            {
                if (numberOfTimes[i] == 7 && numberOfTimes[i + 1] == 7)
                {
                    int2++;
                }
            }
            return int2;
        }

        //The biggest number
        static int theBiggestNumber(int[] number)
        {
            return number.Max();
        }
    }
}
