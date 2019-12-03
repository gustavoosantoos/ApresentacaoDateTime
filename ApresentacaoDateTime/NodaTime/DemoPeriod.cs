using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApresentacaoDateTime.NodaTime
{
    public class DemoPeriod
    {
        public void Run()
        {
            var period = Period.FromMonths(1);

            var january = new LocalDate(2019, 1, 1);
            var february = new LocalDate(2019, 2, 1);

            // 1 mês representou valores diferentes para cada uma das datas
            Console.WriteLine(january.Plus(period));
            Console.WriteLine(february.Plus(period));
        }
    }
}
