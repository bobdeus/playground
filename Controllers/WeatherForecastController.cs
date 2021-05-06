using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace playground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> fred = new List<string>();

            string connectionString = "Server=localhost;User ID=root;Password=Password1;Port=3306;Database=bob";
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("select * from fred;", connection);
            using var reader = command.ExecuteReader(); 
            while(reader.Read())
            {
              fred.Add(reader.GetString(1));
            }
            return fred;
        }
    }
}
