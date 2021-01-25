using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Result : IOperation
    {
        public int Sum(int val1, int val2)
        {
            return val1 + val2;
        }
    }
    class ConsoleUI
    {

        public void Start()
        {
                      

            bool exit = false;
            do
            {
               
                try
                {
                    Console.WriteLine("Введите первое число:");
                    var val1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    var val2 = Convert.ToInt32(Console.ReadLine());
                    IOperation result = new Result();
                    Console.WriteLine($"Результат: {val1} + {val2} = {result.Sum(val1, val2)}");

                }
                catch (FormatException)
                {

                    Console.WriteLine("Некорректный ввод, введите целое число");
                }
                
                finally
                {

                    Console.WriteLine("_________________________\n");

                    Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;
                }

            } while (!exit);

        }
    }
}
