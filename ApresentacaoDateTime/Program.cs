using ApresentacaoDateTime.Default;
using ApresentacaoDateTime.NodaTime;
using System;

namespace ApresentacaoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var demoDateTime = new DemoDateTime();
            demoDateTime.Run();

            //var demoDateTimeOffset = new DemoDateTimeOffset();
            //demoDateTimeOffset.Run();

            //var demoTimeSpan = new DemoTimeSpan();
            //demoTimeSpan.Run();

            // NODA-TIME
            //var demoInstant = new DemoInstant();
            //demoInstant.Run();

            //var demoLocalDateTime = new DemoLocalDateTime();
            //demoLocalDateTime.Run();

            //var demoDuration = new DemoDuration();
            //demoDuration.Run();

            //var demoPeriod = new DemoPeriod();
            //demoPeriod.Run();

            Console.ReadKey();
        }
    }
}
