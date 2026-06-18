using ModsenLogistics.Tasks.Task1;
using ModsenLogistics.Tasks.Task2;
using ModsenLogistics.Tasks.Task3;
using ModsenLogistics.Tasks.Task4;
using ModsenLogistics.Tasks.Task5;
using ModsenLogistics.Tasks.Task6;
using ModsenLogistics.Tasks.Task7;
using System;
using System.Collections.Generic;

namespace ModsenLogistics
{
    class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                // Выполнение задачи 1. Расчет стоимости доставки.
                // Индивидуальное задание: Метод принимает bool isNight. Если доставка ночная, базовая ставка удваивается, но экспресс-коэффициент снижается до стандартного.
                Console.WriteLine("Задача 1. Расчет стоимости доставки.");
                try
                {
                    Console.WriteLine(DeliveryCalculator.СalculateDeliveryCost(10, 5, true, "Express"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при расчете стоимости доставки: {ex.Message}");
                }

                // Выполнение задачи 2. Оптимальное размещение груза.
                // Индивидуальное задание: Отсутсвует.
                Console.WriteLine("Задача 2. Оптимальное размещение груза.");
                try
                {
                    Console.WriteLine(ContainerCalculator.GetRequiredContainers([10, 5, 7, 10, 12], 20));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при расчете контейнеров: {ex.Message}");
                }

                // Выполнение задачи 3. Модель "Умный Контейнер"
                // Индивидуальное задание: Отсутствует.
                Console.WriteLine("Задача 3. Модель Умный Контейнер");
                try
                {
                    SmartContainer container = new SmartContainer("1", 100);
                    Console.WriteLine(container.Status);
                    container.LoadCargo(100);
                    Console.WriteLine(container.Status);
                    Console.WriteLine(container.CurrentVolume);
                    container.UnloadCargo(40);
                    Console.WriteLine(container.Status);
                    Console.WriteLine(container.CurrentVolume);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при работе с контейнером: {ex.Message}");
                }

                // Выполнение задачи 4. Система тарифов (Наследование и Полиморфизм)
                // Индивидуальное задание: Создать класс TransportFactory, который создает нужный объект (Truck/Plane) на основе переданной строки.
                double distance = 1000;
                try
                {
                    Console.WriteLine(TransportFactory.Create("Поезд").CalculateTime(distance));
                    Console.WriteLine(TransportFactory.Create("Самолет").CalculateTime(distance));
                    Console.WriteLine(TransportFactory.Create("Грузовик").CalculateTime(distance));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка при создании транспорта: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка в задаче 4: {ex.Message}");
                }

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
                try
                {
                    var result = VehicleStatisticsService.GetValues(vehicles);
                    foreach (var item in result)
                    {
                        Console.WriteLine($"Категория: {item.Key}, Средний расход: {item.Value:F2} л/100км");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при аналитике автопарка: {ex.Message}");
                }

                // Выполнение задачи 6. Очередь на разгрузку (Коллекции Queue / PriorityQueue)
                // Индивидуальное задание: В Задаче 6 очередь должна быть реализована с использованием потокобезопасных коллекций (ConcurrentQueue).
                var Dock1 = new WarehouseDock();
                try
                {
                    Dock1.RegisterTruck("hejrtrw", 1);
                    Dock1.RegisterTruck("4326", 3);
                    Dock1.RegisterTruck("31251235613", 1);
                    Dock1.RegisterTruck("12516t678", 3);
                    Dock1.RegisterTruck("12445", 2);
                    Dock1.ProcessNextTruck();
                    Dock1.ProcessNextTruck();
                    Dock1.ProcessNextTruck();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при работе с очередью: {ex.Message}");
                }

                // Выполнение задачи 7. Парсер накладных (Строки и Exception Handling)
                // Индивидуальное задание: Отсутствует.
                try
                {
                    TestWaybillParser.Test();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при парсинге накладных: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Критическая ошибка в программе: {ex.Message}");
                Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}