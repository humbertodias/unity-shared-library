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

    const int RTLD_NOW = 2;
    private static IntPtr _dllPointer = IntPtr.Zero;
    public static IntPtr LoadLibrary (string fileName)
    {
        IntPtr retVal = dlopen (fileName, RTLD_NOW);
        var errPtr = dlerror ();
        if (errPtr != IntPtr.Zero) {
            Console.WriteLine(Marshal.PtrToStringAnsi (errPtr)) ;
        }
        return retVal;
    }    

    [DllImport("libdl.so")]
    private static extern IntPtr dlopen (String fileName, int flags);

    [DllImport("libdl.so")]
	private static extern IntPtr dlsym (IntPtr handle, String symbol);
    
	[DllImport("libdl.so")]
    private static extern IntPtr dlerror ();

    public T GetMethod<T>(String functionName) where T : class {
        if (_dllPointer == IntPtr.Zero) {
            Console.WriteLine("DLL not found, cannot get method '" + functionName + "'");
            return default(T);
        }

        IntPtr pAddressOfFunctionToCall = dlsym(_dllPointer, functionName);

        if (pAddressOfFunctionToCall == IntPtr.Zero) {
            return default(T);
        }

        return Marshal.GetDelegateForFunctionPointer(pAddressOfFunctionToCall, typeof(T)) as T;
    }

       static void loadDLL(string dllPath){
            _dllPointer = LoadLibrary(dllPath);
            if (_dllPointer == IntPtr.Zero) {
                Console.WriteLine("Error loading DLL.");
            }
        }

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

            // // libcalc.so - c
            // var result3 = GetMethod("sum");
            // Console.WriteLine($"{a} + {b} = {result3}");
        }
    }

}
