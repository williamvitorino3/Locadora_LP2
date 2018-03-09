using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebApi.Models;

namespace Locadora.Controllers
{
    [Route("api/[controller]")]
    public class FilmeLocacaoController : Controller
    {
        private DataContext api;

        public FilmeLocacaoController(DataContext dataContext)
        {
            this.api = dataContext;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<FilmeLocacao> Get()
        {
            return this.api.Set<FilmeLocacao>();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]FilmeLocacao body)
        {
            if(body != null)
            {
                this.api.Set<FilmeLocacao>().Add(body);
                this.api.SaveChanges();
            }
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
