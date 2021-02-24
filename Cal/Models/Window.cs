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
        /// <summary>
        /// Площадь
        /// </summary>
        public double Square { get; set; }
        /// <summary>
        /// Check_Box Закаленного стекла 
        /// </summary>
        public bool Tempered_Glass { get; set; }
        /// <summary>
        /// Check_Box Закаленного осветленного
        /// </summary>
        public bool Tempered_Clarified { get; set; }
        /// <summary>
        /// Перемитр
        /// </summary>
        public double Perimeter { get; set; }
        /// <summary>
        /// Результат 
        /// </summary>
        public double Resalt { get; set; }
        /// <summary>
        /// Результат с установкой  
        /// </summary>
        public double Resalt_Install{ get; set; }
        /// <summary>
        /// Combo_Box с выбором 
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Количество розетоки
        /// </summary>
        public int Sockets { get; set; }
        /// <summary>
        /// Количество отверстий рейлинг
        /// </summary>
        public int Railing { get; set; }
        /// <summary>
        /// Количество крепежа
        /// </summary>
        public int Fasteners { get; set; }


        public Window() { }
    }
}
