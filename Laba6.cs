namespace RPM {
    abstract class Transport (int speed, int capacity, int distance) {
        public int speed = speed;
        public int capacity = capacity;
        public int distance = distance;

        public abstract override string ToString();
    }


    abstract class Automobile(int speed, int capacity, int distance) : Transport(speed, capacity, distance) {
        public override string ToString() {
            return $"Автомобиль со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может проехать: {distance}";
        }
        
        public abstract void Crash();
        public abstract void Drive();
    }

    abstract class Plane(int speed, int capacity, int distance) : Transport(speed, capacity, distance) {
        public override string ToString() {
            return $"Самолет со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может пролететь: {distance}";
        }

        public abstract void Fall();
        public abstract void Fly();
    }
    
    abstract class Ship(int speed, int capacity, int distance) : Transport(speed, capacity, distance) {
        public override string ToString() {
            return $"Корабль со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может проплыть: {distance}";
        }

        public abstract void Drown();
        public abstract void Sail();
    }

    class Juke(int speed, int capacity, int distance) : Automobile(speed, capacity, distance) {
        public override string ToString() {
            return $"Nissan Juke со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может проехать: {distance}";
        }

        public override void Crash() {
            Console.WriteLine("Nissan Juke врезался");
        }

        public override void Drive() {
            Console.WriteLine("Nissan Juke едет");
        }
    }

    class FlyingTank(int speed, int capacity, int distance) : Plane(speed, capacity, distance) {
        public override string ToString() {
            return $"Летающий танк со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может пролететь: {distance}";
        }

        public override void Fall() {
            Console.WriteLine("Летающий танк падает!");
        }

        public override void Fly() {
            Console.WriteLine("Летающий танк летит");
        }
    }

    class BedaKapitan(int speed, int capacity, int distance) : Ship(speed, capacity, distance) {
        public override string ToString() {
            return $"Корабль \"Беда, капитан!\" со скоростью {speed}, грузоподъемностью {capacity}. Дальность расстояния, которое он может проплыть: {distance}";
        }

        public override void Drown() {
            Console.WriteLine("Корабль \"Беда, капитан!\" тонет");
        }

        public override void Sail() {
            Console.WriteLine("Корабль \"Беда, капитан!\" плывет");
        }
    }

    public class Laba6 {
        public static void Run() {
            Console.WriteLine(new Juke(150, 1000, 10000));
            Console.WriteLine(new FlyingTank(300, 7000, 900000));
            Console.WriteLine(new BedaKapitan(70, 100000, 1000000));
        }
    }

}