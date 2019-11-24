using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){Id = 0,Author = "author0",Description = "description0",Title = "title0"},
            new Quote(){Id = 1,Author = "author1",Description = "description1",Title = "title1"}
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        [HttpPost]
        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quote quote)
        {
            _quotes[id] = quote;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}