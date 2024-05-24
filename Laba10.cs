namespace RPM {
    public class ClassWithEvent(string EventString)
    {
        public event Laba10.StringDelegate? StringEvent;
        public string EventString = EventString;

        public void GenerateEvent() {
            StringEvent?.Invoke(EventString);
        }
    }
    public class Laba10 {
        public delegate void StringDelegate(string EventString);
        public static void Run() {
            Handler EventHandler = new();
            ClassWithEvent ObjectOfClassWithEvent = new("Первый объект класса с событием");
            ClassWithEvent SecondObjectOfClassWithEvent = new("Второй объект класса с событием");
            ObjectOfClassWithEvent.StringEvent += EventHandler.StringEventHandler;
            SecondObjectOfClassWithEvent.StringEvent += EventHandler.StringEventHandler;
            ObjectOfClassWithEvent.GenerateEvent();
            SecondObjectOfClassWithEvent.GenerateEvent();
        }
    }
    public class Handler {
        public void StringEventHandler(string EventString) {
            Console.WriteLine($"Строка события: {EventString}");
            Console.WriteLine("Вызвано событие!");
        }
    }
}