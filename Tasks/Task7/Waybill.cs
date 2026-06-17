namespace ModsenLogistics.Tasks.Task7
{
    public class Waybill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Название: {Name}, Количество: {Quantity}, Вес: {Weight}";
        }
    }
}
