using System;

namespace ApresentacaoDateTime.Default
{
    public class DemoDateTimeOffset
    {
        public void Run()
        {
            var localNow = DateTimeOffset.Now;
            var utcNow = DateTimeOffset.UtcNow;

            Console.WriteLine("Demo DateTimeOffset\n\n");
            
            // Agora temos a timezone
            Console.WriteLine("LOCAL: " + localNow + " " + localNow.Offset);
            Console.WriteLine("UTC: " + utcNow + " " + utcNow.Offset + "\n");

            // A conversão também funciona bem
            Console.WriteLine("LOCAL FROM LOCAL: " + localNow.ToLocalTime());
            Console.WriteLine("LOCAL FROM UTC: " + utcNow.ToLocalTime() + "\n");

            // Podemos converter para uma timezone específica (mostrar para o usuário final)
            var localToSpecific = localNow.ToOffset(new TimeSpan(-2, 0, 0));
            var utcToSpecific = utcNow.ToOffset(new TimeSpan(-2, 0, 0));

            Console.WriteLine("LOCAL TO SPECIFIC: " + localToSpecific);
            Console.WriteLine("UTC TO SPECIFIC: " + utcToSpecific + "\n");
        }
    }
}
