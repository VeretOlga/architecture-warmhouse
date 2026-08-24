namespace Temperature_Api.Controllers
{
    public class GenerateTemperature
    {
        public static Dictionary<int, string> Locations = new Dictionary<int, string>
        {
            {1,"Living Room"}, {2, "Bedroom"}, { 3,"Kitchen"}, { 4,"Unknown"}
        };

        public static Dictionary<string, string> SensorId = new Dictionary<string, string>
        {
            {"Living Room","1"}, {"Bedroom","2"}, { "Kitchen","3"}, { "Unknown","4"}
        };
        private static readonly Random _random = new Random();

        public static TemperatureResponce GetTemperature(int location)
        {
        
            int value = _random.Next(180, 281); // верхняя граница не включается, поэтому 281
            double valueTemp =  value / 10.0;
            string locationCur = Locations.GetValueOrDefault(location, "Unknown");
            string SensorIdCur = SensorId.GetValueOrDefault(locationCur, "4");

            return new TemperatureResponce()
            { 
                Value= valueTemp,
                Location = locationCur,
                SensorID= SensorIdCur,
                
            };
        }

            
    }
}
