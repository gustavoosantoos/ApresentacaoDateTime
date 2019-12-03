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
        }
    }
}
