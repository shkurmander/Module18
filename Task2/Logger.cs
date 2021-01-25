using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Logger : ILogger
    {
       
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.WriteLine(message);
        }
    }
}
