using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс утка
    /// </summary>
    internal class Duck : Animal
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
            Console.WriteLine("Издает звук: Кря");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Название потомка: Утенок");
        }

        /// <summary>
        /// Конструктор класса Duck
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Duck(string mass, string growth, string color) : 
            base("Утка", mass.ToString() + " кг", growth.ToString() + " см", Color.Black) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 4 кг, рост: 30 см, цвет: черный)
        /// </summary>
        public Duck() : base(name: "Утка", mass: "4 кг", growth: "30 см", color: Color.Black) { }
    }
}
