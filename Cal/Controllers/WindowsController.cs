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
        public async Task<ActionResult<Window>> PostAsync([FromBody] Window value)
        {
            Price desWindow= new Price();
            using (FileStream file = new FileStream("Price.json", FileMode.OpenOrCreate))
            {
                 desWindow = await JsonSerializer.DeserializeAsync<Price>(file);
                

            }
            value.Square = (Convert.ToDouble(value.Width) * Convert.ToDouble(value.Lenght)) / 1000000;
            value.Perimeter = (Convert.ToDouble(value.Width) + Convert.ToDouble(value.Lenght)) * 2 / 1000;
           
            if (value.Tempered_Glass)
            {
                switch (Convert.ToInt32(value.Picture))
                {
                    case 1:
                        desWindow.Picture = 0;
                        break;
                    case 2:
                        desWindow.Picture = desWindow.Picture_ShaterStock;
                        break;
                    case 3:
                        desWindow.Picture = desWindow.Picture_ArtSkinali;
                        break;
                }
                
                value.Resalt = (value.Square * desWindow.Tempered_Glass + value.Square * desWindow.Print + value.Square * desWindow.Booking+desWindow.Picture);
                if ((value.Resalt-desWindow.Picture)*desWindow.Installation/100 < 6000)
                {
                    value.Resalt_Install = value.Resalt + 6000;
                }
                else
                {
                    value.Resalt_Install=(value.Resalt - desWindow.Picture)*desWindow.Installation / 100;
                }
                return value;
            }
            else
            {
                switch (Convert.ToInt32(value.Picture))
                {
                    case 1:
                        desWindow.Picture = 0;
                        break;
                    case 2:
                        desWindow.Picture = desWindow.Picture_ShaterStock;
                        break;
                    case 3:
                        desWindow.Picture = desWindow.Picture_ArtSkinali;
                        break;
                }

                value.Resalt = (value.Square * desWindow.Tempered_Clarified + value.Square * desWindow.Print + value.Square * desWindow.Booking + desWindow.Picture);
                if ((value.Resalt - desWindow.Picture) * desWindow.Installation / 100 < 6000)
                {
                    value.Resalt_Install = value.Resalt + 6000;
                }
                else
                {
                    value.Resalt_Install = (value.Resalt - desWindow.Picture) * desWindow.Installation / 100;
                }
                return value;

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
