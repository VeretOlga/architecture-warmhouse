using Microsoft.AspNetCore.Mvc;

namespace Temperature_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
       

        [HttpGet(Name = "temperature")]
        public TemperatureResponce GetTemperature(int location)
        {
            return GenerateTemperature.GetTemperature(location);
        }


        [HttpGet("{sensorID}")]
        public IActionResult GetTemperaturebyID(int sensorID)
        {
            try
            {
                var result = GenerateTemperature.GetTemperatureByID(sensorID);
                return Ok(result);   // возвращает JSON
            }
            catch (Exception ex)
            {
                return NotFound($"Sensor {sensorID} not found: {ex.Message}");
            }
        }
    }
}
