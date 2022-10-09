using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс кошка
    /// </summary>
    internal class Cat : Animal
    {
        /// <summary>
        /// Переопределение метода Move
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Передвижение: Ходит");
        }

        /// <summary>
        /// Переопределение метода Sound
        /// </summary>
        public override void Sound()
        {
            Console.WriteLine("Издает звук: Мяу");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Название потомка: Котенок");
        }

        /// <summary>
        /// Конструктор класса Cat
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Cat(double mass, double growth, string color) : 
            base("Кошка", mass.ToString() + " кг", growth.ToString() + " см", Color.Black) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 4 кг, рост: 25 см, цвет: черный)
        /// </summary>
        public Cat() : base(name: "Кошка", mass: "4 кг", growth: "25 см", color: Color.Black) { }
    }
}
