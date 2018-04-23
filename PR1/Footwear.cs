using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{/// <summary>
/// Описываем класс обувь
/// </summary>
    class Footwear
    {
        public string Manufacturer { get; set; }
        public float Size { get; set; }
        public double Price { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Footwear()
        {

        }
        /// <summary>
        /// Ввод объектов класса с клавиатуры
        /// </summary>
        public void Input()
        {
            Manufacturer = Console.ReadLine();
            Size = float.Parse(Console.ReadLine());
            Price = Double.Parse(Console.ReadLine());
        }
    }
}