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
            // Console.WriteLine(String.Join(", ", SieveOfEratosthenes(30)));
            //Console.WriteLine(ToThePowerOf(5, 5));
            //Console.WriteLine(SumAndAverage(-10, 0));
            Console.WriteLine(FullSequenceOfLetters('m', 'b'));
            Console.Read();
        }

        public static int[] SieveOfEratosthenes(int a)
        {
            int[] res = { };
            var tempRes = res.ToList();

            for (int i = 0; i < a; i++)
            {
                if (!(i % 2 == 0 || i % 3 == 0 || i == 1 ) || i == 2 || i == 3) {
                    tempRes.Add(i);
                }
            }

            res = tempRes.ToArray();
        return res;

        }

        public static double ToThePowerOf(int a, int b)
        {
            double c = a;

            for (int i = 1; i < b; i++)
            {
                c *= Convert.ToDouble(a);
            }

            return c;
        }

        public static string SumAndAverage(int a, int b)
        {
            if (!(a <= b)) { (a, b) = (b, a); }

            int[] arr = { };
            var arr2 = arr.ToList();

            for (int i = a; i < b+1; i++)
            {
                arr2.Add(i);
            }

            int sum = arr2.Sum();
            double avg = arr2.Average();

            return "Sum: " + Convert.ToString(sum) + ", Average: " + Convert.ToString(avg);
        }

        public static string FullSequenceOfLetters(char a, char b)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            

            string[] res = { };
            var res2 = res.ToList();

            int add = 0;

            foreach (char e in alphabet)
            {
                if (e == a || e == b) {
                    add += 1; 
                    if (add == 2) {
                        res2.Add(Convert.ToString(e)); 
                    }
                }
                if (add == 1) { res2.Add(Convert.ToString(e)); }
            }

            return String.Join(" ", res2);
        }
    }
}
