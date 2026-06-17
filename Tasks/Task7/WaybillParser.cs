using ModsenLogistics.Exceptions;
using System.Globalization;

namespace ModsenLogistics.Tasks.Task7
{
    public class WaybillParser
    {
        public static Waybill Parse(string input)
        {
            // Проверка входной строки
            if (input == null)
            {
                throw new WaybillParseException("Строка накладной равна null");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new WaybillParseException("Строка накладной пуста или состоит только из пробелов");
            }

            // Разбивка строки
            string[] parts = input.Split(';');

            if (parts.Length != 4)
            {
                throw new WaybillParseException(
                    $"Некорректный формат: ожидается 4 поля, получено {parts.Length}"
                );
            }

            // Очистка полей от пробелов
            string idStr = parts[0].Trim();
            string nameStr = parts[1].Trim();
            string quantityStr = parts[2].Trim();
            string weightStr = parts[3].Trim();

            // Проверка, что поля не пустые
            if (string.IsNullOrEmpty(idStr))
            {
                throw new WaybillParseException("Поле 'ID_Груза' пусто");
            }

            if (string.IsNullOrEmpty(nameStr))
            {
                throw new WaybillParseException("Поле 'Название' пусто");
            }

            if (string.IsNullOrEmpty(quantityStr))
            {
                throw new WaybillParseException("Поле 'Количество' пусто");
            }

            if (string.IsNullOrEmpty(weightStr))
            {
                throw new WaybillParseException("Поле 'Вес' пусто");
            }

            // Парсинг ID
            if (!int.TryParse(idStr, out int id))
            {
                throw new WaybillParseException(
                    $"Поле 'ID_Груза' содержит нечисловое значение: '{idStr}'"
                );
            }

            // Парсинг Количества
            if (!int.TryParse(quantityStr, out int quantity))
            {
                throw new WaybillParseException(
                    $"Поле 'Количество' содержит нечисловое значение: '{quantityStr}'"
                );
            }

            // Парсинг Веса (с учетом культуры)
            if (!double.TryParse(weightStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double weight))
            {
                throw new WaybillParseException(
                    $"Поле 'Вес' содержит нечисловое значение: '{weightStr}'"
                );
            }

            // Дополнительные проверки (опционально)
            if (id < 0)
            {
                throw new WaybillParseException(
                    $"Поле 'ID_Груза' не может быть отрицательным: {id}"
                );
            }

            if (quantity < 0)
            {
                throw new WaybillParseException(
                    $"Поле 'Количество' не может быть отрицательным: {quantity}"
                );
            }

            if (weight < 0)
            {
                throw new WaybillParseException(
                    $"Поле 'Вес' не может быть отрицательным: {weight}"
                );
            }

            // Создание и возврат объекта
            return new Waybill
            {
                Id = id,
                Name = nameStr,
                Quantity = quantity,
                Weight = weight
            };
        }
    }
}
