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
        public async Task<ActionResult<Window>> Get()
        {
            using (FileStream file = new FileStream("Windows.json",FileMode.OpenOrCreate))
            {
                var desWindow = await JsonSerializer.DeserializeAsync<Window>(file);
                return desWindow;
                
                
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
        public async Task PostAsync([FromBody] Window value)
        {
            Price desWindow= new Price();
            using ( StreamReader reader = new StreamReader("Price.txt"))
            {
                string line = reader.ReadLine();
                char[] str = line.ToCharArray();
                int temp = 0;
                char[] str2= new char[4];
                for ( int i = 0; i <= str.Length; i++)
                {
                    if (str[i] == ':')
                    {
                        temp = i;
                        temp++;
                        break;
                    }

                }
                for(int i = 0; i < str2.Length; i++)
                {
                    if (str[i]==',')
                    {
                        break;
                    }
                    else { 
                        str2[i] = str[temp];
                        temp++;
                    }
                 
                }
           
            }
            using (FileStream file = new FileStream("Price.json", FileMode.OpenOrCreate))
            {
                 desWindow = await JsonSerializer.DeserializeAsync<Price>(file);
                

            }
            //value.Square = (Convert.ToDouble(value.Width) * Convert.ToDouble(value.Lenght)) / 1000000;
            //value.Perimeter = (Convert.ToDouble(value.Width) + Convert.ToDouble(value.Lenght)) * 2 / 1000;
            //value.Resalt =((value.Square*desWindow.Tempered_Glass+desWindow.Edge_of_tempered_glass*value.Perimeter+
            //value.Square*desWindow.Print+value.Square*desWindow.Booking));
                
            using (FileStream file = new FileStream("Windows.json",FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<Window>(file,value);
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
