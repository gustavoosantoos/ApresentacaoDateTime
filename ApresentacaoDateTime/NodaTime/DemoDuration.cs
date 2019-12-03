using NodaTime;

namespace ApresentacaoDateTime.NodaTime
{
    public class DemoDuration
    {
        public void Run()
        {
            // Objeto específico para uma quantidade de tempo, e não horário
            var duration = Duration.FromDays(13);
            System.Console.WriteLine(duration);

            var duration2 = Duration.FromMinutes(32);
            var duration3 = duration.Plus(duration2);
            System.Console.WriteLine(duration3);
        }
    }
}
