using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс бабочка
    /// </summary>
    internal class Butterfly : Animal
    {
        /// <summary>
        /// Переопределение метода Move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Ходит, летает");
        }

        /// <summary>
        /// Переопределение метода Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Гусиница");
        }

        /// <summary>
        /// Конструктор класса Butterfly
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Butterfly(string mass, string growth, string color) :
            base("Бабочка", mass.ToString() + " кг", growth.ToString() + " см", Color.Black)
        { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 10 мг, рост: 10 см, цвет: черный)
        /// </summary>
        public Butterfly() : base(name: "Бабочка", mass: "10 кг", growth: "10 см", color: Color.Red) { }
    }
}
