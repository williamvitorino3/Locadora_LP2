using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebApi.Models;

namespace Locadora.Controllers
{
    [Route("api/[controller]")]
    public class DevolucaoController : Controller
    {
        private DataContext api;

        public DevolucaoController(DataContext dataContext)
        {
            this.api = dataContext;
        }

        // GET api/values
        // [HttpGet]
        // public IEnumerable<Devolucao> Get()
        // {
        //     return this.api.Set<Devolucao>();
        // }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody]Devolucao body)
        // {
        //     if(body != null)
        //     {
        //         this.api.Set<Devolucao>.Add(body);
        //         this.api.SaveChanges();
        //     }
        // }

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
