using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in typeof(ConsoleApp1.Program).Assembly.GetManifestResourceNames())
            {
                Console.WriteLine(name);
            }
        }
    }
}
