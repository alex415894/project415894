using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Core_calculator
    {
       public string Value;
       
       
         double Result = 0;
         double Result_2=0;
         string Znak = null;
         string Znak_2 = null;
         string Chislo = null;
         
         
        public void Deistvie()
         {
             Console.WriteLine("Уровень 1");
             if (Znak == null)
             {                
                 Result = Result + Convert.ToDouble(Chislo);
                 Chislo = null;
                 Console.WriteLine("Д1 (null) Result_1= " + Result);
             }
             else if (Znak == "+")                                             
             {  
                 Result = Result  + Result_2 + Convert.ToDouble(Chislo);
                 Chislo=null;
                 Result_2=0;
                 Console.WriteLine("Д1 (+) Result_1= " + Result);
             }
             else if (Znak == "-")                                               
             {  
                 Result = Result  - Result_2 - Convert.ToDouble(Chislo);
                 Chislo=null;
                 Result_2=0;
                 Console.WriteLine("Д1 (-) Result_1= " + Result);
             }
             else if (Znak == "*")                                               
             {
                 Result = Result * Convert.ToDouble(Chislo);
                 Chislo = null;
                 Console.WriteLine("Д1 (*) Result_1= " + Result);
             }                  
             else if (Znak == "/")                                              
             {
                 Result = Result * Convert.ToDouble(Chislo);
                 Chislo = null;
                 Console.WriteLine("Д1 (*) Result_1= " + Result);
             }                    
         }          
       
        public void Deistvie2()
        {
            Console.WriteLine("Уровень 2");
            if   (Znak_2 == null)
            {
                Result_2 = Result_2 + Convert.ToDouble(Chislo);
                Console.WriteLine("Д2 (null) Result_2= " + Result_2);
                Chislo = null;
            }                     
            else if (Znak_2 == "+")
            {
                Result_2 = Result_2 + Convert.ToDouble(Chislo);
                Chislo = null;
                Console.WriteLine("Д2 (+) Result_2= " + Result_2);
            }                                         
            else if (Znak_2 == "-")
            {
                Result_2 = Result_2 - Convert.ToDouble(Chislo);
                Chislo = null;
                Console.WriteLine("Д2 (-) Result_2= " + Result_2);
            }                                        
            else if (Znak_2 == "*")
            {
                Result_2 = Result_2 * Convert.ToDouble(Chislo);
                Chislo = null;
                Console.WriteLine("Д2 (*) Result_2= " + Result_2);
            }                                         
            else if (Znak_2 == "/")
            {
                Result_2 = Result_2 / Convert.ToDouble(Chislo);
                Chislo = null;
                Console.WriteLine("Д2 (/) Result_2= " + Result_2);
            }                                         
        }
        public void Symbol()
        {
            Value = "10000*10+5000/25-250+550+0,2/2";
                    
           
            for (int i = 0; i < Value.Length; i++)
            {
                switch (Value[i])
                {
                    case '0':        case '1':        case '2':
                    case '3':        case '4':        case '5':
                    case '6':        case '7':        case '8':
                    case '9':        case ',':       
                        {
                            Chislo = Chislo + Convert.ToString(Value[i]);    
                        }
                        break;
                    case '+':
                        {   
                            if (Znak_2==null)
                            {
                                 Deistvie();
                           
                                 Znak = "+";
                                 
                            }
                            else if (Znak_2 == "*" || Znak_2=="/")
                            {
                                
                                Deistvie2();
                                Znak_2 = null;
                                Deistvie();
                                Znak = "+";
                            }
                        }
                        break;
                    case '-':
                        {
                            if (Znak_2 == null)
                            {
                                Deistvie();
                                Znak = "-";
                                
                            }
                            else if (Znak_2 == "*" || Znak_2 == "/")
                            {
                                
                                Deistvie2();
                                Znak_2 = null;
                                Deistvie();
                                Znak = "-";
                            }   
                        }
                        break;
                    case '*':
                        {
                            if (Znak == "*" || Znak == "/" || Znak == null)
                            {
                                Deistvie();
                                Znak = "*";
                                
                            }
                            else if (Znak == "+" || Znak == "-")
                            {
                                
                                Deistvie2();
                                Znak_2 = "*";
                               
                            }
                           
                        }
                        break;
                    case '/':
                        {
                            if (Znak == "*" || Znak == "/" || Znak == null)
                            {
                                Deistvie();
                                Znak = "/";
                                
                            }
                            else if (Znak == "+" || Znak == "-")
                            {
                               
                                Deistvie2();
                                Znak_2 = "/";
                               
                            }

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("!!!Была допущена ошибка ввода символа!!!");
                            Console.WriteLine("!!!Ответ может быть неверен!!"); ;
                        }
                        break;
                        
                }
   
             }
            if (Znak_2 == "+" || Znak_2 == "-" || Znak_2 == "*" || Znak_2 == "/")
            {
                Deistvie2();
                Znak_2 = null;
            }
            Deistvie();
            Znak = null;
            Console.WriteLine("Ответ:");
            Console.WriteLine( Value+" = "+Result);
            Result = 0;
         }
    } 
}


