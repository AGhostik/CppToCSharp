using System;
using System.Runtime.InteropServices;

namespace CosoleApp
{
    public class Program
    {
        [DllImport("CppDLL.dll")]
        public static extern void hello_dll();

        private static void Main()
        {
            Console.WriteLine("Hello from CSharp project!");

            try
            {
                hello_dll();
            }
            catch (BadImageFormatException e)
            {
                Console.WriteLine($"ERROR!{Environment.NewLine}Set \"platform target\" = x86");
                Console.WriteLine(e);
            }
        }
    }
}
