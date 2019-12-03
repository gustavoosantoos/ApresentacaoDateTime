using ApresentacaoDateTime.Default;
using System;

namespace ApresentacaoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //var demoDateTime = new DemoDateTime();
            //demoDateTime.Run();

            //var demoDateTimeOffset = new DemoDateTimeOffset();
            //demoDateTimeOffset.Run();

            var demoTimeSpan = new DemoTimeSpan();
            demoTimeSpan.Run();

            Console.ReadKey();
        }
    }
}
