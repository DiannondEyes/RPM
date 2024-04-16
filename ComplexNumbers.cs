using System.Numerics;
using System.Text.RegularExpressions;

namespace RPM {
    public class ComplexNumber {
        int firstnumber;
        int secondnumber;

        public ComplexNumber(string value) {
            if (!Regex.IsMatch(value, @"-?\d+[\+-]\d+i")) {
                throw new ArgumentException("Не является комплексным числом");
            }
            if (value.LastIndexOf('-') > 0) {
                firstnumber = Convert.ToInt32(value[..value.LastIndexOf('-')]);
                secondnumber = Convert.ToInt32(value[value.LastIndexOf('-')..(value.Length - 1)]);
            }
            else {
                firstnumber = Convert.ToInt32(value[..value.IndexOf('+')]);
                secondnumber = Convert.ToInt32(value[(value.IndexOf('+') + 1)..(value.Length - 1)]);
            }
        }
        // public static implicit operator ComplexNumber(string value) {
        //     return new ComplexNumber(value);
        // }

        public override string ToString() {
            return $"{firstnumber}{(secondnumber > 0 ? '+' : "")}{secondnumber}i";
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
            int secondsum = a.secondnumber + b.secondnumber;
            return new ComplexNumber($"{a.firstnumber + b.firstnumber}{(secondsum > 0 ? '+' : "")}{secondsum}i");
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) {
            int secondsub = a.secondnumber - b.secondnumber;
            return new ComplexNumber($"{a.firstnumber - b.firstnumber}{(secondsub > 0 ? '+' : "")}{secondsub}i");
        }
    }

    public class ComplexNumberUsage {
        public static void Run() {
            Console.WriteLine(new ComplexNumber("2+4i"));
            Console.WriteLine(new ComplexNumber("234+4213i"));
            Console.WriteLine(new ComplexNumber("-45+3i"));
            Console.WriteLine(new ComplexNumber("-57-2i"));
            Console.WriteLine(new ComplexNumber("2-5i"));
            Console.WriteLine(new ComplexNumber("1+2i") + new ComplexNumber("2+3i"));
            Console.WriteLine(new ComplexNumber("-45+3i") + new ComplexNumber("2-5i"));

            Console.Write("Введите комплексное число для проверки на правильность: ");
            try {
                string input = Console.ReadLine() ?? "";
                Console.WriteLine("Число верное: " + new ComplexNumber(input));
            }
            catch (ArgumentException) {
                Console.WriteLine("Число неверное!");
            }
        }
    }
}