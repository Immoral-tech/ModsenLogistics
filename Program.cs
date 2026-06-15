using ModsenLogistics.Tasks.Task1;
using ModsenLogistics.Tasks.Task2;

namespace TestTask
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

        }
    }
}

