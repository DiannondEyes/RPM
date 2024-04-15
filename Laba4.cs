using ReaderNS;

namespace StudentNS {
    public class Student (string name, int group, int age) {
        string name = name;
        int group = group;
        private int age = age;

        public override string ToString() {
            return $"Студент {name} возрастом {age} из группы {group}";
        }
    }
}

namespace ReaderNS {
    public class Reader (string name, int ticket, string faculty, DateOnly birthdate, string phone) {
        private string name = name;
        int ticket = ticket;
        string faculty = faculty;
        private DateOnly birthdate = birthdate;
        string phone = phone;

        public void takeBook(int books) {
            Console.WriteLine($"{name} взял {books} книг");
        }
        
        public void takeBook(params string[] books) {
            Console.WriteLine($"{name} взял книги: " + string.Join(", ", books));
        }

        public void returnBook(int books) {
            Console.WriteLine($"{name} вернул {books} книг");
        }

        public void returnBook(params string[] books) {
            Console.WriteLine($"{name} вернул книги: " + string.Join(", ", books));
        }
    }
}

namespace RPM {
    public class Laba4 {
        public static void Run() {
            StudentNS.Student[] students = [new ("Григорий Стоматолог", 404, 19),
                                            new ("Леонид Клавишник", 88, 21),
                                            new ("Валентина Космосовна", 1969, 22)
                                           ];
            Reader[] readers = [new ("Василий Пупкин", 44543, "Факультет прикольной истории", DateOnly.FromDateTime(DateTime.Now), "+17476849302"),
                                new ("Петя Иванов", 34982, "Факультет чародейства \"Хогвардс\"", DateOnly.FromDateTime(DateTime.Now), "+238420838"),
                                new ("Олег Лордозавр", 12345, "Факультет динозаврологии", DateOnly.FromDateTime(DateTime.Parse("1800-12-12")), "+79221234567"),
                               ];
            
            foreach (StudentNS.Student st in students) Console.WriteLine(st);
            readers[0].takeBook("Словарь", "Азбука");
            readers[1].returnBook(3517);
            readers[2].returnBook("Всё про космос", "Как оживить динозавров", "Как стать самым крутым во 2 классе");
        }
    }
}