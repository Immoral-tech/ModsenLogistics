namespace ModsenLogistics.Tasks.Task5
{
    public class VehicleStatisticsService
    {
        public static Dictionary<string, double> GetValues(List<Vehicle> vehicles)
        {
            return vehicles
                .Where(x => x.Mileage > 50000)
                .GroupBy(x => x.Category)
                .ToDictionary(
                g => g.Key,
                g => g.Average(x => x.FuelConsumption)
                );
        }
    }
}
