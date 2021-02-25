using Microsoft.Office.Interop.Excel;
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
        public double Tempered_Glass { get; set; }
        /// <summary>
        /// Незакаленного стекла
        /// </summary>
        public double Unglazed_glass { get; set; }
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

        public double Picture_ArtSkinali { get; set; }

        public double Picture_ShaterStock { get; set; }
        /// <summary>
        /// Установка обычного %
        /// </summary>
        public double Installation { get; set; }
        /// <summary>
        /// Установка прозрачного%
        /// </summary>
        public double Installation_Transparent { get; set; }
        /// <summary>
        /// Бронирование
        /// </summary>
        public double Booking { get; set; }

        public Price()
        {
            Application excelApp = new Application();


            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }

            Workbook excelBook = excelApp.Workbooks.Open(@"C:\Users\fed0r\source\repos\Excel\Excel\bin\Debug\netcoreapp3.1\Price.xls");
           _Worksheet excelSheet = excelBook.Sheets[2];
            Microsoft.Office.Interop.Excel.Range excelRange = excelSheet.UsedRange;

            int rows = excelRange.Rows.Count;
            int cols = excelRange.Columns.Count;
            for (int i = 3; i <= rows; i++)
            {
                object _xVal = ((Microsoft.Office.Interop.Excel.Range)excelSheet.Cells[i, 7]).Value2;
                if (_xVal != null)
                {
                    this.Tempered_Glass = Convert.ToDouble(_xVal);
                  
                    Console.Write(_xVal + "\n");
                }

            }
            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            Console.ReadLine();
        }
    }
}
