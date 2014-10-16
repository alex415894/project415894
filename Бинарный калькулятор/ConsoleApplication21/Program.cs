using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main()
        {
            Core_calculator Proba = new Core_calculator();
            Core_calculator_brackets Proba_2 = new Core_calculator_brackets();
            CCB_MaztFun Proba_3 = new CCB_MaztFun();

            Console.WriteLine("Сделайте выбор калькулятора");
            Console.WriteLine("Введите '1' или '2' или '3'");
            string V = Console.ReadLine();
            switch (V)
            {
                case "1":
                    Proba.Symbol();
                    break;
                case "2":
                    Proba_2.Symbol();
                    break;
                case "3":
                    Proba_3.Symbol();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;

            }

                              
            Console.ReadLine();
        }                      
    }                         
}  
                           
                              
                              
                              
                              
                              
                              
                              
                              
                              
                              
                              
                              