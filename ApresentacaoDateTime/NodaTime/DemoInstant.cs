using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentacaoDateTime.NodaTime
{
    public class DemoInstant
    {
        public void Run()
        {
            Console.WriteLine("Demo Instant\n\n");

            var now = SystemClock.Instance.GetCurrentInstant();

            // O PADRÃO é UTC
            Console.WriteLine("Now padrão: " + now);
            Console.WriteLine("Now UTC: " + now.InUtc());

            //// A conversão é possível com o offset em horas
            //var timezone = DateTimeZone.ForOffset(Offset.FromHours(-5));

            //// Pegando a timezone do sistema
            //var timezone2 = DateTimeZoneProviders.Tzdb.GetSystemDefault();

            //// Ou com o ID do fuso horário
            //var timezone3 = DateTimeZoneProviders.Tzdb.GetZoneOrNull("US/Pacific");

            //var nowMinus5 = now.InZone(timezone);
            //var nowSystem = now.InZone(timezone2);
            //var nowId = now.InZone(timezone3);

            //Console.WriteLine("Now -5: " + nowMinus5);
            //Console.WriteLine("Now system: " + nowSystem);
            //Console.WriteLine("Now by id: " + nowId);
        }
    }
}
