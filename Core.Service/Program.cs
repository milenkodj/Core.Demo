using System;
using System.Threading;

namespace Core.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; ; i++)
            {
                Console.WriteLine($"{i}. Hello World!");
                Thread.Sleep(5000);
            }
        }
    }
}
