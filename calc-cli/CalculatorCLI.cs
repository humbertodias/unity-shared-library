using System;
using calculation;
using System.Reflection;

namespace calc_cli
{
    class Program
    {
        static void reflect(){
            // get all public static methods of MyClass type
            MethodInfo[] methodInfos = typeof(calculate).GetMethods(BindingFlags.Public | BindingFlags.Static);
            // sort methods by name
            // Array.Sort(methodInfos,
            //         delegate(MethodInfo methodInfo1, MethodInfo methodInfo2)
            //         { return methodInfo1.Name.CompareTo(methodInfo2.Name); });

            // write method names
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
            }

        }
        static void Main(string[] args)
        {
            Program.reflect();
        }

        static void Main1(string[] args)
        {

            Program.reflect();

            var calc = new calculate();
            Console.WriteLine("Sum two numbers");
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            var result = calc.Sum(a,b);
            Console.WriteLine($"{a} + {b} = {result}");
        }
    }
}
