using ModsenLogistics.Tasks.Task1;
using ModsenLogistics.Tasks.Task2;
using ModsenLogistics.Tasks.Task3;
using ModsenLogistics.Tasks.Task4;
using ModsenLogistics.Tasks.Task5;
using ModsenLogistics.Tasks.Task6;


namespace ModsenLogistics
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Выполнение задачи 1. Расчет стоимости доставки.
            // Индивидуальное задание: Метод принимает bool isNight. Если доставка ночная, базовая ставка удваивается, но экспресс-коэффициент снижается до стандартного.
            Console.WriteLine("Задача 1. Расчет стоимости доставки.");
            Console.WriteLine(DeliveryCalculator.СalculateDeliveryCost(10, 5, true, "Express"));

            // Выполнение задачи 2. Оптимальное размещение груза.
            // Индивидуальное задание: отсутсвует.
            Console.WriteLine("Задача 2. Оптимальное размещение груза.");
            Console.WriteLine(ContainerCalculator.GetRequiredContainers([10, 5, 7, 10, 12], 20));

            // Выполнение задачи 3. Модель "Умный Контейнер"
            // Индивидуальное задание: отсутствует.
            Console.WriteLine("Задача 3. Модель Умный Контейнер");
            SmartContainer container = new SmartContainer("1", 100);
            Console.WriteLine(container.Status);
            container.LoadCargo(100);
            Console.WriteLine(container.Status);
            Console.WriteLine(container.CurrentVolume);
            container.UnloadCargo(40);
            Console.WriteLine(container.Status);
            Console.WriteLine(container.CurrentVolume);

            // Выполнение задачи 4. Система тарифов (Наследование и Полиморфизм)
            // Индивидуальное задание: Создать класс TransportFactory, который создает нужный объект (Truck/Plane) на основе переданной строки.
            double distance = 1000;
            Console.WriteLine(TransportFactory.Create("Поезд").CalculateTime(distance));
            Console.WriteLine(TransportFactory.Create("Самолет").CalculateTime(distance));
            Console.WriteLine(TransportFactory.Create("Грузовик").CalculateTime(distance));

            // Выполнение задачи 5. Аналитика автопарка (LINQ)
            // Индивидуальное задание: Отсутсвтует.
            var vehicles = new List<Vehicle>
        {
            new Vehicle("A123BC", "Sedan", 8.5, 60000),
            new Vehicle("B456DE", "Sedan", 7.8, 45000),
            new Vehicle("C789FG", "SUV", 12.3, 70000),
            new Vehicle("D012HI", "SUV", 14.1, 80000),
            new Vehicle("E345JK", "Truck", 15.2, 90000)
        };
            var result = VehicleStatisticsService.GetValues(vehicles);
            foreach (var item in result)
            {
                Console.WriteLine($"Категория: {item.Key}, Средний расход: {item.Value:F2} л/100км");
            }

            // Выполнение задачи 6. Очередь на разгрузку (Коллекции Queue / PriorityQueue)
            // Индивидуальное задание: В Задаче 6 очередь должна быть реализована с использованием потокобезопасных коллекций (ConcurrentQueue).
            var Dock1 = new WarehouseDock();
            Dock1.RegisterTruck("hejrtrw", 1);
            Dock1.RegisterTruck("4326", 3);
            Dock1.RegisterTruck("31251235613", 1);
            Dock1.RegisterTruck("12516t678", 3);
            Dock1.RegisterTruck("12445", 2);
            Dock1.ProcessNextTruck();
            Dock1.ProcessNextTruck();
            Dock1.ProcessNextTruck();
        }
    }
}

