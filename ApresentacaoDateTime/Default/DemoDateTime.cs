using System;

namespace ApresentacaoDateTime.Default
{
    public class DemoDateTime
    {
        public void Run()
        {
            var localNow = DateTime.Now;
            var utcNow = DateTime.UtcNow;

            Console.WriteLine("Demo DateTime");
            Console.WriteLine("LOCAL: " + localNow + " " + localNow.Kind);
            Console.WriteLine("UTC: " + utcNow + " " + utcNow.Kind);

            //var d1 = new DateTime(2019, 1, 1);
            //var d2 = new DateTime(2019, 2, 1);

            //Console.WriteLine(d1.AddMonths(1));
            //Console.WriteLine(d2.AddMonths(1));
        }
    }
}
