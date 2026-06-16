namespace ModsenLogistics.Tasks.Task4
{
    public abstract class Transport
    {
        public double speed { get; set; }

        public Transport(double speed)
        {
            this.speed = speed;
        }

        public abstract double CalculateTime(double distance);
    }
}
