using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Core_calculator_brackets
    {
        public string Value;


        double Result = 0;
        double Result_2 = 0;
        string Znak = null;
        string Znak_2 = null;
        string Chislo = null;
        double Nabor = 0;

        double Memory_Result = 0;
        double Memory_Result_2 = 0;
        string Memory_Znak = null;
        string Memory_Znak_2 = null;
        
        //double Double_Brakets = 0;

           


        public void Deistvie()
        {
            Console.WriteLine("Уровень 1");
            Nabor = Nabor+Convert.ToDouble(Chislo);
            Chislo = null;
            if (Znak == null)
            {
                Result = Result + Nabor ;
                Console.WriteLine("Д1 (null) Result_1= " + Result);
            }
            else if (Znak == "+")
            {  
                Result = Result + Nabor + Result_2;
                Result_2 = 0;
                Console.WriteLine("Д1 (+) Result_1= " + Result);
            }

            else if (Znak == "-")
            {
                Result = Result - Nabor - Result_2;
                Result_2 = 0;
                Console.WriteLine("Д1 (-) Result_1= " + Result);
            }
            else if (Znak == "*")
            {
                Result = Result * Nabor;
                Console.WriteLine("Д1 (*) Result_1= " + Result);
            }

            else if (Znak == "/")
            {
                Result = Result / Nabor;
                Console.WriteLine("Д1 (/) Result_1= " + Result);
            }
            Nabor = 0;
            
        }
        public void Deistvie2()
        {
            Console.WriteLine("Уровень 2");
            Nabor =Nabor + Convert.ToDouble(Chislo);
            Chislo = null;
        
            if (Znak_2 == null)
            { 
                Result_2 = Result_2 + Nabor;
                Console.WriteLine("Д2 (null) Result_2= " + Result_2);
            }
            else if (Znak_2 == "*")
            {               
                Result_2 = Result_2 * Nabor;
                Console.WriteLine("Д2 (*) Result_2= " + Result_2);
            }
            else if (Znak_2 == "/")
            {
                Result_2 = Result_2 / Nabor;
                Console.WriteLine("Д2 (/) Result_2= " + Result_2);
            }
            Nabor = 0;
        }
        public void MemoryUP_L1()
        {
            Memory_Result = Result;
            Result = 0;
            Memory_Result_2 = Result_2;
            Result_2 = 0;
            Memory_Znak = Znak;
            Znak = null;
            Memory_Znak_2 = Znak_2;
            Znak_2 = null;
        }
        public void MemoryDOWN_L1()
        {
            if (Znak_2 == "*" || Znak_2 == "/")
            {
                Deistvie2();
                Znak_2 = null;
            }
            Deistvie();
            Znak = null;
            Nabor = Result;
            Result = 0;

            Result = Memory_Result;
            Memory_Result = 0;
            Result_2 = Memory_Result_2;
            Memory_Result_2 = 0;
            Znak = Memory_Znak;
            Memory_Znak = null;
            Znak_2 = Memory_Znak_2;
            Memory_Znak_2 = null;

            Chislo = null;
           
            Console.WriteLine("         mem down Result=" + Result);
            Console.WriteLine("         mem down Result_2=" + Result_2);
            Console.WriteLine("         mem down Znak=" + Znak);
            Console.WriteLine("         mem down Znak_2=" + Znak_2); 
            Console.WriteLine("         mem down Nabor=" + Nabor);
        }                              

        public void Symbol()
        {
            
            Value = "(60000*4)+(500*7)+100-(56-53)*4+1000*10000/44*88";

            for (int i = 0; i < Value.Length; i++)
            {
                switch (Value[i])
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
                        {
                            Chislo = Chislo + Convert.ToString(Value[i]);
                        }
                        break;
                    case '(':
                            MemoryUP_L1();                     
                        break;
                    case ')':                        
                            MemoryDOWN_L1();                        
                        break;
                    case '+':
                    case '-':
                        {
                            if (Znak_2 == null)
                            {
                                Deistvie();
                                Znak = Convert.ToString(Value[i]);
                             }
                            else if (Znak_2 == "*" || Znak_2 == "/")
                            {
                                Deistvie2();
                                Znak_2 = null;
                                Deistvie();
                                Znak = Convert.ToString(Value[i]);
                            }
                        }                        
                        break;
                    case '*':
                    case '/': 
                        {
                            if (Znak == "*" || Znak == "/" || Znak == null)
                            {
                                Deistvie();
                                Znak = Convert.ToString(Value[i]); 
                            }
                            else if (Znak == "+" || Znak == "-")
                            {
                                Deistvie2();
                                Znak_2 = Convert.ToString(Value[i]); 
                            }
                         }
                        break;                                        
                    default:
                        {
                            Console.WriteLine("!!!Символ не прочитан. Была допущена ошибка ввода символа!!!"); 
                        }
                        break;
                }
            }
            if (Znak_2 == "*" || Znak_2 == "/")
            {
                Deistvie2();
                Znak_2 = null;
            }
            Deistvie();
            Znak = null;
            Console.WriteLine("Ответ:");
            Console.WriteLine(Value + " = " + Result);
            Result = 0;
        }
    }
}


