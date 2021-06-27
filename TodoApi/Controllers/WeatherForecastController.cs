using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Base;
using TodoApi.Entity;

namespace TodoApi.Controllers
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
        private readonly TodoContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, //dependcy injection
                                        TodoContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // [HttpPost]
        // public async Task<ActionResult<User>> PostTodoItem(User todoItem)
        // {
        //     _context.Users.Add(todoItem);
        //     await _context.SaveChangesAsync();

        //     //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //     return Ok(todoItem);
        // }

        // [HttpGet]
        // [Route("user")]
        // public ActionResult GetUser()
        // {
        //     var data = _context.Users;
        //     return Ok(_context.Users);
        // }
    }
}
