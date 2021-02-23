using System;

namespace ConsoleApp2
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
