using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс комар
    /// </summary>
    internal class Mosquito : Animal
    {
        /// <summary>
        /// Переопределение метода Move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Передвижение: Ходит, летает");
        }

        /// <summary>
        /// Переопределение метода Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Издает звук: Бзз");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Название потомка: Личинка");
        }

        /// <summary>
        /// Конструктор класса Mosquito
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Mosquito(double mass, double growth, Color color) : 
            base("Комар", mass.ToString() + " мг", growth.ToString() + " мм", Color.Black) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 2 мг, рост: 5 мм, цвет: черный)
        /// </summary>
        public Mosquito() : base(name: "Комар", mass: "2 мг", growth: "5 мм", color: Color.Black) { }
    }
}
