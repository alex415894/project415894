using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    class Parse
    {
        string Value = null;
        public void VvodChisla( string Example)
        {
            for (int i = 0; i < Example.Length; i++)
            {
                switch (Example[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case ',':
                    case 'c':
                    case 'o':
                    case 's':
                    case 'i':
                    case 'n':
                    case 't':
                    case 'g':
                    case '(':
                    case ')':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        {
                           
                            
                            Value=Value + Convert.ToString(Example[i]);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("!!!Символ не прочитан. Была допущена ошибка ввода символа!!!");
                        }
                        break;
                }
                Console.WriteLine("Value");
                Calculate Calc = new Calculate();
                Calc.Calculation(Value);
            }
         }
    }
}
