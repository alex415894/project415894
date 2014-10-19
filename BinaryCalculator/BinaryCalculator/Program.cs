using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t СДЕЛАЙТЕ СВОЙ ВЫБОР:");
            Console.WriteLine("\n 1. Просмотреть пример\n\n 2. Ввести новый пример\n\n 3. Открыть winform калькулятор\n\n 4. Выход\n\n");
            string Сhoice = Console.ReadLine();
            switch (Сhoice)
            {
                case "1":
                    {
                        Console.WriteLine("Ваш выбор \"1\"");
                        string Example;
                        Example = "(2*3)+(10*6)+600-(56-53)*4-33*3+45+800*cos(60)+cos(60)+1+cos(0,5-cos(120*cos(40+20)))";
                        Parse Vvod = new Parse();
                        Vvod.VvodChisla(Example);
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Ваш выбор \"2\"");
                        string Example;
                        Example = Console.ReadLine();
                        Parse Vvod = new Parse();
                        Vvod.VvodChisla(Example);
                        

                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("file not found");
                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("close the program");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    break;

            }
            Console.ReadLine();
        }
    }
}
