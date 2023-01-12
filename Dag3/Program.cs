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
            
            Console.ReadLine();
        }

        static string Stars(string stars)
        {
            string stars = "         *";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stars);
                stars = stars.Remove(0, 1);
                stars += "**";
                return stars;
            }
        }

        static string multiTabel (string test)
        {
            for (int j = 1; j <= 10; j = j + 1)
            {


                String text = "";

                for (int i = 1; i <= 10; i = i + 1)
                {
                    text = text + i * j + " ";





                }
                Console.WriteLine(text);
            }
            return test;
        }
    }
}
  
    