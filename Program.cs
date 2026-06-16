using ModsenLogistics.Tasks.Task1;
using ModsenLogistics.Tasks.Task2;
using ModsenLogistics.Tasks.Task3;
using ModsenLogistics.Tasks.Task4;

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
        }
    }
}

