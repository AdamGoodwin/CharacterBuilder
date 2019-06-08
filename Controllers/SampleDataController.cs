using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharacterBuilder.Models;
namespace CharacterBuilder.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private DBContext _context;

        public SampleDataController(DBContext context)
        {
            _context = context;
        }


        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            //Character exists = _context.Characters.FirstOrDefault();
            //This is just a test.
            //Another test 
            //I can fly,
            //Character c = new Character();
            //c.Name = "Adam!!!!";
            //c.Id = 1;
            //_context.Characters.Add(c);
            //_context.SaveChanges();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
