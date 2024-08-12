using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string consolComand;
            bool isOpen = true;

            Console.WriteLine("1. Вывести приветствие.\n \n" +
                "2. Вывести инофрмацю.\n \n" +
                "3. Показать случайное число.\n \n" +
                "4. очистить консоль.\n \n" +
                "5. Выход.");

            Console.WriteLine("Введите необходимую команду");

            while (isOpen)
            {
                consolComand = Console.ReadLine();
                switch (consolComand)
                {
                    case "1":
                        Console.WriteLine("Привет");
                        break;
                    case "2":
                        Console.WriteLine("Некая информация");
                        break;
                    case "3":
                        Console.WriteLine(rand.Next(0, 100));
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("До свидание.");
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Не верная команда");
                        break;
                }
            }
        }
    }
}
