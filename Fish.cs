using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс рыба
    /// </summary>
    internal class Fish : Animal
    {
        /// <summary>
        /// Переопределение метода Move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Передвижение: Плавает");
        }

        /// <summary>
        /// Переопределение метода Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Издает звук: ");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Название потомка: Малек");
        }

        /// <summary>
        /// Конструктор класса Fish
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Fish(string mass, string growth, string color) : 
            base("Рыба", mass.ToString() + " г", growth.ToString() + " см", Color.Black) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 500 г, рост: 7 см, цвет: черный)
        /// </summary>
        public Fish() : base(name: "Рыба", mass: "500 г", growth: "7 см", color: Color.Black) { }
    }
}
