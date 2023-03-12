using System;
using System.IO;
using System.Text.Json;

namespace TMSLesson13
{
    internal class Program
    {
        delegate void WeatherHandler();
        static event WeatherHandler? Notify;

        static void Main(string[] args)
        {
            //task1
            int index = 1;

            DayOfWeekDelegate dayOfWeek = delegate
            {
                if (index == 7) index = 0;
                var k = Enum.GetValues(typeof(DayOfWeek));
                return k.GetValue(index++).ToString();
            };

            Console.WriteLine(dayOfWeek());
            Console.WriteLine(dayOfWeek());
            Console.WriteLine(dayOfWeek());

            //task2
            Console.WriteLine();
            
            void ShowWeather()
            {
                string[] weatherArray = { "Rainy", "Sunny", "Windy", "Hot", "Cloudy", "Foggy" };
                Random rnd = new Random();
                Console.WriteLine(weatherArray[rnd.Next(6)]);
            }

            Notify += ShowWeather;

            Console.WriteLine(dayOfWeek());
            Notify?.Invoke();
            Console.WriteLine(dayOfWeek());
            Notify?.Invoke();

            //task3
            Console.WriteLine();

            using (var fs = new FileStream("squad.json", FileMode.OpenOrCreate))
            {
                var squad = JsonSerializer.Deserialize<Squad>(fs);
                Console.WriteLine($"Название команды: {squad?.SquadName}\nКоличество участников:{squad?.Members.Length}");
            }
        }
    }
}
