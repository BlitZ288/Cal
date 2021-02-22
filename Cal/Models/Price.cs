using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cal.Models
{
    public class Price
    {/// <summary>
     /// Печетать
     /// </summary>
        public double Print { get; set; }
        /// <summary>
        /// Закаленного стекла
        /// </summary>
        public double Tempered_Glass {get; set;}
        /// <summary>
        /// Незакаленного стекла
        /// </summary>
        public double Unglazed_glass{ get; set; }
        /// <summary>
        /// Закаленного осветленного
        /// </summary>
        public double Tempered_Clarified { get; set; }
        /// <summary>
        /// Кромка закаленного
        /// </summary>
        public double Edge_of_tempered_glass { get; set; }
        /// <summary>
        /// Кромка незакаленного
        /// </summary>
        public double The_edge_of_the_unfinished { get; set; }
        /// <summary>
        /// Кромка закаленного осветленного
        /// </summary>
        public double Edge_of_tempered_clarified { get; set; }
        /// <summary>
        /// Розетки
        /// </summary>
        public double Sockets { get; set; }
        /// <summary>
        /// Крепеж
        /// </summary>
        public double Fasteners { get; set; }
        /// <summary>
        /// Railing
        /// </summary>
        public double Railing { get; set; }
        /// <summary>
        /// Картинка
        /// </summary>
        public double Picture { get; set; }
        /// <summary>
        /// Бронирование
        /// </summary>
        public double Booking { get; set; }

       
    }
}
