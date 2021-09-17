using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programmer_s_day.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaysController : ControllerBase
    {
        // GET: api/<DaysController>
        [HttpGet]
        public string Get()
        {
            return DayOfDate(DayOfInt(256, DateTime.Today.Year));
        }

        // GET api/<DaysController>/2021
        [HttpGet("{year}")]
        public string Get(int year)
        {
            return DayOfDate(DayOfInt(256, year));
        }





        private string DayOfDate(DateTime d)
        {
            return $"{d.ToLongDateString()}";
        }

        private DateTime DayOfInt(int dayOfYear, int year)
        {
            if (dayOfYear < 1 || dayOfYear > 366) return DateTime.MinValue;

            DateTime date = new DateTime(year, 1, 1);
            return date.AddDays(dayOfYear - 1);
        }
    }
}
