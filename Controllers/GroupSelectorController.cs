using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APITEST.BusinessLogic;
using APITEST.DTOModels;

namespace APITEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupSelectorController : ControllerBase
    {
        private readonly IGroupLogic _groupLogic;

        public GroupSelectorController(IGroupLogic grouplogic)
        {
            _groupLogic = grouplogic;
        }
        // GET: api/GroupSelector   CRUD
        // C => Create
        // R => Read
        // U => Update
        // D => Delete

        [HttpGet]
        public IEnumerable<Group> GetAll() //Leer
        {
            return _groupLogic.GetGroupsCERTClass();
        }


        /*
        // POST: api/GroupSelector
        //Create
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GroupSelector/5
        //Update
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
