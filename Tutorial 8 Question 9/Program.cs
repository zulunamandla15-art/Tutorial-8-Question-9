using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_8_Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matrix

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + j - 1 + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
