namespace RPM {
    public class CalcSqrt {
        public static void Run() {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = m; i <= n; i++) {
                if (Math.Sqrt(i) % 1 == 0) Console.WriteLine($"{i}^√{i} = {i}^{Math.Sqrt(i)} = {Math.Pow(i, Math.Sqrt(i))}");
            }
        }
    }
    
}