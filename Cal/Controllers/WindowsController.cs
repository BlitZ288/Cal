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
        public void Get()
        {

        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult<Window> Post(List<Window> value)
        {
            Price desWindow = new Price();
            for (int i = 0; i <= value.Count; i++)
            {

                value[i].Square = (Convert.ToDouble(value[i].Width) * Convert.ToDouble(value[i].Lenght)) / 1000000;
                value[i].Perimeter = (Convert.ToDouble(value[i].Width) + Convert.ToDouble(value[i].Lenght)) * 2 / 1000;
                if (!value[i].Booking)
                {
                    desWindow.Booking = 0;
                }

                if (value[i].Tempered_Glass)
                {
                    switch (Convert.ToInt32(value[i].Picture))
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


                    value[i].Resalt = (value[i].Square * desWindow.Tempered_Glass + value[i].Square * desWindow.Print + value[i].Square * desWindow.Booking
                      + desWindow.Picture + Convert.ToDouble(value[i].Fasteners) * desWindow.Fasteners + Convert.ToDouble(value[i].Sockets) * desWindow.Sockets
                       + Convert.ToDouble(value[i].Railing) * desWindow.Railing);
                    if ((value[i].Resalt - desWindow.Picture) * desWindow.Installation / 100 < 6000)
                    {
                        value[i].Resalt_Install = value[i].Resalt + 6000;
                    }
                    else
                    {
                        value[i].Resalt_Install = (value[i].Resalt - desWindow.Picture) * desWindow.Installation / 100;
                    }
                    return value[i];
                }
                else
                {
                    switch (Convert.ToInt32(value[i].Picture))
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
                    value[i].Resalt = (value[i].Square * desWindow.Tempered_Clarified + value[i].Square * desWindow.Print + value[i].Square * desWindow.Booking
                     + desWindow.Picture + Convert.ToDouble(value[i].Fasteners) * desWindow.Fasteners + Convert.ToDouble(value[i].Sockets) * desWindow.Sockets
                      + Convert.ToDouble(value[i].Railing) * desWindow.Railing);
                    if ((value[i].Resalt - desWindow.Picture) * desWindow.Installation / 100 < 6000)
                    {
                        value[i].Resalt_Install = value[i].Resalt + 6000;
                    }
                    else
                    {
                        value[i].Resalt_Install = (value[i].Resalt - desWindow.Picture) * desWindow.Installation / 100;
                    }

                    return value[i];
                }
             
            }
            return null;
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
