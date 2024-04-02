namespace RPM {
    public class Laba2 {
        public static void Run() {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= -1) {
                Console.WriteLine("X должен быть < -1");
                return;
            }
            Console.Write("Введите конечное значение n: ");

            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 <= 0) {
                Console.WriteLine("N должен быть положительным");
                return;
            }

            double result = 0;
            for (int n = 0; n <= n2; n++) {
                result += Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
            }
            Console.WriteLine(-Math.PI/2 + result);
        }
    }
}