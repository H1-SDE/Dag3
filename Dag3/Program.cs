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
            //Console.WriteLine(threeIncreasingAdjacent(new int[] { 1, 4, 1, 1, 4, 3, 4, 5, 6, 7, 5, 4, 9 }));
            Console.WriteLine(extractString("##abc##def"));  // 123456789
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

        //Three increasing adjacent
        static bool threeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == numbers[i + 1] - 1 && numbers[i] == numbers[i + 2] - 2)
                {
                    return true;
                }
            }
            return false;
        }

        static string extractString(string word)
        {
            int firstWord = word.IndexOf("##") + 2;
            int secondWord = word.IndexOf("##", firstWord);
            if (secondWord - firstWord == 0 || secondWord == -1)
            {
                return "empty string";
            }
            return word.Substring(firstWord, secondWord - 2);
        }
    }
}
