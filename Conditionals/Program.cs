﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;


            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is not 10");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            //Console.WriteLine(number == 10 ? "Number is : 10" : "Number is not 10");    //kısa hali (single line)


            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;

            //}

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0 to 100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 100 to 200");

            //}
            //else if (number > 200 || number < 0) // "||" veya anlamını taşır.
            //{
            //    Console.WriteLine("Number is less than 0 or greater then 200");
            //}

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    Console.WriteLine("Number is between 90 and 95");
                }
            }

            Console.ReadLine();
        }
    }
}
