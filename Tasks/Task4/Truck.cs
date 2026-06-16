namespace ModsenLogistics.Tasks.Task4
{
    class Truck : Transport
    {
        public Truck() : base(120) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }
    }
}
