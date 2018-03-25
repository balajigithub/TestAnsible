using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i.ToString() + Division.ReturnStr(i));
            }

            Console.ReadLine();
        }

        
    }
}
