using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = 'a'; //ASCII kod değerini verir.((') tek tırnak kullanılır.)
            bool condition = false;
            decimal number6 = 10.4m;//ondalıklı değer verebilmek için 'm' ifadesi eklenir.
            double number5 = 10;
            byte number4 = 255;
            short number3 = 3267;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;

            var number7 = 10; //verilen değerin değer tipini "var" verir.

            Console.WriteLine("Number1 is  {0}", number1);
            Console.WriteLine("Number2 is  {0}", number2);
            Console.WriteLine("Number3 is  {0}", number3);
            Console.WriteLine("Number4 is  {0}", number4);
            Console.WriteLine("Number5 is  {0}", number5);
            Console.WriteLine("Number5 is  {0}", number6);
            Console.WriteLine(Days.Friday); //enum sabitleri ((int)Days.Friday) Days lerin 4. index değerini verir.
            Console.WriteLine("Character is {0}", (int)character);



            Console.ReadLine();
        }
    }
    enum Days   //verilen değerlerin bağımlılığından kurtulmak için kullanılır.
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Sunday
    }
}
