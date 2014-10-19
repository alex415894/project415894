using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator
{
    class Calculate
    {
        
        string Chislo = null;
        double Nabor = 0;
        double Result = 0;
        double Result_2 = 0;
        string Znak = null;
        string Znak_2 = null;
        string Znak_Function = null;

        double MemoryL1_Result = 0;
        double MemoryL1_Result_2 = 0;
        string MemoryL1_Znak = null;
        string MemoryL1_Znak_2 = null;
        string MemoryL1_Znak_Function = null;

        double MemoryL2_Result = 0;
        double MemoryL2_Result_2 = 0;
        string MemoryL2_Znak = null;
        string MemoryL2_Znak_2 = null;
        string MemoryL2_Znak_Function = null;

        double MemoryL3_Result = 0;
        double MemoryL3_Result_2 = 0;
        string MemoryL3_Znak = null;
        string MemoryL3_Znak_2 = null;
        string MemoryL3_Znak_Function = null;

        double CounterBrackets = 0;



        void Deistvie()
        {
            Console.WriteLine("Уровень 1");
            Nabor = Nabor + Convert.ToDouble(Chislo);
            Chislo = null;
            if (Znak == null)
            {
                Result = Result + Nabor;
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
        void Deistvie2()
        {
            Console.WriteLine("Уровень 2");
            Nabor = Nabor + Convert.ToDouble(Chislo);
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
        void DeistvieFunction()
        {
            switch (Znak_Function)
            {
                case "cos":
                    {
                        Nabor = Math.Cos(Nabor * Math.PI / 180);
                    }
                    break;
                case "sin":
                    {
                        Nabor = Math.Sin(Nabor * Math.PI / 180);
                    }
                    break;
                case "td":
                    {
                        Nabor = Math.Tan(Nabor * Math.PI / 180);
                    }
                    break;
                case "ctg":
                    {
                        Nabor = 1 / Math.Tan(Nabor * Math.PI / 180);
                    }
                    break;
            }
            Znak_Function = null;
            Console.WriteLine("cos/sin/tg/ctg(nabor)=" + Nabor);
        }
        void DeistvieFindTheResult()
        {

            if (Znak_2 == "*" || Znak_2 == "/")
            {
                Deistvie2();
                Znak_2 = null;
            }
            Deistvie();
            Znak = null;

        }
        void MemoryUP_L1()
        {
            MemoryL1_Result = Result;
            Result = 0;
            MemoryL1_Result_2 = Result_2;
            Result_2 = 0;
            MemoryL1_Znak = Znak;
            Znak = null;
            MemoryL1_Znak_2 = Znak_2;
            Znak_2 = null;
            MemoryL1_Znak_Function = Znak_Function;
            Znak_Function = null;
        }
        void MemoryDOWN_L1()
        {
            DeistvieFindTheResult();
            Nabor = Result;
            Result = 0;

            Result = MemoryL1_Result;
            MemoryL1_Result = 0;
            Result_2 = MemoryL1_Result_2;
            MemoryL1_Result_2 = 0;
            Znak = MemoryL1_Znak;
            MemoryL1_Znak = null;
            Znak_2 = MemoryL1_Znak_2;
            MemoryL1_Znak_2 = null;
            Znak_Function = MemoryL1_Znak_Function;
            MemoryL1_Znak_Function = null;

            Chislo = null;

            Console.WriteLine("         mem down_1 Result=" + Result);
            Console.WriteLine("         mem down_1 Result_2=" + Result_2);
            Console.WriteLine("         mem down_1 Znak=" + Znak);
            Console.WriteLine("         mem down_1 Znak_2=" + Znak_2);
            Console.WriteLine("         mem down_1 Nabor=" + Nabor);
        }
        void MemoryUP_L2()
        {
            MemoryL2_Result = Result;
            Result = 0;
            MemoryL2_Result_2 = Result_2;
            Result_2 = 0;
            MemoryL2_Znak = Znak;
            Znak = null;
            MemoryL2_Znak_2 = Znak_2;
            Znak_2 = null;
            MemoryL2_Znak_Function = Znak_Function;
            Znak_Function = null;
        }
        void MemoryDOWN_L2()
        {
            DeistvieFindTheResult();
            Nabor = Result;
            Result = 0;

            Result = MemoryL2_Result;
            MemoryL2_Result = 0;
            Result_2 = MemoryL2_Result_2;
            MemoryL2_Result_2 = 0;
            Znak = MemoryL2_Znak;
            MemoryL2_Znak = null;
            Znak_2 = MemoryL2_Znak_2;
            MemoryL2_Znak_2 = null;
            Znak_Function = MemoryL2_Znak_Function;
            MemoryL2_Znak_Function = null;

            Chislo = null;

            Console.WriteLine("         mem down_2 Result=" + Result);
            Console.WriteLine("         mem down_2 Result_2=" + Result_2);
            Console.WriteLine("         mem down_2 Znak=" + Znak);
            Console.WriteLine("         mem down_2 Znak_2=" + Znak_2);
            Console.WriteLine("         mem down_2 Nabor=" + Nabor);
        }
        void MemoryUP_L3()
        {
            MemoryL3_Result = Result;
            Result = 0;
            MemoryL3_Result_2 = Result_2;
            Result_2 = 0;
            MemoryL3_Znak = Znak;
            Znak = null;
            MemoryL3_Znak_2 = Znak_2;
            Znak_2 = null;
            MemoryL3_Znak_Function = Znak_Function;
            Znak_Function = null;
        }
        void MemoryDOWN_L3()
        {
            DeistvieFindTheResult();
            Nabor = Result;
            Result = 0;

            Result = MemoryL3_Result;
            MemoryL3_Result = 0;
            Result_2 = MemoryL3_Result_2;
            MemoryL3_Result_2 = 0;
            Znak = MemoryL3_Znak;
            MemoryL3_Znak = null;
            Znak_2 = MemoryL3_Znak_2;
            MemoryL3_Znak_2 = null;
            Znak_Function = MemoryL3_Znak_Function;
            MemoryL3_Znak_Function = null;

            Chislo = null;

            Console.WriteLine("         mem down_3 Result=" + Result);
            Console.WriteLine("         mem down_3 Result_2=" + Result_2);
            Console.WriteLine("         mem down_3 Znak=" + Znak);
            Console.WriteLine("         mem down_3 Znak_2=" + Znak_2);
            Console.WriteLine("         mem down_3 Nabor=" + Nabor);
        }
        public void Calculation(string Value)
        {
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
                    case 'c':
                    case 'o':
                    case 's':
                    case 'i':
                    case 'n':
                    case 't':
                    case 'g':
                        {
                            Znak_Function = Znak_Function + Convert.ToString(Value[i]);
                        }
                        break;
                    case '(':
                        {
                            CounterBrackets++;
                            if (CounterBrackets == 1)
                                MemoryUP_L1();
                            else if (CounterBrackets == 2)
                                MemoryUP_L2();
                            else if (CounterBrackets == 3)
                                MemoryUP_L3();
                        }
                        break;
                    case ')':
                        {
                            if (CounterBrackets == 1)
                                MemoryDOWN_L1();
                            else if (CounterBrackets == 2)
                                MemoryDOWN_L2();
                            else if (CounterBrackets == 3)
                                MemoryDOWN_L3();
                            if (Znak_Function != null)
                            {
                                DeistvieFunction();
                            }
                            CounterBrackets--;

                        }
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
            DeistvieFindTheResult();
            Console.WriteLine("Ответ:");
            Console.WriteLine(Value + " = " + Result);
            Result = 0;
        }
        
    }
}
