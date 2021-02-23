using System;
using System.Reflection;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine(name);
            }
        }
    }
}
