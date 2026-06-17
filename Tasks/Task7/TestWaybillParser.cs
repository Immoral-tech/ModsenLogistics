using ModsenLogistics.Exceptions;
namespace ModsenLogistics.Tasks.Task7
{
    public class TestWaybillParser
    {

        public static void Test()
        {
            // Тест 1: Корректная строка
            Console.WriteLine("Тест 1: Корректные данные");
            try
            {
                string validInput = "1024;Трубы стальные;50;1200.5";
                Waybill waybill = WaybillParser.Parse(validInput);
                Console.WriteLine($"Успешно спарсено: {waybill}");
                Console.WriteLine();
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Тест 2: Пустая строка
            Console.WriteLine("Тест 2: Пустая строка");
            try
            {
                string emptyInput = "";
                WaybillParser.Parse(emptyInput);
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 3: Неверное количество полей
            Console.WriteLine("Тест 3: Неверное количество полей");
            try
            {
                string invalidCount = "1024;Трубы стальные;50";
                WaybillParser.Parse(invalidCount);
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 4: Нечисловое значение в Количестве
            Console.WriteLine("Тест 4: Нечисловое значение в Количестве");
            try
            {
                string invalidQuantity = "1024;Трубы стальные;пятьдесят;1200.5";
                WaybillParser.Parse(invalidQuantity);
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 5: Нечисловое значение в Весе
            Console.WriteLine("Тест 5: Вес с запятой вместо точки");
            try
            {
                string russianWeight = "1024;Трубы стальные;50;1200,5";
                Waybill waybill = WaybillParser.Parse(russianWeight);
                Console.WriteLine($"Успешно спарсено: {waybill}");
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 6: Вес с пробелами
            Console.WriteLine("Тест 6: Вес с пробелами");
            try
            {
                string withSpaces = " 1024 ; Трубы стальные ; 50 ; 1200.5 ";
                Waybill waybill = WaybillParser.Parse(withSpaces);
                Console.WriteLine($"Успешно спарсено: {waybill}");
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 7: Отрицательное количество
            Console.WriteLine("Тест 7: Отрицательное количество");
            try
            {
                string negative = "1024;Трубы стальные;-50;1200.5";
                WaybillParser.Parse(negative);
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine();

            // Тест 8: null строка
            Console.WriteLine("Тест 8: null строка");
            try
            {
                WaybillParser.Parse(null);
            }
            catch (WaybillParseException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
