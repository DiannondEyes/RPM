namespace RPM {
    public class Animal (string name, string food, string location) {
        public string name = name;
        public string food = food;
        public string location = location;

        public virtual void makeNoise() {
            Console.WriteLine($"{name} спит");
        }
        public virtual void eat() {
            Console.WriteLine($"{name} кушает");
        }
        public virtual void sleep() {
            Console.WriteLine($"{name} спит");
        }
    }

    public class Dog (string name, string food, string location, string breed) : Animal(name, food, location) {
        string breed = breed;
        public override void makeNoise() {
            Console.WriteLine($"{name} гавкает");
        }
        public override void eat() {
            Console.WriteLine($"{name} по-собачьи кушает");
        }
        public override void sleep() {
            Console.WriteLine($"{name} по-собачьи спит");
        }
    }

    public class Cat (string name, string food, string location, string breed) : Animal(name, food, location) {
        string breed = breed;
        public override void makeNoise() {
            Console.WriteLine($"{name} мяукает");
        }
        public override void eat() {
            Console.WriteLine($"{name} по-котячьи кушает");
        }
        public override void sleep() {
            Console.WriteLine($"{name} по-котячьи спит");
        }
    }

    public class Horse (string name, string food, string location) : Animal(name, food, location) {
        public override void makeNoise() {
            Console.WriteLine($"{name} ржёт");
        }
        public override void eat() {
            Console.WriteLine($"{name} по-лошадиному кушает");
        }
        public override void sleep() {
            Console.WriteLine($"{name} по-лошадиному спит");
        }
    }

    public class Vet () {
        public void treatAnimal(Animal animal) {
            Console.WriteLine($"Еда животного: {animal.food}, место: {animal.location}");
        }
    }

    public class Laba5 {
        public static void Run() {
            Cat kitty = new("Комару", "мясо", "дома", "Манчкин");
            Dog dog = new("Рудольф", "корм", "диван", "Бульдог");
            Horse horse = new("Плотва", "сено", "конюшня");
            kitty.eat();
            dog.makeNoise();
            horse.sleep();
            Vet vet = new();
            vet.treatAnimal(kitty);
            vet.treatAnimal(dog);
            vet.treatAnimal(horse);
        }
    }
}