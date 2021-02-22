using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cal.Models
{
   
    public class Window
    {
        public string Width { get; set; }
        public string Lenght { get; set; }
        
        public double Square { get; set; }

        public double Resalt { get; set; }
        /// <summary>
        /// Перемитр
        /// </summary>
        public double Perimeter { get; set; }

        public Window() { }
    }
}
