
namespace RPM {

    public class Car {
        public string model;
        
        public Car(string model) {
            this.model = model;
        }
    }

    public class Garage {
        public List<Car> cars = [];
    }

    public class Laba9 {

        public delegate void CarWasher(Car car);

        public static void Wash(Car car) {
            Console.WriteLine($"{car.model} помылся");
        }

        public static void Run() {
            CarWasher washer = Wash;
            Garage garage = new();
            garage.cars.AddRange([
                new Car("TOYOTA OPA"),
                new Car("KIA Cerato"),
                new Car("Proton Perdana"),
                new Car("VOLKSWAGEN PASSAT")
            ]);

            foreach (Car car in garage.cars) {
                washer(car);
            }
        }
    }
}