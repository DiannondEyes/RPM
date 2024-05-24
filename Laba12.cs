namespace RPM {
    public class Laba12 {
        interface Publishing {
            string? Name {get; set;}
            string? Author {get; set;}

        }

        interface Book<T> : Publishing {
            T? PublishDate {get; set;}
            int? Pages {get; set;}
        }

        class GuideBook<T>(string Name, string Author, int Pages, T PublishDate) : Book<T> {
            public string Name {get; set;} = Name;
            public string Author {get; set;} = Author;
            public T PublishDate {get; set;} = PublishDate;
            public int? Pages {get; set;} = Pages;
        }

        interface User<T> {
            T Login {get; set;}
            string Password {get; set;}
        }

        class ShopUser<T>(T Login, string Password) : User<T> {
            public T Login {get; set;} = Login;
            public string Password {get; set;} = Password;
        }

        class BookUser<T>(string Login, string Password) : User<string>, Book<T> {
            public string Login {get; set;} = Login;
            public string Password {get; set;} = Password;
            public T? PublishDate {get; set;}
            public int? Pages {get; set;}
            public string? Name {get; set;}
            public string? Author {get; set;}

            public void BuyBook(Book<T> book) {
                PublishDate = book.PublishDate;
                Pages = book.Pages;
                Name = book.Name;
                Author = book.Author;
                Console.WriteLine($"Пользователь {Login} купил книгу {Name} автора {Author}.");
            }
        }

        public static void Run() {
            GuideBook<long> BreathingGuide = new("Как правильно дышать", "Василий Пупкин", 50, DateTime.Today.Ticks);
            GuideBook<string> WalkingGuide = new("Как правильно ходить", "Петр Хороший", 200, DateTime.Today.ToLongDateString());

            ShopUser<string> Kolya = new("Kolya", "qwerty");
            ShopUser<int> Petya = new(560, "petya5151");

            BookUser<long> Vasya = new("Vasya123", "qwerty16");
            Vasya.BuyBook(BreathingGuide);
        }
    }
}