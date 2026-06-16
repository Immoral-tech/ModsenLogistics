namespace ModsenLogistics.Tasks.Task4
{
    class Plane : Transport
    {
        public Plane() : base(800) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed + 2;
        }
    }
}
