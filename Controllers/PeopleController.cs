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
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> people = new List<Person>();

            string connectionString = "Server=localhost;User ID=root;Password=Password1;Port=3306;Database=bob";
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("select * from fred;", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                people.Add(new Person
                {
                    ID = int.Parse(reader.GetString(0)),
                    Name = reader.GetString(1)
                });
            }
            return people;
        }
    }
}
