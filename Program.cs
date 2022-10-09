using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        // Счетчик для отображение номера животного
        static int count = 0;

        // Выбор пользователя
        static string select;

        // Список животных
        static List<Animal> animals = new List<Animal>()
        { new Dog(),
          new Cat(),
          new Duck(),
          new Fish(),
          new Mosquito(),
          new Сhicken()
        };

        static void Main(string[] args)
        {
            // Введенное значение пользователя после конвертации
            int result;

            Console.WriteLine("Выберете животного:");

            // Вывод спимка животных
            foreach (Animal p in animals)
                Console.WriteLine($"{count++}) {p.name}");

            // ввод значения пользователем
            select = Console.ReadLine();
            
            // Проверка введенного значения
            if (!string.IsNullOrEmpty(select) && int.TryParse(select, out result))
            {
                // Входит ли занчение в диапазон валидных значений и вывод данных животного
                if (result <= animals.Count - 1)
                {
                    Console.WriteLine($"Масса: {animals[result].mass}");
                    Console.WriteLine($"Рост: {animals[result].growth}");
                    Console.WriteLine($"Цвет: {animals[result].color}");
                    animals[result].Move();
                    animals[result].Sound();
                    animals[result].Children();

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Введено неверное значение!");
                    Console.ReadLine();
                }    
            }

        }
    }
}
