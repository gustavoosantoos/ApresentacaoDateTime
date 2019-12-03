using System;

namespace ApresentacaoDateTime.Default
{
    public class DemoTimeSpan
    {
        public void Run()
        {
            Console.WriteLine("Demo TimeSpan\n\n");

            var localNow = DateTimeOffset.Now;
            var utcNow = DateTimeOffset.UtcNow;

            Console.WriteLine(localNow.TimeOfDay);
            Console.WriteLine(utcNow.TimeOfDay + "\n");

            var time1 = new TimeSpan(19, 30, 00);
            var time2 = new TimeSpan(80, 130, 999);

            Console.WriteLine(time1);
            Console.WriteLine(time2);
        }
    }
}
