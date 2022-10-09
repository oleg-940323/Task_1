using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс собака
    /// </summary>
    internal class Dog : Animal
    {
        /// <summary>
        /// Переопределение метода Move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Ходит");
        }

        /// <summary>
        /// Переопределение метода Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Гав");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Щенок");
        }

        /// <summary>
        /// Конструктор класса Dog
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Dog(string mass, string growth, string color) : 
            base("Собака", mass.ToString() + " кг", growth.ToString() + " см", Color.Black) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 40 кг, рост: 70 см, цвет: черный)
        /// </summary>
        public Dog() : base(name: "Собака", mass: "40 кг", growth: "70 см", color: Color.Black) { }
    }
}