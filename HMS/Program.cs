using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = string.Empty;
            test = null;
            if(Int32.TryParse(test, out int integerValue) == true)
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("Failed!");
        }
    }
}
