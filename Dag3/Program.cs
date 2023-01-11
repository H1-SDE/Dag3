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
            Console.WriteLine(String.Join(", ", SieveOfEratosthenes(100)));
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
    }
}
