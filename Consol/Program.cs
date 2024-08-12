using System;

namespace Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string consolComand;
            int randomNumber;
            bool isOpen = true;

            const string ComandShowHello = "1"; 
            const string ComandShowInfo = "2"; 
            const string ComandShowRandomNumber = "3"; 
            const string ComandConsolClear = "4"; 
            const string ComandExit = "5"; 

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
                    case ComandShowHello:
                        Console.WriteLine("Привет");
                        break;
                    case ComandShowInfo:
                        Console.WriteLine("Некая информация");
                        break;
                    case ComandShowRandomNumber:
                        randomNumber = random.Next(0, 100);
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
