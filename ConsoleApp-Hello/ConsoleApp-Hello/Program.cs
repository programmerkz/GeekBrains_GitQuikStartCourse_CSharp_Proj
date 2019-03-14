using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // вывести слово Привет на экран и ожидать нажания клавиши Enter

            Console.WriteLine("Privet! " + Class1.MY_NAME);
            Console.WriteLine("\r\n press Enter to continue");
            Console.ReadLine();
        }
    }
}
