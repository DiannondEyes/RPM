namespace RPM {

    public struct Student() {
        public string name;
        public int group;
        public int[] grades;

        public double Average() {return grades.Average(); }
        public override string ToString()
        {
            return $"{name} из группы {group} со средним баллом {Average()}";
        }

    }
    public class Laba3 {
        public static void Run() {
            Student[] students = [
                new() { name = "Иван", group = 1, grades = [4, 5, 5, 3, 2] },
                new() { name = "Александра", group = 1, grades = [5, 5, 4, 4, 5] },
                new() { name = "Петр", group = 2, grades = [3, 3, 4, 2, 4] },
                new() { name = "Мария", group = 2, grades = [5, 5, 5, 5, 5] },
                new() { name = "Дмитрий", group = 3, grades = [2, 3, 3, 4, 4] },
                new() { name = "Елизавета", group = 3, grades = [4, 4, 4, 4, 4] },
                new() { name = "Анна", group = 4, grades = [5, 4, 5, 4, 5] }
            ];

            students = students.OrderByDescending(s => s.Average()).ToArray();

            foreach (Student st in students) {
                Console.WriteLine(st);
            }
        }
    }
}