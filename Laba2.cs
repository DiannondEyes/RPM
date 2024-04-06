namespace RPM {
    public class Laba2 {

        public enum Weekday {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        public enum TimeOfDay {
            Утро = 7,
            День = 13,
            Вечер = 19,
            Ночь = 0
        }
        
        public static void Run() {
            Console.Write("Введите день недели цифрой (1-7): ");
            string? day = Enum.GetName(typeof(Weekday), Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите час (0-23): ");
            int? hour = Convert.ToInt32(Console.ReadLine());
            if (hour >= (int)TimeOfDay.Утро && hour < (int)TimeOfDay.День)
                hour = 7;
            else if (hour >= (int)TimeOfDay.День && hour < (int)TimeOfDay.Вечер)
                hour = 13;
            else if (hour >= (int)TimeOfDay.Вечер || hour < (int)TimeOfDay.Утро)
                hour = 19;
            else hour = 0;
            
            Console.WriteLine($"Сейчас {day ?? "неверный день недели"}, {Enum.GetName(typeof(TimeOfDay), hour)}");
        }
    }
}