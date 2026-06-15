namespace ModsenLogistics.Tasks.Task2
{
    internal class ContainerCalculator
    {
        // Метод для нахождения оптимального количество коробок
        public static int GetRequiredContainers(int[] boxWeights, int maxCapacity)
        {
            int quantity = 1;
            int temp = 0;

            for (int i = 0; i < boxWeights.Length; i++)
            {
                // Проверка на допустимый вес коробки
                if (boxWeights[i] < maxCapacity)
                {
                    if (temp + boxWeights[i] > maxCapacity)
                    {
                        quantity++;
                        temp = boxWeights[i];
                    }
                    else
                    {
                        temp += boxWeights[i];
                    }
                }
                else
                {
                    throw new ArgumentException("Вес одной коробки превышает допустимый");
                }
            }
            return quantity;
        }
    }
}

