using System;
using calculation;
// DllImport
using System.Runtime.InteropServices;

namespace calculation.cli
{

    class CalcCLI
    {

        [DllImport("libcalc.so")] // 64-bit dll
        public static extern int sum(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Sum two numbers");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // calc-lib.dll - c#
            var calc = new Calculate();
            var result1 = calc.Sum(a,b);
            Console.WriteLine($"{a} + {b} = {result1}");

            loadDLL("../calc-lib-c/libcalc.so");

            // libcalc.so - c
            var result2 = sum(a,b);
            Console.WriteLine($"{a} + {b} = {result2}");
        }

    }

}
