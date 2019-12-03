using NodaTime;
using System;

namespace ApresentacaoDateTime.NodaTime
{
    public class DemoLocalDateTime
    {
        public void Run()
        {
            // Ponto no tempo sem informação de fuso por padrão
            var datetime = new LocalDateTime(2019, 12, 5, 10, 32).WithOffset(Offset.FromHours(-3));
            Console.WriteLine(datetime);
            Console.WriteLine(datetime.ToInstant());

            // Somente data
            var date = datetime.Date;
            Console.WriteLine(date);
            Console.WriteLine(date.ToString("dd/MM/yyyy", null));

            // Somente horario
            var time = datetime.TimeOfDay;
            Console.WriteLine(time);

            //var time2 = new LocalTime(50, 30, 900);
            //Console.WriteLine(time2);
        }
    }
}
