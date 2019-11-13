using System;
using System.Threading.Tasks;

namespace SomeUiConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(100);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
