using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 100000;
            var concatString = "";
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < length; i++)
            {
                concatString = concatString + "a";
            }
            stopWatch.Stop();
            Console.WriteLine($"String Concat took: {stopWatch.ElapsedMilliseconds} ms, for {length} iterations.");
            stopWatch.Reset();
            concatString = string.Empty;
            stopWatch.Start();
            for (int i = 0; i < length; i++)
            {
                concatString = $"{concatString}a";
            }
            stopWatch.Stop();
            Console.WriteLine($"String Interpolation took: {stopWatch.ElapsedMilliseconds} ms, for {length} iterations.");

            stopWatch.Reset();
            stopWatch.Start();
            concatString = string.Empty;
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append("a");
            }
            concatString = stringBuilder.ToString();
            stopWatch.Stop();
            Console.WriteLine($"String Builder took: {stopWatch.ElapsedMilliseconds} ms, for {length} iterations.");

            Console.ReadLine();

        }
    }

}
