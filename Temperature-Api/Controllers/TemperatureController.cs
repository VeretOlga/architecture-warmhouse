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
    }
}
