using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double Sum(double in1, double in2)
        {
            double out1 = in1 + in2;
            return out1;
        }
        public double Dif(double in1, double in2)
        {
            double out1 = in1 - in2;
            return out1;
        }
        public double Mult(double in1, double in2)
        {
            double out1 = in1 * in2;
            return out1;
        }
        public double Div(double in1, double in2)
        {
            double out1 = in1 * in2;
            return out1;
        }
    }
    class Program
    {
            static void Main(string[] args)
            {
                string state = "Yes";
                Console.WriteLine("Это калькулятор. Он производит математические операции с двумя числами");
                while (state == "Yes")
                {
                    try
                    {
                        double a;
                        double b;
                        char oper;
                        double c;
                        Calc s = new Calc();
                        Console.WriteLine("Введите первое число:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Какую операцию проведем? \n + | Сложение \n - | Вычитание \n * | Умножение \n / | Деление");
                        oper = Convert.ToChar(Console.ReadLine());
                        if (oper == '+')
                        {
                            c = s.Sum(a, b);
                            Console.WriteLine("Результат сложения: " + c);
                        }
                        else if (oper == '-')
                        {
                            c = s.Dif(a, b);
                            Console.WriteLine("Результат вычитания: " + c);
                        }
                        else if (oper == '*')
                        {
                            c = s.Mult(a, b);
                            Console.WriteLine("Результат умножения: " + c);
                        }
                        else if (oper == '/')
                        {
                            c = s.Div(a, b);
                            Console.WriteLine("Результат разности: " + c);
                        }
                        else
                            Console.WriteLine("Выбран оператор не из списка. \nПроверьте, оператор указан корректно!");
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "Входная строка имела неверный формат.")
                        {
                            Console.WriteLine("Вы указали не число, или не оператор. \nПроверьте, что число и оператор указаны корректно!");
                        }
                    }
                    finally
                    {
                        Console.WriteLine("Чтобы посчитать еще раз, введите 'Yes'");
                        state = Console.ReadLine();
                    }
                }
            }
        }
    }

  
