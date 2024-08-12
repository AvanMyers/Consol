using System;

namespace Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ComandShowHello = "1"; 
            const string ComandShowInfo = "2"; 
            const string ComandShowRandomNumber = "3"; 
            const string ComandConsolClear = "4"; 
            const string ComandExit = "5"; 

            Random random = new Random();
            string consolComand;
            int randomNumber;
            int minRandomNumber = 0;
            int maxRandomNumber = 100;
            bool isOpen = true;

            Console.WriteLine($"{ComandShowHello}. Вывести приветствие.\n \n" +
                $"{ComandShowInfo}. Вывести инофрмацю.\n \n" +
                $"{ComandShowRandomNumber}. Показать случайное число.\n \n" +
                $"{ComandConsolClear}. очистить консоль.\n \n" +
                $"{ComandExit}. Выход.");
            Console.WriteLine("Введите необходимую команду");

            while (isOpen)
            {
                consolComand = Console.ReadLine();

                switch (consolComand)
                {
                    case ComandShowHello:
                        Console.WriteLine("Привет");
                        break;
                    case ComandShowInfo:
                        Console.WriteLine("Некая информация");
                        break;
                    case ComandShowRandomNumber:
                        randomNumber = random.Next(minRandomNumber, maxRandomNumber);
                        Console.WriteLine(randomNumber);
                        break;
                    case ComandConsolClear:
                        Console.Clear();
                        break;
                    case ComandExit:
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
