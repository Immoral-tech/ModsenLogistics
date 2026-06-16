namespace ModsenLogistics.Tasks.Task4
{
    public class TransportFactory
    {
        public static Transport Create(string type)
        {
            switch (type)
            {
                case "Самолет":
                    return new Plane();
                case "Грузовик":
                    return new Truck();
                case "Поезд":
                    return new Train();
                default: Console.WriteLine("Ошибка");
                    throw new Exception();
            }
        }
    }
}
