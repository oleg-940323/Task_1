using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Родительский класс, описывающий основные возможности животного
    /// </summary>
    abstract class Animal
    {
        public string mass;
        public string growth;
        public string name;
        public string color;

        /// <summary>
        /// Передвижение животного
        /// </summary>
        abstract public void Move();

        /// <summary>
        /// Какой звук издает животное
        /// </summary>
        abstract public void Sound();

        /// <summary>
        /// Потомство
        /// </summary>
        abstract public void Children();

        /// <summary>
        /// Конструктор класса Animal
        /// </summary>
        /// <param name="name"> Название животного </param>
        /// <param name="mass"> Масса животного </param>
        /// <param name="growth"> Рост животного </param>
        /// <param name="color"> Цвет животного </param>
        public Animal(string name, string mass, string growth, Color color)
        {
            this.name = name;
            this.mass = mass;
            this.growth = growth;

            // Задание цвета
            switch (color)
            { 
                case Color.Black:

                    this.color = "Черный";
                    break;

                case Color.Red:

                    this.color = "Красный";
                    break;

                case Color.Green:

                    this.color = "Зеленый";
                    break;

                case Color.Blue:

                    this.color = "Голубой";
                    break;

                case Color.Yellow:

                    this.color = "Желтый";
                    break;

                case Color.White:

                    this.color = "Белый";
                    break;
            }


        }
    }

    /// <summary>
    /// Цвета животных
    /// </summary>
    enum Color
    { 
        Black,
        Red,
        Green,
        Blue,
        Yellow,
        White
    }
}
