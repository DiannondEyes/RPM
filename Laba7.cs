namespace RPM {

    public class ArrayStorage<T> {
        private List<T> value = [];

        public void AddItem(T item) {
            value.Add(item);
        }

        public void RemoveItem(T item) {
            value.Remove(item);
        }

        public T GetItem(int index) {
            return value[index];
        }

        public int GetLength() {
            return value.Count;
        }
    }
    public class Laba7 {
        public static void Run() {
            ArrayStorage<int> IntList = new();
            IntList.AddItem(45);
            IntList.AddItem(36);
            IntList.AddItem(3664);
            Console.WriteLine("Длина - " + IntList.GetLength());
            Console.WriteLine("Элемент 2 - " + IntList.GetItem(2));
            IntList.RemoveItem(1);

        }
    }
}