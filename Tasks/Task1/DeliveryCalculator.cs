namespace ModsenLogistics.Tasks.Task1
{
    internal class DeliveryCalculator
    {
        // Подсчет итоговой стоимости доставки
        public static decimal СalculateDeliveryCost(double distance, double weight, bool isNight, string DeliveryType)
        {

            return (CalculatePrice(distance, weight) + IsNight(isNight)) * ChoiceType(DeliveryType, isNight);
        }


        // Метод для расчета стоимости по расстоянию и весу груза
        static decimal CalculatePrice(double distance, double weight)
        {
            if (distance <= 0 || weight <= 0)
            {
                throw new ArgumentException("Расстояние или вес меньше нуля");
            }
            else
            {
                return ((decimal)distance * 0.5m) + ((decimal)weight * 2m);
            }
        }


        // Метод для выбора типа доставки (расчет коэффициента)
        static decimal ChoiceType(string DeliveryType, bool isNight)
        {
            switch (DeliveryType)
            {
                case "Standart":
                    return 1m;
                case "Express":
                    // Проверка для ночного тарифа
                    if (isNight)
                    {
                        return 1m;
                    }
                    else
                    {
                        return 1.5m;
                    }
                case "Overnight":
                    return 2m;
                default:
                    throw new ArgumentException("Неверное значение типа");
            }
        }


        // Метод для проверки на ночную доставку (расчет базовой ставки)
        static decimal IsNight(bool isNight)
        {
            const decimal BasicPrice = 10m;

            if (isNight == true)
            {
                return BasicPrice * 2m;
            }
            else
            {
                return BasicPrice;
            }
        }
    }
}

