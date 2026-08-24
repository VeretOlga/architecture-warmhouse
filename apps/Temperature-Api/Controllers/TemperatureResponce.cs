using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Temperature_Api.Controllers
{

    public record TemperatureResponce
    {

        public double Value { get; set; }

        public string Unit { get { return "°C"; } }

        public DateTime Timestamp { get { return DateTime.Now;  } }
        
		public string Location    { get; set; }
        public string Status { get { return "active"; } }
        public string SensorID { get; set; }
        
        public string SensorType { get { return "temperature"; } }  
        public string Description
        { get
            {
                return $"Temperature sensor in {this.Location}";
            } 
        }
    }
}
