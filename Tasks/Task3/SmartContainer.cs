using ModsenLogistics.Enums;

namespace ModsenLogistics.Tasks.Task3
{
    // Создание класса SmartContainer
    public class SmartContainer
    {
        public string Id { get; }
        public double VolumeCapacity { get; }
        public double CurrentVolume { get; private set; }


        // Автоматическое определине статуса контейнера
        public Status Status
        {
            get
            {
                if (CurrentVolume == 0)
                {
                    return Status.Empty;
                }
                else if (CurrentVolume >= VolumeCapacity)
                {
                    return Status.Full;
                }
                else
                {
                    return Status.PartiallyFilled;
                }
            }
        }


        // Конструктов класса
        public SmartContainer(string id, double volumeCapacity)
        {
            Id = id;
            VolumeCapacity = volumeCapacity;
            CurrentVolume = 0;
        }


        // Метод для загрузки контейнера
        public void LoadCargo(double volume)
        {
            if (CurrentVolume + volume <= VolumeCapacity)
            {
                CurrentVolume += volume;
            }
            else
            {
                throw new InvalidOperationException("Загружаемый объем больше допустимого");
            }
        }


        // Метод для выгрузки контейнера
        public double UnloadCargo(double volume)
        {
            if (CurrentVolume > volume)
            {
                CurrentVolume -= volume;
                return volume;
            }
            else
            {
                throw new InvalidOperationException("Выгружаемый объем больше допустимого");
            }
        }
    }
}

