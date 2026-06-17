using System.Collections.Concurrent;

namespace ModsenLogistics.Tasks.Task6
{
    public class WarehouseDock
    {
        public ConcurrentQueue<string> firstQueue = new ConcurrentQueue<string>();
        public ConcurrentQueue<string> secondQueue = new ConcurrentQueue<string>();
        public ConcurrentQueue<string> thirdQueue = new ConcurrentQueue<string>();

        public void RegisterTruck(string Plate, int priority)
        {
            switch (priority)
            {
                case 1:
                    firstQueue.Enqueue(Plate);
                    break;
                case 2:
                    secondQueue.Enqueue(Plate);
                    break;
                case 3:
                    thirdQueue.Enqueue(Plate);
                    break;
                default:
                    throw new Exception("Ошибка!");
            }
        }

        public void ProcessNextTruck()
        {
            if (thirdQueue.Count != 0)
            {
                thirdQueue.TryDequeue(out string? result);
                    Console.WriteLine(result);
            }
            else if (secondQueue.Count != 0)
            {
                secondQueue.TryDequeue(out string? result);
                Console.WriteLine(result);
            }
            else if (firstQueue.Count != 0)
            {
                firstQueue.TryDequeue(out string? result);
                Console.WriteLine(result);
            }
            else
            {
                throw new Exception("Ошибка");
            }
        }
    }
}
