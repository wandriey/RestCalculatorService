using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCalculatorService.Model;

namespace RestCalculatorService.Controllers
{
    [Produces("application/json")]
    [Route("api/Calculator")]
    public class CalculatorController : Controller
    {
        // GET: api/Calculator
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calculator/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Calculator
        //[HttpPost()]
        //public void Post([FromBody]string value)
        //{
        //}

        // POST: api/Calculator/Add
        [HttpGet("Add", Name = "Add")]
        public int Addition([FromBody] Data data)
        {
            return data.getA + data.getB;
        }

        // POST: api/Calculator/Sub
        [HttpPost("Sub", Name = "Sub")]
        public int Subtract([FromBody] Data data)
        {
            return data.getA - data.getB;
        }

        // POST: api/Calculator/Mul
        [HttpPost("Mul", Name = "Mul")]
        public double Multiplication([FromBody] Data data)
        {
            return data.getA * data.getB;
        }

        // POST: api/Calculator/Div
        [HttpPost("Div", Name = "Div")]
        public double Division([FromBody] Data data)
        {
            return Convert.ToDouble(data.getA) / Convert.ToDouble(data.getB);
        }


        // PUT: api/Calculator/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
