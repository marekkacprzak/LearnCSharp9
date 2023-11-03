using System;

namespace Learn90.InitOnlySetters
{
    public class Init_only_setters
    {
        public static void Test()
        {
            var now = new WeatherObservation 
            { 
                RecordedAt = DateTime.Now, 
                TemperatureInCelsius = 20, 
                PressureInMillibars = 998.0m 
            };
            //now.RecordedAt= DateTime.Now //Error
            Console.WriteLine($"{now.RecordedAt}, {now.RecordedAt}, {now.PressureInMillibars}");
        }
        public struct WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
        }
    }
}