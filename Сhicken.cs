using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс курица
    /// </summary>
    internal class Сhicken : Animal
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
            Console.WriteLine("Издает звук: Ко");
        }

        /// <summary>
        /// Переопределение метода Children
        /// </summary>
        public override void Children()
        {
            Console.WriteLine("Название потомка: Цыпленок");
        }

        /// <summary>
        /// Конструктор класса Сhicken
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Сhicken(int mass, int growth, string color) : 
            base("Курица", mass.ToString() + " кг", growth.ToString() + " см", Color.White) { }

        /// <summary>
        /// Конструктор со значениями по умолчанию (вес: 5 кг, рост: 50 см, цвет: рыжий)
        /// </summary>
        public Сhicken() : base(name: "Курица", mass: "5 кг", growth: "50 см", color: Color.White) { }
    }
}
