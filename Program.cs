using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace write_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = ""; bool s = false; bool g = false;
            Console.Write("Enter big number: "); string q = Console.ReadLine();
            for (int x = 0; x < q.Length; x++)
            {
                if (q[x] != "e".ToCharArray()[0] && !g)
                {
                    Console.Write(q[x]);
                }
                else
                {
                    g = true;
                    if (!s) { x++; s = !s; }
                    a += q[x];
                }
            }
            for (int x = 0; x < int.Parse(a);x++)
            {
                Console.Write("0");
            }
            Console.ReadKey();
        }
    }
}
