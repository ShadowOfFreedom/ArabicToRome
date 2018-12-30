using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace RomeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(Rome.toRome(2865));
            sw.Stop();
            Console.WriteLine($"Elapsed={sw.Elapsed}");


        }
    }
}
