namespace RPM {

    public class Train (string EndPointName, int number, DateTime DepartureTime) {
        public string EndPointName = EndPointName;
        public int number = number;
        public DateTime DepartureTime = DepartureTime;

        public override string ToString() {
            return $"Поезд {number} в {EndPointName} отправляется в {DepartureTime:HH:mm}";
        }
    }
    public class TrainUsage {
        public static void Run() {
            Train[] trains = [
                new Train("Пенза", 70, DateTime.Parse("12:00")),
                new Train("Москва", 65, DateTime.Parse("15:30")),
                new Train("ПКИПТ", 23, DateTime.Parse("7:00")),
                new Train("Магазин за гаражом", 54, DateTime.Parse("15:30")),
                new Train("Марс", 17, DateTime.Parse("18:30")),
                new Train("Марс", 17, DateTime.Parse("15:30")),
            ];

            trains = trains.OrderBy(s => s.number).ToArray();
            Console.WriteLine("Отсортировал по номеру поездов:");
            foreach (Train t in trains) {
                Console.WriteLine(t);
            }

            trains = trains.OrderBy(s => s.EndPointName).ThenBy(s => s.DepartureTime).ToArray();
            Console.WriteLine("\nОтсортировал по пункту назначения и по времени отправления:");
            foreach (Train t in trains) {
                Console.WriteLine(t);
            }

            Console.Write("Введите номер поезда для просмотра информации (1-6): ");
            int train = Convert.ToInt32(Console.ReadLine());
            if (train < 1 || train > 6) {
                Console.WriteLine("Неверный номер поезда!");
                return;
            }
            Console.WriteLine(trains[train-1]);
        }
    }
}