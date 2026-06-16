namespace ModsenLogistics.Tasks.Task4
{
    class Train : Transport
    {
        public Train() : base(80) { }

        public override double CalculateTime(double distance)
        {
            return distance / speed;
        }
    }
}
