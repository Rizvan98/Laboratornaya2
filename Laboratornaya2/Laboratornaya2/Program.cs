using System;

namespace Laboratornaya2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 - пример с sin \n" +
                "2 - пример без sin \n";

            Console.Write(text + "Введите одно из двух значений > ");
            int result = Convert.ToInt32(Console.ReadLine());

            switch(result)
            {
                case 1: { Console.WriteLine("j = - sin^3(y)/1*3 + sin^5(x^2)/3*5 - sin^7(y^3)/5*7+sin^9(x^4)/7*9"); break; }
                case 2: { Console.WriteLine("j = - y/1*3 + x^2/3*5 - y^3/5*7 + x^4/7*9"); break; }
                default: { Console.WriteLine("Неверное значение"); break; }
            }
        }
    }
}
