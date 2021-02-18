using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cal.Controllers
{
    [Route("api/[controller]")]
    public class WindowsController : Controller
    {
        
        // GET: api/<controller>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            using (FileStream file = new FileStream("Windows.json",FileMode.OpenOrCreate))
            {
                Window desWindow = await JsonSerializer.DeserializeAsync<Window>(file);
                if (desWindow == null)
                {
                    return new string[] { "Файл пуст" };
                }
                else
                {
                    return new string[] { $"{desWindow.Length}, {desWindow.Width}" };
                }
                
            }
          
           
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Window value)
        {
            value.Square = value.Length * value.Width;
            using(FileStream file = new FileStream("Windows.json",FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Window>(file,value);
            }

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
