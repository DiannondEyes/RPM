namespace RPM {
    public class Laba11 {
        static int CurrentWeekday = -1;
        public delegate string NextWeekday();
        enum Weekdays { Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье }

        public static void Run() {
            NextWeekday GetNextWeekday = () => {
                CurrentWeekday = (CurrentWeekday + 1) % 7;
                return Enum.GetName(typeof(Weekdays), CurrentWeekday)!;
            };

            for (int _ = 0; _ < 10; _++) Console.WriteLine(GetNextWeekday());
        }
    }
}