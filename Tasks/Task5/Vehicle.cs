namespace ModsenLogistics.Tasks.Task5
{
    public class Vehicle
    {
        public string? LicensePlate { get; set; }
        public string? Category { get; set; }
        public double FuelConsumption { get; set; }
        public double Mileage { get; set; }
        public bool IsMaintenanceRequired { get; set; }

        public Vehicle(string LicensePlate, string Category, double FuelConsumption, double Mileage)
        {
            this.LicensePlate = LicensePlate;
            this.Category = Category;
            this.FuelConsumption = FuelConsumption;
            this.Mileage = Mileage;
            this.IsMaintenanceRequired = IsMaintenanceRequired;
        }
    }
}
