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
            string stars = "         *";
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine(stars);
                stars = stars.Remove(0, 1);
                stars += "**";
            }
            Console.ReadLine();
        }
    }
}
