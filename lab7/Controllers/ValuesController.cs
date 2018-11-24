using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using lab7.ModelsForMapper;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace lab7.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IMapper _mapper;
        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.Warn("Jakiś log ");
            Customer customer = new Customer() { Id = 5, Name = "Jan", Surname = "Kowalsi" };
            CustomerDto customerDto = _mapper.Map<CustomerDto>(customer);

            return Ok(customerDto);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new SystemException("coś poszło nie tak ");
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
