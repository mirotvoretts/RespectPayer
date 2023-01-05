using System;
using PressF;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            var respectPayer = new RespectPayer();
            
            respectPayer.Start();
            
            Console.ReadKey();
        }
    }
}