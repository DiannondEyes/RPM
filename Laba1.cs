namespace RPM {
    public class Laba1 {
        public static void Run() {
            Console.Write("Введите x: ");
            double x;
            try {
                x = Convert.ToDouble(Console.ReadLine());
                if (x >= -1) throw new Exception();
            } catch {
                Console.WriteLine("Введите число X, который < -1!");
                return;
            }
            Console.Write("Введите конечное значение n: ");

            int n2;
            try {
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 <= 0) throw new Exception();
            } catch {
                Console.WriteLine("Введите положительное число N!");
                return;
            }

            double result = 0;
            for (int n = 0; n <= n2; n++) {
                result += Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
            }
            Console.WriteLine(-Math.PI / 2 + result);
        }
    }
}