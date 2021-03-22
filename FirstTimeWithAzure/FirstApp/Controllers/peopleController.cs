using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FirstApp.models;
using System.Linq;

namespace FirstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class peopleController : ControllerBase
    {

        private readonly PeopleDB db;
        public peopleController(PeopleDB db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var people = db.People.ToList();
            return Ok(people);
        }
    }
}
